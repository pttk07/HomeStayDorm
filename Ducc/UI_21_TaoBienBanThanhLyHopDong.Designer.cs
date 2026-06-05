namespace Ducc
{
    partial class UI_21_TaoBienBanThanhLyHopDong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox hopDongComboBox;
        private System.Windows.Forms.Button taiDuLieuButton;
        private System.Windows.Forms.DataGridView phatSinhGrid;
        private System.Windows.Forms.Label tongTienLabel;
        private System.Windows.Forms.Button hoanThanhButton;
        private System.Windows.Forms.Label trangThaiLabel;

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
            this.hopDongComboBox = new System.Windows.Forms.ComboBox();
            this.taiDuLieuButton = new System.Windows.Forms.Button();
            this.phatSinhGrid = new System.Windows.Forms.DataGridView();
            this.tongTienLabel = new System.Windows.Forms.Label();
            this.hoanThanhButton = new System.Windows.Forms.Button();
            this.trangThaiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thongTinHopDong = new System.Windows.Forms.Label();
            this.ThongTInHopDongdataGridView = new System.Windows.Forms.DataGridView();
            this.khoanPhatSinh = new System.Windows.Forms.Label();
            this.themKhoanPhatSinhButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phatSinhGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTInHopDongdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hopDongComboBox
            // 
            this.hopDongComboBox.FormattingEnabled = true;
            this.hopDongComboBox.Location = new System.Drawing.Point(248, 30);
            this.hopDongComboBox.Name = "hopDongComboBox";
            this.hopDongComboBox.Size = new System.Drawing.Size(181, 28);
            this.hopDongComboBox.TabIndex = 0;
            // 
            // taiDuLieuButton
            // 
            this.taiDuLieuButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.taiDuLieuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taiDuLieuButton.Location = new System.Drawing.Point(441, 26);
            this.taiDuLieuButton.Name = "taiDuLieuButton";
            this.taiDuLieuButton.Size = new System.Drawing.Size(100, 34);
            this.taiDuLieuButton.TabIndex = 1;
            this.taiDuLieuButton.Text = "Tải dữ liệu";
            this.taiDuLieuButton.UseVisualStyleBackColor = false;
            this.taiDuLieuButton.Click += new System.EventHandler(this.taiDuLieuButton_Click);
            // 
            // phatSinhGrid
            // 
            this.phatSinhGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phatSinhGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phatSinhGrid.Location = new System.Drawing.Point(30, 333);
            this.phatSinhGrid.Name = "phatSinhGrid";
            this.phatSinhGrid.RowHeadersWidth = 62;
            this.phatSinhGrid.Size = new System.Drawing.Size(645, 148);
            this.phatSinhGrid.TabIndex = 2;
            // 
            // tongTienLabel
            // 
            this.tongTienLabel.AutoSize = true;
            this.tongTienLabel.Location = new System.Drawing.Point(30, 532);
            this.tongTienLabel.Name = "tongTienLabel";
            this.tongTienLabel.Size = new System.Drawing.Size(274, 20);
            this.tongTienLabel.TabIndex = 4;
            this.tongTienLabel.Text = "Tổng số tiền cần thanh toán/hoàn trả:";
            // 
            // hoanThanhButton
            // 
            this.hoanThanhButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.hoanThanhButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hoanThanhButton.Location = new System.Drawing.Point(527, 614);
            this.hoanThanhButton.Name = "hoanThanhButton";
            this.hoanThanhButton.Size = new System.Drawing.Size(130, 30);
            this.hoanThanhButton.TabIndex = 5;
            this.hoanThanhButton.Text = "Hoàn thành";
            this.hoanThanhButton.UseVisualStyleBackColor = false;
            this.hoanThanhButton.Click += new System.EventHandler(this.hoanThanhButton_Click);
            // 
            // trangThaiLabel
            // 
            this.trangThaiLabel.AutoSize = true;
            this.trangThaiLabel.Location = new System.Drawing.Point(30, 565);
            this.trangThaiLabel.Name = "trangThaiLabel";
            this.trangThaiLabel.Size = new System.Drawing.Size(171, 20);
            this.trangThaiLabel.TabIndex = 6;
            this.trangThaiLabel.Text = "Trạng thái hợp đồng: ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn hợp đồng cần thanh lý";
            // 
            // thongTinHopDong
            // 
            this.thongTinHopDong.AutoSize = true;
            this.thongTinHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinHopDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.thongTinHopDong.Location = new System.Drawing.Point(30, 90);
            this.thongTinHopDong.Name = "thongTinHopDong";
            this.thongTinHopDong.Size = new System.Drawing.Size(164, 20);
            this.thongTinHopDong.TabIndex = 9;
            this.thongTinHopDong.Text = "Thông tin hợp đồng";
            // 
            // ThongTInHopDongdataGridView
            // 
            this.ThongTInHopDongdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThongTInHopDongdataGridView.Location = new System.Drawing.Point(30, 119);
            this.ThongTInHopDongdataGridView.Name = "ThongTInHopDongdataGridView";
            this.ThongTInHopDongdataGridView.RowHeadersWidth = 62;
            this.ThongTInHopDongdataGridView.RowTemplate.Height = 28;
            this.ThongTInHopDongdataGridView.Size = new System.Drawing.Size(644, 147);
            this.ThongTInHopDongdataGridView.TabIndex = 10;
            // 
            // khoanPhatSinh
            // 
            this.khoanPhatSinh.AutoSize = true;
            this.khoanPhatSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoanPhatSinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.khoanPhatSinh.Location = new System.Drawing.Point(26, 297);
            this.khoanPhatSinh.Name = "khoanPhatSinh";
            this.khoanPhatSinh.Size = new System.Drawing.Size(139, 20);
            this.khoanPhatSinh.TabIndex = 11;
            this.khoanPhatSinh.Text = "Khoản phát sinh";
            // 
            // themKhoanPhatSinhButton
            // 
            this.themKhoanPhatSinhButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.themKhoanPhatSinhButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.themKhoanPhatSinhButton.Location = new System.Drawing.Point(225, 487);
            this.themKhoanPhatSinhButton.Name = "themKhoanPhatSinhButton";
            this.themKhoanPhatSinhButton.Size = new System.Drawing.Size(235, 34);
            this.themKhoanPhatSinhButton.TabIndex = 12;
            this.themKhoanPhatSinhButton.Text = "Thêm khoản phát sinh";
            this.themKhoanPhatSinhButton.UseVisualStyleBackColor = false;
            this.themKhoanPhatSinhButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UI_21_TaoBienBanThanhLyHopDong
            // 
            this.ClientSize = new System.Drawing.Size(721, 666);
            this.Controls.Add(this.themKhoanPhatSinhButton);
            this.Controls.Add(this.khoanPhatSinh);
            this.Controls.Add(this.ThongTInHopDongdataGridView);
            this.Controls.Add(this.thongTinHopDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hopDongComboBox);
            this.Controls.Add(this.taiDuLieuButton);
            this.Controls.Add(this.phatSinhGrid);
            this.Controls.Add(this.tongTienLabel);
            this.Controls.Add(this.hoanThanhButton);
            this.Controls.Add(this.trangThaiLabel);
            this.Name = "UI_21_TaoBienBanThanhLyHopDong";
            this.Text = "Tạo biên bản thanh lý hợp đồng";
            this.Load += new System.EventHandler(this.FormThanhLyHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phatSinhGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTInHopDongdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label thongTinHopDong;
        private System.Windows.Forms.DataGridView ThongTInHopDongdataGridView;
        private System.Windows.Forms.Label khoanPhatSinh;
        private System.Windows.Forms.Button themKhoanPhatSinhButton;
    }
}
