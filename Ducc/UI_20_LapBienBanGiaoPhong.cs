using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ducc
{
    public partial class UI_20_LapBienBanGiaoPhong : Form
    {
        public UI_20_LapBienBanGiaoPhong()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Tên tài sản
            DataGridViewTextBoxColumn tenTaiSanColumn = new DataGridViewTextBoxColumn();
            tenTaiSanColumn.HeaderText = "Tên tài sản";
            tenTaiSanColumn.Name = "TenTaiSan";

            // Số lượng
            DataGridViewTextBoxColumn soLuongColumn = new DataGridViewTextBoxColumn();
            soLuongColumn.HeaderText = "Số lượng";
            soLuongColumn.Name = "SoLuong";

            // Tình trạng (ComboBox)
            DataGridViewComboBoxColumn tinhTrangColumn = new DataGridViewComboBoxColumn();
            tinhTrangColumn.HeaderText = "Tình trạng";
            tinhTrangColumn.Name = "TinhTrang";
            tinhTrangColumn.Items.AddRange("Đầy đủ", "Hư hỏng", "Thiếu");

            // Đánh dấu bàn giao (CheckBox)
            DataGridViewCheckBoxColumn daDanhDauColumn = new DataGridViewCheckBoxColumn();
            daDanhDauColumn.HeaderText = "Bàn giao";
            daDanhDauColumn.Name = "DaDanhDau";

            // Ghi chú
            DataGridViewTextBoxColumn ghiChuColumn = new DataGridViewTextBoxColumn();
            ghiChuColumn.HeaderText = "Ghi chú";
            ghiChuColumn.Name = "GhiChu";

            // Thêm các cột vào DataGridView
            danhSachTaiSanGrid.Columns.AddRange(
                tenTaiSanColumn,
                soLuongColumn,
                tinhTrangColumn,
                daDanhDauColumn,
                ghiChuColumn
            );

            // Ví dụ thêm dữ liệu mẫu
            danhSachTaiSanGrid.Rows.Add("Tivi", 1, "Đầy đủ", false, "");
            danhSachTaiSanGrid.Rows.Add("Bàn", 1, "Hư hỏng", false, "Trầy xước mặt bàn");
            danhSachTaiSanGrid.Rows.Add("Ghế", 4, "Thiếu", false, "Thiếu 1 ghế");
            danhSachTaiSanGrid.Rows.Add("Quạt", 1, "Đầy đủ", false, "");
        }
    }
}
