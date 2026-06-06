namespace WindowsFormsApp1
{
    partial class UI_07b_KhauTru
    {
        private System.ComponentModel.IContainer components = null;

        // Group 1: Thông tin cơ sở
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.TextBox txtThoiGian;
        private System.Windows.Forms.Label lblTienCocGoc;
        private System.Windows.Forms.TextBox txtTienCocGoc;

        // Group 2: Mức hoàn cọc cơ bản
        private System.Windows.Forms.GroupBox grpHoanCocCoBan;
        private System.Windows.Forms.Label lblQuyTac;
        private System.Windows.Forms.TextBox txtQuyTac;
        private System.Windows.Forms.Label lblTienDuocHoan;
        private System.Windows.Forms.TextBox txtTienDuocHoan;

        // Group 3: Khấu trừ
        private System.Windows.Forms.GroupBox grpKhauTru;
        private System.Windows.Forms.Label lblPhatSinh;
        private System.Windows.Forms.TextBox txtPhatSinh;
        private System.Windows.Forms.Label lblPhepTru;
        private System.Windows.Forms.Label lblTienThucNhan;
        private System.Windows.Forms.Label valTienThucNhan;

        // Nút
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtTienCocGoc = new System.Windows.Forms.TextBox();
            this.lblTienCocGoc = new System.Windows.Forms.Label();
            this.txtThoiGian = new System.Windows.Forms.TextBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.grpHoanCocCoBan = new System.Windows.Forms.GroupBox();
            this.txtTienDuocHoan = new System.Windows.Forms.TextBox();
            this.lblTienDuocHoan = new System.Windows.Forms.Label();
            this.txtQuyTac = new System.Windows.Forms.TextBox();
            this.lblQuyTac = new System.Windows.Forms.Label();
            this.grpKhauTru = new System.Windows.Forms.GroupBox();
            this.valTienThucNhan = new System.Windows.Forms.Label();
            this.lblTienThucNhan = new System.Windows.Forms.Label();
            this.lblPhepTru = new System.Windows.Forms.Label();
            this.txtPhatSinh = new System.Windows.Forms.TextBox();
            this.lblPhatSinh = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            this.grpHoanCocCoBan.SuspendLayout();
            this.grpKhauTru.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.txtTienCocGoc);
            this.grpThongTin.Controls.Add(this.lblTienCocGoc);
            this.grpThongTin.Controls.Add(this.txtThoiGian);
            this.grpThongTin.Controls.Add(this.lblThoiGian);
            this.grpThongTin.Controls.Add(this.txtTrangThai);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.txtMaHD);
            this.grpThongTin.Controls.Add(this.lblMaHD);
            this.grpThongTin.Location = new System.Drawing.Point(20, 20);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(650, 110);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "1. Thông tin hồ sơ hoàn cọc";
            // 
            // txtTienCocGoc
            // 
            this.txtTienCocGoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienCocGoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTienCocGoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCocGoc.Location = new System.Drawing.Point(420, 72);
            this.txtTienCocGoc.Name = "txtTienCocGoc";
            this.txtTienCocGoc.ReadOnly = true;
            this.txtTienCocGoc.Size = new System.Drawing.Size(210, 29);
            this.txtTienCocGoc.TabIndex = 0;
            this.txtTienCocGoc.Text = "5,000,000";
            this.txtTienCocGoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienCocGoc
            // 
            this.lblTienCocGoc.AutoSize = true;
            this.lblTienCocGoc.Location = new System.Drawing.Point(340, 75);
            this.lblTienCocGoc.Name = "lblTienCocGoc";
            this.lblTienCocGoc.Size = new System.Drawing.Size(76, 23);
            this.lblTienCocGoc.TabIndex = 1;
            this.lblTienCocGoc.Text = "Cọc gốc:";
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtThoiGian.Location = new System.Drawing.Point(125, 72);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.ReadOnly = true;
            this.txtThoiGian.Size = new System.Drawing.Size(180, 29);
            this.txtThoiGian.TabIndex = 2;
            this.txtThoiGian.Text = "8 Tháng (Trên 6T)";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(20, 75);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(90, 23);
            this.lblThoiGian.TabIndex = 3;
            this.lblThoiGian.Text = "TG lưu trú:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrangThai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTrangThai.Location = new System.Drawing.Point(420, 32);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.ReadOnly = true;
            this.txtTrangThai.Size = new System.Drawing.Size(210, 29);
            this.txtTrangThai.TabIndex = 4;
            this.txtTrangThai.Text = "Đã ký hợp đồng";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(340, 35);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 23);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaHD.Location = new System.Drawing.Point(125, 32);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(180, 29);
            this.txtMaHD.TabIndex = 6;
            this.txtMaHD.Text = "HD2026-001";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(20, 35);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(120, 23);
            this.lblMaHD.TabIndex = 7;
            this.lblMaHD.Text = "Mã Hợp đồng:";
            // 
            // grpHoanCocCoBan
            // 
            this.grpHoanCocCoBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHoanCocCoBan.Controls.Add(this.txtTienDuocHoan);
            this.grpHoanCocCoBan.Controls.Add(this.lblTienDuocHoan);
            this.grpHoanCocCoBan.Controls.Add(this.txtQuyTac);
            this.grpHoanCocCoBan.Controls.Add(this.lblQuyTac);
            this.grpHoanCocCoBan.Location = new System.Drawing.Point(20, 145);
            this.grpHoanCocCoBan.Name = "grpHoanCocCoBan";
            this.grpHoanCocCoBan.Size = new System.Drawing.Size(650, 110);
            this.grpHoanCocCoBan.TabIndex = 1;
            this.grpHoanCocCoBan.TabStop = false;
            this.grpHoanCocCoBan.Text = "2. Xác định mức hoàn cọc cơ bản";
            // 
            // txtTienDuocHoan
            // 
            this.txtTienDuocHoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTienDuocHoan.BackColor = System.Drawing.Color.Honeydew;
            this.txtTienDuocHoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDuocHoan.ForeColor = System.Drawing.Color.Green;
            this.txtTienDuocHoan.Location = new System.Drawing.Point(190, 70);
            this.txtTienDuocHoan.Name = "txtTienDuocHoan";
            this.txtTienDuocHoan.ReadOnly = true;
            this.txtTienDuocHoan.Size = new System.Drawing.Size(440, 32);
            this.txtTienDuocHoan.TabIndex = 0;
            this.txtTienDuocHoan.Text = "3,500,000";
            this.txtTienDuocHoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienDuocHoan
            // 
            this.lblTienDuocHoan.AutoSize = true;
            this.lblTienDuocHoan.Location = new System.Drawing.Point(20, 75);
            this.lblTienDuocHoan.Name = "lblTienDuocHoan";
            this.lblTienDuocHoan.Size = new System.Drawing.Size(213, 23);
            this.lblTienDuocHoan.TabIndex = 1;
            this.lblTienDuocHoan.Text = "Cọc được hoàn (Tạm tính):";
            // 
            // txtQuyTac
            // 
            this.txtQuyTac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuyTac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQuyTac.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtQuyTac.Location = new System.Drawing.Point(190, 32);
            this.txtQuyTac.Name = "txtQuyTac";
            this.txtQuyTac.ReadOnly = true;
            this.txtQuyTac.Size = new System.Drawing.Size(440, 29);
            this.txtQuyTac.TabIndex = 2;
            this.txtQuyTac.Text = "Đã ký hợp đồng, lưu trú trên 6 tháng ➔ Hoàn 70% tiền cọc";
            // 
            // lblQuyTac
            // 
            this.lblQuyTac.AutoSize = true;
            this.lblQuyTac.Location = new System.Drawing.Point(20, 35);
            this.lblQuyTac.Name = "lblQuyTac";
            this.lblQuyTac.Size = new System.Drawing.Size(142, 23);
            this.lblQuyTac.TabIndex = 3;
            this.lblQuyTac.Text = "Quy tắc áp dụng:";
            // 
            // grpKhauTru
            // 
            this.grpKhauTru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKhauTru.Controls.Add(this.valTienThucNhan);
            this.grpKhauTru.Controls.Add(this.lblTienThucNhan);
            this.grpKhauTru.Controls.Add(this.lblPhepTru);
            this.grpKhauTru.Controls.Add(this.txtPhatSinh);
            this.grpKhauTru.Controls.Add(this.lblPhatSinh);
            this.grpKhauTru.Location = new System.Drawing.Point(20, 270);
            this.grpKhauTru.Name = "grpKhauTru";
            this.grpKhauTru.Size = new System.Drawing.Size(650, 180);
            this.grpKhauTru.TabIndex = 2;
            this.grpKhauTru.TabStop = false;
            this.grpKhauTru.Text = "3. Khấu trừ khoản phát sinh";
            // 
            // valTienThucNhan
            // 
            this.valTienThucNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valTienThucNhan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTienThucNhan.ForeColor = System.Drawing.Color.MediumBlue;
            this.valTienThucNhan.Location = new System.Drawing.Point(380, 93);
            this.valTienThucNhan.Name = "valTienThucNhan";
            this.valTienThucNhan.Size = new System.Drawing.Size(250, 48);
            this.valTienThucNhan.TabIndex = 2;
            this.valTienThucNhan.Text = "2,850,000 VNĐ";
            this.valTienThucNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTienThucNhan
            // 
            this.lblTienThucNhan.AutoSize = true;
            this.lblTienThucNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThucNhan.Location = new System.Drawing.Point(20, 100);
            this.lblTienThucNhan.Name = "lblTienThucNhan";
            this.lblTienThucNhan.Size = new System.Drawing.Size(205, 28);
            this.lblTienThucNhan.TabIndex = 3;
            this.lblTienThucNhan.Text = "SỐ TIỀN HOÀN CỌC:";
            // 
            // lblPhepTru
            // 
            this.lblPhepTru.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhepTru.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhepTru.Location = new System.Drawing.Point(190, 75);
            this.lblPhepTru.Name = "lblPhepTru";
            this.lblPhepTru.Size = new System.Drawing.Size(440, 2);
            this.lblPhepTru.TabIndex = 4;
            // 
            // txtPhatSinh
            // 
            this.txtPhatSinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhatSinh.BackColor = System.Drawing.Color.MistyRose;
            this.txtPhatSinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhatSinh.ForeColor = System.Drawing.Color.Firebrick;
            this.txtPhatSinh.Location = new System.Drawing.Point(204, 32);
            this.txtPhatSinh.Name = "txtPhatSinh";
            this.txtPhatSinh.ReadOnly = true;
            this.txtPhatSinh.Size = new System.Drawing.Size(426, 32);
            this.txtPhatSinh.TabIndex = 5;
            this.txtPhatSinh.Text = "650,000";
            this.txtPhatSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhatSinh
            // 
            this.lblPhatSinh.AutoSize = true;
            this.lblPhatSinh.Location = new System.Drawing.Point(20, 35);
            this.lblPhatSinh.Name = "lblPhatSinh";
            this.lblPhatSinh.Size = new System.Drawing.Size(178, 23);
            this.lblPhatSinh.TabIndex = 6;
            this.lblPhatSinh.Text = "Khấu trừ phát sinh (-):";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(470, 470);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(200, 40);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "✔ Xác nhận khấu trừ";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BackColor = System.Drawing.Color.DarkGray;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(360, 470);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // UI_07b_KhauTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 576);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.grpKhauTru);
            this.Controls.Add(this.grpHoanCocCoBan);
            this.Controls.Add(this.grpThongTin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UI_07b_KhauTru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khấu Trừ Khoản Phát Sinh";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpHoanCocCoBan.ResumeLayout(false);
            this.grpHoanCocCoBan.PerformLayout();
            this.grpKhauTru.ResumeLayout(false);
            this.grpKhauTru.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}