
using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class UI_11_TinhKhoanCanThanhToan : Form
    {
        private readonly string ketQuaFilePath;

        public UI_11_TinhKhoanCanThanhToan()
        {
            InitializeComponent();
            ketQuaFilePath = Path.Combine(Application.StartupPath, "doi_chieu_ketqua.xml");
        }

        private void formLoad(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-30);
            dateTimePickerTo.Value = DateTime.Today;
            dataGridViewTinhKhoan.Rows.Clear();

            // Hàng mẫu minh họa (cột: Mã hợp đồng, Ngày, Số tiền yêu cầu, Số tiền thực tế, Phương thức, Chứng từ số, Chứng từ ngày, Trạng thái)
            dataGridViewTinhKhoan.Rows.Add("HD100", DateTime.Today.AddDays(-10).ToString("yyyy-MM-dd"), "1.500.000", "", "Tiền mặt", "BL-20260601-001", DateTime.Today.AddDays(-9).ToString("yyyy-MM-dd"), "");
            dataGridViewTinhKhoan.Rows.Add("HD101", DateTime.Today.AddDays(-5).ToString("yyyy-MM-dd"), "750.000", "", "Chuyển khoản", "", "", "");

            lblTongTien.Text = "Tổng hợp đồng: 2 mục";
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            // Thực tế: gọi DB hoặc API theo khoảng ngày
            MessageBox.Show("Tải dữ liệu theo khoảng ngày đã chọn.", "Tải dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridViewTinhKhoan.Rows.Clear();
            dataGridViewTinhKhoan.Rows.Add("HD200", dateTimePickerFrom.Value.ToString("yyyy-MM-dd"), "2.000.000", "", "Chuyển khoản", "", "", "");
            dataGridViewTinhKhoan.Rows.Add("HD201", dateTimePickerTo.Value.ToString("yyyy-MM-dd"), "1.200.000", "", "Tiền mặt", "", "", "");
            dataGridViewTinhKhoan.Rows.Add("HD202", DateTime.Today.ToString("yyyy-MM-dd"), "500.000", "", "Chuyển khoản", "", "", "");
            lblTongTien.Text = $"Tổng hợp đồng: {dataGridViewTinhKhoan.Rows.Count} mục";
        }

        private void btnDoiChieu_Click(object sender, EventArgs e)
        {
            if (dataGridViewTinhKhoan.Rows.Count == 0)
            {
                MessageBox.Show("Không có hợp đồng để đối chiếu.", "Đối chiếu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int validCount = 0;
            int discrepCount = 0;
            int invalidDocCount = 0;

            foreach (DataGridViewRow row in dataGridViewTinhKhoan.Rows)
            {
                try
                {
                    string maHopDong = row.Cells["colMaDon"].Value?.ToString() ?? "";
                    string soTienYeuCauStr = row.Cells["colSoTienYeuCau"].Value?.ToString() ?? "0";
                    string soTienThucTeStr = row.Cells["colSoTienThucTe"].Value?.ToString() ?? "";
                    string phuongThuc = row.Cells["colPhuongThuc"].Value?.ToString() ?? "";
                    string chungTuSo = row.Cells["colChungTuSo"].Value?.ToString() ?? "";
                    string chungTuNgayStr = row.Cells["colChungTuNgay"].Value?.ToString() ?? "";

                    decimal soTienYeuCau = ParseDecimal(soTienYeuCauStr);
                    decimal soTienThucTe = string.IsNullOrWhiteSpace(soTienThucTeStr) ? 0m : ParseDecimal(soTienThucTeStr);

                    // Kiểm tra chứng từ: bắt buộc có số chứng từ và ngày chứng từ hợp lệ
                    string loiChungTu = ValidateChungTu(chungTuSo, chungTuNgayStr);
                    if (!string.IsNullOrEmpty(loiChungTu))
                    {
                        row.Cells["colTrangThai"].Value = $"Chứng từ không hợp lệ: {loiChungTu}";
                        invalidDocCount++;
                        continue;
                    }

                    // So sánh số tiền
                    if (soTienThucTe == soTienYeuCau)
                    {
                        row.Cells["colTrangThai"].Value = "Thanh toán hợp lệ";
                        validCount++;
                    }
                    else
                    {
                        decimal chenLech = soTienThucTe - soTienYeuCau;
                        string sign = chenLech > 0 ? "+" : "";
                        row.Cells["colTrangThai"].Value = $"Chênh lệch ({sign}{chenLech.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"))} đ)";
                        discrepCount++;
                    }

                    // Chuẩn hoá hiển thị số tiền thực tế và yêu cầu theo định dạng VN
                    row.Cells["colSoTienYeuCau"].Value = soTienYeuCau.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                    row.Cells["colSoTienThucTe"].Value = soTienThucTe == 0m ? "" : soTienThucTe.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                }
                catch (Exception ex)
                {
                    row.Cells["colTrangThai"].Value = $"Lỗi xử lý: {ex.Message}";
                }
            }

            // Lưu kết quả đối chiếu (mô phỏng) vào file XML trong thư mục ứng dụng
            try
            {
                SaveKetQuaDoiChieu();
                MessageBox.Show($"Đã thực hiện đối chiếu.\nHợp lệ: {validCount}, Chênh lệch: {discrepCount}, Chứng từ không hợp lệ: {invalidDocCount}.\nKết quả đã lưu tại:\n{ketQuaFilePath}", "Đối chiếu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đối chiếu xong nhưng không lưu được kết quả: {ex.Message}", "Lưu kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string term = txtTimKiem.Text.Trim().ToLower();
            foreach (DataGridViewRow row in dataGridViewTinhKhoan.Rows)
            {
                bool visible = string.IsNullOrEmpty(term) || row.Cells["colMaDon"].Value.ToString().ToLower().Contains(term);
                row.Visible = visible;
            }
        }

        // Helpers

        private decimal ParseDecimal(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0m;
            // Loại bỏ dấu phân nhóm và ký tự không số
            string cleaned = s.Replace(".", "").Replace(",", "").Replace("đ", "").Replace(" ", "").Trim();
            if (decimal.TryParse(cleaned, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal result))
                return result;
            // Nếu dùng định dạng VN (dấu phẩy là thập phân) thử parse với vi-VN
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.GetCultureInfo("vi-VN"), out result))
                return result;
            return 0m;
        }

        private string ValidateChungTu(string chungTuSo, string chungTuNgayStr)
        {
            // Yêu cầu: có số chứng từ theo định dạng BL-YYYYMMDD-xxx hoặc HD-YYYYMMDD-xxx
            if (string.IsNullOrWhiteSpace(chungTuSo))
                return "Thiếu số chứng từ";

            var match = Regex.Match(chungTuSo.Trim(), @"^(BL|HD)-(?<date>\d{8})-\d+$", RegexOptions.IgnoreCase);
            if (!match.Success)
                return "Số chứng từ sai định dạng (vd: BL-20260601-001 hoặc HD-20260601-001)";

            string datePart = match.Groups["date"].Value;
            if (!DateTime.TryParseExact(datePart, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                return "Ngày trong số chứng từ không hợp lệ";

            // Nếu có trường ngày chứng từ tách riêng, kiểm tra tương thích và không vượt quá ngày hiện tại
            if (!string.IsNullOrWhiteSpace(chungTuNgayStr))
            {
                if (!DateTime.TryParse(chungTuNgayStr, out DateTime chungTuNgay))
                    return "Ngày chứng từ sai định dạng";
                if (chungTuNgay.Date > DateTime.Today)
                    return "Ngày chứng từ không thể ở tương lai";
                // so sánh ngày trong số chứng từ với ngày chứng từ nếu cần: yêu cầu khớp ngày
                if (parsedDate.Date != chungTuNgay.Date)
                    return "Ngày trong số chứng từ không khớp với ngày chứng từ";
            }
            else
            {
                // nếu không có ngày riêng, chỉ kiểm tra ngày trong số chứng từ không ở tương lai
                if (parsedDate.Date > DateTime.Today)
                    return "Ngày trong số chứng từ không thể ở tương lai";
            }

            return string.Empty; // hợp lệ
        }

        private void SaveKetQuaDoiChieu()
        {
            var root = new XElement("DoiChieuKetQua",
                new XAttribute("ngayThucHien", DateTime.Now.ToString("s")));

            foreach (DataGridViewRow row in dataGridViewTinhKhoan.Rows)
            {
                var item = new XElement("HopDong",
                    new XElement("MaHopDong", row.Cells["colMaDon"].Value?.ToString() ?? ""),
                    new XElement("Ngay", row.Cells["colNgay"].Value?.ToString() ?? ""),
                    new XElement("SoTienYeuCau", row.Cells["colSoTienYeuCau"].Value?.ToString() ?? ""),
                    new XElement("SoTienThucTe", row.Cells["colSoTienThucTe"].Value?.ToString() ?? ""),
                    new XElement("PhuongThuc", row.Cells["colPhuongThuc"].Value?.ToString() ?? ""),
                    new XElement("ChungTuSo", row.Cells["colChungTuSo"].Value?.ToString() ?? ""),
                    new XElement("ChungTuNgay", row.Cells["colChungTuNgay"].Value?.ToString() ?? ""),
                    new XElement("TrangThai", row.Cells["colTrangThai"].Value?.ToString() ?? "")
                );
                root.Add(item);
            }

            root.Save(ketQuaFilePath);
        }
    }
}