using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKhachSan.Model;

namespace QLKhachSan.UI
{
    public partial class frmLogin : Form
    {
        QLKSEntities data = new QLKSEntities();

        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUsername;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Tên tài khoản trống", "Thông báo");
            }
            else
            {
                string _UserN = txtUsername.Text;
                var nhanvien = data.tNhanViens
                        .Where(x => x.UserN == _UserN)
                        .FirstOrDefault();
                if (nhanvien == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
                }
                else
                {
                    if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        MessageBox.Show("Mật khẩu trống!", "Thông báo");
                    }
                    else
                    {
                        if (nhanvien.PassW != txtPassword.Text)
                        {
                            MessageBox.Show("Sai mật khẩu", "Thông báo");
                        }
                        else
                        {
                            Program.OpenLoginFormOnClose = true;
                            this.Close();
                        }
                    }
                }
            }
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (String.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Tên tài khoản trống", "Thông báo");
                }
                else
                {
                    string _UserN = txtUsername.Text;
                    var nhanvien = data.tNhanViens
                            .Where(x => x.UserN == _UserN)
                            .FirstOrDefault();
                    if (nhanvien == null)
                    {
                        MessageBox.Show("Tài khoản không tồn tại", "Thông báo");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(txtPassword.Text.Trim()))
                        {
                            MessageBox.Show("Mật khẩu trống!", "Thông báo");
                        }
                        else
                        {
                            if (nhanvien.PassW != txtPassword.Text)
                            {
                                MessageBox.Show("Sai mật khẩu", "Thông báo");
                            }
                            else
                            {
                                Program.OpenLoginFormOnClose = true;
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (this.ActiveControl.Name == btnLogin.Name)
                {
                    btnLogin.FillColor = Color.Goldenrod;
                    btnLogin.FillColor2 = Color.Goldenrod;
                }
                else
                {
                    btnLogin.FillColor = Color.FromArgb(0, 109, 240);
                    btnLogin.FillColor2 = Color.FromArgb(0, 109, 240);
                }

                if (this.ActiveControl.Name == btnExit.Name)
                {
                    btnExit.FillColor = Color.Goldenrod;
                }
                else
                {
                    btnExit.FillColor = Color.FromArgb(0, 109, 240);
                }
            }
        }
    }
}
