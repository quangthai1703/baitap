
using System;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HangThucPham gao = new HangThucPham("", "Gao", 100000, new DateTime(2018, 07, 10), new DateTime(2018, 07, 10));
                gao.KiemTra(gao.getnsx(), gao.getnhh());
                Console.WriteLine("Ma_Hang      Ten_Hang          Don_gia           NSX             NHH            Ghi chu  ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine(gao.ToString());
            }
            catch (Exception )
            {
                Console.WriteLine("Can not make this object!");
            }
            HangThucPham mi = new HangThucPham("002", "Mi", 100000, new DateTime(2018, 03, 01), new DateTime(2018, 09, 01));
            mi.KiemTra(mi.getnsx(), mi.getnhh());
            Console.WriteLine("Ma_Hang      Ten_Hang          Don_gia           NSX             NHH            Ghi chu  ");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine(mi.ToString());
        }
    }
}