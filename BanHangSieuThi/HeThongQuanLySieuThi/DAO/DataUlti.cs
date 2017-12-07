using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using HeThongQuanLySieuThi.DTO;
using System.Configuration;

namespace HeThongQuanLySieuThi.DAO
{
    class DataUlti
    {
        static string cnString;
        static string nameCS = "sqlPC_QLBH";
        static SqlConnection cn;
        static DataUlti()
        {
            //
            cnString = ConfigurationManager.ConnectionStrings[nameCS].ConnectionString;
            cn = new SqlConnection(cnString);
        }
        //
        static SqlCommand CreateCommand()
        {
            //
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            //
            var cm = new SqlCommand();
            cm.Connection = cn;
            return cm;
        }
        //
        public static List<HoaDon> DSHoaDon()
        {
            var lhd = new List<HoaDon>();
            var cm = CreateCommand();
            cm.CommandText = @"Select * from HOA_DON";
            //
            var reader = cm.ExecuteReader();
            while (reader.Read())
            {
                lhd.Add(HoaDon.ReadHoaDon(reader));
            }
            //
            cn.Close();
            return lhd;
        }
        public static bool ThemHoaDon(HoaDon hd)
        {
            var cm = CreateCommand();
            cm.CommandText = @"Insert into HOA_DON(MaHD, NgayLap, MaNV, ThanhTien, VAT, TienKhachDua, TienHoanLai) Values (@MaHD, @NgayLap, @MaNV, @ThanhTien, @VAT, @TienKhachDua, @TienHoanLai)";
            cm.Parameters.Add(new SqlParameter("@MaHD", hd.MaHD));
            cm.Parameters.Add(new SqlParameter("@NgayLap", hd.NgayLap));
            cm.Parameters.Add(new SqlParameter("@MaNV", hd.MaNV));
            cm.Parameters.Add(new SqlParameter("@ThanhTien", hd.ThanhTien));
            cm.Parameters.Add(new SqlParameter("@VAT", hd.VAT));
            cm.Parameters.Add(new SqlParameter("@TienKhachDua", hd.TienKhachDua));
            cm.Parameters.Add(new SqlParameter("@TienHoanLai", hd.TienHoanLai));
            int rs = cm.ExecuteNonQuery();
            cn.Close();
            //
            return rs > 0;
        }
        
    }
}
