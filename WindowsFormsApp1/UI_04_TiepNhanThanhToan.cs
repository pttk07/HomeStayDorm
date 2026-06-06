using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_04_TiepNhanThanhToan : Form
    {
        public UI_04_TiepNhanThanhToan()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtRequiredAmount.Text) ||
                string.IsNullOrWhiteSpace(txtReceivedAmount.Text) ||
                cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thanh toán.", "Lỗi hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal requiredAmount, receivedAmount;
            if (!decimal.TryParse(txtRequiredAmount.Text, out requiredAmount) || requiredAmount <= 0)
            {
                MessageBox.Show("Số tiền yêu cầu không hợp lệ.", "Lỗi hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtReceivedAmount.Text, out receivedAmount) || receivedAmount <= 0)
            {
                MessageBox.Show("Số tiền thực nhận không hợp lệ.", "Lỗi hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dòng sự kiện phụ A3: Số tiền không khớp (khách trả thiếu)
            if (receivedAmount < requiredAmount)
            {
                decimal missing = requiredAmount - receivedAmount;
                MessageBox.Show($"Số tiền không khớp! Khách hàng còn thiếu: {missing:C0}.\nVui lòng thông báo lại cho khách hàng.", 
                    "Thanh toán chưa đủ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ghi nhận thành công
            string successMsg = $"Hệ thống ghi nhận thanh toán cọc thành công!\n\n" +
                                $"Khách hàng: {txtCustomerName.Text}\n" +
                                $"Số tiền đã nhận: {receivedAmount:C0}\n" +
                                $"Hình thức thanh toán: {cmbPaymentMethod.SelectedItem}\n" +
                                $"Ngày thanh toán: {dtpPaymentDate.Value.ToString("dd/MM/yyyy")}";

            MessageBox.Show(successMsg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Hậu điều kiện: Chuyển sang bước lập phiếu đặt cọc
            DialogResult result = MessageBox.Show("Ghi nhận thành công! Bạn có muốn chuyển sang bước Lập phiếu đặt cọc ngay bây giờ không?", 
                "Chuyển bước", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UI_03_LapPhieuCoc depositForm = new UI_03_LapPhieuCoc();
                // Optionally can pass parameters or data to this form if needed
                depositForm.Show();
            }

            this.Close();
        }
    }
}
