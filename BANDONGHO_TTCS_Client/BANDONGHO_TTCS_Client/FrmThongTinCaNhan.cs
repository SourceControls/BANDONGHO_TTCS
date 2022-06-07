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
    public partial class FrmThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bdsKhachHangSearch = new BindingSource();
        public FrmThongTinCaNhan()
        {
            InitializeComponent();
        
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhachHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void FrmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dSet.KHACHHANG);

            bdsKhachHang.Filter = "MAKH  = '" + Program.maKH + "'";
            try {
            bdsKhachHangSearch.DataSource = dSet.KHACHHANG;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            if(hoTen.Length == 0 || sdt.Length == 0)
            {
                MessageBox.Show("Họ tên và số điện thoại không được để trống!");
                return;
            }

            int index = bdsKhachHangSearch.Find("SDT", sdt);
            if (index != -1)
            {
                String foundMaKh = ((DataRowView)bdsKhachHangSearch[index])["MAKH"].ToString().Trim();
                if (foundMaKh != Program.maKH.Trim())
                {
                    MessageBox.Show("Số điện thoại đã được người khác đăng kí!");
                    return;
                }

            }
            if(email.Length != 0)
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng!");
                return;
            }
            try
            {
                Program.SDT = sdt;
                Program.hoTen = hoTen;
                bdsKhachHang.EndEdit();
                kHACHHANGTableAdapter.Update(dSet.KHACHHANG);
                bdsKhachHang.ResetCurrentItem();
                //bdsKhachHangSearch.ResetCurrentItem();
                MessageBox.Show("Lưu thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

    }
}