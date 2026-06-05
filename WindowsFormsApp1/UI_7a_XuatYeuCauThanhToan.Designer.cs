namespace WindowsFormsApp1
{
    partial class UI_7a_XuatYeuCauThanhToan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel pnlPhieu;

        // Thông tin phiếu
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label valKhachHang;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label valPhong;
        private System.Windows.Forms.Label lblHanThanhToan;
        private System.Windows.Forms.Label valHanThanhToan;

        // Đường kẻ ngang
        private System.Windows.Forms.Label lblDivider1;
        private System.Windows.Forms.Label lblDivider2;

        // Vùng Tổng tiền
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label valSoTien;
        private System.Windows.Forms.Label lblGhiChuTien;

        // Vùng QR Code
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label lblHuongDanQR;

        // Nút chức năng
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.pnlPhieu = new System.Windows.Forms.Panel();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.lblHuongDanQR = new System.Windows.Forms.Label();
            this.lblDivider2 = new System.Windows.Forms.Label();
            this.valSoTien = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblGhiChuTien = new System.Windows.Forms.Label();
            this.lblDivider1 = new System.Windows.Forms.Label();
            this.valHanThanhToan = new System.Windows.Forms.Label();
            this.lblHanThanhToan = new System.Windows.Forms.Label();
            this.valPhong = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.valKhachHang = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(670, 60);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "PHIẾU YÊU CẦU THANH TOÁN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPhieu
            // 
            this.pnlPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPhieu.BackColor = System.Drawing.Color.White;
            this.pnlPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhieu.Controls.Add(this.picQRCode);
            this.pnlPhieu.Controls.Add(this.lblHuongDanQR);
            this.pnlPhieu.Controls.Add(this.lblDivider2);
            this.pnlPhieu.Controls.Add(this.valSoTien);
            this.pnlPhieu.Controls.Add(this.lblSoTien);
            this.pnlPhieu.Controls.Add(this.lblGhiChuTien);
            this.pnlPhieu.Controls.Add(this.lblDivider1);
            this.pnlPhieu.Controls.Add(this.valHanThanhToan);
            this.pnlPhieu.Controls.Add(this.lblHanThanhToan);
            this.pnlPhieu.Controls.Add(this.valPhong);
            this.pnlPhieu.Controls.Add(this.lblPhong);
            this.pnlPhieu.Controls.Add(this.valKhachHang);
            this.pnlPhieu.Controls.Add(this.lblKhachHang);
            this.pnlPhieu.Location = new System.Drawing.Point(30, 60);
            this.pnlPhieu.Name = "pnlPhieu";
            this.pnlPhieu.Size = new System.Drawing.Size(610, 429);
            this.pnlPhieu.TabIndex = 1;
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.Color.Gainsboro;
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQRCode.Location = new System.Drawing.Point(135, 260);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(130, 130);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCode.TabIndex = 12;
            this.picQRCode.TabStop = false;
            // 
            // lblHuongDanQR
            // 
            this.lblHuongDanQR.AutoSize = true;
            this.lblHuongDanQR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDanQR.Location = new System.Drawing.Point(20, 230);
            this.lblHuongDanQR.Name = "lblHuongDanQR";
            this.lblHuongDanQR.Size = new System.Drawing.Size(269, 23);
            this.lblHuongDanQR.TabIndex = 11;
            this.lblHuongDanQR.Text = "Quét mã QR để thanh toán ngay";
            // 
            // lblDivider2
            // 
            this.lblDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider2.Location = new System.Drawing.Point(20, 210);
            this.lblDivider2.Name = "lblDivider2";
            this.lblDivider2.Size = new System.Drawing.Size(570, 2);
            this.lblDivider2.TabIndex = 10;
            // 
            // valSoTien
            // 
            this.valSoTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valSoTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSoTien.ForeColor = System.Drawing.Color.Firebrick;
            this.valSoTien.Location = new System.Drawing.Point(370, 142);
            this.valSoTien.Name = "valSoTien";
            this.valSoTien.Size = new System.Drawing.Size(220, 32);
            this.valSoTien.TabIndex = 8;
            this.valSoTien.Text = "5,000,000 VNĐ";
            this.valSoTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(20, 150);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(181, 28);
            this.lblSoTien.TabIndex = 7;
            this.lblSoTien.Text = "SỐ TIỀN ĐẶT CỌC";
            // 
            // lblGhiChuTien
            // 
            this.lblGhiChuTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGhiChuTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChuTien.ForeColor = System.Drawing.Color.Gray;
            this.lblGhiChuTien.Location = new System.Drawing.Point(370, 175);
            this.lblGhiChuTien.Name = "lblGhiChuTien";
            this.lblGhiChuTien.Size = new System.Drawing.Size(220, 23);
            this.lblGhiChuTien.TabIndex = 9;
            this.lblGhiChuTien.Text = "(Năm triệu đồng chẵn)";
            this.lblGhiChuTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGhiChuTien.Click += new System.EventHandler(this.lblGhiChuTien_Click);
            // 
            // lblDivider1
            // 
            this.lblDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider1.Location = new System.Drawing.Point(20, 130);
            this.lblDivider1.Name = "lblDivider1";
            this.lblDivider1.Size = new System.Drawing.Size(570, 2);
            this.lblDivider1.TabIndex = 6;
            // 
            // valHanThanhToan
            // 
            this.valHanThanhToan.AutoSize = true;
            this.valHanThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valHanThanhToan.Location = new System.Drawing.Point(177, 91);
            this.valHanThanhToan.Name = "valHanThanhToan";
            this.valHanThanhToan.Size = new System.Drawing.Size(96, 23);
            this.valHanThanhToan.TabIndex = 5;
            this.valHanThanhToan.Text = "10/06/2026";
            // 
            // lblHanThanhToan
            // 
            this.lblHanThanhToan.AutoSize = true;
            this.lblHanThanhToan.ForeColor = System.Drawing.Color.Gray;
            this.lblHanThanhToan.Location = new System.Drawing.Point(20, 90);
            this.lblHanThanhToan.Name = "lblHanThanhToan";
            this.lblHanThanhToan.Size = new System.Drawing.Size(135, 23);
            this.lblHanThanhToan.TabIndex = 4;
            this.lblHanThanhToan.Text = "Hạn thanh toán:";
            // 
            // valPhong
            // 
            this.valPhong.AutoSize = true;
            this.valPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valPhong.Location = new System.Drawing.Point(177, 56);
            this.valPhong.Name = "valPhong";
            this.valPhong.Size = new System.Drawing.Size(50, 23);
            this.valPhong.TabIndex = 3;
            this.valPhong.Text = "P101";
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.ForeColor = System.Drawing.Color.Gray;
            this.lblPhong.Location = new System.Drawing.Point(20, 55);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(104, 23);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng thuê:";
            // 
            // valKhachHang
            // 
            this.valKhachHang.AutoSize = true;
            this.valKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valKhachHang.Location = new System.Drawing.Point(177, 20);
            this.valKhachHang.Name = "valKhachHang";
            this.valKhachHang.Size = new System.Drawing.Size(180, 25);
            this.valKhachHang.TabIndex = 1;
            this.valKhachHang.Text = "Nguyễn Văn Demo";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.ForeColor = System.Drawing.Color.Gray;
            this.lblKhachHang.Location = new System.Drawing.Point(20, 20);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(105, 23);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInPhieu.FlatAppearance.BorderSize = 0;
            this.btnInPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieu.ForeColor = System.Drawing.Color.White;
            this.btnInPhieu.Location = new System.Drawing.Point(470, 495);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(170, 40);
            this.btnInPhieu.TabIndex = 2;
            this.btnInPhieu.Text = "🖨️ Xuất / In phiếu này";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.BackColor = System.Drawing.Color.DarkGray;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(360, 495);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 40);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // UI_7a_XuatYeuCauThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(670, 555);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.pnlPhieu);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UI_7a_XuatYeuCauThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Yêu Cầu Thanh Toán";
            this.pnlPhieu.ResumeLayout(false);
            this.pnlPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }
    }
}