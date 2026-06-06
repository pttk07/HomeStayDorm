namespace WindowsFormsApp1
{
    partial class UI_8_Tính_khoản_phát_sinh
    {
        private System.ComponentModel.IContainer components = null;

        // Group 1: Thông tin hợp đồng & cọc
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.TextBox txtNgayTra;

        // Group 2: Thêm thủ công (Dòng phụ A5)
        private System.Windows.Forms.GroupBox grpThemThuCong;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoaiPhatSinh;
        private System.Windows.Forms.Label lblSoTienNhap;
        private System.Windows.Forms.TextBox txtSoTienNhap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThemKhoan;

        // Group 3: Bảng danh sách
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguon;

        // Tổng kết
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label valTongTien;
        private System.Windows.Forms.Button btnXacNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.grpThemThuCong = new System.Windows.Forms.GroupBox();
            this.btnThemKhoan = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtSoTienNhap = new System.Windows.Forms.TextBox();
            this.lblSoTienNhap = new System.Windows.Forms.Label();
            this.cboLoaiPhatSinh = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvPhatSinh = new System.Windows.Forms.DataGridView();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.valTongTien = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpThemThuCong.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.txtNgayTra);
            this.grpThongTin.Controls.Add(this.lblNgayTra);
            this.grpThongTin.Controls.Add(this.txtTienCoc);
            this.grpThongTin.Controls.Add(this.lblTienCoc);
            this.grpThongTin.Controls.Add(this.txtKhachHang);
            this.grpThongTin.Controls.Add(this.lblKhachHang);
            this.grpThongTin.Controls.Add(this.txtMaHD);
            this.grpThongTin.Controls.Add(this.lblMaHD);
            this.grpThongTin.Location = new System.Drawing.Point(20, 15);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(750, 100);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "1. Thông tin hợp đồng & trả phòng";
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgayTra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNgayTra.Location = new System.Drawing.Point(395, 62);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.ReadOnly = true;
            this.txtNgayTra.Size = new System.Drawing.Size(349, 29);
            this.txtNgayTra.TabIndex = 7;
            this.txtNgayTra.Text = "05/06/2026";
            this.txtNgayTra.TextChanged += new System.EventHandler(this.txtNgayTra_TextChanged);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(290, 65);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(80, 23);
            this.lblNgayTra.TabIndex = 6;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.Location = new System.Drawing.Point(134, 63);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(150, 29);
            this.txtTienCoc.TabIndex = 5;
            this.txtTienCoc.Text = "5,000,000 VNĐ";
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Location = new System.Drawing.Point(20, 65);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(110, 23);
            this.lblTienCoc.TabIndex = 4;
            this.lblTienCoc.Text = "Tiền cọc gốc:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhachHang.Location = new System.Drawing.Point(395, 27);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(349, 29);
            this.txtKhachHang.TabIndex = 3;
            this.txtKhachHang.Text = "Nguyễn Văn Demo";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(290, 30);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(105, 23);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaHD.Location = new System.Drawing.Point(134, 28);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(150, 29);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.Text = "HD2026-001";
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(20, 30);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(118, 23);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hợp đồng:";
            // 
            // grpThemThuCong
            // 
            this.grpThemThuCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThemThuCong.Controls.Add(this.btnThemKhoan);
            this.grpThemThuCong.Controls.Add(this.txtGhiChu);
            this.grpThemThuCong.Controls.Add(this.lblGhiChu);
            this.grpThemThuCong.Controls.Add(this.txtSoTienNhap);
            this.grpThemThuCong.Controls.Add(this.lblSoTienNhap);
            this.grpThemThuCong.Controls.Add(this.cboLoaiPhatSinh);
            this.grpThemThuCong.Controls.Add(this.lblLoai);
            this.grpThemThuCong.Location = new System.Drawing.Point(20, 130);
            this.grpThemThuCong.Name = "grpThemThuCong";
            this.grpThemThuCong.Size = new System.Drawing.Size(750, 80);
            this.grpThemThuCong.TabIndex = 1;
            this.grpThemThuCong.TabStop = false;
            this.grpThemThuCong.Text = "2. Thêm khoản phát sinh thủ công";
            // 
            // btnThemKhoan
            // 
            this.btnThemKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThemKhoan.FlatAppearance.BorderSize = 0;
            this.btnThemKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoan.ForeColor = System.Drawing.Color.White;
            this.btnThemKhoan.Location = new System.Drawing.Point(655, 30);
            this.btnThemKhoan.Name = "btnThemKhoan";
            this.btnThemKhoan.Size = new System.Drawing.Size(75, 29);
            this.btnThemKhoan.TabIndex = 6;
            this.btnThemKhoan.Text = "+ Thêm";
            this.btnThemKhoan.UseVisualStyleBackColor = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(470, 32);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(175, 29);
            this.txtGhiChu.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(395, 35);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(73, 23);
            this.lblGhiChu.TabIndex = 4;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtSoTienNhap
            // 
            this.txtSoTienNhap.Location = new System.Drawing.Point(274, 32);
            this.txtSoTienNhap.Name = "txtSoTienNhap";
            this.txtSoTienNhap.Size = new System.Drawing.Size(111, 29);
            this.txtSoTienNhap.TabIndex = 3;
            // 
            // lblSoTienNhap
            // 
            this.lblSoTienNhap.AutoSize = true;
            this.lblSoTienNhap.Location = new System.Drawing.Point(210, 35);
            this.lblSoTienNhap.Name = "lblSoTienNhap";
            this.lblSoTienNhap.Size = new System.Drawing.Size(67, 23);
            this.lblSoTienNhap.TabIndex = 2;
            this.lblSoTienNhap.Text = "Số tiền:";
            // 
            // cboLoaiPhatSinh
            // 
            this.cboLoaiPhatSinh.FormattingEnabled = true;
            this.cboLoaiPhatSinh.Items.AddRange(new object[] {
            "Phí vệ sinh",
            "Sửa chữa tài sản",
            "Phí trễ hạn",
            "Mất thẻ từ",
            "Khác"});
            this.cboLoaiPhatSinh.Location = new System.Drawing.Point(60, 32);
            this.cboLoaiPhatSinh.Name = "cboLoaiPhatSinh";
            this.cboLoaiPhatSinh.Size = new System.Drawing.Size(140, 29);
            this.cboLoaiPhatSinh.TabIndex = 1;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(20, 35);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(45, 23);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvPhatSinh);
            this.grpDanhSach.Location = new System.Drawing.Point(20, 230);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(750, 230);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "3. Chi tiết các khoản phát sinh";
            // 
            // dgvPhatSinh
            // 
            this.dgvPhatSinh.AllowUserToAddRows = false;
            this.dgvPhatSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhatSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhatSinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhatSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhatSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoai,
            this.colSoTien,
            this.colGhiChu,
            this.colNguon});
            this.dgvPhatSinh.Location = new System.Drawing.Point(15, 25);
            this.dgvPhatSinh.Name = "dgvPhatSinh";
            this.dgvPhatSinh.RowHeadersVisible = false;
            this.dgvPhatSinh.RowHeadersWidth = 51;
            this.dgvPhatSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhatSinh.Size = new System.Drawing.Size(715, 185);
            this.dgvPhatSinh.TabIndex = 0;
            // 
            // colLoai
            // 
            this.colLoai.HeaderText = "Khoản phát sinh";
            this.colLoai.MinimumWidth = 6;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colSoTien
            // 
            this.colSoTien.HeaderText = "Số tiền (VNĐ)";
            this.colSoTien.MinimumWidth = 6;
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.HeaderText = "Chi tiết / Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            // 
            // colNguon
            // 
            this.colNguon.HeaderText = "Nguồn ghi nhận";
            this.colNguon.MinimumWidth = 6;
            this.colNguon.Name = "colNguon";
            this.colNguon.ReadOnly = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(340, 487);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(222, 28);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "TỔNG TIỀN PHÁT SINH: ";
            // 
            // valTongTien
            // 
            this.valTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.valTongTien.AutoSize = true;
            this.valTongTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTongTien.ForeColor = System.Drawing.Color.Firebrick;
            this.valTongTien.Location = new System.Drawing.Point(580, 477);
            this.valTongTien.Name = "valTongTien";
            this.valTongTien.Size = new System.Drawing.Size(202, 41);
            this.valTongTien.TabIndex = 4;
            this.valTongTien.Text = "650,000 VNĐ";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(454, 520);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(316, 40);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác nhận && Chuyển sang Khấu trừ ➔";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // UI_8_Tính_khoản_phát_sinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 581);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.valTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpThemThuCong);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UI_8_Tính_khoản_phát_sinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm tra & Tính khoản phát sinh";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpThemThuCong.ResumeLayout(false);
            this.grpThemThuCong.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
