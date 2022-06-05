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

       

        private void FrmLogRestore_Load(object sender, EventArgs e)
        {
            this.dSet.EnforceConstraints = false;
            this.sp_get_point_timeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_get_point_timeTableAdapter.Fill(this.dSet.sp_get_point_time);

            if(sp_get_point_timeBindingSource.Count == 0)
            {
                btnOk.Enabled = false;
            }
        }

        private void restoreFromFullAndDFBackup(object sender, EventArgs e)
        {
            try
            {
                UCRestore.Instance.restoreFromFullBKBeforeRestoreLog_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UCRestore.Instance.restoreFromDFBKBeforeRestoreLog_Click(sender, e);
        }

        private string convertDate2DateInSQL(string date)
        {
            string[] splitDateAndTime = date.Split(' ');
            string[] splitDate = splitDateAndTime[0].Split('/');

            return splitDate[2] + '-' + splitDate[1] + '-' + splitDate[0] + ' ' + splitDateAndTime[1];
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Program.connectToMaster() == 0)
            {
                return;
            }

            Program.closeConnection();

            string restoreCmd = "RESTORE LOG " + Program.database + " FROM DISK = '" +
               Program.URLBackup + "\\" + Program.logBKfileName + "' WITH STOPAT = '" + 
               convertDate2DateInSQL(cmbPointTime.Text) + "'";
            try
            {
                restoreFromFullAndDFBackup(sender, e);
            } catch (Exception)
            {
                // Nếu restore lỗi từ bản backup differential thì thử restore từ bản log backup
            } finally
            {
                try
                {
                    Program.excuteCommandBKAndRestore(restoreCmd);
                    MessageBox.Show("Restore sucessful!");
                }
                catch (Exception exLog)
                {
                    // Nếu restore lỗi từ bản log backup thì roll back về bản full backup
                    UCRestore.Instance.restoreFromFullBK();
                    MessageBox.Show(exLog.Message);
                } finally
                {
                    if(Program.connectToDB() == 0)
                    {
                        try
                        {
                            restoreFromFullAndDFBackup(sender, e);
                        } catch (Exception)
                        {

                        }
                        MessageBox.Show("Restore with log backup fail!");
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