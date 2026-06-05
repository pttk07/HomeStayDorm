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
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT001", "Nguyễn Văn A", "0901234567", "P101", "01/06/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT002", "Trần Thị B", "0912345678", "P102", "02/06/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT003", "Lê Văn C", "0923456789", "P201", "04/06/2026", "Đã trả" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT004", "Phạm Văn D", "0987654321", "V001", "05/06/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT005", "Hoàng Thị E", "0934567890", "V002", "05/06/2026", "Đã trả" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT006", "Đinh Văn F", "0945678901", "P301", "06/06/2026", "Đang thuê" });
            dgvDanhSachPhieu.Rows.Add(new object[] { "PT007", "Vũ Thị G", "0956789012", "P302", "06/06/2026", "Chờ xử lý" });
        }

        private void TraCuuPhieuThongTinThue_Load(object sender, EventArgs e)
        {

        }

    }
}
