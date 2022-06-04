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
    public partial class UCBackup : DevExpress.XtraEditors.XtraUserControl
    {
        public UCBackup()
        {
            InitializeComponent();
        }

        private static UCBackup _instance;
        public static UCBackup Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UCBackup();
                }
                return _instance;
            }
        }

        private void btnFullBK_Click(object sender, EventArgs e)
        {
            string bkCmd = "BACKUP DATABASE " + Program.database + " TO DISK = '" +
                Program.URLBackup + "\\" + Program.fullBKfileName + "' with init";

            if(Program.execSqlNonQuery(bkCmd))
            {
                MessageBox.Show("Full Backup successful!");

            }
        }

        private void btnDFBK_Click(object sender, EventArgs e)
        {
            string checkHaveFullBackupCmd = "exec sp_check_have_full_bk";
            if (!Program.execSqlNonQuery(checkHaveFullBackupCmd))
            {
                return;
            }

            string bkCmd = "BACKUP DATABASE " + Program.database + " TO DISK = '" +
              Program.URLBackup + "\\" + Program.diffBKfileName + "' WITH INIT, DIFFERENTIAL";

            if (Program.execSqlNonQuery(bkCmd))
            {
                MessageBox.Show("Differential Backup successful!");
            }
        }

        private void btnLogBK_Click(object sender, EventArgs e)
        {
            string bkCmd = "BACKUP LOG " + Program.database + " TO DISK = '" +
            Program.URLBackup + "\\" + Program.logBKfileName + "' WITH INIT, NO_TRUNCATE";

            if (Program.execSqlNonQuery(bkCmd))
            {
                MessageBox.Show("Log Backup successful!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Program.fMain.remove_UCBackup();
            _instance = null;
        }
    }
}
