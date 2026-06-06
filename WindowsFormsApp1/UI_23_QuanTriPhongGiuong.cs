using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_23_QuanTriPhongGiuong : Form
    {
        private List<Phong> dsPhong;
        private List<Giuong> dsGiuong;

        public UI_23_QuanTriPhongGiuong()
        {
            InitializeComponent();
            this.Load += UI_23_QuanTriPhongGiuong_Load;
        }

        private void UI_23_QuanTriPhongGiuong_Load(object sender, EventArgs e)
        {
            LoadDuLieuMau();
            HienThiPhong(dsPhong);
            HienThiGiuong(dsGiuong);
        }

        private void LoadDuLieuMau()
        {
            dsPhong = new List<Phong>
            {
                new Phong { MaPhong="P101", ChiNhanh="Q1",  KhuVuc="Nam",      LoaiPhong="Ghép",       SucChua=4, GiaThue=2000000, TienNghi="Điều hòa, Wifi",            TrangThai="Đang ở"     },
                new Phong { MaPhong="P102", ChiNhanh="Q1",  KhuVuc="Nữ",       LoaiPhong="Ghép",       SucChua=4, GiaThue=2100000, TienNghi="Điều hòa, Wifi, Tủ lạnh",   TrangThai="Đang ở"     },
                new Phong { MaPhong="P103", ChiNhanh="Q1",  KhuVuc="Nam",      LoaiPhong="Nguyên căn", SucChua=2, GiaThue=3500000, TienNghi="Điều hòa, Wifi, WC riêng",  TrangThai="Trống"      },
                new Phong { MaPhong="P201", ChiNhanh="Q3",  KhuVuc="Hỗn hợp", LoaiPhong="Ghép",       SucChua=6, GiaThue=1800000, TienNghi="Wifi, Quạt",                 TrangThai="Đang ở"     },
                new Phong { MaPhong="P202", ChiNhanh="Q3",  KhuVuc="Nữ",       LoaiPhong="Ghép",       SucChua=4, GiaThue=2200000, TienNghi="Điều hòa, Wifi",            TrangThai="Đã đặt cọc" },
                new Phong { MaPhong="P301", ChiNhanh="Q7",  KhuVuc="Nam",      LoaiPhong="Ghép",       SucChua=4, GiaThue=1900000, TienNghi="Wifi, Tủ lạnh",             TrangThai="Bảo trì"    },
                new Phong { MaPhong="P302", ChiNhanh="Q7",  KhuVuc="Nữ",       LoaiPhong="Nguyên căn", SucChua=2, GiaThue=3200000, TienNghi="Điều hòa, Wifi, WC riêng",  TrangThai="Trống"      },
            };

            dsGiuong = new List<Giuong>
            {
                new Giuong { MaGiuong="G101A", MaPhong="P101", ViTri="Tầng dưới (cửa sổ)", TrangThai="Đang ở",     GhiChu="" },
                new Giuong { MaGiuong="G101B", MaPhong="P101", ViTri="Tầng dưới",           TrangThai="Đang ở",     GhiChu="" },
                new Giuong { MaGiuong="G101C", MaPhong="P101", ViTri="Tầng trên",            TrangThai="Trống",      GhiChu="" },
                new Giuong { MaGiuong="G101D", MaPhong="P101", ViTri="Tầng trên",            TrangThai="Đang ở",     GhiChu="" },
                new Giuong { MaGiuong="G102A", MaPhong="P102", ViTri="Tầng dưới (cửa sổ)", TrangThai="Đang ở",     GhiChu="" },
                new Giuong { MaGiuong="G102B", MaPhong="P102", ViTri="Tầng dưới",           TrangThai="Trống",      GhiChu="Mới dọn" },
                new Giuong { MaGiuong="G102C", MaPhong="P102", ViTri="Tầng trên",            TrangThai="Đang ở",     GhiChu="" },
                new Giuong { MaGiuong="G102D", MaPhong="P102", ViTri="Tầng trên",            TrangThai="Đang ở",     GhiChu="" },
                new Giuong { MaGiuong="G201A", MaPhong="P201", ViTri="Tầng dưới (cửa sổ)", TrangThai="Đang ở",     GhiChu="" },
                new Giuong { MaGiuong="G201B", MaPhong="P201", ViTri="Tầng dưới",           TrangThai="Trống",      GhiChu="" },
                new Giuong { MaGiuong="G202A", MaPhong="P202", ViTri="Tầng dưới",           TrangThai="Đã đặt cọc", GhiChu="Cọc 05/06" },
                new Giuong { MaGiuong="G202B", MaPhong="P202", ViTri="Tầng trên",            TrangThai="Đã đặt cọc", GhiChu="Cọc 05/06" },
                new Giuong { MaGiuong="G301A", MaPhong="P301", ViTri="Tầng dưới",           TrangThai="Bảo trì",    GhiChu="Hỏng khung giường" },
            };
        }

        private void HienThiPhong(List<Phong> ds)
        {
            dgvPhong.Rows.Clear();
            dgvPhong.Columns.Clear();
            dgvPhong.Columns.Add("MaPhong", "Mã phòng");
            dgvPhong.Columns.Add("ChiNhanh", "Chi nhánh");
            dgvPhong.Columns.Add("KhuVuc", "Khu vực");
            dgvPhong.Columns.Add("LoaiPhong", "Loại phòng");
            dgvPhong.Columns.Add("SucChua", "Sức chứa");
            dgvPhong.Columns.Add("GiaThue", "Giá/giường/tháng");
            dgvPhong.Columns.Add("TienNghi", "Tiện nghi");
            dgvPhong.Columns.Add("TrangThai", "Trạng thái");

            dgvPhong.Columns["MaPhong"].FillWeight = 55;
            dgvPhong.Columns["ChiNhanh"].FillWeight = 55;
            dgvPhong.Columns["KhuVuc"].FillWeight = 70;
            dgvPhong.Columns["LoaiPhong"].FillWeight = 75;
            dgvPhong.Columns["SucChua"].FillWeight = 55;
            dgvPhong.Columns["GiaThue"].FillWeight = 90;
            dgvPhong.Columns["TrangThai"].FillWeight = 80;

            foreach (var p in ds)
            {
                int idx = dgvPhong.Rows.Add(
                    p.MaPhong, p.ChiNhanh, p.KhuVuc, p.LoaiPhong,
                    p.SucChua + " giường",
                    p.GiaThue.ToString("N0") + " đ",
                    p.TienNghi, p.TrangThai);

                var row = dgvPhong.Rows[idx];
                row.DefaultCellStyle.BackColor = idx % 2 == 0 ? Color.White : Color.FromArgb(247, 249, 252);
                ApplyTrangThaiColor(row.Cells["TrangThai"], p.TrangThai);
            }
            lblPhongCount.Text = $"Tổng: {ds.Count} phòng";
        }

        private void HienThiGiuong(List<Giuong> ds)
        {
            dgvGiuong.Rows.Clear();
            dgvGiuong.Columns.Clear();
            dgvGiuong.Columns.Add("MaGiuong", "Mã giường");
            dgvGiuong.Columns.Add("MaPhong", "Phòng");
            dgvGiuong.Columns.Add("ViTri", "Vị trí");
            dgvGiuong.Columns.Add("TrangThai", "Trạng thái");
            dgvGiuong.Columns.Add("GhiChu", "Ghi chú");

            dgvGiuong.Columns["MaGiuong"].FillWeight = 70;
            dgvGiuong.Columns["MaPhong"].FillWeight = 55;
            dgvGiuong.Columns["TrangThai"].FillWeight = 90;

            foreach (var g in ds)
            {
                int idx = dgvGiuong.Rows.Add(g.MaGiuong, g.MaPhong, g.ViTri, g.TrangThai, g.GhiChu);
                var row = dgvGiuong.Rows[idx];
                row.DefaultCellStyle.BackColor = idx % 2 == 0 ? Color.White : Color.FromArgb(247, 249, 252);
                ApplyTrangThaiColor(row.Cells["TrangThai"], g.TrangThai);
            }
            lblGiuongCount.Text = $"Tổng: {ds.Count} giường";
        }

        private void ApplyTrangThaiColor(DataGridViewCell cell, string tt)
        {
            switch (tt)
            {
                case "Trống": cell.Style.ForeColor = Color.FromArgb(15, 110, 86); break;
                case "Đã đặt cọc": cell.Style.ForeColor = Color.FromArgb(30, 64, 140); break;
                case "Đang ở": cell.Style.ForeColor = Color.FromArgb(80, 80, 80); break;
                case "Bảo trì": cell.Style.ForeColor = Color.FromArgb(163, 45, 45); break;
            }
            cell.Style.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
        }

        private void btnSearchPhong_Click(object sender, EventArgs e)
        {
            string kw = txtSearchPhong.Text.Trim().ToLower();
            string kv = cboKhuVuc.SelectedItem?.ToString();
            string loai = cboLoaiPhong.SelectedItem?.ToString();
            string tt = cboTrangThaiPhong.SelectedItem?.ToString();

            var ket = dsPhong.FindAll(p =>
            {
                bool matchKw = string.IsNullOrEmpty(kw) || p.MaPhong.ToLower().Contains(kw);
                bool matchKv = kv == "Tất cả khu vực" || p.KhuVuc == kv;
                bool matchLoai = loai == "Tất cả loại" || p.LoaiPhong == loai;
                bool matchTT = tt == "Tất cả TT" || p.TrangThai == tt;
                return matchKw && matchKv && matchLoai && matchTT;
            });
            HienThiPhong(ket);
        }

        private void btnSearchGiuong_Click(object sender, EventArgs e)
        {
            string kw = txtSearchGiuong.Text.Trim().ToLower();
            string phong = cboPhongFilter.SelectedItem?.ToString();
            string tt = cboTrangThaiGiuong.SelectedItem?.ToString();

            var ket = dsGiuong.FindAll(g =>
            {
                bool matchKw = string.IsNullOrEmpty(kw) || g.MaGiuong.ToLower().Contains(kw);
                bool matchPhong = phong == "Tất cả phòng" || g.MaPhong == phong;
                bool matchTT = tt == "Tất cả TT" || g.TrangThai == tt;
                return matchKw && matchPhong && matchTT;
            });
            HienThiGiuong(ket);
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            var form = new UI_23a_ThemPhong();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dsPhong.Add(form.PhongMoi);
                HienThiPhong(dsPhong);
                MessageBox.Show($"Đã thêm phòng {form.PhongMoi.MaPhong} thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ma = dgvPhong.SelectedRows[0].Cells["MaPhong"].Value?.ToString();
            var p = dsPhong.Find(x => x.MaPhong == ma);
            if (p == null) return;

            var form = new UI_23b_SuaPhong(p);
            if (form.ShowDialog() == DialogResult.OK)
            {
                HienThiPhong(dsPhong);
                MessageBox.Show("Cập nhật phòng thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ma = dgvPhong.SelectedRows[0].Cells["MaPhong"].Value?.ToString();
            var p = dsPhong.Find(x => x.MaPhong == ma);

            if (p.TrangThai == "Đang ở" || p.TrangThai == "Đã đặt cọc")
            {
                MessageBox.Show(
                    $"Không thể xóa phòng {ma} vì đang có khách ở hoặc đã đặt cọc.\n" +
                    "Vui lòng chuyển phòng về trạng thái 'Bảo trì' hoặc 'Trống' trước.",
                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show(
                $"Xóa phòng '{ma}'? Tất cả giường trong phòng cũng sẽ bị xóa.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                dsGiuong.RemoveAll(g => g.MaPhong == ma);
                dsPhong.Remove(p);
                HienThiPhong(dsPhong);
                HienThiGiuong(dsGiuong);
                MessageBox.Show("Đã xóa phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXemGiuong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ma = dgvPhong.SelectedRows[0].Cells["MaPhong"].Value?.ToString();
            tabControl.SelectedTab = tabGiuong;
            if (cboPhongFilter.Items.Contains(ma))
                cboPhongFilter.SelectedItem = ma;
            HienThiGiuong(dsGiuong.FindAll(g => g.MaPhong == ma));
        }

        private void btnThemGiuong_Click(object sender, EventArgs e)
        {
            var form = new UI_23c_ThemGiuong(dsPhong);
            if (form.ShowDialog() == DialogResult.OK)
            {
                dsGiuong.Add(form.GiuongMoi);
                HienThiGiuong(dsGiuong);
                MessageBox.Show($"Đã thêm giường {form.GiuongMoi.MaGiuong} thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaGiuong_Click(object sender, EventArgs e)
        {
            if (dgvGiuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giường cần sửa.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ma = dgvGiuong.SelectedRows[0].Cells["MaGiuong"].Value?.ToString();
            var g = dsGiuong.Find(x => x.MaGiuong == ma);
            if (g == null) return;

            var form = new UI_23d_SuaGiuong(g);
            if (form.ShowDialog() == DialogResult.OK)
            {
                HienThiGiuong(dsGiuong);
                MessageBox.Show("Cập nhật giường thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaGiuong_Click(object sender, EventArgs e)
        {
            if (dgvGiuong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn giường cần xóa.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string ma = dgvGiuong.SelectedRows[0].Cells["MaGiuong"].Value?.ToString();
            var g = dsGiuong.Find(x => x.MaGiuong == ma);

            if (g.TrangThai == "Đang ở" || g.TrangThai == "Đã đặt cọc")
            {
                MessageBox.Show(
                    $"Không thể xóa giường {ma} vì đang có khách ở hoặc đã đặt cọc.",
                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show($"Xóa giường '{ma}'?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                dsGiuong.Remove(g);
                HienThiGiuong(dsGiuong);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}