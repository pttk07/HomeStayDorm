using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_09_LapBangDoiSoat : Form
    {
        public UI_09_LapBangDoiSoat()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += (s, e) => LoadDemoData();
        }

        private void LoadDemoData()
        {
            txtKhachHang.Text = "Bùi Thị Ngọc";
            txtMaHD.Text      = "HD-2503-007";
            txtPhong.Text     = "P102 - G102C  |  Q1 - Nữ";
            txtThoiGian.Text  = "01/03/2026 – 31/05/2026  (3 tháng – trả sớm)";
            txtTienCoc.Text   = "2.100.000 VNĐ";
            txtTienKhauTru.Text = "650.000 VNĐ";

            dgvPhatSinh.Rows.Clear();
            dgvPhatSinh.Rows.Add("Phí hư hỏng tài sản", "500.000 VNĐ", "Hư hỏng TV");
            dgvPhatSinh.Rows.Add("Phí vệ sinh",         "150.000 VNĐ", "Vệ sinh phòng khi trả");

            valTienHoan.Text  = "1.450.000 VNĐ";
            txtGhiChu.Text    = "Khách trả phòng đúng hạn. Hoàn tiền qua chuyển khoản.";
        }
    }
}
