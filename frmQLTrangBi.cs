using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmQLTrangBi : Form
    {
        QLKSEntities data = new QLKSEntities();
        public frmQLTrangBi()
        {
            InitializeComponent();
        }

        private void frmQLTrangBi_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            init();
            LoadData();
        }

        private void init()
        {
            cboSoPhong.DataSource = data.tPhongs.ToList();
            cboSoPhong.DisplayMember = "SoPhong";
            cboSoPhong.ValueMember = "SoPhong";
            cboSoPhong.SelectedIndex = -1;

            cboThietBi.DataSource = data.tThietBis.ToList();
            cboThietBi.DisplayMember = "TenThietBi";
            cboThietBi.ValueMember = "MaThietBi";
            cboThietBi.SelectedIndex = -1;

            dtNgayBatDauTrangBi.Format = DateTimePickerFormat.Custom;
            dtNgayBatDauTrangBi.CustomFormat = "dd/MM/yyyy";

            dtNgayKetThucTrangBi.Format = DateTimePickerFormat.Custom;
            dtNgayKetThucTrangBi.CustomFormat = "dd/MM/yyyy";

            this.ActiveControl = cboSoPhong;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tTrangBi> lstTrangBi = data.tTrangBis.ToList();
            int i = 0;
            var columns = from t in lstTrangBi
                          select new
                          {
                              No = ++i, //0
                              SoPhong = t.SoPhong, //1
                              MaThietBi = t.MaThietBi, //2
                              TenThietBi = t.tThietBi.TenThietBi, //3
                              NgayBatDauTrangBi = t.NgayBatDauTrangBi, //4
                              NgayKetThucTrangBi = t.NgayKetThucTrangBi, //5
                          };
            dgTrangBi.DataSource = columns.ToList();
            dgTrangBi.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgTrangBi.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dgTrangBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgTrangBi.Rows[e.RowIndex];
                cboSoPhong.SelectedIndex = cboSoPhong.FindStringExact(row.Cells[1].Value.ToString());
                cboSoPhong.Enabled = false;

                cboThietBi.SelectedIndex = cboThietBi.FindStringExact(row.Cells[3].Value.ToString());
                cboThietBi.Enabled = false;

                dtNgayBatDauTrangBi.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                dtNgayKetThucTrangBi.Value = DateTime.Parse(row.Cells[5].Value.ToString());

                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgTrangBi_KeyDown(object sender, KeyEventArgs e)
        {
            //int rowIndex = dgTrangBi.CurrentCellAddress.Y;
            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow row = dgTrangBi.Rows[rowIndex];
            //    cboSoPhong.SelectedIndex = cboSoPhong.FindStringExact(row.Cells[1].Value.ToString());
            //    cboThietBi.SelectedIndex = cboThietBi.FindStringExact(row.Cells[3].Value.ToString());
            //    dtNgayBatDauTrangBi.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            //    dtNgayKetThucTrangBi.Value = DateTime.Parse(row.Cells[5].Value.ToString());

            //    cboSoPhong.Enabled = false;
            //    cboThietBi.Enabled = false;
            //    btnThem.Enabled = false;
            //    btnCapNhat.Enabled = true;
            //    btnXoa.Enabled = true;
            //}
        }

        private void dgTrangBi_KeyUp(object sender, KeyEventArgs e)
        {
            //int rowIndex = dgTrangBi.CurrentCellAddress.Y;
            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow row = dgTrangBi.Rows[rowIndex];
            //    cboSoPhong.SelectedIndex = cboSoPhong.FindStringExact(row.Cells[1].Value.ToString());
            //    cboThietBi.SelectedIndex = cboThietBi.FindStringExact(row.Cells[3].Value.ToString());
            //    dtNgayBatDauTrangBi.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            //    dtNgayKetThucTrangBi.Value = DateTime.Parse(row.Cells[5].Value.ToString());

            //    cboSoPhong.Enabled = false;
            //    cboThietBi.Enabled = false;
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
                var trangbi = new tTrangBi
                {
                    SoPhong = cboSoPhong.SelectedValue.ToString(),
                    MaThietBi = cboThietBi.SelectedValue.ToString(),
                    NgayBatDauTrangBi = dtNgayBatDauTrangBi.Value,
                    NgayKetThucTrangBi = dtNgayKetThucTrangBi.Value,
                };
                data.tTrangBis.Add(trangbi);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công", "Thông báo");

                CLEAR();
            }
        }

        private bool ValidateInputData()
        {
            data = new QLKSEntities();

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

            if (string.IsNullOrEmpty(cboThietBi.Text))
            {
                MessageBox.Show("Thiết bị trống", "Thông báo");
                return false;
            }
            if (cboThietBi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đúng Thiết bị", "Thông báo");
                return false;
            }

            string _SoPhong = cboSoPhong.SelectedValue.ToString();
            string _MaThietBi = cboThietBi.SelectedValue.ToString();
            var isDuplicate = data.tTrangBis
                    .Where(x => x.SoPhong == _SoPhong && x.MaThietBi == _MaThietBi)
                    .FirstOrDefault();
            if (isDuplicate != null)
            {
                MessageBox.Show("Trang bị đã tồn tại!", "Thông báo");
                return false;
            }

            // NgayKetThuc > NgayBatDau
            int NamBatDauTrangBi = dtNgayBatDauTrangBi.Value.Year;
            int ThangBatDauTrangBi = dtNgayBatDauTrangBi.Value.Month;
            int NgayBatDauTrangBi = dtNgayBatDauTrangBi.Value.Day;

            int NamKetThucTrangBi = dtNgayKetThucTrangBi.Value.Year;
            int ThangKetThucTrangBi = dtNgayKetThucTrangBi.Value.Month;
            int NgayKetThucTrangBi = dtNgayKetThucTrangBi.Value.Day;

            if (NamKetThucTrangBi < NamBatDauTrangBi)
            {
                MessageBox.Show("Ngày kết thúc trang bị phải bằng hoặc sau ngày bắt đầu trang bị0", "Thông báo");
                return false;
            }
            else if (NamKetThucTrangBi == NamBatDauTrangBi)
            {
                if (ThangKetThucTrangBi < ThangBatDauTrangBi)
                {
                    MessageBox.Show("Ngày kết thúc trang bị phải bằng hoặc sau ngày bắt đầu trang bị1", "Thông báo");
                    return false;
                }
                else if (ThangKetThucTrangBi >= ThangBatDauTrangBi)
                {
                    if (NgayKetThucTrangBi < NgayBatDauTrangBi)
                    {
                        MessageBox.Show("Ngày kết thúc trang bị phải bằng hoặc sau ngày bắt đầu trang bị2", "Thông báo");
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
                string _SoPhong = cboSoPhong.SelectedValue.ToString();
                string _MaThietBi = cboThietBi.SelectedValue.ToString();

                var trangbi = data.tTrangBis
                    .Where(x => x.SoPhong == _SoPhong && x.MaThietBi == _MaThietBi)
                    .FirstOrDefault();

                data.tTrangBis.Remove(trangbi);
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
            dgTrangBi.ClearSelection();
            cboSoPhong.SelectedIndex = -1;
            cboSoPhong.Enabled = true;
            cboThietBi.SelectedIndex = -1;
            cboThietBi.Enabled = true;

            this.ActiveControl = cboSoPhong;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }
    }
}
