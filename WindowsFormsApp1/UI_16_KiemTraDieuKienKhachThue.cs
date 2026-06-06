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
        }

        private void traCuuButton_Click(object sender, EventArgs e)
        {
            if (radioCaNhan.Checked)
            {
                string maKhach = maKhachTextBox.Text.Trim();
                if (maKhach == "KH001")
                {
                    soTienLabel.Text = "Số tiền: 2,000,000 VND";
                    ngayDatLabel.Text = "Ngày đặt: 01/06/2026";
                    trangThaiLabel.Text = "Trạng thái: Còn hiệu lực";
                    phongLabel.Text = "Phòng: 203 - Giường A";
                }
                else
                {
                    MessageBox.Show("Không tồn tại phiếu đặt cọc cho khách này", "Thông báo");
                }
            }
            else if (radioNhom.Checked)
            {
                string maPhieu = maPhieuTextBox.Text.Trim();
                if (maPhieu == "PDCN001")
                {
                    soTienLabel.Text = "Tổng số tiền: 6,000,000 VND";
                    ngayDatLabel.Text = "Ngày đặt: 01/06/2026";
                    trangThaiLabel.Text = "Trạng thái: Còn hiệu lực";
                    phongLabel.Text = "Phòng: 305 - Sức chứa 4 giường";

                    nhomGrid.Rows.Clear();
                    nhomGrid.Columns.Clear();
                    nhomGrid.Columns.Add("MaKhach", "Mã khách");
                    nhomGrid.Columns.Add("TenKhach", "Tên khách");
                    nhomGrid.Columns.Add("GioiTinh", "Giới tính");

                    nhomGrid.Rows.Add("KH001", "Nguyễn Văn A", "Nam");
                    nhomGrid.Rows.Add("KH002", "Trần Thị B", "Nữ");
                    nhomGrid.Rows.Add("KH003", "Lê Văn C", "Nam");
                }
                else
                {
                    MessageBox.Show("Không tồn tại phiếu đặt cọc nhóm này", "Thông báo");
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
