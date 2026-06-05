namespace WindowsFormsApp1
{
    partial class UI_09_LapBangDoiSoat
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;

        // Group 1: Thông tin chung
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.TextBox txtThoiGian;

        // Group 2: Các khoản phát sinh (Khấu trừ)
        private System.Windows.Forms.GroupBox grpPhatSinh;
        private System.Windows.Forms.DataGridView dgvPhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;

        // Group 3: Tổng kết & Ghi chú
        private System.Windows.Forms.GroupBox grpTongKet;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label lblTienKhauTru;
        private System.Windows.Forms.TextBox txtTienKhauTru;
        private System.Windows.Forms.Label lblTienHoan;
        private System.Windows.Forms.Label valTienHoan;

        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        // Nút chức năng
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grpPhatSinh = new System.Windows.Forms.GroupBox();
            this.dgvPhatSinh = new System.Windows.Forms.DataGridView();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTongKet = new System.Windows.Forms.GroupBox();
            this.valTienHoan = new System.Windows.Forms.Label();
            this.lblTienHoan = new System.Windows.Forms.Label();
            this.txtTienKhauTru = new System.Windows.Forms.TextBox();
            this.lblTienKhauTru = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpPhatSinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).BeginInit();
            this.grpTongKet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(784, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BẢNG ĐỐI SOÁT HOÀN CỌC";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.txtThoiGian);
            this.grpThongTin.Controls.Add(this.lblThoiGian);
            this.grpThongTin.Controls.Add(this.txtPhong);
            this.grpThongTin.Controls.Add(this.lblPhong);
            this.grpThongTin.Controls.Add(this.txtMaHD);
            this.grpThongTin.Controls.Add(this.lblMaHD);
            this.grpThongTin.Controls.Add(this.txtKhachHang);
            this.grpThongTin.Controls.Add(this.lblKhachHang);
            this.grpThongTin.Location = new System.Drawing.Point(20, 50);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(744, 110);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "1. Thông tin hợp đồng";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtThoiGian.Location = new System.Drawing.Point(496, 72);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.ReadOnly = true;
            this.txtThoiGian.Size = new System.Drawing.Size(224, 29);
            this.txtThoiGian.TabIndex = 0;
            this.txtThoiGian.Text = "01/01/2026 - 05/06/2026";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(400, 75);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(90, 23);
            this.lblThoiGian.TabIndex = 1;
            this.lblThoiGian.Text = "TG lưu trú:";
            // 
            // txtPhong
            // 
            this.txtPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhong.Location = new System.Drawing.Point(153, 72);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(217, 29);
            this.txtPhong.TabIndex = 2;
            this.txtPhong.Text = "P101";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(20, 75);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(127, 23);
            this.lblPhong.TabIndex = 3;
            this.lblPhong.Text = "Phòng/Giường:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaHD.Location = new System.Drawing.Point(496, 32);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(224, 29);
            this.txtMaHD.TabIndex = 4;
            this.txtMaHD.Text = "HD2026-001";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(400, 35);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(67, 23);
            this.lblMaHD.TabIndex = 5;
            this.lblMaHD.Text = "Mã HĐ:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhachHang.Location = new System.Drawing.Point(131, 32);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(239, 29);
            this.txtKhachHang.TabIndex = 6;
            this.txtKhachHang.Text = "Nguyễn Văn Demo";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(20, 35);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(105, 23);
            this.lblKhachHang.TabIndex = 7;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // grpPhatSinh
            // 
            this.grpPhatSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhatSinh.Controls.Add(this.dgvPhatSinh);
            this.grpPhatSinh.Location = new System.Drawing.Point(20, 175);
            this.grpPhatSinh.Name = "grpPhatSinh";
            this.grpPhatSinh.Size = new System.Drawing.Size(744, 180);
            this.grpPhatSinh.TabIndex = 2;
            this.grpPhatSinh.TabStop = false;
            this.grpPhatSinh.Text = "2. Chi tiết các khoản phát sinh (Khấu trừ)";
            // 
            // dgvPhatSinh
            // 
            this.dgvPhatSinh.AllowUserToAddRows = false;
            this.dgvPhatSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhatSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhatSinh.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPhatSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhatSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLoai,
            this.colSoTien,
            this.colGhiChu});
            this.dgvPhatSinh.Location = new System.Drawing.Point(20, 30);
            this.dgvPhatSinh.Name = "dgvPhatSinh";
            this.dgvPhatSinh.ReadOnly = true;
            this.dgvPhatSinh.RowHeadersVisible = false;
            this.dgvPhatSinh.RowHeadersWidth = 51;
            this.dgvPhatSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhatSinh.Size = new System.Drawing.Size(700, 130);
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
            this.colGhiChu.HeaderText = "Ghi chú chi tiết";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // grpTongKet
            // 
            this.grpTongKet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTongKet.Controls.Add(this.valTienHoan);
            this.grpTongKet.Controls.Add(this.lblTienHoan);
            this.grpTongKet.Controls.Add(this.txtTienKhauTru);
            this.grpTongKet.Controls.Add(this.lblTienKhauTru);
            this.grpTongKet.Controls.Add(this.txtTienCoc);
            this.grpTongKet.Controls.Add(this.lblTienCoc);
            this.grpTongKet.Controls.Add(this.txtGhiChu);
            this.grpTongKet.Controls.Add(this.lblGhiChu);
            this.grpTongKet.Location = new System.Drawing.Point(20, 365);
            this.grpTongKet.Name = "grpTongKet";
            this.grpTongKet.Size = new System.Drawing.Size(744, 180);
            this.grpTongKet.TabIndex = 3;
            this.grpTongKet.TabStop = false;
            this.grpTongKet.Text = "3. Kết luận đối soát (Hoàn cọc = Tiền cọc gốc - Khấu trừ)";
            // 
            // valTienHoan
            // 
            this.valTienHoan.AutoSize = true;
            this.valTienHoan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.valTienHoan.ForeColor = System.Drawing.Color.MediumBlue;
            this.valTienHoan.Location = new System.Drawing.Point(228, 115);
            this.valTienHoan.Name = "valTienHoan";
            this.valTienHoan.Size = new System.Drawing.Size(262, 46);
            this.valTienHoan.TabIndex = 0;
            this.valTienHoan.Text = "4,350,000 VNĐ";
            // 
            // lblTienHoan
            // 
            this.lblTienHoan.AutoSize = true;
            this.lblTienHoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTienHoan.Location = new System.Drawing.Point(20, 125);
            this.lblTienHoan.Name = "lblTienHoan";
            this.lblTienHoan.Size = new System.Drawing.Size(205, 28);
            this.lblTienHoan.TabIndex = 1;
            this.lblTienHoan.Text = "SỐ TIỀN HOÀN TRẢ:";
            // 
            // txtTienKhauTru
            // 
            this.txtTienKhauTru.BackColor = System.Drawing.Color.MistyRose;
            this.txtTienKhauTru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTienKhauTru.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTienKhauTru.Location = new System.Drawing.Point(163, 72);
            this.txtTienKhauTru.Name = "txtTienKhauTru";
            this.txtTienKhauTru.ReadOnly = true;
            this.txtTienKhauTru.Size = new System.Drawing.Size(157, 30);
            this.txtTienKhauTru.TabIndex = 2;
            this.txtTienKhauTru.Text = "650,000";
            this.txtTienKhauTru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienKhauTru
            // 
            this.lblTienKhauTru.AutoSize = true;
            this.lblTienKhauTru.Location = new System.Drawing.Point(20, 75);
            this.lblTienKhauTru.Name = "lblTienKhauTru";
            this.lblTienKhauTru.Size = new System.Drawing.Size(144, 23);
            this.lblTienKhauTru.TabIndex = 3;
            this.lblTienKhauTru.Text = "Tổng khấu trừ (-):";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.Color.Honeydew;
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTienCoc.ForeColor = System.Drawing.Color.Green;
            this.txtTienCoc.Location = new System.Drawing.Point(163, 32);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.ReadOnly = true;
            this.txtTienCoc.Size = new System.Drawing.Size(157, 30);
            this.txtTienCoc.TabIndex = 4;
            this.txtTienCoc.Text = "5,000,000";
            this.txtTienCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Location = new System.Drawing.Point(20, 35);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(137, 23);
            this.lblTienCoc.TabIndex = 5;
            this.lblTienCoc.Text = "Tiền cọc gốc (+):";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(380, 60);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(340, 42);
            this.txtGhiChu.TabIndex = 6;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(380, 35);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(139, 23);
            this.lblGhiChu.TabIndex = 7;
            this.lblGhiChu.Text = "Ghi chú đối soát:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuayLai.BackColor = System.Drawing.Color.DarkOrange;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(384, 565);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(150, 40);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(544, 565);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(220, 40);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // UI_10_LapBangDoiSoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 621);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.grpTongKet);
            this.Controls.Add(this.grpPhatSinh);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UI_10_LapBangDoiSoat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Bảng Đối Soát Hoàn Cọc";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpPhatSinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhatSinh)).EndInit();
            this.grpTongKet.ResumeLayout(false);
            this.grpTongKet.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}