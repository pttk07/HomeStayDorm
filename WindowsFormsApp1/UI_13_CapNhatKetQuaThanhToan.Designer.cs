using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    partial class UI_13_CapNhatKetQuaThanhToan
    {
        private IContainer components = null;

        private Label labelTitle;
        private TextBox txtTimKiem;
        private Button btnTaiDanhSach;
        private DataGridView dataGridViewChoXuLy;

        private GroupBox groupBoxChiTiet;
        private Label labelMaHoSo;
        private Label lblChiTietMaHoSo;
        private Label labelKhachHang;
        private Label lblChiTietKhachHang;
        private Label labelLoai;
        private Label lblChiTietLoai;
        private Label labelSoTien;
        private Label lblChiTietSoTien;

        private Label labelSoTienGiaoDich;
        private TextBox txtSoTienGiaoDich;
        private Label labelPhuongThucGiaoDich;
        private ComboBox cmbPhuongThucGiaoDich;
        private Label labelNgayThanhToan;
        private DateTimePicker dateTimePickerNgayThanhToan;
        private Label labelMaGiaoDich;
        private TextBox txtMaGiaoDich;
        private Label labelKetQua;
        private ComboBox txtKetQuaThanhToan;
        private Label labelGhiChu;
        private TextBox txtGhiChu;

        private Button btnHoanThanh;
        private Button btnCapNhat;
        private Button btnThoat;

        private DataGridViewTextBoxColumn colMaHoSo;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn colLoai;
        private DataGridViewTextBoxColumn colSoTienYeuCau;
        private DataGridViewTextBoxColumn colTrangThai;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();

            this.labelTitle = new Label();
            this.txtTimKiem = new TextBox();
            this.btnTaiDanhSach = new Button();
            this.dataGridViewChoXuLy = new DataGridView();

            this.groupBoxChiTiet = new GroupBox();
            this.labelMaHoSo = new Label();
            this.lblChiTietMaHoSo = new Label();
            this.labelKhachHang = new Label();
            this.lblChiTietKhachHang = new Label();
            this.labelLoai = new Label();
            this.lblChiTietLoai = new Label();
            this.labelSoTien = new Label();
            this.lblChiTietSoTien = new Label();

            this.labelSoTienGiaoDich = new Label();
            this.txtSoTienGiaoDich = new TextBox();
            this.labelPhuongThucGiaoDich = new Label();
            this.cmbPhuongThucGiaoDich = new ComboBox();
            this.labelNgayThanhToan = new Label();
            this.dateTimePickerNgayThanhToan = new DateTimePicker();
            this.labelMaGiaoDich = new Label();
            this.txtMaGiaoDich = new TextBox();
            this.labelKetQua = new Label();
            this.txtKetQuaThanhToan = new ComboBox();
            this.labelGhiChu = new Label();
            this.txtGhiChu = new TextBox();

            this.btnHoanThanh = new Button();
            this.btnCapNhat = new Button();
            this.btnThoat = new Button();

            this.colMaHoSo = new DataGridViewTextBoxColumn();
            this.colKhachHang = new DataGridViewTextBoxColumn();
            this.colLoai = new DataGridViewTextBoxColumn();
            this.colSoTienYeuCau = new DataGridViewTextBoxColumn();
            this.colTrangThai = new DataGridViewTextBoxColumn();

            ((ISupportInitialize)(this.dataGridViewChoXuLy)).BeginInit();
            this.groupBoxChiTiet.SuspendLayout();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(380, 21);
            this.labelTitle.Text = "Cập nhật kết quả thanh toán - Danh sách hồ sơ chờ xử lý";

            // txtTimKiem
            this.txtTimKiem.Location = new Point(16, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new Size(360, 23);
  
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // btnTaiDanhSach
            this.btnTaiDanhSach.Location = new Point(388, 40);
            this.btnTaiDanhSach.Name = "btnTaiDanhSach";
            this.btnTaiDanhSach.Size = new Size(100, 26);
            this.btnTaiDanhSach.Text = "Tải danh sách";
            this.btnTaiDanhSach.UseVisualStyleBackColor = true;
            this.btnTaiDanhSach.Click += new System.EventHandler(this.btnTaiDanhSach_Click);

            // dataGridViewChoXuLy
            this.dataGridViewChoXuLy.AllowUserToAddRows = false;
            this.dataGridViewChoXuLy.AllowUserToDeleteRows = false;
            this.dataGridViewChoXuLy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.dataGridViewChoXuLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChoXuLy.Columns.AddRange(new DataGridViewColumn[] {
                this.colMaHoSo,
                this.colKhachHang,
                this.colLoai,
                this.colSoTienYeuCau,
                this.colTrangThai});
            this.dataGridViewChoXuLy.Location = new Point(16, 80);
            this.dataGridViewChoXuLy.MultiSelect = false;
            this.dataGridViewChoXuLy.Name = "dataGridViewChoXuLy";
            this.dataGridViewChoXuLy.ReadOnly = false;
            this.dataGridViewChoXuLy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChoXuLy.Size = new Size(540, 330);
            this.dataGridViewChoXuLy.SelectionChanged += new System.EventHandler(this.dataGridViewChoXuLy_SelectionChanged);

            // Columns for dataGridViewChoXuLy
            // colMaHoSo
            this.colMaHoSo.HeaderText = "Mã hồ sơ";
            this.colMaHoSo.Name = "colMaHoSo";
            this.colMaHoSo.ReadOnly = true;
            this.colMaHoSo.Width = 100;

            // colKhachHang
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.ReadOnly = true;
            this.colKhachHang.Width = 180;

            // colLoai
            this.colLoai.HeaderText = "Loại";
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            this.colLoai.Width = 80;

            // colSoTienYeuCau
            this.colSoTienYeuCau.HeaderText = "Số tiền yêu cầu";
            this.colSoTienYeuCau.Name = "colSoTienYeuCau";
            this.colSoTienYeuCau.ReadOnly = true;
            this.colSoTienYeuCau.Width = 120;

            // colTrangThai
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 120;

            // groupBoxChiTiet (phần thông tin chi tiết bên phải)
            this.groupBoxChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            this.groupBoxChiTiet.Location = new Point(572, 80);
            this.groupBoxChiTiet.Name = "groupBoxChiTiet";
            this.groupBoxChiTiet.Size = new Size(360, 330);
            this.groupBoxChiTiet.Text = "Chi tiết & nhập kết quả";

            // labelMaHoSo
            this.labelMaHoSo.AutoSize = true;
            this.labelMaHoSo.Location = new Point(12, 22);
            this.labelMaHoSo.Text = "Mã hồ sơ:";

            // lblChiTietMaHoSo
            this.lblChiTietMaHoSo.AutoSize = true;
            this.lblChiTietMaHoSo.Location = new Point(120, 22);
            this.lblChiTietMaHoSo.Name = "lblChiTietMaHoSo";
            this.lblChiTietMaHoSo.Size = new Size(0, 15);
            // labelKhachHang
            this.labelKhachHang.AutoSize = true;
            this.labelKhachHang.Location = new Point(12, 45);
            this.labelKhachHang.Text = "Khách hàng:";
            // lblChiTietKhachHang
            this.lblChiTietKhachHang.AutoSize = true;
            this.lblChiTietKhachHang.Location = new Point(120, 45);
            this.lblChiTietKhachHang.Name = "lblChiTietKhachHang";
            this.lblChiTietKhachHang.Size = new Size(0, 15);

            // labelLoai
            this.labelLoai.AutoSize = true;
            this.labelLoai.Location = new Point(12, 68);
            this.labelLoai.Text = "Loại:";
            // lblChiTietLoai
            this.lblChiTietLoai.AutoSize = true;
            this.lblChiTietLoai.Location = new Point(120, 68);
            this.lblChiTietLoai.Name = "lblChiTietLoai";
            this.lblChiTietLoai.Size = new Size(0, 15);

            // labelSoTien
            this.labelSoTien.AutoSize = true;
            this.labelSoTien.Location = new Point(12, 91);
            this.labelSoTien.Text = "Số tiền yêu cầu:";
            // lblChiTietSoTien
            this.lblChiTietSoTien.AutoSize = true;
            this.lblChiTietSoTien.Location = new Point(120, 91);
            this.lblChiTietSoTien.Name = "lblChiTietSoTien";
            this.lblChiTietSoTien.Size = new Size(0, 15);

            // labelSoTienGiaoDich
            this.labelSoTienGiaoDich.AutoSize = true;
            this.labelSoTienGiaoDich.Location = new Point(12, 120);
            this.labelSoTienGiaoDich.Text = "Số tiền giao dịch:";
            // txtSoTienGiaoDich
            this.txtSoTienGiaoDich.Location = new Point(120, 116);
            this.txtSoTienGiaoDich.Name = "txtSoTienGiaoDich";
            this.txtSoTienGiaoDich.Size = new Size(220, 23);

            // labelPhuongThucGiaoDich
            this.labelPhuongThucGiaoDich.AutoSize = true;
            this.labelPhuongThucGiaoDich.Location = new Point(12, 150);
            this.labelPhuongThucGiaoDich.Text = "Phương thức:";
            // cmbPhuongThucGiaoDich
            this.cmbPhuongThucGiaoDich.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPhuongThucGiaoDich.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            this.cmbPhuongThucGiaoDich.Location = new Point(120, 146);
            this.cmbPhuongThucGiaoDich.Name = "cmbPhuongThucGiaoDich";
            this.cmbPhuongThucGiaoDich.Size = new Size(220, 23);
            this.cmbPhuongThucGiaoDich.SelectedIndex = 0;

            // labelNgayThanhToan
            this.labelNgayThanhToan.AutoSize = true;
            this.labelNgayThanhToan.Location = new Point(12, 180);
            this.labelNgayThanhToan.Text = "Ngày thanh toán:";
            // dateTimePickerNgayThanhToan
            this.dateTimePickerNgayThanhToan.Format = DateTimePickerFormat.Short;
            this.dateTimePickerNgayThanhToan.Location = new Point(120, 176);
            this.dateTimePickerNgayThanhToan.Name = "dateTimePickerNgayThanhToan";
            this.dateTimePickerNgayThanhToan.Size = new Size(220, 23);

            // labelMaGiaoDich
            this.labelMaGiaoDich.AutoSize = true;
            this.labelMaGiaoDich.Location = new Point(12, 210);
            this.labelMaGiaoDich.Text = "Mã giao dịch/Ref:";
            // txtMaGiaoDich
            this.txtMaGiaoDich.Location = new Point(120, 206);
            this.txtMaGiaoDich.Name = "txtMaGiaoDich";
            this.txtMaGiaoDich.Size = new Size(220, 23);

            // labelKetQua
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Location = new Point(12, 240);
            this.labelKetQua.Text = "Kết quả thanh toán:";
            // txtKetQuaThanhToan (ComboBox)
            this.txtKetQuaThanhToan.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txtKetQuaThanhToan.Items.AddRange(new object[] { "Thanh toán thành công", "Hoàn trả", "Không hợp lệ/Chênh lệch" });
            this.txtKetQuaThanhToan.Location = new Point(120, 236);
            this.txtKetQuaThanhToan.Name = "txtKetQuaThanhToan";
            this.txtKetQuaThanhToan.Size = new Size(220, 23);
            this.txtKetQuaThanhToan.SelectedIndex = 0;

            // labelGhiChu
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Location = new Point(12, 270);
            this.labelGhiChu.Text = "Ghi chú:";
            // txtGhiChu
            this.txtGhiChu.Location = new Point(120, 266);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new Size(220, 50);

            // Buttons
            this.btnHoanThanh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnHoanThanh.Location = new Point(580, 420);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new Size(110, 30);
            this.btnHoanThanh.Text = "Hoàn thành";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);

            this.btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCapNhat.Location = new Point(700, 420);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new Size(100, 30);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnThoat.Location = new Point(820, 420);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(110, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Build groupBoxChiTiet controls
            this.groupBoxChiTiet.Controls.Add(this.labelMaHoSo);
            this.groupBoxChiTiet.Controls.Add(this.lblChiTietMaHoSo);
            this.groupBoxChiTiet.Controls.Add(this.labelKhachHang);
            this.groupBoxChiTiet.Controls.Add(this.lblChiTietKhachHang);
            this.groupBoxChiTiet.Controls.Add(this.labelLoai);
            this.groupBoxChiTiet.Controls.Add(this.lblChiTietLoai);
            this.groupBoxChiTiet.Controls.Add(this.labelSoTien);
            this.groupBoxChiTiet.Controls.Add(this.lblChiTietSoTien);

            this.groupBoxChiTiet.Controls.Add(this.labelSoTienGiaoDich);
            this.groupBoxChiTiet.Controls.Add(this.txtSoTienGiaoDich);
            this.groupBoxChiTiet.Controls.Add(this.labelPhuongThucGiaoDich);
            this.groupBoxChiTiet.Controls.Add(this.cmbPhuongThucGiaoDich);
            this.groupBoxChiTiet.Controls.Add(this.labelNgayThanhToan);
            this.groupBoxChiTiet.Controls.Add(this.dateTimePickerNgayThanhToan);
            this.groupBoxChiTiet.Controls.Add(this.labelMaGiaoDich);
            this.groupBoxChiTiet.Controls.Add(this.txtMaGiaoDich);
            this.groupBoxChiTiet.Controls.Add(this.labelKetQua);
            this.groupBoxChiTiet.Controls.Add(this.txtKetQuaThanhToan);
            this.groupBoxChiTiet.Controls.Add(this.labelGhiChu);
            this.groupBoxChiTiet.Controls.Add(this.txtGhiChu);

            // UI_13_CapNhatKetQuaThanhToan Form
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(948, 462);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTaiDanhSach);
            this.Controls.Add(this.dataGridViewChoXuLy);
            this.Controls.Add(this.groupBoxChiTiet);
            this.Controls.Add(this.btnHoanThanh);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UI_13_CapNhatKetQuaThanhToan";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Cập nhật kết quả thanh toán";
            this.Load += new System.EventHandler(this.formLoad);

            ((ISupportInitialize)(this.dataGridViewChoXuLy)).EndInit();
            this.groupBoxChiTiet.ResumeLayout(false);
            this.groupBoxChiTiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}