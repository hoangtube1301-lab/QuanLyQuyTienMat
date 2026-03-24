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
            this.Resize += (s, e) => { this.Refresh(); };
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
                if (user.VaiTroId == 1)
                {
                    menuQuanLyNguoiDung.Visible = true; // Admin thì cho hiện
                }
                else
                {
                    menuQuanLyNguoiDung.Visible = false; // Không phải admin thì ẩn đi
                }
            }
            // Duyệt tìm thành phần MdiClient (vùng màu xám)
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient mdi)
                {
                    mdi.BackgroundImage = this.BackgroundImage;

                    mdi.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoGiaoDich f = new frmSoGiaoDich();
            f.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao bc = new frmBaoCao();
            bc.ShowDialog();
        }

        private void thuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuThu t = new frmPhieuThu();
            t.ShowDialog();
        }

        private void chiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuChi c = new frmPhieuChi();
            c.ShowDialog();
        }

        private void menuQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            // Tìm xem form này đã mở chưa
            Form frm = Application.OpenForms["frmQuanLyNguoiDung"];

            if (frm == null)
            {
                // Nếu chưa mở thì tạo mới
                frmQuanLyNguoiDung f = new frmQuanLyNguoiDung();
                f.MdiParent = this; // Dòng này sẽ hết lỗi sau khi thực hiện Bước 1
                f.Show();
            }
            else
            {
                // Nếu mở rồi thì hiển thị nó lên
                frm.Activate();
            }
        }
    }
}
