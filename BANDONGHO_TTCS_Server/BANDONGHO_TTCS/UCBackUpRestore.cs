using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANDONGHO_TTCS
{
    public partial class UCBackUpRestore : DevExpress.XtraEditors.XtraUserControl
    {
        public UCBackUpRestore()
        {
            InitializeComponent();
        }

        private static UCBackUpRestore _instance;
        public static UCBackUpRestore Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UCBackUpRestore();
                }
                return _instance;
            }
        }

        public void restoreFromFullBK() {
            string restoreCmd = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
           Program.URL_BACKUP + "\\" + Program.FULL_BK_FILE_NAME + "' WITH REPLACE";
            try
            {
                Program.excuteCommandBKAndRestore(restoreCmd);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void restoreFromDFBK()
        {
            string restoreCmd1 = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
            Program.URL_BACKUP + "\\" + Program.FULL_BK_FILE_NAME + "' WITH REPLACE, NORECOVERY";

            string restoreCmd2 = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
            Program.URL_BACKUP + "\\" + Program.DIFF_BK_FILE_NAME + "'";

            try {
                Program.excuteCommandBKAndRestore(restoreCmd1);
                Program.excuteCommandBKAndRestore(restoreCmd2);
            } catch (Exception ex)
            {
                try
                {
                    restoreFromFullBK(); // rollback về bản full backup
                } catch(Exception exFull)
                {
                    throw new Exception(exFull.Message);
                }
                throw new Exception("Restore từ bản differential backup thất bại," +
                    " rollback về bản full backup mới nhất!\n" + ex.Message);
            } 
        }
        private void restoreFromFullBackupHandler()
        {
            if (Program.connectToMaster() == 0)
            {
                return;
            }

            Program.closeConnection();

            try
            {
                restoreFromFullBK();
                MessageBox.Show("Restore successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Program.connectToDB();
            }
        }

        private void restoreFromDFBackupHandler()
        {
            if (Program.connectToMaster() == 0)
            {
                return;
            }

            Program.closeConnection();

            try
            {
                restoreFromDFBK();
                MessageBox.Show("Restore successful!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Program.connectToDB();
            }
        }

        // Full Restore with mode norecovery
        public void restoreFromFullBKBeforeRestoreLog()
        {
            string restoreCmd = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
                Program.URL_BACKUP + "\\" + Program.FULL_BK_FILE_NAME + "' WITH REPLACE, NORECOVERY";

            try
            {
                Program.excuteCommandBKAndRestore(restoreCmd);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Differential Restore with mode norecovery
        public void restoreFromDFBKBeforeRestoreLog()
        {
            string restoreCmd = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
                Program.URL_BACKUP + "\\" + Program.DIFF_BK_FILE_NAME + "' WITH NORECOVERY";

            try
            {
                Program.excuteCommandBKAndRestore(restoreCmd);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void openLogRestoreForm()
        {
            FrmLogRestore frmLogRestore = new FrmLogRestore();
            frmLogRestore.Show();
        }

        private void initBDS()
        {
            dSet.EnforceConstraints = false;
            backupHistoryAdapter.Connection.ConnectionString = Program.connstr;
            backupHistoryAdapter.Fill(dSet.sp_get_backup_history);
        }

        private void UCRestore_Load(object sender, EventArgs e)
        {
            initBDS();

            cmbBackup.SelectedIndex = cmbRestore.SelectedIndex = 0;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLogin.fMain.remove_UCRestore();
            _instance = null;
        }

        private void fullBackup()
        {
            string bkCmd = "BACKUP DATABASE " + Program.database + " TO DISK = '" +
                Program.URL_BACKUP + "\\" + Program.FULL_BK_FILE_NAME + "' WITH INIT";

            if (Program.ExecSqlNonQuery(bkCmd))
            {
                MessageBox.Show("Full Backup successful!");

            }
        }

        private void diffBackup()
        {
            string checkHaveFullBackupCmd = "exec sp_check_have_full_bk";
            if (!Program.ExecSqlNonQuery(checkHaveFullBackupCmd))
            {
                return;
            }

            string bkCmd = "BACKUP DATABASE " + Program.database + " TO DISK = '" +
              Program.URL_BACKUP + "\\" + Program.DIFF_BK_FILE_NAME + "' WITH INIT, DIFFERENTIAL";

            if (Program.ExecSqlNonQuery(bkCmd))
            {
                MessageBox.Show("Differential Backup successful!");
            }
        }

        private void logBackup()
        {
            string checkHaveFullBackupCmd = "exec sp_check_have_full_bk";
            if (!Program.ExecSqlNonQuery(checkHaveFullBackupCmd))
            {
                return;
            }
            string bkCmd = "BACKUP LOG " + Program.database + " TO DISK = '" +
            Program.URL_BACKUP + "\\" + Program.LOG_BK_FILE_NAME + "' WITH INIT, NO_TRUNCATE";

            if (Program.ExecSqlNonQuery(bkCmd))
            {
                MessageBox.Show("Log Backup successful!");
            }
        }

        private void btnBKCF_Click(object sender, EventArgs e)
        {
            string backupType = cmbBackup.Text.Trim();
            if(backupType.Equals("Full Backup"))
            {
                fullBackup();
            } else if(backupType.Equals("Differential Backup")) {
                diffBackup();
            } else if(backupType.Equals("Transaction Log Backup"))
            {
                logBackup();
            }
            backupHistoryAdapter.Connection.ConnectionString = Program.connstr;
            backupHistoryAdapter.Fill(dSet.sp_get_backup_history);
            bdsBackupHistory.Position = 0;
        }

        private void btnRSCF_Click(object sender, EventArgs e)
        {
            string checkHaveFullBackupCmd = "exec sp_check_have_full_bk";
            if (!Program.ExecSqlNonQuery(checkHaveFullBackupCmd))
            {
                return;
            }
            string restoreType = cmbRestore.Text.Trim();
            if (restoreType.Equals("Restore From Full Backup"))
            {
                restoreFromFullBackupHandler();
            }
            else if (restoreType.Equals("Restore From Differential Backup"))
            {
                restoreFromDFBackupHandler();
            }
            else if (restoreType.Equals("Restore From Transaction Log Backup"))
            {
                openLogRestoreForm();
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            initBDS();
        }
    }
}
