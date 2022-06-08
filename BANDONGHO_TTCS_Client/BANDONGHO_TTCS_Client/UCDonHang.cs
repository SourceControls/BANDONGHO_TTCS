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
    public partial class UCDonDatHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static UCDonDatHang _instance;
        public static UCDonDatHang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCDonDatHang();
                }
                return _instance;
            }
        }
        public UCDonDatHang()
        {
            InitializeComponent();

        }

        private void UCDonDatHang_Load(object sender, EventArgs e)
        {
            this.pHIEUDATTableAdapter.Fill(this.dSet.PHIEUDAT);
            bdsPhieuDat.DataSource = dSet.PHIEUDAT;
            bdsChiTiet.DataSource = dSet.sp_lay_ct_pd;
            bdsPhieuDat.Filter = "MAKH = '" + Program.maKH.Trim() + "'";
            pbHinhAnh1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsChiTiet.Position == -1)
            {
                return;
            }

            if (pbHinhAnh1.Image != null)
                pbHinhAnh1.Image.Dispose();

            pbHinhAnh1.Image = Image.FromFile(((DataRowView)bdsChiTiet[bdsChiTiet.Position])["HINHANH"].ToString());
            

        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(bdsPhieuDat.Position == -1)
            {
                return;
            }
            try
            {
                int maPhieuDat = int.Parse(((DataRowView)bdsPhieuDat[bdsPhieuDat.Position])["MAPHIEUDAT"].ToString());
                this.sp_lay_ct_pdTableAdapter.Fill(this.dSet.sp_lay_ct_pd, maPhieuDat);
                double tongTien = 0;
                for (int i = 0; i < bdsChiTiet.Count; i++)
                {
                    tongTien += int.Parse(((DataRowView)bdsChiTiet[i])["SOLUONG"].ToString()) * double.Parse(((DataRowView)bdsChiTiet[i])["DONGIA"].ToString());
                }
                lbTongTien.Text = "Tổng: " + tongTien.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
    
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pHIEUDATTableAdapter.Fill(this.dSet.PHIEUDAT);
            bdsPhieuDat.Filter = "MAKH = '" + Program.maKH.Trim() + "'";

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int maPhieuDat = int.Parse(((DataRowView)bdsPhieuDat[bdsPhieuDat.Position])["MAPHIEUDAT"].ToString());

            String cmd = "EXEC SP_HUY_PHIEU_DAT_CLIENT "+ maPhieuDat.ToString();
            if (Program.execSqlNonQuery(cmd))
            {
                MessageBox.Show("Hủy phiếu đặt thành công!");

            }
            this.pHIEUDATTableAdapter.Fill(this.dSet.PHIEUDAT);
        }

        private void pbHinhAnh1_Click(object sender, EventArgs e)
        {

        }
    }
}
