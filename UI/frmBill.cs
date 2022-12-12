using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan.UI
{
    public partial class frmBill : DevExpress.XtraEditors.XtraForm
    {
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {

            XtraReport1 report = new XtraReport1();
        }
    }
}