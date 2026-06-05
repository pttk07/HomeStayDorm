using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    partial class UI_28_DashboardKeToan
    {
        private IContainer components = null;
        private Panel navPanel;
        private Panel panelContent;
        private Label labelTitle;
        private Label lblHelp;
        private Label lblTotalTasks;
        private Button btnXuatYeuCauThanhToan;
        private Button btnTinhKhoanPhatSinh;
        private Button btnTraCuuHopDong;
        private Button btnLapBangDoiSoat;
        private Button btnDoiChieuKhoanThanhToan;
        private Button btnTinhKhoanCanThanhToan;
        private Button btnHoanTienChoKhach;
        private Button btnCapNhatKetQuaThanhToan;
        private Button btnTaiLai;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();

            this.navPanel = new Panel();
            this.btnCapNhatKetQuaThanhToan = new Button();
            this.btnHoanTienChoKhach = new Button();
            this.btnTinhKhoanCanThanhToan = new Button();
            this.btnDoiChieuKhoanThanhToan = new Button();
            this.btnLapBangDoiSoat = new Button();
            this.btnTraCuuHopDong = new Button();
            this.btnTinhKhoanPhatSinh = new Button();
            this.btnXuatYeuCauThanhToan = new Button();

            this.panelContent = new Panel();
            this.labelTitle = new Label();
            this.lblHelp = new Label();
            this.lblTotalTasks = new Label();
            this.btnTaiLai = new Button();
            this.btnThoat = new Button();

            // navPanel (left navbar)
            this.navPanel.Dock = DockStyle.Left;
            this.navPanel.Width = 260;
            this.navPanel.BackColor = Color.FromArgb(250, 250, 250);
            this.navPanel.Padding = new Padding(8);
            this.navPanel.BorderStyle = BorderStyle.None;

            // Common button style
            Size navBtnSize = new Size(240, 44);
            Padding navBtnMargin = new Padding(0, 4, 0, 4);

            // btnXuatYeuCauThanhToan
            this.btnXuatYeuCauThanhToan.Name = "btnXuatYeuCauThanhToan";
            this.btnXuatYeuCauThanhToan.Text = "Xuất yêu cầu thanh toán (Tính toán tiền cọc)";
            this.btnXuatYeuCauThanhToan.Size = navBtnSize;
            this.btnXuatYeuCauThanhToan.Margin = navBtnMargin;
            this.btnXuatYeuCauThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            this.btnXuatYeuCauThanhToan.Dock = DockStyle.Top;
            this.btnXuatYeuCauThanhToan.FlatStyle = FlatStyle.System;
            this.btnXuatYeuCauThanhToan.Click += new System.EventHandler(this.btnXuatYeuCauThanhToan_Click);

            // btnTinhKhoanPhatSinh
            this.btnTinhKhoanPhatSinh.Name = "btnTinhKhoanPhatSinh";
            this.btnTinhKhoanPhatSinh.Text = "Tính khoản phát sinh";
            this.btnTinhKhoanPhatSinh.Size = navBtnSize;
            this.btnTinhKhoanPhatSinh.Margin = navBtnMargin;
            this.btnTinhKhoanPhatSinh.TextAlign = ContentAlignment.MiddleLeft;
            this.btnTinhKhoanPhatSinh.Dock = DockStyle.Top;
            this.btnTinhKhoanPhatSinh.FlatStyle = FlatStyle.System;
            this.btnTinhKhoanPhatSinh.Click += new System.EventHandler(this.btnTinhKhoanPhatSinh_Click);

            // btnTraCuuHopDong
            this.btnTraCuuHopDong.Name = "btnTraCuuHopDong";
            this.btnTraCuuHopDong.Text = "Tra cứu hợp đồng";
            this.btnTraCuuHopDong.Size = navBtnSize;
            this.btnTraCuuHopDong.Margin = navBtnMargin;
            this.btnTraCuuHopDong.TextAlign = ContentAlignment.MiddleLeft;
            this.btnTraCuuHopDong.Dock = DockStyle.Top;
            this.btnTraCuuHopDong.FlatStyle = FlatStyle.System;
            this.btnTraCuuHopDong.Click += new System.EventHandler(this.btnTraCuuHopDong_Click);

            // btnLapBangDoiSoat
            this.btnLapBangDoiSoat.Name = "btnLapBangDoiSoat";
            this.btnLapBangDoiSoat.Text = "Lập bảng đối soát";
            this.btnLapBangDoiSoat.Size = navBtnSize;
            this.btnLapBangDoiSoat.Margin = navBtnMargin;
            this.btnLapBangDoiSoat.TextAlign = ContentAlignment.MiddleLeft;
            this.btnLapBangDoiSoat.Dock = DockStyle.Top;
            this.btnLapBangDoiSoat.FlatStyle = FlatStyle.System;
            this.btnLapBangDoiSoat.Click += new System.EventHandler(this.btnLapBangDoiSoat_Click);

            // btnDoiChieuKhoanThanhToan
            this.btnDoiChieuKhoanThanhToan.Name = "btnDoiChieuKhoanThanhToan";
            this.btnDoiChieuKhoanThanhToan.Text = "Đối chiếu khoản thanh toán";
            this.btnDoiChieuKhoanThanhToan.Size = navBtnSize;
            this.btnDoiChieuKhoanThanhToan.Margin = navBtnMargin;
            this.btnDoiChieuKhoanThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            this.btnDoiChieuKhoanThanhToan.Dock = DockStyle.Top;
            this.btnDoiChieuKhoanThanhToan.FlatStyle = FlatStyle.System;
            this.btnDoiChieuKhoanThanhToan.Click += new System.EventHandler(this.btnDoiChieuKhoanThanhToan_Click);

            // btnTinhKhoanCanThanhToan
            this.btnTinhKhoanCanThanhToan.Name = "btnTinhKhoanCanThanhToan";
            this.btnTinhKhoanCanThanhToan.Text = "Tính khoản cần thanh toán";
            this.btnTinhKhoanCanThanhToan.Size = navBtnSize;
            this.btnTinhKhoanCanThanhToan.Margin = navBtnMargin;
            this.btnTinhKhoanCanThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            this.btnTinhKhoanCanThanhToan.Dock = DockStyle.Top;
            this.btnTinhKhoanCanThanhToan.FlatStyle = FlatStyle.System;
            this.btnTinhKhoanCanThanhToan.Click += new System.EventHandler(this.btnTinhKhoanCanThanhToan_Click);

            // btnHoanTienChoKhach
            this.btnHoanTienChoKhach.Name = "btnHoanTienChoKhach";
            this.btnHoanTienChoKhach.Text = "Hoàn tiền cho khách";
            this.btnHoanTienChoKhach.Size = navBtnSize;
            this.btnHoanTienChoKhach.Margin = navBtnMargin;
            this.btnHoanTienChoKhach.TextAlign = ContentAlignment.MiddleLeft;
            this.btnHoanTienChoKhach.Dock = DockStyle.Top;
            this.btnHoanTienChoKhach.FlatStyle = FlatStyle.System;
            this.btnHoanTienChoKhach.Click += new System.EventHandler(this.btnHoanTienChoKhach_Click);

            // btnCapNhatKetQuaThanhToan
            this.btnCapNhatKetQuaThanhToan.Name = "btnCapNhatKetQuaThanhToan";
            this.btnCapNhatKetQuaThanhToan.Text = "Cập nhật kết quả thanh toán";
            this.btnCapNhatKetQuaThanhToan.Size = navBtnSize;
            this.btnCapNhatKetQuaThanhToan.Margin = navBtnMargin;
            this.btnCapNhatKetQuaThanhToan.TextAlign = ContentAlignment.MiddleLeft;
            this.btnCapNhatKetQuaThanhToan.Dock = DockStyle.Top;
            this.btnCapNhatKetQuaThanhToan.FlatStyle = FlatStyle.System;
            this.btnCapNhatKetQuaThanhToan.Click += new System.EventHandler(this.btnCapNhatKetQuaThanhToan_Click);

            // Add buttons to navPanel (order top to bottom)
            this.navPanel.Controls.Add(this.btnCapNhatKetQuaThanhToan);
            this.navPanel.Controls.Add(this.btnHoanTienChoKhach);
            this.navPanel.Controls.Add(this.btnTinhKhoanCanThanhToan);
            this.navPanel.Controls.Add(this.btnDoiChieuKhoanThanhToan);
            this.navPanel.Controls.Add(this.btnLapBangDoiSoat);
            this.navPanel.Controls.Add(this.btnTraCuuHopDong);
            this.navPanel.Controls.Add(this.btnTinhKhoanPhatSinh);
            this.navPanel.Controls.Add(this.btnXuatYeuCauThanhToan);

            // panelContent (right area)
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.Padding = new Padding(12);

  

   

            // btnThoat (content area bottom-right)
            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnThoat.Location = new Point(848, 372);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(80, 26);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Add content controls
            this.panelContent.Controls.Add(this.labelTitle);
            this.panelContent.Controls.Add(this.lblHelp);
            this.panelContent.Controls.Add(this.lblTotalTasks);
            this.panelContent.Controls.Add(this.btnTaiLai);

            // Form - combine panels
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.btnThoat); // btnThoat anchored to form

            // Form properties
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(944, 415);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UI_28_DashboardKeToan";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Dashboard Kế toán";
            this.Load += new System.EventHandler(this.formLoad);

            // finalize
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}