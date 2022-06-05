
namespace BANDONGHO_TTCS
{
    partial class UCHangDongHo
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
            System.Windows.Forms.Label mAHANGLabel;
            System.Windows.Forms.Label tENHANGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHangDongHo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dSet = new BANDONGHO_TTCS.DSet();
            this.hANGDONGHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGDONGHOTableAdapter = new BANDONGHO_TTCS.DSetTableAdapters.HANGDONGHOTableAdapter();
            this.tableAdapterManager = new BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager();
            this.hANGDONGHOGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ttHANGDONGHO = new System.Windows.Forms.GroupBox();
            this.mAHANGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENHANGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dONGHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dONGHOTableAdapter = new BANDONGHO_TTCS.DSetTableAdapters.DONGHOTableAdapter();
            mAHANGLabel = new System.Windows.Forms.Label();
            tENHANGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGDONGHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGDONGHOGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.ttHANGDONGHO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAHANGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENHANGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHANGLabel
            // 
            mAHANGLabel.AutoSize = true;
            mAHANGLabel.Location = new System.Drawing.Point(86, 145);
            mAHANGLabel.Name = "mAHANGLabel";
            mAHANGLabel.Size = new System.Drawing.Size(91, 23);
            mAHANGLabel.TabIndex = 0;
            mAHANGLabel.Text = "Mã hãng:";
            // 
            // tENHANGLabel
            // 
            tENHANGLabel.AutoSize = true;
            tENHANGLabel.Location = new System.Drawing.Point(86, 195);
            tENHANGLabel.Name = "tENHANGLabel";
            tENHANGLabel.Size = new System.Drawing.Size(98, 23);
            tENHANGLabel.TabIndex = 2;
            tENHANGLabel.Text = "Tên hãng:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1143, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 679);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1143, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 628);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1143, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 628);
            // 
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hANGDONGHOBindingSource
            // 
            this.hANGDONGHOBindingSource.DataMember = "HANGDONGHO";
            this.hANGDONGHOBindingSource.DataSource = this.dSet;
            // 
            // hANGDONGHOTableAdapter
            // 
            this.hANGDONGHOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_KMTableAdapter = null;
            this.tableAdapterManager.CT_PDTableAdapter = null;
            this.tableAdapterManager.CT_PNTableAdapter = null;
            this.tableAdapterManager.DONGHOTableAdapter = null;
            this.tableAdapterManager.HANGDONGHOTableAdapter = this.hANGDONGHOTableAdapter;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIDONGHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hANGDONGHOGridControl
            // 
            this.hANGDONGHOGridControl.DataSource = this.hANGDONGHOBindingSource;
            this.hANGDONGHOGridControl.Location = new System.Drawing.Point(3, 103);
            this.hANGDONGHOGridControl.MainView = this.gridView1;
            this.hANGDONGHOGridControl.MenuManager = this.barManager1;
            this.hANGDONGHOGridControl.Name = "hANGDONGHOGridControl";
            this.hANGDONGHOGridControl.Size = new System.Drawing.Size(640, 570);
            this.hANGDONGHOGridControl.TabIndex = 5;
            this.hANGDONGHOGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHANG,
            this.colTENHANG});
            this.gridView1.GridControl = this.hANGDONGHOGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHANG
            // 
            this.colMAHANG.Caption = "Mã hãng";
            this.colMAHANG.FieldName = "MAHANG";
            this.colMAHANG.MinWidth = 25;
            this.colMAHANG.Name = "colMAHANG";
            this.colMAHANG.Visible = true;
            this.colMAHANG.VisibleIndex = 0;
            this.colMAHANG.Width = 94;
            // 
            // colTENHANG
            // 
            this.colTENHANG.Caption = "Tên hãng";
            this.colTENHANG.FieldName = "TENHANG";
            this.colTENHANG.MinWidth = 25;
            this.colTENHANG.Name = "colTENHANG";
            this.colTENHANG.Visible = true;
            this.colTENHANG.VisibleIndex = 1;
            this.colTENHANG.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(190, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách hãng đồng hồ";
            // 
            // ttHANGDONGHO
            // 
            this.ttHANGDONGHO.Controls.Add(mAHANGLabel);
            this.ttHANGDONGHO.Controls.Add(this.mAHANGTextEdit);
            this.ttHANGDONGHO.Controls.Add(tENHANGLabel);
            this.ttHANGDONGHO.Controls.Add(this.tENHANGTextEdit);
            this.ttHANGDONGHO.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ttHANGDONGHO.Location = new System.Drawing.Point(672, 157);
            this.ttHANGDONGHO.Name = "ttHANGDONGHO";
            this.ttHANGDONGHO.Size = new System.Drawing.Size(458, 418);
            this.ttHANGDONGHO.TabIndex = 7;
            this.ttHANGDONGHO.TabStop = false;
            this.ttHANGDONGHO.Text = "Thông tin hãng đồng hồ";
            // 
            // mAHANGTextEdit
            // 
            this.mAHANGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hANGDONGHOBindingSource, "MAHANG", true));
            this.mAHANGTextEdit.Location = new System.Drawing.Point(183, 147);
            this.mAHANGTextEdit.MenuManager = this.barManager1;
            this.mAHANGTextEdit.Name = "mAHANGTextEdit";
            this.mAHANGTextEdit.Size = new System.Drawing.Size(125, 22);
            this.mAHANGTextEdit.TabIndex = 1;
            // 
            // tENHANGTextEdit
            // 
            this.tENHANGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hANGDONGHOBindingSource, "TENHANG", true));
            this.tENHANGTextEdit.Location = new System.Drawing.Point(190, 197);
            this.tENHANGTextEdit.MenuManager = this.barManager1;
            this.tENHANGTextEdit.Name = "tENHANGTextEdit";
            this.tENHANGTextEdit.Size = new System.Drawing.Size(125, 22);
            this.tENHANGTextEdit.TabIndex = 3;
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
            // UCHangDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ttHANGDONGHO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hANGDONGHOGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCHangDongHo";
            this.Size = new System.Drawing.Size(1143, 699);
            this.Load += new System.EventHandler(this.UCHangDongHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGDONGHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGDONGHOGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ttHANGDONGHO.ResumeLayout(false);
            this.ttHANGDONGHO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAHANGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENHANGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGHOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource hANGDONGHOBindingSource;
        private DSet dSet;
        private DSetTableAdapters.HANGDONGHOTableAdapter hANGDONGHOTableAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl hANGDONGHOGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox ttHANGDONGHO;
        private DevExpress.XtraEditors.TextEdit mAHANGTextEdit;
        private DevExpress.XtraEditors.TextEdit tENHANGTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHANG;
        private DevExpress.XtraGrid.Columns.GridColumn colTENHANG;
        private System.Windows.Forms.BindingSource dONGHOBindingSource;
        private DSetTableAdapters.DONGHOTableAdapter dONGHOTableAdapter;
    }
}
