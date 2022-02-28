using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTamGiac Hinh1 = new HinhTamGiac(5,5,5);
            HinhTamGiac Hinh2 = new HinhTamGiac(3,4,5);
            HinhTamGiac Hinh3 = new HinhTamGiac(9,5,4); 
            HinhTamGiac Hinh4 = new HinhTamGiac(1,2,5);
            HinhTamGiac Hinh5 = new HinhTamGiac(3,3,4);
            Hinh1.setKieuTamGiac();
            Hinh2.setKieuTamGiac();
            Hinh3.setKieuTamGiac();
            Hinh4.setKieuTamGiac();
            Hinh5.setKieuTamGiac();
            Console.WriteLine("canha     canhb     canhc        Loai                     Chuvi       Dientich");
            Console.WriteLine(Hinh1.ToString());
            Console.WriteLine(Hinh2.ToString());
            Console.WriteLine(Hinh3.ToString());
            Console.WriteLine(Hinh4.ToString());
            Console.WriteLine(Hinh5.ToString());
        }
    }
}