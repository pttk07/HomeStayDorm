namespace WindowsFormsApp1
{
    partial class UI_7b_TinhToanTienCoc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpPhieuThue;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Button btnChonPhieu;
        private System.Windows.Forms.Label lblMaPhieu;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtKhachHang;

        // Thêm GroupBox và DataGridView cho Bảng giá
        private System.Windows.Forms.GroupBox grpBangGia;
        private System.Windows.Forms.DataGridView dgvBangGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMucGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTyLeCoc;

        private System.Windows.Forms.GroupBox grpTinhToan;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMucGia;
        private System.Windows.Forms.TextBox txtMucGia;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;

        private System.Windows.Forms.Button btnXacNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpPhieuThue = new System.Windows.Forms.GroupBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnChonPhieu = new System.Windows.Forms.Button();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.lblMaPhieu = new System.Windows.Forms.Label();
            this.grpBangGia = new System.Windows.Forms.GroupBox();
            this.dgvBangGia = new System.Windows.Forms.DataGridView();
            this.colLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMucGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTyLeCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTinhToan = new System.Windows.Forms.GroupBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtMucGia = new System.Windows.Forms.TextBox();
            this.lblMucGia = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpPhieuThue.SuspendLayout();
            this.grpBangGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).BeginInit();
            this.grpTinhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPhieuThue
            // 
            this.grpPhieuThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhieuThue.Controls.Add(this.txtKhachHang);
            this.grpPhieuThue.Controls.Add(this.lblKhachHang);
            this.grpPhieuThue.Controls.Add(this.btnChonPhieu);
            this.grpPhieuThue.Controls.Add(this.txtMaPhieu);
            this.grpPhieuThue.Controls.Add(this.lblMaPhieu);
            this.grpPhieuThue.Location = new System.Drawing.Point(20, 20);
            this.grpPhieuThue.Name = "grpPhieuThue";
            this.grpPhieuThue.Size = new System.Drawing.Size(826, 120);
            this.grpPhieuThue.TabIndex = 0;
            this.grpPhieuThue.TabStop = false;
            this.grpPhieuThue.Text = "1. Thông tin phiếu thuê";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhachHang.Location = new System.Drawing.Point(152, 72);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(630, 29);
            this.txtKhachHang.TabIndex = 4;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(20, 75);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(105, 23);
            this.lblKhachHang.TabIndex = 3;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // btnChonPhieu
            // 
            this.btnChonPhieu.Location = new System.Drawing.Point(491, 31);
            this.btnChonPhieu.Name = "btnChonPhieu";
            this.btnChonPhieu.Size = new System.Drawing.Size(99, 27);
            this.btnChonPhieu.TabIndex = 2;
            this.btnChonPhieu.Text = "Chọn...";
            this.btnChonPhieu.UseVisualStyleBackColor = true;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(152, 32);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(319, 29);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // lblMaPhieu
            // 
            this.lblMaPhieu.AutoSize = true;
            this.lblMaPhieu.Location = new System.Drawing.Point(20, 35);
            this.lblMaPhieu.Name = "lblMaPhieu";
            this.lblMaPhieu.Size = new System.Drawing.Size(126, 23);
            this.lblMaPhieu.TabIndex = 0;
            this.lblMaPhieu.Text = "Mã phiếu thuê:";
            // 
            // grpBangGia
            // 
            this.grpBangGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBangGia.Controls.Add(this.dgvBangGia);
            this.grpBangGia.Location = new System.Drawing.Point(20, 155);
            this.grpBangGia.Name = "grpBangGia";
            this.grpBangGia.Size = new System.Drawing.Size(826, 140);
            this.grpBangGia.TabIndex = 3;
            this.grpBangGia.TabStop = false;
            this.grpBangGia.Text = "2. Bảng giá";
            // 
            // dgvBangGia
            // 
            this.dgvBangGia.AllowUserToAddRows = false;
            this.dgvBangGia.AllowUserToDeleteRows = false;
            this.dgvBangGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangGia.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoaiPhong,
            this.colMucGia,
            this.colTyLeCoc});
            this.dgvBangGia.Location = new System.Drawing.Point(15, 25);
            this.dgvBangGia.Name = "dgvBangGia";
            this.dgvBangGia.ReadOnly = true;
            this.dgvBangGia.RowHeadersVisible = false;
            this.dgvBangGia.RowHeadersWidth = 51;
            this.dgvBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangGia.Size = new System.Drawing.Size(791, 100);
            this.dgvBangGia.TabIndex = 0;
            // 
            // colLoaiPhong
            // 
            this.colLoaiPhong.HeaderText = "Loại Phòng / Giường";
            this.colLoaiPhong.MinimumWidth = 6;
            this.colLoaiPhong.Name = "colLoaiPhong";
            this.colLoaiPhong.ReadOnly = true;
            // 
            // colMucGia
            // 
            this.colMucGia.HeaderText = "Mức Giá Thuê (Tháng)";
            this.colMucGia.MinimumWidth = 6;
            this.colMucGia.Name = "colMucGia";
            this.colMucGia.ReadOnly = true;
            // 
            // colTyLeCoc
            // 
            this.colTyLeCoc.HeaderText = "Tỷ Lệ Cọc Quy Định";
            this.colTyLeCoc.MinimumWidth = 6;
            this.colTyLeCoc.Name = "colTyLeCoc";
            this.colTyLeCoc.ReadOnly = true;
            // 
            // grpTinhToan
            // 
            this.grpTinhToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTinhToan.Controls.Add(this.txtTienCoc);
            this.grpTinhToan.Controls.Add(this.lblTienCoc);
            this.grpTinhToan.Controls.Add(this.txtMucGia);
            this.grpTinhToan.Controls.Add(this.lblMucGia);
            this.grpTinhToan.Controls.Add(this.txtMaPhong);
            this.grpTinhToan.Controls.Add(this.lblMaPhong);
            this.grpTinhToan.Location = new System.Drawing.Point(20, 310);
            this.grpTinhToan.Name = "grpTinhToan";
            this.grpTinhToan.Size = new System.Drawing.Size(826, 160);
            this.grpTinhToan.TabIndex = 1;
            this.grpTinhToan.TabStop = false;
            this.grpTinhToan.Text = "3. Tính tiền cọc";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienCoc.BackColor = System.Drawing.Color.White;
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTienCoc.Location = new System.Drawing.Point(146, 110);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(660, 32);
            this.txtTienCoc.TabIndex = 5;
            this.txtTienCoc.Text = "0 VNĐ";
            this.txtTienCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienCoc.Location = new System.Drawing.Point(20, 115);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(120, 23);
            this.lblTienCoc.TabIndex = 4;
            this.lblTienCoc.Text = "SỐ TIỀN CỌC:";
            // 
            // txtMucGia
            // 
            this.txtMucGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMucGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMucGia.Location = new System.Drawing.Point(146, 72);
            this.txtMucGia.Name = "txtMucGia";
            this.txtMucGia.ReadOnly = true;
            this.txtMucGia.Size = new System.Drawing.Size(660, 29);
            this.txtMucGia.TabIndex = 3;
            // 
            // lblMucGia
            // 
            this.lblMucGia.AutoSize = true;
            this.lblMucGia.Location = new System.Drawing.Point(20, 75);
            this.lblMucGia.Name = "lblMucGia";
            this.lblMucGia.Size = new System.Drawing.Size(75, 23);
            this.lblMucGia.TabIndex = 2;
            this.lblMucGia.Text = "Mức giá:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaPhong.Location = new System.Drawing.Point(146, 32);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(660, 29);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(20, 35);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(93, 23);
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(596, 490);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(250, 40);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận && Xuất yêu cầu thanh toán";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // TinhToanTienCoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 550);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.grpTinhToan);
            this.Controls.Add(this.grpBangGia);
            this.Controls.Add(this.grpPhieuThue);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TinhToanTienCoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Toán Tiền Cọc";
            this.grpPhieuThue.ResumeLayout(false);
            this.grpPhieuThue.PerformLayout();
            this.grpBangGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).EndInit();
            this.grpTinhToan.ResumeLayout(false);
            this.grpTinhToan.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}