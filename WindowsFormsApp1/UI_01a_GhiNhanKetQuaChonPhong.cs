using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_01a_GhiNhanKetQuaChonPhong : Form
    {
        public string RoomNumber { get; set; }
        public string BedPosition { get; set; }
        public string Price { get; set; }

        public UI_01a_GhiNhanKetQuaChonPhong()
        {
            InitializeComponent();
            AppUiStyle.Apply(this);
        }

        private void UI_01a_GhiNhanKetQuaChonPhong_Load(object sender, EventArgs e)
        {
            txtRoomNumber.Text = RoomNumber;
            txtBedPosition.Text = BedPosition;
            txtPrice.Text = Price;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Chuyển sang lập phiếu đặt cọc
            UI_03_LapPhieuCoc depositForm = new UI_03_LapPhieuCoc();
            depositForm.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
