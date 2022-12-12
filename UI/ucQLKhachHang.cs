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
    public partial class ucQLKhachHang : UserControl
    {
        QLKSEntities data = new QLKSEntities();

        public ucQLKhachHang()
        {
            InitializeComponent();
        }

        private void uc_QLKhachHang_Load(object sender, EventArgs e)
        {
            init();
            LoadData();
        }

        private void init()
        {
            txtMaKhach.Text = "";
            txtMaKhach.ReadOnly = true;

            txtTenKhach.Text = "";

            txtSoCMND.Text = "";

            txtDienThoai.Text = "";

            this.ActiveControl = txtTenKhach;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tKhach> lstKhach = data.tKhaches.ToList();
            int i = 0;
            var columns = from t in lstKhach
                          select new
                          {
                              STT = ++i, //0
                              MaKhachHang = t.MaKhach, //1
                              TenKhachHang = t.TenKhach, //2
                              SoCMND = t.SoCMND, //3
                              DienThoai = t.DienThoai, //4
                          };
            gcKhachHang.DataSource = columns.ToList();
        }

        private void gvKhachHang_RowClick(object sender, RowClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvKhachHang_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvKhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void loadDataToTextbox(object sender)
        {
            GridView view = sender as GridView;
            try
            {
                txtMaKhach.Text = view.GetFocusedRowCellValue(colMaKhach).ToString();
                txtTenKhach.Text = view.GetFocusedRowCellValue(colTenKhach).ToString();
                txtSoCMND.Text = view.GetFocusedRowCellValue(colSoCMND).ToString();
                txtDienThoai.Text = view.GetFocusedRowCellValue(colDienThoai).ToString();

                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnHuyBo.Enabled = true;
            }catch { }
        }
            
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();
            if (ValidateInputData())
            {
                var khach = new tKhach
                {
                    MaKhach = autoGenarateMaKhach(),
                    TenKhach = txtTenKhach.Text.Trim(),
                    SoCMND = txtSoCMND.Text.Trim(),
                    DienThoai = txtDienThoai.Text.Trim()
                };
                data.tKhaches.Add(khach);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công", "Thông báo");

                CLEAR();
            }
        }

        private bool ValidateInputData()
        {
            data = new QLKSEntities();
            if (txtTenKhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên Khách hàng trống!", "Thông báo");
                return false;
            }

            if (txtSoCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số CMND trống!", "Thông báo");
                return false;
            }

            if (txtDienThoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số điện thoại trống!", "Thông báo");
                return false;
            }

            return true;
        }

        private string autoGenarateMaKhach()
        {
            int numberofRows = data.tKhaches.Count();

            int numberofrow = data.tKhaches
                   .Select(x => x.MaKhach)
                   .Count();

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

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();
            if (ValidateInputData())
            {
                var kh = data.tKhaches.Where(x => x.MaKhach == txtMaKhach.Text.Trim()).FirstOrDefault();
                kh.TenKhach = txtTenKhach.Text.Trim();
                kh.SoCMND = txtSoCMND.Text.Trim();
                kh.DienThoai = txtDienThoai.Text.Trim();
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();
            Boolean canDelete = true;
            if (MessageBox.Show("Bạn thực sự muốn xóa khách hàng ["+txtTenKhach.Text+"]!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string _MaKhach = txtMaKhach.Text.Trim();

                var khach_thue = data.tThuePhongs
                        .Where(x => x.MaKhach == _MaKhach)
                        .FirstOrDefault();

                if (khach_thue != null)
                {
                    MessageBox.Show("Xoá không thành công, khách đang thuê phòng", "Thông báo");
                    canDelete = false;
                }
                else if (canDelete)
                {
                    var khach = data.tKhaches
                        .Where(x => x.MaKhach == _MaKhach)
                        .FirstOrDefault();

                    data.tKhaches.Remove(khach);
                    data.SaveChanges();
                    LoadData();
                    MessageBox.Show("Xoá thành công khách hàng ["+txtTenKhach.Text+"]!", "Thông báo");
                    CLEAR();
                }
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CLEAR();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void CLEAR()
        {
            gvKhachHang.ClearSelection();
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtSoCMND.Text = "";
            txtDienThoai.Text = "";

            this.ActiveControl = txtTenKhach;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
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
