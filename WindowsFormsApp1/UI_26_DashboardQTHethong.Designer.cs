namespace WindowsFormsApp1
{
    partial class UI_26_DashboardQTHethong
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.cardPhong = new System.Windows.Forms.Panel();
            this.lblCardPhongTitle = new System.Windows.Forms.Label();
            this.lblCardPhongValue = new System.Windows.Forms.Label();
            this.lblCardPhongSub = new System.Windows.Forms.Label();
            this.cardGiuong = new System.Windows.Forms.Panel();
            this.lblCardGiuongTitle = new System.Windows.Forms.Label();
            this.lblCardGiuongValue = new System.Windows.Forms.Label();
            this.lblCardGiuongSub = new System.Windows.Forms.Label();
            this.cardNguoiDung = new System.Windows.Forms.Panel();
            this.lblCardNguoiDungTitle = new System.Windows.Forms.Label();
            this.lblCardNguoiDungValue = new System.Windows.Forms.Label();
            this.lblCardNguoiDungSub = new System.Windows.Forms.Label();
            this.cardCho = new System.Windows.Forms.Panel();
            this.lblCardChoTitle = new System.Windows.Forms.Label();
            this.lblCardChoValue = new System.Windows.Forms.Label();
            this.lblCardChoSub = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnQuanTriNguoiDung = new System.Windows.Forms.Button();
            this.lblBtnNDDesc = new System.Windows.Forms.Label();
            this.btnQuanTriPhongGiuong = new System.Windows.Forms.Button();
            this.lblBtnPGDesc = new System.Windows.Forms.Label();
            this.pnlRecent = new System.Windows.Forms.Panel();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.timerClock = new System.Windows.Forms.Timer();
            this.pnlHeader.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.cardPhong.SuspendLayout();
            this.cardGiuong.SuspendLayout();
            this.cardNguoiDung.SuspendLayout();
            this.cardCho.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 64, 140);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 80;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);

            // lblWelcome
            this.lblWelcome.Text = "Xin chào, Quản trị hệ thống";
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 14);
            this.lblWelcome.Size = new System.Drawing.Size(400, 28);

            // lblSubtitle
            this.lblSubtitle.Text = "HomeStay Dorm — Hệ thống quản trị nội bộ";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(350, 20);

            // lblTime
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255);
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Location = new System.Drawing.Point(600, 44);
            this.lblTime.Size = new System.Drawing.Size(220, 20);

            // btnLogout
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnLogout.Size = new System.Drawing.Size(90, 32);
            this.btnLogout.Location = new System.Drawing.Point(870, 24);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // pnlStats
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.pnlStats.Padding = new System.Windows.Forms.Padding(20, 16, 20, 8);
            this.pnlStats.Controls.Add(this.cardPhong);
            this.pnlStats.Controls.Add(this.cardGiuong);
            this.pnlStats.Controls.Add(this.cardNguoiDung);
            this.pnlStats.Controls.Add(this.cardCho);
            this.pnlStats.Location = new System.Drawing.Point(0, 80);
            this.pnlStats.Size = new System.Drawing.Size(984, 126);

            // Helper: card style
            System.Drawing.Size cardSize = new System.Drawing.Size(210, 96);

            // cardPhong
            this.cardPhong.BackColor = System.Drawing.Color.White;
            this.cardPhong.Location = new System.Drawing.Point(20, 16);
            this.cardPhong.Size = cardSize;
            this.cardPhong.Controls.Add(this.lblCardPhongTitle);
            this.cardPhong.Controls.Add(this.lblCardPhongValue);
            this.cardPhong.Controls.Add(this.lblCardPhongSub);
            StyleCard(this.cardPhong);

            this.lblCardPhongTitle.Text = "Tổng số phòng";
            this.lblCardPhongValue.Text = "24";
            this.lblCardPhongSub.Text = "4 phòng đang bảo trì";
            StyleCardLabels(lblCardPhongTitle, lblCardPhongValue, lblCardPhongSub, System.Drawing.Color.FromArgb(30, 64, 140));

            // cardGiuong
            this.cardGiuong.BackColor = System.Drawing.Color.White;
            this.cardGiuong.Location = new System.Drawing.Point(248, 16);
            this.cardGiuong.Size = cardSize;
            this.cardGiuong.Controls.Add(this.lblCardGiuongTitle);
            this.cardGiuong.Controls.Add(this.lblCardGiuongValue);
            this.cardGiuong.Controls.Add(this.lblCardGiuongSub);
            StyleCard(this.cardGiuong);

            this.lblCardGiuongTitle.Text = "Tổng số giường";
            this.lblCardGiuongValue.Text = "86";
            this.lblCardGiuongSub.Text = "12 giường còn trống";
            StyleCardLabels(lblCardGiuongTitle, lblCardGiuongValue, lblCardGiuongSub, System.Drawing.Color.FromArgb(15, 110, 86));

            // cardNguoiDung
            this.cardNguoiDung.BackColor = System.Drawing.Color.White;
            this.cardNguoiDung.Location = new System.Drawing.Point(476, 16);
            this.cardNguoiDung.Size = cardSize;
            this.cardNguoiDung.Controls.Add(this.lblCardNguoiDungTitle);
            this.cardNguoiDung.Controls.Add(this.lblCardNguoiDungValue);
            this.cardNguoiDung.Controls.Add(this.lblCardNguoiDungSub);
            StyleCard(this.cardNguoiDung);

            this.lblCardNguoiDungTitle.Text = "Người dùng hệ thống";
            this.lblCardNguoiDungValue.Text = "9";
            this.lblCardNguoiDungSub.Text = "3 Sale · 3 Kế toán · 3 QL";
            StyleCardLabels(lblCardNguoiDungTitle, lblCardNguoiDungValue, lblCardNguoiDungSub, System.Drawing.Color.FromArgb(133, 79, 11));

            // cardCho
            this.cardCho.BackColor = System.Drawing.Color.White;
            this.cardCho.Location = new System.Drawing.Point(704, 16);
            this.cardCho.Size = cardSize;
            this.cardCho.Controls.Add(this.lblCardChoTitle);
            this.cardCho.Controls.Add(this.lblCardChoValue);
            this.cardCho.Controls.Add(this.lblCardChoSub);
            StyleCard(this.cardCho);

            this.lblCardChoTitle.Text = "Đặt cọc chờ xử lý";
            this.lblCardChoValue.Text = "5";
            this.lblCardChoSub.Text = "Trong 24h tới hết hạn";
            StyleCardLabels(lblCardChoTitle, lblCardChoValue, lblCardChoSub, System.Drawing.Color.FromArgb(163, 45, 45));

            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Controls.Add(this.btnQuanTriNguoiDung);
            this.pnlMenu.Controls.Add(this.lblBtnNDDesc);
            this.pnlMenu.Controls.Add(this.btnQuanTriPhongGiuong);
            this.pnlMenu.Controls.Add(this.lblBtnPGDesc);
            this.pnlMenu.Location = new System.Drawing.Point(0, 206);
            this.pnlMenu.Size = new System.Drawing.Size(984, 200);
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);

            this.lblMenuTitle.Text = "Chức năng quản trị";
            this.lblMenuTitle.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.lblMenuTitle.Location = new System.Drawing.Point(20, 12);
            this.lblMenuTitle.Size = new System.Drawing.Size(300, 26);

            // btnQuanTriNguoiDung
            this.btnQuanTriNguoiDung.Text = "👤  Quản trị người dùng";
            this.btnQuanTriNguoiDung.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.btnQuanTriNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnQuanTriNguoiDung.BackColor = System.Drawing.Color.FromArgb(30, 64, 140);
            this.btnQuanTriNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanTriNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnQuanTriNguoiDung.Size = new System.Drawing.Size(300, 60);
            this.btnQuanTriNguoiDung.Location = new System.Drawing.Point(20, 46);
            this.btnQuanTriNguoiDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanTriNguoiDung.Click += new System.EventHandler(this.btnQuanTriNguoiDung_Click);

            this.lblBtnNDDesc.Text = "Tạo, xem, cập nhật, xóa tài khoản Sale / Kế toán / Quản lý";
            this.lblBtnNDDesc.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblBtnNDDesc.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblBtnNDDesc.Location = new System.Drawing.Point(20, 114);
            this.lblBtnNDDesc.Size = new System.Drawing.Size(300, 20);

            // btnQuanTriPhongGiuong
            this.btnQuanTriPhongGiuong.Text = "🏠  Quản trị phòng & giường";
            this.btnQuanTriPhongGiuong.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.btnQuanTriPhongGiuong.ForeColor = System.Drawing.Color.White;
            this.btnQuanTriPhongGiuong.BackColor = System.Drawing.Color.FromArgb(15, 110, 86);
            this.btnQuanTriPhongGiuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanTriPhongGiuong.FlatAppearance.BorderSize = 0;
            this.btnQuanTriPhongGiuong.Size = new System.Drawing.Size(300, 60);
            this.btnQuanTriPhongGiuong.Location = new System.Drawing.Point(360, 46);
            this.btnQuanTriPhongGiuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanTriPhongGiuong.Click += new System.EventHandler(this.btnQuanTriPhongGiuong_Click);

            this.lblBtnPGDesc.Text = "Tạo, xem, cập nhật, xóa phòng và giường theo chi nhánh";
            this.lblBtnPGDesc.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblBtnPGDesc.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblBtnPGDesc.Location = new System.Drawing.Point(360, 114);
            this.lblBtnPGDesc.Size = new System.Drawing.Size(320, 20);

            // pnlRecent
            this.pnlRecent.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.pnlRecent.Controls.Add(this.lblRecentTitle);
            this.pnlRecent.Controls.Add(this.dgvRecent);
            this.pnlRecent.Location = new System.Drawing.Point(0, 390);
            this.pnlRecent.Size = new System.Drawing.Size(984, 220);
            this.pnlRecent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 10);

            this.lblRecentTitle.Text = "Hoạt động gần đây";
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.lblRecentTitle.Location = new System.Drawing.Point(20, 8);
            this.lblRecentTitle.Size = new System.Drawing.Size(250, 26);

            // dgvRecent
            this.dgvRecent.Location = new System.Drawing.Point(20, 38);
            this.dgvRecent.Size = new System.Drawing.Size(944, 170);
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.Font = new System.Drawing.Font("Segoe UI", 9);
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 64, 140);
            this.dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecent.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.dgvRecent.EnableHeadersVisualStyles = false;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // timerClock
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 430);
            this.Text = "Dashboard — Quản trị hệ thống | HomeStay Dorm";
            this.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlMenu);

            this.pnlHeader.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.cardPhong.ResumeLayout(false);
            this.cardGiuong.ResumeLayout(false);
            this.cardNguoiDung.ResumeLayout(false);
            this.cardCho.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);
        }

        private void StyleCard(System.Windows.Forms.Panel card)
        {
            card.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
        }

        private void StyleCardLabels(
            System.Windows.Forms.Label title,
            System.Windows.Forms.Label value,
            System.Windows.Forms.Label sub,
            System.Drawing.Color accentColor)
        {
            title.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            title.ForeColor = System.Drawing.Color.FromArgb(110, 120, 140);
            title.Location = new System.Drawing.Point(12, 10);
            title.Size = new System.Drawing.Size(190, 18);

            value.Font = new System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold);
            value.ForeColor = accentColor;
            value.Location = new System.Drawing.Point(12, 30);
            value.Size = new System.Drawing.Size(150, 40);

            sub.Font = new System.Drawing.Font("Segoe UI", 8f);
            sub.ForeColor = System.Drawing.Color.FromArgb(140, 150, 165);
            sub.Location = new System.Drawing.Point(12, 74);
            sub.Size = new System.Drawing.Size(190, 18);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel cardPhong;
        private System.Windows.Forms.Label lblCardPhongTitle;
        private System.Windows.Forms.Label lblCardPhongValue;
        private System.Windows.Forms.Label lblCardPhongSub;
        private System.Windows.Forms.Panel cardGiuong;
        private System.Windows.Forms.Label lblCardGiuongTitle;
        private System.Windows.Forms.Label lblCardGiuongValue;
        private System.Windows.Forms.Label lblCardGiuongSub;
        private System.Windows.Forms.Panel cardNguoiDung;
        private System.Windows.Forms.Label lblCardNguoiDungTitle;
        private System.Windows.Forms.Label lblCardNguoiDungValue;
        private System.Windows.Forms.Label lblCardNguoiDungSub;
        private System.Windows.Forms.Panel cardCho;
        private System.Windows.Forms.Label lblCardChoTitle;
        private System.Windows.Forms.Label lblCardChoValue;
        private System.Windows.Forms.Label lblCardChoSub;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnQuanTriNguoiDung;
        private System.Windows.Forms.Label lblBtnNDDesc;
        private System.Windows.Forms.Button btnQuanTriPhongGiuong;
        private System.Windows.Forms.Label lblBtnPGDesc;
        private System.Windows.Forms.Panel pnlRecent;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.Timer timerClock;
    }
}
