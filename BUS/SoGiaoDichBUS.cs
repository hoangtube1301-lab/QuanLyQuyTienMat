using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Models;

namespace BUS
{
    public class SoGiaoDichBUS
    {
        private readonly SoGiaoDichDAL _dal = new SoGiaoDichDAL();
        public List<dynamic> HienThiSoQuy(DateTime tuNgay, DateTime denNgay, string tuKhoa)
        {
            // 1. Gọi DAL để lấy dữ liệu thô từ SQL
            var danhSachRaw = _dal.LayDanhSachGiaoDich(tuNgay, denNgay, tuKhoa);

            // 2. Sắp xếp theo ngày tăng dần để tính tồn quỹ lũy kế cho đúng
            var danhSachSắpXếp = danhSachRaw.OrderBy(t => t.NgayCt).ToList();

            decimal tonLuyKe = 0;
            var ketQua = new List<dynamic>();

            foreach (var item in danhSachSắpXếp)
            {
                decimal thu = 0;
                decimal chi = 0;

                // Tách SoTien thành Thu hoặc Chi dựa vào LoaiGiaoDich
                // Giả định: 1 là Thu, 0 là Chi
                if (item.LoaiGiaoDich == 1)
                {
                    thu = item.SoTien;
                    tonLuyKe += thu;
                }
                else
                {
                    chi = item.SoTien;
                    tonLuyKe -= chi;
                }

                // Tạo một đối tượng mới chứa đầy đủ các cột để hiện lên GUI
                ketQua.Add(new
                {
                    Ngay = item.NgayCt,
                    SoPhieu = item.SoCt,
                    NoiDung = item.DienGiai,
                    TienThu = thu,
                    TienChi = chi,
                    TonQuy = tonLuyKe
                });
            }

            // Trả về danh sách
            return ketQua;
        }
    }
}