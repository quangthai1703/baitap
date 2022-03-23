using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai3
{
    public class GiaoDich
    {
       
        public string MaGiaoDich { get; set; }
        public string NgayGiaoDich { get; set; }
        public long DonGia { get; set; }
        public int SoLuong { get; set; }
        public GiaoDich(){}

        public GiaoDich(string maGiaoDich, string ngayGiaoDich, long donGia, int soLuong)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            SoLuong = soLuong;
        }
        public virtual double ThanhTien()
        {
            return this.DonGia*this.SoLuong;
        }

        public virtual string toString()
        {
            return "Mã giao dịch: " + this.MaGiaoDich + ", ngày giao dịch: " + this.NgayGiaoDich +
            ", đơn giá: " + this.DonGia + ", số lượng: " + this.SoLuong;
        }
    }
}
