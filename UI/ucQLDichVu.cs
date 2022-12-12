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
    public partial class ucQLDichVu : UserControl
    {
        QLKSEntities data = new QLKSEntities();

        public ucQLDichVu()
        {
            InitializeComponent();
        }

        private void gcDichVu_Load(object sender, EventArgs e)
        {
            init();
            LoadData();
        }

        private void init()
        {
            txtMaDichVu.Text = "";
            txtMaDichVu.ReadOnly = true;

            txtTenDichVu.Text = "";

            txtGiaDichVu.Text = "";

            txtSoLuong.Text = "";

            this.ActiveControl = txtTenDichVu;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tDichVu> lstDichVu = data.tDichVus.ToList();
            int i = 0;
            var columns = from t in lstDichVu
                          select new
                          {
                              STT = ++i,
                              MaDichVu = t.MaDichVu,
                              TenDichVu = t.TenDichVu,
                              GiaDichVu = t.GiaDichVu,
                              SoLuong = t.SoLuong,
                          };
            gcDichVu.DataSource = columns.ToList();
        }

        private void gvDichVu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvDichVu_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvDichVu_KeyUp(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvDichVu_KeyDown(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void loadDataToTextbox(object sender)
        {
            GridView view = sender as GridView;

            txtMaDichVu.Text = view.GetFocusedRowCellValue(colMaDichVu).ToString();
            txtTenDichVu.Text = view.GetFocusedRowCellValue(colTenDichVu).ToString();
            txtGiaDichVu.Text = view.GetFocusedRowCellValue(colGiaDichVu).ToString();
            txtSoLuong.Text = view.GetFocusedRowCellValue(colSoLuong).ToString();

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
                var dichvu = new tDichVu
                {
                    MaDichVu = autoGenarateMaDichVu(),
                    TenDichVu = txtTenDichVu.Text.Trim(),
                    GiaDichVu = int.Parse(txtGiaDichVu.Text.Trim()),
                    SoLuong = int.Parse(txtSoLuong.Text.Trim())
                };
                data.tDichVus.Add(dichvu);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm dịch vụ thành công", "Thông báo");

                CLEAR();
            }
        }

        private string autoGenarateMaDichVu()
        {
            int numberofRows = data.tDichVus.Count();

            if (numberofRows > 0)
            {
                string maDichVuLastRow = data.tDichVus
                    .OrderByDescending(x => x.MaDichVu)
                    .Select(y => y.MaDichVu)
                    .FirstOrDefault();

                char[] MaDichVuLastRow = maDichVuLastRow.ToArray(); //ex {'D','V','0','1'}

                if (int.Parse(MaDichVuLastRow[2].ToString()) == 0)
                {
                    if (int.Parse(MaDichVuLastRow[3].ToString()) == 9)
                    {
                        return "DV10";
                    }
                    else if (int.Parse(MaDichVuLastRow[3].ToString()) <= 8)
                    {
                        string index3 = MaDichVuLastRow[3].ToString();

                        string MaDichVu = "DV0" + (int.Parse(index3) + 1);
                        return MaDichVu;
                    }
                }
                else if (int.Parse(MaDichVuLastRow[2].ToString()) > 0)
                {
                    string index2 = MaDichVuLastRow[2].ToString();
                    string index3 = MaDichVuLastRow[3].ToString();
                    string index23 = index2 + index3;

                    string MaDichVu = "DV" + (int.Parse(index23) + 1);
                    return MaDichVu;
                }
            }
            return "DV01";
        }

        private bool ValidateInputData()
        {
            data = new QLKSEntities();
            if (txtTenDichVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên Dịch vụ trống!", "Thông báo");
                return false;
            }

            if (txtGiaDichVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giá Dịch vụ trống", "Thông báo");
                return false;
            }

            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số lượng trống!", "Thông báo");
                return false;
            }

            return true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();
            if (ValidateInputData())
            {
                var dv = data.tDichVus.Where(x => x.MaDichVu == txtMaDichVu.Text.Trim()).FirstOrDefault();
                dv.TenDichVu = txtTenDichVu.Text.Trim();
                dv.GiaDichVu = int.Parse(txtGiaDichVu.Text.Trim());
                dv.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();
            Boolean canDelete = true;
            if (MessageBox.Show("Bạn thực sự muốn xóa dịch vụ [" + txtTenDichVu.Text + "]!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string _MaDichVu = txtMaDichVu.Text.Trim();

                var dichvu_hoadon = data.tHoaDons
                        .Where(x => x.MaDichVu == _MaDichVu)
                        .FirstOrDefault();

                if (dichvu_hoadon != null)
                {
                    MessageBox.Show("Xoá không thành công, dịch vụ đang được bán", "Thông báo");
                    canDelete = false;
                }
                else if (canDelete)
                {
                    var dichvu = data.tDichVus
                        .Where(x => x.MaDichVu == _MaDichVu)
                        .FirstOrDefault();

                    data.tDichVus.Remove(dichvu);
                    data.SaveChanges();
                    LoadData();
                    MessageBox.Show("Xoá thành công dịch vụ [" + txtTenDichVu.Text + "]!", "Thông báo");
                    CLEAR();
                }
            }
        }

        private void btnHuyBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CLEAR();
        }

        private void CLEAR()
        {
            gvDichVu.ClearSelection();
            txtMaDichVu.Text = "";
            txtTenDichVu.Text = "";
            txtGiaDichVu.Text = "";
            txtSoLuong.Text = "";

            this.ActiveControl = txtTenDichVu;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void txtGiaDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
