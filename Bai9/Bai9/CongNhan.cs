using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public class CongNhan
    {
        public string MaCN { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        protected double luongNhanVien;
        private double _soSP;
        public double SoSP
        {
            get { return _soSP; }
            set { if(value > 0) _soSP = value; } 
        }

        public CongNhan(string maCN, string ho, string ten, int soSP)
        {
            MaCN = maCN;
            Ho = ho;
            Ten = ten;
            SoSP = soSP;
        }
        public CongNhan() { }
        private double Luong()
        {
            if (SoSP >= 1 && SoSP < 200) return this.SoSP * 0.5;
            else if (SoSP < 400) return this.SoSP * 0.55;
            else if (SoSP < 600) return this.SoSP * 0.6;
            else return this.SoSP * 0.65;
        }
        public void Input()
        {
            Console.WriteLine("Ma CN: ");
            MaCN = Console.ReadLine();
            Console.WriteLine("Ho CN: ");
            Ho = Console.ReadLine();
            Console.WriteLine("Ten CN: ");
            Ten = Console.ReadLine();
            Console.WriteLine("So san pham: ");
            SoSP = int.Parse(Console.ReadLine());
        }

        public string toString()
        {
            return string.Format("{0,-10}{1,-10}{2,-10}{3,-10}{4}", this.MaCN, this.Ho, this.Ten, this.SoSP, this.Luong());
        }
    }
}
