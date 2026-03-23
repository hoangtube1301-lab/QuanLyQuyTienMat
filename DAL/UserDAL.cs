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
        // 1. Lấy toàn bộ danh sách người dùng
        public List<NguoiDung> GetAll()
        {
            return _context.NguoiDungs.Include(u => u.VaiTro).ToList();
        }

        // 2. Thêm người dùng mới
        public bool Add(NguoiDung user)
        {
            try
            {
                _context.NguoiDungs.Add(user);
                _context.SaveChanges(); // Lưu thay đổi vào Database
                return true;
            }
            catch { return false; }
        }

        // 3. Xóa người dùng
        public bool Delete(string username)
        {
            try
            {
                var user = _context.NguoiDungs.FirstOrDefault(u => u.TenNguoiDung == username);
                if (user != null)
                {
                    _context.NguoiDungs.Remove(user);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
        public bool Update(NguoiDung user)
        {
            try
            {
                // Tìm user cũ trong Database dựa trên TenNguoiDung
                var existingUser = _context.NguoiDungs.FirstOrDefault(u => u.TenNguoiDung == user.TenNguoiDung);
                if (existingUser != null)
                {
                    // Cập nhật các thông tin mới
                    existingUser.MatKhau = user.MatKhau;
                    existingUser.VaiTroId = user.VaiTroId;
                    // Nếu bạn có thêm cột Họ tên, Email... thì cập nhật tiếp ở đây

                    _context.SaveChanges(); // Lưu vào DB
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
    }
}
