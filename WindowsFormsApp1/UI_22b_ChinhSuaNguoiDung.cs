using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class UI_22b_ChinhSuaNguoiDung : Form
    {
        private readonly NguoiDung _nd;
        private TextBox txtHoTen, txtEmail;
        private ComboBox cboNhomQuyen, cboTrangThai;
        private Button btnLuu, btnHuy;

        public UI_22b_ChinhSuaNguoiDung(NguoiDung nd)
        {
            _nd = nd;
            BuildUI();
        }

        private void BuildUI()
        {
            this.Text = $"Chỉnh sửa — {_nd.HoTen}";
            this.ClientSize = new Size(440, 340);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9f);
            this.BackColor = Color.White;

            var pnlH = new Panel { BackColor = Color.FromArgb(133, 79, 11), Dock = DockStyle.Top, Height = 46 };
            pnlH.Controls.Add(new Label
            {
                Text = "Chỉnh sửa người dùng",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(16, 12),
                Size = new Size(320, 24)
            });
            this.Controls.Add(pnlH);

            int lx = 24, rx = 160, w = 250, gy = 60, gap = 44;

            Add(MakeLabel("Họ và tên *", lx, gy));
            txtHoTen = MakeTextBox(rx, gy, w); txtHoTen.Text = _nd.HoTen;
            Add(txtHoTen);

            Add(MakeLabel("Email *", lx, gy + gap));
            txtEmail = MakeTextBox(rx, gy + gap, w); txtEmail.Text = _nd.Email;
            Add(txtEmail);

            Add(MakeLabel("Nhóm quyền *", lx, gy + gap * 2));
            cboNhomQuyen = new ComboBox
            {
                Location = new Point(rx, gy + gap * 2),
                Size = new Size(w, 26),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboNhomQuyen.Items.AddRange(new object[] { "Sale", "Kế toán", "Quản lý" });
            cboNhomQuyen.SelectedItem = _nd.NhomQuyen;
            Add(cboNhomQuyen);

            Add(MakeLabel("Trạng thái", lx, gy + gap * 3));
            cboTrangThai = new ComboBox
            {
                Location = new Point(rx, gy + gap * 3),
                Size = new Size(w, 26),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboTrangThai.Items.AddRange(new object[] { "Đang hoạt động", "Đã khóa" });
            cboTrangThai.SelectedItem = _nd.TrangThai;
            Add(cboTrangThai);

            btnLuu = new Button
            {
                Text = "Lưu thay đổi",
                Size = new Size(110, 32),
                Location = new Point(210, 290),
                BackColor = Color.FromArgb(133, 79, 11),
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
                Location = new Point(334, 290),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnHuy.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            Add(btnLuu); Add(btnHuy);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường bắt buộc.", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _nd.HoTen = txtHoTen.Text.Trim();
            _nd.Email = txtEmail.Text.Trim();
            _nd.NhomQuyen = cboNhomQuyen.SelectedItem?.ToString() ?? _nd.NhomQuyen;
            _nd.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? _nd.TrangThai;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Add(Control c) => this.Controls.Add(c);
        private Label MakeLabel(string t, int x, int y) =>
            new Label { Text = t, Location = new Point(x, y + 4), Size = new Size(130, 20), ForeColor = Color.FromArgb(60, 70, 90) };
        private TextBox MakeTextBox(int x, int y, int w) =>
            new TextBox { Location = new Point(x, y), Size = new Size(w, 26) };
    }
}