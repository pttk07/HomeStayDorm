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
            string keyword = txtSearchKeyword.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu cọc, Tên hoặc SĐT để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dữ liệu giả lập
            dgvResults.Rows.Add("PC001", "Nguyễn Văn A", "101", "15/09/2023");
            dgvResults.Rows.Add("PC002", "Trần Thị B", "102", "16/09/2023");
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
