using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BANDONGHO_TTCS
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public FrmMain()
        {
            InitializeComponent();
            sttHoTen.Text = "Họ Tên: " + Program.mHoTen;
            sttMaNV.Text = "Mã NV: " + Program.login;
        }
        private void openTestControll()
        { 
            //code mở control
            //lưu ý: trong mỗi class phải định nghĩa 1 thuộc tính Instance (xem code trong testControl)
            if (!container.Controls.Contains(testControl.Instance))
            {
                this.container.Controls.Add(testControl.Instance);
            }
            testControl.Instance.Dock = DockStyle.Fill;
            testControl.Instance.BringToFront();
            testControl.Instance.BringToFront();
        }
        private void openUCNhanVien()
        {
            //code mở control
            //lưu ý: trong mỗi class phải định nghĩa 1 thuộc tính Instance (xem code trong testControl)
            if (!container.Controls.Contains(UCNhanVien.Instance))
            {
                this.container.Controls.Add(UCNhanVien.Instance);

            }
            UCNhanVien.Instance.Dock = DockStyle.Fill;
            UCNhanVien.Instance.BringToFront();
            UCNhanVien.Instance.BringToFront();
        }

        private void openUCPhieuNhap()
        {
            if(!container.Controls.Contains(UCPhieuNhap.Instance))
            {
                this.container.Controls.Add(UCPhieuNhap.Instance);
                UCPhieuNhap.Instance.Dock = DockStyle.Fill;
            }
            UCPhieuNhap.Instance.BringToFront();

        }
        private void openUCDongHo()
        {
            if (!container.Controls.Contains(UCDongHo.Instance))
            {
                this.container.Controls.Add(UCDongHo.Instance);
            }
            UCDongHo.Instance.Dock = DockStyle.Fill;
            UCDongHo.Instance.BringToFront();
            UCDongHo.Instance.BringToFront();

        }
        public void closeAllForm()
        {


        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            openUCNhanVien();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            openUCPhieuNhap();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            openUCDongHo();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            (new FrmDoiMatKhau()).ShowDialog(this);

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.fLogin.clearData();
            Program.fLogin.Show();
            container.Controls.Clear();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fLogin.Close();
        }
    }
}
