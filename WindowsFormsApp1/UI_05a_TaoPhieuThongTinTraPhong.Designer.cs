namespace WindowsFormsApp1
{
    partial class UI_05a_TaoPhieuThongTinTraPhong
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Control
        private System.Windows.Forms.Button btnMoTraCuu;
        private System.Windows.Forms.GroupBox grpThongTinThue;
        private System.Windows.Forms.Label lblMaPhieuThue;
        private System.Windows.Forms.TextBox txtMaPhieuThue; // Readonly
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong; // Readonly

        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Button btnHoanThanh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnMoTraCuu = new System.Windows.Forms.Button();
            this.grpThongTinThue = new System.Windows.Forms.GroupBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhieuThue = new System.Windows.Forms.TextBox();
            this.lblMaPhieuThue = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.grpThongTinThue.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoTraCuu
            // 
            this.btnMoTraCuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMoTraCuu.FlatAppearance.BorderSize = 0;
            this.btnMoTraCuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoTraCuu.ForeColor = System.Drawing.Color.White;
            this.btnMoTraCuu.Location = new System.Drawing.Point(20, 20);
            this.btnMoTraCuu.Name = "btnMoTraCuu";
            this.btnMoTraCuu.Size = new System.Drawing.Size(180, 35);
            this.btnMoTraCuu.TabIndex = 8;
            this.btnMoTraCuu.Text = "🔍 Tra cứu phiếu thuê...";
            this.btnMoTraCuu.UseVisualStyleBackColor = false;
            this.btnMoTraCuu.Click += new System.EventHandler(this.btnMoTraCuu_Click);
            // 
            // grpThongTinThue
            // 
            this.grpThongTinThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinThue.Controls.Add(this.txtMaPhong);
            this.grpThongTinThue.Controls.Add(this.lblMaPhong);
            this.grpThongTinThue.Controls.Add(this.txtMaPhieuThue);
            this.grpThongTinThue.Controls.Add(this.lblMaPhieuThue);
            this.grpThongTinThue.Location = new System.Drawing.Point(20, 75);
            this.grpThongTinThue.Name = "grpThongTinThue";
            this.grpThongTinThue.Size = new System.Drawing.Size(872, 110);
            this.grpThongTinThue.TabIndex = 7;
            this.grpThongTinThue.TabStop = false;
            this.grpThongTinThue.Text = "Thông tin thuê hiện tại";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaPhong.Location = new System.Drawing.Point(147, 72);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(705, 29);
            this.txtMaPhong.TabIndex = 0;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(15, 75);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(93, 23);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // txtMaPhieuThue
            // 
            this.txtMaPhieuThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaPhieuThue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaPhieuThue.Location = new System.Drawing.Point(147, 32);
            this.txtMaPhieuThue.Name = "txtMaPhieuThue";
            this.txtMaPhieuThue.ReadOnly = true;
            this.txtMaPhieuThue.Size = new System.Drawing.Size(705, 29);
            this.txtMaPhieuThue.TabIndex = 2;
            // 
            // lblMaPhieuThue
            // 
            this.lblMaPhieuThue.AutoSize = true;
            this.lblMaPhieuThue.Location = new System.Drawing.Point(15, 35);
            this.lblMaPhieuThue.Name = "lblMaPhieuThue";
            this.lblMaPhieuThue.Size = new System.Drawing.Size(126, 23);
            this.lblMaPhieuThue.TabIndex = 3;
            this.lblMaPhieuThue.Text = "Mã phiếu thuê:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(20, 205);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(135, 23);
            this.lblNgayTra.TabIndex = 6;
            this.lblNgayTra.Text = "Ngày trả phòng:";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(167, 205);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(200, 29);
            this.dtpNgayTra.TabIndex = 5;
            // 
            // lblLyDo
            // 
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(20, 250);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(80, 23);
            this.lblLyDo.TabIndex = 4;
            this.lblLyDo.Text = "Lý do trả:";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLyDo.Location = new System.Drawing.Point(140, 247);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(752, 29);
            this.txtLyDo.TabIndex = 3;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 295);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(73, 23);
            this.lblGhiChu.TabIndex = 2;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.Location = new System.Drawing.Point(140, 292);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(752, 126);
            this.txtGhiChu.TabIndex = 1;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoanThanh.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHoanThanh.FlatAppearance.BorderSize = 0;
            this.btnHoanThanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoanThanh.ForeColor = System.Drawing.Color.White;
            this.btnHoanThanh.Location = new System.Drawing.Point(772, 436);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(120, 35);
            this.btnHoanThanh.TabIndex = 0;
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = false;
            // 
            // TaoPhieuTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 497);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.txtLyDo);
            this.Controls.Add(this.lblLyDo);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.grpThongTinThue);
            this.Controls.Add(this.btnMoTraCuu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaoPhieuTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Phiếu Thông Tin Trả Phòng";
            this.grpThongTinThue.ResumeLayout(false);
            this.grpThongTinThue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}