
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    partial class UI_11_TinhKhoanCanThanhToan
    {
        private IContainer components = null;
        private Label labelTitle;
        private Label labelFrom;
        private Label labelTo;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button btnTaiDuLieu;
        private Button btnDoiChieu;
        private Button btnThoat;
        private DataGridView dataGridViewTinhKhoan;
        private TextBox txtTimKiem;
        private Label labelTimKiem;
        private Label lblTongTien;

        private DataGridViewTextBoxColumn colMaDon;
        private DataGridViewTextBoxColumn colNgay;
        private DataGridViewTextBoxColumn colSoTienYeuCau;
        private DataGridViewTextBoxColumn colSoTienThucTe;
        private DataGridViewComboBoxColumn colPhuongThuc;
        private DataGridViewTextBoxColumn colChungTuSo;
        private DataGridViewTextBoxColumn colChungTuNgay;
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
            this.labelFrom = new Label();
            this.labelTo = new Label();
            this.dateTimePickerFrom = new DateTimePicker();
            this.dateTimePickerTo = new DateTimePicker();
            this.btnTaiDuLieu = new Button();
            this.btnDoiChieu = new Button();
            this.btnThoat = new Button();
            this.dataGridViewTinhKhoan = new DataGridView();
            this.txtTimKiem = new TextBox();
            this.labelTimKiem = new Label();
            this.lblTongTien = new Label();

            this.colMaDon = new DataGridViewTextBoxColumn();
            this.colNgay = new DataGridViewTextBoxColumn();
            this.colSoTienYeuCau = new DataGridViewTextBoxColumn();
            this.colSoTienThucTe = new DataGridViewTextBoxColumn();
            this.colPhuongThuc = new DataGridViewComboBoxColumn();
            this.colChungTuSo = new DataGridViewTextBoxColumn();
            this.colChungTuNgay = new DataGridViewTextBoxColumn();
            this.colTrangThai = new DataGridViewTextBoxColumn();

            ((ISupportInitialize)(this.dataGridViewTinhKhoan)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(300, 21);
            this.labelTitle.Text = "Đối chiếu khoản thanh toán (Tính, kiểm tra chứng từ)";

            // labelFrom
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new Point(16, 48);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new Size(50, 15);
            this.labelFrom.Text = "Từ ngày";

            // dateTimePickerFrom
            this.dateTimePickerFrom.Format = DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new Point(72, 44);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new Size(110, 23);

            // labelTo
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new Point(190, 48);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new Size(53, 15);
            this.labelTo.Text = "Đến ngày";

            // dateTimePickerTo
            this.dateTimePickerTo.Format = DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new Point(249, 44);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new Size(110, 23);

            // btnTaiDuLieu
            this.btnTaiDuLieu.Location = new Point(370, 42);
            this.btnTaiDuLieu.Name = "btnTaiDuLieu";
            this.btnTaiDuLieu.Size = new Size(90, 26);
            this.btnTaiDuLieu.Text = "Tải dữ liệu";
            this.btnTaiDuLieu.UseVisualStyleBackColor = true;
            this.btnTaiDuLieu.Click += new System.EventHandler(this.btnTaiDuLieu_Click);

            // labelTimKiem
            this.labelTimKiem.AutoSize = true;
            this.labelTimKiem.Location = new Point(480, 48);
            this.labelTimKiem.Name = "labelTimKiem";
            this.labelTimKiem.Size = new Size(60, 15);
            this.labelTimKiem.Text = "Tìm kiếm";

            // txtTimKiem
            this.txtTimKiem.Location = new Point(546, 44);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new Size(180, 23);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            // dataGridViewTinhKhoan
            this.dataGridViewTinhKhoan.AllowUserToAddRows = false;
            this.dataGridViewTinhKhoan.AllowUserToDeleteRows = false;
            this.dataGridViewTinhKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewTinhKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTinhKhoan.Columns.AddRange(new DataGridViewColumn[] {
                this.colMaDon,
                this.colNgay,
                this.colSoTienYeuCau,
                this.colSoTienThucTe,
                this.colPhuongThuc,
                this.colChungTuSo,
                this.colChungTuNgay,
                this.colTrangThai});
            this.dataGridViewTinhKhoan.Location = new Point(16, 80);
            this.dataGridViewTinhKhoan.MultiSelect = false;
            this.dataGridViewTinhKhoan.Name = "dataGridViewTinhKhoan";
            this.dataGridViewTinhKhoan.ReadOnly = false;
            this.dataGridViewTinhKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTinhKhoan.Size = new Size(930, 320);

            // Columns
            // colMaDon
            this.colMaDon.HeaderText = "Mã hợp đồng";
            this.colMaDon.Name = "colMaDon";
            this.colMaDon.ReadOnly = true;
            this.colMaDon.Width = 120;

            // colNgay
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.Name = "colNgay";
            this.colNgay.ReadOnly = true;
            this.colNgay.Width = 90;

            // colSoTienYeuCau
            this.colSoTienYeuCau.HeaderText = "Số tiền yêu cầu";
            this.colSoTienYeuCau.Name = "colSoTienYeuCau";
            this.colSoTienYeuCau.ReadOnly = true;
            this.colSoTienYeuCau.Width = 120;

            // colSoTienThucTe
            this.colSoTienThucTe.HeaderText = "Số tiền thực tế (chỉnh)";
            this.colSoTienThucTe.Name = "colSoTienThucTe";
            this.colSoTienThucTe.ReadOnly = false;
            this.colSoTienThucTe.Width = 140;

            // colPhuongThuc
            this.colPhuongThuc.HeaderText = "Phương thức";
            this.colPhuongThuc.Name = "colPhuongThuc";
            this.colPhuongThuc.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            this.colPhuongThuc.Width = 110;

            // colChungTuSo
            this.colChungTuSo.HeaderText = "Chứng từ (số)";
            this.colChungTuSo.Name = "colChungTuSo";
            this.colChungTuSo.ReadOnly = false;
            this.colChungTuSo.Width = 150;

            // colChungTuNgay
            this.colChungTuNgay.HeaderText = "Chứng từ (ngày yyyy-MM-dd)";
            this.colChungTuNgay.Name = "colChungTuNgay";
            this.colChungTuNgay.ReadOnly = false;
            this.colChungTuNgay.Width = 150;

            // colTrangThai
            this.colTrangThai.HeaderText = "Trạng thái đối chiếu";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 170;

            // btnDoiChieu
            this.btnDoiChieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnDoiChieu.Location = new Point(760, 410);
            this.btnDoiChieu.Name = "btnDoiChieu";
            this.btnDoiChieu.Size = new Size(120, 30);
            this.btnDoiChieu.Text = "Đối chiếu";
            this.btnDoiChieu.UseVisualStyleBackColor = true;
            this.btnDoiChieu.Click += new System.EventHandler(this.btnDoiChieu_Click);

            // btnThoat
            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnThoat.Location = new Point(892, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(54, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // lblTongTien
            this.lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new Point(16, 418);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new Size(160, 15);
            this.lblTongTien.Text = "Tổng hợp đồng: 0 mục";

            // UI_11_TinhKhoanCanThanhToan Form
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(964, 452);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.btnTaiDuLieu);
            this.Controls.Add(this.labelTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dataGridViewTinhKhoan);
            this.Controls.Add(this.btnDoiChieu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTongTien);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UI_11_TinhKhoanCanThanhToan";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Đối chiếu khoản thanh toán";
            this.Load += new System.EventHandler(this.formLoad);

            ((ISupportInitialize)(this.dataGridViewTinhKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}