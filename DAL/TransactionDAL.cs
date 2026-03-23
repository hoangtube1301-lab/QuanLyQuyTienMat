using DAL.Models;
using System;

namespace DAL
{
    public class TransactionDAL
    {
        private readonly QuanLyTienMatContext _context;

        public TransactionDAL()
        {
            _context = new QuanLyTienMatContext();
        }

        // Hàm thêm mới 1 giao dịch
        public void AddTransaction(GiaoDich gd)
        {
            _context.GiaoDiches.Add(gd);
            _context.SaveChanges(); // Lệnh này sẽ đẩy dữ liệu xuống SQL
            // Lưu ý: Nếu trùng Số Chứng Từ (SoCt), SQL sẽ báo lỗi ngay tại dòng SaveChanges này!
        }
    }
}