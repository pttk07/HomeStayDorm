using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class UI_13_CapNhatKetQuaThanhToan : Form
    {
        private readonly string ketQuaFilePath;

        public UI_13_CapNhatKetQuaThanhToan()
        {
            InitializeComponent();
            ketQuaFilePath = Path.Combine(Application.StartupPath, "cap_nhat_ketqua_thanh_toan.xml");
        }

        private void formLoad(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            dateTimePickerNgayThanhToan.Value = DateTime.Today;
            dataGridViewChoXuLy.Rows.Clear();

            // Dữ liệu mẫu: (Mã hồ sơ, Khách hàng, Loại, Số tiền yêu cầu, Trạng thái)
            dataGridViewChoXuLy.Rows.Add("HS001", "Nguyễn Văn A", "Thanh toán", "1.500.000", "Chờ xử lý");
            dataGridViewChoXuLy.Rows.Add("HS002", "Trần Thị B", "Hoàn trả", "800.000", "Chờ xử lý");

            ClearDetailArea();
        }

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            // Thực tế: tải từ DB / API theo điều kiện. Ở đây là demo reload mẫu.
            MessageBox.Show("Đã tải danh sách hồ sơ chờ xử lý (mô phỏng).", "Tải danh sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formLoad(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string term = txtTimKiem.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dataGridViewChoXuLy.Rows)
            {
                bool visible = string.IsNullOrEmpty(term) ||
                    row.Cells["colMaHoSo"].Value.ToString().ToLower().Contains(term) ||
                    row.Cells["colKhachHang"].Value.ToString().ToLower().Contains(term);
                row.Visible = visible;
            }
        }

        private void dataGridViewChoXuLy_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewChoXuLy.SelectedRows.Count == 0)
            {
                ClearDetailArea();
                return;
            }

            var row = dataGridViewChoXuLy.SelectedRows[0];
            lblChiTietMaHoSo.Text = row.Cells["colMaHoSo"].Value?.ToString() ?? "";
            lblChiTietKhachHang.Text = row.Cells["colKhachHang"].Value?.ToString() ?? "";
            lblChiTietLoai.Text = row.Cells["colLoai"].Value?.ToString() ?? "";
            lblChiTietSoTien.Text = row.Cells["colSoTienYeuCau"].Value?.ToString() ?? "0";

            // Reset nhập liệu giao dịch
            txtSoTienGiaoDich.Text = lblChiTietSoTien.Text;
            cmbPhuongThucGiaoDich.SelectedIndex = 0;
            dateTimePickerNgayThanhToan.Value = DateTime.Today;
            txtMaGiaoDich.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtKetQuaThanhToan.SelectedIndex = 0;
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            if (dataGridViewChoXuLy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hồ sơ để cập nhật.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridViewChoXuLy.SelectedRows[0];
            string maHoSo = row.Cells["colMaHoSo"].Value?.ToString() ?? "";
            string soTienYeuCauStr = row.Cells["colSoTienYeuCau"].Value?.ToString() ?? "0";
            decimal soTienYeuCau = ParseDecimal(soTienYeuCauStr);

            decimal soTienGiaoDich = ParseDecimal(txtSoTienGiaoDich.Text.Trim());
            string phuongThuc = cmbPhuongThucGiaoDich.SelectedItem?.ToString() ?? "Tiền mặt";
            DateTime ngayThanhToan = dateTimePickerNgayThanhToan.Value.Date;
            string maGiaoDich = txtMaGiaoDich.Text.Trim();
            string ketQua = txtKetQuaThanhToan.SelectedItem?.ToString() ?? "Thanh toán thành công";
            string ghiChu = txtGhiChu.Text.Trim();

            // Kiểm tra tính hợp lệ cơ bản
            if (soTienGiaoDich < 0)
            {
                MessageBox.Show("Số tiền giao dịch không hợp lệ.", "Kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phuongThuc == "Chuyển khoản" && string.IsNullOrWhiteSpace(maGiaoDich))
            {
                MessageBox.Show("Vui lòng nhập mã giao dịch khi chọn Chuyển khoản.", "Kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ngayThanhToan > DateTime.Today)
            {
                MessageBox.Show("Ngày thanh toán không được lớn hơn ngày hiện tại.", "Kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // So sánh số tiền thực tế với yêu cầu
            string trangThaiCapNhat;
            if (soTienGiaoDich == soTienYeuCau)
            {
                trangThaiCapNhat = "Thanh toán hợp lệ";
            }
            else
            {
                decimal chenLech = soTienGiaoDich - soTienYeuCau;
                trangThaiCapNhat = $"Chênh lệch ({(chenLech >= 0 ? "+" : "")}{chenLech.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))} đ)";
            }

            // Lưu kết quả (mô phỏng) vào file XML
            try
            {
                SaveKetQua(maHoSo, soTienYeuCau, soTienGiaoDich, phuongThuc, ngayThanhToan, maGiaoDich, ketQua, ghiChu, trangThaiCapNhat);
                // Cập nhật trạng thái trên grid
                row.Cells["colTrangThai"].Value = trangThaiCapNhat;
                MessageBox.Show("Cập nhật kết quả thanh toán thành công.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu kết quả thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Mô phỏng cập nhật vào hồ sơ (thực tế sẽ cập nhật DB)
            MessageBox.Show("Kết quả đã cập nhật vào hồ sơ thanh toán (mô phỏng).", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void SaveKetQua(string maHoSo, decimal soTienYeuCau, decimal soTienGiaoDich, string phuongThuc, DateTime ngayThanhToan,
            string maGiaoDich, string ketQua, string ghiChu, string trangThaiCapNhat)
        {
            XElement root;
            if (File.Exists(ketQuaFilePath))
            {
                root = XElement.Load(ketQuaFilePath);
            }
            else
            {
                root = new XElement("CapNhatKetQuaThanhToan");
            }

            var item = new XElement("HoSo",
                new XElement("MaHoSo", maHoSo),
                new XElement("NgayThucHien", DateTime.Now.ToString("s")),
                new XElement("SoTienYeuCau", soTienYeuCau.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))),
                new XElement("SoTienGiaoDich", soTienGiaoDich.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))),
                new XElement("PhuongThuc", phuongThuc),
                new XElement("NgayThanhToan", ngayThanhToan.ToString("yyyy-MM-dd")),
                new XElement("MaGiaoDich", maGiaoDich),
                new XElement("KetQua", ketQua),
                new XElement("GhiChu", ghiChu),
                new XElement("TrangThaiCapNhat", trangThaiCapNhat)
            );

            root.Add(item);
            root.Save(ketQuaFilePath);
        }

        private void ClearDetailArea()
        {
            lblChiTietMaHoSo.Text = string.Empty;
            lblChiTietKhachHang.Text = string.Empty;
            lblChiTietLoai.Text = string.Empty;
            lblChiTietSoTien.Text = "0";
            txtSoTienGiaoDich.Text = string.Empty;
            cmbPhuongThucGiaoDich.SelectedIndex = 0;
            dateTimePickerNgayThanhToan.Value = DateTime.Today;
            txtMaGiaoDich.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtKetQuaThanhToan.SelectedIndex = 0;
        }
    }
}