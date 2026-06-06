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

            dgvCongViec.Rows.Add("1", "Đối chiếu chứng từ", "Phiếu cọc #PC2506-08", "Xác nhận thanh toán cọc từ sale Văn An", "🔴 Cao");
            dgvCongViec.Rows.Add("2", "Kiểm tra điều kiện thuê", "Khách: Trần Minh Quân", "Kiểm tra giấy tờ, điều kiện trước ký HĐ", "🔴 Cao");
            dgvCongViec.Rows.Add("3", "Lập biên bản bàn giao", "P102 - Giường B", "Khách nhận phòng lúc 14:00 hôm nay", "🟡 Vừa");
            dgvCongViec.Rows.Add("4", "Cập nhật trạng thái phòng", "P301 - Chi nhánh Q7", "Phòng bảo trì hoàn tất, chuyển về Trống", "🟡 Vừa");
            dgvCongViec.Rows.Add("5", "Tạo biên bản thanh lý", "HĐ #HD2503-15", "Khách trả phòng, thanh lý hợp đồng", "🟢 Thấp");

            for (int i = 0; i < dgvCongViec.Rows.Count; i++)
                dgvCongViec.Rows[i].DefaultCellStyle.BackColor =
                    i % 2 == 0 ? Color.White : Color.FromArgb(247, 249, 252);
        }

        // ─── Button handlers ──────────────────────────────────────────────────

        private void MoFormGia(string ten)
        {
            new UI_00_FormGia(ten).ShowDialog();
        }

        private void btnDoiChieuChungTu_Click(object s, EventArgs e) => MoFormGia("Đối chiếu chứng từ");
        private void btnKiemTraDieuKien_Click(object s, EventArgs e) => MoFormGia("Kiểm tra điều kiện khách thuê");
        private void btnGhiNhanTinhTrang_Click(object s, EventArgs e) => MoFormGia("Ghi nhận tình trạng phòng/giường");
        private void btnCapNhatTrangThai_Click(object s, EventArgs e) => MoFormGia("Cập nhật trạng thái phòng trống");
        private void btnKiemTraPhongTrong_Click(object s, EventArgs e) => MoFormGia("Kiểm tra phòng/giường còn trống");
        private void btnLapBienBanBanGiao_Click(object s, EventArgs e) => MoFormGia("Lập biên bản bàn giao phòng");
        private void btnTaoBienBanThanhLy_Click(object s, EventArgs e) => MoFormGia("Tạo biên bản thanh lý hợp đồng");

        private void btnLogout_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất khỏi hệ thống?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}