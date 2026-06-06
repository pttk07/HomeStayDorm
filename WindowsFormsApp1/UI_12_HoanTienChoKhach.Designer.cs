using System;
using System.ComponentModel;   
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApp1
{
    partial class UI_12_HoanTienChoKhach
    {
        private IContainer components = null;
        private Label labelTitle;
        private Label labelSearch;
        private TextBox txtSearchCustomer;
        private Button btnTraCuu;
        private DataGridView dataGridViewDoiSoat;
        private Label lblSoTienCoc;
        private Label lblTongKhauTru;
        private Label labelSoTienHoan;
        private TextBox txtSoTienHoan;
        private Label labelPhuongThuc;
        private ComboBox cmbPhuongThuc;
        private Label labelChungTu;
        private TextBox txtChungTu;
        private Button btnHoanTien;
        private Button btnCapNhat;
        private Button btnThoat;
        private Label lblStatus;

        private DataGridViewTextBoxColumn colMaDon;
        private DataGridViewTextBoxColumn colKhachHang;
        private DataGridViewTextBoxColumn colSoTienCoc;
        private DataGridViewTextBoxColumn colKhauTru;
        private DataGridViewTextBoxColumn colConLai;
        private DataGridViewTextBoxColumn colTrangThaiDoiSoat;

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
            this.labelSearch = new Label();
            this.txtSearchCustomer = new TextBox();
            this.btnTraCuu = new Button();
            this.dataGridViewDoiSoat = new DataGridView();
            this.lblSoTienCoc = new Label();
            this.lblTongKhauTru = new Label();
            this.labelSoTienHoan = new Label();
            this.txtSoTienHoan = new TextBox();
            this.labelPhuongThuc = new Label();
            this.cmbPhuongThuc = new ComboBox();
            this.labelChungTu = new Label();
            this.txtChungTu = new TextBox();
            this.btnHoanTien = new Button();
            this.btnCapNhat = new Button();
            this.btnThoat = new Button();
            this.lblStatus = new Label();

            this.colMaDon = new DataGridViewTextBoxColumn();
            this.colKhachHang = new DataGridViewTextBoxColumn();
            this.colSoTienCoc = new DataGridViewTextBoxColumn();
            this.colKhauTru = new DataGridViewTextBoxColumn();
            this.colConLai = new DataGridViewTextBoxColumn();
            this.colTrangThaiDoiSoat = new DataGridViewTextBoxColumn();

            ((ISupportInitialize)(this.dataGridViewDoiSoat)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new Size(320, 21);
            this.labelTitle.Text = "Hoàn tiền cho khách - Tra cứu và xử lý giao dịch";

            // labelSearch
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new Point(16, 48);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new Size(120, 15);
            this.labelSearch.Text = "Tìm theo tên/khách hàng";

            // txtSearchCustomer
            this.txtSearchCustomer.Location = new Point(144, 44);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new Size(280, 23);

            // btnTraCuu
            this.btnTraCuu.Location = new Point(432, 42);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new Size(90, 26);
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);

            // dataGridViewDoiSoat
            this.dataGridViewDoiSoat.AllowUserToAddRows = false;
            this.dataGridViewDoiSoat.AllowUserToDeleteRows = false;
            this.dataGridViewDoiSoat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewDoiSoat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoiSoat.Columns.AddRange(new DataGridViewColumn[] {
                this.colMaDon,
                this.colKhachHang,
                this.colSoTienCoc,
                this.colKhauTru,
                this.colConLai,
                this.colTrangThaiDoiSoat});
            this.dataGridViewDoiSoat.Location = new Point(16, 80);
            this.dataGridViewDoiSoat.MultiSelect = false;
            this.dataGridViewDoiSoat.Name = "dataGridViewDoiSoat";
            this.dataGridViewDoiSoat.ReadOnly = false;
            this.dataGridViewDoiSoat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoiSoat.Size = new Size(930, 260);
            this.dataGridViewDoiSoat.SelectionChanged += new System.EventHandler(this.dataGridViewDoiSoat_SelectionChanged);

            // Columns
            // colMaDon
            this.colMaDon.HeaderText = "Mã hợp đồng";
            this.colMaDon.Name = "colMaDon";
            this.colMaDon.ReadOnly = true;
            this.colMaDon.Width = 120;

            // colKhachHang
            this.colKhachHang.HeaderText = "Khách hàng";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.ReadOnly = true;
            this.colKhachHang.Width = 200;

            // colSoTienCoc
            this.colSoTienCoc.HeaderText = "Số tiền cọc";
            this.colSoTienCoc.Name = "colSoTienCoc";
            this.colSoTienCoc.ReadOnly = true;
            this.colSoTienCoc.Width = 120;

            // colKhauTru
            this.colKhauTru.HeaderText = "Khấu trừ phát sinh";
            this.colKhauTru.Name = "colKhauTru";
            this.colKhauTru.ReadOnly = true;
            this.colKhauTru.Width = 140;

            // colConLai
            this.colConLai.HeaderText = "Còn lại";
            this.colConLai.Name = "colConLai";
            this.colConLai.ReadOnly = true;
            this.colConLai.Width = 120;

            // colTrangThaiDoiSoat
            this.colTrangThaiDoiSoat.HeaderText = "Trạng thái đối soát";
            this.colTrangThaiDoiSoat.Name = "colTrangThaiDoiSoat";
            this.colTrangThaiDoiSoat.ReadOnly = true;
            this.colTrangThaiDoiSoat.Width = 150;

            // lblSoTienCoc
            this.lblSoTienCoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.lblSoTienCoc.AutoSize = true;
            this.lblSoTienCoc.Location = new Point(16, 352);
            this.lblSoTienCoc.Name = "lblSoTienCoc";
            this.lblSoTienCoc.Size = new Size(100, 15);
            this.lblSoTienCoc.Text = "Số tiền cọc: 0 đ";

            // lblTongKhauTru
            this.lblTongKhauTru.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.lblTongKhauTru.AutoSize = true;
            this.lblTongKhauTru.Location = new Point(220, 352);
            this.lblTongKhauTru.Name = "lblTongKhauTru";
            this.lblTongKhauTru.Size = new Size(140, 15);
            this.lblTongKhauTru.Text = "Tổng khấu trừ: 0 đ";

            // labelSoTienHoan
            this.labelSoTienHoan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.labelSoTienHoan.AutoSize = true;
            this.labelSoTienHoan.Location = new Point(16, 378);
            this.labelSoTienHoan.Name = "labelSoTienHoan";
            this.labelSoTienHoan.Size = new Size(110, 15);
            this.labelSoTienHoan.Text = "Số tiền thực tế hoàn";

            // txtSoTienHoan
            this.txtSoTienHoan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.txtSoTienHoan.Location = new Point(144, 374);
            this.txtSoTienHoan.Name = "txtSoTienHoan";
            this.txtSoTienHoan.Size = new Size(160, 23);

            // labelPhuongThuc
            this.labelPhuongThuc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.labelPhuongThuc.AutoSize = true;
            this.labelPhuongThuc.Location = new Point(320, 378);
            this.labelPhuongThuc.Name = "labelPhuongThuc";
            this.labelPhuongThuc.Size = new Size(70, 15);
            this.labelPhuongThuc.Text = "Phương thức";

            // cmbPhuongThuc
            this.cmbPhuongThuc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.cmbPhuongThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbPhuongThuc.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            this.cmbPhuongThuc.Location = new Point(396, 374);
            this.cmbPhuongThuc.Name = "cmbPhuongThuc";
            this.cmbPhuongThuc.Size = new Size(140, 23);
            this.cmbPhuongThuc.SelectedIndex = 0;

            // labelChungTu
            this.labelChungTu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.labelChungTu.AutoSize = true;
            this.labelChungTu.Location = new Point(560, 378);
            this.labelChungTu.Name = "labelChungTu";
            this.labelChungTu.Size = new Size(80, 15);
            this.labelChungTu.Text = "Chứng từ/Ref";

            // txtChungTu
            this.txtChungTu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.txtChungTu.Location = new Point(648, 374);
            this.txtChungTu.Name = "txtChungTu";
            this.txtChungTu.Size = new Size(160, 23);

            // btnHoanTien
            this.btnHoanTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnHoanTien.Location = new Point(620, 410);
            this.btnHoanTien.Name = "btnHoanTien";
            this.btnHoanTien.Size = new Size(120, 30);
            this.btnHoanTien.Text = "Hoàn tiền";
            this.btnHoanTien.UseVisualStyleBackColor = true;
            this.btnHoanTien.Click += new System.EventHandler(this.btnHoanTien_Click);

            // btnCapNhat
            this.btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCapNhat.Location = new Point(752, 410);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new Size(100, 30);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // btnThoat
            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnThoat.Location = new Point(872, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(74, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // lblStatus
            this.lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(16, 410);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new Size(0, 15);
            this.lblStatus.Text = "";

            // UI_12_HoanTienChoKhach Form
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(964, 452);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.dataGridViewDoiSoat);
            this.Controls.Add(this.lblSoTienCoc);
            this.Controls.Add(this.lblTongKhauTru);
            this.Controls.Add(this.labelSoTienHoan);
            this.Controls.Add(this.txtSoTienHoan);
            this.Controls.Add(this.labelPhuongThuc);
            this.Controls.Add(this.cmbPhuongThuc);
            this.Controls.Add(this.labelChungTu);
            this.Controls.Add(this.txtChungTu);
            this.Controls.Add(this.btnHoanTien);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblStatus);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UI_12_HoanTienChoKhach";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Hoàn tiền cho khách";
            this.Load += new System.EventHandler(this.formLoad);

            ((ISupportInitialize)(this.dataGridViewDoiSoat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}