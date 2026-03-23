using DAL;
using DAL.Models;
using System;

namespace BUS
{
    public class TransactionService
    {
        private readonly TransactionDAL _transactionDAL = new TransactionDAL();

        // Hàm này trả về string. Nếu thành công trả về rỗng "", nếu lỗi trả về câu thông báo lỗi
        public string AddNewTransaction(GiaoDich gd)
        {
            // 1. Kiểm tra các quy tắc nghiệp vụ cơ bản
            if (string.IsNullOrWhiteSpace(gd.SoCt))
                return "Vui lòng nhập Số chứng từ!";

            if (gd.SoTien <= 0)
                return "Số tiền phải lớn hơn 0!";

            // Ràng buộc "Thép": LoaiGiaoDich chỉ được là 1 (Thu) hoặc 0 (Chi)
            if (gd.LoaiGiaoDich != 0 && gd.LoaiGiaoDich != 1)
                return "Loại giao dịch không hợp lệ (Chỉ được 0 hoặc 1)!";

            // 2. Gọi DAL để lưu, dùng try-catch để bắt lỗi từ Database (ví dụ trùng mã)
            try
            {
                _transactionDAL.AddTransaction(gd);
                return ""; // Rỗng nghĩa là thành công không có lỗi
            }
            catch (Exception ex)
            {
                // Bắt lỗi Unique Constraint (Trùng Số Chứng Từ) từ SQL Server dội lên
                if (ex.InnerException != null && ex.InnerException.Message.Contains("UNIQUE KEY"))
                {
                    return "Số chứng từ này đã tồn tại trong hệ thống. Vui lòng nhập số khác!";
                }
                return "Lỗi hệ thống: " + ex.Message;
            }
        }
    }
}