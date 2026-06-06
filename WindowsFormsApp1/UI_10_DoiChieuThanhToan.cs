using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_10_DoiChieuThanhToan : Form
    {
        public UI_10_DoiChieuThanhToan()
        {
            InitializeComponent();
        }

        // Event handlers use camelCase naming and UI messages are Vietnamese.
        private void formLoad(object sender, EventArgs e)
        {
            // Ví dụ khởi tạo dữ liệu mặc định (có thể thay bằng gọi DB)
            txtTimKiem.Text = string.Empty;
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            dateTimePickerTo.Value = DateTime.Today;
            dataGridViewThanhToan.Rows.Clear();

            // Thêm hàng mẫu để minh họa
            dataGridViewThanhToan.Rows.Add("HD001", DateTime.Today.AddDays(-2).ToString("yyyy-MM-dd"), "1,200,000", "Chưa đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD002", DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"), "850,000", "Đã đối chiếu");
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            // TODO: tải dữ liệu từ nguồn (DB, API...). Hiện hiển thị MessageBox tạm thời.
            MessageBox.Show("Tải dữ liệu theo khoảng thời gian đã chọn.", "Tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ví dụ: lọc theo ngày (thực tế: thay bằng truy vấn)
            // Ở đây chỉ làm demo: xóa và thêm lại mẫu
            dataGridViewThanhToan.Rows.Clear();
            dataGridViewThanhToan.Rows.Add("HD010", dateTimePickerFrom.Value.ToString("yyyy-MM-dd"), "500,000", "Chưa đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD011", dateTimePickerTo.Value.ToString("yyyy-MM-dd"), "2,000,000", "Chưa đối chiếu");
        }

        private void btnDoiChieu_Click(object sender, EventArgs e)
        {
            // TODO: logic đối chiếu thực tế
            if (dataGridViewThanhToan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để đối chiếu.", "Đối chiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in dataGridViewThanhToan.SelectedRows)
            {
                row.Cells["colTrangThai"].Value = "Đã đối chiếu";
            }

            MessageBox.Show("Đã thực hiện đối chiếu cho các mục được chọn.", "Đối chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Ví dụ lọc client-side theo mã đơn (thực tế: filter trên nguồn dữ liệu)
            string term = txtTimKiem.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dataGridViewThanhToan.Rows)
            {
                bool visible = string.IsNullOrEmpty(term) || row.Cells["colMaDon"].Value.ToString().ToLower().Contains(term);
                row.Visible = visible;
            }
        }
    }
}