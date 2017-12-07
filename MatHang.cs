using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLySieuThi.DTO
{
    class MatHang
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public string DonVi { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }
        public int MaCSKM { get; set; }
        public int MaLoaiMH { get; set; }
        public int TrangThai { get; set; }
        public int  NhaPhanPhoi { get; set; }

        public static int iMaMH = 0, iTenMH = 1, iDonVi = 2, iGiaBan = 3, iGiaNhap = 4, iMaCSKM = 5, iMaLoaiMH = 6, iTrangThai = 7, iNhaPhanPhoi = 8;

        //method read Mat Hang Data
        public static MatHang ReadMatHang(SqlDataReader reader)
        {
            var matHang = new MatHang()
            {
                MaMH = reader.GetInt32(iMaMH),
                TenMH = reader.GetString(iTenMH),
                DonVi = reader.GetString(iDonVi),
                GiaBan = reader.GetDecimal(iGiaBan),
                GiaNhap = reader.GetDecimal(iGiaNhap),
                MaCSKM = reader.GetInt32(iMaCSKM),
                MaLoaiMH = reader.GetInt32(iMaLoaiMH),
                TrangThai = reader.GetInt32(iTrangThai),
                NhaPhanPhoi = reader.GetInt32(iNhaPhanPhoi)
            };
            return matHang;
        }
    }
}
