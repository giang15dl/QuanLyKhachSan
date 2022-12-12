
namespace QLKhachSan.UI
{
    partial class ucQLTrangBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLTrangBi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBo = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.leThietBi = new DevExpress.XtraEditors.LookUpEdit();
            this.leSoPhong = new DevExpress.XtraEditors.LookUpEdit();
            this.deNgayKetThucTrangBi = new DevExpress.XtraEditors.DateEdit();
            this.gcTrangBi = new DevExpress.XtraGrid.GridControl();
            this.tTrangBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvTrangBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBatDauTrangBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThucTrangBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deNgayBatDauTrangBi = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leThietBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSoPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThucTrangBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThucTrangBi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrangBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTrangBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrangBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDauTrangBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDauTrangBi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThietBiBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnSua,
            this.btnXoa,
            this.btnHuyBo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.btnThem.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ItemAppearance.Normal.Options.UseFont = true;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Caption = "Hủy bỏ";
            this.btnHuyBo.Id = 3;
            this.btnHuyBo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.Image")));
            this.btnHuyBo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.ImageOptions.LargeImage")));
            this.btnHuyBo.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuyBo.ItemAppearance.Normal.Options.UseFont = true;
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyBo_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(975, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 702);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(975, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 669);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(975, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 669);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.leThietBi);
            this.layoutControl1.Controls.Add(this.leSoPhong);
            this.layoutControl1.Controls.Add(this.deNgayKetThucTrangBi);
            this.layoutControl1.Controls.Add(this.gcTrangBi);
            this.layoutControl1.Controls.Add(this.deNgayBatDauTrangBi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 33);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(975, 669);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // leThietBi
            // 
            this.leThietBi.Location = new System.Drawing.Point(233, 90);
            this.leThietBi.MaximumSize = new System.Drawing.Size(200, 0);
            this.leThietBi.MenuManager = this.barManager1;
            this.leThietBi.MinimumSize = new System.Drawing.Size(200, 0);
            this.leThietBi.Name = "leThietBi";
            this.leThietBi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.leThietBi.Properties.Appearance.Options.UseFont = true;
            this.leThietBi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leThietBi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaThietBi", "Mã thiết bị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenThietBi", "Tên thiết bị"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgayMua", "Ngày mua"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GiaMua", "Giá mua"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TinhNang", "Tính năng")});
            this.leThietBi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leThietBi.Size = new System.Drawing.Size(200, 28);
            this.leThietBi.StyleController = this.layoutControl1;
            this.leThietBi.TabIndex = 12;
            // 
            // leSoPhong
            // 
            this.leSoPhong.Location = new System.Drawing.Point(233, 50);
            this.leSoPhong.MaximumSize = new System.Drawing.Size(200, 0);
            this.leSoPhong.MenuManager = this.barManager1;
            this.leSoPhong.MinimumSize = new System.Drawing.Size(200, 0);
            this.leSoPhong.Name = "leSoPhong";
            this.leSoPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.leSoPhong.Properties.Appearance.Options.UseFont = true;
            this.leSoPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leSoPhong.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoPhong", "Số phòng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GiaTien", "Giá tiền"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TinhTrang", "Tình trạng")});
            this.leSoPhong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.leSoPhong.Size = new System.Drawing.Size(200, 28);
            this.leSoPhong.StyleController = this.layoutControl1;
            this.leSoPhong.TabIndex = 11;
            // 
            // deNgayKetThucTrangBi
            // 
            this.deNgayKetThucTrangBi.EditValue = null;
            this.deNgayKetThucTrangBi.Location = new System.Drawing.Point(236, 173);
            this.deNgayKetThucTrangBi.MaximumSize = new System.Drawing.Size(200, 0);
            this.deNgayKetThucTrangBi.MenuManager = this.barManager1;
            this.deNgayKetThucTrangBi.MinimumSize = new System.Drawing.Size(200, 0);
            this.deNgayKetThucTrangBi.Name = "deNgayKetThucTrangBi";
            this.deNgayKetThucTrangBi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deNgayKetThucTrangBi.Properties.Appearance.Options.UseFont = true;
            this.deNgayKetThucTrangBi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThucTrangBi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayKetThucTrangBi.Size = new System.Drawing.Size(200, 28);
            this.deNgayKetThucTrangBi.StyleController = this.layoutControl1;
            this.deNgayKetThucTrangBi.TabIndex = 10;
            // 
            // gcTrangBi
            // 
            this.gcTrangBi.DataSource = this.tTrangBiBindingSource;
            this.gcTrangBi.Location = new System.Drawing.Point(24, 270);
            this.gcTrangBi.MainView = this.gvTrangBi;
            this.gcTrangBi.MenuManager = this.barManager1;
            this.gcTrangBi.Name = "gcTrangBi";
            this.gcTrangBi.Size = new System.Drawing.Size(927, 375);
            this.gcTrangBi.TabIndex = 9;
            this.gcTrangBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTrangBi});
            // 
            // tTrangBiBindingSource
            // 
            this.tTrangBiBindingSource.DataSource = typeof(QLKhachSan.Model.tTrangBi);
            // 
            // gvTrangBi
            // 
            this.gvTrangBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colSoPhong,
            this.colMaThietBi,
            this.colTenThietBi,
            this.colNgayBatDauTrangBi,
            this.colNgayKetThucTrangBi});
            this.gvTrangBi.GridControl = this.gcTrangBi;
            this.gvTrangBi.Name = "gvTrangBi";
            this.gvTrangBi.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gvTrangBi.OptionsFind.AlwaysVisible = true;
            this.gvTrangBi.OptionsView.ShowGroupPanel = false;
            this.gvTrangBi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvTrangBi_RowClick);
            this.gvTrangBi.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvTrangBi_RowCellClick);
            this.gvTrangBi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvTrangBi_KeyDown);
            this.gvTrangBi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvTrangBi_KeyUp);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.MinWidth = 25;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 94;
            // 
            // colSoPhong
            // 
            this.colSoPhong.AppearanceCell.Options.UseTextOptions = true;
            this.colSoPhong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSoPhong.Caption = "Số phòng";
            this.colSoPhong.FieldName = "SoPhong";
            this.colSoPhong.MinWidth = 25;
            this.colSoPhong.Name = "colSoPhong";
            this.colSoPhong.Visible = true;
            this.colSoPhong.VisibleIndex = 1;
            this.colSoPhong.Width = 94;
            // 
            // colMaThietBi
            // 
            this.colMaThietBi.AppearanceCell.Options.UseTextOptions = true;
            this.colMaThietBi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaThietBi.Caption = "Mã thiết bị";
            this.colMaThietBi.FieldName = "MaThietBi";
            this.colMaThietBi.MinWidth = 25;
            this.colMaThietBi.Name = "colMaThietBi";
            this.colMaThietBi.Visible = true;
            this.colMaThietBi.VisibleIndex = 2;
            this.colMaThietBi.Width = 94;
            // 
            // colTenThietBi
            // 
            this.colTenThietBi.AppearanceCell.Options.UseTextOptions = true;
            this.colTenThietBi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTenThietBi.Caption = "Tên thiết bị";
            this.colTenThietBi.FieldName = "TenThietBi";
            this.colTenThietBi.MinWidth = 25;
            this.colTenThietBi.Name = "colTenThietBi";
            this.colTenThietBi.Visible = true;
            this.colTenThietBi.VisibleIndex = 3;
            this.colTenThietBi.Width = 94;
            // 
            // colNgayBatDauTrangBi
            // 
            this.colNgayBatDauTrangBi.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayBatDauTrangBi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNgayBatDauTrangBi.Caption = "Ngày bắt đầu trang bị";
            this.colNgayBatDauTrangBi.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayBatDauTrangBi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayBatDauTrangBi.FieldName = "NgayBatDauTrangBi";
            this.colNgayBatDauTrangBi.MinWidth = 25;
            this.colNgayBatDauTrangBi.Name = "colNgayBatDauTrangBi";
            this.colNgayBatDauTrangBi.Visible = true;
            this.colNgayBatDauTrangBi.VisibleIndex = 4;
            this.colNgayBatDauTrangBi.Width = 94;
            // 
            // colNgayKetThucTrangBi
            // 
            this.colNgayKetThucTrangBi.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayKetThucTrangBi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNgayKetThucTrangBi.Caption = "Ngày kết thúc trang bị";
            this.colNgayKetThucTrangBi.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayKetThucTrangBi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayKetThucTrangBi.FieldName = "NgayKetThucTrangBi";
            this.colNgayKetThucTrangBi.MinWidth = 25;
            this.colNgayKetThucTrangBi.Name = "colNgayKetThucTrangBi";
            this.colNgayKetThucTrangBi.Visible = true;
            this.colNgayKetThucTrangBi.VisibleIndex = 5;
            this.colNgayKetThucTrangBi.Width = 94;
            // 
            // deNgayBatDauTrangBi
            // 
            this.deNgayBatDauTrangBi.EditValue = null;
            this.deNgayBatDauTrangBi.Location = new System.Drawing.Point(236, 133);
            this.deNgayBatDauTrangBi.MaximumSize = new System.Drawing.Size(200, 0);
            this.deNgayBatDauTrangBi.MenuManager = this.barManager1;
            this.deNgayBatDauTrangBi.MinimumSize = new System.Drawing.Size(200, 0);
            this.deNgayBatDauTrangBi.Name = "deNgayBatDauTrangBi";
            this.deNgayBatDauTrangBi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deNgayBatDauTrangBi.Properties.Appearance.Options.UseFont = true;
            this.deNgayBatDauTrangBi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDauTrangBi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayBatDauTrangBi.Size = new System.Drawing.Size(200, 28);
            this.deNgayBatDauTrangBi.StyleController = this.layoutControl1;
            this.deNgayBatDauTrangBi.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(975, 669);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(955, 210);
            this.layoutControlGroup1.Text = "Thông tin trang bị";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.deNgayBatDauTrangBi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 40);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(275, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(931, 40);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Ngày bắt đầu trang bị:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(197, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.deNgayKetThucTrangBi;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 40);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(275, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(931, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Ngày kết thúc trang bị:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(197, 21);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem6.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.Control = this.leSoPhong;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 40);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(312, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(931, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Số phòng:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(197, 21);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.leThietBi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(931, 40);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Thiết bị:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(197, 21);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 220);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(955, 429);
            this.layoutControlGroup2.Text = "Danh sách trang bị";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gcTrangBi;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(931, 379);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 210);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(955, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tPhongBindingSource
            // 
            this.tPhongBindingSource.DataSource = typeof(QLKhachSan.Model.tPhong);
            // 
            // tThietBiBindingSource
            // 
            this.tThietBiBindingSource.DataSource = typeof(QLKhachSan.Model.tThietBi);
            // 
            // ucQLTrangBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucQLTrangBi";
            this.Size = new System.Drawing.Size(975, 702);
            this.Load += new System.EventHandler(this.ucQLTrangBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leThietBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leSoPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThucTrangBi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayKetThucTrangBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrangBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTrangBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrangBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDauTrangBi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayBatDauTrangBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThietBiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHuyBo;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.DateEdit deNgayKetThucTrangBi;
        private DevExpress.XtraGrid.GridControl gcTrangBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrangBi;
        private DevExpress.XtraEditors.DateEdit deNgayBatDauTrangBi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource tTrangBiBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBatDauTrangBi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThucTrangBi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraEditors.LookUpEdit leThietBi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit leSoPhong;
        private System.Windows.Forms.BindingSource tPhongBindingSource;
        private System.Windows.Forms.BindingSource tThietBiBindingSource;
    }
}
