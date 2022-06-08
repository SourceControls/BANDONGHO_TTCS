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
    public partial class FrmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //check ràng buộc nhập liệu
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();
            if(matKhauCu.Length == 0 || matKhauMoi.Length == 0 || nhapLaiMatKhau.Length == 0)
            {
                MessageBox.Show("Không được để trống bất kì 1 trường thông tin nào!");
                return;
            }
            if(matKhauMoi != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
                return;
            }
            if(matKhauCu != Program.password)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }
            //bắt đầu đổi mật khẩu
            if(Program.execSqlNonQuery("alter login " +Program.login + " with password = '" + matKhauMoi+"'"))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Program.password = matKhauMoi;
                if(Program.connectToDB() == -1)
                {
                    Program.fLogin.Close();
                }
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}