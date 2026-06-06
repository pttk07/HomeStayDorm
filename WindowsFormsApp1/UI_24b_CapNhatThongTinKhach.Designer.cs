namespace WindowsFormsApp1
{
    partial class UI_24b_CapNhatThongTinKhach
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

            this.pnlMaDangKy = new System.Windows.Forms.Panel();
            this.lblMaDangKyLabel = new System.Windows.Forms.Label();
            this.txtMaDangKy = new System.Windows.Forms.TextBox();
            this.lblMaDangKyNote = new System.Windows.Forms.Label();

            // Cột trái – thông tin ban đầu (readonly)
            this.grpThongTinCu = new System.Windows.Forms.GroupBox();
            this.lblHoTenCuL = new System.Windows.Forms.Label();
            this.txtHoTenCu = new System.Windows.Forms.TextBox();
            this.lblGioiTinhCuL = new System.Windows.Forms.Label();
            this.lblGioiTinhCu = new System.Windows.Forms.Label();
            this.lblSoDienThoaiCuL = new System.Windows.Forms.Label();
            this.txtSoDienThoaiCu = new System.Windows.Forms.TextBox();
            this.lblEmailCuL = new System.Windows.Forms.Label();
            this.txtEmailCu = new System.Windows.Forms.TextBox();
            this.lblKhuVucCuL = new System.Windows.Forms.Label();
            this.lblKhuVucCu = new System.Windows.Forms.Label();
            this.lblLoaiPhongCuL = new System.Windows.Forms.Label();
            this.lblLoaiPhongCu = new System.Windows.Forms.Label();
            this.lblMucGiaCuL = new System.Windows.Forms.Label();
            this.lblMucGiaCu = new System.Windows.Forms.Label();
            this.lblNgayVaoOCuL = new System.Windows.Forms.Label();
            this.lblNgayVaoOCu = new System.Windows.Forms.Label();
            this.lblThoiHanCuL = new System.Windows.Forms.Label();
            this.lblThoiHanCu = new System.Windows.Forms.Label();
            this.lblSoNguoiCuL = new System.Windows.Forms.Label();
            this.lblSoNguoiCu = new System.Windows.Forms.Label();
            this.lblTieuChiCuL = new System.Windows.Forms.Label();
            this.lblTieuChiCu = new System.Windows.Forms.Label();
            this.lblGhiChuCuL = new System.Windows.Forms.Label();
            this.lblGhiChuCu = new System.Windows.Forms.Label();

            // Cột phải – thông tin cập nhật
            this.grpThongTinMoi = new System.Windows.Forms.GroupBox();
            this.lblHoTenMoiL = new System.Windows.Forms.Label();
            this.txtHoTenMoi = new System.Windows.Forms.TextBox();
            this.lblGioiTinhMoiL = new System.Windows.Forms.Label();
            this.radNamMoi = new System.Windows.Forms.RadioButton();
            this.radNuMoi = new System.Windows.Forms.RadioButton();
            this.lblSoDienThoaiMoiL = new System.Windows.Forms.Label();
            this.txtSoDienThoaiMoi = new System.Windows.Forms.TextBox();
            this.lblEmailMoiL = new System.Windows.Forms.Label();
            this.txtEmailMoi = new System.Windows.Forms.TextBox();
            this.lblNgayVaoOMoiL = new System.Windows.Forms.Label();
            this.dtpNgayVaoOMoi = new System.Windows.Forms.DateTimePicker();
            this.lblThoiHanMoiL = new System.Windows.Forms.Label();
            this.cboThoiHanMoi = new System.Windows.Forms.ComboBox();
            this.lblSoNguoiMoiL = new System.Windows.Forms.Label();
            this.txtSoNguoiMoi = new System.Windows.Forms.TextBox();
            this.lblGiayToBoSungL = new System.Windows.Forms.Label();
            this.txtGiayToBoSung = new System.Windows.Forms.TextBox();

            // Phòng xác định
            this.grpPhongXacDinh = new System.Windows.Forms.GroupBox();
            this.lblPhongXacDinhL = new System.Windows.Forms.Label();
            this.txtPhongXacDinh = new System.Windows.Forms.TextBox();
            this.lblGiaThueL = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.lblDonViGia = new System.Windows.Forms.Label();
            this.lblSoGiuongL = new System.Windows.Forms.Label();
            this.txtSoGiuong = new System.Windows.Forms.TextBox();
            this.lblHinhThucThueL = new System.Windows.Forms.Label();
            this.cboHinhThucThue = new System.Windows.Forms.ComboBox();

            // Trạng thái xác nhận
            this.grpTrangThai = new System.Windows.Forms.GroupBox();
            this.lblTrangThaiL = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();

            // Footer
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnLuuCapNhat = new System.Windows.Forms.Button();
            this.btnDongBo = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            // ── Suspend ──────────────────────────────────────────────────
            this.pnlHeader.SuspendLayout();
            this.pnlMaDangKy.SuspendLayout();
            this.grpThongTinCu.SuspendLayout();
            this.grpThongTinMoi.SuspendLayout();
            this.grpPhongXacDinh.SuspendLayout();
            this.grpTrangThai.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();

            // ── Form ────────────────────────────────────────────────────
            this.Text = "Cập Nhật Thông Tin Khách – Xác Nhận Thuê – UC 24b";
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9.5f);
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);

            // ── pnlHeader ───────────────────────────────────────────────
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 72;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(20, 100, 80);
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 8, 10, 8);

            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(18, 10);
            this.lblTieuDe.Text = "CẬP NHẬT THÔNG TIN KHÁCH – XÁC NHẬN THUÊ";
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14f, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;

            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(20, 38);
            this.lblMoTa.Text = "Rà soát và cập nhật thông tin khách trước khi tiến hành đặt cọc – UC 24b";
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Italic);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(180, 230, 210);

            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblMoTa);

            // ── pnlMaDangKy ─────────────────────────────────────────────
            this.pnlMaDangKy.Location = new System.Drawing.Point(18, 82);
            this.pnlMaDangKy.Size = new System.Drawing.Size(864, 40);
            this.pnlMaDangKy.BackColor = System.Drawing.Color.FromArgb(230, 245, 240);
            this.pnlMaDangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblMaDangKyLabel.Text = "Mã Đăng Ký:";
            this.lblMaDangKyLabel.Location = new System.Drawing.Point(10, 10);
            this.lblMaDangKyLabel.Size = new System.Drawing.Size(90, 20);
            this.lblMaDangKyLabel.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblMaDangKyLabel.ForeColor = System.Drawing.Color.FromArgb(20, 100, 80);

            this.txtMaDangKy.Location = new System.Drawing.Point(106, 8);
            this.txtMaDangKy.Size = new System.Drawing.Size(160, 24);
            this.txtMaDangKy.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.txtMaDangKy.ReadOnly = true;
            this.txtMaDangKy.BackColor = System.Drawing.Color.FromArgb(230, 245, 240);
            this.txtMaDangKy.BorderStyle = System.Windows.Forms.BorderStyle.None;

            this.lblMaDangKyNote.Text = "⚠ Các trường có dấu (*) là bắt buộc. Chỉ cập nhật những trường thay đổi.";
            this.lblMaDangKyNote.Location = new System.Drawing.Point(300, 10);
            this.lblMaDangKyNote.Size = new System.Drawing.Size(550, 20);
            this.lblMaDangKyNote.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Italic);
            this.lblMaDangKyNote.ForeColor = System.Drawing.Color.FromArgb(140, 80, 20);

            this.pnlMaDangKy.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblMaDangKyLabel, txtMaDangKy, lblMaDangKyNote
            });

            // ── Hằng số layout ──────────────────────────────────────────
            int grpTop = 132;
            int grpH = 330;
            int colW = 418;
            int lx = 10;
            int cx = 160;
            int rowH = 32;
            int gy0 = 24;

            // ────────────────────────────────────────────────────────────
            // grpThongTinCu  (Cột trái – readonly, màu xám nhạt)
            // ────────────────────────────────────────────────────────────
            this.grpThongTinCu.Text = "📋  Thông tin đăng ký ban đầu (chỉ đọc)";
            this.grpThongTinCu.Location = new System.Drawing.Point(18, grpTop);
            this.grpThongTinCu.Size = new System.Drawing.Size(colW, grpH);
            this.grpThongTinCu.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpThongTinCu.ForeColor = System.Drawing.Color.FromArgb(90, 90, 90);
            this.grpThongTinCu.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);

            System.Drawing.Color roFg = System.Drawing.Color.FromArgb(60, 60, 60);
            System.Drawing.Color roVal = System.Drawing.Color.FromArgb(40, 40, 40);
            System.Drawing.Font lblF = new System.Drawing.Font("Segoe UI", 9f);
            System.Drawing.Font valF = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            // helper inline via array
            var cuRows = InitializeCuRows(lx, cx, gy0, rowH, lblF, valF, roFg, roVal);
            AddControlsToGroup(this.grpThongTinCu, cuRows);

            // Tiêu chí + ghi chú (multiline label)
            this.lblTieuChiCuL.Text = "Tiêu chí";
            this.lblTieuChiCuL.Location = new System.Drawing.Point(lx, gy0 + 10 * rowH + 3);
            this.lblTieuChiCuL.Size = new System.Drawing.Size(145, 20);
            this.lblTieuChiCuL.Font = lblF;
            this.lblTieuChiCuL.ForeColor = roFg;

            this.lblTieuChiCu.Location = new System.Drawing.Point(cx, gy0 + 10 * rowH + 3);
            this.lblTieuChiCu.Size = new System.Drawing.Size(248, 20);
            this.lblTieuChiCu.Font = valF;
            this.lblTieuChiCu.ForeColor = roVal;

            this.grpThongTinCu.Controls.AddRange(new System.Windows.Forms.Control[] { lblTieuChiCuL, lblTieuChiCu });

            // ────────────────────────────────────────────────────────────
            // grpThongTinMoi  (Cột phải – editable)
            // ────────────────────────────────────────────────────────────
            int rightX = 18 + colW + 12;
            this.grpThongTinMoi.Text = "✏  Thông tin cập nhật (có thể chỉnh sửa)";
            this.grpThongTinMoi.Location = new System.Drawing.Point(rightX, grpTop);
            this.grpThongTinMoi.Size = new System.Drawing.Size(colW, grpH);
            this.grpThongTinMoi.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpThongTinMoi.ForeColor = System.Drawing.Color.FromArgb(20, 100, 80);
            this.grpThongTinMoi.BackColor = System.Drawing.Color.White;

            int lx2 = 10, cx2 = 160, rowH2 = 32;

            // Họ tên mới
            this.lblHoTenMoiL.Text = "Họ và tên (*)";
            this.lblHoTenMoiL.Location = new System.Drawing.Point(lx2, gy0 + 0 * rowH2 + 4);
            this.lblHoTenMoiL.Size = new System.Drawing.Size(148, 20);
            this.lblHoTenMoiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblHoTenMoiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtHoTenMoi.Location = new System.Drawing.Point(cx2, gy0 + 0 * rowH2);
            this.txtHoTenMoi.Size = new System.Drawing.Size(240, 24);

            // Giới tính mới
            this.lblGioiTinhMoiL.Text = "Giới tính (*)";
            this.lblGioiTinhMoiL.Location = new System.Drawing.Point(lx2, gy0 + 1 * rowH2 + 4);
            this.lblGioiTinhMoiL.Size = new System.Drawing.Size(148, 20);
            this.lblGioiTinhMoiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblGioiTinhMoiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.radNamMoi.Text = "Nam";
            this.radNamMoi.Location = new System.Drawing.Point(cx2, gy0 + 1 * rowH2 + 2);
            this.radNamMoi.Size = new System.Drawing.Size(54, 22);
            this.radNamMoi.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.radNuMoi.Text = "Nữ";
            this.radNuMoi.Location = new System.Drawing.Point(cx2 + 60, gy0 + 1 * rowH2 + 2);
            this.radNuMoi.Size = new System.Drawing.Size(54, 22);
            this.radNuMoi.Font = new System.Drawing.Font("Segoe UI", 9f);

            // SĐT mới
            this.lblSoDienThoaiMoiL.Text = "Số điện thoại (*)";
            this.lblSoDienThoaiMoiL.Location = new System.Drawing.Point(lx2, gy0 + 2 * rowH2 + 4);
            this.lblSoDienThoaiMoiL.Size = new System.Drawing.Size(148, 20);
            this.lblSoDienThoaiMoiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSoDienThoaiMoiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtSoDienThoaiMoi.Location = new System.Drawing.Point(cx2, gy0 + 2 * rowH2);
            this.txtSoDienThoaiMoi.Size = new System.Drawing.Size(240, 24);

            // Email mới
            this.lblEmailMoiL.Text = "Email";
            this.lblEmailMoiL.Location = new System.Drawing.Point(lx2, gy0 + 3 * rowH2 + 4);
            this.lblEmailMoiL.Size = new System.Drawing.Size(148, 20);
            this.lblEmailMoiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblEmailMoiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtEmailMoi.Location = new System.Drawing.Point(cx2, gy0 + 3 * rowH2);
            this.txtEmailMoi.Size = new System.Drawing.Size(240, 24);

            // Ngày vào ở mới
            this.lblNgayVaoOMoiL.Text = "Ngày dự kiến vào ở";
            this.lblNgayVaoOMoiL.Location = new System.Drawing.Point(lx2, gy0 + 4 * rowH2 + 4);
            this.lblNgayVaoOMoiL.Size = new System.Drawing.Size(148, 20);
            this.lblNgayVaoOMoiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblNgayVaoOMoiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.dtpNgayVaoOMoi.Location = new System.Drawing.Point(cx2, gy0 + 4 * rowH2);
            this.dtpNgayVaoOMoi.Size = new System.Drawing.Size(190, 24);
            this.dtpNgayVaoOMoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Thời hạn mới
            this.lblThoiHanMoiL.Text = "Thời hạn thuê";
            this.lblThoiHanMoiL.Location = new System.Drawing.Point(lx2, gy0 + 5 * rowH2 + 4);
            this.lblThoiHanMoiL.Size = new System.Drawing.Size(148, 20);
            this.lblThoiHanMoiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblThoiHanMoiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cboThoiHanMoi.Location = new System.Drawing.Point(cx2, gy0 + 5 * rowH2);
            this.cboThoiHanMoi.Size = new System.Drawing.Size(190, 24);
            this.cboThoiHanMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Số người mới
            this.lblSoNguoiMoiL.Text = "Số người ở";
            this.lblSoNguoiMoiL.Location = new System.Drawing.Point(lx2, gy0 + 6 * rowH2 + 4);
            this.lblSoNguoiMoiL.Size = new System.Drawing.Size(148, 20);
            this.lblSoNguoiMoiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSoNguoiMoiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtSoNguoiMoi.Location = new System.Drawing.Point(cx2, gy0 + 6 * rowH2);
            this.txtSoNguoiMoi.Size = new System.Drawing.Size(60, 24);

            // Giấy tờ bổ sung
            this.lblGiayToBoSungL.Text = "Giấy tờ / ghi chú bổ sung";
            this.lblGiayToBoSungL.Location = new System.Drawing.Point(lx2, gy0 + 7 * rowH2 + 4);
            this.lblGiayToBoSungL.Size = new System.Drawing.Size(148, 20);
            this.lblGiayToBoSungL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblGiayToBoSungL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtGiayToBoSung.Location = new System.Drawing.Point(lx2, gy0 + 8 * rowH2);
            this.txtGiayToBoSung.Size = new System.Drawing.Size(394, 64);
            this.txtGiayToBoSung.Multiline = true;
            this.txtGiayToBoSung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGiayToBoSung.Font = new System.Drawing.Font("Segoe UI", 9f);

            this.grpThongTinMoi.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblHoTenMoiL, txtHoTenMoi,
                lblGioiTinhMoiL, radNamMoi, radNuMoi,
                lblSoDienThoaiMoiL, txtSoDienThoaiMoi,
                lblEmailMoiL, txtEmailMoi,
                lblNgayVaoOMoiL, dtpNgayVaoOMoi,
                lblThoiHanMoiL, cboThoiHanMoi,
                lblSoNguoiMoiL, txtSoNguoiMoi,
                lblGiayToBoSungL, txtGiayToBoSung
            });

            // ────────────────────────────────────────────────────────────
            // grpPhongXacDinh  (bottom left)
            // ────────────────────────────────────────────────────────────
            int bottomY = grpTop + grpH + 10;
            this.grpPhongXacDinh.Text = "Phòng / Giường xác định";
            this.grpPhongXacDinh.Location = new System.Drawing.Point(18, bottomY);
            this.grpPhongXacDinh.Size = new System.Drawing.Size(colW, 100);
            this.grpPhongXacDinh.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpPhongXacDinh.ForeColor = System.Drawing.Color.FromArgb(20, 100, 80);
            this.grpPhongXacDinh.BackColor = System.Drawing.Color.White;

            this.lblPhongXacDinhL.Text = "Phòng / Giường";
            this.lblPhongXacDinhL.Location = new System.Drawing.Point(lx, 26);
            this.lblPhongXacDinhL.Size = new System.Drawing.Size(145, 20);
            this.lblPhongXacDinhL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblPhongXacDinhL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtPhongXacDinh.Location = new System.Drawing.Point(cx, 24);
            this.txtPhongXacDinh.Size = new System.Drawing.Size(250, 24);
            this.txtPhongXacDinh.ReadOnly = true;
            this.txtPhongXacDinh.BackColor = System.Drawing.Color.FromArgb(240, 248, 244);

            this.lblGiaThueL.Text = "Giá thuê / tháng";
            this.lblGiaThueL.Location = new System.Drawing.Point(lx, 56);
            this.lblGiaThueL.Size = new System.Drawing.Size(145, 20);
            this.lblGiaThueL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblGiaThueL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtGiaThue.Location = new System.Drawing.Point(cx, 54);
            this.txtGiaThue.Size = new System.Drawing.Size(130, 24);
            this.txtGiaThue.ReadOnly = true;
            this.txtGiaThue.BackColor = System.Drawing.Color.FromArgb(240, 248, 244);

            this.lblDonViGia.Text = "VNĐ / giường";
            this.lblDonViGia.Location = new System.Drawing.Point(cx + 138, 57);
            this.lblDonViGia.Size = new System.Drawing.Size(100, 20);
            this.lblDonViGia.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Italic);
            this.lblDonViGia.ForeColor = System.Drawing.Color.Gray;

            this.grpPhongXacDinh.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblPhongXacDinhL, txtPhongXacDinh,
                lblGiaThueL, txtGiaThue, lblDonViGia
            });

            // ────────────────────────────────────────────────────────────
            // grpTrangThai  (bottom right)
            // ────────────────────────────────────────────────────────────
            this.grpTrangThai.Text = "Hình thức & Trạng thái xác nhận";
            this.grpTrangThai.Location = new System.Drawing.Point(rightX, bottomY);
            this.grpTrangThai.Size = new System.Drawing.Size(colW, 100);
            this.grpTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.grpTrangThai.ForeColor = System.Drawing.Color.FromArgb(20, 100, 80);
            this.grpTrangThai.BackColor = System.Drawing.Color.White;

            this.lblSoGiuongL.Text = "Số giường thuê";
            this.lblSoGiuongL.Location = new System.Drawing.Point(lx2, 26);
            this.lblSoGiuongL.Size = new System.Drawing.Size(148, 20);
            this.lblSoGiuongL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblSoGiuongL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.txtSoGiuong.Location = new System.Drawing.Point(cx2, 24);
            this.txtSoGiuong.Size = new System.Drawing.Size(50, 24);
            this.txtSoGiuong.ReadOnly = true;
            this.txtSoGiuong.BackColor = System.Drawing.Color.FromArgb(240, 248, 244);

            this.lblHinhThucThueL.Text = "Hình thức thuê";
            this.lblHinhThucThueL.Location = new System.Drawing.Point(lx2, 56);
            this.lblHinhThucThueL.Size = new System.Drawing.Size(148, 20);
            this.lblHinhThucThueL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblHinhThucThueL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cboHinhThucThue.Location = new System.Drawing.Point(cx2, 54);
            this.cboHinhThucThue.Size = new System.Drawing.Size(200, 24);
            this.cboHinhThucThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblTrangThaiL.Text = "Trạng thái";
            this.lblTrangThaiL.Location = new System.Drawing.Point(lx2 + 270, 26);
            this.lblTrangThaiL.Size = new System.Drawing.Size(80, 20);
            this.lblTrangThaiL.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblTrangThaiL.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            this.cboTrangThai.Location = new System.Drawing.Point(lx2 + 270, 46);
            this.cboTrangThai.Size = new System.Drawing.Size(134, 24);
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.grpTrangThai.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblSoGiuongL, txtSoGiuong,
                lblHinhThucThueL, cboHinhThucThue,
                lblTrangThaiL, cboTrangThai
            });

            // ── pnlFooter ───────────────────────────────────────────────
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Height = 60;
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(225, 240, 235);
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);

            this.btnLuuCapNhat.Text = "✔  Lưu Cập Nhật";
            this.btnLuuCapNhat.Location = new System.Drawing.Point(560, 12);
            this.btnLuuCapNhat.Size = new System.Drawing.Size(150, 36);
            this.btnLuuCapNhat.BackColor = System.Drawing.Color.FromArgb(20, 100, 80);
            this.btnLuuCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnLuuCapNhat.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnLuuCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuCapNhat.Click += new System.EventHandler(this.btnLuuCapNhat_Click);

            this.btnDongBo.Text = "↺  Đồng bộ";
            this.btnDongBo.Location = new System.Drawing.Point(720, 12);
            this.btnDongBo.Size = new System.Drawing.Size(120, 36);
            this.btnDongBo.BackColor = System.Drawing.Color.FromArgb(80, 100, 160);
            this.btnDongBo.ForeColor = System.Drawing.Color.White;
            this.btnDongBo.Font = new System.Drawing.Font("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            this.btnDongBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongBo.Click += new System.EventHandler(this.btnDongBo_Click);

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
                btnLuuCapNhat, btnDongBo, btnHuy
            });

            // ── Add all ──────────────────────────────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                pnlHeader,
                pnlMaDangKy,
                grpThongTinCu,
                grpThongTinMoi,
                grpPhongXacDinh,
                grpTrangThai,
                pnlFooter
            });

            // ── Resume ───────────────────────────────────────────────────
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMaDangKy.ResumeLayout(false);
            this.pnlMaDangKy.PerformLayout();
            this.grpThongTinCu.ResumeLayout(false);
            this.grpThongTinCu.PerformLayout();
            this.grpThongTinMoi.ResumeLayout(false);
            this.grpThongTinMoi.PerformLayout();
            this.grpPhongXacDinh.ResumeLayout(false);
            this.grpPhongXacDinh.PerformLayout();
            this.grpTrangThai.ResumeLayout(false);
            this.grpTrangThai.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Helper methods (private static để giữ code Designer gọn) ────
        private void AddControlsToGroup(System.Windows.Forms.GroupBox grp, (System.Windows.Forms.Control, System.Windows.Forms.Control)[] rows)
        {
            foreach (var (l, v) in rows)
                grp.Controls.AddRange(new System.Windows.Forms.Control[] { l, v });
        }

        private (System.Windows.Forms.Control, System.Windows.Forms.Control)[] InitializeCuRows(
            int lx, int cx, int gy0, int rowH,
            System.Drawing.Font lblF, System.Drawing.Font valF,
            System.Drawing.Color roFg, System.Drawing.Color roVal)
        {
            return new (System.Windows.Forms.Control, System.Windows.Forms.Control)[]
            {
                (MakeLbl(lblHoTenCuL,       "Họ và tên",       lx, gy0 + 0*rowH, lblF, roFg),
                 MakeRoTxt(txtHoTenCu,       cx, gy0 + 0*rowH)),
                (MakeLbl(lblGioiTinhCuL,     "Giới tính",       lx, gy0 + 1*rowH, lblF, roFg),
                 MakeValLbl(lblGioiTinhCu,   cx, gy0 + 1*rowH + 3, valF, roVal)),
                (MakeLbl(lblSoDienThoaiCuL,  "SĐT",             lx, gy0 + 2*rowH, lblF, roFg),
                 MakeRoTxt(txtSoDienThoaiCu, cx, gy0 + 2*rowH)),
                (MakeLbl(lblEmailCuL,        "Email",           lx, gy0 + 3*rowH, lblF, roFg),
                 MakeRoTxt(txtEmailCu,        cx, gy0 + 3*rowH)),
                (MakeLbl(lblKhuVucCuL,       "Khu vực",         lx, gy0 + 4*rowH, lblF, roFg),
                 MakeValLbl(lblKhuVucCu,      cx, gy0 + 4*rowH + 3, valF, roVal)),
                (MakeLbl(lblLoaiPhongCuL,    "Loại phòng",      lx, gy0 + 5*rowH, lblF, roFg),
                 MakeValLbl(lblLoaiPhongCu,   cx, gy0 + 5*rowH + 3, valF, roVal)),
                (MakeLbl(lblMucGiaCuL,       "Mức giá",         lx, gy0 + 6*rowH, lblF, roFg),
                 MakeValLbl(lblMucGiaCu,      cx, gy0 + 6*rowH + 3, valF, roVal)),
                (MakeLbl(lblNgayVaoOCuL,     "Ngày vào ở",      lx, gy0 + 7*rowH, lblF, roFg),
                 MakeValLbl(lblNgayVaoOCu,    cx, gy0 + 7*rowH + 3, valF, roVal)),
                (MakeLbl(lblThoiHanCuL,      "Thời hạn thuê",   lx, gy0 + 8*rowH, lblF, roFg),
                 MakeValLbl(lblThoiHanCu,     cx, gy0 + 8*rowH + 3, valF, roVal)),
                (MakeLbl(lblSoNguoiCuL,      "Số người",        lx, gy0 + 9*rowH, lblF, roFg),
                 MakeValLbl(lblSoNguoiCu,     cx, gy0 + 9*rowH + 3, valF, roVal)),
            };
        }

        private static System.Windows.Forms.Label MakeLbl(
            System.Windows.Forms.Label lbl, string text,
            int x, int y, System.Drawing.Font f, System.Drawing.Color fg)
        {
            lbl.Text = text; lbl.Location = new System.Drawing.Point(x, y);
            lbl.Size = new System.Drawing.Size(148, 20); lbl.Font = f; lbl.ForeColor = fg;
            return lbl;
        }
        private static System.Windows.Forms.TextBox MakeRoTxt(
            System.Windows.Forms.TextBox t, int x, int y)
        {
            t.Location = new System.Drawing.Point(x, y); t.Size = new System.Drawing.Size(240, 24);
            t.ReadOnly = true; t.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            return t;
        }
        private static System.Windows.Forms.Label MakeValLbl(
            System.Windows.Forms.Label lbl, int x, int y,
            System.Drawing.Font f, System.Drawing.Color fg)
        {
            lbl.Location = new System.Drawing.Point(x, y); lbl.Size = new System.Drawing.Size(248, 20);
            lbl.Font = f; lbl.ForeColor = fg; return lbl;
        }

        // ── Field declarations ───────────────────────────────────────────
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMoTa;

        private System.Windows.Forms.Panel pnlMaDangKy;
        private System.Windows.Forms.Label lblMaDangKyLabel;
        private System.Windows.Forms.TextBox txtMaDangKy;
        private System.Windows.Forms.Label lblMaDangKyNote;

        private System.Windows.Forms.GroupBox grpThongTinCu;
        private System.Windows.Forms.Label lblHoTenCuL;
        private System.Windows.Forms.TextBox txtHoTenCu;
        private System.Windows.Forms.Label lblGioiTinhCuL;
        private System.Windows.Forms.Label lblGioiTinhCu;
        private System.Windows.Forms.Label lblSoDienThoaiCuL;
        private System.Windows.Forms.TextBox txtSoDienThoaiCu;
        private System.Windows.Forms.Label lblEmailCuL;
        private System.Windows.Forms.TextBox txtEmailCu;
        private System.Windows.Forms.Label lblKhuVucCuL;
        private System.Windows.Forms.Label lblKhuVucCu;
        private System.Windows.Forms.Label lblLoaiPhongCuL;
        private System.Windows.Forms.Label lblLoaiPhongCu;
        private System.Windows.Forms.Label lblMucGiaCuL;
        private System.Windows.Forms.Label lblMucGiaCu;
        private System.Windows.Forms.Label lblNgayVaoOCuL;
        private System.Windows.Forms.Label lblNgayVaoOCu;
        private System.Windows.Forms.Label lblThoiHanCuL;
        private System.Windows.Forms.Label lblThoiHanCu;
        private System.Windows.Forms.Label lblSoNguoiCuL;
        private System.Windows.Forms.Label lblSoNguoiCu;
        private System.Windows.Forms.Label lblTieuChiCuL;
        private System.Windows.Forms.Label lblTieuChiCu;
        private System.Windows.Forms.Label lblGhiChuCuL;
        private System.Windows.Forms.Label lblGhiChuCu;

        private System.Windows.Forms.GroupBox grpThongTinMoi;
        private System.Windows.Forms.Label lblHoTenMoiL;
        private System.Windows.Forms.TextBox txtHoTenMoi;
        private System.Windows.Forms.Label lblGioiTinhMoiL;
        private System.Windows.Forms.RadioButton radNamMoi;
        private System.Windows.Forms.RadioButton radNuMoi;
        private System.Windows.Forms.Label lblSoDienThoaiMoiL;
        private System.Windows.Forms.TextBox txtSoDienThoaiMoi;
        private System.Windows.Forms.Label lblEmailMoiL;
        private System.Windows.Forms.TextBox txtEmailMoi;
        private System.Windows.Forms.Label lblNgayVaoOMoiL;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoOMoi;
        private System.Windows.Forms.Label lblThoiHanMoiL;
        private System.Windows.Forms.ComboBox cboThoiHanMoi;
        private System.Windows.Forms.Label lblSoNguoiMoiL;
        private System.Windows.Forms.TextBox txtSoNguoiMoi;
        private System.Windows.Forms.Label lblGiayToBoSungL;
        private System.Windows.Forms.TextBox txtGiayToBoSung;

        private System.Windows.Forms.GroupBox grpPhongXacDinh;
        private System.Windows.Forms.Label lblPhongXacDinhL;
        private System.Windows.Forms.TextBox txtPhongXacDinh;
        private System.Windows.Forms.Label lblGiaThueL;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label lblDonViGia;
        private System.Windows.Forms.Label lblSoGiuongL;
        private System.Windows.Forms.TextBox txtSoGiuong;

        private System.Windows.Forms.GroupBox grpTrangThai;
        private System.Windows.Forms.Label lblTrangThaiL;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblHinhThucThueL;
        private System.Windows.Forms.ComboBox cboHinhThucThue;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnLuuCapNhat;
        private System.Windows.Forms.Button btnDongBo;
        private System.Windows.Forms.Button btnHuy;
    }
}