using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnQLThuePhong_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }

            bool present = false;
            foreach (Form frm in openForms)
            {
                if (frm.Name == "frmQLThuePhong")
                {
                    present = true;
                }
            }

            if (!present)
            {
                List<Form> _openForms = new List<Form>();

                foreach (Form t in Application.OpenForms)
                {
                    _openForms.Add(t);
                }

                foreach (Form t in _openForms)
                {
                    if (t.Name != "frmMain")
                    {
                        t.Close();
                    }
                }

                frmQLThuePhong f = new frmQLThuePhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }

            bool present = false;
            foreach (Form frm in openForms)
            {
                if (frm.Name == "frmQLKhachHang")
                {
                    present = true;
                }
            }

            if (!present)
            {
                List<Form> _openForms = new List<Form>();

                foreach (Form t in Application.OpenForms)
                {
                    _openForms.Add(t);
                }

                foreach (Form t in _openForms)
                {
                    if (t.Name != "frmMain")
                    {
                        t.Close();
                    }
                }

                frmQLKhachHang f = new frmQLKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }

            bool present = false;
            foreach (Form frm in openForms)
            {
                if (frm.Name == "frmQLPhong")
                {
                    present = true;
                }
            }

            if (!present)
            {
                List<Form> _openForms = new List<Form>();

                foreach (Form t in Application.OpenForms)
                {
                    _openForms.Add(t);
                }

                foreach (Form t in _openForms)
                {
                    if (t.Name != "frmMain")
                    {
                        t.Close();
                    }
                }

                frmQLPhong f = new frmQLPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLThietBi_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form t in Application.OpenForms)
            {
                openForms.Add(t);
            }

            bool present = false;
            foreach (Form frm in openForms)
            {
                if (frm.Name == "frmQLThietBi")
                {
                    present = true;
                }
            }

            if (!present)
            {
                List<Form> _openForms = new List<Form>();

                foreach (Form t in Application.OpenForms)
                    _openForms.Add(t);

                foreach (Form t in _openForms)
                {
                    if (t.Name != "frmMain")
                        t.Close();
                }

                frmQLThietBi f = new frmQLThietBi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLTrangBi_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form t in Application.OpenForms)
            {
                openForms.Add(t);
            }

            bool present = false;
            foreach (Form frm in openForms)
            {
                if (frm.Name == "frmQLTrangBi")
                {
                    present = true;
                }
            }

            if (!present)
            {
                List<Form> _openForms = new List<Form>();

                foreach (Form t in Application.OpenForms)
                    _openForms.Add(t);

                foreach (Form t in _openForms)
                {
                    if (t.Name != "frmMain")
                        t.Close();
                }

                frmQLTrangBi f = new frmQLTrangBi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form t in Application.OpenForms)
            {
                openForms.Add(t);
            }

            foreach (Form frm in openForms)
            {
                if (frm.Name != "frmMain")
                {
                    frm.Close();
                }
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form t in Application.OpenForms)
            {
                openForms.Add(t);
            }

            bool present = false;
            foreach (Form frm in openForms)
            {
                if (frm.Name == "frmBaoCao")
                {
                    present = true;
                }
            }

            if (!present)
            {
                List<Form> _openForms = new List<Form>();

                foreach (Form t in Application.OpenForms)
                    _openForms.Add(t);

                foreach (Form t in _openForms)
                {
                    if (t.Name != "frmMain")
                        t.Close();
                }

                frmBaoCao f = new frmBaoCao();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
