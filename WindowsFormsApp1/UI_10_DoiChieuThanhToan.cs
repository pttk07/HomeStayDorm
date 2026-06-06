using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_10_DoiChieuThanhToan : Form
    {
        public UI_10_DoiChieuThanhToan()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
        }

        private void formLoad(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            dateTimePickerFrom.Value = new DateTime(2026, 5, 1);
            dateTimePickerTo.Value = new DateTime(2026, 6, 6);
            dataGridViewThanhToan.Rows.Clear();

            dataGridViewThanhToan.Rows.Add("HD-2504-001", "01/06/2026", "2.000.000", "Đã đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-002", "01/06/2026", "1.800.000", "Đã đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-003", "01/06/2026", "2.000.000", "Đã đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2505-004", "01/06/2026", "2.100.000", "Chưa đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-005", "01/06/2026", "2.000.000", "Chưa đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-006", "01/06/2026", "2.100.000", "Chưa đối chiếu");
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            dataGridViewThanhToan.Rows.Clear();
            dataGridViewThanhToan.Rows.Add("HD-2504-001", "01/06/2026", "2.000.000", "Đã đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-002", "01/06/2026", "1.800.000", "Đã đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-003", "01/06/2026", "2.000.000", "Đã đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2505-004", "01/06/2026", "2.100.000", "Chưa đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-005", "01/06/2026", "2.000.000", "Chưa đối chiếu");
            dataGridViewThanhToan.Rows.Add("HD-2504-006", "01/06/2026", "2.100.000", "Chưa đối chiếu");
            MessageBox.Show("Đã tải dữ liệu.", "Tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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