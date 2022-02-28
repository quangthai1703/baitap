using System;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle xe1 = new Vehicle("Nguyen Thu Loan","Future Neo", 35000000, 100);
            Vehicle xe2 = new Vehicle("Le Minh Tinh", "Ford Ranger", 250000000,3000);
            Vehicle xe3 = new Vehicle("Nguyen Minh Triet", "Landscape",1000000000,1500);
            xe1.TinhThue();
            xe2.TinhThue(); 
            xe3.TinhThue();
            Console.WriteLine("Ten Chu Xe          Loai xe          Dung tich          Tri gia          Thue phai nop  ");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine(xe1.ToString());
            Console.WriteLine(xe2.ToString());
            Console.WriteLine(xe3.ToString());
        }
    }
}