namespace Ducc
{
    partial class UI_16_KiemTraDieuKienKhachThue
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RadioButton radioCaNhan;
        private System.Windows.Forms.RadioButton radioNhom;
        private System.Windows.Forms.TextBox maKhachTextBox;
        private System.Windows.Forms.TextBox maPhieuTextBox;
        private System.Windows.Forms.Button traCuuButton;
        private System.Windows.Forms.DataGridView nhomGrid;
        private System.Windows.Forms.Label soTienLabel;
        private System.Windows.Forms.Label ngayDatLabel;
        private System.Windows.Forms.Label trangThaiLabel;
        private System.Windows.Forms.Label phongLabel;
        private System.Windows.Forms.Button xacNhanButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.radioCaNhan = new System.Windows.Forms.RadioButton();
            this.radioNhom = new System.Windows.Forms.RadioButton();
            this.maKhachTextBox = new System.Windows.Forms.TextBox();
            this.maPhieuTextBox = new System.Windows.Forms.TextBox();
            this.traCuuButton = new System.Windows.Forms.Button();
            this.nhomGrid = new System.Windows.Forms.DataGridView();
            this.soTienLabel = new System.Windows.Forms.Label();
            this.ngayDatLabel = new System.Windows.Forms.Label();
            this.trangThaiLabel = new System.Windows.Forms.Label();
            this.phongLabel = new System.Windows.Forms.Label();
            this.xacNhanButton = new System.Windows.Forms.Button();
            this.maKhachHang = new System.Windows.Forms.Label();
            this.maPhieuDatCoc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nhomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // radioCaNhan
            // 
            this.radioCaNhan.AutoSize = true;
            this.radioCaNhan.Location = new System.Drawing.Point(30, 30);
            this.radioCaNhan.Name = "radioCaNhan";
            this.radioCaNhan.Size = new System.Drawing.Size(140, 24);
            this.radioCaNhan.TabIndex = 0;
            this.radioCaNhan.Text = "Khách cá nhân";
            this.radioCaNhan.UseVisualStyleBackColor = true;
            // 
            // radioNhom
            // 
            this.radioNhom.AutoSize = true;
            this.radioNhom.Location = new System.Drawing.Point(250, 30);
            this.radioNhom.Name = "radioNhom";
            this.radioNhom.Size = new System.Drawing.Size(159, 24);
            this.radioNhom.TabIndex = 1;
            this.radioNhom.Text = "Khách theo nhóm";
            this.radioNhom.UseVisualStyleBackColor = true;
            // 
            // maKhachTextBox
            // 
            this.maKhachTextBox.Location = new System.Drawing.Point(30, 97);
            this.maKhachTextBox.Name = "maKhachTextBox";
            this.maKhachTextBox.Size = new System.Drawing.Size(200, 26);
            this.maKhachTextBox.TabIndex = 2;
            // 
            // maPhieuTextBox
            // 
            this.maPhieuTextBox.Location = new System.Drawing.Point(250, 97);
            this.maPhieuTextBox.Name = "maPhieuTextBox";
            this.maPhieuTextBox.Size = new System.Drawing.Size(200, 26);
            this.maPhieuTextBox.TabIndex = 3;
            // 
            // traCuuButton
            // 
            this.traCuuButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.traCuuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.traCuuButton.Location = new System.Drawing.Point(470, 93);
            this.traCuuButton.Name = "traCuuButton";
            this.traCuuButton.Size = new System.Drawing.Size(100, 34);
            this.traCuuButton.TabIndex = 4;
            this.traCuuButton.Text = "Tra cứu";
            this.traCuuButton.UseVisualStyleBackColor = false;
            this.traCuuButton.Click += new System.EventHandler(this.traCuuButton_Click);
            // 
            // nhomGrid
            // 
            this.nhomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomGrid.Location = new System.Drawing.Point(30, 173);
            this.nhomGrid.Name = "nhomGrid";
            this.nhomGrid.RowHeadersWidth = 62;
            this.nhomGrid.Size = new System.Drawing.Size(540, 150);
            this.nhomGrid.TabIndex = 5;
            // 
            // soTienLabel
            // 
            this.soTienLabel.AutoSize = true;
            this.soTienLabel.Location = new System.Drawing.Point(26, 343);
            this.soTienLabel.Name = "soTienLabel";
            this.soTienLabel.Size = new System.Drawing.Size(72, 20);
            this.soTienLabel.TabIndex = 6;
            this.soTienLabel.Text = "Số tiền: -";
            // 
            // ngayDatLabel
            // 
            this.ngayDatLabel.AutoSize = true;
            this.ngayDatLabel.Location = new System.Drawing.Point(26, 375);
            this.ngayDatLabel.Name = "ngayDatLabel";
            this.ngayDatLabel.Size = new System.Drawing.Size(85, 20);
            this.ngayDatLabel.TabIndex = 7;
            this.ngayDatLabel.Text = "Ngày đặt: -";
            // 
            // trangThaiLabel
            // 
            this.trangThaiLabel.AutoSize = true;
            this.trangThaiLabel.Location = new System.Drawing.Point(26, 412);
            this.trangThaiLabel.Name = "trangThaiLabel";
            this.trangThaiLabel.Size = new System.Drawing.Size(93, 20);
            this.trangThaiLabel.TabIndex = 8;
            this.trangThaiLabel.Text = "Trạng thái: -";
            // 
            // phongLabel
            // 
            this.phongLabel.AutoSize = true;
            this.phongLabel.Location = new System.Drawing.Point(26, 444);
            this.phongLabel.Name = "phongLabel";
            this.phongLabel.Size = new System.Drawing.Size(68, 20);
            this.phongLabel.TabIndex = 9;
            this.phongLabel.Text = "Phòng: -";
            // 
            // xacNhanButton
            // 
            this.xacNhanButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.xacNhanButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xacNhanButton.Location = new System.Drawing.Point(238, 485);
            this.xacNhanButton.Name = "xacNhanButton";
            this.xacNhanButton.Size = new System.Drawing.Size(120, 44);
            this.xacNhanButton.TabIndex = 10;
            this.xacNhanButton.Text = "Xác nhận";
            this.xacNhanButton.UseVisualStyleBackColor = false;
            this.xacNhanButton.Click += new System.EventHandler(this.xacNhanButton_Click);
            // 
            // maKhachHang
            // 
            this.maKhachHang.AutoSize = true;
            this.maKhachHang.Location = new System.Drawing.Point(30, 74);
            this.maKhachHang.Name = "maKhachHang";
            this.maKhachHang.Size = new System.Drawing.Size(118, 20);
            this.maKhachHang.TabIndex = 11;
            this.maKhachHang.Text = "Mã khách hàng";
            // 
            // maPhieuDatCoc
            // 
            this.maPhieuDatCoc.AutoSize = true;
            this.maPhieuDatCoc.Location = new System.Drawing.Point(246, 74);
            this.maPhieuDatCoc.Name = "maPhieuDatCoc";
            this.maPhieuDatCoc.Size = new System.Drawing.Size(130, 20);
            this.maPhieuDatCoc.TabIndex = 12;
            this.maPhieuDatCoc.Text = "Mã phiếu đặt cọc";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 369);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 26);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 406);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 26);
            this.textBox4.TabIndex = 16;
            // 
            // UI_16_KiemTraDieuKienKhachThue
            // 
            this.ClientSize = new System.Drawing.Size(600, 559);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maPhieuDatCoc);
            this.Controls.Add(this.maKhachHang);
            this.Controls.Add(this.radioCaNhan);
            this.Controls.Add(this.radioNhom);
            this.Controls.Add(this.maKhachTextBox);
            this.Controls.Add(this.maPhieuTextBox);
            this.Controls.Add(this.traCuuButton);
            this.Controls.Add(this.nhomGrid);
            this.Controls.Add(this.soTienLabel);
            this.Controls.Add(this.ngayDatLabel);
            this.Controls.Add(this.trangThaiLabel);
            this.Controls.Add(this.phongLabel);
            this.Controls.Add(this.xacNhanButton);
            this.Name = "UI_16_KiemTraDieuKienKhachThue";
            this.Text = "Kiểm tra điều kiện khách thuê";
            ((System.ComponentModel.ISupportInitialize)(this.nhomGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maKhachHang;
        private System.Windows.Forms.Label maPhieuDatCoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
