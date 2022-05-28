using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
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
    public partial class UCPhieuNhap : DevExpress.XtraEditors.XtraUserControl
    {
        private static int viTri;
        private static string maPN;
        private static int slPN;
        private static int slCTPN;
        private static bool isAssignSLCTPN;


        private static UCPhieuNhap _instance;
        public static UCPhieuNhap Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UCPhieuNhap();
                }
                return _instance;
            }
        }

        private void selectDefaultValue()
        {
            dpPN.DateTime = DateTime.Now;
            cmbNV.SelectedIndex = 0;
        }

        public UCPhieuNhap()
        {
            InitializeComponent();
        }

        private bool checkBdsPhieuNhapHaveItem(string message)
        {
            if (bdsPhieuNhap.Count == 0)
            {
                MessageBox.Show(message);
                return false;
            }
            return true;
        }

        private void controlPanelAndButton(bool isEnable)
        {
            btnSua.Enabled = btnXoa.Enabled =
            btnLoad.Enabled = pcGridPN.Enabled =
            btnThem.Enabled = pcGridPN.Enabled = isEnable;

            pcPNNhap.Enabled = btnUndo.Enabled = btnLuu.Enabled = !isEnable;
        }

        private void enabledPanelAndButton()
        {
            controlPanelAndButton(true);
        }

        private void disabledPanelAndButton()
        {
            controlPanelAndButton(false);
        }

        private void UCPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSet.DONGHO' table. You can move, or remove it, as needed.
            this.dSet.EnforceConstraints = false;
            this.PhieuNhapAdapter.Connection.ConnectionString = Program.connstr;
            this.PhieuNhapAdapter.Fill(this.dSet.PHIEUNHAP);
            this.hotenNVAdapter.Connection.ConnectionString = Program.connstr;
            this.hotenNVAdapter.Fill(this.dSet.HOTENNV);
            this.CTPNAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNAdapter.Fill(this.dSet.CT_PN);
            this.dongHoAdapter.Connection.ConnectionString = Program.connstr;
            this.dongHoAdapter.Fill(this.dSet.DONGHO);

           /* List<string> dummyListDH = new List<string>();
            dummyListDH.Add("DH01");
            dummyListDH.Add("DH02");
            dummyListDH.Add("DH03");
            dummyListDH.Add("DH04");

            RepositoryItemComboBox riCmbDongHo = new RepositoryItemComboBox();
            riCmbDongHo.Items.AddRange(dummyListDH);
            gvCTPN.Columns["DONGHO"].ColumnEdit = riCmbDongHo;
*/
            slPN = bdsPhieuNhap.Count;
            selectDefaultValue();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsHoTenNV.Count == 0)
            {
                MessageBox.Show("Phải có ít nhất một nhân viên để lập phiếu nhập!");
                return;
            }
            viTri = bdsPhieuNhap.Position;
            bdsPhieuNhap.AddNew();
            selectDefaultValue();
            edtPN.Enabled = true;
            edtPN.Focus();
            disabledPanelAndButton();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkBdsPhieuNhapHaveItem("Không có phiếu nhập để xoá!"))
            {
                return;
            }
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Phiếu nhập đã có các chi tiết!");
                return;
            }
            if (MessageBox.Show("Xác nhận xóa phiếu nhập? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maPN = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position])["MAPN"].ToString();
                    bdsPhieuNhap.RemoveCurrent();
                    PhieuNhapAdapter.Connection.ConnectionString = Program.connstr;
                    PhieuNhapAdapter.Update(this.dSet.PHIEUNHAP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá phiếu nhập! (line 127)" + ex.ToString());
                    PhieuNhapAdapter.Fill(this.dSet.PHIEUNHAP);
                    bdsPhieuNhap.Position = bdsPhieuNhap.Find("MALOP", maPN);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!checkBdsPhieuNhapHaveItem("Không có phiếu nhập để sửa!"))
            {
                return;
            }

            viTri = bdsPhieuNhap.Position;
            edtMANV.Text = cmbNV.SelectedValue.ToString();

            edtPN.Enabled = false;
            disabledPanelAndButton();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maPN = edtPN.Text.ToString().Trim();
            if (maPN.Length == 0)
            {
                MessageBox.Show("Mã phiếu nhập không được để trống!");
                return;
            }

            try
            {
                bdsPhieuNhap.EndEdit();
                PhieuNhapAdapter.Connection.ConnectionString = Program.connstr;
                PhieuNhapAdapter.Update(dSet.PHIEUNHAP);
                bdsPhieuNhap.ResetCurrentItem();
                slPN = bdsPhieuNhap.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                enabledPanelAndButton();
            }
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                PhieuNhapAdapter.Fill(dSet.PHIEUNHAP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Lỗi reload, line 142");
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsPhieuNhap.CancelEdit();
            while (slPN < bdsPhieuNhap.Count)
            {
                bdsPhieuNhap.RemoveAt(bdsPhieuNhap.Count - 1);
            }
            bdsPhieuNhap.Position = viTri;
            enabledPanelAndButton();
        }

        private void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNV.SelectedValue == null ||
                  cmbNV.SelectedValue.ToString().Equals("System.Data.DataRowView")
              )
            {
                return;
            }
            try
            {
                edtMANV.Text = cmbNV.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Line 100");
            }
        }

        private void ctMenuThemCT_Click(object sender, EventArgs e)
        {
            if (!checkBdsPhieuNhapHaveItem("Phải có ít nhất một phiếu nhập!"))
            {
                return;
            }
            if (bdsDongHo.Count == 0)
            {
                MessageBox.Show("Phải có ít nhất 1 đồng hồ!");
                return;
            }
            if (isAssignSLCTPN)
            {
                isAssignSLCTPN = false;
                slCTPN = bdsCTPN.Count;
            }
            bdsCTPN.AddNew();
            ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"] = edtPN.Text;
        }

        private void ctMenuLuuCT_Click(object sender, EventArgs e)
        {
            if (bdsCTPN.Count == 0)
            {
                return;
            }
            for (int i = slCTPN; i < bdsCTPN.Count; i++)
            {

            }
        }
    }
}
