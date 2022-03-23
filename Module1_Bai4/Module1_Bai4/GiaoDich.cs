using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai4
{
    public class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public string NgayGiaoDich { set; get; }
        public long DonGia { get; set; }
        public double DienTich { get; set; }
        public GiaoDich(string maGiaoDich, string ngayGiaoDich, long donGia, float dienTich)
        {
            MaGiaoDich = maGiaoDich;
            NgayGiaoDich = ngayGiaoDich;
            DonGia = donGia;
            DienTich = dienTich;
        }
        public GiaoDich()
        {
        }
        public virtual long ThanhTien() => ((long)(DienTich * DonGia));
        public virtual string toString()
        {
            return "Mã giao dịch: " + this.MaGiaoDich + ", ngày giao dịch: " + this.NgayGiaoDich +
            ", đơn giá: " + this.DonGia + ", diện tích: " + this.DienTich;
        }
    }
}
