using DevExpress.XtraBars;
using Microsoft.Diagnostics.Runtime;
using QLKhachSan.Model;
using QLKhachSan.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        ucQLPhong uc_QLPhong;
        ucQLThietBi uc_QLThietBi;
        ucQLDichVu uc_QLDichVu;
        ucThongKeDichVuDaBan uc_ThongKeDichVuDaBan;
        ucQLKhachHang uc_QLKhachHang;
        ucDoanhThuChiTiet uc_DoanhThuChiTiet;
        ucDanhSachHoaDon uc_DanhSachHoaDon;
        ucBaoCao uc_BaoCao;
        ucQLTrangBi uc_QLTrangBi;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        public void showFormQLDatPhong(frmQLDatPhong frm) 
        {

            mainContainer.Invoke(new MethodInvoker(delegate ()
            {
                mainContainer.Controls.Add(frm);
                frm.BringToFront();
                frm.Show();
            }));
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private async void menuQuanLyPhong_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_QLPhong");
            this.itemNav.Caption = "Khách sạn / Quản lý phòng";
        }

        private async void menuQLThietBi_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_QLThietBi");
            this.itemNav.Caption = "Khách sạn / Quản lý thiết bị";
        }

        private async void menuQuanLyTrangBi_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_QLTrangBi");
            this.itemNav.Caption = "Khách sạn / Quản lý trang bị";
        }

        private async void menuQuanLyDichVu_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_QLDichVu");
            this.itemNav.Caption = "Dịch vụ / Quản lý dịch vụ";
        }

        private async void menuThongKeDichVuDaBan_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_ThongKeDichVuDaBan");
            this.itemNav.Caption = "Dịch vụ / Thống kê dịch vụ đã bán";
        }

        private async void menuQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_QLKhachHang");
            this.itemNav.Caption = "Khách hàng / Quản lý khách hàng";
        }

        private async void menuDoanhThuChiTiet_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_DoanhThuChiTiet");
            this.itemNav.Caption = "Doanh thu / Doanh thu chi tiết";
        }

        private async void menuDanhSachHoaDon_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_DanhSachHoaDon");
            this.itemNav.Caption = "Thống kê / Danh sách hóa đơn";
        }

        private async void menuBaoCao_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync("uc_BaoCao");
            this.itemNav.Caption = "Thống kê / Báo cáo";
        }

        private void menuQuanLyNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void menuNhomPhanQuyen_Click(object sender, EventArgs e)
        {

        }

        public async Task LoadModuleAsync(string name)
        {
            if (name.Equals("uc_QLPhong"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_QLPhong))
                    {
                        uc_QLPhong = new ucQLPhong(this);
                        if (uc_QLPhong != null)
                        {
                            uc_QLPhong.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_QLPhong);
                                uc_QLPhong.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_QLPhong.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_QLThietBi"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_QLThietBi))
                    {
                        uc_QLThietBi = new ucQLThietBi();
                        if (uc_QLThietBi != null)
                        {
                            uc_QLThietBi.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_QLThietBi);
                                uc_QLThietBi.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_QLThietBi.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_QLTrangBi"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_QLTrangBi))
                    {
                        uc_QLTrangBi = new ucQLTrangBi();
                        if (uc_QLTrangBi != null)
                        {
                            uc_QLTrangBi.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_QLTrangBi);
                                uc_QLTrangBi.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_QLTrangBi.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_QLDichVu"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_QLDichVu))
                    {
                        uc_QLDichVu = new ucQLDichVu();
                        if (uc_QLDichVu != null)
                        {
                            uc_QLDichVu.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_QLDichVu);
                                uc_QLDichVu.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_QLDichVu.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_ThongKeDichVuDaBan"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_ThongKeDichVuDaBan))
                    {
                        uc_ThongKeDichVuDaBan = new ucThongKeDichVuDaBan();
                        if (uc_ThongKeDichVuDaBan != null)
                        {
                            uc_ThongKeDichVuDaBan.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_ThongKeDichVuDaBan);
                                uc_ThongKeDichVuDaBan.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_ThongKeDichVuDaBan.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_QLKhachHang"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_QLKhachHang))
                    {
                        uc_QLKhachHang = new ucQLKhachHang();
                        if (uc_QLKhachHang != null)
                        {
                            uc_QLKhachHang.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_QLKhachHang);
                                uc_QLKhachHang.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_QLKhachHang.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_DoanhThuChiTiet"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_DoanhThuChiTiet))
                    {
                        uc_DoanhThuChiTiet = new ucDoanhThuChiTiet();
                        if (uc_DoanhThuChiTiet != null)
                        {
                            uc_DoanhThuChiTiet.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_DoanhThuChiTiet);
                                uc_DoanhThuChiTiet.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_DoanhThuChiTiet.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_DanhSachHoaDon"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_DanhSachHoaDon))
                    {
                        uc_DanhSachHoaDon = new ucDanhSachHoaDon();
                        if (uc_DanhSachHoaDon != null)
                        {
                            uc_DanhSachHoaDon.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_DanhSachHoaDon);
                                uc_DoanhThuChiTiet.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_DanhSachHoaDon.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
            else if (name.Equals("uc_BaoCao"))
            {
                await Task.Factory.StartNew(() =>
                {
                    if (!mainContainer.Controls.Contains(uc_BaoCao))
                    {
                        uc_BaoCao = new ucBaoCao();
                        if (uc_BaoCao != null)
                        {
                            uc_BaoCao.Dock = DockStyle.Fill;
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                mainContainer.Controls.Add(uc_BaoCao);
                                uc_BaoCao.BringToFront();
                            }));
                        }
                    }
                    else
                    {
                        var temp = mainContainer.Controls.Find(uc_BaoCao.Name, true);
                        if (temp.Length == 1)
                        {
                            mainContainer.Invoke(new MethodInvoker(delegate ()
                            {
                                temp[0].BringToFront();
                            }));
                        }
                    }
                });
            }
        }
    }
}
