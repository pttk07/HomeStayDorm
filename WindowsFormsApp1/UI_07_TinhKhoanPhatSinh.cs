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
    public partial class UI_8_Tính_khoản_phát_sinh : Form
    {
        public UI_8_Tính_khoản_phát_sinh()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += Form_Load;
            btnThemKhoan.Click += BtnThemKhoan_Click;
            btnTraCuuHD.Click  += BtnTraCuuHD_Click;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Pre-fill với HD-2503-007 Bùi Thị Ngọc (hợp đồng đã kết thúc)
            txtMaHD.Text       = "HD-2503-007";
            txtKhachHang.Text  = "Bùi Thị Ngọc";
            txtTienCoc.Text    = "2.100.000 VNĐ";
            txtNgayTra.Text    = "31/05/2026";

            // Thêm khoản phát sinh mẫu
            dgvPhatSinh.Rows.Add("Phí vệ sinh", "150.000", "Vệ sinh phòng sau khi trả", "Nhân viên ghi nhận");
            dgvPhatSinh.Rows.Add("Sửa chữa tài sản", "500.000", "Hư hỏng TV – trầy xước bàn", "Biên bản kiểm tra");
            CapNhatTongTien();
        }

        private void BtnTraCuuHD_Click(object sender, EventArgs e)
        {
            using (var lookup = new UI_08_TraCuuHopDong())
            {
                if (lookup.ShowDialog(this) != DialogResult.OK) return;
                txtMaHD.Text      = lookup.SelectedMaHD;
                txtKhachHang.Text = lookup.SelectedKhachHang;
                txtNgayTra.Text   = lookup.SelectedNgayKetThuc;
                // Tính cọc = 1 tháng tiền thuê từ MucGia
                string mucGiaStr = lookup.SelectedMucGia ?? "";
                txtTienCoc.Text  = string.IsNullOrEmpty(mucGiaStr) ? "" : mucGiaStr.Replace("/tháng", "");
                dgvPhatSinh.Rows.Clear();
                CapNhatTongTien();
            }
        }

        private void BtnThemKhoan_Click(object sender, EventArgs e)
        {
            string loai = cboLoaiPhatSinh.Text;
            string ghiChu = txtGhiChu.Text.Trim();

            if (!decimal.TryParse(txtSoTienNhap.Text.Trim().Replace(".", ""), out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.", "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvPhatSinh.Rows.Add(loai, AppUiStyle.Money(soTien).Replace(" VNĐ", ""), ghiChu, "Nhân viên thêm thủ công");
            txtSoTienNhap.Clear();
            txtGhiChu.Clear();
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvPhatSinh.Rows)
            {
                string val = row.Cells["colSoTien"].Value?.ToString() ?? "";
                val = val.Replace(".", "").Replace(",", "").Replace(" VNĐ", "").Trim();
                if (decimal.TryParse(val, out decimal n)) tong += n;
            }
            valTongTien.Text = AppUiStyle.Money(tong);
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e) { }
        private void txtNgayTra_TextChanged(object sender, EventArgs e) { }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (var form = new UI_07b_KhauTru())
                form.ShowDialog(this);
        }
    }
}
