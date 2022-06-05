using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class UCHoaDon : DevExpress.XtraEditors.XtraUserControl
    {

        private static UCHoaDon _instance;
        public static UCHoaDon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCHoaDon();
                }
                return _instance;
            }
        }

        public UCHoaDon()
        {
            InitializeComponent();
        }

        private void initBDS()
        {
            this.dSet.EnforceConstraints = false;

            this.PDAdapter.Connection.ConnectionString = Program.connstr;
            this.PDAdapter.Fill(this.dSet.v_lay_phieu_dat);
        }

        private void pHIEUDATGridControl_Load(object sender, EventArgs e)
        {
            initBDS();

            if (bdsPD.Count == 0)
            {
                pcHD.Enabled = false;
            }
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            string[] dateTmp = ((DataRowView)bdsPD[bdsPD.Position])["NGAYDAT"].ToString().Trim().Split(' ')[0].Split('/');

            XrptHoaDon xrptHD = new XrptHoaDon(edtMaPD.Text.Trim());
            xrptHD.lbKH.Text = ((DataRowView)bdsPD[bdsPD.Position])["HOTENNGUOINHAN"].ToString().Trim();
            xrptHD.lbSDT.Text = ((DataRowView)bdsPD[bdsPD.Position])["SDTNGUOINHAN"].ToString().Trim();
            xrptHD.lbDC.Text = ((DataRowView)bdsPD[bdsPD.Position])["DIACHINGUOINHAN"].ToString().Trim();
            xrptHD.lbNV.Text = ((DataRowView)bdsPD[bdsPD.Position])["HOTENNV"].ToString().Trim();
            xrptHD.lbNgayDat.Text = ((DataRowView)bdsPD[bdsPD.Position])["NGAYDAT"].ToString().Trim().Split(' ')[0];

            ReportPrintTool rpt = new ReportPrintTool(xrptHD);
            rpt.ShowPreviewDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLogin.fMain.remove_UCHoaDon();
            _instance = null;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            initBDS();
        }
    }
}