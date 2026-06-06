namespace WindowsFormsApp1
{
    partial class UI_23_QuanTriPhongGiuong
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
            this.btnBack = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.tabGiuong = new System.Windows.Forms.TabPage();

            // --- TAB PHONG controls ---
            this.pnlPhongToolbar = new System.Windows.Forms.Panel();
            this.txtSearchPhong = new System.Windows.Forms.TextBox();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cboTrangThaiPhong = new System.Windows.Forms.ComboBox();
            this.btnSearchPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.pnlPhongActions = new System.Windows.Forms.Panel();
            this.lblPhongCount = new System.Windows.Forms.Label();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnXemGiuong = new System.Windows.Forms.Button();

            // --- TAB GIUONG controls ---
            this.pnlGiuongToolbar = new System.Windows.Forms.Panel();
            this.txtSearchGiuong = new System.Windows.Forms.TextBox();
            this.cboPhongFilter = new System.Windows.Forms.ComboBox();
            this.cboTrangThaiGiuong = new System.Windows.Forms.ComboBox();
            this.btnSearchGiuong = new System.Windows.Forms.Button();
            this.btnThemGiuong = new System.Windows.Forms.Button();
            this.dgvGiuong = new System.Windows.Forms.DataGridView();
            this.pnlGiuongActions = new System.Windows.Forms.Panel();
            this.lblGiuongCount = new System.Windows.Forms.Label();
            this.btnSuaGiuong = new System.Windows.Forms.Button();
            this.btnXoaGiuong = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.tabGiuong.SuspendLayout();
            this.pnlPhongToolbar.SuspendLayout();
            this.pnlPhongActions.SuspendLayout();
            this.pnlGiuongToolbar.SuspendLayout();
            this.pnlGiuongActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiuong)).BeginInit();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(15, 110, 86);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 56;

            this.lblTitle.Text = "🏠  Quản trị phòng & giường";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Size = new System.Drawing.Size(420, 28);

            this.btnBack.Text = "← Dashboard";
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(8, 80, 60);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnBack.Size = new System.Drawing.Size(110, 30);
            this.btnBack.Location = new System.Drawing.Point(860, 13);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // tabControl
            this.tabControl.Location = new System.Drawing.Point(0, 56);
            this.tabControl.Size = new System.Drawing.Size(984, 580);
            this.tabControl.TabPages.Add(this.tabPhong);
            this.tabControl.TabPages.Add(this.tabGiuong);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // tabPhong
            this.tabPhong.Text = "  Phòng  ";
            this.tabPhong.BackColor = System.Drawing.Color.FromArgb(245, 247, 252);
            this.tabPhong.Controls.Add(this.pnlPhongToolbar);
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Controls.Add(this.pnlPhongActions);

            // pnlPhongToolbar
            this.pnlPhongToolbar.BackColor = System.Drawing.Color.FromArgb(245, 247, 252);
            this.pnlPhongToolbar.Controls.Add(this.txtSearchPhong);
            this.pnlPhongToolbar.Controls.Add(this.cboKhuVuc);
            this.pnlPhongToolbar.Controls.Add(this.cboLoaiPhong);
            this.pnlPhongToolbar.Controls.Add(this.cboTrangThaiPhong);
            this.pnlPhongToolbar.Controls.Add(this.btnSearchPhong);
            this.pnlPhongToolbar.Controls.Add(this.btnThemPhong);
            this.pnlPhongToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlPhongToolbar.Size = new System.Drawing.Size(984, 48);

            this.txtSearchPhong.Font = new System.Drawing.Font("Segoe UI", 9);
            this.txtSearchPhong.Location = new System.Drawing.Point(12, 12);
            this.txtSearchPhong.Size = new System.Drawing.Size(150, 23);
            //this.txtSearchPhong.PlaceholderText = "Mã phòng...";

            StyleCombo(this.cboKhuVuc, 174, 12, 110,
                new object[] { "Tất cả khu vực", "Nam", "Nữ", "Hỗn hợp" });
            StyleCombo(this.cboLoaiPhong, 296, 12, 120,
                new object[] { "Tất cả loại", "Nguyên căn", "Ghép" });
            StyleCombo(this.cboTrangThaiPhong, 428, 12, 120,
                new object[] { "Tất cả TT", "Trống", "Đã đặt cọc", "Đang ở", "Bảo trì" });

            this.btnSearchPhong.Text = "Tìm";
            StyleActionBtn(this.btnSearchPhong, 562, 12, 70, System.Drawing.Color.FromArgb(15, 110, 86));
            this.btnSearchPhong.Click += new System.EventHandler(this.btnSearchPhong_Click);

            this.btnThemPhong.Text = "+ Thêm phòng";
            StyleActionBtn(this.btnThemPhong, 820, 10, 140, System.Drawing.Color.FromArgb(15, 110, 86));
            this.btnThemPhong.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);

            // dgvPhong
            this.dgvPhong.Location = new System.Drawing.Point(0, 48);
            this.dgvPhong.Size = new System.Drawing.Size(984, 454);
            StyleGrid(this.dgvPhong, System.Drawing.Color.FromArgb(15, 110, 86));

            // pnlPhongActions
            this.pnlPhongActions.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.pnlPhongActions.Controls.Add(this.lblPhongCount);
            this.pnlPhongActions.Controls.Add(this.btnXemGiuong);
            this.pnlPhongActions.Controls.Add(this.btnSuaPhong);
            this.pnlPhongActions.Controls.Add(this.btnXoaPhong);
            this.pnlPhongActions.Location = new System.Drawing.Point(0, 502);
            this.pnlPhongActions.Size = new System.Drawing.Size(984, 46);

            this.lblPhongCount.Text = "Tổng: 0 phòng";
            StyleCountLabel(this.lblPhongCount, 16, 13);

            this.btnXemGiuong.Text = "🛏  Xem giường";
            StyleActionBtn(this.btnXemGiuong, 640, 9, 120, System.Drawing.Color.FromArgb(30, 64, 140));
            this.btnXemGiuong.Click += new System.EventHandler(this.btnXemGiuong_Click);

            this.btnSuaPhong.Text = "✏  Sửa phòng";
            StyleActionBtn(this.btnSuaPhong, 772, 9, 100, System.Drawing.Color.FromArgb(133, 79, 11));
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);

            this.btnXoaPhong.Text = "🗑  Xóa";
            StyleActionBtn(this.btnXoaPhong, 884, 9, 80, System.Drawing.Color.FromArgb(163, 45, 45));
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);

            // ── TAB GIƯỜNG ──────────────────────────────────────────────────────
            this.tabGiuong.Text = "  Giường  ";
            this.tabGiuong.BackColor = System.Drawing.Color.FromArgb(245, 247, 252);
            this.tabGiuong.Controls.Add(this.pnlGiuongToolbar);
            this.tabGiuong.Controls.Add(this.dgvGiuong);
            this.tabGiuong.Controls.Add(this.pnlGiuongActions);

            this.pnlGiuongToolbar.BackColor = System.Drawing.Color.FromArgb(245, 247, 252);
            this.pnlGiuongToolbar.Controls.Add(this.txtSearchGiuong);
            this.pnlGiuongToolbar.Controls.Add(this.cboPhongFilter);
            this.pnlGiuongToolbar.Controls.Add(this.cboTrangThaiGiuong);
            this.pnlGiuongToolbar.Controls.Add(this.btnSearchGiuong);
            this.pnlGiuongToolbar.Controls.Add(this.btnThemGiuong);
            this.pnlGiuongToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlGiuongToolbar.Size = new System.Drawing.Size(984, 48);

            this.txtSearchGiuong.Font = new System.Drawing.Font("Segoe UI", 9);
            this.txtSearchGiuong.Location = new System.Drawing.Point(12, 12);
            this.txtSearchGiuong.Size = new System.Drawing.Size(150, 23);
            //this.txtSearchGiuong.PlaceholderText = "Mã giường...";

            StyleCombo(this.cboPhongFilter, 174, 12, 150,
                new object[] { "Tất cả phòng", "P101", "P102", "P201", "P202", "P301" });
            StyleCombo(this.cboTrangThaiGiuong, 336, 12, 130,
                new object[] { "Tất cả TT", "Trống", "Đã đặt cọc", "Đang ở", "Bảo trì" });

            this.btnSearchGiuong.Text = "Tìm";
            StyleActionBtn(this.btnSearchGiuong, 478, 12, 70, System.Drawing.Color.FromArgb(15, 110, 86));
            this.btnSearchGiuong.Click += new System.EventHandler(this.btnSearchGiuong_Click);

            this.btnThemGiuong.Text = "+ Thêm giường";
            StyleActionBtn(this.btnThemGiuong, 820, 10, 140, System.Drawing.Color.FromArgb(15, 110, 86));
            this.btnThemGiuong.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnThemGiuong.Click += new System.EventHandler(this.btnThemGiuong_Click);

            this.dgvGiuong.Location = new System.Drawing.Point(0, 48);
            this.dgvGiuong.Size = new System.Drawing.Size(984, 454);
            StyleGrid(this.dgvGiuong, System.Drawing.Color.FromArgb(15, 110, 86));

            this.pnlGiuongActions.BackColor = System.Drawing.Color.FromArgb(240, 244, 250);
            this.pnlGiuongActions.Controls.Add(this.lblGiuongCount);
            this.pnlGiuongActions.Controls.Add(this.btnSuaGiuong);
            this.pnlGiuongActions.Controls.Add(this.btnXoaGiuong);
            this.pnlGiuongActions.Location = new System.Drawing.Point(0, 502);
            this.pnlGiuongActions.Size = new System.Drawing.Size(984, 46);

            this.lblGiuongCount.Text = "Tổng: 0 giường";
            StyleCountLabel(this.lblGiuongCount, 16, 13);

            this.btnSuaGiuong.Text = "✏  Sửa giường";
            StyleActionBtn(this.btnSuaGiuong, 772, 9, 100, System.Drawing.Color.FromArgb(133, 79, 11));
            this.btnSuaGiuong.Click += new System.EventHandler(this.btnSuaGiuong_Click);

            this.btnXoaGiuong.Text = "🗑  Xóa";
            StyleActionBtn(this.btnXoaGiuong, 884, 9, 80, System.Drawing.Color.FromArgb(163, 45, 45));
            this.btnXoaGiuong.Click += new System.EventHandler(this.btnXoaGiuong_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 640);
            this.Text = "Quản trị phòng & giường | HomeStay Dorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tabControl);

            this.pnlHeader.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabGiuong.ResumeLayout(false);
            this.pnlPhongToolbar.ResumeLayout(false);
            this.pnlPhongActions.ResumeLayout(false);
            this.pnlGiuongToolbar.ResumeLayout(false);
            this.pnlGiuongActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiuong)).EndInit();
            this.ResumeLayout(false);
        }

        private void StyleGrid(System.Windows.Forms.DataGridView dgv, System.Drawing.Color headerColor)
        {
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.Font = new System.Drawing.Font("Segoe UI", 9);
            dgv.RowTemplate.Height = 32;
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }

        private void StyleCombo(System.Windows.Forms.ComboBox cbo, int x, int y, int w, object[] items)
        {
            cbo.Font = new System.Drawing.Font("Segoe UI", 9);
            cbo.Location = new System.Drawing.Point(x, y);
            cbo.Size = new System.Drawing.Size(w, 23);
            cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbo.Items.AddRange(items);
            cbo.SelectedIndex = 0;
        }

        private void StyleActionBtn(System.Windows.Forms.Button btn, int x, int y, int w, System.Drawing.Color bg)
        {
            btn.Font = new System.Drawing.Font("Segoe UI", 9);
            btn.BackColor = bg;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(w, 28);
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void StyleCountLabel(System.Windows.Forms.Label lbl, int x, int y)
        {
            lbl.Font = new System.Drawing.Font("Segoe UI", 9);
            lbl.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(200, 20);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabGiuong;

        private System.Windows.Forms.Panel pnlPhongToolbar;
        private System.Windows.Forms.TextBox txtSearchPhong;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.ComboBox cboTrangThaiPhong;
        private System.Windows.Forms.Button btnSearchPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Panel pnlPhongActions;
        private System.Windows.Forms.Label lblPhongCount;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnXemGiuong;

        private System.Windows.Forms.Panel pnlGiuongToolbar;
        private System.Windows.Forms.TextBox txtSearchGiuong;
        private System.Windows.Forms.ComboBox cboPhongFilter;
        private System.Windows.Forms.ComboBox cboTrangThaiGiuong;
        private System.Windows.Forms.Button btnSearchGiuong;
        private System.Windows.Forms.Button btnThemGiuong;
        private System.Windows.Forms.DataGridView dgvGiuong;
        private System.Windows.Forms.Panel pnlGiuongActions;
        private System.Windows.Forms.Label lblGiuongCount;
        private System.Windows.Forms.Button btnSuaGiuong;
        private System.Windows.Forms.Button btnXoaGiuong;
    }
}