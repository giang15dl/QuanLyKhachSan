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
    public partial class frmQLThuePhong : Form
    {
        QLKSEntities data = new QLKSEntities();
        public frmQLThuePhong()
        {
            InitializeComponent();
        }

        private void frmQLThuePhong_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            init();
            LoadData();
        }

        private void init()
        {
            data = new QLKSEntities();

            txtSTT.Text = "";
            txtSTT.Enabled = false;

            cboSoPhong.DataSource = data.tPhongs.ToList();
            cboSoPhong.DisplayMember = "SoPhong";
            cboSoPhong.ValueMember = "SoPhong";
            cboSoPhong.SelectedIndex = -1;
            cboSoPhong.Enabled = true;
            txtSoPhong.Text = "";
            txtGiaTien.Text = "";
            txtConSuDung.Text = "";

            dtNgayNhanPhong.Format = DateTimePickerFormat.Custom;
            dtNgayNhanPhong.CustomFormat = "dd/MM/yyyy";

            dtNgayTraPhong.Format = DateTimePickerFormat.Custom;
            dtNgayTraPhong.CustomFormat = "dd/MM/yyyy";

            cboMaKhach.DataSource = data.tKhaches.ToList();
            cboMaKhach.DisplayMember = "MaKhach";
            cboMaKhach.ValueMember = "MaKhach";
            cboMaKhach.SelectedIndex = -1;
            cboMaKhach.Enabled = true;
            txtTenKhach.Text = "";
            txtCMND.Text = "";
            txtDienThoai.Text = "";

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tThuePhong> lstThuePhong = data.tThuePhongs.ToList();
            var columns = from t in lstThuePhong
                          select new
                          {
                              STT = t.STT, //0
                              SoPhong = t.SoPhong, //1
                              MaKhachHang = t.MaKhach, //2
                              TenKhachHang = t.tKhach.TenKhach, //3
                              CMND = t.tKhach.SoCMND, //4
                              NgayNhanPhong = t.NgayNhanPhong, //5
                              NgayTraPhong = t.NgayTraPhong, //6
                          };
            dgThuePhong.DataSource = columns.ToList();
            dgThuePhong.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgThuePhong.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void cboSoPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboSoPhong.SelectedValue != null)
            {
                string _SoPhong = cboSoPhong.SelectedValue.ToString();
                data = new QLKSEntities();
                var phong = data.tPhongs
                        .Where(x => x.SoPhong == _SoPhong)
                        .FirstOrDefault();
                if (phong != null)
                {
                    txtSoPhong.Text = phong.SoPhong;
                    txtGiaTien.Text = phong.GiaTien.ToString();
                    txtConSuDung.Text = phong.ConSuDung;
                }
            }
        }

        private void cboMaKhach_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMaKhach.SelectedValue != null)
            {
                string _MaKhach = cboMaKhach.SelectedValue.ToString();
                data = new QLKSEntities();
                var khach = data.tKhaches
                        .Where(x => x.MaKhach == _MaKhach)
                        .FirstOrDefault();
                if (khach != null)
                {
                    txtTenKhach.Text = khach.TenKhach;
                    txtCMND.Text = khach.SoCMND.ToString();
                    txtDienThoai.Text = khach.DienThoai.ToString();
                }
            }
        }

        private void dgThuePhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgThuePhong.Rows[e.RowIndex];

                txtSTT.Text = row.Cells[0].Value.ToString();

                cboSoPhong.SelectedIndex = cboSoPhong.FindStringExact(row.Cells[1].Value.ToString());
                cboSoPhong.Enabled = false;

                cboMaKhach.SelectedIndex = cboMaKhach.FindStringExact(row.Cells[2].Value.ToString());
                cboMaKhach.Enabled = false;

                dtNgayNhanPhong.Value = DateTime.Parse(row.Cells[5].Value.ToString());
                dtNgayTraPhong.Value = DateTime.Parse(row.Cells[6].Value.ToString());

                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgThuePhong_KeyDown(object sender, KeyEventArgs e)
        {
            //int rowIndex = dgThuePhong.CurrentCellAddress.Y;
            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow row = dgThuePhong.Rows[rowIndex];

            //    txtSTT.Text = row.Cells[0].Value.ToString();

            //    cboSoPhong.SelectedIndex = cboSoPhong.FindStringExact(row.Cells[1].Value.ToString());
            //    cboSoPhong.Enabled = false;

            //    cboMaKhach.SelectedIndex = cboMaKhach.FindStringExact(row.Cells[2].Value.ToString());
            //    cboMaKhach.Enabled = false;

            //    dtNgayNhanPhong.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            //    dtNgayTraPhong.Value = DateTime.Parse(row.Cells[6].Value.ToString());

            //    btnThem.Enabled = false;
            //    btnCapNhat.Enabled = true;
            //    btnXoa.Enabled = true;
            //}
        }

        private void dgThuePhong_KeyUp(object sender, KeyEventArgs e)
        {
            //int rowIndex = dgThuePhong.CurrentCellAddress.Y;
            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow row = dgThuePhong.Rows[rowIndex];
            //    txtSTT.Text = row.Cells[0].Value.ToString();
            //    txtSTT.Enabled = false;

            //    cboSoPhong.SelectedIndex = cboSoPhong.FindStringExact(row.Cells[1].Value.ToString());
            //    cboSoPhong.Enabled = false;

            //    cboMaKhach.SelectedIndex = cboMaKhach.FindStringExact(row.Cells[2].Value.ToString());
            //    cboMaKhach.Enabled = false;

            //    txtTenKhach.Text = row.Cells[3].Value.ToString();
            //    txtTenKhach.Enabled = false;

            //    dtNgayNhanPhong.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            //    dtNgayTraPhong.Value = DateTime.Parse(row.Cells[5].Value.ToString());

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
                var thuephong = new tThuePhong
                {
                    SoPhong = cboSoPhong.SelectedValue.ToString(),
                    MaKhach = cboMaKhach.SelectedValue.ToString(),
                    NgayNhanPhong = dtNgayNhanPhong.Value,
                    NgayTraPhong = dtNgayTraPhong.Value,
                };
                data.tThuePhongs.Add(thuephong);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công", "Thông báo");

                CLEAR();
            }
        }

        private bool ValidateInputData()
        {
            if (string.IsNullOrEmpty(cboSoPhong.Text))
            {
                MessageBox.Show("Số phòng trống", "Thông báo");
                return false;
            }
            if (cboSoPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đúng Số phòng", "Thông báo");
                return false;
            }

            if (string.IsNullOrEmpty(cboMaKhach.Text))
            {
                MessageBox.Show("Mã Khách hàng trống", "Thông báo");
                return false;
            }
            if (cboMaKhach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đúng Mã Khách hàng", "Thông báo");
                return false;
            }

            // NgayTraPhong >= NgayNhanPhong
            int NamNhanPhong = dtNgayNhanPhong.Value.Year;
            int ThangNhanPhong = dtNgayNhanPhong.Value.Month;
            int NgayNhanPhong = dtNgayNhanPhong.Value.Day;

            int NamTraPhong = dtNgayTraPhong.Value.Year;
            int ThangTraPhong = dtNgayTraPhong.Value.Month;
            int NgayTraPhong = dtNgayTraPhong.Value.Day;

            if (NamTraPhong < NamNhanPhong)
            {
                MessageBox.Show("Ngày trả phòng phải bằng hoặc sau ngày nhận phòng", "Thông báo");
                return false;
            }
            else if (NamTraPhong == NamNhanPhong)
            {
                if (ThangTraPhong < ThangNhanPhong)
                {
                    MessageBox.Show("Ngày trả phòng phải bằng hoặc sau ngày nhận phòng", "Thông báo");
                    return false;
                }
                else if (ThangTraPhong >= ThangNhanPhong)
                {
                    if (NgayTraPhong < NgayNhanPhong)
                    {
                        MessageBox.Show("Ngày trả phòng phải bằng hoặc sau ngày nhận phòng", "Thông báo");
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            data = new QLKSEntities();

            if (MessageBox.Show("Are you sure!", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int _STT = int.Parse(txtSTT.Text);
                string _SoPhong = cboSoPhong.SelectedValue.ToString();
                string _MaKhach = cboMaKhach.SelectedValue.ToString();

                var thuephong = (tThuePhong)data.tThuePhongs
                    .Where(x => x.STT == _STT && x.SoPhong == _SoPhong && x.MaKhach == _MaKhach)
                    .FirstOrDefault();

                data.tThuePhongs.Remove(thuephong);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Xoá thành công", "Thông báo");

                CLEAR();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            CLEAR();
        }

        private void CLEAR()
        {
            dgThuePhong.ClearSelection();

            txtSTT.Text = "";

            cboSoPhong.SelectedIndex = -1;
            cboSoPhong.Enabled = true;
            txtSoPhong.Text = "";
            txtGiaTien.Text = "";
            txtConSuDung.Text = "";

            cboMaKhach.SelectedIndex = -1;
            cboMaKhach.Enabled = true;
            txtTenKhach.Text = "";
            txtCMND.Text = "";
            txtDienThoai.Text = "";

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
