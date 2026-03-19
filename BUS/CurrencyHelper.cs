using System;
using System.Globalization;

namespace BUS
{
    public static class CurrencyHelper
    {
        /// <summary>
        /// Hàm chuyển đổi số (decimal) sang định dạng tiền Việt Nam (VNĐ)
        /// Ví dụ: 5000000 -> 5.000.000 VNĐ
        /// </summary>
        public static string FormatVND(decimal amount)
        {
            // Sử dụng định dạng số của Việt Nam
            CultureInfo cul = new CultureInfo("vi-VN");
            return amount.ToString("N0", cul) + " VNĐ";
        }

        /// <summary>
        /// Hàm hỗ trợ nếu bạn muốn hiển thị số tiền mà không có chữ VNĐ
        /// </summary>
        public static string FormatNumber(decimal amount)
        {
            CultureInfo cul = new CultureInfo("vi-VN");
            return amount.ToString("N0", cul);
        }
    }
}