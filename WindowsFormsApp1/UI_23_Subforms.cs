using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // ══════════════════════════════════════════════════════════════════════════
    // UI_23a — Thêm phòng mới
    // ══════════════════════════════════════════════════════════════════════════
    public class UI_23a_ThemPhong : Form
    {
        public Phong PhongMoi { get; private set; }

        private TextBox txtMaPhong, txtChiNhanh, txtSucChua, txtGiaThue, txtTienNghi;
        private ComboBox cboKhuVuc, cboLoaiPhong, cboTrangThai;
        private Button btnLuu, btnHuy;

        public UI_23a_ThemPhong()
        {
            this.Text = "Thêm phòng mới";
            this.ClientSize = new Size(460, 430);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9f);
            this.BackColor = Color.White;

            var hdr = MakeHeader("Thêm phòng mới", Color.FromArgb(15, 110, 86));
            this.Controls.Add(hdr);

            int lx = 20, rx = 160, w = 270, y = 56, gap = 42;

            AddRow("Mã phòng *", lx, rx, y, w, out txtMaPhong);
            AddRow("Chi nhánh *", lx, rx, y + gap, w, out txtChiNhanh);

            AddLabel("Khu vực *", lx, y + gap * 2 + 4);
            cboKhuVuc = MakeCombo(rx, y + gap * 2, w, new[] { "Nam", "Nữ", "Hỗn hợp" });
            this.Controls.Add(cboKhuVuc);

            AddLabel("Loại phòng *", lx, y + gap * 3 + 4);
            cboLoaiPhong = MakeCombo(rx, y + gap * 3, w, new[] { "Nguyên căn", "Ghép" });
            this.Controls.Add(cboLoaiPhong);

            AddRow("Sức chứa (giường) *", lx, rx, y + gap * 4, w, out txtSucChua);
            AddRow("Giá thuê/giường/tháng *", lx, rx, y + gap * 5, w, out txtGiaThue);
            //txtGiaThue.PlaceholderText = "VD: 2000000";
            AddRow("Tiện nghi", lx, rx, y + gap * 6, w, out txtTienNghi);
            //txtTienNghi.PlaceholderText = "VD: Điều hòa, Wifi";

            AddLabel("Trạng thái", lx, y + gap * 7 + 4);
            cboTrangThai = MakeCombo(rx, y + gap * 7, w, new[] { "Trống", "Bảo trì" });
            this.Controls.Add(cboTrangThai);

            btnLuu = MakeButton("Lưu", 250, 390, 90, Color.FromArgb(15, 110, 86));
            btnLuu.Click += (s, e) => Luu();
            btnHuy = MakeButton("Hủy", 354, 390, 80, Color.FromArgb(120, 120, 130));
            btnHuy.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            this.Controls.Add(btnLuu);
            this.Controls.Add(btnHuy);
            AppUiStyle.Apply(this);
        }

        private void Luu()
        {
            if (string.IsNullOrWhiteSpace(txtMaPhong.Text) ||
                string.IsNullOrWhiteSpace(txtChiNhanh.Text) ||
                string.IsNullOrWhiteSpace(txtSucChua.Text) ||
                string.IsNullOrWhiteSpace(txtGiaThue.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc (*).", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtSucChua.Text, out int sc) || sc <= 0)
            {
                MessageBox.Show("Sức chứa phải là số nguyên dương.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtGiaThue.Text, out decimal gia) || gia <= 0)
            {
                MessageBox.Show("Giá thuê không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PhongMoi = new Phong
            {
                MaPhong = txtMaPhong.Text.Trim().ToUpper(),
                ChiNhanh = txtChiNhanh.Text.Trim(),
                KhuVuc = cboKhuVuc.SelectedItem.ToString(),
                LoaiPhong = cboLoaiPhong.SelectedItem.ToString(),
                SucChua = sc,
                GiaThue = gia,
                TienNghi = txtTienNghi.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem.ToString()
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        // helpers
        private void AddRow(string label, int lx, int rx, int y, int w, out TextBox txt)
        {
            AddLabel(label, lx, y + 4);
            txt = new TextBox { Location = new Point(rx, y), Size = new Size(w, 26) };
            this.Controls.Add(txt);
        }
        private void AddLabel(string t, int x, int y) =>
            this.Controls.Add(new Label { Text = t, Location = new Point(x, y), Size = new Size(138, 20), ForeColor = Color.FromArgb(60, 70, 90) });
        private Panel MakeHeader(string title, Color bg)
        {
            var p = new Panel { BackColor = bg, Dock = DockStyle.Top, Height = 46 };
            p.Controls.Add(new Label
            {
                Text = title,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(16, 12),
                Size = new Size(380, 24)
            });
            return p;
        }
        private ComboBox MakeCombo(int x, int y, int w, string[] items)
        {
            var c = new ComboBox
            {
                Location = new Point(x, y),
                Size = new Size(w, 26),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            c.Items.AddRange(items); c.SelectedIndex = 0;
            return c;
        }
        private Button MakeButton(string text, int x, int y, int w, Color bg)
        {
            var b = new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(w, 30),
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }
    }

    // ══════════════════════════════════════════════════════════════════════════
    // UI_23b — Sửa phòng
    // ══════════════════════════════════════════════════════════════════════════
    public class UI_23b_SuaPhong : Form
    {
        private readonly Phong _p;
        private TextBox txtSucChua, txtGiaThue, txtTienNghi;
        private ComboBox cboKhuVuc, cboLoaiPhong, cboTrangThai;
        private Button btnLuu, btnHuy;

        public UI_23b_SuaPhong(Phong p)
        {
            _p = p;
            this.Text = $"Sửa phòng — {p.MaPhong}";
            this.ClientSize = new Size(460, 370);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9f);
            this.BackColor = Color.White;

            var hdr = new Panel { BackColor = Color.FromArgb(133, 79, 11), Dock = DockStyle.Top, Height = 46 };
            hdr.Controls.Add(new Label
            {
                Text = $"Sửa phòng — {p.MaPhong}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(16, 12),
                Size = new Size(380, 24)
            });
            this.Controls.Add(hdr);

            // Readonly info
            this.Controls.Add(new Label
            {
                Text = $"Chi nhánh: {p.ChiNhanh}  |  Mã phòng: {p.MaPhong}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.FromArgb(120, 120, 140),
                Location = new Point(20, 56),
                Size = new Size(420, 20)
            });

            int lx = 20, rx = 160, w = 270, y = 84, gap = 42;

            Add(new Label { Text = "Khu vực *", Location = new Point(lx, y + 4), Size = new Size(138, 20), ForeColor = Color.FromArgb(60, 70, 90) });
            cboKhuVuc = Combo(rx, y, w, new[] { "Nam", "Nữ", "Hỗn hợp" }, p.KhuVuc);

            Add(new Label { Text = "Loại phòng *", Location = new Point(lx, y + gap + 4), Size = new Size(138, 20), ForeColor = Color.FromArgb(60, 70, 90) });
            cboLoaiPhong = Combo(rx, y + gap, w, new[] { "Nguyên căn", "Ghép" }, p.LoaiPhong);

            Add(new Label { Text = "Sức chứa *", Location = new Point(lx, y + gap * 2 + 4), Size = new Size(138, 20), ForeColor = Color.FromArgb(60, 70, 90) });
            txtSucChua = TB(rx, y + gap * 2, w, p.SucChua.ToString());

            Add(new Label { Text = "Giá thuê *", Location = new Point(lx, y + gap * 3 + 4), Size = new Size(138, 20), ForeColor = Color.FromArgb(60, 70, 90) });
            txtGiaThue = TB(rx, y + gap * 3, w, p.GiaThue.ToString());

            Add(new Label { Text = "Tiện nghi", Location = new Point(lx, y + gap * 4 + 4), Size = new Size(138, 20), ForeColor = Color.FromArgb(60, 70, 90) });
            txtTienNghi = TB(rx, y + gap * 4, w, p.TienNghi);

            Add(new Label { Text = "Trạng thái", Location = new Point(lx, y + gap * 5 + 4), Size = new Size(138, 20), ForeColor = Color.FromArgb(60, 70, 90) });
            cboTrangThai = Combo(rx, y + gap * 5, w, new[] { "Trống", "Đã đặt cọc", "Đang ở", "Bảo trì" }, p.TrangThai);

            btnLuu = Btn("Lưu", 254, 332, 90, Color.FromArgb(133, 79, 11));
            btnLuu.Click += (s, e) => Luu();
            btnHuy = Btn("Hủy", 358, 332, 80, Color.FromArgb(120, 120, 130));
            btnHuy.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            Add(btnLuu); Add(btnHuy);
            AppUiStyle.Apply(this);
        }

        private void Luu()
        {
            if (!int.TryParse(txtSucChua.Text, out int sc) || sc <= 0 ||
                !decimal.TryParse(txtGiaThue.Text, out decimal gia) || gia <= 0)
            {
                MessageBox.Show("Sức chứa và giá thuê phải là số hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((cboTrangThai.SelectedItem.ToString() == "Bảo trì" || cboTrangThai.SelectedItem.ToString() == "Trống")
                && (_p.TrangThai == "Đang ở" || _p.TrangThai == "Đã đặt cọc"))
            {
                var warn = MessageBox.Show(
                    "Phòng đang có khách/đặt cọc. Bạn vẫn muốn thay đổi trạng thái?",
                    "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warn != DialogResult.Yes) return;
            }
            _p.KhuVuc = cboKhuVuc.SelectedItem.ToString();
            _p.LoaiPhong = cboLoaiPhong.SelectedItem.ToString();
            _p.SucChua = sc;
            _p.GiaThue = gia;
            _p.TienNghi = txtTienNghi.Text.Trim();
            _p.TrangThai = cboTrangThai.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Add(Control c) => this.Controls.Add(c);
        private TextBox TB(int x, int y, int w, string val) { var t = new TextBox { Location = new Point(x, y), Size = new Size(w, 26), Text = val }; Add(t); return t; }
        private ComboBox Combo(int x, int y, int w, string[] items, string sel)
        {
            var c = new ComboBox { Location = new Point(x, y), Size = new Size(w, 26), DropDownStyle = ComboBoxStyle.DropDownList };
            c.Items.AddRange(items); c.SelectedItem = sel; if (c.SelectedIndex < 0) c.SelectedIndex = 0;
            Add(c); return c;
        }
        private Button Btn(string t, int x, int y, int w, Color bg)
        {
            var b = new Button
            {
                Text = t,
                Location = new Point(x, y),
                Size = new Size(w, 30),
                BackColor = bg,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0; return b;
        }
    }

    // ══════════════════════════════════════════════════════════════════════════
    // UI_23c — Thêm giường
    // ══════════════════════════════════════════════════════════════════════════
    public class UI_23c_ThemGiuong : Form
    {
        public Giuong GiuongMoi { get; private set; }
        private TextBox txtMaGiuong, txtViTri, txtGhiChu;
        private ComboBox cboPhong, cboTrangThai;
        private Button btnLuu, btnHuy;

        public UI_23c_ThemGiuong(List<Phong> dsPhong)
        {
            this.Text = "Thêm giường mới";
            this.ClientSize = new Size(420, 320);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9f);
            this.BackColor = Color.White;

            var hdr = new Panel { BackColor = Color.FromArgb(15, 110, 86), Dock = DockStyle.Top, Height = 46 };
            hdr.Controls.Add(new Label
            {
                Text = "Thêm giường mới",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(16, 12),
                Size = new Size(320, 24)
            });
            this.Controls.Add(hdr);

            int lx = 20, rx = 150, w = 240, y = 56, gap = 42;
            void AddLabel(string t, int yy) =>
                this.Controls.Add(new Label { Text = t, Location = new Point(lx, yy + 4), Size = new Size(128, 20), ForeColor = Color.FromArgb(60, 70, 90) });
            void AddTB(string label, int yy, out TextBox tb)
            {
                AddLabel(label, yy);
                tb = new TextBox { Location = new Point(rx, yy), Size = new Size(w, 26) };
                this.Controls.Add(tb);
            }
            AddTB("Mã giường *", y, out txtMaGiuong);
            //txtMaGiuong.PlaceholderText = "VD: G101E";

            AddLabel("Phòng *", y + gap);
            cboPhong = new ComboBox { Location = new Point(rx, y + gap), Size = new Size(w, 26), DropDownStyle = ComboBoxStyle.DropDownList };
            foreach (var p in dsPhong) cboPhong.Items.Add(p.MaPhong);
            if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
            this.Controls.Add(cboPhong);

            AddTB("Vị trí", y + gap * 2, out txtViTri);
            //txtViTri.PlaceholderText = "VD: Tầng dưới (cửa sổ)";

            AddLabel("Trạng thái", y + gap * 3);
            cboTrangThai = new ComboBox { Location = new Point(rx, y + gap * 3), Size = new Size(w, 26), DropDownStyle = ComboBoxStyle.DropDownList };
            cboTrangThai.Items.AddRange(new[] { "Trống", "Bảo trì" }); cboTrangThai.SelectedIndex = 0;
            this.Controls.Add(cboTrangThai);

            AddTB("Ghi chú", y + gap * 4, out txtGhiChu);

            btnLuu = new Button
            {
                Text = "Lưu",
                Location = new Point(216, 278),
                Size = new Size(90, 30),
                BackColor = Color.FromArgb(15, 110, 86),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.Click += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtMaGiuong.Text) || cboPhong.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng điền mã giường và chọn phòng.", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GiuongMoi = new Giuong
                {
                    MaGiuong = txtMaGiuong.Text.Trim().ToUpper(),
                    MaPhong = cboPhong.SelectedItem.ToString(),
                    ViTri = txtViTri.Text.Trim(),
                    TrangThai = cboTrangThai.SelectedItem.ToString(),
                    GhiChu = txtGhiChu.Text.Trim()
                };
                DialogResult = DialogResult.OK; Close();
            };
            btnHuy = new Button
            {
                Text = "Hủy",
                Location = new Point(318, 278),
                Size = new Size(80, 30),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnHuy.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            this.Controls.Add(btnLuu);
            this.Controls.Add(btnHuy);
            AppUiStyle.Apply(this);
        }
    }

    // ══════════════════════════════════════════════════════════════════════════
    // UI_23d — Sửa giường
    // ══════════════════════════════════════════════════════════════════════════
    public class UI_23d_SuaGiuong : Form
    {
        private readonly Giuong _g;
        private TextBox txtViTri, txtGhiChu;
        private ComboBox cboTrangThai;
        private Button btnLuu, btnHuy;

        public UI_23d_SuaGiuong(Giuong g)
        {
            _g = g;
            this.Text = $"Sửa giường — {g.MaGiuong}";
            this.ClientSize = new Size(400, 270);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9f);
            this.BackColor = Color.White;

            var hdr = new Panel { BackColor = Color.FromArgb(133, 79, 11), Dock = DockStyle.Top, Height = 46 };
            hdr.Controls.Add(new Label
            {
                Text = $"Sửa giường — {g.MaGiuong} (Phòng {g.MaPhong})",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(16, 12),
                Size = new Size(360, 24)
            });
            this.Controls.Add(hdr);

            int lx = 20, rx = 140, w = 240, y = 56, gap = 42;
            void L(string t, int yy) =>
                this.Controls.Add(new Label { Text = t, Location = new Point(lx, yy + 4), Size = new Size(118, 20), ForeColor = Color.FromArgb(60, 70, 90) });

            L("Vị trí", y);
            txtViTri = new TextBox { Location = new Point(rx, y), Size = new Size(w, 26), Text = g.ViTri };
            this.Controls.Add(txtViTri);

            L("Trạng thái", y + gap);
            cboTrangThai = new ComboBox { Location = new Point(rx, y + gap), Size = new Size(w, 26), DropDownStyle = ComboBoxStyle.DropDownList };
            cboTrangThai.Items.AddRange(new[] { "Trống", "Đã đặt cọc", "Đang ở", "Bảo trì" });
            cboTrangThai.SelectedItem = g.TrangThai;
            this.Controls.Add(cboTrangThai);

            L("Ghi chú", y + gap * 2);
            txtGhiChu = new TextBox { Location = new Point(rx, y + gap * 2), Size = new Size(w, 26), Text = g.GhiChu };
            this.Controls.Add(txtGhiChu);

            btnLuu = new Button
            {
                Text = "Lưu",
                Location = new Point(200, 228),
                Size = new Size(90, 30),
                BackColor = Color.FromArgb(133, 79, 11),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.Click += (s, e) => {
                if (g.TrangThai == "Đang ở" || g.TrangThai == "Đã đặt cọc")
                {
                    string newTT = cboTrangThai.SelectedItem?.ToString();
                    if (newTT == "Trống" || newTT == "Bảo trì")
                    {
                        var w2 = MessageBox.Show("Giường đang có khách/đặt cọc. Vẫn thay đổi trạng thái?",
                            "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (w2 != DialogResult.Yes) return;
                    }
                }
                _g.ViTri = txtViTri.Text.Trim();
                _g.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? _g.TrangThai;
                _g.GhiChu = txtGhiChu.Text.Trim();
                DialogResult = DialogResult.OK; Close();
            };
            btnHuy = new Button
            {
                Text = "Hủy",
                Location = new Point(304, 228),
                Size = new Size(80, 30),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnHuy.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
            this.Controls.Add(btnLuu);
            this.Controls.Add(btnHuy);
            AppUiStyle.Apply(this);
        }
    }
}