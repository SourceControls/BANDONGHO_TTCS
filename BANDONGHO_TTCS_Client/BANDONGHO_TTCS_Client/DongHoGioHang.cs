using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANDONGHO_TTCS_Client
{
    public partial class DongHoGioHang : DevExpress.XtraEditors.XtraUserControl
    {

        public string maDH;
        public string ten;
        public string loai;
        public string hang;
        public string hinhAnh;
        public string moTa;
        public double gia;
        public double giamGia;
        public double giaSauGiam;
        public int slDat;
        public DongHoGioHang()
        {
            InitializeComponent();
        }
        public void initUI()
        {
            lbTen.Text = ten;
            lbLoai.Text = loai;
            lbHang.Text = hang;
            lbMoTa.Text = moTa;
            spinSLDat.Value = slDat;
            pbHinhAnh.Image = Image.FromFile(hinhAnh);
            pbHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            if (giamGia != -1)
            {
                lbGia.ForeColor = Color.FromArgb(255, 128, 128);
                lbGiaGoc.Text = gia.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
                lbGia.Text = giaSauGiam.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")) + "  (-" + giamGia.ToString() + "%)";
            }
            else
            {
                lbGia.Text = gia.ToString("C0", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            String cmd = "DELETE FROM CT_GIOHANG WHERE MAKH = '"+Program.maKH+"' AND MADH = '"+maDH+"'";
            if (Program.execSqlNonQuery(cmd))
            {
                this.Hide();
            }
        }

        private void spinSLDat_EditValueChanged(object sender, EventArgs e)
        {
            
 

        }

        private void spinEdit1_Properties_ValueChanged(object sender, EventArgs e)
        {

        }

        private void spinSLDat_Click(object sender, EventArgs e)
        {
            string cmd;
            int loai = 1;
            if (spinSLDat.Value == slDat)
                return;
            if (spinSLDat.Value < slDat)
            {
                loai = -1;
            }

            if (giamGia == -1)
                cmd = "EXEC SP_UPDATE_GIO_HANG '" + Program.maKH + "','" + maDH + "'," + gia + "," + loai;
            else
                cmd = "EXEC SP_UPDATE_GIO_HANG '" + Program.maKH + "','" + maDH + "'," + giaSauGiam + "," + loai;

            if (Program.execSqlNonQuery(cmd))
            {
                slDat = (int)spinSLDat.Value;
            }
            spinSLDat.Value = slDat;

        }
    }
}
