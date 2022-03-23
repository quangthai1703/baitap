using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai3
{
    public class GiaoDichVang:GiaoDich
    {
        public string LoaiVang { get; set; }

        public GiaoDichVang():base()
        {
        }
        public GiaoDichVang(string maGiaoDich, string ngayGiaoDich, long donGia, int soLuong,string loaiVang) : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            LoaiVang = loaiVang;
        }

        public override double ThanhTien()
        {
            return base.ThanhTien();
        }

        public override string toString()
        {
            return base.toString() + ", loại vàng: " + this.LoaiVang;
        }
    }
}
