using System;
using System.Data;
using DAL; // Để gọi được lớp DAL ở trên

namespace BUS
{
    public class GiaoDichBUS
    {
        GiaoDichDAL dal = new GiaoDichDAL();

        public DataTable LayBangBaoCao(DateTime tu, DateTime den)
        {
            return dal.GetDuLieuBaoCao(tu, den);
        }

        // Hàm này giúp bạn tính toán con số hiển thị lên Label
        public void TinhToanSoDu(DataTable dt, out decimal tongThu, out decimal tongChi)
        {
            tongThu = 0; tongChi = 0;
            foreach (DataRow dr in dt.Rows)
            {
                decimal tien = Convert.ToDecimal(dr["SoTien"]);
                // Sửa: 1 là Thu, 0 là Chi theo Database của nhóm
                if (dr["LoaiGiaoDich"].ToString() == "1")
                    tongThu += tien;
                else
                    tongChi += tien;
            }
        }
    }
}