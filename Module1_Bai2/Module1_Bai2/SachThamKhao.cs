using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai2
{
    public class SachThamKhao:Sach
    {
        public double Thue { get; set; }
        private double ThanhTien;


        public SachThamKhao():base()
        {

        }

        public SachThamKhao(string maSach, string ngayNhap, double donGia, int soLuong, string nhaXuatBan,double thue) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            Thue = thue;
        }

        public override string toString()
        {
            return base.toString() + ", thue: " + this.Thue;
        }
    }
}
