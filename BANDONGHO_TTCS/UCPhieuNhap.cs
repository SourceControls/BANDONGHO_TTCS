using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
        private static int IDCTPN;

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

        private void confirmUpdateBdsCTPN()
        {
            bdsCTPN.EndEdit();
            CTPNAdapter.Connection.ConnectionString = Program.connstr;
            CTPNAdapter.Update(dSet.CT_PN);
            bdsCTPN.ResetCurrentItem();
        }

        private void initBDS()
        {
            this.dSet.EnforceConstraints = false;
            this.PhieuNhapAdapter.Connection.ConnectionString = Program.connstr;
            this.PhieuNhapAdapter.Fill(this.dSet.PHIEUNHAP);

            this.CTPNAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNAdapter.Fill(this.dSet.CT_PN);

            this.hotenNVAdapter.Connection.ConnectionString = Program.connstr;
            this.hotenNVAdapter.Fill(this.dSet.HOTENNV);

            this.dongHoAdapter.Connection.ConnectionString = Program.connstr;
            this.dongHoAdapter.Fill(this.dSet.DONGHO);
        }

        private void UCPhieuNhap_Load(object sender, EventArgs e)
        {
            initBDS();

            lkDH.DataSource = bdsDongHo;
            lkDH.DisplayMember = "TENDONGHO";
            lkDH.ValueMember = "MADONGHO";

            slPN = bdsPhieuNhap.Count;
            slCTPN = bdsCTPN.Count;
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
                initBDS();
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
                MessageBox.Show(ex.Message + " Line 224");
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
            ((DataRowView)bdsCTPN[bdsCTPN.Position])["MAPN"] = maPN = edtPN.Text;

        }

        private void ctMenuLuuCT_Click(object sender, EventArgs e)
        {
            if (bdsCTPN.Count == 0 || slCTPN == bdsCTPN.Count)
            {
                return;
            }
            string maDH, strCmd;
            for (int i = slCTPN; i < bdsCTPN.Count; i++)
            {
                maDH = ((DataRowView)bdsCTPN[i])["MADONGHO"].ToString().Trim();
                strCmd = "sp_kt_ton_tai_dh_trong_ctpn '" + maPN + "', '" + maDH + "'";
                for (int j = i + 1; j < bdsCTPN.Count; j++)
                {
                    if (((DataRowView)bdsCTPN[j])["MADONGHO"].ToString().Trim().Equals(maDH))
                    {
                        gvCTPN.SetColumnError(null, "Hai đồng hồ cùng tên tồn tại trong 1 phiếu nhập!");
                        MessageBox.Show("Hai đồng hồ cùng tên tồn tại trong 1 phiếu nhập!");
                        return;
                    }
                }
                if (!Program.ExecSqlNonQuery(strCmd))
                {
                    gvCTPN.SetColumnError(null, "Đồng hồ đã tồn tại trong phiếu nhập!");
                    return;
                }
            }
            try
            {
                confirmUpdateBdsCTPN();
                isAssignSLCTPN = true;
                slCTPN = bdsCTPN.Count;
                MessageBox.Show("Lưu chi tiết thành công!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void ctMenuXoaCT_Click(object sender, EventArgs e)
        {
            if (bdsCTPN.Count == 0) return;
            if (MessageBox.Show("Xác nhận xóa chi tiết? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    // Lưu mã để phục hồi vị trí khi bị lỗi
                    IDCTPN = Int32.Parse(((DataRowView)bdsCTPN[viTri])["ID_CTPN"].ToString());
                    bdsCTPN.RemoveCurrent();
                    CTPNAdapter.Connection.ConnectionString = Program.connstr;
                    CTPNAdapter.Update(this.dSet.CT_PN);
                    slCTPN = bdsCTPN.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa chi tiết! " + ex.ToString());
                    CTPNAdapter.Fill(this.dSet.CT_PN);
                    bdsCTPN.Position = bdsCTPN.Find("MADONGHO", IDCTPN);
                    return;
                }
            }
        }

        private void ctMenuXN_Click(object sender, EventArgs e)
        {
            if(bdsCTPN.Count == 0 || slCTPN < bdsCTPN.Count)
            {
                return;
            }
           try
            {
                confirmUpdateBdsCTPN();
                MessageBox.Show("Cập nhật thành công!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Line 325");
            }
        }

        private void gvCTPN_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gvCTPN.FocusedColumn.FieldName == "DONGIA" || gvCTPN.FocusedColumn.FieldName == "SOLUONG")
            {
                double donGia = 0;
                if (!Double.TryParse(e.Value as String, out donGia))
                {
                    e.Valid = false;
                    e.ErrorText = "Phải nhập một số!";
                }
                if (donGia <= 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Phải là số dương!";
                }
            }
        }
       
        private void gvCTPN_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridColumn columnDonGia = gvCTPN.Columns["DONGIA"];
            GridColumn columnSoLuong = gvCTPN.Columns["SOLUONG"];
            GridColumn columnMaDongHo = gvCTPN.Columns["MADONGHO"];

            string test = gvCTPN.GetSelectedCells().ToString();

            string maDH = gvCTPN.GetRowCellValue(gvCTPN.FocusedRowHandle, columnMaDongHo).ToString().Trim();
            string donGia = gvCTPN.GetRowCellValue(gvCTPN.FocusedRowHandle, columnDonGia).ToString().Trim();
            string soLuong = gvCTPN.GetRowCellValue(gvCTPN.FocusedRowHandle, columnSoLuong).ToString().Trim();

            if (maDH.Length == 0)
            {
                e.Valid = false;
                e.ErrorText = "Mã đồng hồ không được để trống!\n";
            }
            else if (donGia.Length == 0)
            {
                e.Valid = false;
                e.ErrorText = "Đơn giá không được để trống và phải lớn hơn 0!\n";
            }
            else if (soLuong.Length == 0)
            {
                e.Valid = false;
                e.ErrorText = "Số lượng không được để trống và phải lớn hơn 0!\n";
            }
        }
        
        private void gvCTPN_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            MessageBox.Show(e.ErrorText, "Giá trị không hợp lệ!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void btnExist_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLogin.fMain.remove_UCPhieuNhap();
            _instance = null;
        }

        private void gvPN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            slCTPN = bdsCTPN.Count;
        }
    }
}
