using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai4
{
    public class GiaoDichNha:GiaoDich
    {
        public string LoaiNha { get; set; }
        public string DiaChi { get; set; }

        public GiaoDichNha():base()
        {
        }

        public GiaoDichNha(string maGiaoDich, string ngayGiaoDich, long donGia, float dienTich, string loaiNha, string diaChi) : base(maGiaoDich, ngayGiaoDich, donGia, dienTich)
        {
            LoaiNha = loaiNha;
            DiaChi = diaChi;
        }

        public override long ThanhTien()
        {
            if (LoaiNha.Equals("Cao Cap") || LoaiNha.Equals("cao cap")) return base.ThanhTien();
            else return base.ThanhTien() * 90 / 100;
        }

        public override string toString()
        {
            return base.toString() + ", loại nhà: " + this.LoaiNha + ", địa chỉ: " + this.DiaChi;
        }   
    }
}
