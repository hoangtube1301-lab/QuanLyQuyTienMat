using System;
using System.Collections.Generic;
using System.Text;

namespace BUS.Models
{
    public class Payment : Transaction
    {
        // Tự động gán bằng 0 (Khớp với điều kiện Constraint trong SQL: 0 là Chi)
        public override byte LoaiGiaoDich => 0;
        // Phiếu chi thì đối tượng là Người nhận tiền
        public string NguoiNhanTien { get; set; }
        // Đẩy tên Người Nhận vào cột TenDoiTuong của DB
        public override string TenDoiTuong
        {
            get => NguoiNhanTien;
            set => NguoiNhanTien = value;
        }
        public override string GetTransactionDetails()
        {
            return $"[PHIẾU CHI - {SoCT}] Ngày: {NgayCT:dd/MM/yyyy} | Chi cho: {TenDoiTuong} | Số tiền: -{SoTien:N0} VNĐ";
        }
    }
}
