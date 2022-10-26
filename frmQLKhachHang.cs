using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmQLKhachHang : Form
    {
        QLKSEntities data = new QLKSEntities();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            init();
            LoadData();
        }

        private void init()
        {
            txtMaKhach.Text = "";

            txtTenKhach.Text = "";

            txtSoCMND.Text = "";

            txtDienThoai.Text = "";

            this.ActiveControl = txtTenKhach;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tKhach> lstKhach = data.tKhaches.ToList();
            int i = 0;
            var columns = from t in lstKhach
                          select new
                          {
                              No = ++i, //0
                              MaKhachHang = t.MaKhach, //1
                              TenKhachHang = t.TenKhach, //2
                              SoCMND = t.SoCMND, //3
                              DienThoai = t.DienThoai, //4
                          };
            dgKhachHang.DataSource = columns.ToList();
        }

        private void dgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgKhachHang.Rows[e.RowIndex];
                txtMaKhach.Text = row.Cells[1].Value.ToString();
                txtTenKhach.Text = row.Cells[2].Value.ToString();
                txtSoCMND.Text = row.Cells[3].Value.ToString();
                txtDienThoai.Text = row.Cells[4].Value.ToString();

                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgKhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            int rowIndex = dgKhachHang.CurrentCellAddress.Y;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgKhachHang.Rows[rowIndex];
                txtMaKhach.Text = row.Cells[1].Value.ToString();
                txtTenKhach.Text = row.Cells[2].Value.ToString();
                txtSoCMND.Text = row.Cells[3].Value.ToString();
                txtDienThoai.Text = row.Cells[4].Value.ToString();

                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIndex = dgKhachHang.CurrentCellAddress.Y;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgKhachHang.Rows[rowIndex];
                txtMaKhach.Text = row.Cells[1].Value.ToString();
                txtTenKhach.Text = row.Cells[2].Value.ToString();
                txtSoCMND.Text = row.Cells[3].Value.ToString();
                txtDienThoai.Text = row.Cells[4].Value.ToString();

                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
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
            int numberofRows = dgKhachHang.Rows.Count;

            if (numberofRows > 0)
            {
                int lastRowIndex = numberofRows - 1;
                DataGridViewRow lastRow = dgKhachHang.Rows[lastRowIndex];
                char[] MaKhachLastRow = lastRow.Cells[1].Value.ToString().ToArray(); //ex {'K','0','0','1'}

                if (int.Parse(MaKhachLastRow[1].ToString()) <= 0)
                {
                    if (int.Parse(MaKhachLastRow[2].ToString()) <= 0)
                    {
                        int idex3 = int.Parse(MaKhachLastRow[3].ToString());
                        string MaKhach = "K00" + (idex3 + 1);
                        return MaKhach;
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

                    string sophong = "P" + (int.Parse(index123) + 1);
                    return sophong;
                }
            }
            return "K001";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
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
                MessageBox.Show("Update thành công", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data = new QLKSEntities();
            Boolean canDelete = true;
            if (MessageBox.Show("Are you sure!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string _MaKhach = txtMaKhach.Text.Trim();

                var khach_thue = data.tThuePhongs
                        .Where(x => x.MaKhach == _MaKhach)
                        .FirstOrDefault();

                if (khach_thue != null)
                {
                    MessageBox.Show("Xoá không được, khách đang thuê phòng", "Thông báo");
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
            dgKhachHang.ClearSelection();
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtSoCMND.Text = "";
            txtDienThoai.Text = "";

            this.ActiveControl = txtTenKhach;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
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
