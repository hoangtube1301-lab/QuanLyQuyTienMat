using BUS;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQuanLyNguoiDung : Form
    {
        private readonly UserService _userService = new UserService();

        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
            LoadGrid(); // 3. Gọi hàm load dữ liệu khi mở Form
        }

        // 4. THÊM HÀM NÀY: Để đổ dữ liệu vào DataGridView
        private void LoadGrid()
        {
            // dgvNguoiDung là tên DataGridView bạn đặt ngoài giao diện
            dgvNguoiDung.DataSource = _userService.GetAllUsers();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng model từ dữ liệu nhập trên màn hình
            var newUser = new NguoiDung
            {
                TenNguoiDung = txtTenDangNhap.Text,
                MatKhau = txtMatKhau.Text,
                VaiTroId = 1 // Giả sử 1 là Admin, 2 là Nhân viên (tùy Database của bạn)
            };

            if (_userService.CreateUser(newUser))
            {
                MessageBox.Show("Thêm thành công!");
                LoadGrid(); // Hàm này gọi lại GetAllUsers để cập nhật GridView
            }
            else
            {
                MessageBox.Show("Lỗi: Tài khoản đã tồn tại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có chọn dòng nào trên bảng không
            if (dgvNguoiDung.CurrentRow != null)
            {
                // Lấy tên đăng nhập của dòng đang chọn
                string username = dgvNguoiDung.CurrentRow.Cells["TenNguoiDung"].Value.ToString();

                var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {username}?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (_userService.RemoveUser(username))
                    {
                        MessageBox.Show("Đã xóa thành công!");
                        LoadGrid(); // Load lại bảng để thấy mất dòng đó đi
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa từ danh sách!");
                return;
            }

            var updatedUser = new NguoiDung
            {
                TenNguoiDung = txtTenDangNhap.Text, // Khóa chính nên không đổi
                MatKhau = txtMatKhau.Text,         // Mật khẩu mới
                VaiTroId = 1                       // Hoặc lấy từ ComboBox vai trò
            };

            if (_userService.UpdateUser(updatedUser))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadGrid(); // Refresh lại bảng
            }
            else
            {
                MessageBox.Show("Không tìm thấy người dùng hoặc có lỗi xảy ra!");
            }
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào dòng dữ liệu (không phải tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // 1. Lấy ra dòng hiện tại đang được click
                DataGridViewRow row = dgvNguoiDung.Rows[e.RowIndex];

                // 2. Đổ dữ liệu từ các cột vào TextBox tương ứng
                // Lưu ý: Tên cột "TenNguoiDung" và "MatKhau" phải khớp với Database/Model
                txtTenDangNhap.Text = row.Cells["TenNguoiDung"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();

                // 3. (Mẹo nhỏ) Khóa ô Username vì đây là khóa chính, không nên cho sửa
                txtTenDangNhap.ReadOnly = true;

                // Bạn có thể đổi màu nền để người dùng biết là đang ở chế độ Sửa
                txtTenDangNhap.BackColor = Color.LightGray;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            // 1. Xóa nội dung trong các ô TextBox dựa theo tên bạn đã đặt
            txtTenDangNhap.Clear(); // Ô "Tài khoản"
            txtMatKhau.Clear();     // Ô "Mật khẩu"

            // 2. Nếu bạn có dùng ComboBox cho Vai trò (ô ở dưới Mật khẩu)
            // cboVaiTro.SelectedIndex = 0; // Trả về lựa chọn đầu tiên

            // 3. QUAN TRỌNG: Mở khóa ô Tài khoản
            // Vì khi Click vào Grid, chúng ta thường khóa ô này để tránh sửa Khóa Chính
            txtTenDangNhap.ReadOnly = false;

            // 4. Trả lại màu trắng cho ô nhập liệu (nếu trước đó đổi sang màu xám ReadOnly)
            txtTenDangNhap.BackColor = Color.White;

            // 5. Đưa con trỏ chuột về ô Tài khoản để người dùng nhập ngay
            txtTenDangNhap.Focus();
        }
    }
}
