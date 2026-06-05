namespace WindowsFormsApp1
{
    partial class UI_08_TraCuuHopDong
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Control
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;

        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvHopDong;

        // Khai báo các cột của bảng
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;

        private System.Windows.Forms.Button btnChonHopDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChonHopDong = new System.Windows.Forms.Button();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(20, 25);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(222, 23);
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Nhập mã hợp đồng, tên KH";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(248, 22);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(412, 29);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(670, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvHopDong);
            this.grpDanhSach.Location = new System.Drawing.Point(20, 70);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(750, 380);
            this.grpDanhSach.TabIndex = 3;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách hợp đồng";
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            this.dgvHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colTenKH,
            this.colPhong,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colTienCoc,
            this.colTrangThai});
            this.dgvHopDong.Location = new System.Drawing.Point(15, 25);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersVisible = false;
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(720, 340);
            this.dgvHopDong.TabIndex = 0;
            // 
            // colMaHD
            // 
            this.colMaHD.HeaderText = "Mã Hợp Đồng";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Khách Hàng";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colPhong
            // 
            this.colPhong.HeaderText = "Phòng/Giường";
            this.colPhong.MinimumWidth = 6;
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.colNgayBatDau.MinimumWidth = 6;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.colNgayKetThuc.MinimumWidth = 6;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.ReadOnly = true;
            // 
            // colTienCoc
            // 
            this.colTienCoc.HeaderText = "Tiền Cọc (VNĐ)";
            this.colTienCoc.MinimumWidth = 6;
            this.colTienCoc.Name = "colTienCoc";
            this.colTienCoc.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // btnChonHopDong
            // 
            this.btnChonHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonHopDong.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChonHopDong.FlatAppearance.BorderSize = 0;
            this.btnChonHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonHopDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonHopDong.ForeColor = System.Drawing.Color.White;
            this.btnChonHopDong.Location = new System.Drawing.Point(618, 465);
            this.btnChonHopDong.Name = "btnChonHopDong";
            this.btnChonHopDong.Size = new System.Drawing.Size(152, 40);
            this.btnChonHopDong.TabIndex = 4;
            this.btnChonHopDong.Text = "Tra cứu";
            this.btnChonHopDong.UseVisualStyleBackColor = false;
            // 
            // UI_9_TraCuuHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 520);
            this.Controls.Add(this.btnChonHopDong);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.lblTuKhoa);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UI_9_TraCuuHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Hợp Đồng (Kế Toán)";
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}