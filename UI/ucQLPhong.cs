using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using QLKhachSan.Model;
using DevExpress.XtraGrid.Views.Base;

namespace QLKhachSan.UI
{
    public partial class ucQLPhong : UserControl
    {
        QLKSEntities data = new QLKSEntities();

        private MainForm mainForm;
        public ucQLPhong(Form callingForm)
        {
            this.mainForm = callingForm as MainForm;
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
            tinhtrang.Add("Trong");
            tinhtrang.Add("DangO");
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
                              TinhTrang = t.TinhTrang
                          };
            gcPhong.DataSource = columns.ToList();
        }

        private void updateLabel()
        {
            int SoPhongTrong = data.tPhongs.Where(x => x.TinhTrang == "Trong").Count();
            this.labelTrong.Text = SoPhongTrong.ToString();

            int SoPhongDangO = data.tPhongs.Where(x => x.TinhTrang == "DangO").Count();
            this.labelDangO.Text = SoPhongDangO.ToString();
        }

        private void tvPhong_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            TileView view = sender as TileView;
            string tinhtrang = view.GetRowCellValue(e.RowHandle, colTinhTrang).ToString();
            if ((bool) tinhtrang.Equals("DangO", StringComparison.InvariantCulture))
            {
                e.Item.AppearanceItem.Normal.BackColor = Color.Orange;
            }
        }

        private void tvPhong_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            TileView view = sender as TileView;

            txtSoPhong.Text = view.GetRowCellValue(e.Item.RowHandle, colSoPhong).ToString();
            txtGiaTien.Text = view.GetRowCellValue(e.Item.RowHandle, colGiaTien).ToString();
            cboTinhTrang.SelectedIndex = getIndexcboConSuDung(view.GetRowCellValue(e.Item.RowHandle, colTinhTrang).ToString());

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private int getIndexcboConSuDung(string tinhtrang)
        {
            if (tinhtrang.Equals("Trong", StringComparison.InvariantCulture))
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
                    TinhTrang = cboTinhTrang.Text
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
            data = new QLKSEntities();

            int numberofRows = data.tPhongs.Count();

            if (numberofRows > 0)
            {
                string maPhongLastRow = data.tPhongs
                    .OrderByDescending(x => x.SoPhong)
                    .Select(y => y.SoPhong)
                    .FirstOrDefault();

                char[] MaPhongLastRow = maPhongLastRow.ToArray(); //ex {'P','0','0','1'} B001->B999 K001->K999

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

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data = new QLKSEntities();

            if (ValidateInputData())
            {
                var phong = data.tPhongs.Where(x => x.SoPhong == txtSoPhong.Text.Trim()).FirstOrDefault();
                phong.GiaTien = int.Parse(txtGiaTien.Text.Trim());
                phong.TinhTrang = cboTinhTrang.Text;
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

        string txtSoPhong_currentFocus;
        private void tvPhong_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            TileView view = sender as TileView;
            this.txtSoPhong_currentFocus = view.GetFocusedRowCellValue(colSoPhong).ToString();
        }

        private void tvPhong_ItemRightClick(object sender, TileViewItemClickEventArgs e)
        {
            string tinhtrang = data.tPhongs.Where(x => x.SoPhong == this.txtSoPhong_currentFocus).Select(y => y.TinhTrang).FirstOrDefault();

            if (tinhtrang.Equals("Trong"))
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
            else if (tinhtrang.Equals("DangO"))
            {
                popupMenu2.ShowPopup(Control.MousePosition);
            }
        }

        frmQLDatPhong FrmQLDatPhong;
        private void barbtnNhanPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQLDatPhong = new frmQLDatPhong(this.txtSoPhong_currentFocus);
            FrmQLDatPhong.TopLevel = false;
            FrmQLDatPhong.Dock = DockStyle.Fill;
            this.mainForm.showFormQLDatPhong(FrmQLDatPhong);
        }

        private void barbtnChinhSuaThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQLDatPhong = new frmQLDatPhong(this.txtSoPhong_currentFocus);
            FrmQLDatPhong.TopLevel = false;
            FrmQLDatPhong.Dock = DockStyle.Fill;
            this.mainForm.showFormQLDatPhong(FrmQLDatPhong);
        }

        private void barbtnTraPhong_ItemClick(object sender, ItemClickEventArgs e)
        {

            MessageBox.Show("Trả phòng", "Thông báo");
        }

        private void barbtnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            updateLabel();
        }
    }
}
