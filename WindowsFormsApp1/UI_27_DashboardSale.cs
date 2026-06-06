using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_27_DashboardSale : Form
    {
        public UI_27_DashboardSale()
        {
            InitializeComponent();
            this.Load += UI_27_DashboardSale_Load;
        }

        private void UI_27_DashboardSale_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            UpdateClock(null, null);
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy  HH:mm:ss");
        }

        private void LoadHoatDongGanDay()
        {
            dgvHoatDong.Columns.Clear();
            dgvHoatDong.Columns.Add("ThoiGian", "Thời gian");
            dgvHoatDong.Columns.Add("HoatDong", "Hoạt động");
            dgvHoatDong.Columns.Add("KhachHang", "Khách hàng");
            dgvHoatDong.Columns.Add("ChiTiet", "Chi tiết");
            dgvHoatDong.Columns.Add("TrangThai", "Trạng thái");

            dgvHoatDong.Columns["ThoiGian"].FillWeight = 80;
            dgvHoatDong.Columns["TrangThai"].FillWeight = 70;

            dgvHoatDong.Rows.Add("07/06 09:30", "Lập phiếu đặt cọc", "Nguyễn Thị Hoa", "P202 - Giường A, B (2 giường)", "✅ Hoàn tất");
            dgvHoatDong.Rows.Add("07/06 08:15", "Đăng ký thông tin KH", "Trần Văn Bình", "Khách ghép phòng nam, Q1", "✅ Hoàn tất");
            dgvHoatDong.Rows.Add("06/06 16:45", "Tra cứu phòng trống", "—", "Tìm phòng nữ, ghép, Q3, ≤2.2tr", "✅ Hoàn tất");
            dgvHoatDong.Rows.Add("06/06 14:00", "Tiếp nhận thanh toán", "Lê Thị Cẩm", "Cọc phiếu #PC2506-07, 4.200.000đ", "⏳ Chờ XN QL");
            dgvHoatDong.Rows.Add("05/06 11:20", "Lập phiếu trả phòng", "Phạm Minh Tuấn", "HĐ #HD2503-12, trả G101A", "✅ Hoàn tất");

            for (int i = 0; i < dgvHoatDong.Rows.Count; i++)
            {
                dgvHoatDong.Rows[i].DefaultCellStyle.BackColor =
                    i % 2 == 0 ? Color.White : Color.FromArgb(247, 249, 252);
                string tt = dgvHoatDong.Rows[i].Cells["TrangThai"].Value?.ToString() ?? "";
                dgvHoatDong.Rows[i].Cells["TrangThai"].Style.ForeColor =
                    tt.Contains("Chờ") ? Color.FromArgb(133, 79, 11) : Color.FromArgb(15, 110, 86);
            }
        }

        // ─── Button handlers ──────────────────────────────────────────────────

        private void ShowForm(Form form)
        {
            using (form)
                form.ShowDialog(this);
        }

        private void btnTraCuuPhongTrong_Click(object s, EventArgs e) => ShowForm(new UI_01_TimKiemPhong());
        private void btnLapHopDong_Click(object s, EventArgs e) => ShowForm(new UI_02_LapHopDong());
        private void btnLapPhieuDatCoc_Click(object s, EventArgs e) => ShowForm(new UI_03_LapPhieuCoc());
        private void btnTiepNhanThanhToan_Click(object s, EventArgs e) => ShowForm(new UI_04_TiepNhanThanhToan());
        private void btnTaoPhieuTraPhong_Click(object s, EventArgs e) => ShowForm(new UI_05a_TaoPhieuThongTinTraPhong());
        private void btnDangKyThongTinKhach_Click(object s, EventArgs e)
        {
            ShowForm(new UI_24a_DangKyThongTinKhach());
        }

        private void btnCapNhatThongTinKhach_Click(object s, EventArgs e)
        {
            ShowForm(new UI_24b_CapNhatThongTinKhach());
        }

        private void btnLogout_Click(object s, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất khỏi hệ thống?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
