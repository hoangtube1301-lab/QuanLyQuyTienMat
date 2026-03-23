namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmBaoCao());

            // 1. Mở bảng đăng nhập lên trước
            frmLogin login = new frmLogin();

            // 2. Nếu bấm Đăng nhập thành công (OK) thì mới mở tiếp
            if (login.ShowDialog() == DialogResult.OK)
            {
                // Mượn tạm frmBase làm giao diện chính cho đơn giản
                Application.Run(new frmMain());
            }
        }
    }
}