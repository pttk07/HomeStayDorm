using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_02a_TraCuuPhieuDatCoc : Form
    {
        // Thuộc tính để trả dữ liệu về Form gốc
        public string SelectedDepositCode { get; private set; }
        public string SelectedCustomerName { get; private set; }
        public string SelectedRoom { get; private set; }

        public UI_02a_TraCuuPhieuDatCoc()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
        }

        private void UI_02a_TraCuuPhieuDatCoc_Load(object sender, EventArgs e)
        {
            // Khởi tạo cột cho DataGridView
            dgvResults.ColumnCount = 4;
            dgvResults.Columns[0].Name = "Mã phiếu cọc";
            dgvResults.Columns[1].Name = "Khách hàng";
            dgvResults.Columns[2].Name = "Số phòng";
            dgvResults.Columns[3].Name = "Ngày cọc";
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear();

            var allPhieu = new[]
            {
                new[]{ "PC-2506-001", "Trần Thị Bình",    "P202 - G202A", "05/06/2026" },
                new[]{ "PC-2506-002", "Phạm Thị Dung",    "P103",         "06/06/2026" },
                new[]{ "PC-2506-003", "Nguyễn Thị Lan",   "P102 - G102B", "04/06/2026" },
                new[]{ "PC-2506-004", "Phan Văn Bình",     "P201 - G201B", "03/06/2026" },
            };

            string keyword = txtSearchKeyword.Text.Trim().ToLower();
            foreach (var p in allPhieu)
            {
                bool match = string.IsNullOrEmpty(keyword)
                    || p[0].ToLower().Contains(keyword)
                    || p[1].ToLower().Contains(keyword)
                    || p[2].ToLower().Contains(keyword);
                if (match)
                    dgvResults.Rows.Add(p[0], p[1], p[2], p[3]);
            }

            if (dgvResults.Rows.Count == 0)
                MessageBox.Show("Không tìm thấy phiếu cọc phù hợp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvResults.SelectedRows[0];
                SelectedDepositCode = row.Cells[0].Value?.ToString();
                SelectedCustomerName = row.Cells[1].Value?.ToString();
                SelectedRoom = row.Cells[2].Value?.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu cọc từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
