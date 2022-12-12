using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Tile;
using QLKhachSan.Model;

namespace QLKhachSan.UI
{
    public partial class frmQLDatPhong : DevExpress.XtraEditors.XtraForm
    {
        string maThuePhong;
        string soPhong;
        string maKhach;

        string NhanPhongOrChinhSua;

        QLKSEntities data = new QLKSEntities();

        public frmQLDatPhong(string txtSoPhong_currentFocus)
        {
            InitializeComponent();

            this.soPhong = txtSoPhong_currentFocus;
            
            string tinhtrang = data.tPhongs
                .Where(x => x.SoPhong == this.soPhong)
                .Select(y => y.TinhTrang)
                .FirstOrDefault();

            if (tinhtrang.Equals("Trong"))
            {
                this.NhanPhongOrChinhSua = "nhan";
            }
            else if (tinhtrang.Equals("Trong"))
            {
                this.NhanPhongOrChinhSua = "sua";
            }
        }

        private void frmQLDatPhong_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            init();
        }

        private void init()
        {
            layoutControlThongTinPhong.Text = "Thông tin đăng ký - Phòng " + this.soPhong;

            txtGiaTien.Text = data.tPhongs
                .Where(x => x.SoPhong == this.soPhong)
                .Select(y => y.GiaTien)
                .FirstOrDefault()
                .ToString();
            txtGiaTien.ReadOnly = true;

            this.deNgayNhanPhong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayNhanPhong.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deNgayNhanPhong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayNhanPhong.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deNgayNhanPhong.Properties.Mask.EditMask = "dd/MM/yyyy";

            this.deNgayTraPhong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayTraPhong.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deNgayTraPhong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayTraPhong.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deNgayTraPhong.Properties.Mask.EditMask = "dd/MM/yyyy";

            List<tDichVu> lstDichVu = data.tDichVus.ToList();
            var columnDichVu = from t in lstDichVu
                               select new
                               {
                                   MaDichVu = t.MaDichVu,
                                   TenDichVu = t.TenDichVu,
                                   GiaDichVu = t.GiaDichVu
                               };
            leDichVu.Properties.DataSource = columnDichVu.ToList();
            leDichVu.Properties.DisplayMember = "TenDichVu";
            leDichVu.Properties.ValueMember = "MaDichVu";
            leDichVu.EditValue = "";

            List<string> soluongmua = new List<string>();
            soluongmua.Add("1");
            soluongmua.Add("2");
            soluongmua.Add("3");
            soluongmua.Add("4");
            soluongmua.Add("5");
            cboSoLuongMua.Properties.Items.AddRange(soluongmua);
            cboSoLuongMua.SelectedIndex = 0;

            if (this.NhanPhongOrChinhSua.Equals("nhan"))
            {
                labelNhanPhong.Text = "Nhận phòng - " + this.soPhong;
                
                this.deNgayNhanPhong.DateTime = DateTime.Now;
                this.deNgayTraPhong.DateTime = DateTime.Now;

                txtTenKhach.Text = "";
                txtSoCMND.Text = "";
                txtDienThoai.Text = "";

                this.btnNhanPhong.Text = "Nhận phòng";
                this.btnNhanPhong.Enabled = false;
            }
            else if (this.NhanPhongOrChinhSua.Equals("sua"))
            {
                labelNhanPhong.Text = "Chỉnh sửa phòng - " + this.soPhong;
                
                this.maThuePhong = data.tThuePhongs
                    .OrderByDescending(x => x.MaThuePhong)
                    .Where(y => y.SoPhong == this.soPhong)
                    .Select(z => z.MaThuePhong)
                    .FirstOrDefault();
                
                this.deNgayNhanPhong.DateTime = data.tThuePhongs
                   .Where(x => x.MaThuePhong == this.maThuePhong)
                   .Select(y => y.NgayNhanPhong)
                   .FirstOrDefault();

                this.deNgayTraPhong.DateTime = data.tThuePhongs
                    .Where(x => x.MaThuePhong == this.maThuePhong)
                    .Select(y => y.NgayTraPhong)
                    .FirstOrDefault();

                this.maKhach = data.tThuePhongs
                    .Where(x => x.MaThuePhong == this.maThuePhong && x.SoPhong == this.soPhong)
                    .Select(y => y.MaKhach)
                    .FirstOrDefault();

                txtTenKhach.Text = data.tKhaches
                    .Where(x => x.MaKhach == this.maKhach)
                    .Select(y => y.TenKhach)
                    .FirstOrDefault();
                
                txtSoCMND.Text = data.tKhaches
                    .Where(x => x.MaKhach == this.maKhach)
                    .Select(y => y.SoCMND)
                    .FirstOrDefault();
                
                txtDienThoai.Text = data.tKhaches
                    .Where(x => x.MaKhach == this.maKhach)
                    .Select(y => y.DienThoai)
                    .FirstOrDefault();

                LoadKhachHangToGridView(this.maKhach);

                this.btnNhanPhong.Text = "Trả phòng";
            }  
        }

