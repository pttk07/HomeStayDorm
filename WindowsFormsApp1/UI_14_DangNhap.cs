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
            string username = txtUsername.Text.Trim().ToLowerInvariant();
            string password = txtPassword.Text;

            if (password != "123456")
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form dashboard = null;

            if (username == "admin")
            {
                dashboard = new UI_26_DashboardQTHethong();
            }
            else if (username == "sale")
            {
                dashboard = new UI_27_DashboardSale();
            }
            else if (username == "accountant" || username == "ketoan")
            {
                dashboard = new UI_28_DashboardKeToan();
            }
            else if (username == "manager" || username == "quanly")
            {
                dashboard = new UI_25_DashboardQuanLy();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
