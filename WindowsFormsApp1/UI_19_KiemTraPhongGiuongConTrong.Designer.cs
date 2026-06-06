namespace WindowsFormsApp1
{
    partial class UI_19_KiemTraPhongGiuongConTrong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kiemTraButton = new System.Windows.Forms.Button();
            this.chonPhong = new System.Windows.Forms.Label();
            this.maPhongGiuong = new System.Windows.Forms.TextBox();
            this.ketQuaKiemTra = new System.Windows.Forms.GroupBox();
            this.thongTinHopDong = new System.Windows.Forms.Label();
            this.tinTrangPhongHienTai = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hoanThanhButton = new System.Windows.Forms.Button();
            this.phongKhongTonTai = new System.Windows.Forms.TextBox();
            this.ketQuaKiemTra.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiemTraButton
            // 
            this.kiemTraButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.kiemTraButton.Location = new System.Drawing.Point(530, 45);
            this.kiemTraButton.Name = "kiemTraButton";
            this.kiemTraButton.Size = new System.Drawing.Size(107, 40);
            this.kiemTraButton.TabIndex = 10;
            this.kiemTraButton.Text = "Kiểm tra";
            this.kiemTraButton.UseVisualStyleBackColor = false;
            this.kiemTraButton.Click += new System.EventHandler(this.lamMoiButton_Click);
            // 
            // chonPhong
            // 
            this.chonPhong.AutoSize = true;
            this.chonPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonPhong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chonPhong.Location = new System.Drawing.Point(54, 52);
            this.chonPhong.Name = "chonPhong";
            this.chonPhong.Size = new System.Drawing.Size(203, 20);
            this.chonPhong.TabIndex = 8;
            this.chonPhong.Text = "Nhập mã phòng/giường";
            // 
            // maPhongGiuong
            // 
            this.maPhongGiuong.Location = new System.Drawing.Point(285, 52);
            this.maPhongGiuong.Name = "maPhongGiuong";
            this.maPhongGiuong.Size = new System.Drawing.Size(211, 26);
            this.maPhongGiuong.TabIndex = 11;
            // 
            // ketQuaKiemTra
            // 
            this.ketQuaKiemTra.Controls.Add(this.textBox2);
            this.ketQuaKiemTra.Controls.Add(this.textBox1);
            this.ketQuaKiemTra.Controls.Add(this.thongTinHopDong);
            this.ketQuaKiemTra.Controls.Add(this.tinTrangPhongHienTai);
            this.ketQuaKiemTra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ketQuaKiemTra.Location = new System.Drawing.Point(58, 104);
            this.ketQuaKiemTra.Name = "ketQuaKiemTra";
            this.ketQuaKiemTra.Size = new System.Drawing.Size(687, 124);
            this.ketQuaKiemTra.TabIndex = 12;
            this.ketQuaKiemTra.TabStop = false;
            this.ketQuaKiemTra.Text = "Kết quả kiểm tra";
            this.ketQuaKiemTra.Enter += new System.EventHandler(this.capNhatTrangThai_Enter);
            // 
            // thongTinHopDong
            // 
            this.thongTinHopDong.AutoSize = true;
            this.thongTinHopDong.Location = new System.Drawing.Point(25, 71);
            this.thongTinHopDong.Name = "thongTinHopDong";
            this.thongTinHopDong.Size = new System.Drawing.Size(146, 20);
            this.thongTinHopDong.TabIndex = 2;
            this.thongTinHopDong.Text = "Thông tin hợp đồng";
            // 
            // tinTrangPhongHienTai
            // 
            this.tinTrangPhongHienTai.AutoSize = true;
            this.tinTrangPhongHienTai.Location = new System.Drawing.Point(25, 31);
            this.tinTrangPhongHienTai.Name = "tinTrangPhongHienTai";
            this.tinTrangPhongHienTai.Size = new System.Drawing.Size(184, 20);
            this.tinTrangPhongHienTai.TabIndex = 0;
            this.tinTrangPhongHienTai.Text = "Tình trạng phòng hiện tại";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 26);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 26);
            this.textBox2.TabIndex = 13;
            // 
            // hoanThanhButton
            // 
            this.hoanThanhButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hoanThanhButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hoanThanhButton.Location = new System.Drawing.Point(274, 324);
            this.hoanThanhButton.Name = "hoanThanhButton";
            this.hoanThanhButton.Size = new System.Drawing.Size(249, 48);
            this.hoanThanhButton.TabIndex = 13;
            this.hoanThanhButton.Text = "Hoàn Thành";
            this.hoanThanhButton.UseVisualStyleBackColor = false;
            // 
            // phongKhongTonTai
            // 
            this.phongKhongTonTai.Location = new System.Drawing.Point(64, 254);
            this.phongKhongTonTai.Name = "phongKhongTonTai";
            this.phongKhongTonTai.Size = new System.Drawing.Size(680, 26);
            this.phongKhongTonTai.TabIndex = 14;
            // 
            // UI_19_KiemTraPhongGiuongConTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phongKhongTonTai);
            this.Controls.Add(this.hoanThanhButton);
            this.Controls.Add(this.ketQuaKiemTra);
            this.Controls.Add(this.maPhongGiuong);
            this.Controls.Add(this.kiemTraButton);
            this.Controls.Add(this.chonPhong);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "UI_19_KiemTraPhongGiuongConTrong";
            this.Text = "Kiểm tra phòng/giường còn trống";
            this.ketQuaKiemTra.ResumeLayout(false);
            this.ketQuaKiemTra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kiemTraButton;
        private System.Windows.Forms.Label chonPhong;
        private System.Windows.Forms.TextBox maPhongGiuong;
        private System.Windows.Forms.GroupBox ketQuaKiemTra;
        private System.Windows.Forms.Label thongTinHopDong;
        private System.Windows.Forms.Label tinTrangPhongHienTai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button hoanThanhButton;
        private System.Windows.Forms.TextBox phongKhongTonTai;
    }
}