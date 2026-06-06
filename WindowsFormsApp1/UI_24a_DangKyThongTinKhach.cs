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
    public partial class UI_24a_DangKyThongTinKhach : Form
    {
        public UI_24a_DangKyThongTinKhach()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // Dữ liệu mẫu cho ComboBox khu vực
            cboKhuVuc.Items.AddRange(new string[] {
                "Quận 1", "Quận 3", "Quận 5", "Quận 7",
                "Quận Bình Thạnh", "Quận Gò Vấp", "Thủ Đức"
            });
            cboKhuVuc.SelectedIndex = 0;

            // Dữ liệu mẫu loại phòng
            cboLoaiPhong.Items.AddRange(new string[] {
                "Phòng đơn (1 người)", "Phòng đôi (2 người)",
                "Phòng 4 người", "Phòng 6 người", "Phòng 8 người"
            });
            cboLoaiPhong.SelectedIndex = 1;

            // Dữ liệu mẫu mức giá
            cboMucGia.Items.AddRange(new string[] {
                "Dưới 1 triệu", "1 - 2 triệu", "2 - 3 triệu",
                "3 - 4 triệu", "Trên 4 triệu"
            });
            cboMucGia.SelectedIndex = 1;

            // Ngày dự kiến vào ở mặc định
            dtpNgayVaoO.Value = DateTime.Now.AddDays(7);

            // Thời hạn thuê
            cboThoiHanThue.Items.AddRange(new string[] {
                "1 tháng", "3 tháng", "6 tháng", "12 tháng", "Khác"
            });
            cboThoiHanThue.SelectedIndex = 2;

            // Ví dụ dữ liệu mẫu điền sẵn
            txtHoTen.Text = "Trần Văn Toàn";
            txtSoDienThoai.Text = "0987654321";
            txtEmail.Text = "tranvantoan@email.com";
            radNam.Checked = true;
            txtSoNguoi.Text = "1";
            txtGhiChu.Text = "Cần phòng gần trung tâm, ưu tiên có điều hòa, gửi xe máy.";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Placeholder: Xử lý lưu thông tin đăng ký
            MessageBox.Show("Đăng ký thông tin thành công!\nNhân viên sẽ liên hệ để sắp xếp lịch xem phòng.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            // Placeholder: Xóa trắng form
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtSoNguoi.Clear();
            txtGhiChu.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            cboKhuVuc.SelectedIndex = -1;
            cboLoaiPhong.SelectedIndex = -1;
            cboMucGia.SelectedIndex = -1;
            cboThoiHanThue.SelectedIndex = -1;
            chkDieuHoa.Checked = false;
            chkGuiXe.Checked = false;
            chkYenTinh.Checked = false;
            chkWifi.Checked = false;
        }
    }
}