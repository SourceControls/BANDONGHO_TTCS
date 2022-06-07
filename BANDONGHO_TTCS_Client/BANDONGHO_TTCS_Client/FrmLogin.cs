using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BANDONGHO_TTCS_Client
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static FrmMain fMain;
        public void clearData()
        {
            txtMatKhau.Text = "";
                
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SDT = txtTenDangNhap.Text.Trim();
            string matKhau  = txtMatKhau.Text.Trim();
            if(SDT.Length == 0 || SDT.Length == 0 || matKhau.Contains(" "))
            {
                MessageBox.Show("Tên Đăng Nhập Và Mật Khẩu Không Được Để Trống Và Không Được Chứa Khoảng Cách");
                return;
            }
            else
            {
                String cmd = "EXEC SP_DANG_NHAP_CLIENT '" + SDT + "','" + matKhau + "'";
                SqlDataReader myReader = Program.ExecSqlDataReader(cmd);
                if (myReader == null)
                {
                    return;
                }
                else if (myReader.HasRows)
                {
                    myReader.Read();
                    Program.maKH = myReader.GetString(0).Trim();
                    Program.hoTen = myReader.GetString(1).Trim();
                    Program.SDT = SDT;
                    Program.matKhau = matKhau;
                    this.Visible = false;
                    Program.frmMain.phanQuyen();
                }

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }
    }

}
