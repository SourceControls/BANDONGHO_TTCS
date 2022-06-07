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

namespace BANDONGHO_TTCS_Client
{
    public partial class FrmDangKi : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangKi()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string SDT = txtSDT.Text.Trim();
            string matKhau = txtMatKhauMoi.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();

            if(hoTen.Length == 0 || SDT.Length == 0 || matKhau.Length == 0 || nhapLaiMatKhau.Length == 0)
            {
                MessageBox.Show("Không được để trống bất kì thông tin nào");
                return;
            }
            if(matKhau.Contains(" "))
            { 
                MessageBox.Show("Mật khẩu không được chứa kí tự khoảng trắng!");
                return;
            }
            if(matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            string cmd = "EXEC sp_dang_ki_tai_khoan_client N'" + hoTen + "','" + SDT + "','" + matKhau + "'";
            if (Program.execSqlNonQuery(cmd))
            {
                MessageBox.Show("Đăng kí tài khoản thành công!");
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}