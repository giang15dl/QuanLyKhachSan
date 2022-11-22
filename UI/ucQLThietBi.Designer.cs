
namespace QLKhachSan.UI
{
    partial class ucQLThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucQLThietBi));
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
            this.gcThietBi = new DevExpress.XtraGrid.GridControl();
            this.tThietBiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvThietBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMaThietBi = new DevExpress.XtraEditors.TextEdit();
            this.cboTinhNang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deNgayMua = new DevExpress.XtraEditors.DateEdit();
            this.txtGiaMua = new DevExpress.XtraEditors.TextEdit();
            this.txtTenThietBi = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThietBiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThietBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhNang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayMua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayMua.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaMua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThietBi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(866, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 694);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(866, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 661);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(866, 33);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 661);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcThietBi);
            this.layoutControl1.Controls.Add(this.txtMaThietBi);
            this.layoutControl1.Controls.Add(this.cboTinhNang);
            this.layoutControl1.Controls.Add(this.deNgayMua);
            this.layoutControl1.Controls.Add(this.txtGiaMua);
            this.layoutControl1.Controls.Add(this.txtTenThietBi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 33);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(866, 661);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcThietBi
            // 
            this.gcThietBi.DataSource = this.tThietBiBindingSource;
            this.gcThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThietBi.Location = new System.Drawing.Point(24, 310);
            this.gcThietBi.MainView = this.gvThietBi;
            this.gcThietBi.MenuManager = this.barManager1;
            this.gcThietBi.Name = "gcThietBi";
            this.gcThietBi.Size = new System.Drawing.Size(818, 327);
            this.gcThietBi.TabIndex = 13;
            this.gcThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThietBi});
            // 
            // tThietBiBindingSource
            // 
            this.tThietBiBindingSource.DataSource = typeof(QLKhachSan.Model.tThietBi);
            // 
            // gvThietBi
            // 
            this.gvThietBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMaThietBi,
            this.colTenThietBi,
            this.colNgayMua,
            this.colGiaMua,
            this.colTinhNang});
            this.gvThietBi.GridControl = this.gcThietBi;
            this.gvThietBi.Name = "gvThietBi";
            this.gvThietBi.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gvThietBi.OptionsFind.AlwaysVisible = true;
            this.gvThietBi.OptionsView.ShowGroupPanel = false;
            this.gvThietBi.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvThietBi_RowClick);
            this.gvThietBi.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvThietBi_RowCellClick);
            this.gvThietBi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvThietBi_KeyDown);
            this.gvThietBi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvThietBi_KeyUp);
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
            // colMaThietBi
            // 
            this.colMaThietBi.AppearanceCell.Options.UseTextOptions = true;
            this.colMaThietBi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaThietBi.Caption = "Mã thiết bị";
            this.colMaThietBi.FieldName = "MaThietBi";
            this.colMaThietBi.MinWidth = 25;
            this.colMaThietBi.Name = "colMaThietBi";
            this.colMaThietBi.Visible = true;
            this.colMaThietBi.VisibleIndex = 1;
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
            this.colTenThietBi.VisibleIndex = 2;
            this.colTenThietBi.Width = 94;
            // 
            // colNgayMua
            // 
            this.colNgayMua.AppearanceCell.Options.UseTextOptions = true;
            this.colNgayMua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNgayMua.Caption = "Ngày mua";
            this.colNgayMua.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayMua.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayMua.FieldName = "NgayMua";
            this.colNgayMua.MinWidth = 25;
            this.colNgayMua.Name = "colNgayMua";
            this.colNgayMua.Visible = true;
            this.colNgayMua.VisibleIndex = 3;
            this.colNgayMua.Width = 94;
            // 
            // colGiaMua
            // 
            this.colGiaMua.AppearanceCell.Options.UseTextOptions = true;
            this.colGiaMua.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colGiaMua.Caption = "Giá mua";
            this.colGiaMua.FieldName = "GiaMua";
            this.colGiaMua.MinWidth = 25;
            this.colGiaMua.Name = "colGiaMua";
            this.colGiaMua.Visible = true;
            this.colGiaMua.VisibleIndex = 4;
            this.colGiaMua.Width = 94;
            // 
            // colTinhNang
            // 
            this.colTinhNang.AppearanceCell.Options.UseTextOptions = true;
            this.colTinhNang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTinhNang.Caption = "Tính năng";
            this.colTinhNang.FieldName = "TinhNang";
            this.colTinhNang.MinWidth = 25;
            this.colTinhNang.Name = "colTinhNang";
            this.colTinhNang.Visible = true;
            this.colTinhNang.VisibleIndex = 5;
            this.colTinhNang.Width = 94;
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(137, 53);
            this.txtMaThietBi.MaximumSize = new System.Drawing.Size(350, 0);
            this.txtMaThietBi.MenuManager = this.barManager1;
            this.txtMaThietBi.MinimumSize = new System.Drawing.Size(350, 0);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaThietBi.Properties.Appearance.Options.UseFont = true;
            this.txtMaThietBi.Size = new System.Drawing.Size(350, 28);
            this.txtMaThietBi.StyleController = this.layoutControl1;
            this.txtMaThietBi.TabIndex = 12;
            // 
            // cboTinhNang
            // 
            this.cboTinhNang.Location = new System.Drawing.Point(137, 213);
            this.cboTinhNang.MaximumSize = new System.Drawing.Size(350, 0);
            this.cboTinhNang.MenuManager = this.barManager1;
            this.cboTinhNang.MinimumSize = new System.Drawing.Size(350, 0);
            this.cboTinhNang.Name = "cboTinhNang";
            this.cboTinhNang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboTinhNang.Properties.Appearance.Options.UseFont = true;
            this.cboTinhNang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTinhNang.Size = new System.Drawing.Size(350, 28);
            this.cboTinhNang.StyleController = this.layoutControl1;
            this.cboTinhNang.TabIndex = 11;
            // 
            // deNgayMua
            // 
            this.deNgayMua.EditValue = null;
            this.deNgayMua.Location = new System.Drawing.Point(137, 133);
            this.deNgayMua.MaximumSize = new System.Drawing.Size(350, 0);
            this.deNgayMua.MenuManager = this.barManager1;
            this.deNgayMua.MinimumSize = new System.Drawing.Size(350, 0);
            this.deNgayMua.Name = "deNgayMua";
            this.deNgayMua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deNgayMua.Properties.Appearance.Options.UseFont = true;
            this.deNgayMua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayMua.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayMua.Size = new System.Drawing.Size(350, 28);
            this.deNgayMua.StyleController = this.layoutControl1;
            this.deNgayMua.TabIndex = 10;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(137, 173);
            this.txtGiaMua.MaximumSize = new System.Drawing.Size(350, 0);
            this.txtGiaMua.MenuManager = this.barManager1;
            this.txtGiaMua.MinimumSize = new System.Drawing.Size(350, 0);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtGiaMua.Properties.Appearance.Options.UseFont = true;
            this.txtGiaMua.Size = new System.Drawing.Size(350, 28);
            this.txtGiaMua.StyleController = this.layoutControl1;
            this.txtGiaMua.TabIndex = 7;
            this.txtGiaMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(137, 93);
            this.txtTenThietBi.MaximumSize = new System.Drawing.Size(350, 0);
            this.txtTenThietBi.MenuManager = this.barManager1;
            this.txtTenThietBi.MinimumSize = new System.Drawing.Size(350, 0);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenThietBi.Properties.Appearance.Options.UseFont = true;
            this.txtTenThietBi.Size = new System.Drawing.Size(350, 28);
            this.txtTenThietBi.StyleController = this.layoutControl1;
            this.txtTenThietBi.TabIndex = 4;
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
            this.Root.Size = new System.Drawing.Size(866, 661);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(846, 250);
            this.layoutControlGroup1.Text = "Thông tin thiết bị";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.txtTenThietBi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(822, 40);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Tên thiết bị:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(103, 21);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.txtGiaMua;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 5, 5, 5);
            this.layoutControlItem4.Size = new System.Drawing.Size(822, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "Giá mua";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(103, 21);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem7.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem7.Control = this.deNgayMua;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 5, 5, 5);
            this.layoutControlItem7.Size = new System.Drawing.Size(822, 40);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "Ngày mua:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(103, 21);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.cboTinhNang;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(822, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Tính năng:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(103, 21);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtMaThietBi;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(750, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(822, 40);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Mã thiết bị:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(103, 21);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 260);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(846, 381);
            this.layoutControlGroup2.Text = "Danh sách thiết bị";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gcThietBi;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(822, 331);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 250);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(846, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ucQLThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucQLThietBi";
            this.Size = new System.Drawing.Size(866, 694);
            this.Load += new System.EventHandler(this.ucQLThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThietBiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThietBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTinhNang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayMua.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayMua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaMua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThietBi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtGiaMua;
        private DevExpress.XtraEditors.TextEdit txtTenThietBi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ComboBoxEdit cboTinhNang;
        private DevExpress.XtraEditors.DateEdit deNgayMua;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtMaThietBi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraGrid.GridControl gcThietBi;
        private System.Windows.Forms.BindingSource tThietBiBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMua;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhNang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
