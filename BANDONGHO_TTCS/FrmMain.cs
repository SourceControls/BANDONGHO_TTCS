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


        }

        public void phanQuyen()
        {


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
        }

        private void openUCPhieuNhap()
        {
            if(!container.Controls.Contains(UCPhieuNhap.Instance))
            {
                this.container.Controls.Add(UCPhieuNhap.Instance);
            }
            UCPhieuNhap.Instance.Dock = DockStyle.Fill;
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
            Program.fLogin.clearData();
            Program.fLogin.Show();
            this.Dispose();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.fLogin.Close();
        }
        public void remove_UCPhieuNhap()
        {
            this.container.Controls.Remove(UCPhieuNhap.Instance);
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(UCHoaDon.Instance))
            {
                this.container.Controls.Add(UCHoaDon.Instance);
            }
                UCHoaDon.Instance.Dock = DockStyle.Fill;
            UCHoaDon.Instance.BringToFront();
        }

        public void remove_UCHoaDon()
        {
            this.container.Controls.Remove(UCHoaDon.Instance);
        }
        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(UCBackUpRestore.Instance))
            {
                this.container.Controls.Add(UCBackUpRestore.Instance);
            }
            UCBackUpRestore.Instance.Dock = DockStyle.Fill;
            UCBackUpRestore.Instance.BringToFront();
        }

        public void remove_UCRestore()
        {
            this.container.Controls.Remove(UCBackUpRestore.Instance);
        }

        private void container_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            sttHoTen.Text = "Họ Tên: " + Program.mHoTen;
            sttMaNV.Text = "Mã NV: " + Program.login;
            sttChucVu.Text = "Chức vụ: " + Program.mGroup;
            if (Program.mGroup.ToUpper().Trim() == "NHANVIEN")
            {
                accordionControlElement6.Visible = false;
                accordionControlElement5.Visible = false;
                accordionControlElement9.Visible = false;
                accordionControlElement10.Visible = false;
            }
            else if (Program.mGroup.ToUpper().Trim() == "QUANLY")
            {
                accordionControlElement6.Visible = true;
                accordionControlElement5.Visible = true;
                accordionControlElement9.Visible = true;
                accordionControlElement10.Visible = true;
            }
        }
    }
}
