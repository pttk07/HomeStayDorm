namespace WindowsFormsApp1
{
    partial class UI_24a_DangKyThongTinKhach
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Controls ────────────────────────────────────────────────
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();

            this.grpThongTinCaNhan = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.grpYeuCauThue = new System.Windows.Forms.GroupBox();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.txtSoNguoi = new System.Windows.Forms.TextBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lblMucGia = new System.Windows.Forms.Label();
            this.cboMucGia = new System.Windows.Forms.ComboBox();
            this.lblNgayVaoO = new System.Windows.Forms.Label();
            this.dtpNgayVaoO = new System.Windows.Forms.DateTimePicker();
            this.lblThoiHanThue = new System.Windows.Forms.Label();
            this.cboThoiHanThue = new System.Windows.Forms.ComboBox();

            this.grpTieuChi = new System.Windows.Forms.GroupBox();
            this.chkDieuHoa = new System.Windows.Forms.CheckBox();
            this.chkGuiXe = new System.Windows.Forms.CheckBox();
            this.chkYenTinh = new System.Windows.Forms.CheckBox();
            this.chkWifi = new System.Windows.Forms.CheckBox();

            this.grpGhiChu = new System.Windows.Forms.GroupBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();

            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            // ── Suspend layout ──────────────────────────────────────────
            this.pnlHeader.SuspendLayout();
            this.grpThongTinCaNhan.SuspendLayout();
            this.grpYeuCauThue.SuspendLayout();
            this.grpTieuChi.SuspendLayout();
            this.grpGhiChu.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // ── Form ────────────────────────────────────────────────────
            this.Text = "Đăng Ký Thông Tin Khách Thuê – UC 24a";
            this.ClientSize = new System.Drawing.Size(760, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // ── pnlHeader ───────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 72;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 8, 10, 8);

            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDe.Text = "ĐĂNG KÝ THÔNG TIN KHÁCH THUÊ";
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;

            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(20, 38);
            this.lblMoTa.Text = "Tiếp nhận và ghi nhận thông tin yêu cầu của khách hàng – UC 24a";
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Italic);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(180, 210, 240);

            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblMoTa);

            // ────────────────────────────────────────────────────────────
            // grpThongTinCaNhan  (Left col, top)
            // ────────────────────────────────────────────────────────────
            this.grpThongTinCaNhan.Text = "Thông tin cá nhân";
            this.grpThongTinCaNhan.Location = new System.Drawing.Point(18, 88);
            this.grpThongTinCaNhan.Size = new System.Drawing.Size(356, 210);
            this.grpThongTinCaNhan.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpThongTinCaNhan.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.grpThongTinCaNhan.BackColor = System.Drawing.Color.White;

            int lx = 12, cx = 130, gy = 26, rowH = 36;

            // Họ và tên
            this.lblHoTen.Text = "Họ và tên (*)";
            this.lblHoTen.Location = new System.Drawing.Point(lx, gy + 0 * rowH + 4);
            this.lblHoTen.Size = new System.Drawing.Size(110, 20);
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtHoTen.Location = new System.Drawing.Point(cx, gy + 0 * rowH);
            this.txtHoTen.Size = new System.Drawing.Size(208, 24);

            // Giới tính
            this.lblGioiTinh.Text = "Giới tính (*)";
            this.lblGioiTinh.Location = new System.Drawing.Point(lx, gy + 1 * rowH + 4);
            this.lblGioiTinh.Size = new System.Drawing.Size(110, 20);
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.radNam.Text = "Nam";
            this.radNam.Location = new System.Drawing.Point(cx, gy + 1 * rowH + 2);
            this.radNam.Size = new System.Drawing.Size(54, 22);
            this.radNam.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.radNu.Text = "Nữ";
            this.radNu.Location = new System.Drawing.Point(cx + 60, gy + 1 * rowH + 2);
            this.radNu.Size = new System.Drawing.Size(54, 22);
            this.radNu.Font = new System.Drawing.Font("Segoe UI", 9f);

            // Số điện thoại
            this.lblSoDienThoai.Text = "Số điện thoại (*)";
            this.lblSoDienThoai.Location = new System.Drawing.Point(lx, gy + 2 * rowH + 4);
            this.lblSoDienThoai.Size = new System.Drawing.Size(115, 20);
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtSoDienThoai.Location = new System.Drawing.Point(cx, gy + 2 * rowH);
            this.txtSoDienThoai.Size = new System.Drawing.Size(208, 24);

            // Email
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new System.Drawing.Point(lx, gy + 3 * rowH + 4);
            this.lblEmail.Size = new System.Drawing.Size(110, 20);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtEmail.Location = new System.Drawing.Point(cx, gy + 3 * rowH);
            this.txtEmail.Size = new System.Drawing.Size(208, 24);

            this.grpThongTinCaNhan.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblHoTen, txtHoTen, lblGioiTinh, radNam, radNu,
                lblSoDienThoai, txtSoDienThoai, lblEmail, txtEmail
            });

            // ────────────────────────────────────────────────────────────
            // grpYeuCauThue  (Right col, top)
            // ────────────────────────────────────────────────────────────
            this.grpYeuCauThue.Text = "Yêu cầu thuê phòng";
            this.grpYeuCauThue.Location = new System.Drawing.Point(392, 88);
            this.grpYeuCauThue.Size = new System.Drawing.Size(354, 210);
            this.grpYeuCauThue.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpYeuCauThue.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.grpYeuCauThue.BackColor = System.Drawing.Color.White;

            int lx2 = 12, cx2 = 142;

            // Số người dự kiến
            this.lblSoNguoi.Text = "Số người dự kiến (*)";
            this.lblSoNguoi.Location = new System.Drawing.Point(lx2, gy + 0 * rowH + 4);
            this.lblSoNguoi.Size = new System.Drawing.Size(128, 20);
            this.lblSoNguoi.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSoNguoi.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtSoNguoi.Location = new System.Drawing.Point(cx2, gy + 0 * rowH);
            this.txtSoNguoi.Size = new System.Drawing.Size(60, 24);

            // Khu vực mong muốn
            this.lblKhuVuc.Text = "Khu vực mong muốn";
            this.lblKhuVuc.Location = new System.Drawing.Point(lx2, gy + 1 * rowH + 4);
            this.lblKhuVuc.Size = new System.Drawing.Size(128, 20);
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblKhuVuc.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cboKhuVuc.Location = new System.Drawing.Point(cx2, gy + 1 * rowH);
            this.cboKhuVuc.Size = new System.Drawing.Size(196, 24);
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Loại phòng
            this.lblLoaiPhong.Text = "Loại phòng";
            this.lblLoaiPhong.Location = new System.Drawing.Point(lx2, gy + 2 * rowH + 4);
            this.lblLoaiPhong.Size = new System.Drawing.Size(128, 20);
            this.lblLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblLoaiPhong.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cboLoaiPhong.Location = new System.Drawing.Point(cx2, gy + 2 * rowH);
            this.cboLoaiPhong.Size = new System.Drawing.Size(196, 24);
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Mức giá
            this.lblMucGia.Text = "Mức giá / tháng";
            this.lblMucGia.Location = new System.Drawing.Point(lx2, gy + 3 * rowH + 4);
            this.lblMucGia.Size = new System.Drawing.Size(128, 20);
            this.lblMucGia.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblMucGia.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cboMucGia.Location = new System.Drawing.Point(cx2, gy + 3 * rowH);
            this.cboMucGia.Size = new System.Drawing.Size(196, 24);
            this.cboMucGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.grpYeuCauThue.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblSoNguoi, txtSoNguoi, lblKhuVuc, cboKhuVuc,
                lblLoaiPhong, cboLoaiPhong, lblMucGia, cboMucGia
            });

            // ────────────────────────────────────────────────────────────
            // grpThoiGian  (Left col, 2nd row – reuse grpTieuChi group)
            // Thêm ngày vào ở + thời hạn vào grpYeuCauThue mở rộng
            // thay vào đó dùng panel phẳng
            // ────────────────────────────────────────────────────────────
            var pnlThoiGian = new System.Windows.Forms.Panel();
            pnlThoiGian.Location = new System.Drawing.Point(18, 308);
            pnlThoiGian.Size = new System.Drawing.Size(356, 80);
            pnlThoiGian.BackColor = System.Drawing.Color.White;
            pnlThoiGian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            var lblThoiGianHeader = new System.Windows.Forms.Label();
            lblThoiGianHeader.Text = "Thời gian thuê";
            lblThoiGianHeader.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            lblThoiGianHeader.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            lblThoiGianHeader.Location = new System.Drawing.Point(8, 6);
            lblThoiGianHeader.Size = new System.Drawing.Size(200, 20);

            this.lblNgayVaoO.Text = "Ngày dự kiến vào ở (*)";
            this.lblNgayVaoO.Location = new System.Drawing.Point(8, 32);
            this.lblNgayVaoO.Size = new System.Drawing.Size(148, 20);
            this.lblNgayVaoO.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblNgayVaoO.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.dtpNgayVaoO.Location = new System.Drawing.Point(160, 30);
            this.dtpNgayVaoO.Size = new System.Drawing.Size(178, 24);
            this.dtpNgayVaoO.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblThoiHanThue.Text = "Thời hạn thuê";
            this.lblThoiHanThue.Location = new System.Drawing.Point(8, 56);
            this.lblThoiHanThue.Size = new System.Drawing.Size(148, 20);
            this.lblThoiHanThue.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblThoiHanThue.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cboThoiHanThue.Location = new System.Drawing.Point(160, 54);
            this.cboThoiHanThue.Size = new System.Drawing.Size(178, 24);
            this.cboThoiHanThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            pnlThoiGian.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblThoiGianHeader, lblNgayVaoO, dtpNgayVaoO, lblThoiHanThue, cboThoiHanThue
            });

            // ────────────────────────────────────────────────────────────
            // grpTieuChi  (Right col, 2nd row)
            // ────────────────────────────────────────────────────────────
            this.grpTieuChi.Text = "Tiêu chí ưu tiên";
            this.grpTieuChi.Location = new System.Drawing.Point(392, 308);
            this.grpTieuChi.Size = new System.Drawing.Size(354, 80);
            this.grpTieuChi.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpTieuChi.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.grpTieuChi.BackColor = System.Drawing.Color.White;

            this.chkDieuHoa.Text = "Điều hòa";
            this.chkDieuHoa.Location = new System.Drawing.Point(10, 24);
            this.chkDieuHoa.Size = new System.Drawing.Size(90, 22);
            this.chkDieuHoa.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.chkWifi.Text = "Wi-Fi";
            this.chkWifi.Location = new System.Drawing.Point(108, 24);
            this.chkWifi.Size = new System.Drawing.Size(70, 22);
            this.chkWifi.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.chkGuiXe.Text = "Gửi xe";
            this.chkGuiXe.Location = new System.Drawing.Point(190, 24);
            this.chkGuiXe.Size = new System.Drawing.Size(80, 22);
            this.chkGuiXe.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.chkYenTinh.Text = "Yên tĩnh";
            this.chkYenTinh.Location = new System.Drawing.Point(278, 24);
            this.chkYenTinh.Size = new System.Drawing.Size(80, 22);
            this.chkYenTinh.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.grpTieuChi.Controls.AddRange(new System.Windows.Forms.Control[] {
                chkDieuHoa, chkWifi, chkGuiXe, chkYenTinh
            });

            // ────────────────────────────────────────────────────────────
            // grpGhiChu  (full width, 3rd row)
            // ────────────────────────────────────────────────────────────
            this.grpGhiChu.Text = "Ghi chú / Yêu cầu thêm";
            this.grpGhiChu.Location = new System.Drawing.Point(18, 400);
            this.grpGhiChu.Size = new System.Drawing.Size(728, 110);
            this.grpGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpGhiChu.ForeColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.grpGhiChu.BackColor = System.Drawing.Color.White;

            this.lblGhiChu.Text = "Ghi chú:";
            this.lblGhiChu.Location = new System.Drawing.Point(10, 24);
            this.lblGhiChu.Size = new System.Drawing.Size(60, 20);
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtGhiChu.Location = new System.Drawing.Point(78, 22);
            this.txtGhiChu.Size = new System.Drawing.Size(638, 76);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.grpGhiChu.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblGhiChu, txtGhiChu
            });

            // ────────────────────────────────────────────────────────────
            // pnlFooter  (Dock Bottom)
            // ────────────────────────────────────────────────────────────
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 60;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);

            // Nút Đăng Ký
            this.btnDangKy.Text = "✔  Lưu Đăng Ký";
            this.btnDangKy.Location = new System.Drawing.Point(470, 12);
            this.btnDangKy.Size = new System.Drawing.Size(140, 36);
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(31, 78, 121);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            // Nút Xóa trắng
            this.btnXoaTrang.Text = "↺  Xóa Trắng";
            this.btnXoaTrang.Location = new System.Drawing.Point(620, 12);
            this.btnXoaTrang.Size = new System.Drawing.Size(120, 36);
            this.btnXoaTrang.BackColor = System.Drawing.Color.FromArgb(210, 120, 40);
            this.btnXoaTrang.ForeColor = System.Drawing.Color.White;
            this.btnXoaTrang.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnXoaTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTrang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);

            // Nút Hủy
            this.btnHuy.Text = "✕  Hủy";
            this.btnHuy.Location = new System.Drawing.Point(18, 12);
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.pnlFooter.Controls.AddRange(new System.Windows.Forms.Control[] {
                btnDangKy, btnXoaTrang, btnHuy
            });

            // ── Add all top-level controls ──────────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                pnlHeader,
                grpThongTinCaNhan,
                grpYeuCauThue,
                pnlThoiGian,
                grpTieuChi,
                grpGhiChu,
                pnlFooter
            });

            // ── Resume layout ────────────────────────────────────────────
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpThongTinCaNhan.ResumeLayout(false);
            this.grpThongTinCaNhan.PerformLayout();
            this.grpYeuCauThue.ResumeLayout(false);
            this.grpYeuCauThue.PerformLayout();
            this.grpTieuChi.ResumeLayout(false);
            this.grpGhiChu.ResumeLayout(false);
            this.grpGhiChu.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ───────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;

        private System.Windows.Forms.GroupBox grpThongTinCaNhan;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.GroupBox grpYeuCauThue;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.TextBox txtSoNguoi;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lblMucGia;
        private System.Windows.Forms.ComboBox cboMucGia;
        private System.Windows.Forms.Label lblNgayVaoO;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoO;
        private System.Windows.Forms.Label lblThoiHanThue;
        private System.Windows.Forms.ComboBox cboThoiHanThue;

        private System.Windows.Forms.GroupBox grpTieuChi;
        private System.Windows.Forms.CheckBox chkDieuHoa;
        private System.Windows.Forms.CheckBox chkGuiXe;
        private System.Windows.Forms.CheckBox chkYenTinh;
        private System.Windows.Forms.CheckBox chkWifi;

        private System.Windows.Forms.GroupBox grpGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnHuy;
    }
}