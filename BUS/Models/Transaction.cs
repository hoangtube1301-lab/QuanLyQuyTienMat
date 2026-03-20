using System;
using System.Collections.Generic;
using System.Text;
namespace BUS.Models
{
    public abstract class Transaction
    {
        // Các thuộc tính khớp với bảng GiaoDich trong SQL
        public int GiaoDichID { get; set; }
        public string SoCT { get; set; }
        public DateTime NgayCT { get; set; }
        public string DienGiai { get; set; }
        public string TKDoiUng { get; set; }
        public string DiaChi { get; set; }
        public string SoTienBangChu { get; set; }
        public string ChungTuGoc { get; set; }

        // Tính đóng gói cho Số Tiền
        private decimal _soTien;
        public decimal SoTien
        {
            get { return _soTien; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lỗi: Số tiền giao dịch phải lớn hơn 0!");
                }
                _soTien = value;
            }
        }

        // --- CÁC THUỘC TÍNH TRỪU TƯỢNG (Bắt buộc lớp con phải tự định nghĩa) ---

        // Trả về 1 (Thu) hoặc 0 (Chi) để lưu xuống DB
        public abstract byte LoaiGiaoDich { get; }

        // Sẽ map với cột TenDoiTuong trong DB
        public abstract string TenDoiTuong { get; set; }

        // Tính đa hình: Hàm in thông tin chung
        public abstract string GetTransactionDetails();
    }
}
