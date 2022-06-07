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
    public partial class DongHo : DevExpress.XtraEditors.XtraUserControl
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
        public int slTon;

        public void initUI()
        {
            lbTen.Text = ten;
            lbLoai.Text = loai;
            lbHang.Text = hang;
            lbMoTa.Text = moTa;
            lbSoLuong.Text = slTon.ToString();
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

        //coppy từ đoạn này
        private static DongHo _instance;
        public static DongHo Instance
        { 
           get
           {
                if (_instance == null)
                    _instance = new DongHo();
                return _instance;
            }    
        }
        //đến đoạn này, lưu ý đổi tất cả class "testControl" cho phù hợp

            public DongHo()
        {
            InitializeComponent();
            addToCart.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            if(Program.maKH.Length == 0)
            {
                MessageBox.Show("Đăng nhập hoặc đăng kí để tiếp tục");
                (new FrmLogin()).ShowDialog(Program.frmMain);
                return;
            }
            string cmd;
            if (giamGia == -1)
                 cmd = "EXEC SP_UPDATE_GIO_HANG '" + Program.maKH + "','" + maDH + "'," + gia + ",1";
            else 
                cmd = "EXEC SP_UPDATE_GIO_HANG '" + Program.maKH + "','" + maDH + "'," + giaSauGiam + ",1";

            if (Program.execSqlNonQuery(cmd))
            {
                MessageBox.Show("Thêm vào giỏ hàng thành công!");
            }
        }

        private void DongHo_Load(object sender, EventArgs e)
        {

        }

        private void addToCart_MouseHover(object sender, EventArgs e)
        {
            addToCart.BorderStyle = BorderStyle.FixedSingle;
        }

        private void addToCart_MouseLeave(object sender, EventArgs e)
        {
            addToCart.BorderStyle = BorderStyle.None;
        }
    }
}
