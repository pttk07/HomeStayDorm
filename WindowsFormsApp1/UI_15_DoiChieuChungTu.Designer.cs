namespace WindowsFormsApp1
{
    partial class UI_15_DoiChieuChungTu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timKiemButton = new System.Windows.Forms.Button();
            this.danhSachChungTuGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ketQuaDoiChieu = new System.Windows.Forms.TextBox();
            this.doiChieuButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachChungTuGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 28);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã chứng từ:";
            // 
            // timKiemButton
            // 
            this.timKiemButton.Location = new System.Drawing.Point(750, 29);
            this.timKiemButton.Name = "timKiemButton";
            this.timKiemButton.Size = new System.Drawing.Size(110, 34);
            this.timKiemButton.TabIndex = 2;
            this.timKiemButton.Text = "Tìm kiếm";
            this.timKiemButton.UseVisualStyleBackColor = true;
            // 
            // danhSachChungTuGrid
            // 
            this.danhSachChungTuGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danhSachChungTuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachChungTuGrid.Location = new System.Drawing.Point(36, 151);
            this.danhSachChungTuGrid.Name = "danhSachChungTuGrid";
            this.danhSachChungTuGrid.RowHeadersWidth = 62;
            this.danhSachChungTuGrid.RowTemplate.Height = 28;
            this.danhSachChungTuGrid.Size = new System.Drawing.Size(802, 172);
            this.danhSachChungTuGrid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách chứng từ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ketQuaDoiChieu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả đối chiếu";
            // 
            // ketQuaDoiChieu
            // 
            this.ketQuaDoiChieu.ForeColor = System.Drawing.Color.Red;
            this.ketQuaDoiChieu.Location = new System.Drawing.Point(26, 34);
            this.ketQuaDoiChieu.Multiline = true;
            this.ketQuaDoiChieu.Name = "ketQuaDoiChieu";
            this.ketQuaDoiChieu.Size = new System.Drawing.Size(729, 40);
            this.ketQuaDoiChieu.TabIndex = 0;
            this.ketQuaDoiChieu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // doiChieuButton
            // 
            this.doiChieuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doiChieuButton.Location = new System.Drawing.Point(527, 486);
            this.doiChieuButton.Name = "doiChieuButton";
            this.doiChieuButton.Size = new System.Drawing.Size(146, 36);
            this.doiChieuButton.TabIndex = 6;
            this.doiChieuButton.Text = "Đối chiếu";
            this.doiChieuButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(698, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xuất báo cáo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UI_15_DoiChieuChungTu
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 556);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.doiChieuButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.danhSachChungTuGrid);
            this.Controls.Add(this.timKiemButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UI_15_DoiChieuChungTu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Đối Chiếu Chứng Từ";
            this.Load += new System.EventHandler(this.UI_15_DoiChieuChungTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachChungTuGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timKiemButton;
        private System.Windows.Forms.DataGridView danhSachChungTuGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ketQuaDoiChieu;
        private System.Windows.Forms.Button doiChieuButton;
        private System.Windows.Forms.Button button2;
    }
}

