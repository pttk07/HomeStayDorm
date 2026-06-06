using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class UI_28_DashboardKeToan
    {
        private IContainer components = null;

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblTotalTasks;
        private Button btnTaiLai;
        private Button btnThoat;

        private Panel pnlStats;
        private Panel cardYeuCau;
        private Panel cardDoiSoat;
        private Panel cardHoanTien;
        private Panel cardChoXuLy;
        private Label lblYeuCauT;
        private Label lblYeuCauV;
        private Label lblYeuCauS;
        private Label lblDoiSoatT;
        private Label lblDoiSoatV;
        private Label lblDoiSoatS;
        private Label lblHoanTienT;
        private Label lblHoanTienV;
        private Label lblHoanTienS;
        private Label lblChoXuLyT;
        private Label lblChoXuLyV;
        private Label lblChoXuLyS;

        private Panel navPanel;
        private Label lblMenuTitle;
        private Button btnXuatYeuCauThanhToan;
        private Button btnTinhKhoanPhatSinh;
        private Button btnTraCuuHopDong;
        private Button btnLapBangDoiSoat;
        private Button btnDoiChieuKhoanThanhToan;
        private Button btnTinhKhoanCanThanhToan;
        private Button btnHoanTienChoKhach;
        private Button btnCapNhatKetQuaThanhToan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.lblSubtitle = new Label();
            this.lblTotalTasks = new Label();
            this.btnTaiLai = new Button();
            this.btnThoat = new Button();

            this.pnlStats = new Panel();
            this.cardYeuCau = new Panel();
            this.cardDoiSoat = new Panel();
            this.cardHoanTien = new Panel();
            this.cardChoXuLy = new Panel();
            this.lblYeuCauT = new Label();
            this.lblYeuCauV = new Label();
            this.lblYeuCauS = new Label();
            this.lblDoiSoatT = new Label();
            this.lblDoiSoatV = new Label();
            this.lblDoiSoatS = new Label();
            this.lblHoanTienT = new Label();
            this.lblHoanTienV = new Label();
            this.lblHoanTienS = new Label();
            this.lblChoXuLyT = new Label();
            this.lblChoXuLyV = new Label();
            this.lblChoXuLyS = new Label();

            this.navPanel = new Panel();
            this.lblMenuTitle = new Label();
            this.btnXuatYeuCauThanhToan = new Button();
            this.btnTinhKhoanPhatSinh = new Button();
            this.btnTraCuuHopDong = new Button();
            this.btnLapBangDoiSoat = new Button();
            this.btnDoiChieuKhoanThanhToan = new Button();
            this.btnTinhKhoanCanThanhToan = new Button();
            this.btnHoanTienChoKhach = new Button();
            this.btnCapNhatKetQuaThanhToan = new Button();

            this.pnlHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();

            this.pnlHeader.BackColor = Color.FromArgb(133, 79, 11);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTotalTasks);
            this.pnlHeader.Controls.Add(this.btnTaiLai);
            this.pnlHeader.Controls.Add(this.btnThoat);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 80;

            this.lblTitle.Text = "HomeStay Dorm - Kế toán";
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 12);
            this.lblTitle.Size = new Size(420, 28);

            this.lblSubtitle.Text = "Dashboard Kế toán - Thanh toán & đối soát";
            this.lblSubtitle.ForeColor = Color.FromArgb(245, 220, 180);
            this.lblSubtitle.Font = new Font("Segoe UI", 9);
            this.lblSubtitle.Location = new Point(22, 44);
            this.lblSubtitle.Size = new Size(360, 20);

            this.lblTotalTasks.ForeColor = Color.FromArgb(245, 220, 180);
            this.lblTotalTasks.Font = new Font("Segoe UI", 9);
            this.lblTotalTasks.TextAlign = ContentAlignment.MiddleRight;
            this.lblTotalTasks.Location = new Point(560, 44);
            this.lblTotalTasks.Size = new Size(240, 20);

            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.ForeColor = Color.White;
            this.btnTaiLai.BackColor = Color.FromArgb(15, 110, 86);
            this.btnTaiLai.FlatStyle = FlatStyle.Flat;
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.Font = new Font("Segoe UI", 9);
            this.btnTaiLai.Size = new Size(76, 32);
            this.btnTaiLai.Location = new Point(792, 24);
            this.btnTaiLai.Cursor = Cursors.Hand;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.BackColor = Color.FromArgb(163, 45, 45);
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new Font("Segoe UI", 9);
            this.btnThoat.Size = new Size(90, 32);
            this.btnThoat.Location = new Point(874, 24);
            this.btnThoat.Cursor = Cursors.Hand;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.pnlStats.BackColor = Color.FromArgb(246, 243, 238);
            this.pnlStats.Controls.Add(this.cardYeuCau);
            this.pnlStats.Controls.Add(this.cardDoiSoat);
            this.pnlStats.Controls.Add(this.cardHoanTien);
            this.pnlStats.Controls.Add(this.cardChoXuLy);
            this.pnlStats.Location = new Point(0, 80);
            this.pnlStats.Size = new Size(984, 126);

            Size cardSz = new Size(210, 96);
            BuildStatCard(this.cardYeuCau, this.lblYeuCauT, this.lblYeuCauV, this.lblYeuCauS,
                20, 14, cardSz, "Yêu cầu thanh toán", "8", "Đang chờ xử lý", Color.FromArgb(133, 79, 11));
            BuildStatCard(this.cardDoiSoat, this.lblDoiSoatT, this.lblDoiSoatV, this.lblDoiSoatS,
                248, 14, cardSz, "Bảng đối soát", "3", "Cần lập hôm nay", Color.FromArgb(30, 64, 140));
            BuildStatCard(this.cardHoanTien, this.lblHoanTienT, this.lblHoanTienV, this.lblHoanTienS,
                476, 14, cardSz, "Hoàn tiền", "2", "Chờ xác nhận", Color.FromArgb(15, 110, 86));
            BuildStatCard(this.cardChoXuLy, this.lblChoXuLyT, this.lblChoXuLyV, this.lblChoXuLyS,
                704, 14, cardSz, "Khoản phát sinh", "5", "Cần tính toán", Color.FromArgb(163, 45, 45));

            this.navPanel.BackColor = Color.FromArgb(246, 243, 238);
            this.navPanel.Controls.Add(this.lblMenuTitle);
            this.navPanel.Controls.Add(this.btnXuatYeuCauThanhToan);
            this.navPanel.Controls.Add(this.btnTinhKhoanPhatSinh);
            this.navPanel.Controls.Add(this.btnTraCuuHopDong);
            this.navPanel.Controls.Add(this.btnLapBangDoiSoat);
            this.navPanel.Controls.Add(this.btnDoiChieuKhoanThanhToan);
            this.navPanel.Controls.Add(this.btnTinhKhoanCanThanhToan);
            this.navPanel.Controls.Add(this.btnHoanTienChoKhach);
            this.navPanel.Controls.Add(this.btnCapNhatKetQuaThanhToan);
            this.navPanel.Location = new Point(0, 206);
            this.navPanel.Size = new Size(984, 226);

            this.lblMenuTitle.Text = "Chức năng Kế toán";
            this.lblMenuTitle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            this.lblMenuTitle.ForeColor = Color.FromArgb(80, 55, 30);
            this.lblMenuTitle.Location = new Point(20, 8);
            this.lblMenuTitle.Size = new Size(260, 24);

            int bw = 218, bh = 52, by1 = 40, by2 = 104, gap = 230;
            BuildMenuBtn(this.btnXuatYeuCauThanhToan, "Xuất yêu cầu thanh toán", 20, by1, bw, bh, Color.FromArgb(133, 79, 11));
            BuildMenuBtn(this.btnTinhKhoanPhatSinh, "Tính khoản phát sinh", 20 + gap, by1, bw, bh, Color.FromArgb(163, 45, 45));
            BuildMenuBtn(this.btnTraCuuHopDong, "Tra cứu hợp đồng", 20 + gap * 2, by1, bw, bh, Color.FromArgb(30, 64, 140));
            BuildMenuBtn(this.btnLapBangDoiSoat, "Lập bảng đối soát", 20 + gap * 3, by1, bw, bh, Color.FromArgb(15, 110, 86));

            BuildMenuBtn(this.btnDoiChieuKhoanThanhToan, "Đối chiếu thanh toán", 20, by2, bw, bh, Color.FromArgb(80, 60, 140));
            BuildMenuBtn(this.btnTinhKhoanCanThanhToan, "Tính khoản cần thanh toán", 20 + gap, by2, bw, bh, Color.FromArgb(100, 70, 30));
            BuildMenuBtn(this.btnHoanTienChoKhach, "Hoàn tiền cho khách", 20 + gap * 2, by2, bw, bh, Color.FromArgb(15, 90, 70));
            BuildMenuBtn(this.btnCapNhatKetQuaThanhToan, "Cập nhật kết quả thanh toán", 20 + gap * 3, by2, bw, bh, Color.FromArgb(60, 100, 160));

            this.btnXuatYeuCauThanhToan.Click += new System.EventHandler(this.btnXuatYeuCauThanhToan_Click);
            this.btnTinhKhoanPhatSinh.Click += new System.EventHandler(this.btnTinhKhoanPhatSinh_Click);
            this.btnTraCuuHopDong.Click += new System.EventHandler(this.btnTraCuuHopDong_Click);
            this.btnLapBangDoiSoat.Click += new System.EventHandler(this.btnLapBangDoiSoat_Click);
            this.btnDoiChieuKhoanThanhToan.Click += new System.EventHandler(this.btnDoiChieuKhoanThanhToan_Click);
            this.btnTinhKhoanCanThanhToan.Click += new System.EventHandler(this.btnTinhKhoanCanThanhToan_Click);
            this.btnHoanTienChoKhach.Click += new System.EventHandler(this.btnHoanTienChoKhach_Click);
            this.btnCapNhatKetQuaThanhToan.Click += new System.EventHandler(this.btnCapNhatKetQuaThanhToan_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(984, 452);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = Color.FromArgb(246, 243, 238);
            this.Name = "UI_28_DashboardKeToan";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard Kế toán | HomeStay Dorm";
            this.Load += new System.EventHandler(this.formLoad);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.navPanel);

            this.pnlHeader.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void BuildStatCard(
            Panel card,
            Label title,
            Label value,
            Label sub,
            int x,
            int y,
            Size size,
            string titleText,
            string valueText,
            string subText,
            Color accent)
        {
            card.BackColor = Color.White;
            card.Location = new Point(x, y);
            card.Size = size;
            card.Controls.Add(title);
            card.Controls.Add(value);
            card.Controls.Add(sub);

            title.Text = titleText;
            title.Font = new Font("Segoe UI", 8.5f);
            title.ForeColor = Color.FromArgb(120, 100, 80);
            title.Location = new Point(12, 10);
            title.Size = new Size(190, 18);

            value.Text = valueText;
            value.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            value.ForeColor = accent;
            value.Location = new Point(12, 30);
            value.Size = new Size(150, 40);

            sub.Text = subText;
            sub.Font = new Font("Segoe UI", 8f);
            sub.ForeColor = Color.FromArgb(145, 125, 105);
            sub.Location = new Point(12, 74);
            sub.Size = new Size(190, 18);
        }

        private void BuildMenuBtn(Button btn, string text, int x, int y, int w, int h, Color bg)
        {
            btn.Text = text;
            btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.BackColor = bg;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new Point(x, y);
            btn.Size = new Size(w, h);
            btn.Cursor = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(10, 0, 0, 0);
        }
    }
}
