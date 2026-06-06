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
    public partial class UI_16_KiemTraDieuKienKhachThue : Form
    {
        public UI_16_KiemTraDieuKienKhachThue()
        {
            InitializeComponent();
        }

        private void traCuuButton_Click(object sender, EventArgs e)
        {
            if (radioCaNhan.Checked)
            {
                string maKhach = maKhachTextBox.Text.Trim();
                if (maKhach == "KH001")
                {
                    soTienLabel.Text = "S? ti?n: 2,000,000 VND";
                    ngayDatLabel.Text = "Ngày d?t: 01/06/2026";
                    trangThaiLabel.Text = "Tr?ng thái: Còn hi?u l?c";
                    phongLabel.Text = "Phòng: 203 - Giu?ng A";
                }
                else
                {
                    MessageBox.Show("Không t?n t?i phi?u d?t c?c cho khách này", "Thông báo");
                }
            }
            else if (radioNhom.Checked)
            {
                string maPhieu = maPhieuTextBox.Text.Trim();
                if (maPhieu == "PDCN001")
                {
                    soTienLabel.Text = "T?ng s? ti?n: 6,000,000 VND";
                    ngayDatLabel.Text = "Ngày d?t: 01/06/2026";
                    trangThaiLabel.Text = "Tr?ng thái: Còn hi?u l?c";
                    phongLabel.Text = "Phòng: 305 - S?c ch?a 4 giu?ng";

                    nhomGrid.Rows.Clear();
                    nhomGrid.Columns.Clear();
                    nhomGrid.Columns.Add("MaKhach", "Mã khách");
                    nhomGrid.Columns.Add("TenKhach", "Tên khách");
                    nhomGrid.Columns.Add("GioiTinh", "Gi?i tính");

                    nhomGrid.Rows.Add("KH001", "Nguy?n Van A", "Nam");
                    nhomGrid.Rows.Add("KH002", "Tr?n Th? B", "N?");
                    nhomGrid.Rows.Add("KH003", "Lê Van C", "Nam");
                }
                else
                {
                    MessageBox.Show("Không t?n t?i phi?u d?t c?c nhóm này", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng ch?n lo?i khách (cá nhân ho?c nhóm)", "Thông báo");
            }
        }

        private void xacNhanButton_Click(object sender, EventArgs e)
        {
            if (radioCaNhan.Checked)
            {
                MessageBox.Show("Thông tin phi?u d?t c?c cá nhân dã du?c xác nh?n. Ti?p t?c quy trình nh?n phòng/l?p h?p d?ng.", "Thông báo");
            }
            else if (radioNhom.Checked)
            {
                MessageBox.Show("Thông tin phi?u d?t c?c nhóm dã du?c xác nh?n. Ti?p t?c quy trình nh?n phòng/l?p h?p d?ng.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng ch?n lo?i khách tru?c khi xác nh?n.", "Thông báo");
            }
        }
    }
}
