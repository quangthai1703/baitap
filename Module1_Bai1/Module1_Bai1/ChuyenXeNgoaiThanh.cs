using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai1
{
    public class ChuyenXeNgoaiThanh:ChuyenXe
    {
        private string noiDen { get; set; }
        private int soNgayDiDuoc { get; set; }
        public ChuyenXeNgoaiThanh()
        {

        }
        public ChuyenXeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu, string noiDen, int soNgayDiDuoc)
            :base(maSoChuyen,hoTenTaiXe,soXe,doanhThu)
        {
            this.noiDen = noiDen;
            this.soNgayDiDuoc = soNgayDiDuoc;
        }
        public override void nhapThongTinChuyenXe()
        {
            base.nhapThongTinChuyenXe();
            Console.WriteLine("Nhap noi den: ");
            noiDen = Console.ReadLine();
            Console.WriteLine("Nhap so ngay di duoc: ");
            soNgayDiDuoc = int.Parse(Console.ReadLine());
        }
        public override string toString()
        {
            return base.toString() + ", noi den: " + this.noiDen + ", so ngay di duoc: " +
                    this.soNgayDiDuoc;
        }
    }
}
