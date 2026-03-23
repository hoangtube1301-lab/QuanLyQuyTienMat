using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SoGiaoDichDAL
    {
        // Thay vì new khơi khơi, mình tạo một hàm để khởi tạo Context chuẩn
        private QuanLyTienMatContext GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<QuanLyTienMatContext>();
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=QuanLyTienMat; Integrated Security=True; TrustServerCertificate=True;");

            return new QuanLyTienMatContext(optionsBuilder.Options);
        }

        public List<GiaoDich> LayDanhSachGiaoDich(DateTime tuNgay, DateTime denNgay, string tuKhoa)
        {
            // Dùng using để đảm bảo kết nối luôn được đóng sau khi lấy dữ liệu
            using (var context = GetContext())
            {
                var query = context.GiaoDiches.AsQueryable();

                query = query.Where(t => t.NgayCt >= tuNgay && t.NgayCt <= denNgay);

                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    query = query.Where(t => t.SoCt.Contains(tuKhoa) || t.DienGiai.Contains(tuKhoa));
                }

                return query.OrderByDescending(t => t.NgayCt).ToList();
            }
        }
    }
}