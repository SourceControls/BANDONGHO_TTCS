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
                UCPhieuNhap.Instance.Dock = DockStyle.Fill;
                UCPhieuNhap.Instance.BringToFront();
            }
        }

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
            }
        }

        public void remove_UCHoaDon()
        {
            this.container.Controls.Remove(UCHoaDon.Instance);
        }

    }
}
