namespace WindowsFormsApp1
{
    partial class UI_18_CapNhatTrangThaiPhongTrong
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
            this.danhSachPhongGiuongChoCapNhat = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chonPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lamMoiButton = new System.Windows.Forms.Button();
            this.thongTinHopDong = new System.Windows.Forms.GroupBox();
            this.soHopDong = new System.Windows.Forms.Label();
            this.maHopDong = new System.Windows.Forms.TextBox();
            this.trangThaiHopDong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tinhTrangThanhToan = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.capNhatTrangThai = new System.Windows.Forms.GroupBox();
            this.chonTrangThaiMoi = new System.Windows.Forms.Label();
            this.trangThaiHienTai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.hoanThanhButton = new System.Windows.Forms.Button();
            this.dieuKienCapNhat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.thongTinHopDong.SuspendLayout();
            this.tinhTrangThanhToan.SuspendLayout();
            this.capNhatTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhSachPhongGiuongChoCapNhat
            // 
            this.danhSachPhongGiuongChoCapNhat.AutoSize = true;
            this.danhSachPhongGiuongChoCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSachPhongGiuongChoCapNhat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.danhSachPhongGiuongChoCapNhat.Location = new System.Drawing.Point(62, 73);
            this.danhSachPhongGiuongChoCapNhat.Name = "danhSachPhongGiuongChoCapNhat";
            this.danhSachPhongGiuongChoCapNhat.Size = new System.Drawing.Size(327, 20);
            this.danhSachPhongGiuongChoCapNhat.TabIndex = 0;
            this.danhSachPhongGiuongChoCapNhat.Text = "Danh sách phòng & Giu?ng ch? c?p nh?t";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(688, 163);
            this.dataGridView1.TabIndex = 1;
            // 
            // chonPhong
            // 
            this.chonPhong.AutoSize = true;
            this.chonPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonPhong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chonPhong.Location = new System.Drawing.Point(62, 291);
            this.chonPhong.Name = "chonPhong";
            this.chonPhong.Size = new System.Drawing.Size(106, 20);
            this.chonPhong.TabIndex = 2;
            this.chonPhong.Text = "Ch?n phòng";
            this.chonPhong.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(452, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngày ghi nh?n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ngayGhiNhan
            // 
            this.ngayGhiNhan.CustomFormat = "dd/MM/yyyy";
            this.ngayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayGhiNhan.Location = new System.Drawing.Point(591, 41);
            this.ngayGhiNhan.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.ngayGhiNhan.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ngayGhiNhan.Name = "ngayGhiNhan";
            this.ngayGhiNhan.Size = new System.Drawing.Size(163, 26);
            this.ngayGhiNhan.TabIndex = 5;
            this.ngayGhiNhan.Value = new System.DateTime(2026, 6, 5, 15, 55, 48, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 291);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // lamMoiButton
            // 
            this.lamMoiButton.Location = new System.Drawing.Point(494, 291);
            this.lamMoiButton.Name = "lamMoiButton";
            this.lamMoiButton.Size = new System.Drawing.Size(148, 27);
            this.lamMoiButton.TabIndex = 7;
            this.lamMoiButton.Text = "Làm m?i";
            this.lamMoiButton.UseVisualStyleBackColor = true;
            // 
            // thongTinHopDong
            // 
            this.thongTinHopDong.Controls.Add(this.textBox1);
            this.thongTinHopDong.Controls.Add(this.trangThaiHopDong);
            this.thongTinHopDong.Controls.Add(this.maHopDong);
            this.thongTinHopDong.Controls.Add(this.soHopDong);
            this.thongTinHopDong.Location = new System.Drawing.Point(66, 338);
            this.thongTinHopDong.Name = "thongTinHopDong";
            this.thongTinHopDong.Size = new System.Drawing.Size(687, 66);
            this.thongTinHopDong.TabIndex = 8;
            this.thongTinHopDong.TabStop = false;
            this.thongTinHopDong.Text = "Thông tin h?p d?ng";
            // 
            // soHopDong
            // 
            this.soHopDong.AutoSize = true;
            this.soHopDong.Location = new System.Drawing.Point(25, 31);
            this.soHopDong.Name = "soHopDong";
            this.soHopDong.Size = new System.Drawing.Size(112, 20);
            this.soHopDong.TabIndex = 0;
            this.soHopDong.Text = "Mã H?p Ð?ng:";
            // 
            // maHopDong
            // 
            this.maHopDong.Location = new System.Drawing.Point(143, 28);
            this.maHopDong.Name = "maHopDong";
            this.maHopDong.Size = new System.Drawing.Size(161, 26);
            this.maHopDong.TabIndex = 1;
            // 
            // trangThaiHopDong
            // 
            this.trangThaiHopDong.AutoSize = true;
            this.trangThaiHopDong.Location = new System.Drawing.Point(344, 31);
            this.trangThaiHopDong.Name = "trangThaiHopDong";
            this.trangThaiHopDong.Size = new System.Drawing.Size(151, 20);
            this.trangThaiHopDong.TabIndex = 2;
            this.trangThaiHopDong.Text = "Tr?ng thái h?p d?ng";
            this.trangThaiHopDong.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 26);
            this.textBox1.TabIndex = 3;
            // 
            // tinhTrangThanhToan
            // 
            this.tinhTrangThanhToan.Controls.Add(this.textBox3);
            this.tinhTrangThanhToan.Controls.Add(this.label3);
            this.tinhTrangThanhToan.Location = new System.Drawing.Point(66, 423);
            this.tinhTrangThanhToan.Name = "tinhTrangThanhToan";
            this.tinhTrangThanhToan.Size = new System.Drawing.Size(687, 66);
            this.tinhTrangThanhToan.TabIndex = 9;
            this.tinhTrangThanhToan.TabStop = false;
            this.tinhTrangThanhToan.Text = "Tình tr?ng thanh toán";
            this.tinhTrangThanhToan.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 28);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 26);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tr?ng thái thanh toán";
            // 
            // capNhatTrangThai
            // 
            this.capNhatTrangThai.Controls.Add(this.comboBox2);
            this.capNhatTrangThai.Controls.Add(this.chonTrangThaiMoi);
            this.capNhatTrangThai.Controls.Add(this.trangThaiHienTai);
            this.capNhatTrangThai.Controls.Add(this.label4);
            this.capNhatTrangThai.Location = new System.Drawing.Point(67, 520);
            this.capNhatTrangThai.Name = "capNhatTrangThai";
            this.capNhatTrangThai.Size = new System.Drawing.Size(687, 124);
            this.capNhatTrangThai.TabIndex = 10;
            this.capNhatTrangThai.TabStop = false;
            this.capNhatTrangThai.Text = "C?p nh?t tr?ng thái";
            // 
            // chonTrangThaiMoi
            // 
            this.chonTrangThaiMoi.AutoSize = true;
            this.chonTrangThaiMoi.Location = new System.Drawing.Point(25, 71);
            this.chonTrangThaiMoi.Name = "chonTrangThaiMoi";
            this.chonTrangThaiMoi.Size = new System.Drawing.Size(147, 20);
            this.chonTrangThaiMoi.TabIndex = 2;
            this.chonTrangThaiMoi.Text = "Ch?n tr?ng thái m?i";
            // 
            // trangThaiHienTai
            // 
            this.trangThaiHienTai.BackColor = System.Drawing.SystemColors.Control;
            this.trangThaiHienTai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trangThaiHienTai.Location = new System.Drawing.Point(195, 28);
            this.trangThaiHienTai.Name = "trangThaiHienTai";
            this.trangThaiHienTai.Size = new System.Drawing.Size(161, 19);
            this.trangThaiHienTai.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tr?ng thái hi?n t?i";
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(195, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 28);
            this.comboBox2.TabIndex = 7;
            // 
            // hoanThanhButton
            // 
            this.hoanThanhButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hoanThanhButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hoanThanhButton.Location = new System.Drawing.Point(281, 741);
            this.hoanThanhButton.Name = "hoanThanhButton";
            this.hoanThanhButton.Size = new System.Drawing.Size(249, 48);
            this.hoanThanhButton.TabIndex = 11;
            this.hoanThanhButton.Text = "Hoàn Thành";
            this.hoanThanhButton.UseVisualStyleBackColor = false;
            this.hoanThanhButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dieuKienCapNhat
            // 
            this.dieuKienCapNhat.Location = new System.Drawing.Point(72, 662);
            this.dieuKienCapNhat.Name = "dieuKienCapNhat";
            this.dieuKienCapNhat.Size = new System.Drawing.Size(681, 26);
            this.dieuKienCapNhat.TabIndex = 12;
            // 
            // UI_18_CapNhatTrangThaiPhongTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 835);
            this.Controls.Add(this.dieuKienCapNhat);
            this.Controls.Add(this.hoanThanhButton);
            this.Controls.Add(this.capNhatTrangThai);
            this.Controls.Add(this.tinhTrangThanhToan);
            this.Controls.Add(this.thongTinHopDong);
            this.Controls.Add(this.lamMoiButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ngayGhiNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chonPhong);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.danhSachPhongGiuongChoCapNhat);
            this.Name = "UI_18_CapNhatTrangThaiPhongTrong";
            this.Text = "C?p nh?t tr?ng thái phòng tr?ng";
            this.Load += new System.EventHandler(this.UI_18_CapNhatTrangThaiPhongTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.thongTinHopDong.ResumeLayout(false);
            this.thongTinHopDong.PerformLayout();
            this.tinhTrangThanhToan.ResumeLayout(false);
            this.tinhTrangThanhToan.PerformLayout();
            this.capNhatTrangThai.ResumeLayout(false);
            this.capNhatTrangThai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label danhSachPhongGiuongChoCapNhat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label chonPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ngayGhiNhan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button lamMoiButton;
        private System.Windows.Forms.GroupBox thongTinHopDong;
        private System.Windows.Forms.Label soHopDong;
        private System.Windows.Forms.Label trangThaiHopDong;
        private System.Windows.Forms.TextBox maHopDong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox tinhTrangThanhToan;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox capNhatTrangThai;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label chonTrangThaiMoi;
        private System.Windows.Forms.TextBox trangThaiHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hoanThanhButton;
        private System.Windows.Forms.TextBox dieuKienCapNhat;
    }
}