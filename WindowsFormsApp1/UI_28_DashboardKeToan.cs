using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_28_DashboardKeToan : Form
    {
        public UI_28_DashboardKeToan()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
        }

        private void formLoad(object sender, EventArgs e)
        {
            UpdateSummary();
            LoadStatCards();
        }

        private void UpdateSummary()
        {
            int total = navPanel.Controls.OfType<Button>().Count(b => b.Visible);
            lblTotalTasks.Text = $"Tổng chức năng: {total}";
        }

        private void LoadStatCards()
        {
            lblYeuCauV.Text = "12";
            lblYeuCauS.Text = "↑ 3 hôm nay";
            lblDoiSoatV.Text = "5";
            lblDoiSoatS.Text = "Chờ đối chiếu";
            lblHoanTienV.Text = "2";
            lblHoanTienS.Text = "Cần xử lý";
            lblChoXuLyV.Text = "7";
            lblChoXuLyS.Text = "Tổng hồ sơ";
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            UpdateSummary();
            MessageBox.Show("Đã tải lại dashboard.", "Tải lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinhToanTienCoc_Click(object sender, EventArgs e)
        {
            using (var f = new UI_06a_TinhToanTienCoc())
                f.ShowDialog(this);
        }

        private void btnTinhKhoanPhatSinh_Click(object sender, EventArgs e)
        {
            using (var f = new UI_8_Tính_khoản_phát_sinh())
                f.ShowDialog(this);
        }

        private void btnTraCuuHopDong_Click(object sender, EventArgs e)
        {
            using (var f = new UI_08_TraCuuHopDong())
                f.ShowDialog(this);
        }

        private void btnLapBangDoiSoat_Click(object sender, EventArgs e)
        {
            using (var f = new UI_09_LapBangDoiSoat())
                f.ShowDialog(this);
        }

        private void btnDoiChieuKhoanThanhToan_Click(object sender, EventArgs e)
        {
            using (var f = new UI_10_DoiChieuThanhToan())
                f.ShowDialog(this);
        }

        private void btnTinhKhoanCanThanhToan_Click(object sender, EventArgs e)
        {
            using (var f = new UI_11_TinhKhoanCanThanhToan())
                f.ShowDialog(this);
        }

        private void btnHoanTienChoKhach_Click(object sender, EventArgs e)
        {
            using (var f = new UI_12_HoanTienChoKhach())
                f.ShowDialog(this);
        }

        private void btnCapNhatKetQuaThanhToan_Click(object sender, EventArgs e)
        {
            using (var f = new UI_13_CapNhatKetQuaThanhToan())
                f.ShowDialog(this);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
