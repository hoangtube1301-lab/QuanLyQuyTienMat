using System.Collections.Generic;

namespace BUS
{
    public interface ITransactionService
    {
        // Lấy tổng số dư hiện tại trong quỹ
        decimal GetTotalBalance();

        // Lấy danh sách tất cả giao dịch để hiện lên bảng
    }
}