using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmQLThietBi : Form
    {
        QLKSEntities data = new QLKSEntities();

        public frmQLThietBi()
        {
            InitializeComponent();
        }

        private void frmQLThietBi_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            init();
            LoadData();
        }

        private void init()
        {
            txtMaThietBi.Text = "";
            txtMaThietBi.Enabled = false;

            txtTenThietBi.Text = "";

            dtNgayMua.Format = DateTimePickerFormat.Custom;
            dtNgayMua.CustomFormat = "dd/MM/yyyy";

            txtGiaMua.Text = "0";

            List<string> tinhnang = new List<string>();
            tinhnang.Add("New");
            tinhnang.Add("Old");
            cboTinhNang.DataSource = tinhnang;
            cboTinhNang.SelectedIndex = 0;

            this.ActiveControl = txtTenThietBi;
            
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tThietBi> lstThietBi = data.tThietBis.ToList();
            int i = 0;
            var columns = from t in lstThietBi
                          select new
                          {
                              No = ++i, //0
                              MaThietBi = t.MaThietBi, //1
                              TenThietBi = t.TenThietBi, //2
                              NgayMua = t.NgayMua, //3
                              GiaMua = t.GiaMua, //4
                              TinhNang = t.TinhTrang //5
                          };
            dgThietBi.DataSource = columns.ToList();
            dgThietBi.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgThietBi.Rows[e.RowIndex];
                txtMaThietBi.Text = row.Cells[1].Value.ToString();
                txtTenThietBi.Text = row.Cells[2].Value.ToString();
                dtNgayMua.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtGiaMua.Text = row.Cells[4].Value.ToString();
                cboTinhNang.SelectedIndex = cboTinhNang.FindStringExact(row.Cells[5].Value.ToString());

                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgThietBi_KeyDown(object sender, KeyEventArgs e)
        {
            //int rowIndex = dgThietBi.CurrentCellAddress.Y;
            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow row = dgThietBi.Rows[rowIndex];
            //    txtMaThietBi.Text = row.Cells[1].Value.ToString();
            //    txtMaThietBi.Enabled = false;
            //    txtTenThietBi.Text = row.Cells[2].Value.ToString();
            //    dtNgayMua.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            //    txtGiaMua.Text = row.Cells[4].Value.ToString();
            //    cboTinhNang.SelectedIndex = cboTinhNang.FindStringExact(row.Cells[5].Value.ToString());

            //    btnThem.Enabled = false;
            //    btnCapNhat.Enabled = true;
            //    btnXoa.Enabled = true;
            //}
        }

        private void dgThietBi_KeyUp(object sender, KeyEventArgs e)
        {
            //int rowIndex = dgThietBi.CurrentCellAddress.Y;
            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow row = dgThietBi.Rows[rowIndex];
            //    txtMaThietBi.Text = row.Cells[1].Value.ToString();
            //    txtMaThietBi.Enabled = false;
            //    txtTenThietBi.Text = row.Cells[2].Value.ToString();
            //    dtNgayMua.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            //    txtGiaMua.Text = row.Cells[4].Value.ToString();
            //    cboTinhNang.SelectedIndex = cboTinhNang.FindStringExact(row.Cells[5].Value.ToString());

            //    btnThem.Enabled = false;
            //    btnCapNhat.Enabled = true;
            //    btnXoa.Enabled = true;
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            data = new QLKSEntities();

            if (ValidateInputData())
            {
                var thietbi = new tThietBi
                {
                    MaThietBi = autoGenarateMaThietBi(),
                    TenThietBi = txtTenThietBi.Text.Trim(),
                    NgayMua = dtNgayMua.Value,
                    GiaMua = int.Parse(txtGiaMua.Text.Trim()),
                    TinhTrang = cboTinhNang.SelectedValue.ToString()
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
                MessageBox.Show("'Tính năng' trống", "Thông báo");
                return false;
            }
            if (cboTinhNang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đúng 'Tính năng'", "Thông báo");
                return false;
            }

            return true;
        }

        private string autoGenarateMaThietBi()
        {
            int numberofRows = dgThietBi.Rows.Count;

            if (numberofRows > 0)
            {
                int lastRowIndex = numberofRows - 1;
                DataGridViewRow lastRow = dgThietBi.Rows[lastRowIndex];
                char[] MaThietBiLastRow = lastRow.Cells[1].Value.ToString().ToArray(); //ex {'T','B','0','0','1'}

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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ValidateInputData())
            {
                data = new QLKSEntities();
                var thietbi = data.tThietBis.Where(x => x.MaThietBi == txtMaThietBi.Text.Trim()).FirstOrDefault();
                thietbi.TenThietBi = txtTenThietBi.Text.Trim();
                thietbi.NgayMua = dtNgayMua.Value;
                thietbi.GiaMua = int.Parse(txtGiaMua.Text.Trim());
                thietbi.TinhTrang = cboTinhNang.SelectedValue.ToString();
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Update thành công", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data = new QLKSEntities();
            Boolean canDelete = true;

            if (MessageBox.Show("Are you sure!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string _MaThietBi = txtMaThietBi.Text.Trim();

                var thietbi_trangbi = data.tTrangBis
                    .Where(x => x.MaThietBi == _MaThietBi)
                    .FirstOrDefault();

                if (thietbi_trangbi != null)
                {
                    MessageBox.Show("Xoá không được, thiết bị đang được trang bị cho phòng", "Thông báo");
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
                    MessageBox.Show("Xoá thành công", "Thông báo");
                    CLEAR();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            CLEAR();
        }

        private void CLEAR()
        {
            dgThietBi.ClearSelection();
            txtMaThietBi.Text = "";
            txtTenThietBi.Text = "";
            txtGiaMua.Text = "0";
            cboTinhNang.SelectedIndex = 0;

            this.ActiveControl = txtTenThietBi;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
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
