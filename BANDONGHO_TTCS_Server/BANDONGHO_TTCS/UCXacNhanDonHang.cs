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
    public partial class UCXacNhanDonHang : DevExpress.XtraEditors.XtraUserControl
    {
        string strView;
        public UCXacNhanDonHang()
        {
            InitializeComponent();
        }

        private static UCXacNhanDonHang _instance;
        public static UCXacNhanDonHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCXacNhanDonHang();
                return _instance;
            }
        }

        private void pHIEUDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUDATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSet);

        }

        private void ShowName()
        {
            if (pHIEUDATBindingSource.Count > 0)
            {
                Program.myReader = Program.ExecSqlDataReader("EXEC SP_LAYHOTENNV_PD "
                    + ((DataRowView)pHIEUDATBindingSource.Current)["MAPHIEUDAT"].ToString());
                if (Program.myReader.Read())
                    label3.Text = Program.myReader.GetString(0);
                else
                    label3.Text = "";
            }
            else label3.Text = "";
        }

        private void FillDS()
        {
            label3.Text = "";
            this.dSet.EnforceConstraints = false;
            
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.dSet.NHANVIEN);
            this.kHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHACHHANGTableAdapter.Fill(this.dSet.KHACHHANG);
            this.dONGHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dONGHOTableAdapter.Fill(this.dSet.DONGHO);

            if (strView != null)
            {
                this.pHIEUDATTableAdapter.Connection.ConnectionString = Program.connstr;
                this.pHIEUDATTableAdapter.FillByTT(this.dSet.PHIEUDAT, strView);

                this.cT_PDTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_PDTableAdapter.FillByTT(this.dSet.CT_PD, strView);
            }
            else
            {
                this.pHIEUDATTableAdapter.Connection.ConnectionString = Program.connstr;
                this.pHIEUDATTableAdapter.Fill(this.dSet.PHIEUDAT);
                this.cT_PDTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_PDTableAdapter.Fill(this.dSet.CT_PD);
            }

            if (pHIEUDATBindingSource.Count == 0)
            {
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
                simpleButton3.Enabled = false;
                simpleButton4.Enabled = false;
            }
            else
            {
                simpleButton3.Enabled = true;
                simpleButton4.Enabled = false;
                simpleButton1.Enabled = true;
                simpleButton2.Enabled = true;
            }    
        }

        private void Init()
        {
            groupBox2.Location = groupBox1.Location;
            groupBox2.Visible = false;
            strView = "Chờ xác nhận";
            FillDS();
            label1.Text = "Danh sách đơn hàng đang chờ xác nhận";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            simpleButton1.Visible = true;
            simpleButton2.Visible = true;
            simpleButton3.Visible = false;
            simpleButton4.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowName();
        }
            

        private void btnDHCXN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            strView = "Chờ xác nhận";
            FillDS();
            label1.Text = "Danh sách đơn hàng đang chờ xác nhận";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            simpleButton1.Visible = true;
            simpleButton2.Visible = true;
            simpleButton3.Visible = false;
            simpleButton4.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowName();
        }

        private void btnDHDG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            strView = "Đang giao";
            FillDS();
            label1.Text = "Danh sách đơn hàng đang giao";
            label2.Visible = true;
            label2.Text = "Nhân viên xác nhận:";
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = true;
            simpleButton4.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowName();
        }

        private void btnDHDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            strView = "Đã hủy";
            FillDS();
            label1.Text = "Danh sách đơn hàng đã hủy";
            label2.Visible = true;
            label2.Text = "Nhân viên xác nhận:";
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            simpleButton4.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowName();
        }

        private void btnDHDHT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            strView = "Hoàn tất";
            FillDS();
            label1.Text = "Danh sách đơn hàng đã hoàn tất";
            label2.Visible = true;
            label2.Text = "Nhân viên xác nhận:";
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            simpleButton4.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowName();
        }

        private void btnTBDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            strView = null;
            FillDS();
            label1.Text = "Danh sách toàn bộ các đơn hàng";
            label2.Visible = true;
            label2.Text = "Nhân viên xác nhận:";
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            simpleButton1.Visible = false;
            simpleButton2.Visible = false;
            simpleButton3.Visible = false;
            simpleButton4.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowName();
        }

        private void pHIEUDATGridControl_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            ShowName();
        }

        private void UCXacNhanDonHang_Load(object sender, EventArgs e)
        {
            FillDS();
            Init();
        }

        private void cT_PDGridControl_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView current = (DataRowView)pHIEUDATBindingSource.Current;
                Program.execSqlNonQuery("EXEC SP_XACNHANDONHANG '" + current["MAPHIEUDAT"]
                    + "', '" + Program.login + "'");
                MessageBox.Show("Đã xác nhận thành công.");
            }
            catch(Exception)
            {
                MessageBox.Show("Xác nhận đơn hàng thất bại.");
            }
            finally
            {
                FillDS();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy đơn hàng này?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRowView current = (DataRowView)pHIEUDATBindingSource.Current;
                    Program.execSqlNonQuery("EXEC SP_HUYDONHANG " + current["MAPHIEUDAT"]
                        + ", '" + Program.login + "'");
                }
                catch(Exception)
                {
                    MessageBox.Show("Hủy đơn hàng thất bại");
                }
                finally
                {
                    FillDS();
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView current = (DataRowView)pHIEUDATBindingSource.Current;
                Program.execSqlNonQuery("EXEC SP_XACNHANGIAOHANG '" + current["MAPHIEUDAT"]
                    + "', '" + Program.login + "'");
                MessageBox.Show("Đã xác nhận giao hàng thành công.");
            }
            catch (Exception)
            {
                MessageBox.Show("Xác nhận thất bại.");
            }
            finally
            {
                FillDS();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận giao thất bại?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    DataRowView current = (DataRowView)pHIEUDATBindingSource.Current;
                    Program.execSqlNonQuery("EXEC SP_HUYDONHANG '" + current["MAPHIEUDAT"]
                        + "', '" + Program.login + "'");
                    MessageBox.Show("Đã xác nhận.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Chưa thể xác nhận.");
                }
                finally
                {
                    FillDS();
                }
            }
        }
    }
}
