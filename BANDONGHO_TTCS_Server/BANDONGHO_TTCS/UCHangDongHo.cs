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
    public partial class UCHangDongHo : DevExpress.XtraEditors.XtraUserControl
    {
        bool isAddNew = false;
        public UCHangDongHo()
        {
            InitializeComponent();
        }

        private static UCHangDongHo _instance;
        public static UCHangDongHo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCHangDongHo();
                return _instance;
            }
        }

        private void SetViewMode(bool isEdit)
        {
            if (!isEdit)
            {
                mAHANGTextEdit.Enabled = true;
            }
            btnThem.Enabled = !isEdit;
            btnXoa.Enabled = !isEdit;
            btnSua.Enabled = !isEdit;
            btnLamMoi.Enabled = !isEdit;
            btnThoat.Enabled = !isEdit;

            btnLuu.Enabled = isEdit;
            btnHuyBo.Enabled = isEdit;
            ttHANGDONGHO.Enabled = isEdit;
            hANGDONGHOGridControl.Enabled = !isEdit;

            if (hANGDONGHOBindingSource.Count == 0)
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private bool CheckInput_HANGDONGHO()
        {

            if (mAHANGTextEdit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã hãng không được để trống");
                return false;
            }
            if(isAddNew)
                if (hANGDONGHOBindingSource.Find("MAHANG", mAHANGTextEdit.Text) > -1)
                {
                    MessageBox.Show("Mã hãng bị trùng");
                    return false;
                }
            if (tENHANGTextEdit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên hãng không được để trống");
                return false;
            }
            if(hANGDONGHOBindingSource.Find("TENHANG", tENHANGTextEdit.Text) >-1)
                if (hANGDONGHOBindingSource.Find("TENHANG", tENHANGTextEdit.Text) 
                    != hANGDONGHOBindingSource.Find("MAHANG",mAHANGTextEdit.Text))
                {
                    MessageBox.Show("Tên hãng bị trùng");
                    return false;
                }

            return true;
        }

        private void FillDS()
        {
            this.dSet.EnforceConstraints = false;
            this.hANGDONGHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hANGDONGHOTableAdapter.Fill(this.dSet.HANGDONGHO);
            this.dONGHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dONGHOTableAdapter.Fill(this.dSet.DONGHO);
        }

        private void hANGDONGHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hANGDONGHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void UCHangDongHo_Load(object sender, EventArgs e)
        {
            FillDS();
            SetViewMode(false);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetViewMode(true);
            isAddNew = true;

            hANGDONGHOBindingSource.AddNew();
            mAHANGTextEdit.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dONGHOBindingSource.Find("MAHANG",mAHANGTextEdit.Text) <= -1)
            {
                if (MessageBox.Show("Xác nhận xóa hãng đồng hồ? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        hANGDONGHOBindingSource.RemoveCurrent();
                        hANGDONGHOTableAdapter.Update(this.dSet.HANGDONGHO);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xoá hãng đồng hồ. " + ex.Message);
                        FillDS();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa hãng vì đã có đồng hồ thuộc hãng này.");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetViewMode(true);
            mAHANGTextEdit.Enabled = false;
            isAddNew = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (CheckInput_HANGDONGHO())
            {
                try
                {
                    this.hANGDONGHOBindingSource.EndEdit();
                    this.hANGDONGHOTableAdapter.Update(this.dSet.HANGDONGHO);
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
            hANGDONGHOBindingSource.CancelEdit();
            SetViewMode(false);
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FillDS();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FrmLogin.fMain.remove_UCHangDongHo();
            //_instance = null;
        }
    }
}
