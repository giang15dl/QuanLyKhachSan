
namespace QLKhachSan.UI
{
    partial class ucDanhSachHoaDon
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
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.MaThuePhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcHoaDon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1118, 716);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1118, 716);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1098, 696);
            this.layoutControlGroup1.Text = "Danh sách hóa đơn";
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.Location = new System.Drawing.Point(24, 50);
            this.gcHoaDon.MainView = this.gvHoaDon;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(1070, 642);
            this.gcHoaDon.TabIndex = 5;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.MaThuePhong,
            this.SoPhong,
            this.KhachHang,
            this.DichVu,
            this.Soluong,
            this.ThanhTien});
            this.gvHoaDon.GridControl = this.gcHoaDon;
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.OptionsFind.AlwaysVisible = true;
            this.gvHoaDon.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcHoaDon;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1074, 646);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // MaThuePhong
            // 
            this.MaThuePhong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.MaThuePhong.AppearanceCell.Options.UseFont = true;
            this.MaThuePhong.AppearanceCell.Options.UseTextOptions = true;
            this.MaThuePhong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaThuePhong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.MaThuePhong.AppearanceHeader.Options.UseFont = true;
            this.MaThuePhong.AppearanceHeader.Options.UseTextOptions = true;
            this.MaThuePhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaThuePhong.Caption = "Mã thuê phòng";
            this.MaThuePhong.MinWidth = 25;
            this.MaThuePhong.Name = "MaThuePhong";
            this.MaThuePhong.Visible = true;
            this.MaThuePhong.VisibleIndex = 1;
            this.MaThuePhong.Width = 94;
            // 
            // SoPhong
            // 
            this.SoPhong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SoPhong.AppearanceCell.Options.UseFont = true;
            this.SoPhong.AppearanceCell.Options.UseTextOptions = true;
            this.SoPhong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoPhong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.SoPhong.AppearanceHeader.Options.UseFont = true;
            this.SoPhong.AppearanceHeader.Options.UseTextOptions = true;
            this.SoPhong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SoPhong.Caption = "Số phòng";
            this.SoPhong.MinWidth = 25;
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.Visible = true;
            this.SoPhong.VisibleIndex = 2;
            this.SoPhong.Width = 94;
            // 
            // KhachHang
            // 
            this.KhachHang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.KhachHang.AppearanceCell.Options.UseFont = true;
            this.KhachHang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.KhachHang.AppearanceHeader.Options.UseFont = true;
            this.KhachHang.AppearanceHeader.Options.UseTextOptions = true;
            this.KhachHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.KhachHang.Caption = "Khách hàng";
            this.KhachHang.MinWidth = 25;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.Visible = true;
            this.KhachHang.VisibleIndex = 3;
            this.KhachHang.Width = 94;
            // 
            // DichVu
            // 
            this.DichVu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.DichVu.AppearanceCell.Options.UseFont = true;
            this.DichVu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.DichVu.AppearanceHeader.Options.UseFont = true;
            this.DichVu.AppearanceHeader.Options.UseTextOptions = true;
            this.DichVu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DichVu.Caption = "Dịch vụ";
            this.DichVu.MinWidth = 25;
            this.DichVu.Name = "DichVu";
            this.DichVu.Visible = true;
            this.DichVu.VisibleIndex = 4;
            this.DichVu.Width = 94;
            // 
            // Soluong
            // 
            this.Soluong.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Soluong.AppearanceCell.Options.UseFont = true;
            this.Soluong.AppearanceCell.Options.UseTextOptions = true;
            this.Soluong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Soluong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Soluong.AppearanceHeader.Options.UseFont = true;
            this.Soluong.AppearanceHeader.Options.UseTextOptions = true;
            this.Soluong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Soluong.Caption = "Số lượng";
            this.Soluong.MinWidth = 25;
            this.Soluong.Name = "Soluong";
            this.Soluong.Visible = true;
            this.Soluong.VisibleIndex = 5;
            this.Soluong.Width = 94;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ThanhTien.AppearanceCell.Options.UseFont = true;
            this.ThanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.ThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ThanhTien.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ThanhTien.AppearanceHeader.Options.UseFont = true;
            this.ThanhTien.AppearanceHeader.Options.UseTextOptions = true;
            this.ThanhTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.MinWidth = 25;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 6;
            this.ThanhTien.Width = 94;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.STT.AppearanceCell.Options.UseFont = true;
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.MinWidth = 25;
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 94;
            // 
            // ucDanhSachHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucDanhSachHoaDon";
            this.Size = new System.Drawing.Size(1118, 716);
            this.Load += new System.EventHandler(this.ucDanhSachHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn MaThuePhong;
        private DevExpress.XtraGrid.Columns.GridColumn SoPhong;
        private DevExpress.XtraGrid.Columns.GridColumn KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn DichVu;
        private DevExpress.XtraGrid.Columns.GridColumn Soluong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
    }
}
