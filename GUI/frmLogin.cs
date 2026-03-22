using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu người dùng nhập
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // 2. Kiểm tra không được để trống
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Gọi tầng BUS để kiểm tra đăng nhập
            BUS.UserService userService = new BUS.UserService();
            var loginUser = userService.Login(user, pass);

            if (loginUser != null)
            {
                // Nếu đúng: Thông báo và mở Form chính
                MessageBox.Show($"Đăng nhập thành công! Xin chào {loginUser.TenNguoiDung}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalUser.CurrentUser = loginUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Nếu sai: Báo lỗi
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
