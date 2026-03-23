using DAL;
using DAL.Models;
using System;

namespace BUS
{
    public class UserService
    {
        private readonly UserDAL _userDAL = new UserDAL();

        public NguoiDung? Login(string username, string password)
        {
            // 1. Tìm người dùng trong DB
            var user = _userDAL.GetByUsername(username);

            // 2. Nếu không tìm thấy user hoặc mật khẩu trống, trả về null
            if (user == null || string.IsNullOrEmpty(password)) return null;

            // 3. SO SÁNH TRỰC TIẾP (VĂN BẢN THUẦN)
            // Dùng .Trim() để tránh lỗi nếu trong DB hoặc Winform có dư khoảng trắng
            if (user.MatKhau.Trim() == password.Trim())
            {
                return user; // Đăng nhập thành công
            }

            return null; // Sai mật khẩu
        }
    }
}