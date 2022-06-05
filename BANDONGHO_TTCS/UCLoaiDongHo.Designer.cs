
namespace BANDONGHO_TTCS
{
    partial class UCLoaiDongHo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoaiDongHo));
            System.Windows.Forms.Label mALOAILabel;
            System.Windows.Forms.Label tENLOAILabel;
            System.Windows.Forms.Label mOTALabel;
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dSet = new BANDONGHO_TTCS.DSet();
            this.lOAIDONGHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIDONGHOTableAdapter = new BANDONGHO_TTCS.DSetTableAdapters.LOAIDONGHOTableAdapter();
            this.tableAdapterManager = new BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager();
            this.lOAIDONGHOGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMOTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ttLOAIDONGHO = new System.Windows.Forms.GroupBox();
            this.mALOAITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLOAITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txtboxMoTa = new System.Windows.Forms.TextBox();
            this.dONGHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONGHOTableAdapter = new BANDONGHO_TTCS.DSetTableAdapters.DONGHOTableAdapter();
            mALOAILabel = new System.Windows.Forms.Label();
            tENLOAILabel = new System.Windows.Forms.Label();
            mOTALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDONGHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDONGHOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.ttLOAIDONGHO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOAITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOAITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnHuyBo,
            this.btnLamMoi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Caption = "Hủy bỏ";
            this.btnHuyBo.Id = 4;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.LargeImage")));
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyBo_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 5;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1134, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 716);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1134, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 665);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1134, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 665);
            // 
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIDONGHOBindingSource
            // 
            this.lOAIDONGHOBindingSource.DataMember = "LOAIDONGHO";
            this.lOAIDONGHOBindingSource.DataSource = this.dSet;
            // 
            // lOAIDONGHOTableAdapter
            // 
            this.lOAIDONGHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_KMTableAdapter = null;
            this.tableAdapterManager.CT_PDTableAdapter = null;
            this.tableAdapterManager.CT_PNTableAdapter = null;
            this.tableAdapterManager.DONGHOTableAdapter = this.dONGHOTableAdapter;
            this.tableAdapterManager.HANGDONGHOTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIDONGHOTableAdapter = this.lOAIDONGHOTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOAIDONGHOGridControl
            // 
            this.lOAIDONGHOGridControl.DataSource = this.lOAIDONGHOBindingSource;
            this.lOAIDONGHOGridControl.Location = new System.Drawing.Point(3, 103);
            this.lOAIDONGHOGridControl.MainView = this.gridView1;
            this.lOAIDONGHOGridControl.MenuManager = this.barManager1;
            this.lOAIDONGHOGridControl.Name = "lOAIDONGHOGridControl";
            this.lOAIDONGHOGridControl.Size = new System.Drawing.Size(690, 607);
            this.lOAIDONGHOGridControl.TabIndex = 5;
            this.lOAIDONGHOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAI,
            this.colTENLOAI,
            this.colMOTA});
            this.gridView1.GridControl = this.lOAIDONGHOGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(207, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách loại đồng hồ";
            // 
            // colMALOAI
            // 
            this.colMALOAI.Caption = "Mã loại";
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.MinWidth = 25;
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 0;
            this.colMALOAI.Width = 94;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.Caption = "Tên loại";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.MinWidth = 25;
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 1;
            this.colTENLOAI.Width = 94;
            // 
            // colMOTA
            // 
            this.colMOTA.Caption = "Mô tả";
            this.colMOTA.FieldName = "MOTA";
            this.colMOTA.MinWidth = 25;
            this.colMOTA.Name = "colMOTA";
            this.colMOTA.Visible = true;
            this.colMOTA.VisibleIndex = 2;
            this.colMOTA.Width = 94;
            // 
            // ttLOAIDONGHO
            // 
            this.ttLOAIDONGHO.Controls.Add(this.txtboxMoTa);
            this.ttLOAIDONGHO.Controls.Add(mALOAILabel);
            this.ttLOAIDONGHO.Controls.Add(this.mALOAITextEdit);
            this.ttLOAIDONGHO.Controls.Add(tENLOAILabel);
            this.ttLOAIDONGHO.Controls.Add(this.tENLOAITextEdit);
            this.ttLOAIDONGHO.Controls.Add(mOTALabel);
            this.ttLOAIDONGHO.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ttLOAIDONGHO.Location = new System.Drawing.Point(721, 129);
            this.ttLOAIDONGHO.Name = "ttLOAIDONGHO";
            this.ttLOAIDONGHO.Size = new System.Drawing.Size(392, 515);
            this.ttLOAIDONGHO.TabIndex = 8;
            this.ttLOAIDONGHO.TabStop = false;
            this.ttLOAIDONGHO.Text = "Thông tin loại đồng hồ";
            // 
            // mALOAILabel
            // 
            mALOAILabel.AutoSize = true;
            mALOAILabel.Location = new System.Drawing.Point(72, 86);
            mALOAILabel.Name = "mALOAILabel";
            mALOAILabel.Size = new System.Drawing.Size(76, 23);
            mALOAILabel.TabIndex = 0;
            mALOAILabel.Text = "Mã loại:";
            // 
            // mALOAITextEdit
            // 
            this.mALOAITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAIDONGHOBindingSource, "MALOAI", true));
            this.mALOAITextEdit.Location = new System.Drawing.Point(154, 83);
            this.mALOAITextEdit.MenuManager = this.barManager1;
            this.mALOAITextEdit.Name = "mALOAITextEdit";
            this.mALOAITextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.mALOAITextEdit.Properties.Appearance.Options.UseFont = true;
            this.mALOAITextEdit.Size = new System.Drawing.Size(125, 28);
            this.mALOAITextEdit.TabIndex = 1;
            // 
            // tENLOAILabel
            // 
            tENLOAILabel.AutoSize = true;
            tENLOAILabel.Location = new System.Drawing.Point(72, 137);
            tENLOAILabel.Name = "tENLOAILabel";
            tENLOAILabel.Size = new System.Drawing.Size(83, 23);
            tENLOAILabel.TabIndex = 2;
            tENLOAILabel.Text = "Tên loại:";
            // 
            // tENLOAITextEdit
            // 
            this.tENLOAITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAIDONGHOBindingSource, "TENLOAI", true));
            this.tENLOAITextEdit.Location = new System.Drawing.Point(161, 134);
            this.tENLOAITextEdit.MenuManager = this.barManager1;
            this.tENLOAITextEdit.Name = "tENLOAITextEdit";
            this.tENLOAITextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tENLOAITextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENLOAITextEdit.Size = new System.Drawing.Size(125, 28);
            this.tENLOAITextEdit.TabIndex = 3;
            // 
            // mOTALabel
            // 
            mOTALabel.AutoSize = true;
            mOTALabel.Location = new System.Drawing.Point(72, 192);
            mOTALabel.Name = "mOTALabel";
            mOTALabel.Size = new System.Drawing.Size(64, 23);
            mOTALabel.TabIndex = 4;
            mOTALabel.Text = "Mô tả:";
            // 
            // txtboxMoTa
            // 
            this.txtboxMoTa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAIDONGHOBindingSource, "MOTA", true));
            this.txtboxMoTa.Location = new System.Drawing.Point(76, 229);
            this.txtboxMoTa.Multiline = true;
            this.txtboxMoTa.Name = "txtboxMoTa";
            this.txtboxMoTa.Size = new System.Drawing.Size(284, 211);
            this.txtboxMoTa.TabIndex = 5;
            // 
            // dONGHOBindingSource
            // 
            this.dONGHOBindingSource.DataMember = "DONGHO";
            this.dONGHOBindingSource.DataSource = this.dSet;
            // 
            // dONGHOTableAdapter
            // 
            this.dONGHOTableAdapter.ClearBeforeFill = true;
            // 
            // UCLoaiDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ttLOAIDONGHO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lOAIDONGHOGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCLoaiDongHo";
            this.Size = new System.Drawing.Size(1134, 736);
            this.Load += new System.EventHandler(this.UCLoaiDongHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDONGHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDONGHOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ttLOAIDONGHO.ResumeLayout(false);
            this.ttLOAIDONGHO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALOAITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOAITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource lOAIDONGHOBindingSource;
        private DSet dSet;
        private DSetTableAdapters.LOAIDONGHOTableAdapter lOAIDONGHOTableAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOAIDONGHOGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ttLOAIDONGHO;
        private System.Windows.Forms.TextBox txtboxMoTa;
        private DevExpress.XtraEditors.TextEdit mALOAITextEdit;
        private DevExpress.XtraEditors.TextEdit tENLOAITextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colMOTA;
        private DSetTableAdapters.DONGHOTableAdapter dONGHOTableAdapter;
        private System.Windows.Forms.BindingSource dONGHOBindingSource;
    }
}
