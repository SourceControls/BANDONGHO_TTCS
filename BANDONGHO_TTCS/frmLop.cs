using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmLop : DevExpress.XtraEditors.XtraForm
    {

        private int viTri = 0;  //Khi ấn vào btn phục hồi thì position trong bds sẽ quay về vị trí ban đầu
        private bool doneLoadForm = false; //Fix lỗi khi load form, cbcoso được đổ dữ liệu vào sẽ bị auto gọi hàm indexchanged
        private bool addingNew = false;
        public frmLop()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSet);

        }

        private void frmLop_Load(object sender, EventArgs e)
        {

            DSet.EnforceConstraints = false;
            
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DSet.KHOA);

            this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LOPTableAdapter.Fill(this.DSet.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SINHVIENTableAdapter.Fill(this.DSet.SINHVIEN);

            //thiết lập cb cơ sở

            cbCoSo.DataSource = Program.bdsDSPM;
            cbCoSo.DisplayMember = "TENCN";
            cbCoSo.ValueMember = "TENSERVER";
            cbCoSo.SelectedIndex = Program.mCoSo;
            
            //đổ dữ liệu vào cb khoa
            bdsKhoa.Filter = "MACS = 'CS" + (cbCoSo.SelectedIndex+1) + "' ";  //lọc ra khoa của cơ sở hiện tại 
            cbKhoa.DataSource = bdsKhoa;
            cbKhoa.DisplayMember = "TENKH";
            cbKhoa.ValueMember = "MAKH";

            //Phân quyền dùng app theo group
            btnGhi.Enabled = btnPhucHoi.Enabled = false;

            if (Program.mGroup.ToUpper().Equals("TRUONG"))
            {
                cbCoSo.Enabled = true;
                 btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
                cbCoSo.Enabled = false;
            }

            doneLoadForm = true;
        }



        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

 
            System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;
            try
            {
                if (cmb.SelectedValue != null & !cmb.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                {
                    txtMaKhoa.Text = cmb.SelectedValue.ToString();
                }
            }            
            catch { }
        }

        private void txtMaKhoa_EditValueChanged(object sender, EventArgs e)
        {

            try
            {
                cbKhoa.SelectedValue = txtMaKhoa.Text;

            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsKhoa.Count == 0)
            {
                MessageBox.Show("Chưa Có Khoa, Không Thể Thêm Lớp");
                return;
            }
            addingNew = true;
            cbKhoa.SelectedIndex = -1;
            viTri = bdsLop.Position;
            bdsLop.AddNew();
            //cbCoSo.SelectedIndex = 0;
            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            panelNhapLieu.Enabled = true;
            lOPGridControl.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsLop.Count <= 0)
            {
                MessageBox.Show("Không còn lớp để hiệu chỉnh");
                return;
            }
            viTri = bdsLop.Position;

            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            panelNhapLieu.Enabled = true;
            lOPGridControl.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu để xóa");
                return;
            }
            String maLop = ""; //lưu lại mã, nếu có sự cố khi xóa thì còn phục hồi vị trí
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa Lớp đã có Sinh Viên!");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa Lớp? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maLop = ((DataRowView)bdsLop[bdsLop.Position])["MALOP"].ToString();
                    bdsLop.RemoveCurrent();
                    LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    LOPTableAdapter.Update(DSet.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Lớp! " + ex.ToString());
                    LOPTableAdapter.Fill(DSet.LOP);
                    bdsLop.Position = bdsLop.Find("MALOP", maLop);
                    return;
                }
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim().Length == 0 || txtTenLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã Lớp Và Tên Lớp Không Được Để Trống");
                return;
            }
            if(txtMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Khoa Không Được Để Trống");
                return;
            }

            //check trùng mã trên môi trường phân tán
            String cmd = "exec sp_tim_lop '" + txtMaLop.Text + "'";
            SqlDataReader myReader = Program.ExecSqlDataReader(cmd);
            if (myReader.HasRows)
            {
                //check trùng trên site hiện tại
                int vTri = bdsLop.Find("MALOP", txtMaLop.Text.Trim());
                if (vTri == -1)  //nếu không trùng trên site hiện tại, tức là trùng trên site khác
                {
                    MessageBox.Show("Mã Lớp Bị Trùng Trên Site Khác");
                    return;
                }
                if (vTri != -1 && vTri != bdsLop.Position)  //nếu trùng trên site hiện tại và không trùng với mẫu tin đang sửa
                {
                    MessageBox.Show("Mã Lớp Bị Trùng! Hãy Đặt Mã Khác");
                    return;
                }
            }


            try
            {
                //check Input
                String tenLop = txtTenLop.Text.Trim();
                String maLop = txtMaLop.Text.Trim();
                while(tenLop.Contains("  "))
                {
                    tenLop.Replace("  ", " ");

                }
                while(maLop.Contains("  "))
                {
                    maLop.Replace("  ", " ");

                }
                txtTenLop.Text = tenLop;
                txtMaLop.Text = maLop;

                bdsLop.EndEdit();
                LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                LOPTableAdapter.Update(DSet.LOP);
                bdsLop.ResetCurrentItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi Lớp: " + ex.Message);
                LOPTableAdapter.Fill(DSet.LOP);
            }
            addingNew = false;
            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelNhapLieu.Enabled = false;
            lOPGridControl.Enabled = true;
            btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnThem.Enabled = true;

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (addingNew)
            {
                bdsLop.RemoveCurrent();
                addingNew = false;
            }
            bdsLop.CancelEdit();
            bdsLop.Position = viTri;
            //bật tắt các controller khác
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
            panelNhapLieu.Enabled = false;
            lOPGridControl.Enabled = true;
            btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = btnThem.Enabled = true;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(DSet.LOP);
                this.KHOATableAdapter.Fill(DSet.KHOA);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload: " + ex.ToString());
                return;
            }
        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!doneLoadForm)
                return;
            //đổi site
            System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)sender;
            if (Program.connectToOtherSite(cmb.SelectedValue.ToString()) == 1)
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LOPTableAdapter.Fill(this.DSet.LOP);
            }
            MessageBox.Show(Program.connstr);
        }
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}