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
    public partial class ucQLThietBi : UserControl
    {
        QLKSEntities data = new QLKSEntities();

        public ucQLThietBi()
        {
            InitializeComponent();
        }

        private void ucQLThietBi_Load(object sender, EventArgs e)
        {
            init();
            LoadData();
        }

        private void init()
        {
            txtMaThietBi.Text = "";
            txtMaThietBi.ReadOnly = false;

            txtTenThietBi.Text = "";

            this.deNgayMua.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayMua.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.deNgayMua.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayMua.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.deNgayMua.Properties.Mask.EditMask = "dd/MM/yyyy";

            txtGiaMua.Text = "0";

            List<string> tinhnang = new List<string>();
            tinhnang.Add("New");
            tinhnang.Add("Old");
            cboTinhNang.Properties.Items.AddRange(tinhnang);
            cboTinhNang.SelectedIndex = 0;

            this.ActiveControl = txtTenThietBi;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = false;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tThietBi> lstThietBi = data.tThietBis.ToList();
            int i = 0;
            var columns = from t in lstThietBi
                          select new
                          {
                              STT = ++i,
                              MaThietBi = t.MaThietBi,
                              TenThietBi = t.TenThietBi,
                              NgayMua = t.NgayMua,
                              GiaMua = t.GiaMua,
                              TinhNang = t.TinhTrang
                          };
            gcThietBi.DataSource = columns.ToList();
        }

        private void gvThietBi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvThietBi_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvThietBi_KeyUp(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void gvThietBi_KeyDown(object sender, KeyEventArgs e)
        {
            loadDataToTextbox(sender);
        }

        private void loadDataToTextbox(object sender)
        {
            GridView view = sender as GridView;

            txtMaThietBi.Text = view.GetFocusedRowCellValue(colMaThietBi).ToString();
            txtTenThietBi.Text = view.GetFocusedRowCellValue(colTenThietBi).ToString();
            deNgayMua.EditValue = DateTime.Parse(view.GetFocusedRowCellValue(colNgayMua).ToString()); //
            txtGiaMua.Text = view.GetFocusedRowCellValue(colGiaMua).ToString();
            cboTinhNang.SelectedIndex = getIndexcboTinhNang(view.GetFocusedRowCellValue(colTinhNang).ToString());

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuyBo.Enabled = true;
        }

        private int getIndexcboTinhNang(string YesNo)
        {
            if (YesNo.Equals("New"))
            {
                return 0;
            }
            return 1;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();

            if (ValidateInputData())
            {
                var thietbi = new tThietBi
                {
                    MaThietBi = autoGenarateMaThietBi(),
                    TenThietBi = txtTenThietBi.Text.Trim(),
                    NgayMua = DateTime.Parse(deNgayMua.EditValue.ToString()),
                    GiaMua = int.Parse(txtGiaMua.Text.Trim()),
                    TinhTrang = cboTinhNang.SelectedItem.ToString()
                };
                data.tThietBis.Add(thietbi);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công", "Thông báo");

                CLEAR();
            }
        }

        private bool ValidateInputData()
        {
            data = new QLKSEntities();

            if (txtTenThietBi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên thiết bị trống!", "Thông báo");
                return false;
            }

            if (txtGiaMua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giá mua trống!", "Thông báo");
                return false;
            }

            if (string.IsNullOrEmpty(cboTinhNang.Text))
            {
                MessageBox.Show("Tính năng trống!", "Thông báo");
                return false;
            }
            if (cboTinhNang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đúng Tính năng!", "Thông báo");
                return false;
            }

            return true;
        }

        private string autoGenarateMaThietBi()
        {
            int numberofRows = data.tThietBis.Count();

            if (numberofRows > 0)
            {
                string maThietBiLastRow = data.tThietBis
                    .OrderByDescending(x => x.MaThietBi)
                    .Select(y => y.MaThietBi)
                    .FirstOrDefault();

                char[] MaThietBiLastRow = maThietBiLastRow.ToArray(); //ex {'T','B','0','0','1'}

                if (int.Parse(MaThietBiLastRow[2].ToString()) == 0)
                {
                    if (int.Parse(MaThietBiLastRow[3].ToString()) == 0)
                    {
                        if (int.Parse(MaThietBiLastRow[4].ToString()) == 9)
                        {
                            return "TB010";
                        }
                        else if (int.Parse(MaThietBiLastRow[4].ToString()) <= 8)
                        {
                            int idex4 = int.Parse(MaThietBiLastRow[4].ToString());
                            string MaThietBi = "TB00" + (idex4 + 1);
                            return MaThietBi;
                        }
                    }
                    else
                    {
                        if (int.Parse(MaThietBiLastRow[3].ToString()) == 9 && int.Parse(MaThietBiLastRow[4].ToString()) == 9)
                        {
                            return "TB100";
                        }
                        else
                        {
                            string idex3 = MaThietBiLastRow[3].ToString();
                            string idex4 = MaThietBiLastRow[4].ToString();
                            string index34 = idex3 + idex4;
                            string MaThietBi = "TB0" + (int.Parse(index34) + 1);
                            return MaThietBi;
                        }
                    }
                }
                else
                {
                    string idex2 = MaThietBiLastRow[2].ToString();
                    string idex3 = MaThietBiLastRow[3].ToString();
                    string idex4 = MaThietBiLastRow[4].ToString();
                    string index234 = idex2 + idex3 + idex4;
                    string MaThietBi = "TB" + (int.Parse(index234) + 1);
                    return MaThietBi;
                }
            }
            return "TB001";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateInputData())
            {
                data = new QLKSEntities();
                var thietbi = data.tThietBis.Where(x => x.MaThietBi == txtMaThietBi.Text.Trim()).FirstOrDefault();
                thietbi.TenThietBi = txtTenThietBi.Text.Trim();
                thietbi.NgayMua = DateTime.Parse(deNgayMua.EditValue.ToString());
                thietbi.GiaMua = int.Parse(txtGiaMua.Text.Trim());
                thietbi.TinhTrang = cboTinhNang.SelectedItem.ToString();
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();
            Boolean canDelete = true;

            if (MessageBox.Show("Bạn thực sự muốn xóa thiết bị ["+txtTenThietBi.Text+"]!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string _MaThietBi = txtMaThietBi.Text.Trim();

                var thietbi_trangbi = data.tTrangBis
                    .Where(x => x.MaThietBi == _MaThietBi)
                    .FirstOrDefault();

                if (thietbi_trangbi != null)
                {
                    MessageBox.Show("Xoá không thành công, thiết bị đang được trang bị cho phòng", "Thông báo");
                    canDelete = false;
                }
                else if (canDelete)
                {
                    var thietbi = data.tThietBis
                        .Where(x => x.MaThietBi == _MaThietBi)
                        .FirstOrDefault();

                    data.tThietBis.Remove(thietbi);
                    data.SaveChanges();
                    LoadData();
                    MessageBox.Show("Xoá thành công thiết bị ["+txtTenThietBi.Text+"]", "Thông báo");
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
            txtMaThietBi.Text = "";
            txtTenThietBi.Text = "";
            txtGiaMua.Text = "0";
            cboTinhNang.SelectedIndex = 0;

            this.ActiveControl = txtTenThietBi;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
