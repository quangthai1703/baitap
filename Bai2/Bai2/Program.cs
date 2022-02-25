using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {

            Students sv1 = new Students(1, "Thai", 8.5f, 9);
            Students sv2 = new Students(2, "Quang", 8, 7);
            Students sv3 = new Students();
            Console.WriteLine("Nhap ma so cua sinh vien sv3: ");
            int Id_sv3 = int.Parse(Console.ReadLine());
            sv3.setId(Id_sv3);
            Console.WriteLine("Nhap ho va ten cua sinh vien sv3: ");
            string name_sv3 = Console.ReadLine();
            sv3.setName(name_sv3);
            Console.WriteLine("Nhap diem ly thuyet cua sinh vien sv3: ");
            float LT_sv3 = float.Parse(Console.ReadLine());
            sv3.setLT(LT_sv3);
            Console.WriteLine("Nhap diem thuc hanh cua sinh vien sv3: ");
            float TH_sv3 = float.Parse(Console.ReadLine());
            sv3.setTH(TH_sv3); 
            Console.WriteLine("MSSV  hoten                         diemLT     diemTH     diemTB");
            Console.WriteLine(sv1.ToString());
            Console.WriteLine(sv2.ToString());
            Console.WriteLine(sv3.ToString());                  
        }
    }
}