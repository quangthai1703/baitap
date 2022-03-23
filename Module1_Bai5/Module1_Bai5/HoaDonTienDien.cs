using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai5
{
    public class HoaDonTienDien
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string NgayLapHD { get; set; }
        public long SoKWh { get; set; }
        public int DonGia { get; set; }

        public HoaDonTienDien(string maKH, string hoTen, string ngayLapHD, long soKWh, int donGia)
        {
            MaKH = maKH;
            HoTen = hoTen;
            NgayLapHD = ngayLapHD;
            SoKWh = soKWh;
            DonGia = donGia;
        }
        public HoaDonTienDien()
        {
        }
        public virtual double ThanhTien()
        {
            return SoKWh * DonGia;
        }

        public virtual string toString()
        {
            return $"Mã Khách Hàng: {this.MaKH}, Họ Tên: {this.HoTen}, Ngày lập HĐ: {this.NgayLapHD}, Số KWh tiêu thụ: {this.SoKWh}, Đơn Giá: {this.DonGia}";
        }
    }
}
