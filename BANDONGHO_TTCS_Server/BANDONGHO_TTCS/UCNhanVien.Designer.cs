
namespace BANDONGHO_TTCS
{
    partial class UCNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoaHoacMoKhoaTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapHoacThuHoiQuyenQuanLy = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnExist = new DevExpress.XtraBars.BarButtonItem();
            this.dSet = new BANDONGHO_TTCS.DSet();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new BANDONGHO_TTCS.DSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelInput = new System.Windows.Forms.Panel();
            this.gioiTinhGroup = new DevExpress.XtraEditors.RadioGroup();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(119, 48);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(46, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(444, 46);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(71, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ Và Tên";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(480, 102);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(70, 17);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "Ngày Sinh";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(115, 211);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(50, 17);
            dIACHILabel.TabIndex = 10;
            dIACHILabel.Text = "Địa Chỉ";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(518, 154);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(34, 17);
            sDTLabel.TabIndex = 12;
            sDTLabel.Text = "SĐT";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(126, 152);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(39, 17);
            eMAILLabel.TabIndex = 14;
            eMAILLabel.Text = "Email";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(108, 102);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(57, 17);
            gIOITINHLabel.TabIndex = 15;
            gIOITINHLabel.Text = "Giớ Tính";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.btnLoad,
            this.btnUndo,
            this.btnExist,
            this.btnCapTaiKhoan,
            this.btnKhoaHoacMoKhoaTaiKhoan,
            this.btnCapHoacThuHoiQuyenQuanLy});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCapTaiKhoan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnKhoaHoacMoKhoaTaiKhoan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCapHoacThuHoiQuyenQuanLy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoad)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnThem.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnCapTaiKhoan
            // 
            this.btnCapTaiKhoan.Caption = "Cấp Tài Khoản";
            this.btnCapTaiKhoan.Id = 7;
            this.btnCapTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapTaiKhoan.ImageOptions.SvgImage")));
            this.btnCapTaiKhoan.Name = "btnCapTaiKhoan";
            this.btnCapTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapTaiKhoan_ItemClick);
            // 
            // btnKhoaHoacMoKhoaTaiKhoan
            // 
            this.btnKhoaHoacMoKhoaTaiKhoan.Caption = "Khóa/Mở Khóa Tài Khoản";
            this.btnKhoaHoacMoKhoaTaiKhoan.Id = 8;
            this.btnKhoaHoacMoKhoaTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKhoaHoacMoKhoaTaiKhoan.ImageOptions.SvgImage")));
            this.btnKhoaHoacMoKhoaTaiKhoan.Name = "btnKhoaHoacMoKhoaTaiKhoan";
            this.btnKhoaHoacMoKhoaTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnCapHoacThuHoiQuyenQuanLy
            // 
            this.btnCapHoacThuHoiQuyenQuanLy.Caption = "Cấp/Thu Hồi Quyền Quản Lý";
            this.btnCapHoacThuHoiQuyenQuanLy.Id = 9;
            this.btnCapHoacThuHoiQuyenQuanLy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCapHoacThuHoiQuyenQuanLy.ImageOptions.SvgImage")));
            this.btnCapHoacThuHoiQuyenQuanLy.Name = "btnCapHoacThuHoiQuyenQuanLy";
            this.btnCapHoacThuHoiQuyenQuanLy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Hủy";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 5;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Reload";
            this.btnLoad.Id = 4;
            this.btnLoad.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoad.ImageOptions.SvgImage")));
            this.btnLoad.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnLoad.ItemAppearance.Normal.Options.UseFont = true;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1032, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 560);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1032, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1032, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnExist
            // 
            this.btnExist.Caption = "Thoát";
            this.btnExist.Id = 6;
            this.btnExist.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExist.ImageOptions.SvgImage")));
            this.btnExist.Name = "btnExist";
            this.btnExist.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // dSet
            // 
            this.dSet.DataSetName = "DSet";
            this.dSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NHANVIEN";
            this.bdsNhanVien.DataSource = this.dSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIDONGHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BANDONGHO_TTCS.DSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.bdsNhanVien;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(0, 30);
            this.nHANVIENGridControl.MainView = this.gridView1;
            this.nHANVIENGridControl.MenuManager = this.barManager1;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(1032, 530);
            this.nHANVIENGridControl.TabIndex = 5;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colGIOITINH,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colSDT,
            this.colEMAIL});
            this.gridView1.GridControl = this.nHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 117;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.OptionsColumn.AllowEdit = false;
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 173;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.OptionsColumn.AllowEdit = false;
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 87;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.FieldName = "GIOITINH";
            this.colGIOITINH.MinWidth = 25;
            this.colGIOITINH.Name = "colGIOITINH";
            this.colGIOITINH.OptionsColumn.AllowEdit = false;
            this.colGIOITINH.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.OptionsColumn.AllowEdit = false;
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            this.colNGAYSINH.Width = 114;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.OptionsColumn.AllowEdit = false;
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 226;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.MinWidth = 25;
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsColumn.AllowEdit = false;
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 5;
            this.colEMAIL.Width = 285;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(gIOITINHLabel);
            this.panelInput.Controls.Add(this.gioiTinhGroup);
            this.panelInput.Controls.Add(eMAILLabel);
            this.panelInput.Controls.Add(this.txtEmail);
            this.panelInput.Controls.Add(sDTLabel);
            this.panelInput.Controls.Add(this.txtSDT);
            this.panelInput.Controls.Add(dIACHILabel);
            this.panelInput.Controls.Add(this.txtDiaChi);
            this.panelInput.Controls.Add(nGAYSINHLabel);
            this.panelInput.Controls.Add(this.txtNgaySinh);
            this.panelInput.Controls.Add(this.txtTen);
            this.panelInput.Controls.Add(hOLabel);
            this.panelInput.Controls.Add(this.txtHo);
            this.panelInput.Controls.Add(mANVLabel);
            this.panelInput.Controls.Add(this.txtMaNV);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Enabled = false;
            this.panelInput.Location = new System.Drawing.Point(0, 216);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1032, 344);
            this.panelInput.TabIndex = 10;
            this.panelInput.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gioiTinhGroup
            // 
            this.gioiTinhGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "GIOITINH", true));
            this.gioiTinhGroup.EditValue = ((short)(0));
            this.gioiTinhGroup.Location = new System.Drawing.Point(184, 102);
            this.gioiTinhGroup.MenuManager = this.barManager1;
            this.gioiTinhGroup.Name = "gioiTinhGroup";
            this.gioiTinhGroup.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gioiTinhGroup.Properties.Appearance.Options.UseBackColor = true;
            this.gioiTinhGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gioiTinhGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Nữ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Khác")});
            this.gioiTinhGroup.Size = new System.Drawing.Size(278, 25);
            this.gioiTinhGroup.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "EMAIL", true));
            this.txtEmail.EditValue = "test@gmail.com";
            this.txtEmail.Location = new System.Drawing.Point(184, 149);
            this.txtEmail.MenuManager = this.barManager1;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "SDT", true));
            this.txtSDT.EditValue = "0973343541";
            this.txtSDT.Location = new System.Drawing.Point(563, 151);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Mask.EditMask = "0\\d{8,9}";
            this.txtSDT.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.txtSDT.Properties.Mask.PlaceHolder = '-';
            this.txtSDT.Size = new System.Drawing.Size(286, 22);
            this.txtSDT.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "DIACHI", true));
            this.txtDiaChi.EditValue = "230/14 Man Thiện, Thủ Đức";
            this.txtDiaChi.Location = new System.Drawing.Point(184, 208);
            this.txtDiaChi.MenuManager = this.barManager1;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(665, 22);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "NGAYSINH", true));
            this.txtNgaySinh.EditValue = null;
            this.txtNgaySinh.Location = new System.Drawing.Point(563, 99);
            this.txtNgaySinh.MenuManager = this.barManager1;
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaySinh.Size = new System.Drawing.Size(174, 22);
            this.txtNgaySinh.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "TEN", true));
            this.txtTen.EditValue = "A";
            this.txtTen.Location = new System.Drawing.Point(772, 43);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(77, 22);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "HO", true));
            this.txtHo.EditValue = "Nguyễn Văn";
            this.txtHo.Location = new System.Drawing.Point(521, 43);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(241, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "MANV", true));
            this.txtMaNV.EditValue = "TESTNV";
            this.txtMaNV.Location = new System.Drawing.Point(184, 45);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Mask.EditMask = "\\p{Lu}+";
            this.txtMaNV.Size = new System.Drawing.Size(174, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.nHANVIENGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(1032, 560);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnExist;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DSet dSet;
        private DSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colGIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private System.Windows.Forms.Panel panelInput;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.DateEdit txtNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.RadioGroup gioiTinhGroup;
        private DevExpress.XtraBars.BarButtonItem btnCapTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnKhoaHoacMoKhoaTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnCapHoacThuHoiQuyenQuanLy;
    }
}
