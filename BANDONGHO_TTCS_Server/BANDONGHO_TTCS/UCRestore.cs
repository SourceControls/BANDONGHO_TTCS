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
    public partial class UCRestore : DevExpress.XtraEditors.XtraUserControl
    {
        public UCRestore()
        {
            InitializeComponent();
        }

        private static UCRestore _instance;
        public static UCRestore Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UCRestore();
                }
                return _instance;
            }
        }

        private void btnRestoreFull_Click(object sender, EventArgs e)
        {
            if(Program.connectToMaster() == 0)
            {
                return;
            }
            Program.closeConnection();
           
            try
            {
                restoreFromFullBK();
                MessageBox.Show("Restore successful!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Program.connectToDB();
            }
        }

        public void restoreFromFullBK() {
            string restoreCmd = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
           Program.URLBackup + "\\" + Program.fullBKfileName + "' WITH REPLACE";

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
            Program.URLBackup + "\\" + Program.fullBKfileName + "' WITH REPLACE, NORECOVERY";

            string restoreCmd2 = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
            Program.URLBackup + "\\" + Program.diffBKfileName + "'";

            try {
                Program.excuteCommandBKAndRestore(restoreCmd1);
                Program.excuteCommandBKAndRestore(restoreCmd2);
            } catch (Exception ex)
            {
                restoreFromFullBK(); // rollback về bản full backup
                throw new Exception(ex.Message);
            } 
        }

        private void btnRestoreDF_Click(object sender, EventArgs e)
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
        public void restoreFromFullBKBeforeRestoreLog_Click(object sender, EventArgs e)
        {
            string restoreCmd = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
                Program.URLBackup + "\\" + Program.fullBKfileName + "' WITH REPLACE, NORECOVERY";

            try
            {
                Program.excuteCommandBKAndRestore(restoreCmd);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Differential Restore with mode norecovery
        public void restoreFromDFBKBeforeRestoreLog_Click(object sender, EventArgs e)
        {
            string restoreCmd = "RESTORE DATABASE " + Program.database + " FROM DISK = '" +
                Program.URLBackup + "\\" + Program.diffBKfileName + "' WITH NORECOVERY";

            try
            {
                Program.excuteCommandBKAndRestore(restoreCmd);
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnRestoreLog_Click(object sender, EventArgs e)
        {
            FrmLogRestore frmLogRestore = new FrmLogRestore();
            frmLogRestore.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmLogin.fMain.remove_UCRestore();
            _instance = null;
        }
    }
}
