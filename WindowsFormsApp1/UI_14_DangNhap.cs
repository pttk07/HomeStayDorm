using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UI_14_DangNhap : Form
    {
        public UI_14_DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                UI_26_DashboardQTHethong mainForm = new UI_26_DashboardQTHethong();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            } else if (txtUsername.Text == "sale" && txtPassword.Text == "123456")
            {
                MessageBox.Show("??ng nh?p th�nh c�ng!", "Th�ng b�o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                UI_27_DashboardSale mainForm = new UI_27_DashboardSale();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            } else if (txtUsername.Text == "manager" && txtPassword.Text == "123456")
            {
                MessageBox.Show("??ng nh?p th�nh c�ng!", "Th�ng b�o", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                UI_25_DashboardQuanLy mainForm = new UI_25_DashboardQuanLy();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
