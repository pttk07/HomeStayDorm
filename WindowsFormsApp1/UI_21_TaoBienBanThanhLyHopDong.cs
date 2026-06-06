using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class UI_21_TaoBienBanThanhLyHopDong : Form
    {
        public UI_21_TaoBienBanThanhLyHopDong()
        {
            InitializeComponent();
        }

        // Khi form load, khởi tạo bảng khoản phát sinh
        private void FormThanhLyHopDong_Load(object sender, EventArgs e)
        {
            // Thêm cột cho DataGridView
            phatSinhGrid.Columns.Add("LoaiKhoan", "Loại khoản");
            phatSinhGrid.Columns.Add("SoTien", "Số tiền");
            phatSinhGrid.Columns.Add("GhiChu", "Ghi chú");

            // Dữ liệu mẫu
            phatSinhGrid.Rows.Add("Phí hư hỏng", 500000, "Hư hỏng TV");
            phatSinhGrid.Rows.Add("Phí vệ sinh", 150000, "Vệ sinh phòng");
        }

        // Nút tải dữ liệu hợp đồng
        private void taiDuLieuButton_Click(object sender, EventArgs e)
        {
            if (hopDongComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần thanh lý!", "Thông báo");
                return;
            }

            string hopDong = hopDongComboBox.SelectedItem.ToString();
            MessageBox.Show($"Đã tải dữ liệu cho hợp đồng: {hopDong}", "Thông báo");
        }

        // Nút thêm khoản phát sinh
        private void themKhoanButton_Click(object sender, EventArgs e)
        {
            phatSinhGrid.Rows.Add("", 0, "");
        }

        // Nút hoàn thành thanh lý
        private void hoanThanhButton_Click(object sender, EventArgs e)
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in phatSinhGrid.Rows)
            {
                if (row.Cells["SoTien"].Value != null)
                {
                    decimal soTien;
                    if (decimal.TryParse(row.Cells["SoTien"].Value.ToString(), out soTien))
                    {
                        tongTien += soTien;
                    }
                }
            }

            tongTienLabel.Text = $"Tổng số tiền cần thanh toán/hoàn trả: {tongTien:N0} VND";
            trangThaiLabel.Text = "Trạng thái hợp đồng: Chờ thanh toán";

            MessageBox.Show("Biên bản thanh lý hợp đồng đã được tạo thành công!", "Thông báo");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
