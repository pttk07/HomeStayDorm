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
    public partial class UI_05a_TaoPhieuThongTinTraPhong : Form
    {
        public UI_05a_TaoPhieuThongTinTraPhong()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
        }

        private void btnMoTraCuu_Click(object sender, EventArgs e)
        {
            TraCuuPhieuThongTinThue frmTraCuu = new TraCuuPhieuThongTinThue();

            // 2. Hiển thị màn hình Tra cứu lên
            frmTraCuu.ShowDialog();
        }
    }
}
