using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLySieuThi.DTO
{
    class CT_HoaDon
    {
        public int MaHD { get; set; }
        public int MaMH { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public float HeSoGiam { get; set; }
        public decimal ThanhTien { get; set; }
        //
        static int iMaHD = 0, iMaMH = 1, iSoLuong = 2, iDonGia = 3, iHeSoGiam = 4, iThanhTien = 5;

        public static CT_HoaDon ReadHoaDon(SqlDataReader reader)
        {
            var cthd = new CT_HoaDon
            {
                MaHD = reader.GetInt32(iMaHD),
                MaMH = reader.GetInt32(iMaMH),
                SoLuong = reader.GetInt32(iSoLuong),
                DonGia = reader.GetDecimal(iDonGia),
                HeSoGiam = reader.GetFloat(iHeSoGiam),
                ThanhTien = reader.GetDecimal(iThanhTien)
            };
            return cthd;
        }
    }
}
