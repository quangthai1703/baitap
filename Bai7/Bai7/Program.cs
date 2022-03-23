using System;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhTron O = new HinhTron(new ToaDo(5, 5), 10.5);
            Console.WriteLine($"Hinh tron co tam: {O}");
            Console.WriteLine($"Chu vi: {O.tinhChuVi()}");
            Console.WriteLine(O.tinhDienTich());
        }
    }
}