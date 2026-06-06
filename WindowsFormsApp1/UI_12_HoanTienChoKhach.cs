using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class UI_12_HoanTienChoKhach : Form
    {
        private readonly string refundFilePath;

        public UI_12_HoanTienChoKhach()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            refundFilePath = Path.Combine(Application.StartupPath, "hoan_tien_giao_dich.xml");
        }

        private void formLoad(object sender, EventArgs e)
        {
            txtSearchCustomer.Text = string.Empty;
            dataGridViewDoiSoat.Rows.Clear();
            lblSoTienCoc.Text = "Số tiền cọc: 0 VNĐ";
            lblTongKhauTru.Text = "Tổng khấu trừ: 0 VNĐ";
            txtSoTienHoan.Text = string.Empty;
            cmbPhuongThuc.SelectedIndex = 0;
            lblStatus.Text = string.Empty;

            dataGridViewDoiSoat.Rows.Add("HD-2503-007", "Bùi Thị Ngọc",   "2.100.000", "650.000", "1.450.000", "Chưa hoàn");
            dataGridViewDoiSoat.Rows.Add("HD-2502-008", "Ngô Quốc Phong", "1.800.000", "0",       "1.800.000", "Đã hoàn");
            dataGridViewDoiSoat.Rows.Add("HD-2411-009", "Phan Thị Xuân",  "2.000.000", "500.000", "1.500.000", "Chờ xử lý");
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string term = txtSearchCustomer.Text.Trim().ToLower();
            // Demo: lọc rows client-side
            foreach (DataGridViewRow row in dataGridViewDoiSoat.Rows)
            {
                bool visible = string.IsNullOrEmpty(term) || row.Cells["colKhachHang"].Value.ToString().ToLower().Contains(term);
                row.Visible = visible;
            }

            MessageBox.Show("Đã tra cứu bảng đối soát theo khách hàng.", "Tra cứu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewDoiSoat_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDoiSoat.SelectedRows.Count == 0)
                return;

            var row = dataGridViewDoiSoat.SelectedRows[0];
            decimal soTienCoc = ParseDecimal(row.Cells["colSoTienCoc"].Value?.ToString());
            decimal tongKhauTru = ParseDecimal(row.Cells["colKhauTru"].Value?.ToString());
            decimal soTienConLai = soTienCoc - tongKhauTru;

            lblSoTienCoc.Text = "Số tiền cọc: " + soTienCoc.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
            lblTongKhauTru.Text = "Tổng khấu trừ: " + tongKhauTru.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
            txtSoTienHoan.Text = soTienConLai > 0 ? soTienConLai.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) : "0";
            lblStatus.Text = row.Cells["colTrangThaiDoiSoat"].Value?.ToString() ?? string.Empty;
        }

        private void btnHoanTien_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoiSoat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng đối soát trước khi hoàn tiền.", "Hoàn tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewDoiSoat.SelectedRows[0];
            string maHopDong = row.Cells["colMaDon"].Value?.ToString() ?? "";
            decimal soTienCoc = ParseDecimal(row.Cells["colSoTienCoc"].Value?.ToString());
            decimal tongKhauTru = ParseDecimal(row.Cells["colKhauTru"].Value?.ToString());

            // Chuẩn hoá input số tiền hoàn
            decimal soTienHoan = ParseDecimal(txtSoTienHoan.Text.Trim());
            if (soTienHoan < 0)
            {
                MessageBox.Show("Số tiền hoàn không hợp lệ.", "Hoàn tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soTienHoan > soTienCoc - tongKhauTru)
            {
                var confirm = MessageBox.Show("Số tiền hoàn lớn hơn số tiền còn lại sau khấu trừ. Bạn có muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;
            }

            string phuongThuc = cmbPhuongThuc.SelectedItem?.ToString() ?? "Tiền mặt";
            string chungTu = txtChungTu.Text.Trim();

            // Nếu chuyển khoản, yêu cầu chứng từ (số giao dịch)
            if (phuongThuc == "Chuyển khoản" && string.IsNullOrWhiteSpace(chungTu))
            {
                MessageBox.Show("Vui lòng nhập chứng từ giao dịch (số tham chiếu) khi phương thức là Chuyển khoản.", "Hoàn tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate định dạng chứng từ đơn giản (nếu có): chữ/ số / dấu gạch ngang
            if (!string.IsNullOrWhiteSpace(chungTu) && !Regex.IsMatch(chungTu, @"^[A-Za-z0-9\-\/_]+$"))
            {
                MessageBox.Show("Số/chứng từ giao dịch không đúng định dạng.", "Hoàn tiền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện "hoàn tiền" (mô phỏng): cập nhật trạng thái và lưu giao dịch
            try
            {
                row.Cells["colTrangThaiDoiSoat"].Value = "Đã hoàn tiền";
                SaveGiaoDichHoanTien(maHopDong, soTienHoan, phuongThuc, chungTu);
                lblStatus.Text = "Đã hoàn tiền";
                MessageBox.Show("Hoàn tiền thành công và đã lưu giao dịch.", "Hoàn tiền", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu giao dịch thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Cập nhật kết quả hoàn tiền vào hệ thống (mô phỏng). Thực tế: gọi API hoặc cập nhật DB.
            MessageBox.Show("Kết quả hoàn tiền đã được cập nhật vào hồ sơ hợp đồng (mô phỏng).", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Helpers

        private decimal ParseDecimal(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0m;
            string cleaned = s.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();
            if (decimal.TryParse(cleaned, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal r))
                return r;
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.GetCultureInfo("vi-VN"), out r))
                return r;
            return 0m;
        }

        private void SaveGiaoDichHoanTien(string maHopDong, decimal soTienHoan, string phuongThuc, string chungTu)
        {
            XElement root;
            if (File.Exists(refundFilePath))
            {
                root = XElement.Load(refundFilePath);
            }
            else
            {
                root = new XElement("GiaoDichHoanTien");
            }

            var item = new XElement("GiaoDich",
                new XElement("MaHopDong", maHopDong),
                new XElement("NgayThucHien", DateTime.Now.ToString("s")),
                new XElement("SoTienHoan", soTienHoan.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))),
                new XElement("PhuongThuc", phuongThuc),
                new XElement("ChungTu", chungTu)
            );

            root.Add(item);
            root.Save(refundFilePath);
        }
    }
}