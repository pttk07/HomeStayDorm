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
    public partial class UI_24b_CapNhatThongTinKhach : Form
    {
        public UI_24b_CapNhatThongTinKhach()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // ── Dữ liệu mẫu thông tin ban đầu (từ 24a) ─────────────────
            txtMaDangKy.Text = "DK-2025-00142";
            txtHoTenCu.Text = "Nguyễn Văn An";
            txtSoDienThoaiCu.Text = "0901234567";
            txtEmailCu.Text = "nguyenvanan@email.com";
            lblGioiTinhCu.Text = "Nam";
            lblKhuVucCu.Text = "Quận Bình Thạnh";
            lblLoaiPhongCu.Text = "Phòng đôi (2 người)";
            lblMucGiaCu.Text = "1 – 2 triệu / tháng";
            lblNgayVaoOCu.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            lblThoiHanCu.Text = "6 tháng";
            lblSoNguoiCu.Text = "2 người";
            lblTieuChiCu.Text = "Điều hòa, Gửi xe";
            lblGhiChuCu.Text = "Cần phòng yên tĩnh, có điều hòa, gửi xe máy.";

            // ── Dữ liệu mẫu phòng xác định đã xem ──────────────────────
            txtPhongXacDinh.Text = "P204 – Tòa A – Tầng 2";
            txtGiaThue.Text = "1,800,000";
            txtSoGiuong.Text = "2";
            cboHinhThucThue.Items.AddRange(new string[] { "Thuê giường ghép", "Thuê nguyên phòng" });
            cboHinhThucThue.SelectedIndex = 0;

            // ── Dữ liệu có thể cập nhật ─────────────────────────────────
            txtHoTenMoi.Text = "Nguyễn Văn An";
            txtSoDienThoaiMoi.Text = "0901234567";
            txtEmailMoi.Text = "an.nguyen2025@gmail.com";   // thay đổi email
            radNamMoi.Checked = true;
            dtpNgayVaoOMoi.Value = DateTime.Now.AddDays(10);    // đổi ngày vào ở
            cboThoiHanMoi.Items.AddRange(new string[] {
                "1 tháng", "3 tháng", "6 tháng", "12 tháng", "Khác"
            });
            cboThoiHanMoi.SelectedIndex = 2;
            txtSoNguoiMoi.Text = "2";
            txtGiayToBoSung.Text = "CCCD 034095001234 – Bổ sung hộ khẩu tạm trú.";

            // Trạng thái xác nhận
            cboTrangThai.Items.AddRange(new string[] {
                "Đang rà soát", "Đã xác nhận – Tiếp tục đặt cọc", "Cần bổ sung giấy tờ", "Từ chối"
            });
            cboTrangThai.SelectedIndex = 1;
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thông tin thành công!\nChuyển sang bước xác nhận đặt cọc.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongBo_Click(object sender, EventArgs e)
        {
            // Placeholder: đồng bộ lại từ dữ liệu đăng ký ban đầu
            MessageBox.Show("Đã đồng bộ thông tin từ phiếu đăng ký ban đầu.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}