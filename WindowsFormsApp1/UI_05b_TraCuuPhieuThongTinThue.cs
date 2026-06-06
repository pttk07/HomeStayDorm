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
    public partial class TraCuuPhieuThongTinThue : Form
    {
        public TraCuuPhieuThongTinThue()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2504-001", "Nguyễn Văn An",    "0901.234.567", "P101 - G101A", "01/05/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2504-002", "Lê Hoàng Cường",   "0923.456.789", "P201 - G201A", "01/05/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2504-003", "Võ Minh Đức",      "0945.678.901", "P101 - G101B", "01/05/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2505-004", "Hoàng Thị Lan",    "0956.789.012", "P102 - G102A", "15/05/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2504-005", "Phạm Văn Toàn",    "0967.890.123", "P101 - G101D", "01/04/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2504-006", "Đặng Thị Hoa",     "0978.901.234", "P102 - G102D", "01/04/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2506-007", "Trần Thị Bình",    "0912.345.678", "P202 - G202A", "05/06/2026", "Chờ xử lý" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT-2503-008", "Bùi Thị Ngọc",     "0934.567.890", "P102 - G102C", "01/03/2026", "Đã trả" });
        }

        private void TraCuuPhieuThongTinThue_Load(object sender, EventArgs e)
        {

        }

    }
}
