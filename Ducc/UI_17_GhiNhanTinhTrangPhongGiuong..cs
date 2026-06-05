using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ducc
{
    public partial class UI_17_GhiNhanTinhTrangPhongGiuong : Form
    {
        public UI_17_GhiNhanTinhTrangPhongGiuong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UI_17_GhiNhanTinhTrangPhongGiuong_Load(object sender, EventArgs e)
        {
            ngayGhiNhanPicker.Format = DateTimePickerFormat.Custom;
            ngayGhiNhanPicker.CustomFormat = "dd/MM/yyyy";
            ngayGhiNhanPicker.Value = DateTime.Now; // tự chọn ngày hiện tại
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
