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
    public partial class FrmGioHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmGioHang()
        {
            InitializeComponent();
        }

        private void FrmGioHang_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dSet.V_CT_GIO_HANG' table. You can move, or remove it, as needed.
            this.v_CT_GIO_HANGTableAdapter.Fill(this.dSet.V_CT_GIO_HANG);
            DongHoGioHang d;
            bdsCTGH.DataSource = dSet.V_CT_GIO_HANG;
            bdsCTGH.Filter = "MAKH = '" +Program.maKH.Trim()+"'";

            
            for (int i = 0; i < bdsCTGH.Count; i++)
            {
                d = new DongHoGioHang();
                d.maDH = ((DataRowView)bdsCTGH[i])[0].ToString();
                d.ten = ((DataRowView)bdsCTGH[i])[1].ToString();
                d.gia = double.Parse(((DataRowView)bdsCTGH[i])[3].ToString());
                d.hinhAnh = ((DataRowView)bdsCTGH[i])[4].ToString();
                d.hang = ((DataRowView)bdsCTGH[i])[5].ToString();
                d.loai = ((DataRowView)bdsCTGH[i])[6].ToString();
                d.moTa = ((DataRowView)bdsCTGH[i])[7].ToString();
                d.giaSauGiam = double.Parse(((DataRowView)bdsCTGH[i])[8].ToString());
                d.giamGia = double.Parse(((DataRowView)bdsCTGH[i])[9].ToString());
                d.slDat = int.Parse(((DataRowView)bdsCTGH[i])["SOLUONG"].ToString().Trim());
                d.initUI();
                this.mainPanel.Controls.Add(d);
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.v_CT_GIO_HANGTableAdapter.Fill(this.dSet.V_CT_GIO_HANG);
            if (bdsCTGH.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm nào");
                return;
            }
            (new FrmDatHang()).ShowDialog(this);
            this.mainPanel.Controls.Clear();
            FrmGioHang_Load(sender, e);
        }
    }
}