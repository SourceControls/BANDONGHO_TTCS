using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANDONGHO_TTCS
{
    public partial class FrmLogRestore : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogRestore()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool isSuccess = true;

            if (Program.connectToMaster() == 0)
            {
                return;
            }

            Program.closeConnection();
            Program.setSingleUser();

            string restoreCmd = "RESTORE LOG " + Program.database + " FROM DISK = '" +
               Program.URL_BACKUP + "\\" + Program.LOG_BK_FILE_NAME + "' WITH STOPAT = '" +
             dpPointTime.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            try
            {
                UCBackUpRestore.Instance.restoreFromFullBKBeforeRestoreLog();
                UCBackUpRestore.Instance.restoreFromDFBKBeforeRestoreLog();
            } catch (Exception)
            {
                // restore from full backup with mode norecovery
                UCBackUpRestore.Instance.restoreFromFullBKBeforeRestoreLog();
                // Nếu restore lỗi từ bản backup differential thì thử restore từ bản log backup
            } finally
            {
                try
                {
                    Program.excuteCommandBKAndRestore(restoreCmd);
                }
                catch (Exception exLog)
                {
                    // Nếu restore lỗi từ bản log backup thì roll back về bản differential backup
                    isSuccess = false;
                    MessageBox.Show("Restore từ bản log backup lỗi," +
                            "thử restore về bản differential backup mới nhất!\n" + exLog.Message); ;
                    try
                    {
                        UCBackUpRestore.Instance.restoreFromDFBK();
                    } catch (Exception exFull)
                    {
                        MessageBox.Show(exFull.Message);
                    }
                } finally
                {
                    // Trường hợp database bị restoring...dđ
                    if(Program.connectToDB() == 0)
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình restore từ bản log backup, " +
                            "vui lòng chọn lại một thòi điểm thích hợp!\n Hệ thống đang rollback về " +
                            "bản differential backup mới nhất");
                        isSuccess = false;
                        try
                        {
                            Program.connectToMaster();
                            UCBackUpRestore.Instance.restoreFromDFBK();
                        } catch (Exception exRollback)
                        {
                            MessageBox.Show(exRollback.Message);
                        } finally
                        {
                            Program.connectToDB();
                            Program.setMultiUser();
                        }
                    }
                    if(isSuccess)
                    {
                        MessageBox.Show("Restore sucessful!");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}