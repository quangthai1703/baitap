using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai3
{
    public class GiaoDichTienTe:GiaoDich
    {
        public double TiGia { get; set; }
        public string LoaiTienTe { get; set; }

        public GiaoDichTienTe():base()
        {
        }
        public GiaoDichTienTe(string maGiaoDich, string ngayGiaoDich, long donGia, int soLuong,double tiGia,string loaiTienTe) : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
        {
            TiGia = tiGia;
            LoaiTienTe = loaiTienTe;
        }

        public override double ThanhTien()
        {

            if (LoaiTienTe.Equals("VND")) return base.ThanhTien();
            else return base.ThanhTien() * this.TiGia;
        }

        public override string toString()
        {
            return base.toString() + ", tỉ giá: " + this.TiGia + ", loại tiền tệ: " + this.LoaiTienTe;
        }
    }
}
