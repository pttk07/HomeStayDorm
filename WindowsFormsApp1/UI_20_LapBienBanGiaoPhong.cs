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
    public partial class UI_20_LapBienBanGiaoPhong : Form
    {
        public UI_20_LapBienBanGiaoPhong()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
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
            thongTinBienBan.Columns.AddRange(
                tenTaiSanColumn,
                soLuongColumn,
                tinhTrangColumn,
                daDanhDauColumn,
                ghiChuColumn
            );

            thongTinBienBan.Rows.Add("Tivi LED 32\"",      1, "Đầy đủ",   false, "");
            thongTinBienBan.Rows.Add("Bàn làm việc",      1, "Hư hỏng",  false, "Trầy xước mặt bàn");
            thongTinBienBan.Rows.Add("Ghế văn phòng",     4, "Thiếu",    false, "Thiếu 1 ghế");
            thongTinBienBan.Rows.Add("Quạt trần",         1, "Đầy đủ",   false, "");
            thongTinBienBan.Rows.Add("Tủ quần áo",        1, "Đầy đủ",   false, "");
            thongTinBienBan.Rows.Add("Điều hòa Daikin",   1, "Đầy đủ",   false, "");
        }
    }
}
