using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_08_TraCuuHopDong : Form
    {
        public string SelectedMaHD       { get; private set; }
        public string SelectedKhachHang  { get; private set; }
        public string SelectedPhong      { get; private set; }
        public string SelectedMucGia     { get; private set; }
        public string SelectedNgayKetThuc { get; private set; }

        public UI_08_TraCuuHopDong()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            this.Load += (s, e) => LoadDanhSachHopDong();
            btnTimKiem.Click += (s, e) => TimKiem();
            btnChonHopDong.Click += (s, e) => ChonHopDong();
            dgvHopDong.DoubleClick += (s, e) => ChonHopDong();
        }

        private void ChonHopDong()
        {
            if (dgvHopDong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hợp đồng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var row = dgvHopDong.SelectedRows[0];
            SelectedMaHD        = row.Cells[0].Value?.ToString();
            SelectedKhachHang   = row.Cells[1].Value?.ToString();
            SelectedPhong       = row.Cells[2].Value?.ToString();
            SelectedNgayKetThuc = row.Cells[4].Value?.ToString();
            SelectedMucGia      = row.Cells[5].Value?.ToString();
            this.DialogResult   = DialogResult.OK;
            this.Close();
        }

        private void LoadDanhSachHopDong()
        {
            dgvHopDong.Rows.Clear();
            dgvHopDong.Rows.Add("HD-2504-001", "Nguyễn Văn An",  "P101 - G101A", "01/05/2026", "30/04/2027", "2.000.000 VNĐ", "Đang hoạt động");
            dgvHopDong.Rows.Add("HD-2504-002", "Lê Hoàng Cường", "P201 - G201A", "01/05/2026", "30/04/2027", "1.800.000 VNĐ", "Đang hoạt động");
            dgvHopDong.Rows.Add("HD-2504-003", "Võ Minh Đức",    "P101 - G101B", "01/05/2026", "30/04/2027", "2.000.000 VNĐ", "Đang hoạt động");
            dgvHopDong.Rows.Add("HD-2505-004", "Hoàng Thị Lan",  "P102 - G102A", "15/05/2026", "14/05/2027", "2.100.000 VNĐ", "Đang hoạt động");
            dgvHopDong.Rows.Add("HD-2504-005", "Phạm Văn Toàn",  "P101 - G101D", "01/04/2026", "31/03/2027", "2.000.000 VNĐ", "Đang hoạt động");
            dgvHopDong.Rows.Add("HD-2504-006", "Đặng Thị Hoa",   "P102 - G102D", "01/04/2026", "31/03/2027", "2.100.000 VNĐ", "Đang hoạt động");
            dgvHopDong.Rows.Add("HD-2503-007", "Bùi Thị Ngọc",   "P102 - G102C", "01/03/2026", "31/05/2026", "2.100.000 VNĐ", "Đã kết thúc");
            dgvHopDong.Rows.Add("HD-2502-008", "Ngô Quốc Phong", "P201 - G201B", "01/02/2026", "31/05/2026", "1.800.000 VNĐ", "Đã kết thúc");
        }

        private void TimKiem()
        {
            string kw = txtTuKhoa.Text.Trim().ToLower();
            dgvHopDong.Rows.Clear();

            var data = new[]
            {
                new[]{ "HD-2504-001", "Nguyễn Văn An",  "P101 - G101A", "01/05/2026", "30/04/2027", "2.000.000 VNĐ", "Đang hoạt động" },
                new[]{ "HD-2504-002", "Lê Hoàng Cường", "P201 - G201A", "01/05/2026", "30/04/2027", "1.800.000 VNĐ", "Đang hoạt động" },
                new[]{ "HD-2504-003", "Võ Minh Đức",    "P101 - G101B", "01/05/2026", "30/04/2027", "2.000.000 VNĐ", "Đang hoạt động" },
                new[]{ "HD-2505-004", "Hoàng Thị Lan",  "P102 - G102A", "15/05/2026", "14/05/2027", "2.100.000 VNĐ", "Đang hoạt động" },
                new[]{ "HD-2504-005", "Phạm Văn Toàn",  "P101 - G101D", "01/04/2026", "31/03/2027", "2.000.000 VNĐ", "Đang hoạt động" },
                new[]{ "HD-2504-006", "Đặng Thị Hoa",   "P102 - G102D", "01/04/2026", "31/03/2027", "2.100.000 VNĐ", "Đang hoạt động" },
                new[]{ "HD-2503-007", "Bùi Thị Ngọc",   "P102 - G102C", "01/03/2026", "31/05/2026", "2.100.000 VNĐ", "Đã kết thúc" },
                new[]{ "HD-2502-008", "Ngô Quốc Phong", "P201 - G201B", "01/02/2026", "31/05/2026", "1.800.000 VNĐ", "Đã kết thúc" },
            };

            foreach (var r in data)
            {
                bool match = string.IsNullOrEmpty(kw)
                    || r[0].ToLower().Contains(kw)
                    || r[1].ToLower().Contains(kw)
                    || r[2].ToLower().Contains(kw);
                if (match) dgvHopDong.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6]);
            }
        }
    }
}
