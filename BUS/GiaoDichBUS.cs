using DAL.Models; // Sửa lỗi 1: Import namespace chứa Context và Model
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BUS
{
    public class GiaoDichBUS
    {
        // Hàm lấy dữ liệu báo cáo
        public DataTable LayBangBaoCao(DateTime tu, DateTime den)
        {
            using (var db = new QuanLyTienMatContext())
            {
                // Lưu ý: Nếu db.GiaoDiches báo đỏ, hãy thử đổi thành db.GiaoDichs
                var data = db.GiaoDiches
                             .AsNoTracking() // ÉP EF lấy dữ liệu mới nhất từ DB, không lấy từ bộ nhớ tạm
                             .Where(g => g.NgayCt >= tu.Date && g.NgayCt < den.Date )
                             .ToList();

                return ToDataTable(data); // Sửa lỗi 2: Đã có hàm hỗ trợ bên dưới
            }
        }

        public void TinhToanSoDu(DataTable dt, out decimal tongThu, out decimal tongChi)
        {
            tongThu = 0;
            tongChi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                decimal tien = Convert.ToDecimal(dr["SoTien"]);
                // Kiểm tra đúng tên cột "LoaiGiaoDich" trong database của bạn
                if (dr["LoaiGiaoDich"].ToString() == "1")
                    tongThu += tien;
                else
                    tongChi += tien;
            }
        }

        // Hàm bổ trợ để sửa lỗi "ToDataTable" không tồn tại
        private DataTable ToDataTable(List<GiaoDich> items)
        {
            DataTable dataTable = new DataTable(typeof(GiaoDich).Name);

            // Khai báo các cột đúng theo các thuộc tính trong file GiaoDich.cs (DAL)
            dataTable.Columns.Add("MaGiaoDich");
            dataTable.Columns.Add("NgayGiaoDich");
            dataTable.Columns.Add("LoaiGiaoDich");
            dataTable.Columns.Add("SoTien", typeof(decimal));
            dataTable.Columns.Add("GhiChu");

            foreach (var item in items)
            {
                dataTable.Rows.Add(item.SoCt, item.NgayCt, item.LoaiGiaoDich, item.SoTien, item.DienGiai);
            }
            return dataTable;
        }
    }
}