using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class GiaoDichDAL
    {
        // 1. Sửa tên Database thành QuanLyTienMat theo file SQL
        string strCon = @"Data Source=.;Initial Catalog=QuanLyTienMat;Integrated Security=True;TrustServerCertificate=True";
        public DataTable GetDuLieuBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(strCon))
            {
                // 2. Sửa tên cột thành NgayCT, LoaiGiaoDich theo đúng file SQL bạn gửi
                string sql = "SELECT GiaoDichID, NgayCT, LoaiGiaoDich, SoTien, DienGiai FROM GiaoDich WHERE NgayCT BETWEEN @tu AND @den";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@tu", tuNgay);
                cmd.Parameters.AddWithValue("@den", denNgay);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}