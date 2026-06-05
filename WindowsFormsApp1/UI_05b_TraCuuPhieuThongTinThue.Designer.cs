namespace WindowsFormsApp1
{
    partial class TraCuuPhieuThongTinThue
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieu;
        private System.Windows.Forms.Button btnChonPhieu;

        // Khai báo các cột cứng
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;

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
            this.dgvDanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.colMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChonPhieu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(20, 25);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(233, 23);
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Nhập mã phiếu, tên KH:";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(220, 22);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(475, 29);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(715, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // dgvDanhSachPhieu
            // 
            this.dgvDanhSachPhieu.AllowUserToAddRows = false;
            this.dgvDanhSachPhieu.AllowUserToDeleteRows = false;
            this.dgvDanhSachPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieu,
            this.colTenKH,
            this.colSDT,
            this.colMaPhong,
            this.colNgayThue,
            this.colTrangThai});
            this.dgvDanhSachPhieu.Location = new System.Drawing.Point(23, 70);
            this.dgvDanhSachPhieu.Name = "dgvDanhSachPhieu";
            this.dgvDanhSachPhieu.ReadOnly = true;
            this.dgvDanhSachPhieu.RowHeadersVisible = false;
            this.dgvDanhSachPhieu.RowHeadersWidth = 51;
            this.dgvDanhSachPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieu.Size = new System.Drawing.Size(782, 325);
            this.dgvDanhSachPhieu.TabIndex = 3;
            // 
            // colMaPhieu
            // 
            this.colMaPhieu.HeaderText = "Mã Phiếu";
            this.colMaPhieu.MinimumWidth = 6;
            this.colMaPhieu.Name = "colMaPhieu";
            this.colMaPhieu.ReadOnly = true;
            // 
            // colTenKH
            // 
            this.colTenKH.HeaderText = "Tên Khách Hàng";
            this.colTenKH.MinimumWidth = 6;
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.ReadOnly = true;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "Số Điện Thoại";
            this.colSDT.MinimumWidth = 6;
            this.colSDT.Name = "colSDT";
            this.colSDT.ReadOnly = true;
            // 
            // colMaPhong
            // 
            this.colMaPhong.HeaderText = "Mã Phòng";
            this.colMaPhong.MinimumWidth = 6;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            // 
            // colNgayThue
            // 
            this.colNgayThue.HeaderText = "Ngày Thuê";
            this.colNgayThue.MinimumWidth = 6;
            this.colNgayThue.Name = "colNgayThue";
            this.colNgayThue.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // btnChonPhieu
            // 
            this.btnChonPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonPhieu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChonPhieu.FlatAppearance.BorderSize = 0;
            this.btnChonPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonPhieu.ForeColor = System.Drawing.Color.White;
            this.btnChonPhieu.Location = new System.Drawing.Point(685, 410);
            this.btnChonPhieu.Name = "btnChonPhieu";
            this.btnChonPhieu.Size = new System.Drawing.Size(120, 35);
            this.btnChonPhieu.TabIndex = 4;
            this.btnChonPhieu.Text = "Chọn phiếu này";
            this.btnChonPhieu.UseVisualStyleBackColor = false;
            // 
            // TraCuuPhieuThongTinThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 466);
            this.Controls.Add(this.btnChonPhieu);
            this.Controls.Add(this.dgvDanhSachPhieu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.lblTuKhoa);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TraCuuPhieuThongTinThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra Cứu Phiếu Thông Tin Thuê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}