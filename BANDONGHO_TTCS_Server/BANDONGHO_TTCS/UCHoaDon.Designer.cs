
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHoaDon));
            this.mAPHIEUDATLabel = new System.Windows.Forms.Label();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.pcHD = new DevExpress.XtraEditors.PanelControl();
            this.edtMaPD = new DevExpress.XtraEditors.TextEdit();
            this.bdsPD = new System.Windows.Forms.BindingSource(this.components);
            this.dSet = new BANDONGHO_TTCS.DSet();
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
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.pcHD)).BeginInit();
            this.pcHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMaPD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPHIEUDATLabel
            // 
            this.mAPHIEUDATLabel.AutoSize = true;
            this.mAPHIEUDATLabel.Location = new System.Drawing.Point(206, 53);
            this.mAPHIEUDATLabel.Name = "mAPHIEUDATLabel";
            this.mAPHIEUDATLabel.Size = new System.Drawing.Size(62, 17);
            this.mAPHIEUDATLabel.TabIndex = 3;
            this.mAPHIEUDATLabel.Text = "Mã phiếu";
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
            this.pcHD.Controls.Add(this.mAPHIEUDATLabel);
            this.pcHD.Controls.Add(this.edtMaPD);
            this.pcHD.Controls.Add(this.btnLapHD);
            this.pcHD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pcHD.Location = new System.Drawing.Point(0, 497);
            this.pcHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcHD.Name = "pcHD";
            this.pcHD.Size = new System.Drawing.Size(944, 159);
            this.pcHD.TabIndex = 2;
            // 
            // edtMaPD
            // 
            this.edtMaPD.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPD, "MAPHIEUDAT", true));
            this.edtMaPD.Location = new System.Drawing.Point(302, 49);
            this.edtMaPD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edtMaPD.Name = "edtMaPD";
            this.edtMaPD.Properties.ReadOnly = true;
            this.edtMaPD.Size = new System.Drawing.Size(167, 22);
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
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(577, 46);
            this.btnLapHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(87, 28);
            this.btnLapHD.TabIndex = 2;
            this.btnLapHD.Text = "Lập hoá đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pHIEUDATGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 30);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(944, 467);
            this.panelControl2.TabIndex = 3;
            // 
            // pHIEUDATGridControl
            // 
            this.pHIEUDATGridControl.DataSource = this.bdsPD;
            this.pHIEUDATGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHIEUDATGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pHIEUDATGridControl.Location = new System.Drawing.Point(2, 2);
            this.pHIEUDATGridControl.MainView = this.gridView1;
            this.pHIEUDATGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pHIEUDATGridControl.Name = "pHIEUDATGridControl";
            this.pHIEUDATGridControl.Size = new System.Drawing.Size(940, 463);
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
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.pHIEUDATGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPHIEUDAT
            // 
            this.colMAPHIEUDAT.Caption = "Mã phiếu đặt";
            this.colMAPHIEUDAT.FieldName = "MAPHIEUDAT";
            this.colMAPHIEUDAT.MinWidth = 23;
            this.colMAPHIEUDAT.Name = "colMAPHIEUDAT";
            this.colMAPHIEUDAT.OptionsColumn.AllowEdit = false;
            this.colMAPHIEUDAT.OptionsColumn.AllowFocus = false;
            this.colMAPHIEUDAT.Visible = true;
            this.colMAPHIEUDAT.VisibleIndex = 0;
            this.colMAPHIEUDAT.Width = 87;
            // 
            // colHOTENNGUOINHAN
            // 
            this.colHOTENNGUOINHAN.Caption = "Người nhận";
            this.colHOTENNGUOINHAN.FieldName = "HOTENNGUOINHAN";
            this.colHOTENNGUOINHAN.MinWidth = 23;
            this.colHOTENNGUOINHAN.Name = "colHOTENNGUOINHAN";
            this.colHOTENNGUOINHAN.OptionsColumn.AllowEdit = false;
            this.colHOTENNGUOINHAN.OptionsColumn.AllowFocus = false;
            this.colHOTENNGUOINHAN.Visible = true;
            this.colHOTENNGUOINHAN.VisibleIndex = 1;
            this.colHOTENNGUOINHAN.Width = 87;
            // 
            // colDIACHINGUOINHAN
            // 
            this.colDIACHINGUOINHAN.Caption = "Địa chỉ";
            this.colDIACHINGUOINHAN.FieldName = "DIACHINGUOINHAN";
            this.colDIACHINGUOINHAN.MinWidth = 23;
            this.colDIACHINGUOINHAN.Name = "colDIACHINGUOINHAN";
            this.colDIACHINGUOINHAN.OptionsColumn.AllowEdit = false;
            this.colDIACHINGUOINHAN.OptionsColumn.AllowFocus = false;
            this.colDIACHINGUOINHAN.Visible = true;
            this.colDIACHINGUOINHAN.VisibleIndex = 2;
            this.colDIACHINGUOINHAN.Width = 87;
            // 
            // colSDTNGUOINHAN
            // 
            this.colSDTNGUOINHAN.Caption = "Số điện thoại";
            this.colSDTNGUOINHAN.FieldName = "SDTNGUOINHAN";
            this.colSDTNGUOINHAN.MinWidth = 23;
            this.colSDTNGUOINHAN.Name = "colSDTNGUOINHAN";
            this.colSDTNGUOINHAN.OptionsColumn.AllowEdit = false;
            this.colSDTNGUOINHAN.OptionsColumn.AllowFocus = false;
            this.colSDTNGUOINHAN.Visible = true;
            this.colSDTNGUOINHAN.VisibleIndex = 3;
            this.colSDTNGUOINHAN.Width = 87;
            // 
            // colHOTENNV
            // 
            this.colHOTENNV.Caption = "Nhân viên lập phiếu";
            this.colHOTENNV.FieldName = "HOTENNV";
            this.colHOTENNV.MinWidth = 23;
            this.colHOTENNV.Name = "colHOTENNV";
            this.colHOTENNV.OptionsColumn.AllowEdit = false;
            this.colHOTENNV.OptionsColumn.AllowFocus = false;
            this.colHOTENNV.Visible = true;
            this.colHOTENNV.VisibleIndex = 4;
            this.colHOTENNV.Width = 87;
            // 
            // colNGAYDAT
            // 
            this.colNGAYDAT.Caption = "Ngày đặt";
            this.colNGAYDAT.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAYDAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYDAT.FieldName = "NGAYDAT";
            this.colNGAYDAT.MinWidth = 23;
            this.colNGAYDAT.Name = "colNGAYDAT";
            this.colNGAYDAT.OptionsColumn.AllowEdit = false;
            this.colNGAYDAT.OptionsColumn.AllowFocus = false;
            this.colNGAYDAT.Visible = true;
            this.colNGAYDAT.VisibleIndex = 5;
            this.colNGAYDAT.Width = 87;
            // 
            // PDAdapter
            // 
            this.PDAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_GIOHANGTableAdapter = null;
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
            // bar7
            // 
            this.bar7.BarName = "Main menu";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.OptionsBar.MultiLine = true;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThoat,
            this.btnReload});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 1;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 0;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(944, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 656);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(944, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 626);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(944, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 626);
            // 
            // UCHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.pcHD);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCHoaDon";
            this.Size = new System.Drawing.Size(944, 676);
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
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.PanelControl pcHD;
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
        private System.Windows.Forms.Label mAPHIEUDATLabel;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}