using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLySieuThi.DTO
{
    class LoaiNguoiDung
    {
        public int MaND { get; set; }
        public string TenLoaiND { get; set; }
        public int DiemTichLuyCanThiet { get; set; }
        public int MaCSKH { get; set; }

        static int iMaND = 0, iTenLoaiND = 1, iDiemTichLuyCanThiet = 2, iMaCSKH = 3;

        //method read Loai Nguoi Dung Data
        public static LoaiNguoiDung ReadLoaiNguoiDung(SqlDataReader reader)
        {
            var LoaiNguoiDung = new LoaiNguoiDung()
            {
                MaND = reader.GetInt32(iMaND),
                TenLoaiND = reader.GetString(iTenLoaiND),
                DiemTichLuyCanThiet = reader.GetInt32(iDiemTichLuyCanThiet),
                MaCSKH = reader.GetInt32(iMaCSKH)
            };
            return LoaiNguoiDung;
        }
    }
}
