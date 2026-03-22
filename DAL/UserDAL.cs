using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL
{
    // Phải là public để tầng BUS gọi được
    public class UserDAL
    {
        private readonly QuanLyTienMatContext _context;

        public UserDAL()
        {
            // Khởi tạo kết nối Database
            _context = new QuanLyTienMatContext();
        }

        // Hàm lấy thông tin người dùng kèm theo Vai Trò (Admin/Kế toán)
        public NguoiDung? GetByUsername(string username)
        {
            return _context.NguoiDungs
                           .Include(u => u.VaiTro)
                           .FirstOrDefault(u => u.TenNguoiDung == username);
        }
    }
}
