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

        private void btnTraCuuHD_Click(object sender, EventArgs e)
        {
            using (var lookup = new UI_08_TraCuuHopDong())
            {
                if (lookup.ShowDialog(this) != DialogResult.OK) return;

                txtMaHD.Text      = lookup.SelectedMaHD;
                txtKhachHang.Text = lookup.SelectedKhachHang;
                txtPhong.Text     = lookup.SelectedPhong;

                // Tính thời gian lưu trú từ ngày bắt đầu đến ngày kết thúc HĐ
                // SelectedMucGia dạng "2.000.000 VNĐ" — dùng làm tiền cọc gốc (1 tháng)
                string mucGiaRaw = (lookup.SelectedMucGia ?? "").Replace(" VNĐ", "").Replace(".", "").Trim();
                decimal mucGia = 0;
                decimal.TryParse(mucGiaRaw, out mucGia);

                txtThoiGian.Text    = "Đến " + (lookup.SelectedNgayKetThuc ?? "");
                txtTienCoc.Text     = mucGia > 0 ? AppUiStyle.Money(mucGia) : txtTienCoc.Text;
                txtTienKhauTru.Text = "0 VNĐ";
                valTienHoan.Text    = mucGia > 0 ? AppUiStyle.Money(mucGia) : valTienHoan.Text;

                dgvPhatSinh.Rows.Clear();
                txtGhiChu.Clear();
            }
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
