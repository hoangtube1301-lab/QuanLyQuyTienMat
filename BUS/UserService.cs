using DAL;
using DAL.Models;
using System;

namespace BUS
{
    public class UserService
    {
        // Khởi tạo lớp DAL để tương tác với Database
        private readonly UserDAL _userDAL = new UserDAL();

        /// <summary>
        /// Logic Đăng nhập: Kiểm tra tên đăng nhập và mật khẩu
        /// </summary>
        /// <param name="username">Tên người dùng nhập</param>
        /// <param name="password">Mật khẩu chưa mã hóa</param>
        /// <returns>Đối tượng NguoiDung nếu thành công, null nếu thất bại</returns>
        public NguoiDung? Login(string username, string password)
        {
            // 1. Tìm người dùng trong DB thông qua DAL
            var user = _userDAL.GetByUsername(username);

            // 2. Nếu không tìm thấy user, trả về null
            if (user == null) return null;

            // 3. Mã hóa mật khẩu người dùng vừa nhập bằng MD5
            string hashedInput = PasswordHasher.HashMD5(password);

            // 4. So sánh mật khẩu đã mã hóa với mật khẩu trong DB
            // Lưu ý: So sánh không phân biệt hoa thường (vì MD5 thường xuất ra chuỗi Hex)
            if (user.MatKhau.Equals(hashedInput, StringComparison.OrdinalIgnoreCase))
            {
                return user; // Đăng nhập thành công
            }

            return null; // Sai mật khẩu
        }
    }
}