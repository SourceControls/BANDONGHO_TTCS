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
    public partial class FrmDatHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSet.V_CT_GIO_HANG' table. You can move, or remove it, as needed.
            this.v_CT_GIO_HANGTableAdapter.Fill(this.dSet.V_CT_GIO_HANG);
            // TODO: This line of code loads data into the 'dSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dSet.KHACHHANG);
            // TODO: This line of code loads data into the 'dSet.PHIEUDAT' table. You can move, or remove it, as needed.
            bdsKhachHang.Filter = "MAKH = '" + Program.maKH.Trim() + "'";
            bdsCTGH.Filter = "MAKH = '" + Program.maKH.Trim() + "'";
            if (bdsKhachHang.Count == 0)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                this.Close();
                return;
            }

            txtHoTen.Text = ((DataRowView)bdsKhachHang[0])["HOTENKH"].ToString();
            txtSDT.Text = ((DataRowView)bdsKhachHang[0])["SDT"].ToString();
            txtDiaChi.Text = ((DataRowView)bdsKhachHang[0])["DIACHI"].ToString();
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            


            double tongTien = 0;
            for(int i = 0; i < bdsCTGH.Count; i++)
            {
                tongTien += int.Parse(((DataRowView)bdsCTGH[i])["SOLUONG"].ToString()) * double.Parse(((DataRowView)bdsCTGH[i])["DONGIA"].ToString());
            }
            lbTongTien.Text = "Tổng: " + tongTien.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            if(hoTen.Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống");
                return;
            }
            if (hoTen.Length == 0)
            {
                MessageBox.Show("SDT không được để trống");
                return;
            }
            if(diaChi.Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống");
                return;
            }
            string cmd = "EXEC SP_DAT_HANG '" + Program.maKH.Trim()
                +"',N'" + hoTen + "','" + sdt + "',N'" + diaChi +"'";
            if (Program.execSqlNonQuery(cmd))
            {
                MessageBox.Show("Đặt hàng thành công!");
                this.Close();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (pbHinhAnh.Image != null)
                pbHinhAnh.Image.Dispose();
            pbHinhAnh.Image = Image.FromFile(((DataRowView)bdsCTGH[bdsCTGH.Position])["HINHANH"].ToString());

        }
    }
}