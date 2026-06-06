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
    public partial class UI_07b_KhauTru : Form
    {
        public UI_07b_KhauTru()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += Form_Load;
            btnXacNhan.Click += BtnXacNhan_Click;
            btnDong.Click    += (s, e) => this.Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu cho HD-2503-007 Bùi Thị Ngọc (khớp với UI_12)
            txtMaHD.Text       = "HD-2503-007";
            txtTrangThai.Text  = "Đã kết thúc";
            txtThoiGian.Text   = "3 Tháng (≤ 6T)";
            txtTienCocGoc.Text = "2.100.000";
            txtQuyTac.Text     = "Lưu trú ≤ 6 tháng ➔ Hoàn 100% tiền cọc";
            txtTienDuocHoan.Text = "2.100.000";
            txtTienDuocHoan.ForeColor = System.Drawing.Color.Green;
            txtPhatSinh.Text  = "650.000";
            valTienThucNhan.Text = "1.450.000 VNĐ";
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Đã xác nhận khấu trừ khoản phát sinh!\n\n" +
                "Tiền cọc gốc:    2.100.000 VNĐ\n" +
                "Khấu trừ:          650.000 VNĐ\n" +
                "Hoàn trả khách: 1.450.000 VNĐ\n\n" +
                "Chuyển sang bước Hoàn tiền cho khách.",
                "Xác nhận thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
