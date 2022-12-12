
namespace QLKhachSan
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.menuKhachSan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuQuanLyPhong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuQLThietBi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuQuanLyTrangBi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuDichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuQuanLyDichVu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuQuanLyKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuQuanLyDoanhThu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuDanhSachHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuQuanLyNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuNhomPhanQuyen = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuHoTro = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuDuongDayNong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuThongTinPhanMem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuLienHeNhaPhatTrien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuHuongDanCaiDat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.itemNav = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(353, 54);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(503, 616);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuKhachSan,
            this.menuDichVu,
            this.menuKhachHang,
            this.menuDoanhThu,
            this.menuThongKe,
            this.menuNhanVien,
            this.menuHoTro,
            this.menuThongTinPhanMem});
            this.accordionControl1.Location = new System.Drawing.Point(0, 54);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(353, 616);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // menuKhachSan
            // 
            this.menuKhachSan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuQuanLyPhong,
            this.menuQLThietBi,
            this.menuQuanLyTrangBi});
            this.menuKhachSan.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.menuKhachSan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuKhachSan.ImageOptions.Image")));
            this.menuKhachSan.Name = "menuKhachSan";
            this.menuKhachSan.Text = "Khách sạn";
            // 
            // menuQuanLyPhong
            // 
            this.menuQuanLyPhong.ImageOptions.Image = global::QLKhachSan.Properties.Resources.phong;
            this.menuQuanLyPhong.Name = "menuQuanLyPhong";
            this.menuQuanLyPhong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuQuanLyPhong.Text = "Quản lý Phòng";
            this.menuQuanLyPhong.Click += new System.EventHandler(this.menuQuanLyPhong_Click);
            // 
            // menuQLThietBi
            // 
            this.menuQLThietBi.ImageOptions.Image = global::QLKhachSan.Properties.Resources.thietbi;
            this.menuQLThietBi.Name = "menuQLThietBi";
            this.menuQLThietBi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuQLThietBi.Text = "Quản lý thiết bị";
            this.menuQLThietBi.Click += new System.EventHandler(this.menuQLThietBi_Click);
            // 
            // menuQuanLyTrangBi
            // 
            this.menuQuanLyTrangBi.ImageOptions.Image = global::QLKhachSan.Properties.Resources.trangbi;
            this.menuQuanLyTrangBi.Name = "menuQuanLyTrangBi";
            this.menuQuanLyTrangBi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuQuanLyTrangBi.Text = "Quản lý trang bị";
            this.menuQuanLyTrangBi.Click += new System.EventHandler(this.menuQuanLyTrangBi_Click);
            // 
            // menuDichVu
            // 
            this.menuDichVu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuQuanLyDichVu});
            this.menuDichVu.ImageOptions.Image = global::QLKhachSan.Properties.Resources.dichvu;
            this.menuDichVu.Name = "menuDichVu";
            this.menuDichVu.Text = "Dịch vụ";
            // 
            // menuQuanLyDichVu
            // 
            this.menuQuanLyDichVu.ImageOptions.Image = global::QLKhachSan.Properties.Resources.danhsach;
            this.menuQuanLyDichVu.Name = "menuQuanLyDichVu";
            this.menuQuanLyDichVu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuQuanLyDichVu.Text = "Quản lý dịch vụ";
            this.menuQuanLyDichVu.Click += new System.EventHandler(this.menuQuanLyDichVu_Click);
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuQuanLyKhachHang});
            this.menuKhachHang.ImageOptions.Image = global::QLKhachSan.Properties.Resources.khachhang;
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Text = "Khách hàng";
            // 
            // menuQuanLyKhachHang
            // 
            this.menuQuanLyKhachHang.ImageOptions.Image = global::QLKhachSan.Properties.Resources.quanlykhachhang;
            this.menuQuanLyKhachHang.Name = "menuQuanLyKhachHang";
            this.menuQuanLyKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.menuQuanLyKhachHang.Click += new System.EventHandler(this.menuQuanLyKhachHang_Click);
            // 
            // menuDoanhThu
            // 
            this.menuDoanhThu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuQuanLyDoanhThu});
            this.menuDoanhThu.ImageOptions.Image = global::QLKhachSan.Properties.Resources.doanhthu;
            this.menuDoanhThu.Name = "menuDoanhThu";
            this.menuDoanhThu.Text = "Doanh thu";
            // 
            // menuQuanLyDoanhThu
            // 
            this.menuQuanLyDoanhThu.ImageOptions.Image = global::QLKhachSan.Properties.Resources.quanlydoanhthu;
            this.menuQuanLyDoanhThu.Name = "menuQuanLyDoanhThu";
            this.menuQuanLyDoanhThu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuQuanLyDoanhThu.Text = "Quản lý Doanh thu";
            this.menuQuanLyDoanhThu.Click += new System.EventHandler(this.menuQuanLyDoanhThu_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuDanhSachHoaDon,
            this.menuBaoCao});
            this.menuThongKe.ImageOptions.Image = global::QLKhachSan.Properties.Resources.thongke;
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Text = "Thống kê";
            // 
            // menuDanhSachHoaDon
            // 
            this.menuDanhSachHoaDon.ImageOptions.Image = global::QLKhachSan.Properties.Resources.bill;
            this.menuDanhSachHoaDon.Name = "menuDanhSachHoaDon";
            this.menuDanhSachHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuDanhSachHoaDon.Text = "Danh sách hóa đơn";
            this.menuDanhSachHoaDon.Click += new System.EventHandler(this.menuDanhSachHoaDon_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.ImageOptions.Image = global::QLKhachSan.Properties.Resources.report;
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuBaoCao.Text = "Báo cáo";
            this.menuBaoCao.Click += new System.EventHandler(this.menuBaoCao_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuQuanLyNhanVien,
            this.menuNhomPhanQuyen});
            this.menuNhanVien.ImageOptions.Image = global::QLKhachSan.Properties.Resources.nhanvien;
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Text = "Nhân viên";
            // 
            // menuQuanLyNhanVien
            // 
            this.menuQuanLyNhanVien.ImageOptions.Image = global::QLKhachSan.Properties.Resources._quanlynhanvien;
            this.menuQuanLyNhanVien.Name = "menuQuanLyNhanVien";
            this.menuQuanLyNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.menuQuanLyNhanVien.Click += new System.EventHandler(this.menuQuanLyNhanVien_Click);
            // 
            // menuNhomPhanQuyen
            // 
            this.menuNhomPhanQuyen.ImageOptions.Image = global::QLKhachSan.Properties.Resources.nhomphanquyen;
            this.menuNhomPhanQuyen.Name = "menuNhomPhanQuyen";
            this.menuNhomPhanQuyen.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuNhomPhanQuyen.Text = "Nhóm phân quyền";
            this.menuNhomPhanQuyen.Click += new System.EventHandler(this.menuNhomPhanQuyen_Click);
            // 
            // menuHoTro
            // 
            this.menuHoTro.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuDuongDayNong});
            this.menuHoTro.ImageOptions.Image = global::QLKhachSan.Properties.Resources.hotro;
            this.menuHoTro.Name = "menuHoTro";
            this.menuHoTro.Text = "Hỗ trợ";
            // 
            // menuDuongDayNong
            // 
            this.menuDuongDayNong.ImageOptions.Image = global::QLKhachSan.Properties.Resources.hotline;
            this.menuDuongDayNong.Name = "menuDuongDayNong";
            this.menuDuongDayNong.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuDuongDayNong.Text = "Đường dây nóng";
            // 
            // menuThongTinPhanMem
            // 
            this.menuThongTinPhanMem.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuLienHeNhaPhatTrien,
            this.menuHuongDanCaiDat});
            this.menuThongTinPhanMem.ImageOptions.Image = global::QLKhachSan.Properties.Resources.info;
            this.menuThongTinPhanMem.Name = "menuThongTinPhanMem";
            this.menuThongTinPhanMem.Text = "Thông tin phần mềm";
            // 
            // menuLienHeNhaPhatTrien
            // 
            this.menuLienHeNhaPhatTrien.Name = "menuLienHeNhaPhatTrien";
            this.menuLienHeNhaPhatTrien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuLienHeNhaPhatTrien.Text = "Liên hệ nhà phát triển";
            // 
            // menuHuongDanCaiDat
            // 
            this.menuHuongDanCaiDat.Name = "menuHuongDanCaiDat";
            this.menuHuongDanCaiDat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.menuHuongDanCaiDat.Text = "Hướng dẫn cài đặt";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav,
            this.barButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(856, 54);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.itemNav);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barButtonItem1);
            // 
            // itemNav
            // 
            this.itemNav.Caption = "???";
            this.itemNav.Id = 0;
            this.itemNav.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.itemNav.ItemAppearance.Normal.Options.UseFont = true;
            this.itemNav.Name = "itemNav";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Thoát";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemNav,
            this.barButtonItem1});
            this.fluentFormDefaultManager1.MaxItemId = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 670);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::QLKhachSan.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuKhachSan;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuDichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuQuanLyDichVu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuQuanLyNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuNhomPhanQuyen;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuHoTro;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuQuanLyKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuDuongDayNong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuQuanLyPhong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuThongTinPhanMem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuLienHeNhaPhatTrien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuQuanLyDoanhThu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuDanhSachHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuBaoCao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuHuongDanCaiDat;
        private DevExpress.XtraBars.BarStaticItem itemNav;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuQLThietBi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuQuanLyTrangBi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}