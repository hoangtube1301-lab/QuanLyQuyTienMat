using DAL.Models;

namespace BUS
{
    public static class GlobalUser
    {
        // Biến này sẽ giữ thông tin người dùng xuyên suốt chương trình
        public static NguoiDung? CurrentUser { get; set; }
    }
}
