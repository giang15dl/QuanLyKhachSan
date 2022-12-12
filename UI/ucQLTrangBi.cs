using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using QLKhachSan.Model;

namespace QLKhachSan.UI
{
    public partial class ucQLTrangBi : UserControl
    {
        QLKSEntities data = new QLKSEntities();

        public ucQLTrangBi()
        {
            InitializeComponent();
        }

        private void ucQLTrangBi_Load(object sender, EventArgs e)
        {
            init();
            LoadData();
        }

        private void init()
        {
            List<tPhong> lstPhong = data.tPhongs.ToList();
            var columnPhong = from t in lstPhong
                              select new
                              {
                                  SoPhong = t.SoPhong,
                                  GiaTien = t.GiaTien,
                                  TinhTrang = t.TinhTrang
                              };

            leSoPhong.Properties.DataSource = columnPhong.ToList();
            leSoPhong.Properties.DisplayMember = "SoPhong";
            leSoPhong.Properties.ValueMember = "SoPhong";
            leSoPhong.EditValue = "P001";

            List<tThietBi> lstThietBi = data.tThietBis.ToList();
            var columnThietBi = from t in lstThietBi
                                select new
                                {
                                    MaThietBi = t.MaThietBi,
                                    TenThietBi = t.TenThietBi,
                                    NgayMua = t.NgayMua,
                                    GiaMua = t.GiaMua,
                                    TinhNang = t.TinhTrang
                                };
            leThietBi.Properties.DataSource = columnThietBi.ToList();
            leThietBi.Properties.DisplayMember = "TenThietBi";
            leThietBi.Properties.ValueMember = "MaThietBi";
            leThietBi.EditValue = "TB001";

            this.deNgayBatDauTrangBi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayBatDauTrangBi.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deNgayBatDauTrangBi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayBatDauTrangBi.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deNgayBatDauTrangBi.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deNgayBatDauTrangBi.DateTime = DateTime.Now;

            this.deNgayKetThucTrangBi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayKetThucTrangBi.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deNgayKetThucTrangBi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayKetThucTrangBi.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deNgayKetThucTrangBi.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.deNgayKetThucTrangBi.DateTime = DateTime.Now;

            this.ActiveControl = leSoPhong;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tTrangBi> lstTrangBi = data.tTrangBis.ToList();
            int i = 0;
            var columns = from t in lstTrangBi
                          select new
                          {
                              STT = ++i, //0
                              SoPhong = t.SoPhong, //1
                              MaThietBi = t.MaThietBi, //2
                              TenThietBi = t.tThietBi.TenThietBi, //3
                              NgayBatDauTrangBi = t.NgayBatDauTrangBi, //4
                              NgayKetThucTrangBi = t.NgayKetThucTrangBi, //5
                          };
            gcTrangBi.DataSource = columns.ToList();
        }

