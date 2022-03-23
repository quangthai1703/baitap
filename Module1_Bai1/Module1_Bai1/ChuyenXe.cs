using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai1
{
    public class ChuyenXe
    {
        private string maSoChuyen { get; set; }
        private string hoTenTaiXe { get; set; }
        private string soXe { get; set; }
        public double doanhThu { get; set; }

        public ChuyenXe()
        {
            this.maSoChuyen = "";
            this.hoTenTaiXe = "";
            this.soXe = "";
            this.doanhThu = 0;
        }

        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu)
        {
            this.maSoChuyen = maSoChuyen;
            this.hoTenTaiXe = hoTenTaiXe;
            this.soXe = soXe;
            this.doanhThu = doanhThu;
        }
        public virtual void nhapThongTinChuyenXe()
        {
            Console.WriteLine("Nhap ma so chuyen: ");
            maSoChuyen = Console.ReadLine();
            Console.WriteLine("Nhap ho ten tai xe: ");
            hoTenTaiXe = Console.ReadLine();
            Console.WriteLine("Nhap so xe: ");
            soXe = Console.ReadLine();
            Console.WriteLine("Nhap doanh thu: ");
            doanhThu = double.Parse(Console.ReadLine());
        }
        public virtual string toString()
        {
            return "Ma so chuyen: " + this.maSoChuyen + ", ho ten tai xe: " + this.hoTenTaiXe
                    + ", so xe: " + this.soXe + ", doanh thu: " + this.doanhThu;
        }

    }
}
