using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // ─── Designer inline (form nhỏ, gom 1 file cho gọn) ──────────────────────
    public class UI_22a_ThemNguoiDung : Form
    {
        public NguoiDung NguoiDungMoi { get; private set; }

        private Label lblHoTen, lblEmail, lblMatKhau, lblNhomQuyen, lblTrangThai;
        private TextBox txtHoTen, txtEmail, txtMatKhau;
        private ComboBox cboNhomQuyen, cboTrangThai;
        private Button btnLuu, btnHuy;
        private Panel pnlHeader;
        private Label lblTitle;

        public UI_22a_ThemNguoiDung()
        {
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = "Thêm người dùng mới";
            this.ClientSize = new Size(440, 380);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9f);
            this.BackColor = Color.White;

            pnlHeader = new Panel
            {
                BackColor = Color.FromArgb(30, 64, 140),
                Dock = DockStyle.Top,
                Height = 46
            };
            lblTitle = new Label
            {
                Text = "Thêm người dùng mới",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(16, 12),
                Size = new Size(320, 24)
            };
            pnlHeader.Controls.Add(lblTitle);
            this.Controls.Add(pnlHeader);

            int lx = 24, rx = 170, w = 240, gy = 60, gap = 44;

            // Họ tên
            lblHoTen = MakeLabel("Họ và tên *", lx, gy);
            txtHoTen = MakeTextBox(rx, gy, w);

            // Email
            lblEmail = MakeLabel("Email *", lx, gy + gap);
            txtEmail = MakeTextBox(rx, gy + gap, w);

            // Mật khẩu
            lblMatKhau = MakeLabel("Mật khẩu *", lx, gy + gap * 2);
            txtMatKhau = MakeTextBox(rx, gy + gap * 2, w);
            txtMatKhau.PasswordChar = '●';

            // Nhóm quyền
            lblNhomQuyen = MakeLabel("Nhóm quyền *", lx, gy + gap * 3);
            cboNhomQuyen = new ComboBox
            {
                Location = new Point(rx, gy + gap * 3),
                Size = new Size(w, 26),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboNhomQuyen.Items.AddRange(new object[] { "Sale", "Kế toán", "Quản lý", "Quản trị hệ thống" });
            cboNhomQuyen.SelectedIndex = 0;

            // Trạng thái
            lblTrangThai = MakeLabel("Trạng thái", lx, gy + gap * 4);
            cboTrangThai = new ComboBox
            {
                Location = new Point(rx, gy + gap * 4),
                Size = new Size(w, 26),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Đã khóa" });
            cboTrangThai.SelectedIndex = 0;

            // Buttons
            btnLuu = new Button
            {
                Text = "Lưu",
                Size = new Size(90, 32),
                Location = new Point(240, 320),
                BackColor = Color.FromArgb(15, 110, 86),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.Click += BtnLuu_Click;

            btnHuy = new Button
            {
                Text = "Hủy",
                Size = new Size(80, 32),
                Location = new Point(344, 320),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnHuy.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            this.Controls.AddRange(new Control[] {
                lblHoTen, txtHoTen, lblEmail, txtEmail,
                lblMatKhau, txtMatKhau, lblNhomQuyen, cboNhomQuyen,
                lblTrangThai, cboTrangThai, btnLuu, btnHuy
            });
            AppUiStyle.Apply(this);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc (*).",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NguoiDungMoi = new NguoiDung
            {
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                NhomQuyen = cboNhomQuyen.SelectedItem.ToString(),
                TrangThai = cboTrangThai.SelectedItem.ToString()
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private Label MakeLabel(string text, int x, int y) =>
            new Label
            {
                Text = text,
                Location = new Point(x, y + 4),
                Size = new Size(140, 20),
                ForeColor = Color.FromArgb(60, 70, 90)
            };

        private TextBox MakeTextBox(int x, int y, int w) =>
            new TextBox { Location = new Point(x, y), Size = new Size(w, 26) };
    }
}