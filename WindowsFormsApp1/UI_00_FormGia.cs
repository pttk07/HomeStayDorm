using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Form giả dùng tạm cho tất cả các chức năng chưa cài đặt.
    /// Khi import form thật, thay thế: new UI_00_FormGia("...") → new UI_XX_TenForm()
    /// </summary>
    public class UI_00_FormGia : Form
    {
        public UI_00_FormGia(string tenChucNang)
        {
            this.Text = tenChucNang + " (Chưa cài đặt)";
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9f);

            var pnlTop = new Panel
            {
                BackColor = System.Drawing.Color.FromArgb(200, 210, 230),
                Dock = DockStyle.Top,
                Height = 6
            };

            var lbl = new Label
            {
                Text = $"⚙  Chức năng đang phát triển\n\n{tenChucNang}",
                Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Regular),
                ForeColor = System.Drawing.Color.FromArgb(80, 90, 110),
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var btnDong = new Button
            {
                Text = "Đóng",
                Size = new System.Drawing.Size(90, 32),
                Location = new System.Drawing.Point(205, 152),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnDong.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 185, 200);
            btnDong.Click += (s, e) => this.Close();

            this.Controls.Add(lbl);
            this.Controls.Add(btnDong);
            this.Controls.Add(pnlTop);
        }
    }
}