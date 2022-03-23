using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai1
{
    public class ChuyenXeNoiThanh : ChuyenXe
    {
        private string soTuyen { get; set; }
        private double soKmDiDuoc { get; set; }

        public ChuyenXeNoiThanh()
        {
        }

        public ChuyenXeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu,string soTuyen, double soKmDiDuoc) :base(maSoChuyen,hoTenTaiXe,soXe,doanhThu)
        {
            this.soTuyen = soTuyen;
            this.soKmDiDuoc = soKmDiDuoc;
        }

        public override void nhapThongTinChuyenXe()
        {
            base.nhapThongTinChuyenXe();
            Console.WriteLine("Nhap so tuyen: ");
            soTuyen = Console.ReadLine();
            Console.WriteLine("Nhap so km di duoc: ");
            soKmDiDuoc = double.Parse(Console.ReadLine());
        }

        public override string toString()
        {
            return base.toString() + ", so tuyen: " + this.soTuyen +
                ", so km di duoc: " + this.soKmDiDuoc;
        }
    }
}
