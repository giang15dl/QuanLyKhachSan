using Microsoft.Reporting.WinForms;
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
    public partial class frmBaoCao : Form
    {
        QLKSEntities data = new QLKSEntities();

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKSDataSet.tKhach' table. You can move, or remove it, as needed.
            //this.tKhachTableAdapter.Fill(this.QLKSDataSet.tKhach);
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            this.report.RefreshReport();
        }

        private void btnBaoCaoKhachHang_Click(object sender, EventArgs e)
        {
            report.Visible = true;

            List<tKhach> lstKhach = data.tKhaches.ToList();

            this.report.LocalReport.ReportPath = "./Report/ReportKhachHang.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("Dataset_KhachHang", lstKhach);

            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(reportDataSource);

            this.report.RefreshReport();
        }

        private void btnBaoCaoPhong_Click(object sender, EventArgs e)
        {
            report.Visible = true;
            
            List<tPhong> lstPhong = data.tPhongs.ToList();

            this.report.LocalReport.ReportPath = "./Report/ReportPhong.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("Dataset_Phong", lstPhong);
            
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(reportDataSource);

            this.report.RefreshReport();
        }

        private void btnBaoCaoThietBi_Click(object sender, EventArgs e)
        {
            report.Visible = true;

            List<tThietBi> lstThietBi = data.tThietBis.ToList();

            this.report.LocalReport.ReportPath = "./Report/ReportThietBi.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("Dataset_ThietBi", lstThietBi);

            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(reportDataSource);

            this.report.RefreshReport();
        }
    }
}
