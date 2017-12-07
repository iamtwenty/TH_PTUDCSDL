using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HeThongQuanLySieuThi.DAO;

namespace HeThongQuanLySieuThi.DTO
{
    class HoaDon
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaNV { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal VAT { get; set; }
        public decimal TienKhachDua { get; set; }
        public decimal TienHoanLai { get; set; }
        //
        static int iMaHD = 0, iNgayLap = 1, iMaNV = 2, iThanhTien = 3, iVAT = 4, iTienKhachDua = 5, iTienHoanLai = 6;

        public static HoaDon ReadHoaDon(SqlDataReader reader)
        {
            var hd = new HoaDon
            {
                MaHD = reader.GetInt32(iMaHD),
                NgayLap = reader.GetDateTime(iNgayLap),
                MaNV = reader.GetInt32(iMaNV),
                ThanhTien = reader.GetDecimal(iThanhTien),
                VAT = reader.GetDecimal(iVAT),
                TienKhachDua=reader.GetDecimal(iTienKhachDua),
                TienHoanLai=reader.GetDecimal(iTienHoanLai)
            };
            return hd;
        }
        public static int CreateMaHD()
        {
            var ds = DataUlti.DSHoaDon();
            //
            ds.Sort((hd1,hd2) => -hd1.MaHD.CompareTo(hd2.MaHD));
            int ms = ds[0].MaHD;
            ms++;
            return ms;
        }
    }
}