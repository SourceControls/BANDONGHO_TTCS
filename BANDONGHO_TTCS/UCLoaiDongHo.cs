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

namespace BANDONGHO_TTCS
{
    public partial class UCLoaiDongHo : DevExpress.XtraEditors.XtraUserControl
    {
        bool isAddNew = false;

        public UCLoaiDongHo()
        {
            InitializeComponent();
        }

        private static UCLoaiDongHo _instance;
        public static UCLoaiDongHo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCLoaiDongHo();
                return _instance;
            }
        }

        private void SetViewMode(bool isEdit)
        {
            if (!isEdit)
            {
                mALOAITextEdit.Enabled = true;
            }
            btnThem.Enabled = !isEdit;
            btnXoa.Enabled = !isEdit;
            btnSua.Enabled = !isEdit;
            btnLamMoi.Enabled = !isEdit;
            btnThoat.Enabled = !isEdit;

            btnLuu.Enabled = isEdit;
            btnHuyBo.Enabled = isEdit;
            ttLOAIDONGHO.Enabled = isEdit;
            lOAIDONGHOGridControl.Enabled = !isEdit;

            if (lOAIDONGHOBindingSource.Count == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private bool CheckInput_LOAIDONGHO()
        {

            if (mALOAITextEdit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại không được để trống");
                return false;
            }
            if (isAddNew)
                if (lOAIDONGHOBindingSource.Find("MALOAI", mALOAITextEdit.Text) > -1)
                {
                    MessageBox.Show("Mã loại bị trùng");
                    return false;
                }
            if (tENLOAITextEdit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên loại không được để trống");
                return false;
            }
            if (lOAIDONGHOBindingSource.Find("TENLOAI", tENLOAITextEdit.Text) > -1)
                if (lOAIDONGHOBindingSource.Find("TENLOAI", tENLOAITextEdit.Text)
                    != lOAIDONGHOBindingSource.Find("MALOAI", mALOAITextEdit.Text))
                {
                    MessageBox.Show("Tên loại bị trùng");
                    return false;
                }

            return true;
        }

        private void FillDS()
        {
            this.dSet.EnforceConstraints = false;
            this.lOAIDONGHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOAIDONGHOTableAdapter.Fill(this.dSet.LOAIDONGHO);
            this.dONGHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dONGHOTableAdapter.Fill(this.dSet.DONGHO);
        }

        private void lOAIDONGHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAIDONGHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void UCLoaiDongHo_Load(object sender, EventArgs e)
        {
            FillDS();
            SetViewMode(false);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetViewMode(true);
            isAddNew = true;

            lOAIDONGHOBindingSource.AddNew();
            mALOAITextEdit.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dONGHOBindingSource.Find("MALOAI", mALOAITextEdit.Text) <= -1)
            {
                if (MessageBox.Show("Xác nhận xóa loại đồng hồ? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        lOAIDONGHOBindingSource.RemoveCurrent();
                        lOAIDONGHOTableAdapter.Update(this.dSet.LOAIDONGHO);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xoá loại đồng hồ. " + ex.Message);
                        FillDS();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa loại vì đã có đồng hồ thuộc loại này.");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetViewMode(true);
            mALOAITextEdit.Enabled = false;
            isAddNew = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckInput_LOAIDONGHO())
            {
                try
                {
                    this.lOAIDONGHOBindingSource.EndEdit();
                    this.lOAIDONGHOTableAdapter.Update(this.dSet.LOAIDONGHO);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu. " + ex.Message);
                    FillDS();
                }
                finally
                {
                    SetViewMode(false);
                }
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lOAIDONGHOBindingSource.CancelEdit();
            SetViewMode(false);
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FillDS();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.fMain.remove_UCLoaiDongHo();
            _instance = null;
        }
    }
}
