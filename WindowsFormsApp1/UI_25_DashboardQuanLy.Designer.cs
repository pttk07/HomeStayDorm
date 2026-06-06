namespace WindowsFormsApp1
{
    partial class UI_25_DashboardQuanLy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer();

            // ── stat cards ──
            this.pnlStats = new System.Windows.Forms.Panel();
            this.cardPhongTrong = new System.Windows.Forms.Panel();
            this.lblCPhongTrongT = new System.Windows.Forms.Label();
            this.lblCPhongTrongV = new System.Windows.Forms.Label();
            this.lblCPhongTrongS = new System.Windows.Forms.Label();
            this.cardDangO = new System.Windows.Forms.Panel();
            this.lblCDangOT = new System.Windows.Forms.Label();
            this.lblCDangOV = new System.Windows.Forms.Label();
            this.lblCDangOS = new System.Windows.Forms.Label();
            this.cardChoKy = new System.Windows.Forms.Panel();
            this.lblCChoKyT = new System.Windows.Forms.Label();
            this.lblCChoKyV = new System.Windows.Forms.Label();
            this.lblCChoKyS = new System.Windows.Forms.Label();
            this.cardTraPhong = new System.Windows.Forms.Panel();
            this.lblCTraPhongT = new System.Windows.Forms.Label();
            this.lblCTraPhongV = new System.Windows.Forms.Label();
            this.lblCTraPhongS = new System.Windows.Forms.Label();

            // ── menu buttons ──
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnDoiChieuChungTu = new System.Windows.Forms.Button();
            this.btnKiemTraDieuKien = new System.Windows.Forms.Button();
            this.btnGhiNhanTinhTrang = new System.Windows.Forms.Button();
            this.btnCapNhatTrangThai = new System.Windows.Forms.Button();
            this.btnKiemTraPhongTrong = new System.Windows.Forms.Button();
            this.btnLapBienBanBanGiao = new System.Windows.Forms.Button();
            this.btnTaoBienBanThanhLy = new System.Windows.Forms.Button();

            // ── work queue ──
            this.pnlQueue = new System.Windows.Forms.Panel();
            this.lblQueue = new System.Windows.Forms.Label();
            this.dgvCongViec = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
            this.SuspendLayout();

            // ── Header ──────────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 110, 86);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;

            this.lblTitle.Text = "HomeStay Dorm — Quản lý";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Size = new System.Drawing.Size(420, 28);

            this.lblSubtitle.Text = "Dashboard Quản lý chi nhánh";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 230, 210);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(300, 20);

            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(160, 230, 210);
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Location = new System.Drawing.Point(580, 44);
            this.lblTime.Size = new System.Drawing.Size(280, 20);

            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(163, 45, 45);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.Location = new System.Drawing.Point(874, 24);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // ── Stat cards ──────────────────────────────────────────────────
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(240, 245, 242);
            this.pnlStats.Controls.Add(this.cardPhongTrong);
            this.pnlStats.Controls.Add(this.cardDangO);
            this.pnlStats.Controls.Add(this.cardChoKy);
            this.pnlStats.Controls.Add(this.cardTraPhong);
            this.pnlStats.Location = new System.Drawing.Point(0, 80);
            this.pnlStats.Size = new System.Drawing.Size(984, 106);

            var cardSz = new System.Drawing.Size(210, 78);

            BuildStatCard(this.cardPhongTrong, this.lblCPhongTrongT, this.lblCPhongTrongV, this.lblCPhongTrongS,
                20, 14, cardSz, "Phòng/giường trống", "14", "Sẵn sàng nhận khách", System.Drawing.Color.FromArgb(15, 110, 86));

            BuildStatCard(this.cardDangO, this.lblCDangOT, this.lblCDangOV, this.lblCDangOS,
                248, 14, cardSz, "Đang có khách ở", "68", "74 tổng giường", System.Drawing.Color.FromArgb(30, 64, 140));

            BuildStatCard(this.cardChoKy, this.lblCChoKyT, this.lblCChoKyV, this.lblCChoKyS,
                476, 14, cardSz, "Chờ ký hợp đồng", "3", "Đã đặt cọc xong", System.Drawing.Color.FromArgb(133, 79, 11));

            BuildStatCard(this.cardTraPhong, this.lblCTraPhongT, this.lblCTraPhongV, this.lblCTraPhongS,
                704, 14, cardSz, "Trả phòng hôm nay", "2", "Cần kiểm tra & thanh lý", System.Drawing.Color.FromArgb(163, 45, 45));

            // ── Menu buttons ────────────────────────────────────────────────
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(240, 245, 242);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Controls.Add(this.btnDoiChieuChungTu);
            this.pnlMenu.Controls.Add(this.btnKiemTraDieuKien);
            this.pnlMenu.Controls.Add(this.btnGhiNhanTinhTrang);
            this.pnlMenu.Controls.Add(this.btnCapNhatTrangThai);
            this.pnlMenu.Controls.Add(this.btnKiemTraPhongTrong);
            this.pnlMenu.Controls.Add(this.btnLapBienBanBanGiao);
            this.pnlMenu.Controls.Add(this.btnTaoBienBanThanhLy);
            this.pnlMenu.Location = new System.Drawing.Point(0, 186);
            this.pnlMenu.Size = new System.Drawing.Size(984, 178);

            this.lblMenuTitle.Text = "Chức năng quản lý";
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(40, 60, 50);
            this.lblMenuTitle.Location = new System.Drawing.Point(20, 10);
            this.lblMenuTitle.Size = new System.Drawing.Size(280, 24);

            // Row 1 — 4 buttons
            int bw = 218, bh = 52, by1 = 40, by2 = 104, gap = 230;
            BuildMenuBtn(this.btnDoiChieuChungTu, "📋  Đối chiếu chứng từ", 20, by1, bw, bh, System.Drawing.Color.FromArgb(15, 110, 86));
            BuildMenuBtn(this.btnKiemTraDieuKien, "✅  Kiểm tra điều kiện khách thuê", 20 + gap, by1, bw, bh, System.Drawing.Color.FromArgb(30, 64, 140));
            BuildMenuBtn(this.btnGhiNhanTinhTrang, "📝  Ghi nhận tình trạng phòng", 20 + gap * 2, by1, bw, bh, System.Drawing.Color.FromArgb(80, 60, 140));
            BuildMenuBtn(this.btnCapNhatTrangThai, "🔄  Cập nhật trạng thái phòng", 20 + gap * 3, by1, bw, bh, System.Drawing.Color.FromArgb(133, 79, 11));

            // Row 2 — 3 buttons
            BuildMenuBtn(this.btnKiemTraPhongTrong, "🔍  Kiểm tra phòng/giường trống", 20, by2, bw, bh, System.Drawing.Color.FromArgb(60, 100, 80));
            BuildMenuBtn(this.btnLapBienBanBanGiao, "🏠  Lập biên bản bàn giao phòng", 20 + gap, by2, bw, bh, System.Drawing.Color.FromArgb(30, 80, 140));
            BuildMenuBtn(this.btnTaoBienBanThanhLy, "📄  Tạo biên bản thanh lý HĐ", 20 + gap * 2, by2, bw, bh, System.Drawing.Color.FromArgb(163, 45, 45));

            this.btnDoiChieuChungTu.Click += new System.EventHandler(this.btnDoiChieuChungTu_Click);
            this.btnKiemTraDieuKien.Click += new System.EventHandler(this.btnKiemTraDieuKien_Click);
            this.btnGhiNhanTinhTrang.Click += new System.EventHandler(this.btnGhiNhanTinhTrang_Click);
            this.btnCapNhatTrangThai.Click += new System.EventHandler(this.btnCapNhatTrangThai_Click);
            this.btnKiemTraPhongTrong.Click += new System.EventHandler(this.btnKiemTraPhongTrong_Click);
            this.btnLapBienBanBanGiao.Click += new System.EventHandler(this.btnLapBienBanBanGiao_Click);
            this.btnTaoBienBanThanhLy.Click += new System.EventHandler(this.btnTaoBienBanThanhLy_Click);

            // ── Work queue ──────────────────────────────────────────────────
            this.pnlQueue.BackColor = System.Drawing.Color.FromArgb(240, 245, 242);
            this.pnlQueue.Controls.Add(this.lblQueue);
            this.pnlQueue.Controls.Add(this.dgvCongViec);
            this.pnlQueue.Location = new System.Drawing.Point(0, 364);
            this.pnlQueue.Size = new System.Drawing.Size(984, 240);

            this.lblQueue.Text = "Công việc cần xử lý hôm nay";
            this.lblQueue.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.lblQueue.ForeColor = System.Drawing.Color.FromArgb(40, 60, 50);
            this.lblQueue.Location = new System.Drawing.Point(20, 8);
            this.lblQueue.Size = new System.Drawing.Size(320, 24);

            this.dgvCongViec.Location = new System.Drawing.Point(20, 36);
            this.dgvCongViec.Size = new System.Drawing.Size(944, 190);
            StyleGrid(this.dgvCongViec, System.Drawing.Color.FromArgb(15, 110, 86));

            // ── Timer ───────────────────────────────────────────────────────
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.UpdateClock);

            // ── Form ────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Text = "Dashboard Quản lý | HomeStay Dorm";
            this.BackColor = System.Drawing.Color.FromArgb(240, 245, 242);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlQueue);

            this.pnlHeader.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
            this.ResumeLayout(false);
        }

        private void BuildStatCard(
            System.Windows.Forms.Panel card,
            System.Windows.Forms.Label lblT,
            System.Windows.Forms.Label lblV,
            System.Windows.Forms.Label lblS,
            int x, int y, System.Drawing.Size sz,
            string title, string value, string sub,
            System.Drawing.Color accent)
        {
            card.BackColor = System.Drawing.Color.White;
            card.Location = new System.Drawing.Point(x, y);
            card.Size = sz;
            this.pnlStats.Controls.Add(card);

            lblT.Text = title; lblT.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            lblT.ForeColor = System.Drawing.Color.FromArgb(110, 130, 120);
            lblT.Location = new System.Drawing.Point(12, 10); lblT.Size = new System.Drawing.Size(190, 18);

            lblV.Text = value; lblV.Font = new System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold);
            lblV.ForeColor = accent;
            lblV.Location = new System.Drawing.Point(12, 28); lblV.Size = new System.Drawing.Size(150, 34);

            lblS.Text = sub; lblS.Font = new System.Drawing.Font("Segoe UI", 8f);
            lblS.ForeColor = System.Drawing.Color.FromArgb(140, 160, 150);
            lblS.Location = new System.Drawing.Point(12, 58); lblS.Size = new System.Drawing.Size(190, 16);

            card.Controls.Add(lblT); card.Controls.Add(lblV); card.Controls.Add(lblS);
        }

        private void BuildMenuBtn(System.Windows.Forms.Button btn, string text,
            int x, int y, int w, int h, System.Drawing.Color bg)
        {
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            btn.ForeColor = System.Drawing.Color.White;
            btn.BackColor = bg;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, h);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
        }

        private void StyleGrid(System.Windows.Forms.DataGridView dgv, System.Drawing.Color headerColor)
        {
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.Font = new System.Drawing.Font("Segoe UI", 9);
            dgv.RowTemplate.Height = 30;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle, lblSubtitle, lblTime;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timerClock;

        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel cardPhongTrong, cardDangO, cardChoKy, cardTraPhong;
        private System.Windows.Forms.Label lblCPhongTrongT, lblCPhongTrongV, lblCPhongTrongS;
        private System.Windows.Forms.Label lblCDangOT, lblCDangOV, lblCDangOS;
        private System.Windows.Forms.Label lblCChoKyT, lblCChoKyV, lblCChoKyS;
        private System.Windows.Forms.Label lblCTraPhongT, lblCTraPhongV, lblCTraPhongS;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnDoiChieuChungTu;
        private System.Windows.Forms.Button btnKiemTraDieuKien;
        private System.Windows.Forms.Button btnGhiNhanTinhTrang;
        private System.Windows.Forms.Button btnCapNhatTrangThai;
        private System.Windows.Forms.Button btnKiemTraPhongTrong;
        private System.Windows.Forms.Button btnLapBienBanBanGiao;
        private System.Windows.Forms.Button btnTaoBienBanThanhLy;

        private System.Windows.Forms.Panel pnlQueue;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.DataGridView dgvCongViec;
    }
}