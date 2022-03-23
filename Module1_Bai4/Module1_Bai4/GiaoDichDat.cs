using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai4
{
    public class GiaoDichDat : GiaoDich
    {
        public string LoaiDat { get; set; }

        public GiaoDichDat():base(){}

        public GiaoDichDat(string maGiaoDich, string ngayGiaoDich, long donGia, float dienTich, string loaiDat) : base(maGiaoDich, ngayGiaoDich, donGia, dienTich)
        {
            LoaiDat = loaiDat;

        }

        public override long ThanhTien()
        {
            if(LoaiDat.Equals("A")) return (long)(base.ThanhTien()*1.5);
            else return base.ThanhTien();
        }

        public override string toString()
        {
            return base.toString() + ", loại đất: " + this.LoaiDat;
        }
    }
}
