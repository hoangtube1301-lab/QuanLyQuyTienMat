using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : frmBase
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Lấy thông tin user đã lưu lúc đăng nhập
            var user = BUS.GlobalUser.CurrentUser;

            if (user != null)
            {
                // 1. Hiện tên lên thanh status dưới cùng
                lblUserStatus.Text = $"Người dùng: {user.TenNguoiDung} | Quyền: {user.VaiTro?.TenVaiTro}";

                // 2. Phân quyền: Giả sử ID 1 là Admin, ID 2 là Nhân viên
                if (user.VaiTroId != 1)
                {
                    menuQuanLyNguoiDung.Visible = true; // Admin thì cho hiện
                }
                else
                {
                    menuQuanLyNguoiDung.Visible = false; // Không phải admin thì ẩn đi
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
