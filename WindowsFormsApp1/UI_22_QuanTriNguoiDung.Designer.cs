namespace WindowsFormsApp1
{
    partial class UI_22_QuanTriNguoiDung
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboNhomQuyen = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 64, 140);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 56;

            // lblTitle
            this.lblTitle.Text = "👤  Quản trị người dùng";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTitle.Size = new System.Drawing.Size(380, 28);

            // btnBack
            this.btnBack.Text = "← Dashboard";
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(20, 50, 110);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnBack.Size = new System.Drawing.Size(110, 30);
            this.btnBack.Location = new System.Drawing.Point(860, 13);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(245, 247, 252);
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.cboNhomQuyen);
            this.pnlToolbar.Controls.Add(this.cboTrangThai);
            this.pnlToolbar.Controls.Add(this.btnSearch);
            this.pnlToolbar.Controls.Add(this.btnThem);
            this.pnlToolbar.Location = new System.Drawing.Point(0, 56);
            this.pnlToolbar.Size = new System.Drawing.Size(984, 52);
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);

            // lblSearch
            this.lblSearch.Text = "Tìm kiếm:";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(70, 80, 100);
            this.lblSearch.Location = new System.Drawing.Point(12, 16);
            this.lblSearch.Size = new System.Drawing.Size(70, 20);

            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9);
            this.txtSearch.Location = new System.Drawing.Point(82, 13);
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            //this.txtSearch.PlaceholderText = "Họ tên hoặc email...";

            // cboNhomQuyen
            this.cboNhomQuyen.Font = new System.Drawing.Font("Segoe UI", 9);
            this.cboNhomQuyen.Location = new System.Drawing.Point(314, 13);
            this.cboNhomQuyen.Size = new System.Drawing.Size(130, 23);
            this.cboNhomQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhomQuyen.Items.AddRange(new object[] { "Tất cả nhóm", "Sale", "Kế toán", "Quản lý", "Quản trị hệ thống" });
            this.cboNhomQuyen.SelectedIndex = 0;

            // cboTrangThai
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9);
            this.cboTrangThai.Location = new System.Drawing.Point(456, 13);
            this.cboTrangThai.Size = new System.Drawing.Size(130, 23);
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang hoạt động", "Đã khóa" });
            this.cboTrangThai.SelectedIndex = 0;

            // btnSearch
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(30, 64, 140);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Location = new System.Drawing.Point(598, 13);
            this.btnSearch.Size = new System.Drawing.Size(88, 26);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnThem
            this.btnThem.Text = "+ Thêm người dùng";
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(15, 110, 86);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new System.Drawing.Point(824, 11);
            this.btnThem.Size = new System.Drawing.Size(148, 30);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // dgvNguoiDung
            this.dgvNguoiDung.Location = new System.Drawing.Point(0, 108);
            this.dgvNguoiDung.Size = new System.Drawing.Size(984, 450);
            this.dgvNguoiDung.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNguoiDung.RowHeadersVisible = false;
            this.dgvNguoiDung.AllowUserToAddRows = false;
            this.dgvNguoiDung.AllowUserToDeleteRows = false;
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9);
            this.dgvNguoiDung.RowTemplate.Height = 32;
            this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 64, 140);
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            this.dgvNguoiDung.EnableHeadersVisualStyles = false;
            this.dgvNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguoiDung.MultiSelect = false;

            // pnlActions
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(245, 247, 252);
            this.pnlActions.Controls.Add(this.lblCount);
            this.pnlActions.Controls.Add(this.btnChinhSua);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnDoiMatKhau);
            this.pnlActions.Location = new System.Drawing.Point(0, 558);
            this.pnlActions.Size = new System.Drawing.Size(984, 48);

            // lblCount
            this.lblCount.Text = "Tổng: 0 người dùng";
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130);
            this.lblCount.Location = new System.Drawing.Point(16, 14);
            this.lblCount.Size = new System.Drawing.Size(200, 20);

            // btnChinhSua
            this.btnChinhSua.Text = "✏  Chỉnh sửa";
            this.btnChinhSua.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnChinhSua.BackColor = System.Drawing.Color.FromArgb(133, 79, 11);
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.Location = new System.Drawing.Point(640, 10);
            this.btnChinhSua.Size = new System.Drawing.Size(100, 28);
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);

            // btnDoiMatKhau
            this.btnDoiMatKhau.Text = "🔑 Đặt lại MK";
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(60, 100, 170);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(754, 10);
            this.btnDoiMatKhau.Size = new System.Drawing.Size(110, 28);
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);

            // btnXoa
            this.btnXoa.Text = "🗑  Xóa";
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(163, 45, 45);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Location = new System.Drawing.Point(878, 10);
            this.btnXoa.Size = new System.Drawing.Size(88, 28);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 614);
            this.Text = "Quản trị người dùng | HomeStay Dorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.dgvNguoiDung);
            this.Controls.Add(this.pnlActions);

            this.pnlHeader.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboNhomQuyen;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}