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
    public partial class UI_06b_XuatYeuCauThanhToan : Form
    {
        public string  KhachHang { get; set; }
        public string  Phong     { get; set; }
        public decimal SoTien    { get; set; }

        public UI_06b_XuatYeuCauThanhToan()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load   += Form_Load;
            btnDong.Click    += (s, e) => this.Close();
            btnInPhieu.Click += BtnInPhieu_Click;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KhachHang)) valKhachHang.Text = KhachHang;
            if (!string.IsNullOrEmpty(Phong))     valPhong.Text     = Phong;
            if (SoTien > 0)
            {
                valSoTien.Text    = AppUiStyle.Money(SoTien);
                lblGhiChuTien.Text = "(" + DocSoTien(SoTien) + ")";
            }
            valHanThanhToan.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
        }

        private void BtnInPhieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phiếu yêu cầu thanh toán đã được xuất thành công!\n\nTrong hệ thống thực, phiếu sẽ được in hoặc gửi email cho khách.",
                "Xuất phiếu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string DocSoTien(decimal soTien)
        {
            if (soTien == 2_000_000) return "Hai triệu đồng chẵn";
            if (soTien == 2_100_000) return "Hai triệu một trăm nghìn đồng";
            if (soTien == 2_200_000) return "Hai triệu hai trăm nghìn đồng";
            if (soTien == 1_800_000) return "Một triệu tám trăm nghìn đồng";
            if (soTien == 3_500_000) return "Ba triệu năm trăm nghìn đồng";
            if (soTien == 7_000_000) return "Bảy triệu đồng chẵn";
            if (soTien == 4_200_000) return "Bốn triệu hai trăm nghìn đồng";
            return soTien.ToString("N0", new System.Globalization.CultureInfo("vi-VN")) + " đồng";
        }

        private void lblGhiChuTien_Click(object sender, EventArgs e) { }
    }
}
