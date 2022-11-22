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
    public partial class ucQLPhong : UserControl
    {
        QLKSEntities data = new QLKSEntities();

        public ucQLPhong()
        {
            InitializeComponent();
        }

        private void uc_DanhSachPhong_Load(object sender, EventArgs e)
        {
            init();
            LoadData();
            updateLabel();
        }

        private void init()
        {
            txtSoPhong.Text = "";
            txtSoPhong.ReadOnly = true;

            txtGiaTien.Text = "0";

            List<string> tinhtrang= new List<string>();
            tinhtrang.Add("Trống");
            tinhtrang.Add("Đang ở");
            cboTinhTrang.Properties.Items.AddRange(tinhtrang);
            cboTinhTrang.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuyBo.Enabled = true;
        }

        private void LoadData()
        {
            data = new QLKSEntities();
            List<tPhong> lstPhong = data.tPhongs.ToList();
            var columns = from t in lstPhong
                          select new
                          {
                              SoPhong = t.SoPhong,
                              GiaTien = t.GiaTien,
                              ConSuDung = setConSuDung(t.ConSuDung)
                          };
            gcPhong.DataSource = columns.ToList();
        }

        private string setConSuDung(string s)
        {
            if (s == "Yes") {
                return "Đang ở";
            }
            return "Trống";
        }

        private void updateLabel()
        {
            int SoPhongTrong = data.tPhongs.Where(x => x.ConSuDung == "No").Count();
            this.labelTrong.Text = SoPhongTrong.ToString();

            int SoPhongDangO = data.tPhongs.Where(x => x.ConSuDung == "Yes").Count();
            this.labelDangO.Text = SoPhongDangO.ToString();
        }

        private void tvPhong_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            TileView view = sender as TileView;
            if ((bool)view.GetRowCellValue(e.RowHandle, colConSuDung).Equals("Đang ở"))
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.Orange;
            }
        }

        private void tvPhong_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            TileView view = sender as TileView;

            txtSoPhong.Text = view.GetRowCellValue(e.Item.RowHandle, colSoPhong).ToString();
            txtGiaTien.Text = view.GetRowCellValue(e.Item.RowHandle, colGiaTien).ToString();
            cboTinhTrang.SelectedIndex = getIndexcboConSuDung(view.GetRowCellValue(e.Item.RowHandle, colConSuDung).ToString());

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private int getIndexcboConSuDung(string YesNo)
        {
            if (YesNo.Equals("Trống"))
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
                var phong = new tPhong
                {
                    SoPhong = autoGenarateSoPhong(),
                    GiaTien = int.Parse(txtGiaTien.Text.Trim()),
                    ConSuDung = insertConSuDung(cboTinhTrang.Text)
                };
                data.tPhongs.Add(phong);
                data.SaveChanges();
                LoadData();
                updateLabel();
                MessageBox.Show("Thêm thành công", "Thông báo");

                CLEAR();
                this.ActiveControl = txtGiaTien;
            }
        }

        private bool ValidateInputData()
        {
            data = new QLKSEntities();

            if (txtGiaTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giá tiền trống!", "Thông báo");
                return false;
            }

            if (string.IsNullOrEmpty(cboTinhTrang.Text))
            {
                MessageBox.Show("Tình trạng trống", "Thông báo");
                return false;
            }
            if (cboTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đúng tình trạng", "Thông báo");
                return false;
            }

            return true;
        }

        private string autoGenarateSoPhong()
        {
            int numberofRows = data.tPhongs.Count();

            if (numberofRows > 0)
            {
                string maPhongLastRow = data.tPhongs
                    .OrderByDescending(x => x.SoPhong)
                    .Select(y => y.SoPhong)
                    .FirstOrDefault();

                char[] MaPhongLastRow = maPhongLastRow.ToArray(); //ex {'P','0','0','1'}

                if (int.Parse(MaPhongLastRow[1].ToString()) == 0)
                {
                    if (int.Parse(MaPhongLastRow[2].ToString()) == 0)
                    {
                        if (int.Parse(MaPhongLastRow[3].ToString()) == 9)
                        {
                            return "P010";
                        }
                        else if (int.Parse(MaPhongLastRow[3].ToString()) <= 8)
                        {
                            int idex3 = int.Parse(MaPhongLastRow[3].ToString());
                            string MaPhong = "P00" + (idex3 + 1);
                            return MaPhong;
                        }
                    }
                    else
                    {
                        if (int.Parse(MaPhongLastRow[2].ToString()) == 9 && int.Parse(MaPhongLastRow[3].ToString()) == 9)
                        {
                            return "P100";
                        }
                        else
                        {
                            string index2 = MaPhongLastRow[2].ToString();
                            string index3 = MaPhongLastRow[3].ToString();
                            string index23 = index2 + index3;
                            string MaPhong = "P0" + (int.Parse(index23) + 1);
                            return MaPhong;
                        }
                    }
                }
                else
                {
                    string index1 = MaPhongLastRow[1].ToString();
                    string index2 = MaPhongLastRow[2].ToString();
                    string index3 = MaPhongLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;
                    string MaPhong = "P" + (int.Parse(index123) + 1);
                }
            }
            return "P001";
        }

        private string insertConSuDung(string s)
        {
            if (s.Equals("Đang ở"))
            {
                return "Yes";
            }
            return "No";
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateInputData())
            {
                data = new QLKSEntities();
                var phong = data.tPhongs.Where(x => x.SoPhong == txtSoPhong.Text.Trim()).FirstOrDefault();
                phong.GiaTien = int.Parse(txtGiaTien.Text.Trim());
                phong.ConSuDung = insertConSuDung(cboTinhTrang.Text);
                data.SaveChanges();
                LoadData();
                updateLabel();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();
            Boolean canDelete = true;

            if (MessageBox.Show("Bạn thực sự muốn xóa phòng ["+txtSoPhong.Text+"] !", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string _SoPhong = txtSoPhong.Text.Trim();

                var phong_thue = data.tThuePhongs
                        .Where(x => x.SoPhong == _SoPhong)
                        .FirstOrDefault();

                var phong_trangbi = data.tTrangBis
                    .Where(x => x.SoPhong == _SoPhong)
                    .FirstOrDefault();

                if (phong_thue != null)
                {
                    MessageBox.Show("Xoá không được, phòng đang được thuê", "Thông báo");
                    canDelete = false;
                }
                else if (phong_trangbi != null)
                {
                    MessageBox.Show("Xoá không được, phòng đang được trang bị", "Thông báo");
                    canDelete = false;
                }
                else if (canDelete)
                {
                    var phong = data.tPhongs
                        .Where(x => x.SoPhong == _SoPhong)
                        .FirstOrDefault();

                    data.tPhongs.Remove(phong);
                    data.SaveChanges();
                    LoadData();
                    updateLabel();

                    MessageBox.Show("Xoá thành công", "Thông báo");
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
            txtSoPhong.Text = "";
            txtGiaTien.Text = "0";
            cboTinhTrang.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tvPhong_ItemCustomize_1(object sender, TileViewItemCustomizeEventArgs e)
        {
            TileView view = sender as TileView;
            if ((bool)view.GetRowCellValue(e.RowHandle, colConSuDung).Equals("Đang ở"))
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.Orange;
            }
        }
    }     
}
