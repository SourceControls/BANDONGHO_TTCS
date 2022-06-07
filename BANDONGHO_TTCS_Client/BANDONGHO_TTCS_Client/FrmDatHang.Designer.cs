
namespace BANDONGHO_TTCS_Client
{
    partial class FrmDatHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dSet = new BANDONGHO_TTCS_Client.DSet();
            this.tableAdapterManager = new BANDONGHO_TTCS_Client.DSetTableAdapters.TableAdapterManager();
            this.kHACHHANGTableAdapter = new BANDONGHO_TTCS_Client.DSetTableAdapters.KHACHHANGTableAdapter();
            this.bdsKhachHang = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pbHinhAnh = new System.Windows.Forms.PictureBox();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bdsCTGH = new System.Windows.Forms.BindingSource(this.components);
            this.v_CT_GIO_HANGTableAdapter = new BANDONGHO_TTCS_Client.DSetTableAdapters.V_CT_GIO_HANGTableAdapter();
            this.v_CT_GIO_HANGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHINHANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENDONGHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_CT_GIO_HANGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_GIOHANGTableAdapter = null;
            this.tableAdapterManager.CT_KMTableAdapter = null;
            this.tableAdapterManager.CT_PDTableAdapter = null;
            this.tableAdapterManager.CT_PNTableAdapter = null;
            this.tableAdapterManager.DONGHOTableAdapter = null;
            this.tableAdapterManager.HANGDONGHOTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIDONGHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BANDONGHO_TTCS_Client.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // bdsKhachHang
            // 
            this.bdsKhachHang.DataMember = "KHACHHANG";
            this.bdsKhachHang.DataSource = this.dSet;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pbHinhAnh);
            this.panelControl1.Controls.Add(this.txtSDT);
            this.panelControl1.Controls.Add(this.txtHoTen);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtDiaChi);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(523, 259);
            this.panelControl1.TabIndex = 7;
            // 
            // pbHinhAnh
            // 
            this.pbHinhAnh.Location = new System.Drawing.Point(317, 8);
            this.pbHinhAnh.Name = "pbHinhAnh";
            this.pbHinhAnh.Size = new System.Drawing.Size(201, 246);
            this.pbHinhAnh.TabIndex = 15;
            this.pbHinhAnh.TabStop = false;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(12, 90);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Mask.EditMask = "\\d\\d\\d\\ ?\\d{1,2}\\d\\d\\d\\d\\d";
            this.txtSDT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSDT.Size = new System.Drawing.Size(298, 22);
            this.txtSDT.TabIndex = 14;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(12, 28);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(298, 22);
            this.txtHoTen.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Địa Chỉ Người Nhận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số điện thoại người nhận";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(12, 142);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(298, 96);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ tên người nhận:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chi tiết giỏ hàng";
            // 
            // bdsCTGH
            // 
            this.bdsCTGH.DataMember = "V_CT_GIO_HANG";
            this.bdsCTGH.DataSource = this.dSet;
            // 
            // v_CT_GIO_HANGTableAdapter
            // 
            this.v_CT_GIO_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // v_CT_GIO_HANGGridControl
            // 
            this.v_CT_GIO_HANGGridControl.DataSource = this.bdsCTGH;
            this.v_CT_GIO_HANGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.v_CT_GIO_HANGGridControl.Location = new System.Drawing.Point(0, 276);
            this.v_CT_GIO_HANGGridControl.MainView = this.gridView1;
            this.v_CT_GIO_HANGGridControl.Name = "v_CT_GIO_HANGGridControl";
            this.v_CT_GIO_HANGGridControl.Size = new System.Drawing.Size(523, 317);
            this.v_CT_GIO_HANGGridControl.TabIndex = 9;
            this.v_CT_GIO_HANGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHINHANH,
            this.colTENDONGHO,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView1.GridControl = this.v_CT_GIO_HANGGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colHINHANH
            // 
            this.colHINHANH.Caption = "Hình Ảnh";
            this.colHINHANH.FieldName = "HINHANH";
            this.colHINHANH.MinWidth = 25;
            this.colHINHANH.Name = "colHINHANH";
            this.colHINHANH.OptionsColumn.AllowEdit = false;
            this.colHINHANH.Width = 94;
            // 
            // colTENDONGHO
            // 
            this.colTENDONGHO.Caption = "Tên Đồng Hồ";
            this.colTENDONGHO.FieldName = "TENDONGHO";
            this.colTENDONGHO.MinWidth = 25;
            this.colTENDONGHO.Name = "colTENDONGHO";
            this.colTENDONGHO.OptionsColumn.AllowEdit = false;
            this.colTENDONGHO.Visible = true;
            this.colTENDONGHO.VisibleIndex = 0;
            this.colTENDONGHO.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số Lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.OptionsColumn.AllowEdit = false;
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 1;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.DisplayFormat.FormatString = "N0";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.OptionsColumn.AllowEdit = false;
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 94;
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTongTien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(0, 593);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(60, 24);
            this.lbTongTien.TabIndex = 10;
            this.lbTongTien.Text = "Tổng";
            this.lbTongTien.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDatHang
            // 
            this.btnDatHang.Location = new System.Drawing.Point(130, 684);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(261, 35);
            this.btnDatHang.TabIndex = 11;
            this.btnDatHang.Text = "Xác Nhận Đặt Hàng";
            this.btnDatHang.UseVisualStyleBackColor = true;
            this.btnDatHang.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 741);
            this.Controls.Add(this.btnDatHang);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.v_CT_GIO_HANGGridControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmDatHang";
            this.Text = "Đặt Hàng";
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_CT_GIO_HANGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSet dSet;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsKhachHang;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDiaChi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bdsCTGH;
        private DSetTableAdapters.V_CT_GIO_HANGTableAdapter v_CT_GIO_HANGTableAdapter;
        private DevExpress.XtraGrid.GridControl v_CT_GIO_HANGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHINHANH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENDONGHO;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btnDatHang;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.PictureBox pbHinhAnh;
    }
}