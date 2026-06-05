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
        }

        private void formLoad(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            // Count only buttons in navPanel (functions)
            int total = navPanel.Controls.OfType<Button>().Count(b => b.Visible);
            lblTotalTasks.Text = $"Tổng chức năng: {total}";
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

        private void btnXuatYeuCauThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng 'Xuất yêu cầu thanh toán' đang là mô phỏng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTinhKhoanPhatSinh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng 'Tính khoản phát sinh' đang là mô phỏng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTraCuuHopDong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng 'Tra cứu hợp đồng' đang là mô phỏng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLapBangDoiSoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng 'Lập bảng đối soát' đang là mô phỏng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoiChieuKhoanThanhToan_Click(object sender, EventArgs e)
        {
            using (var f = new UI_11_TinhKhoanCanThanhToan())
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