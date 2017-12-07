using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLySieuThi.DTO
{
    class ChinhSachKhachHang
    {
        public int MaCSKH { get; set; }
        public string TenChinhSach { get; set; }
        public decimal TongTienHoaDonToiThieu { get; set; }
        public float HeSoGiamGia { get; set; }
        public decimal DiemCongToiThieu { get; set; }
        

        static int iMaCSKH = 0, iTenChinhSach = 1, iTongTienHoaDonToiThieu = 2, iHeSoGiamGia = 3, iDiemCongToiThieu = 4;

        //method read ChinhSachKhachHang Data
        public static ChinhSachKhachHang ReadKhachHang(SqlDataReader reader)
        {
            var cskh = new ChinhSachKhachHang()
            {
                MaCSKH = reader.GetInt32(iMaCSKH),
                TenChinhSach = reader.GetString(iTenChinhSach),
                TongTienHoaDonToiThieu = reader.GetInt32(iTongTienHoaDonToiThieu),
                HeSoGiamGia = reader.GetFloat(iHeSoGiamGia),
                DiemCongToiThieu = reader.GetInt32(iDiemCongToiThieu)
            };
            return cskh;
        }
    }
}
