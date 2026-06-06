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
            AppUiStyle.Apply(this);
        }

        private void FormThanhLyHopDong_Load(object sender, EventArgs e)
        {
            hopDongComboBox.Items.AddRange(new object[] {
                "HD-2503-007 – Bùi Thị Ngọc (P102-G102C)",
                "HD-2502-008 – Ngô Quốc Phong (P201-G201B)",
                "HD-2411-009 – Phan Thị Xuân",
                "HD-2504-001 – Nguyễn Văn An (P101-G101A)",
                "HD-2504-002 – Lê Hoàng Cường (P201-G201A)",
                "HD-2504-003 – Võ Minh Đức (P101-G101B)",
            });
            hopDongComboBox.SelectedIndex = 0;

            phatSinhGrid.Columns.Add("LoaiKhoan", "Loại khoản");
            phatSinhGrid.Columns.Add("SoTien",    "Số tiền (VNĐ)");
            phatSinhGrid.Columns.Add("GhiChu",    "Ghi chú");

            phatSinhGrid.Rows.Add("Phí hư hỏng tài sản", 500000, "Hư hỏng TV, trầy xước bàn");
            phatSinhGrid.Rows.Add("Phí vệ sinh phòng",   150000, "Vệ sinh sau khi trả phòng");
            phatSinhGrid.Rows.Add("Tiền thuê còn nợ",    0,      "Đã thanh toán đủ");
        }

        private void taiDuLieuButton_Click(object sender, EventArgs e)
        {
            if (hopDongComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần thanh lý!", "Thông báo");
                return;
            }
            string hopDong = hopDongComboBox.SelectedItem.ToString();
            MessageBox.Show($"Đã tải dữ liệu cho hợp đồng: {hopDong}", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            tongTienLabel.Text = $"Tổng khấu trừ: {AppUiStyle.Money(tongTien)}";
            trangThaiLabel.Text = "Trạng thái hợp đồng: Chờ thanh toán";

            MessageBox.Show("Biên bản thanh lý hợp đồng đã được tạo thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phatSinhGrid.Rows.Add("", 0, "");
            // Focus vào ô đầu tiên của dòng mới để nhập liệu
            int lastRow = phatSinhGrid.Rows.Count - 1;
            phatSinhGrid.CurrentCell = phatSinhGrid.Rows[lastRow].Cells[0];
            phatSinhGrid.BeginEdit(true);
        }
    }
}
