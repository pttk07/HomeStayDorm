using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_26_DashboardQTHethong : Form
    {
        public UI_26_DashboardQTHethong()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += UI_26_DashboardQTHethong_Load;
        }

        private void UI_26_DashboardQTHethong_Load(object sender, EventArgs e)
        {
            timerClock.Start();
            timerClock_Tick(null, null);
            LoadRecentActivity();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy  HH:mm:ss");
        }

        private void LoadRecentActivity()
        {
            dgvRecent.Columns.Clear();
            dgvRecent.Columns.Add("ThoiGian", "Thời gian");
            dgvRecent.Columns.Add("LoaiHoatDong", "Loại hoạt động");
            dgvRecent.Columns.Add("DoiTuong", "Đối tượng");
            dgvRecent.Columns.Add("ChiTiet", "Chi tiết");
            dgvRecent.Columns.Add("NguoiThucHien", "Người thực hiện");

            dgvRecent.Rows.Add("07/06/2025 09:12", "Tạo người dùng", "Nguyễn Văn An", "Thêm tài khoản Sale mới", "admin");
            dgvRecent.Rows.Add("07/06/2025 08:45", "Cập nhật phòng", "P101 - Chi nhánh Q1", "Cập nhật giá thuê: 1.800.000 → 2.000.000đ", "admin");
            dgvRecent.Rows.Add("06/06/2025 17:30", "Xóa giường", "G205C - Chi nhánh Q7", "Giường đã thanh lý hợp đồng", "admin");
            dgvRecent.Rows.Add("06/06/2025 14:20", "Cập nhật người dùng", "Trần Thị Bình", "Đổi nhóm: Sale → Kế toán", "admin");
            dgvRecent.Rows.Add("05/06/2025 11:05", "Tạo phòng", "P312 - Chi nhánh Q3", "Phòng ghép nữ, 4 giường, 2.200.000đ/giường", "admin");

            // Color rows alternating
            for (int i = 0; i < dgvRecent.Rows.Count; i++)
            {
                dgvRecent.Rows[i].DefaultCellStyle.BackColor =
                    i % 2 == 0 ? Color.White : Color.FromArgb(247, 249, 252);
            }
        }

        private void btnQuanTriNguoiDung_Click(object sender, EventArgs e)
        {
            var form = new UI_22_QuanTriNguoiDung();
            form.Show();
        }

        private void btnQuanTriPhongGiuong_Click(object sender, EventArgs e)
        {
            var form = new UI_23_QuanTriPhongGiuong();
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                // Application.Restart() hoặc mở lại màn hình Login nếu có
            }
        }
    }
}
