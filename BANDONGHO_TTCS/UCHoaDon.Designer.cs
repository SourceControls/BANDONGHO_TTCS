
namespace BANDONGHO_TTCS
{
    partial class UCHoaDon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAPHIEUDATLabel;
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.pcHD = new DevExpress.XtraEditors.PanelControl();
            this.edtMaPD = new DevExpress.XtraEditors.TextEdit();
            this.bdsPD = new System.Windows.Forms.BindingSource(this.components);
            this.dSet = new BANDONGHO_TTCS.DSet();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pHIEUDATGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPHIEUDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENNGUOINHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHINGUOINHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTNGUOINHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYDAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PDAdapter = new BANDONGHO_TTCS.DSetTableAdapters.v_lay_phieu_datTableAdapter();
            this.tableAdapterManager = new BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager();
            mAPHIEUDATLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcHD)).BeginInit();
            this.pcHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaPD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPHIEUDATLabel
            // 
            mAPHIEUDATLabel.AutoSize = true;
            mAPHIEUDATLabel.Location = new System.Drawing.Point(177, 43);
            mAPHIEUDATLabel.Name = "mAPHIEUDATLabel";
            mAPHIEUDATLabel.Size = new System.Drawing.Size(50, 13);
            mAPHIEUDATLabel.TabIndex = 3;
            mAPHIEUDATLabel.Text = "Mã phiếu";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // pcHD
            // 
            this.pcHD.Controls.Add(mAPHIEUDATLabel);
            this.pcHD.Controls.Add(this.edtMaPD);
            this.pcHD.Controls.Add(this.btnThoat);
            this.pcHD.Controls.Add(this.btnLapHD);
            this.pcHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcHD.Location = new System.Drawing.Point(0, 449);
            this.pcHD.Name = "pcHD";
            this.pcHD.Size = new System.Drawing.Size(809, 100);
            this.pcHD.TabIndex = 2;
            // 
            // edtMaPD
            // 
            this.edtMaPD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPD, "MAPHIEUDAT", true));
            this.edtMaPD.Location = new System.Drawing.Point(259, 40);
            this.edtMaPD.Name = "edtMaPD";
            this.edtMaPD.Properties.ReadOnly = true;
            this.edtMaPD.Size = new System.Drawing.Size(143, 20);
            this.edtMaPD.TabIndex = 4;
            // 
            // bdsPD
            // 
            this.bdsPD.DataMember = "v_lay_phieu_dat";
            this.bdsPD.DataSource = this.dSet;
            // 
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(618, 37);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Huỷ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(495, 37);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(75, 23);
            this.btnLapHD.TabIndex = 2;
            this.btnLapHD.Text = "Lập hoá đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pHIEUDATGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(809, 449);
            this.panelControl2.TabIndex = 3;
            // 
            // pHIEUDATGridControl
            // 
            this.pHIEUDATGridControl.DataSource = this.bdsPD;
            this.pHIEUDATGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHIEUDATGridControl.Location = new System.Drawing.Point(2, 2);
            this.pHIEUDATGridControl.MainView = this.gridView1;
            this.pHIEUDATGridControl.Name = "pHIEUDATGridControl";
            this.pHIEUDATGridControl.Size = new System.Drawing.Size(805, 445);
            this.pHIEUDATGridControl.TabIndex = 0;
            this.pHIEUDATGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.pHIEUDATGridControl.Load += new System.EventHandler(this.pHIEUDATGridControl_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPHIEUDAT,
            this.colHOTENNGUOINHAN,
            this.colDIACHINGUOINHAN,
            this.colSDTNGUOINHAN,
            this.colHOTENNV,
            this.colNGAYDAT});
            this.gridView1.GridControl = this.pHIEUDATGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPHIEUDAT
            // 
            this.colMAPHIEUDAT.Caption = "Mã phiếu đặt";
            this.colMAPHIEUDAT.FieldName = "MAPHIEUDAT";
            this.colMAPHIEUDAT.Name = "colMAPHIEUDAT";
            this.colMAPHIEUDAT.OptionsColumn.AllowEdit = false;
            this.colMAPHIEUDAT.OptionsColumn.AllowFocus = false;
            this.colMAPHIEUDAT.Visible = true;
            this.colMAPHIEUDAT.VisibleIndex = 0;
            // 
            // colHOTENNGUOINHAN
            // 
            this.colHOTENNGUOINHAN.Caption = "Người nhận";
            this.colHOTENNGUOINHAN.FieldName = "HOTENNGUOINHAN";
            this.colHOTENNGUOINHAN.Name = "colHOTENNGUOINHAN";
            this.colHOTENNGUOINHAN.OptionsColumn.AllowEdit = false;
            this.colHOTENNGUOINHAN.OptionsColumn.AllowFocus = false;
            this.colHOTENNGUOINHAN.Visible = true;
            this.colHOTENNGUOINHAN.VisibleIndex = 1;
            // 
            // colDIACHINGUOINHAN
            // 
            this.colDIACHINGUOINHAN.Caption = "Địa chỉ";
            this.colDIACHINGUOINHAN.FieldName = "DIACHINGUOINHAN";
            this.colDIACHINGUOINHAN.Name = "colDIACHINGUOINHAN";
            this.colDIACHINGUOINHAN.OptionsColumn.AllowEdit = false;
            this.colDIACHINGUOINHAN.OptionsColumn.AllowFocus = false;
            this.colDIACHINGUOINHAN.Visible = true;
            this.colDIACHINGUOINHAN.VisibleIndex = 2;
            // 
            // colSDTNGUOINHAN
            // 
            this.colSDTNGUOINHAN.Caption = "Số điện thoại";
            this.colSDTNGUOINHAN.FieldName = "SDTNGUOINHAN";
            this.colSDTNGUOINHAN.Name = "colSDTNGUOINHAN";
            this.colSDTNGUOINHAN.OptionsColumn.AllowEdit = false;
            this.colSDTNGUOINHAN.OptionsColumn.AllowFocus = false;
            this.colSDTNGUOINHAN.Visible = true;
            this.colSDTNGUOINHAN.VisibleIndex = 3;
            // 
            // colHOTENNV
            // 
            this.colHOTENNV.Caption = "Nhân viên lập phiếu";
            this.colHOTENNV.FieldName = "HOTENNV";
            this.colHOTENNV.Name = "colHOTENNV";
            this.colHOTENNV.OptionsColumn.AllowEdit = false;
            this.colHOTENNV.OptionsColumn.AllowFocus = false;
            this.colHOTENNV.Visible = true;
            this.colHOTENNV.VisibleIndex = 4;
            // 
            // colNGAYDAT
            // 
            this.colNGAYDAT.Caption = "Ngày đặt";
            this.colNGAYDAT.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYDAT.FieldName = "NGAYDAT";
            this.colNGAYDAT.Name = "colNGAYDAT";
            this.colNGAYDAT.OptionsColumn.AllowEdit = false;
            this.colNGAYDAT.OptionsColumn.AllowFocus = false;
            this.colNGAYDAT.Visible = true;
            this.colNGAYDAT.VisibleIndex = 5;
            // 
            // PDAdapter
            // 
            this.PDAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_KMTableAdapter = null;
            this.tableAdapterManager.CT_PDTableAdapter = null;
            this.tableAdapterManager.CT_PNTableAdapter = null;
            this.tableAdapterManager.DONGHOTableAdapter = null;
            this.tableAdapterManager.HANGDONGHOTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIDONGHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UCHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.pcHD);
            this.Name = "UCHoaDon";
            this.Size = new System.Drawing.Size(809, 549);
            ((System.ComponentModel.ISupportInitialize)(this.pcHD)).EndInit();
            this.pcHD.ResumeLayout(false);
            this.pcHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaPD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.PanelControl pcHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLapHD;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl pHIEUDATGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdsPD;
        private DSet dSet;
        private DSetTableAdapters.v_lay_phieu_datTableAdapter PDAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit edtMaPD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHIEUDAT;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENNGUOINHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHINGUOINHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTNGUOINHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYDAT;
    }
}