        private void btnLuuKhachHang_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.maKhach))
            {
                if (ValidateDataKhachHang())
                {
                    this.maKhach = autoGenarateMaKhach();
                    var khach = new tKhach
                    {
                        MaKhach = this.maKhach,
                        TenKhach = txtTenKhach.Text.Trim(),
                        SoCMND = txtSoCMND.Text.Trim(),
                        DienThoai = txtDienThoai.Text.Trim()
                    };
                    data.tKhaches.Add(khach);
                    data.SaveChanges();
                    LoadKhachHangToGridView(maKhach);

                    this.maThuePhong = autoGenarateMaThuePhong();
                    var thuephong = new tThuePhong
                    {
                        MaThuePhong = this.maThuePhong,
                        SoPhong = this.soPhong,
                        MaKhach = this.maKhach,
                        NgayNhanPhong = deNgayNhanPhong.DateTime,
                        NgayTraPhong = deNgayTraPhong.DateTime
                    };
                    data.tThuePhongs.Add(thuephong);
                    data.SaveChanges();

                    double thanhtien = data.tPhongs.Where(x => x.SoPhong == this.soPhong).Select(y => y.GiaTien).FirstOrDefault();
                    var hoadon = new tHoaDon
                    {
                        MaThuePhong = this.maThuePhong,
                        SoPhong = this.soPhong,
                        MaKhach = this.maKhach,
                        MaDichVu = "DV01",
                        Soluong = 1,
                        ThanhTien = thanhtien
                    };
                    data.tHoaDons.Add(hoadon);
                    data.SaveChanges();
                    LoadDichVuBanToGridView();

                    this.btnNhanPhong.Enabled = true;
                }
            }
            else
            {
                if (ValidateDataKhachHang())
                {
                    var khach = data.tKhaches
                    .Where(x => x.MaKhach == this.maKhach)
                    .FirstOrDefault();

                    khach.TenKhach = txtTenKhach.Text.Trim();
                    khach.SoCMND = txtSoCMND.Text.Trim();
                    khach.DienThoai = txtDienThoai.Text.Trim();

                    data.SaveChanges();
                    LoadKhachHangToGridView(maKhach);
                }
            }
        }

        private bool ValidateDataKhachHang()
        {
            if (String.IsNullOrEmpty(txtTenKhach.Text.Trim()))
            {
                MessageBox.Show("Tên Khách hàng trống!", "Thông báo");
                return false;
            }

            if (String.IsNullOrEmpty(txtSoCMND.Text.Trim()))
            {
                MessageBox.Show("Số CMND trống!", "Thông báo");
                return false;
            }

            if (String.IsNullOrEmpty(txtDienThoai.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại trống!", "Thông báo");
                return false;
            }

            return true;
        }

        private string autoGenarateMaKhach()
        {
            int numberofRows = data.tKhaches.Count();

            if (numberofRows > 0)
            {
                string maKhachLastRow = data.tKhaches
                    .OrderByDescending(x => x.MaKhach)
                    .Select(y => y.MaKhach)
                    .FirstOrDefault();

                char[] MaKhachLastRow = maKhachLastRow.ToArray(); //ex {'K','0','0','1'}

                if (int.Parse(MaKhachLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MaKhachLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MaKhachLastRow[3].ToString()) == 9)
                        {
                            return "K010";
                        }
                        else if (int.Parse(MaKhachLastRow[3].ToString()) <= 8)
                        {
                            string index3 = MaKhachLastRow[3].ToString();
                            string MaKhach = "K00" + (int.Parse(index3) + 1);
                            return MaKhach;
                        }
                    }
                    else if (int.Parse(MaKhachLastRow[2].ToString()) > 0)
                    {
                        string idex2 = MaKhachLastRow[2].ToString();
                        string idex3 = MaKhachLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string MaKhach = "K0" + (int.Parse(index23) + 1);
                        return MaKhach;
                    }
                }
                else if (int.Parse(MaKhachLastRow[1].ToString()) > 0)
                {
                    string index1 = MaKhachLastRow[1].ToString();
                    string index2 = MaKhachLastRow[2].ToString();
                    string index3 = MaKhachLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string MaKhach = "K" + (int.Parse(index123) + 1);
                    return MaKhach;
                }
            }
            return "K001";
        }

        private void LoadKhachHangToGridView(string maKhach)
        {
            List<tKhach> lstKhach = data.tKhaches.ToList();
            int i = 0;
            var columns = from t in lstKhach
                          where t.MaKhach == maKhach
                          select new
                          {
                              STT = ++i,
                              MaKhach = t.MaKhach,
                              TenKhach = t.TenKhach,
                              SoCMND = t.SoCMND, 
                              DienThoai = t.DienThoai,
                          };
            gcKhachHangDatPhong.DataSource = columns.ToList();
        }

        private string autoGenarateMaThuePhong()
        {
            int numberofRows = data.tThuePhongs.Count();

            if (numberofRows > 0)
            {
                string maThuePhongLastRow = data.tThuePhongs
                    .OrderByDescending(x => x.MaThuePhong)
                    .Select(y => y.MaThuePhong)
                    .FirstOrDefault();

                char[] MaThuePhongLastRow = maThuePhongLastRow.ToArray(); //ex {'T', 'P', '0','0','1'}

                if (int.Parse(MaThuePhongLastRow[2].ToString()) == 0)
                {
                    if (int.Parse(MaThuePhongLastRow[3].ToString()) == 0)
                    {
                        if (int.Parse(MaThuePhongLastRow[4].ToString()) == 9)
                        {
                            return "TP010";
                        }
                        else if (int.Parse(MaThuePhongLastRow[4].ToString()) <= 8)
                        {
                            string index4 = MaThuePhongLastRow[4].ToString();
                            string MaHoaDon = "TP00" + (int.Parse(index4) + 1);
                            return MaHoaDon;
                        }
                    }
                    else if (int.Parse(MaThuePhongLastRow[3].ToString()) > 0)
                    {
                        string idex3 = MaThuePhongLastRow[3].ToString();
                        string idex4 = MaThuePhongLastRow[4].ToString();
                        string index34 = idex3 + idex4;

                        string MaHoaDon = "TP0" + (int.Parse(index34) + 1);
                        return MaHoaDon;
                    }
                }
                else if (int.Parse(MaThuePhongLastRow[2].ToString()) > 0)
                {
                    string index2 = MaThuePhongLastRow[2].ToString();
                    string index3 = MaThuePhongLastRow[3].ToString();
                    string index4 = MaThuePhongLastRow[3].ToString();
                    string index234 = index2 + index3 + index4;

                    string MaHoaDon = "TP" + (int.Parse(index234) + 1);
                    return MaHoaDon;
                }
            }
            return "TP001";
        }

        private void btnThemDichVuBan_Click(object sender, EventArgs e)
        {
            if (ValidateDataDichVuBan())
            {
                var hoadon = new tHoaDon
                {
                    MaThuePhong = this.maThuePhong,
                    SoPhong = this.soPhong,
                    MaKhach = this.maKhach,
                    MaDichVu = leDichVu.EditValue.ToString().Trim(),
                    Soluong = int.Parse(cboSoLuongMua.EditValue.ToString().Trim()),
                    ThanhTien = tinhTienDichVu()
                };
                data.tHoaDons.Add(hoadon);
                data.SaveChanges();
                LoadDichVuBanToGridView();
                //MessageBox.Show("Thêm dịch vụ thành công", "Thông báo");
            }
        }

        private bool ValidateDataDichVuBan()
        {
            if (string.IsNullOrEmpty(leDichVu.EditValue.ToString().Trim()))
            {
                MessageBox.Show("Tên dịch vụ trống", "Thông báo");
                return false;
            }

            if (string.IsNullOrEmpty(cboSoLuongMua.EditValue.ToString().Trim()))
            {
                MessageBox.Show("Số lượng mua trống", "Thông báo");
                return false;
            }
            return true;
        }

        private double tinhTienDichVu()
        {
            string maDichVu = leDichVu.EditValue.ToString().Trim();
            int giaDichVu = data.tDichVus
                .Where(x => x.MaDichVu == maDichVu)
                .Select(x => x.GiaDichVu)
                .FirstOrDefault();
            int soLuongMua = int.Parse(cboSoLuongMua.EditValue.ToString());

            return giaDichVu * soLuongMua;
        }

        private void LoadDichVuBanToGridView()
        {
            List<tHoaDon> lstHoaDon = data.tHoaDons.ToList();
            int i = 0;
            var columns = from t in lstHoaDon
                          where (t.MaThuePhong == this.maThuePhong) && (t.SoPhong == this.soPhong) && (t.MaKhach == this.maKhach)
                          select new
                          {
                              STT = ++i,
                              MaDichVu = t.MaDichVu,
                              TenDichVu = t.tDichVu.TenDichVu,
                              DonGia = t.tDichVu.GiaDichVu,
                              SoLuong = t.Soluong,
                              ThanhTien = t.ThanhTien
                          };
            gcDanhSachDichVu.DataSource = columns.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (this.NhanPhongOrChinhSua.Equals("nhan"))
            {
                var hoadon = data.tHoaDons
                    .Where(x => x.MaThuePhong == this.maThuePhong && x.SoPhong == this.soPhong && x.MaKhach == this.maKhach)
                    .FirstOrDefault();
                if (hoadon != null)
                {
                    data.tHoaDons.Remove(hoadon);
                    data.SaveChanges();
                }

                var thuephong = data.tThuePhongs
                        .Where(x => x.MaThuePhong == this.maThuePhong && x.SoPhong == this.soPhong && x.MaKhach == this.maKhach)
                        .FirstOrDefault();
                if (thuephong != null)
                {
                    data.tThuePhongs.Remove(thuephong);
                    data.SaveChanges();
                }

                var khachhang = data.tKhaches
                    .Where(x => x.MaKhach == this.maKhach)
                    .FirstOrDefault();
                if (khachhang != null)
                {
                    data.tKhaches.Remove(khachhang);
                    data.SaveChanges();
                }

                this.Close();
            }
            else if (this.NhanPhongOrChinhSua.Equals("sua"))
            {
                this.Close();
            }
        }
        
        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            var phong = data.tPhongs.Where(x => x.SoPhong == this.soPhong).FirstOrDefault();
            phong.TinhTrang = "DangO";
            data.SaveChanges();
            this.Close();
        }
        
        private void columnEditBtnXoa1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var hoadon = data.tHoaDons
                    .Where(x => x.MaThuePhong == this.maThuePhong && x.SoPhong == this.soPhong && x.MaKhach == this.maKhach)
                    .FirstOrDefault();
            if (hoadon != null)
            {
                data.tHoaDons.Remove(hoadon);
                data.SaveChanges();
            }

            var thuephong = data.tThuePhongs
                    .Where(x => x.MaThuePhong == this.maThuePhong && x.SoPhong == this.soPhong && x.MaKhach == this.maKhach)
                    .FirstOrDefault();
            if (thuephong != null)
            {
                data.tThuePhongs.Remove(thuephong);
                data.SaveChanges();
            }

            var khachhang = data.tKhaches
                .Where(x => x.MaKhach == this.maKhach)
                .FirstOrDefault();
            if (khachhang != null)
            {
                data.tKhaches.Remove(khachhang);
                data.SaveChanges();
            }
        }

        private void columnEditBtnXoa2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var madichvu = gvDanhSachDichVu.GetFocusedRowCellValue(colMaDichVu).ToString();

            var hoadon = data.tHoaDons
                .Where(x => x.MaThuePhong == this.maThuePhong
                && x.SoPhong == this.soPhong
                && x.MaKhach == this.maKhach
                && x.MaDichVu == madichvu)
                .FirstOrDefault();
            if (hoadon.MaDichVu == "DV01")
            {
                MessageBox.Show("Không xóa được tiền phòng", "Thông báo");
            }
            else
            {
                data.tHoaDons.Remove(hoadon);
                data.SaveChanges();
                LoadDichVuBanToGridView();
            }
        }

        private void txtSoCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}