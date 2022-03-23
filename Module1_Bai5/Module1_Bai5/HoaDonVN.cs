using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai5
{
    public class HoaDonVN:HoaDonTienDien
    {
        public string DoiTuong { get; set; }
        public long DinhMuc { get; set; }


        public HoaDonVN(string maKH, string hoTen, string ngayLapHD, long soKWh, int donGia, string doiTuong, long dinhMuc) : base(maKH, hoTen, ngayLapHD, soKWh, donGia)
        {
            DoiTuong = doiTuong;
            DinhMuc = dinhMuc;
        }

        public HoaDonVN():base()
        {
        }

        public override double ThanhTien()
        {
            if (SoKWh <= DinhMuc) return base.ThanhTien();
            else return base.ThanhTien() * DinhMuc + (SoKWh - DinhMuc) * DonGia * 2.5;
        }

        public override string toString()
        {
            return base.toString() + ", Đối tượng: " + this.DoiTuong + ", Định mức: " + this.DinhMuc;
        }
    }
}
