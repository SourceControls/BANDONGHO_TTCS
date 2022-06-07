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
    public partial class UCKhuyenMai : DevExpress.XtraEditors.XtraUserControl
    {
        bool isAddNew = false;

        public UCKhuyenMai()
        {
            InitializeComponent();
        }

        private static UCKhuyenMai _instance;
        public static UCKhuyenMai Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCKhuyenMai();
                return _instance;
            }
        }

        private void SetViewMode(bool isEdit)
        {
            if (!isEdit)
            {
                mAKMTextEdit.Enabled = true;
            }
            mAKMTextEdit1.Enabled = false;
            btnThemKM.Enabled = !isEdit;
            btnThemCTKM.Enabled = !isEdit;
            btnXoa.Enabled = !isEdit;
            btnSua.Enabled = !isEdit;
            btnLamMoi.Enabled = !isEdit;
            btnThoat.Enabled = !isEdit;
            
            btnLuu.Enabled = isEdit;
            btnHuyBo.Enabled = isEdit;
            ttKM.Enabled = isEdit;
            ttCT_KM.Enabled = isEdit;
            kHUYENMAIGridControl.Enabled = !isEdit;
            cT_KMGridControl.Enabled = !isEdit;
            
            if (kHUYENMAIBindingSource.Count == 0)
            {
                btnThemCTKM.Enabled = false;
                btnSua.Enabled = false;
            }
        }

        private void InitValue_KM()
        {
            nGAYBDDateEdit.DateTime = DateTime.Now;
            nGAYKTDateEdit.DateTime = DateTime.Now;
        }

        private void InitValue_CTKM()
        {
            mAKMTextEdit1.Text = mAKMTextEdit.Text;
            comboBox1.SelectedIndex = 0;
        }

        private bool CheckInput_KM()
        {
            
            if (mAKMTextEdit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã khuyến mãi không được để trống");
                return false;
            }
            if(isAddNew)
                if (kHUYENMAIBindingSource.Find("MAKM", mAKMTextEdit.Text) > -1)
                {
                    MessageBox.Show("Mã khuyến mãi bị trùng");
                    return false;
                }
            if (tENKMTextEdit.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên khuyến mãi không được để trống");
                return false;
            }
            
            if (nGAYBDDateEdit.DateTime==DateTime.MinValue)
            {    
                MessageBox.Show("Ngày bắt đầu không được để trống");
                return false;
            }
            if(nGAYKTDateEdit.DateTime==DateTime.MinValue)
            {    
                MessageBox.Show("Ngày kết thúc không được để trống");
                return false;
            }
            if(nGAYBDDateEdit.DateTime > nGAYKTDateEdit.DateTime)
            {
                MessageBox.Show("Ngày bắt đầu không được đặt sau ngày kết thúc.");
                return false;
            }    

            return true;
        }

        private bool CheckInput_CTKM()
        {
            if (isAddNew)
            {
                Program.myReader = Program.ExecSqlDataReader("SELECT * FROM CT_KM WHERE MADONGHO = '"
                    + comboBox1.SelectedValue.ToString() + "' AND MAKM = '" + mAKMTextEdit.Text + "'");
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Đồng hồ đã được khuyến mãi.");
                    return false;
                }
            }
            if (tYLEGIAMGIASpinEdit.Value <= 0)
            {
                MessageBox.Show("Tỷ lệ giảm giá không hợp lệ.");
                return false;
            }
            return true;
        }

        private void FillDS()
        {
            this.dSet.EnforceConstraints = false;
            this.kHUYENMAITableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHUYENMAITableAdapter.Fill(this.dSet.KHUYENMAI);
            this.cT_KMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_KMTableAdapter.Fill(this.dSet.CT_KM);
            this.dONGHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dONGHOTableAdapter.Fill(this.dSet.DONGHO);
        }

        private void kHUYENMAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUYENMAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void UCKhuyenMai_Load(object sender, EventArgs e)
        {
            FillDS();
            SetViewMode(false);
        }

        private void btnThemKM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetViewMode(true);
            ttCT_KM.Enabled = false;
            cT_KMGridControl.Enabled = false;
            isAddNew = true;

            kHUYENMAIBindingSource.AddNew();
            InitValue_KM();
            mAKMTextEdit.Focus();
        }

        private void btnThemCTKM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetViewMode(true);
            ttKM.Enabled = false;
            kHUYENMAIGridControl.Enabled = false;
            mAKMTextEdit1.Enabled = false;
            isAddNew = true;
            comboBox1.Enabled = true;

            cT_KMBindingSource.AddNew();
            InitValue_CTKM();
            comboBox1.Focus();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHUYENMAIGridControl.IsFocused)
            {
                if (MessageBox.Show("Xác nhận xóa khuyến mãi và toàn bộ chi tiết của nó? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        int n = gridView2.RowCount;
                        for (int i = 0; i < n; i++)
                        {
                            this.cT_KMBindingSource.RemoveAt(0);
                        }
                        this.cT_KMTableAdapter.Update(this.dSet.CT_KM);
                        gridView1.DeleteSelectedRows();
                        this.kHUYENMAITableAdapter.Update(this.dSet.KHUYENMAI);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi xoá khuyến mãi. " + ex.Message);
                        FillDS();
                    }
                }

            }
            else if (cT_KMGridControl.IsFocused)
                if (MessageBox.Show("Xác nhận xóa chi tiết khuyến mãi? ", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        gridView2.DeleteSelectedRows();
                        this.cT_KMTableAdapter.Update(this.dSet.CT_KM);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xoá chi tiết khuyến mãi!. " + ex.Message);
                        FillDS();
                    }
                }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHUYENMAIGridControl.IsFocused)
            {
                SetViewMode(true);
                ttCT_KM.Enabled = false;
                mAKMTextEdit.Enabled = false;
            }
            else if (cT_KMGridControl.IsFocused)
            {
                SetViewMode(true);
                ttKM.Enabled = false;
                comboBox1.Enabled = false;
            }
            isAddNew = false;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ttKM.Enabled)
            {
                if(CheckInput_KM())
                {
                    try
                    {
                        this.kHUYENMAIBindingSource.EndEdit();
                        this.kHUYENMAITableAdapter.Update(this.dSet.KHUYENMAI);
                    }
                    catch(Exception ex)
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
            else if(ttCT_KM.Enabled)
            {
                if (CheckInput_CTKM())
                {
                    try
                    {
                        this.cT_KMBindingSource.EndEdit();
                        this.cT_KMTableAdapter.Update(this.dSet.CT_KM);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu dữ liệu. " + ex.Message);
                        FillDS();
                    }
                    finally
                    {
                        SetViewMode(false);
                        isAddNew = false;
                    }
                }
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ttKM.Enabled)
            {
                kHUYENMAIBindingSource.CancelEdit();
            }
            else if (ttCT_KM.Enabled)
            {
                cT_KMBindingSource.CancelEdit();
            }
            FillDS();
            SetViewMode(false);    
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FillDS();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
 /*           FrmLogin.fMain.remove_UCKhuyenMai();
            _instance = null;*/
        }
    }
}
