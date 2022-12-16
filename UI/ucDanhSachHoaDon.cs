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
    public partial class ucDanhSachHoaDon : UserControl
    {
        QLKSEntities data = new QLKSEntities();

        public ucDanhSachHoaDon()
        {
            InitializeComponent();
        }

        private void ucDanhSachHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            data = new QLKSEntities();

            List<tHoaDon> lstHoaDon = data.tHoaDons.ToList();
            int i = 0;
            var columns = from t in lstHoaDon
                          select new
                          {
                              STT = ++i, //0
                              MaThuePhong = t.MaThuePhong, //1
                              SoPhong = t.SoPhong, //2
                              KhachHang = getTenKhach(t.MaKhach), //3
                              DichVu = getTenDichVu(t.MaDichVu), //4
                              ThanhTien = t.ThanhTien, //5
                          };
            gcHoaDon.DataSource = columns.ToList();
        }

        private string getTenKhach(string makhach)
        {
            string tenkhach = data.tKhaches
                .Where(x => x.MaKhach == makhach)
                .Select(y => y.TenKhach)
                .FirstOrDefault();
            return tenkhach;
        }

        private string getTenDichVu(string madichvu)
        {
            string tendichvu = data.tDichVus
                .Where(x => x.MaDichVu == madichvu)
                .Select(y => y.TenDichVu)
                .FirstOrDefault();
            return tendichvu;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}
