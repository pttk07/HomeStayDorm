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
    public partial class UI_06a_TinhToanTienCoc : Form
    {
        private decimal _mucGia;

        public UI_06a_TinhToanTienCoc()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += Form_Load;
            btnChonPhieu.Click += btnChonPhieu_Click;
            btnXacNhan.Click   += btnXacNhan_Click;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dgvBangGia.Rows.Add("Giường ghép – Khu 1 (P101 / P102)",  "2.000.000 – 2.100.000 VNĐ/tháng", "1 tháng tiền thuê");
            dgvBangGia.Rows.Add("Giường ghép – Khu 3 (P201 / P202)",  "1.800.000 – 2.200.000 VNĐ/tháng", "1 tháng tiền thuê");
            dgvBangGia.Rows.Add("Phòng nguyên căn (P103)",             "3.500.000 VNĐ/tháng",              "2 tháng tiền thuê");
            dgvBangGia.Rows.Add("Phòng VIP (P301 / P302)",             "Theo thỏa thuận",                  "2 tháng tiền thuê");
        }

        private void btnChonPhieu_Click(object sender, EventArgs e)
        {
            using (var lookup = new TraCuuPhieuThongTinThue())
            {
                if (lookup.ShowDialog(this) != DialogResult.OK) return;

                txtMaPhieu.Text   = lookup.SelectedMaPhieu;
                txtKhachHang.Text = lookup.SelectedKhachHang;

                string phong = lookup.SelectedPhong ?? "";
                txtMaPhong.Text = phong;
                _mucGia = GetMucGia(phong);
                txtMucGia.Text = AppUiStyle.Money(_mucGia) + "/tháng";

                decimal tienCoc = phong.ToUpper().Contains("P103") || phong.ToUpper().Contains("P30")
                    ? _mucGia * 2 : _mucGia;
                txtTienCoc.Text = AppUiStyle.Money(tienCoc);
            }
        }

        private decimal GetMucGia(string phong)
        {
            string p = phong.ToUpper();
            if (p.Contains("G202") || p.Contains("G202A") || p.Contains("G202B")) return 2_200_000;
            if (p.Contains("G102") || p.Contains("G102A") || p.Contains("G102D")) return 2_100_000;
            if (p.Contains("P103")) return 3_500_000;
            if (p.Contains("G201") || p.Contains("G201A") || p.Contains("G201B")) return 1_800_000;
            return 2_000_000;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu thuê trước.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var phieu = new UI_06b_XuatYeuCauThanhToan
            {
                KhachHang = txtKhachHang.Text,
                Phong     = txtMaPhong.Text,
                SoTien    = _mucGia * (txtMaPhong.Text.ToUpper().Contains("P103") ? 2m : 1m)
            };
            phieu.ShowDialog(this);
        }
    }
}
