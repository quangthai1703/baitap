using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module1_Bai4
{
    class Program
    {
        static void Main(string [] arg)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<GiaoDichDat> giaodichdats = new List<GiaoDichDat>();
            List<GiaoDichNha> giaodichnhas = new List<GiaoDichNha>();
            long tongGiaoDichDat = 0, tongGiaoDichNha = 0;

            GiaoDichDat GDD1 = new GiaoDichDat("M001", "15/9/2013", 15000000, 30, "A");
            GiaoDichDat GDD2 = new GiaoDichDat("M002", "8/3/2022", 10000000, 10, "B");
            GiaoDichDat GDD3 = new GiaoDichDat("M003", "10/3/2022", 20000000, 20, "C");

            GiaoDichNha GDN1 = new GiaoDichNha("MGD1", "11/9/2013", 30000000, 60.5f, "Cao Cap", "TP.HCM");
            GiaoDichNha GDN2 = new GiaoDichNha("MGD2", "5/3/2022", 25000000, 30.5f, "thuong", "Tay Ninh");
            GiaoDichNha GDN3 = new GiaoDichNha("MGD3", "7/2/2022", 35000000, 40, "cao cap", "Ha Noi");

            giaodichdats.Add(GDD1);
            giaodichdats.Add(GDD2);
            giaodichdats.Add(GDD3);

            giaodichnhas.Add(GDN1);
            giaodichnhas.Add(GDN2);
            giaodichnhas.Add(GDN3);

            Console.Write("Tổng số tiền giao dịch đất = ");
            for (int i = 0; i < giaodichdats.Count; i++)
            {
                tongGiaoDichDat += giaodichdats[i].ThanhTien();
            }
            Console.WriteLine(tongGiaoDichDat);

            Console.Write("Tổng số tiền giao dịch Nhà = ");
            for (int i = 0; i < giaodichnhas.Count; i++)
            {
                tongGiaoDichNha += giaodichnhas[i].ThanhTien();
            }
            Console.WriteLine(tongGiaoDichNha);

            Console.WriteLine("------ Thông tin các giao dich đất -----");
            for (int i = 0;i<giaodichdats.Count; i++)
            {
                Console.WriteLine(giaodichdats[i].toString());
            }
            Console.WriteLine();

            Console.WriteLine("------ Thông tin các giao dich nhà -----");
            for (int i = 0; i < giaodichnhas.Count; i++)
            {
                Console.WriteLine(giaodichnhas[i].toString());
            }
            Console.WriteLine();
            Console.WriteLine("TRUNG BÌNH THÀNH TIỀN CỦA CÁC GIAO DỊCH ĐẤT = " + tongGiaoDichDat/giaodichdats.Count);
            Console.WriteLine();
            // xuất ra các giao dịch của tháng 9 năm 2013
            Console.WriteLine("Các giao dịch đất của tháng 9 năm 2013: ");
            for (int i = 0; i < giaodichdats.Count; i++)
            {
                String[] dateGiaoDichDat = giaodichdats[i].NgayGiaoDich.Split("/");
                if (dateGiaoDichDat[1].Equals("9") && dateGiaoDichDat[2].Equals("2013"))
                    Console.WriteLine(giaodichdats[i].toString());
            }
            Console.WriteLine("Các giao dịch đất của tháng 9 năm 2013: ");
            for (int i = 0; i < giaodichnhas.Count; i++)
            {
                String[] dateGiaoDichNha = giaodichnhas[i].NgayGiaoDich.Split("/");
                if (dateGiaoDichNha[1].Equals("9") && dateGiaoDichNha[2].Equals("2013"))
                    Console.WriteLine(giaodichnhas[i].toString());
            }

        }
    }
}