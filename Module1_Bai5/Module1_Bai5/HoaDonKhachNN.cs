using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai5
{
    public class HoaDonKhachNN:HoaDonTienDien
    {
        public HoaDonKhachNN():base()
        {
        }

        public HoaDonKhachNN(string maKH, string hoTen, string ngayLapHD, long soKWh, int donGia, string quocTich) : base(maKH, hoTen, ngayLapHD, soKWh, donGia)
        {
            QuocTich = quocTich;
        }

        public string QuocTich { get; set; }

        public override double ThanhTien()
        {
            return base.ThanhTien();
        }

        public override string toString()
        {
            return base.toString() +" , Quốc Tịch: " + this.QuocTich;
        }
    }
}
