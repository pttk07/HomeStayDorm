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
    public partial class UI_16_KiemTraDieuKienKhachThue : Form
    {
        public UI_16_KiemTraDieuKienKhachThue()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
        }

        private void traCuuButton_Click(object sender, EventArgs e)
        {
            if (radioCaNhan.Checked)
            {
                string maPhieu = maKhachTextBox.Text.Trim();
                if (maPhieu == "PC-2506-001" || maPhieu == "pc-2506-001")
                {
                    soTienLabel.Text = "Số tiền cọc: 2.200.000 VNĐ";
                    ngayDatLabel.Text = "Ngày đặt: 05/06/2026";
                    trangThaiLabel.Text = "Trạng thái: Còn hiệu lực";
                    phongLabel.Text = "Phòng: P202 - Giường G202A  |  Khách: Trần Thị Bình";
                }
                else if (maPhieu == "PC-2506-002" || maPhieu == "pc-2506-002")
                {
                    soTienLabel.Text = "Số tiền cọc: 3.500.000 VNĐ";
                    ngayDatLabel.Text = "Ngày đặt: 06/06/2026";
                    trangThaiLabel.Text = "Trạng thái: Còn hiệu lực";
                    phongLabel.Text = "Phòng: P103  |  Khách: Phạm Thị Dung";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu đặt cọc. Vui lòng nhập đúng mã phiếu (vd: PC-2506-001).", "Thông báo");
                }
            }
            else if (radioNhom.Checked)
            {
                string maPhieu = maPhieuTextBox.Text.Trim();
                if (maPhieu == "PC-2506-003" || maPhieu == "pc-2506-003")
                {
                    soTienLabel.Text = "Tổng số tiền cọc: 6.300.000 VNĐ";
                    ngayDatLabel.Text = "Ngày đặt: 04/06/2026";
                    trangThaiLabel.Text = "Trạng thái: Còn hiệu lực";
                    phongLabel.Text = "Phòng: P201 - Ghép  |  3 giường";

                    nhomGrid.Rows.Clear();
                    nhomGrid.Columns.Clear();
                    nhomGrid.Columns.Add("MaPhieu", "Mã phiếu cọc");
                    nhomGrid.Columns.Add("TenKhach", "Tên khách");
                    nhomGrid.Columns.Add("GioiTinh", "Giới tính");

                    nhomGrid.Rows.Add("PC-2506-003A", "Trần Thanh Tùng",   "Nam");
                    nhomGrid.Rows.Add("PC-2506-003B", "Nguyễn Minh Khoa",  "Nam");
                    nhomGrid.Rows.Add("PC-2506-003C", "Lê Anh Kiệt",       "Nam");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phiếu đặt cọc nhóm. Vui lòng nhập đúng mã phiếu (vd: PC-2506-003).", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại khách (cá nhân hoặc nhóm)", "Thông báo");
            }
        }

        private void xacNhanButton_Click(object sender, EventArgs e)
        {
            if (radioCaNhan.Checked)
            {
                MessageBox.Show("Thông tin phiếu đặt cọc cá nhân đã được xác nhận. Tiếp tục quy trình nhận phòng/lập hợp đồng.", "Thông báo");
            }
            else if (radioNhom.Checked)
            {
                MessageBox.Show("Thông tin phiếu đặt cọc nhóm đã được xác nhận. Tiếp tục quy trình nhận phòng/lập hợp đồng.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại khách trước khi xác nhận.", "Thông báo");
            }
        }
    }
}
