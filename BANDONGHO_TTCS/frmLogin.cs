using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BANDONGHO_TTCS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static FrmMain fMain;

        public void clearData()
        {
            txtMatKhau.Text = "";
                
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Program.login = txtTenDangNhap.Text.Trim();
            Program.password  = txtMatKhau.Text.Trim();
            if(Program.login.Length == 0 || Program.password.Length == 0)
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Chứa Khoảng Cách Và Không Được Để Trống");
                return;
            }
            else
            {
                if(Program.connectToDB() == 1)
                {
                    this.Visible = false;
                    
                    if(fMain == null)
                    {
                        fMain = new FrmMain();
                    }
                    fMain.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc tài khoản bị khóa!");
                }

            }
            Program.login = "";

        }

    }

}
