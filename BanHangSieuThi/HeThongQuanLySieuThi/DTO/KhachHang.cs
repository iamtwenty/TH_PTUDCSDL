using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLySieuThi.DTO
{
    class KhachHang
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayDangKi { get; set; }
        public int MaND { get; set; }
        public int DiemTichLuy { get; set; }

        static int iMaKH = 0, iTenKH = 1, iNgaySinh = 2, iDiaChi = 3, iNgayDangKi = 4, iMaND = 5, iDiemTichLuy = 6;

        //read data into Khach Hang
        public static KhachHang ReadKhachHang(SqlDataReader reader)
        {
            var khachHang = new KhachHang()
            {
                MaKH = reader.GetInt32(iMaKH),
                TenKH = reader.GetString(iTenKH),
                NgaySinh = reader.GetDateTime(iNgaySinh),
                DiaChi = reader.GetString(iDiaChi),
                NgayDangKi = reader.GetDateTime(iNgayDangKi),
                MaND = reader.GetInt32(iMaND),
                DiemTichLuy = reader.GetInt32(iDiemTichLuy)
            };
            return khachHang;
        }
    }
}
