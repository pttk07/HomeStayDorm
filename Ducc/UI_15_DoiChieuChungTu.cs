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
    public partial class UI_15_DoiChieuChungTu : Form
    {
        public UI_15_DoiChieuChungTu()
        {
            InitializeComponent();

            // Gắn sự kiện cho các nút
            timKiemButton.Click += timKiemButton_Click;
            doiChieuButton.Click += doiChieuButton_Click;
            button2.Click += button2_Click;
        }

        private void UI_15_DoiChieuChungTu_Load(object sender, EventArgs e)
        {
            // TODO: load dữ liệu chứng từ ban đầu nếu cần
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string maChungTu = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(maChungTu))
            {
                MessageBox.Show("Vui lòng nhập mã chứng từ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: logic tìm kiếm chứng từ trong DB hoặc danh sách
            // Ví dụ giả lập:
            if (maChungTu == "CT001")
            {
                MessageBox.Show("Đã tìm thấy chứng từ " + maChungTu, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Giả lập load dữ liệu vào grid
                DataTable dt = new DataTable();
                dt.Columns.Add("Mã chứng từ");
                dt.Columns.Add("Nội dung");
                dt.Rows.Add("CT001", "Thanh toán tiền phòng");
                danhSachChungTuGrid.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy chứng từ nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doiChieuButton_Click(object sender, EventArgs e)
        {
            // TODO: logic đối chiếu chứng từ
            ketQuaDoiChieu.Text = "Chứng từ hợp lệ";
            MessageBox.Show("Đối chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: logic xuất báo cáo
            MessageBox.Show("Báo cáo đã được xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Không cần xử lý gì thêm
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Không cần xử lý gì thêm
        }
    }
}