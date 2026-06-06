using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_22_QuanTriNguoiDung : Form
    {
        private System.Collections.Generic.List<NguoiDung> danhSach;

        public UI_22_QuanTriNguoiDung()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += UI_22_QuanTriNguoiDung_Load;
        }

        private void UI_22_QuanTriNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDuLieuMau();
            HienThiDanhSach(danhSach);
        }

        private void LoadDuLieuMau()
        {
            danhSach = new System.Collections.Generic.List<NguoiDung>
            {
                new NguoiDung { MaND=1, HoTen="Đỗ Thanh Quang",    Email="quang.do@hsdorm.vn",     NhomQuyen="Quản trị hệ thống", TrangThai="Đang hoạt động", NgayTao="01/01/2025" },
                new NguoiDung { MaND=2, HoTen="Trần Văn Hải",       Email="hai.tran@hsdorm.vn",     NhomQuyen="Quản lý",           TrangThai="Đang hoạt động", NgayTao="01/02/2025" },
                new NguoiDung { MaND=3, HoTen="Nguyễn Thị Thu",     Email="thu.nguyen@hsdorm.vn",   NhomQuyen="Quản lý",           TrangThai="Đang hoạt động", NgayTao="15/02/2025" },
                new NguoiDung { MaND=4, HoTen="Lê Công Phúc",       Email="phuc.le@hsdorm.vn",      NhomQuyen="Sale",              TrangThai="Đang hoạt động", NgayTao="01/03/2025" },
                new NguoiDung { MaND=5, HoTen="Phạm Tuấn Kiệt",     Email="kiet.pham@hsdorm.vn",    NhomQuyen="Sale",              TrangThai="Đang hoạt động", NgayTao="15/03/2025" },
                new NguoiDung { MaND=6, HoTen="Vũ Thị Tuyết",       Email="tuyet.vu@hsdorm.vn",     NhomQuyen="Kế toán",           TrangThai="Đang hoạt động", NgayTao="01/04/2025" },
                new NguoiDung { MaND=7, HoTen="Nguyễn Quang Huy",   Email="huy.nguyen@hsdorm.vn",   NhomQuyen="Kế toán",           TrangThai="Đang hoạt động", NgayTao="01/04/2025" },
                new NguoiDung { MaND=8, HoTen="Trần Minh Khánh",    Email="khanh.tran@hsdorm.vn",   NhomQuyen="Sale",              TrangThai="Đã khóa",        NgayTao="01/05/2025" },
            };
        }

        private void HienThiDanhSach(System.Collections.Generic.List<NguoiDung> ds)
        {
            dgvNguoiDung.Rows.Clear();
            dgvNguoiDung.Columns.Clear();

            dgvNguoiDung.Columns.Add("MaND", "Mã ND");
            dgvNguoiDung.Columns.Add("HoTen", "Họ và tên");
            dgvNguoiDung.Columns.Add("Email", "Email");
            dgvNguoiDung.Columns.Add("NhomQuyen", "Nhóm quyền");
            dgvNguoiDung.Columns.Add("TrangThai", "Trạng thái");
            dgvNguoiDung.Columns.Add("NgayTao", "Ngày tạo");

            dgvNguoiDung.Columns["MaND"].FillWeight = 40;
            dgvNguoiDung.Columns["NgayTao"].FillWeight = 70;
            dgvNguoiDung.Columns["NhomQuyen"].FillWeight = 80;
            dgvNguoiDung.Columns["TrangThai"].FillWeight = 90;

            foreach (var nd in ds)
            {
                int idx = dgvNguoiDung.Rows.Add(
                    nd.MaND, nd.HoTen, nd.Email,
                    nd.NhomQuyen, nd.TrangThai, nd.NgayTao);

                var row = dgvNguoiDung.Rows[idx];
                row.DefaultCellStyle.BackColor = idx % 2 == 0
                    ? Color.White : Color.FromArgb(247, 249, 252);

                row.Cells["TrangThai"].Style.ForeColor = nd.TrangThai == "Đã khóa"
                    ? Color.FromArgb(163, 45, 45)
                    : Color.FromArgb(15, 110, 86);

                switch (nd.NhomQuyen)
                {
                    case "Sale":                  row.Cells["NhomQuyen"].Style.ForeColor = Color.FromArgb(30, 64, 140);  break;
                    case "Kế toán":               row.Cells["NhomQuyen"].Style.ForeColor = Color.FromArgb(133, 79, 11); break;
                    case "Quản lý":               row.Cells["NhomQuyen"].Style.ForeColor = Color.FromArgb(80, 50, 140);  break;
                    case "Quản trị hệ thống":     row.Cells["NhomQuyen"].Style.ForeColor = Color.FromArgb(163, 45, 45);  break;
                }
            }

            lblCount.Text = $"Tổng: {ds.Count} người dùng";
        }

        private NguoiDung GetSelectedNguoiDung()
        {
            if (dgvNguoiDung.SelectedRows.Count == 0) return null;
            int ma = Convert.ToInt32(dgvNguoiDung.SelectedRows[0].Cells["MaND"].Value);
            return danhSach.Find(x => x.MaND == ma);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string nhom = cboNhomQuyen.SelectedItem?.ToString();
            string tthai = cboTrangThai.SelectedItem?.ToString();

            var ket = danhSach.FindAll(nd =>
            {
                bool matchKw = string.IsNullOrEmpty(keyword)
                    || nd.HoTen.ToLower().Contains(keyword)
                    || nd.Email.ToLower().Contains(keyword);
                bool matchNhom = nhom == "Tất cả nhóm" || nd.NhomQuyen == nhom;
                bool matchTT = tthai == "Tất cả trạng thái" || nd.TrangThai == tthai;
                return matchKw && matchNhom && matchTT;
            });

            HienThiDanhSach(ket);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var form = new UI_22a_ThemNguoiDung();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.NguoiDungMoi.MaND = danhSach.Count + 1;
                form.NguoiDungMoi.NgayTao = DateTime.Now.ToString("dd/MM/yyyy");
                danhSach.Add(form.NguoiDungMoi);
                HienThiDanhSach(danhSach);
                MessageBox.Show("Thêm người dùng thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            var nd = GetSelectedNguoiDung();
            if (nd == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần chỉnh sửa.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var form = new UI_22b_ChinhSuaNguoiDung(nd);
            if (form.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhSach(danhSach);
                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var nd = GetSelectedNguoiDung();
            if (nd == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var res = MessageBox.Show(
                $"Đặt lại mật khẩu về mặc định cho '{nd.HoTen}'?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                MessageBox.Show("Mật khẩu đã được đặt lại thành: Hsdorm@2025", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var nd = GetSelectedNguoiDung();
            if (nd == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa.", "Lưu ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var res = MessageBox.Show(
                $"Bạn có chắc muốn xóa tài khoản '{nd.HoTen}' ({nd.Email})?\nHành động này không thể hoàn tác.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                danhSach.Remove(nd);
                HienThiDanhSach(danhSach);
                MessageBox.Show("Đã xóa người dùng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}