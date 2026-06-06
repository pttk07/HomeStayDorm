using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_03_LapPhieuCoc : Form
    {
        public UI_03_LapPhieuCoc()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtSelectedRoom.Text) ||
                string.IsNullOrWhiteSpace(txtDepositAmount.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc (Mã khách, Phòng chọn, Số tiền cọc).", "Lỗi hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal depositAmount;
            if (!decimal.TryParse(txtDepositAmount.Text, out depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Số tiền cọc không hợp lệ. Phải là số lớn hơn 0.", "Lỗi hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ở đây có thể thêm code lưu vào CSDL
            // Hệ thống xuất thông tin đặt cọc
            string depositInfo = string.Format("Phiếu đặt cọc đã được lưu thành công!\n\n" +
                                 "Khách hàng: {0}\n" +
                                 "Phòng: {1}\n" +
                                 "Số tiền cọc: {2:C0}\n" +
                                 "Ngày cọc: {3}\n" +
                                 "Thời gian nhận phòng: {4}", 
                                 txtCustomerName.Text, txtSelectedRoom.Text, depositAmount, 
                                 dtpDepositDate.Value.ToString("dd/MM/yyyy"), 
                                 dtpCheckIn.Value.ToString("dd/MM/yyyy HH:mm"));

            MessageBox.Show(depositInfo, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Hậu điều kiện: Chuyển yêu cầu sang Kế toán
            MessageBox.Show("Đã gửi yêu cầu thanh toán sang bộ phận Kế toán (UI_KeToan).", "Chuyển bước", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }

        private void dtpDepositDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDepositDate.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
        }
    }
}
