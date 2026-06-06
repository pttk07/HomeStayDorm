using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_25_DashboardQuanLy : Form
    {
        public UI_25_DashboardQuanLy()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += UI_25_DashboardQuanLy_Load;
        }

        private void UI_25_DashboardQuanLy_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            UpdateClock(null, null);
            LoadThongBao();
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy  HH:mm:ss");
        }

        private void LoadThongBao()
        {
            // Dữ liệu mẫu: các việc cần xử lý hôm nay
            dgvCongViec.Columns.Clear();
            dgvCongViec.Columns.Add("STT", "#");
            dgvCongViec.Columns.Add("LoaiViec", "Loại công việc");
            dgvCongViec.Columns.Add("DoiTuong", "Đối tượng");
            dgvCongViec.Columns.Add("MoTa", "Mô tả");
            dgvCongViec.Columns.Add("UuTien", "Ưu tiên");

            dgvCongViec.Columns["STT"].FillWeight = 25;
            dgvCongViec.Columns["LoaiViec"].FillWeight = 110;
            dgvCongViec.Columns["UuTien"].FillWeight = 60;

            dgvCongViec.Rows.Add("1", "Đối chiếu chứng từ",    "Phiếu cọc PC-2506-002",   "Xác nhận thanh toán cọc của Phạm Thị Dung (P103)",      "🔴 Cao");
            dgvCongViec.Rows.Add("2", "Kiểm tra điều kiện thuê", "PC-2506-001 – Trần Thị Bình", "Kiểm tra giấy tờ, điều kiện trước ký HĐ (P202-G202A)", "🔴 Cao");
            dgvCongViec.Rows.Add("3", "Lập biên bản bàn giao",  "P202 - G202A",            "Khách nhận phòng lúc 14:00 hôm nay",                     "🟡 Vừa");
            dgvCongViec.Rows.Add("4", "Cập nhật trạng thái phòng", "P301 - Chi nhánh Q7",  "Phòng bảo trì hoàn tất, chuyển về Trống",                "🟡 Vừa");
            dgvCongViec.Rows.Add("5", "Tạo biên bản thanh lý",  "HD-2503-007 – Bùi Thị Ngọc", "Khách trả phòng sớm, lập biên bản thanh lý HĐ",       "🟢 Thấp");

            for (int i = 0; i < dgvCongViec.Rows.Count; i++)
                dgvCongViec.Rows[i].DefaultCellStyle.BackColor =
                    i % 2 == 0 ? Color.White : Color.FromArgb(247, 249, 252);
        }

        // ─── Button handlers ──────────────────────────────────────────────────

        private void ShowForm(Form form)
        {
            using (form)
                form.ShowDialog(this);
        }

        private void btnDoiChieuChungTu_Click(object s, EventArgs e) => ShowForm(new UI_15_DoiChieuChungTu());
        private void btnKiemTraDieuKien_Click(object s, EventArgs e) => ShowForm(new UI_16_KiemTraDieuKienKhachThue());
        private void btnGhiNhanTinhTrang_Click(object s, EventArgs e) => ShowForm(new UI_17_GhiNhanTinhTrangPhongGiuong());
        private void btnCapNhatTrangThai_Click(object s, EventArgs e) => ShowForm(new UI_18_CapNhatTrangThaiPhongTrong());
        private void btnKiemTraPhongTrong_Click(object s, EventArgs e) => ShowForm(new UI_19_KiemTraPhongGiuongConTrong());
        private void btnLapBienBanBanGiao_Click(object s, EventArgs e) => ShowForm(new UI_20_LapBienBanGiaoPhong());
        private void btnTaoBienBanThanhLy_Click(object s, EventArgs e) => ShowForm(new UI_21_TaoBienBanThanhLyHopDong());

        private void btnLogout_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất khỏi hệ thống?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
