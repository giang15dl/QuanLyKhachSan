using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmQLPhong : Form
    {
        QLKSEntities data = new QLKSEntities();

        public frmQLPhong()
        {
            InitializeComponent();
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            init();
            LoadData();
        }

        private void init()
        {
            txtSoPhong.Text = "";

            txtGiaTien.Text = "0";

            List<string> consudung = new List<string >();
            consudung.Add("Yes");
            consudung.Add("No");
            cboConSuDung.DataSource = consudung;
            cboConSuDung.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void LoadData()
        {
            data = new QLKSEntities();
            List<tPhong> lstPhong = data.tPhongs.ToList();
            int i = 0;
            var columns = from t in lstPhong
                    select new
                    {
                        No = ++i, //0
                        SoPhong = t.SoPhong, //1
                        GiaTien = t.GiaTien, //2
                        ConSuDung = t.ConSuDung //3
                    };
            dgPhong.DataSource = columns.ToList();
        }

        private void dgPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgPhong.Rows[e.RowIndex];
                txtSoPhong.Text = row.Cells[1].Value.ToString();
                txtGiaTien.Text = row.Cells[2].Value.ToString();
                cboConSuDung.SelectedIndex = getIndexcboConSuDung(row.Cells[3].Value.ToString());
                
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        private void dgPhong_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIndex = dgPhong.CurrentCellAddress.Y;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgPhong.Rows[rowIndex];
                txtSoPhong.Text = row.Cells[1].Value.ToString();
                txtGiaTien.Text = row.Cells[2].Value.ToString();
                cboConSuDung.SelectedIndex = getIndexcboConSuDung(row.Cells[3].Value.ToString());
                
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgPhong_KeyUp(object sender, KeyEventArgs e)
        {
            int rowIndex = dgPhong.CurrentCellAddress.Y;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgPhong.Rows[rowIndex];
                txtSoPhong.Text = row.Cells[1].Value.ToString();
                txtGiaTien.Text = row.Cells[2].Value.ToString();
                cboConSuDung.SelectedIndex = getIndexcboConSuDung(row.Cells[3].Value.ToString());
                
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private int getIndexcboConSuDung(string YesNo)
        {
            if (YesNo.Equals("Yes"))
            {
                return 0;
            }
            return 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            data = new QLKSEntities();

            if (ValidateInputData())
            {
                var phong = new tPhong
                {
                    SoPhong = autoGenarateSoPhong(),
                    GiaTien = int.Parse(txtGiaTien.Text.Trim()),
                    ConSuDung = cboConSuDung.SelectedValue.ToString()
                };
                data.tPhongs.Add(phong);
                data.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công", "Thông báo");

                CLEAR();
            }
        }

        private string autoGenarateSoPhong()
        {
            int numberofRows = dgPhong.Rows.Count;
            
            if (numberofRows > 0)
            {
                int lastRowIndex = numberofRows - 1;
                DataGridViewRow lastRow = dgPhong.Rows[lastRowIndex];
                char[] SoPhongLastRow = lastRow.Cells[1].Value.ToString().ToArray(); //ex {'P','0','0','1'}

                if (int.Parse(SoPhongLastRow[1].ToString()) <= 0)
                {
                    if (int.Parse(SoPhongLastRow[2].ToString()) <= 0)
                    {
                        int idex3 = int.Parse(SoPhongLastRow[3].ToString());
                        string SoPhong = "P00" + (idex3+1);
                        return SoPhong;
                    }
                    else if (int.Parse(SoPhongLastRow[2].ToString()) > 0)
                    {
                        string idex2 = SoPhongLastRow[2].ToString();
                        string idex3 = SoPhongLastRow[3].ToString();
                        string index23 = idex2 + idex3;

                        string SoPhong = "P0" + (int.Parse(index23)+1);
                        return SoPhong;
                    }
                }
                else if (int.Parse(SoPhongLastRow[1].ToString()) > 0)
                {
                    string index1 = SoPhongLastRow[1].ToString();
                    string index2 = SoPhongLastRow[2].ToString();
                    string index3 = SoPhongLastRow[3].ToString();
                    string index123 = index1 + index2 + index3;

                    string SoPhong = "P" + (int.Parse(index123) + 1);
                    return SoPhong;
                }
            }
            return "P001";
        }

        private bool ValidateInputData()
        {
            data = new QLKSEntities();

            if (txtGiaTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giá tiền trống!", "Thông báo");
                return false;
            }

            if (string.IsNullOrEmpty(cboConSuDung.Text))
            {
                MessageBox.Show("'Còn sử dụng' trống", "Thông báo");
                return false;
            }
            if (cboConSuDung.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đúng 'Còn sử dụng'", "Thông báo");
                return false;
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
                string _SoPhong = txtSoPhong.Text.Trim();

                var phong = (tPhong) data.tPhongs
                    .Where(x => x.SoPhong == _SoPhong)
                    .FirstOrDefault();

                data.tPhongs.Remove(phong);
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
            dgPhong.ClearSelection();
            txtSoPhong.Text = "";
            txtGiaTien.Text = "0";
            cboConSuDung.SelectedIndex = 0;

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
