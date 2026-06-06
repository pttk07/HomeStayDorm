namespace WindowsFormsApp1
{
    partial class UI_27_DashboardSale
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

            this.pnlStats = new System.Windows.Forms.Panel();
            this.cardPhongTrong = new System.Windows.Forms.Panel();
            this.lblCPhongTrongT = new System.Windows.Forms.Label();
            this.lblCPhongTrongV = new System.Windows.Forms.Label();
            this.lblCPhongTrongS = new System.Windows.Forms.Label();
            this.cardChoXN = new System.Windows.Forms.Panel();
            this.lblCChoXNT = new System.Windows.Forms.Label();
            this.lblCChoXNV = new System.Windows.Forms.Label();
            this.lblCChoXNS = new System.Windows.Forms.Label();
            this.cardDatCocHomNay = new System.Windows.Forms.Panel();
            this.lblCDatCocT = new System.Windows.Forms.Label();
            this.lblCDatCocV = new System.Windows.Forms.Label();
            this.lblCDatCocS = new System.Windows.Forms.Label();
            this.cardKhachMoi = new System.Windows.Forms.Panel();
            this.lblCKhachMoiT = new System.Windows.Forms.Label();
            this.lblCKhachMoiV = new System.Windows.Forms.Label();
            this.lblCKhachMoiS = new System.Windows.Forms.Label();

            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.lblMenuNote = new System.Windows.Forms.Label();
            this.btnTraCuuPhongTrong = new System.Windows.Forms.Button();
            this.lblNoteTraCuu = new System.Windows.Forms.Label();
            this.btnLapHopDong = new System.Windows.Forms.Button();
            this.lblNoteLapHD = new System.Windows.Forms.Label();
            this.btnLapPhieuDatCoc = new System.Windows.Forms.Button();
            this.btnTiepNhanThanhToan = new System.Windows.Forms.Button();
            this.btnTaoPhieuTraPhong = new System.Windows.Forms.Button();
            this.lblNoteTaoPhieu = new System.Windows.Forms.Label();
            this.btnDangKyThongTinKhach = new System.Windows.Forms.Button();
            this.btnCapNhatThongTinKhach = new System.Windows.Forms.Button();

            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dgvHoatDong = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoatDong)).BeginInit();
            this.SuspendLayout();

            // ── Header ──────────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 64, 140);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;

            this.lblTitle.Text = "HomeStay Dorm — Sale";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Size = new System.Drawing.Size(380, 28);

            this.lblSubtitle.Text = "Dashboard Sale — Tư vấn & Đặt phòng";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 190, 240);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(340, 20);

            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(160, 190, 240);
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
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(240, 243, 250);
            this.pnlStats.Controls.Add(this.cardPhongTrong);
            this.pnlStats.Controls.Add(this.cardChoXN);
            this.pnlStats.Controls.Add(this.cardDatCocHomNay);
            this.pnlStats.Controls.Add(this.cardKhachMoi);
            this.pnlStats.Location = new System.Drawing.Point(0, 80);
            this.pnlStats.Size = new System.Drawing.Size(984, 126);

            var cardSz = new System.Drawing.Size(210, 96);
            BuildStatCard(this.cardPhongTrong, this.lblCPhongTrongT, this.lblCPhongTrongV, this.lblCPhongTrongS,
                20, 14, cardSz, "Phòng/giường trống", "14", "Có thể giới thiệu KH", System.Drawing.Color.FromArgb(15, 110, 86));
            BuildStatCard(this.cardChoXN, this.lblCChoXNT, this.lblCChoXNV, this.lblCChoXNS,
                248, 14, cardSz, "Cọc chờ xác nhận QL", "4", "Trong 24h hết hạn", System.Drawing.Color.FromArgb(163, 45, 45));
            BuildStatCard(this.cardDatCocHomNay, this.lblCDatCocT, this.lblCDatCocV, this.lblCDatCocS,
                476, 14, cardSz, "Đặt cọc hôm nay", "3", "Tổng 12.600.000 đ", System.Drawing.Color.FromArgb(30, 64, 140));
            BuildStatCard(this.cardKhachMoi, this.lblCKhachMoiT, this.lblCKhachMoiV, this.lblCKhachMoiS,
                704, 14, cardSz, "Khách đăng ký mới", "7", "Trong tuần này", System.Drawing.Color.FromArgb(133, 79, 11));

            // ── Menu buttons ────────────────────────────────────────────────
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(240, 243, 250);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Controls.Add(this.lblMenuNote);
            this.pnlMenu.Controls.Add(this.btnTraCuuPhongTrong);
            this.pnlMenu.Controls.Add(this.lblNoteTraCuu);
            this.pnlMenu.Controls.Add(this.btnLapHopDong);
            this.pnlMenu.Controls.Add(this.lblNoteLapHD);
            this.pnlMenu.Controls.Add(this.btnLapPhieuDatCoc);
            this.pnlMenu.Controls.Add(this.btnTiepNhanThanhToan);
            this.pnlMenu.Controls.Add(this.btnTaoPhieuTraPhong);
            this.pnlMenu.Controls.Add(this.lblNoteTaoPhieu);
            this.pnlMenu.Controls.Add(this.btnDangKyThongTinKhach);
            this.pnlMenu.Controls.Add(this.btnCapNhatThongTinKhach);
            this.pnlMenu.Location = new System.Drawing.Point(0, 206);
            this.pnlMenu.Size = new System.Drawing.Size(984, 226);

            this.lblMenuTitle.Text = "Chức năng Sale";
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100);
            this.lblMenuTitle.Location = new System.Drawing.Point(20, 8);
            this.lblMenuTitle.Size = new System.Drawing.Size(240, 24);

            this.lblMenuNote.Text = "* include → chức năng con sẽ được gọi tự động bên trong";
            this.lblMenuNote.Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Italic);
            this.lblMenuNote.ForeColor = System.Drawing.Color.FromArgb(140, 150, 170);
            this.lblMenuNote.Location = new System.Drawing.Point(240, 12);
            this.lblMenuNote.Size = new System.Drawing.Size(460, 16);

            // Row 1: Tra cứu phòng trống | Lập hợp đồng | Lập phiếu đặt cọc | Tiếp nhận TT cọc
            int bw = 218, bh = 48, by1 = 36, by2 = 96, gap = 230;
            BuildMenuBtn(this.btnTraCuuPhongTrong, "🔍  Tra cứu phòng trống", 20, by1, bw, bh, System.Drawing.Color.FromArgb(15, 110, 86));
            BuildMenuBtn(this.btnLapHopDong, "📃  Lập hợp đồng", 20 + gap, by1, bw, bh, System.Drawing.Color.FromArgb(30, 64, 140));
            BuildMenuBtn(this.btnLapPhieuDatCoc, "💰  Lập phiếu đặt cọc", 20 + gap * 2, by1, bw, bh, System.Drawing.Color.FromArgb(80, 60, 140));
            BuildMenuBtn(this.btnTiepNhanThanhToan, "💳  Tiếp nhận thanh toán cọc", 20 + gap * 3, by1, bw, bh, System.Drawing.Color.FromArgb(133, 79, 11));

            // Note dòng include
            BuildNote(this.lblNoteTraCuu, "→ include: Ghi nhận kết quả chọn phòng", 22, by1 + bh + 2, bw - 4);
            BuildNote(this.lblNoteLapHD, "→ include: Thu thập TT cư trú, Tra cứu phiếu cọc", 22 + gap, by1 + bh + 2, bw - 4);

            // Row 2: Tạo phiếu trả phòng | Đăng ký TT khách | Cập nhật TT khách
            BuildMenuBtn(this.btnTaoPhieuTraPhong, "📋  Tạo phiếu thông tin trả phòng", 20, by2, bw, bh, System.Drawing.Color.FromArgb(60, 100, 160));
            BuildMenuBtn(this.btnDangKyThongTinKhach, "👤  Đăng ký thông tin khách", 20 + gap, by2, bw, bh, System.Drawing.Color.FromArgb(15, 90, 70));
            BuildMenuBtn(this.btnCapNhatThongTinKhach, "✏   Cập nhật thông tin khách", 20 + gap * 2, by2, bw, bh, System.Drawing.Color.FromArgb(100, 70, 30));

            BuildNote(this.lblNoteTaoPhieu, "→ include: Tra cứu phiếu thông tin thuê", 22, by2 + bh + 2, bw - 4);

            this.btnTraCuuPhongTrong.Click += new System.EventHandler(this.btnTraCuuPhongTrong_Click);
            this.btnLapHopDong.Click += new System.EventHandler(this.btnLapHopDong_Click);
            this.btnLapPhieuDatCoc.Click += new System.EventHandler(this.btnLapPhieuDatCoc_Click);
            this.btnTiepNhanThanhToan.Click += new System.EventHandler(this.btnTiepNhanThanhToan_Click);
            this.btnTaoPhieuTraPhong.Click += new System.EventHandler(this.btnTaoPhieuTraPhong_Click);
            this.btnDangKyThongTinKhach.Click += new System.EventHandler(this.btnDangKyThongTinKhach_Click);
            this.btnCapNhatThongTinKhach.Click += new System.EventHandler(this.btnCapNhatThongTinKhach_Click);

            // ── History table ───────────────────────────────────────────────
            this.pnlHistory.BackColor = System.Drawing.Color.FromArgb(240, 243, 250);
            this.pnlHistory.Controls.Add(this.lblHistory);
            this.pnlHistory.Controls.Add(this.dgvHoatDong);
            this.pnlHistory.Location = new System.Drawing.Point(0, 412);
            this.pnlHistory.Size = new System.Drawing.Size(984, 218);

            this.lblHistory.Text = "Hoạt động gần đây của tôi";
            this.lblHistory.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(30, 50, 100);
            this.lblHistory.Location = new System.Drawing.Point(20, 8);
            this.lblHistory.Size = new System.Drawing.Size(320, 24);

            this.dgvHoatDong.Location = new System.Drawing.Point(20, 36);
            this.dgvHoatDong.Size = new System.Drawing.Size(944, 170);
            StyleGrid(this.dgvHoatDong, System.Drawing.Color.FromArgb(30, 64, 140));

            // ── Timer ───────────────────────────────────────────────────────
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.UpdateClock);

            // ── Form ────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 452);
            this.Text = "Dashboard Sale | HomeStay Dorm";
            this.BackColor = System.Drawing.Color.FromArgb(240, 243, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlMenu);

            this.pnlHeader.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoatDong)).EndInit();
            this.ResumeLayout(false);
        }

        private void BuildStatCard(
            System.Windows.Forms.Panel card,
            System.Windows.Forms.Label lblT, System.Windows.Forms.Label lblV, System.Windows.Forms.Label lblS,
            int x, int y, System.Drawing.Size sz,
            string title, string value, string sub, System.Drawing.Color accent)
        {
            card.BackColor = System.Drawing.Color.White;
            card.Location = new System.Drawing.Point(x, y);
            card.Size = sz;
            this.pnlStats.Controls.Add(card);

            lblT.Text = title; lblT.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            lblT.ForeColor = System.Drawing.Color.FromArgb(110, 120, 150);
            lblT.Location = new System.Drawing.Point(12, 10); lblT.Size = new System.Drawing.Size(190, 18);

            lblV.Text = value; lblV.Font = new System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold);
            lblV.ForeColor = accent;
            lblV.Location = new System.Drawing.Point(12, 30); lblV.Size = new System.Drawing.Size(150, 40);

            lblS.Text = sub; lblS.Font = new System.Drawing.Font("Segoe UI", 8f);
            lblS.ForeColor = System.Drawing.Color.FromArgb(140, 150, 170);
            lblS.Location = new System.Drawing.Point(12, 74); lblS.Size = new System.Drawing.Size(190, 18);

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

        private void BuildNote(System.Windows.Forms.Label lbl, string text, int x, int y, int w)
        {
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 7.5f, System.Drawing.FontStyle.Italic);
            lbl.ForeColor = System.Drawing.Color.FromArgb(100, 130, 180);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(w, 16);
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
        private System.Windows.Forms.Panel cardPhongTrong, cardChoXN, cardDatCocHomNay, cardKhachMoi;
        private System.Windows.Forms.Label lblCPhongTrongT, lblCPhongTrongV, lblCPhongTrongS;
        private System.Windows.Forms.Label lblCChoXNT, lblCChoXNV, lblCChoXNS;
        private System.Windows.Forms.Label lblCDatCocT, lblCDatCocV, lblCDatCocS;
        private System.Windows.Forms.Label lblCKhachMoiT, lblCKhachMoiV, lblCKhachMoiS;

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuTitle, lblMenuNote;
        private System.Windows.Forms.Button btnTraCuuPhongTrong;
        private System.Windows.Forms.Label lblNoteTraCuu;
        private System.Windows.Forms.Button btnLapHopDong;
        private System.Windows.Forms.Label lblNoteLapHD;
        private System.Windows.Forms.Button btnLapPhieuDatCoc;
        private System.Windows.Forms.Button btnTiepNhanThanhToan;
        private System.Windows.Forms.Button btnTaoPhieuTraPhong;
        private System.Windows.Forms.Label lblNoteTaoPhieu;
        private System.Windows.Forms.Button btnDangKyThongTinKhach;
        private System.Windows.Forms.Button btnCapNhatThongTinKhach;

        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView dgvHoatDong;
    }
}
