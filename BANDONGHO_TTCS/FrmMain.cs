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
        private void openTestControll()
        { 
            //code mở control
            //lưu ý: trong mỗi class phải định nghĩa 1 thuộc tính Instance (xem code trong testControl)
            if (!container.Controls.Contains(testControl.Instance))
                    this.container.Controls.Add(testControl.Instance);
            testControl.Instance.Dock = DockStyle.Fill;
            testControl.Instance.BringToFront();
            testControl.Instance.BringToFront();
        }

        private void openUCPhieuNhap()
        {
            if(!container.Controls.Contains(UCPhieuNhap.Instance))
            {
                this.container.Controls.Add(UCPhieuNhap.Instance);
<<<<<<< HEAD
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
=======
                UCPhieuNhap.Instance.Dock = DockStyle.Fill;
                UCPhieuNhap.Instance.BringToFront();
            }
        }
>>>>>>> parent of c394127 (hùng)

        public void closeAllForm()
        {

        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            openTestControll();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            openUCPhieuNhap();
        }
<<<<<<< HEAD

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
        public void remove_UCPhieuNhap()
        {
            this.container.Controls.Remove(UCPhieuNhap.Instance);
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(UCHoaDon.Instance))
            {
                this.container.Controls.Add(UCHoaDon.Instance);
                UCHoaDon.Instance.Dock = DockStyle.Fill;
                UCHoaDon.Instance.BringToFront();
                UCHoaDon.Instance.BringToFront();
            }
        }

        public void remove_UCHoaDon()
        {
            this.container.Controls.Remove(UCHoaDon.Instance);
        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(UCBackup.Instance))
            {
                this.container.Controls.Add(UCBackup.Instance);
                UCBackup.Instance.Dock = DockStyle.Fill;
                UCBackup.Instance.BringToFront();
                UCBackup.Instance.BringToFront();
            }
        }

        public void remove_UCBackup()
        {
            this.container.Controls.Remove(UCBackup.Instance);
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(UCRestore.Instance))
            {
                this.container.Controls.Add(UCRestore.Instance);
                UCRestore.Instance.Dock = DockStyle.Fill;
                UCRestore.Instance.BringToFront();
                UCRestore.Instance.BringToFront();
            }
        }

        public void remove_UCRestore()
        {
            this.container.Controls.Remove(UCRestore.Instance);
        }
=======
>>>>>>> parent of c394127 (hùng)
    }
}
