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
            string depositInfo = $"Phiếu đặt cọc đã được lưu thành công!\n\n" +
                                 $"Khách hàng: {txtCustomerName.Text}\n" +
                                 $"Phòng: {txtSelectedRoom.Text}\n" +
                                 $"Số tiền cọc: {depositAmount:C0}\n" +
                                 $"Ngày cọc: {dtpDepositDate.Value.ToString("dd/MM/yyyy")}\n" +
                                 $"Thời gian nhận phòng: {dtpCheckIn.Value.ToString("dd/MM/yyyy HH:mm")}";

            MessageBox.Show(depositInfo, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
