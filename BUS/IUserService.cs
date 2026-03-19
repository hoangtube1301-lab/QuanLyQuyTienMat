namespace BUS
{
    public interface IUserService
    {
        // Hàm đăng nhập: trả về true nếu thành công
        bool Login(string username, string password);

        // Hàm đổi mật khẩu
        bool ChangePassword(string username, string oldPassword, string newPassword);
    }
}