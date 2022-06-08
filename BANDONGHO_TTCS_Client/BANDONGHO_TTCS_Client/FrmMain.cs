using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BANDONGHO_TTCS_Client
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        public void phanQuyen()
        {
            container.Controls.Clear();
            sttHoTenKH.Text = "Họ tên: " + Program.hoTen;
            if (Program.maKH.Length == 0)
            {
                accordionControlElement3.Visible = true;
                accordionControlElement9.Visible = true;
                accordionControlElement4.Visible = false;
                accordionControlElement6.Visible = false;
                accordionControlElement7.Visible = false;
                accordionControlElement8.Visible = false;
                accordionControlElement11.Visible = false;

            }
            else
            {
                accordionControlElement3.Visible = false;
                accordionControlElement9.Visible = false;
                accordionControlElement4.Visible = true;
                accordionControlElement6.Visible = true;
                accordionControlElement7.Visible = true;
                accordionControlElement8.Visible = true;
                accordionControlElement11.Visible = true;
            }
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(UCTrangChu.Instance))
            {
                this.container.Controls.Add(UCTrangChu.Instance);

            }
            UCTrangChu.Instance.Dock = DockStyle.Fill;
            UCTrangChu.Instance.BringToFront();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            Program.maKH = "";
            Program.SDT = "";
            Program.matKhau = "";
            phanQuyen();
            (new FrmLogin()).ShowDialog(this);
        }

            private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            (new FrmDoiMatKhau()).ShowDialog(this);
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            (new FrmGioHang()).ShowDialog(this);

        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(UCDonDatHang.Instance))
            {
                this.container.Controls.Add(UCDonDatHang.Instance);

            }
            UCDonDatHang.Instance.Dock = DockStyle.Fill;
            UCDonDatHang.Instance.BringToFront();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            (new FrmThongTinCaNhan()).ShowDialog(this);

        }

        private void accordionControlElement9_Click(object sender, EventArgs e)
        {
            (new FrmLogin()).ShowDialog(this);

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            phanQuyen();
            accordionControlElement5_Click(sender, e);


        }

        private void container_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            (new FrmDangKi()).ShowDialog(this);
        }
    }
}