        private void gvTrangBi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvTrangBi_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvTrangBi_KeyUp(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvTrangBi_KeyDown(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void loadDataToTextbox(object sender)
        {
            GridView view = sender as GridView;

            leSoPhong.EditValue = view.GetFocusedRowCellValue(colSoPhong).ToString();
            leSoPhong.ReadOnly = true;
            leThietBi.EditValue = view.GetFocusedRowCellValue(colMaThietBi).ToString();
            leThietBi.ReadOnly = true;

            deNgayBatDauTrangBi.EditValue = DateTime.Parse(view.GetFocusedRowCellValue(colNgayBatDauTrangBi).ToString());
            deNgayKetThucTrangBi.EditValue = DateTime.Parse(view.GetFocusedRowCellValue(colNgayKetThucTrangBi).ToString());

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuyBo.Enabled = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();

            if (ValidateInputData())
            {
                var trangbi = new tTrangBi
                {
                    SoPhong = leSoPhong.EditValue.ToString(),
                    MaThietBi = leThietBi.EditValue.ToString(),
                    NgayBatDauTrangBi = deNgayBatDauTrangBi.DateTime,
                    NgayKetThucTrangBi = deNgayKetThucTrangBi.DateTime
                };
                data.tTrangBis.Add(trangbi);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
        }

        private bool ValidateInputData()
        {
            data = new QLKSEntities();

            if (string.IsNullOrEmpty(leSoPhong.EditValue.ToString()))
            {
                MessageBox.Show("Số phòng trống", "Thông báo");
                return false;
            }

            if (string.IsNullOrEmpty(leThietBi.EditValue.ToString()))
            {
                MessageBox.Show("Thiết bị trống", "Thông báo");
                return false;
            }

            string _SoPhong = leSoPhong.EditValue.ToString();
            string _MaThietBi = leThietBi.EditValue.ToString();
            var isDuplicate = data.tTrangBis
                    .Where(x => x.SoPhong == _SoPhong && x.MaThietBi == _MaThietBi)
                    .FirstOrDefault();
            if (isDuplicate != null)
            {
                MessageBox.Show("Trang bị đã tồn tại!", "Thông báo");
                return false;
            }

            // NgayKetThuc >= NgayBatDau
            if (ValidateNgayTrangBi() == false)
            {
                return false;
            }

            return true;
        }

        private bool ValidateNgayTrangBi()
        {
            int NamBatDauTrangBi = deNgayBatDauTrangBi.DateTime.Year;
            int ThangBatDauTrangBi = deNgayBatDauTrangBi.DateTime.Month;
            int NgayBatDauTrangBi = deNgayBatDauTrangBi.DateTime.Day;

            int NamKetThucTrangBi = deNgayKetThucTrangBi.DateTime.Year;
            int ThangKetThucTrangBi = deNgayKetThucTrangBi.DateTime.Month;
            int NgayKetThucTrangBi = deNgayKetThucTrangBi.DateTime.Day;

            if (NamKetThucTrangBi < NamBatDauTrangBi)
            {
                MessageBox.Show("Ngày kết thúc trang bị phải bằng hoặc sau ngày bắt đầu trang bị", "Thông báo");
                return false;
            }
            else if (NamKetThucTrangBi == NamBatDauTrangBi)
            {
                if (ThangKetThucTrangBi < ThangBatDauTrangBi)
                {
                    MessageBox.Show("Ngày kết thúc trang bị phải bằng hoặc sau ngày bắt đầu trang bị", "Thông báo");
                    return false;
                }
                else if (ThangKetThucTrangBi >= ThangBatDauTrangBi)
                {
                    if (NgayKetThucTrangBi < NgayBatDauTrangBi)
                    {
                        MessageBox.Show("Ngày kết thúc trang bị phải bằng hoặc sau ngày bắt đầu trang bị", "Thông báo");
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if (ValidateNgayTrangBi())
           {
                data = new QLKSEntities();
                string _SoPhong = leSoPhong.EditValue.ToString();
                string _MaThietBi = leThietBi.EditValue.ToString();
                var quanlytrangbi = data.tTrangBis.Where(x => x.SoPhong == _SoPhong && x.MaThietBi == _MaThietBi).FirstOrDefault();
                quanlytrangbi.NgayBatDauTrangBi = deNgayBatDauTrangBi.DateTime;
                quanlytrangbi.NgayKetThucTrangBi = deNgayKetThucTrangBi.DateTime;
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công trang bị cho phòng [" + leSoPhong.EditValue.ToString() + "]!", "Thông báo");
           }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();

            if (MessageBox.Show("Bạn thực sự muốn xóa trang bị cho phòng ["+leSoPhong.EditValue.ToString()+"]!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string _SoPhong = leSoPhong.EditValue.ToString();
                string _MaThietBi = leThietBi.EditValue.ToString();

                var trangbi = data.tTrangBis
                    .Where(x => x.SoPhong == _SoPhong && x.MaThietBi == _MaThietBi)
                    .FirstOrDefault();

                data.tTrangBis.Remove(trangbi);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Xoá thành công trang bị cho phòng [" + leSoPhong.EditValue.ToString() + "]!", "Thông báo");

                CLEAR();
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CLEAR();       
        }

        private void CLEAR()
        {
            //gcTrangBi.ClearSelection();
            leSoPhong.EditValue = "";
            leSoPhong.ReadOnly = false;
            leThietBi.EditValue = "";
            leThietBi.ReadOnly = false;

            this.ActiveControl = leSoPhong;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }
    }
}
