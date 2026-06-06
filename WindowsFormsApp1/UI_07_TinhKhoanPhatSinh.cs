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
    public partial class UI_8_Tính_khoản_phát_sinh : Form
    {
        public UI_8_Tính_khoản_phát_sinh()
        {
            InitializeComponent();
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgayTra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            using (var form = new UI_07b_KhauTru())
                form.ShowDialog(this);
        }
    }
}
