using System;
using System.Collections.Generic;
using System.Text;

namespace BUS.Models
{
    public class Receipt : Transaction
    {
        // Tự động gán bằng 1 (Khớp với điều kiện Constraint trong SQL: 1 là Thu)
        public override byte LoaiGiaoDich => 1;
        // Phiếu thu thì đối tượng là Người nộp tiền
        public string NguoiNopTien { get; set; }
        // Đẩy tên Người Nộp vào cột TenDoiTuong của DB
        public override string TenDoiTuong
        {
            get => NguoiNopTien;
            set => NguoiNopTien = value;
        }
        public override string GetTransactionDetails()
        {
            return $"[PHIẾU THU - {SoCT}] Ngày: {NgayCT:dd/MM/yyyy} | Nộp bởi: {TenDoiTuong} | Số tiền: +{SoTien:N0} VNĐ";
        }
    }
}
