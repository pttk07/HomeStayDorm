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
            using (var frmTraCuu = new TraCuuPhieuThongTinThue())
            {
                if (frmTraCuu.ShowDialog(this) != DialogResult.OK) return;

                txtMaPhieuThue.Text = frmTraCuu.SelectedMaPhieu;
                txtMaPhong.Text     = frmTraCuu.SelectedPhong;

                // Gợi ý lý do mặc định nếu chưa nhập
                if (string.IsNullOrWhiteSpace(txtLyDo.Text))
                    txtLyDo.Text = "Khách tự nguyện trả phòng trước hạn.";
            }
        }
    }
}
