using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai11
{
    class Program
    {
        static void Main(string [] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<HocVien> hocViens = new List<HocVien>();
            int soluongLamLuanVan = 0, soluongThiTotNghiep = 0, soluongThiLai = 0;
            HocVien HV1 = new HocVien("Le Hai Duong", 1999, 9, 7.5, 8.5, 7, 7.5);
            HocVien HV2 = new HocVien("Nguyen Hoang Viet", 2003, 8, 8, 7, 9.5, 9);
            HocVien HV3 = new HocVien("Luu Khoa Hoc", 2003, 8.5, 7, 8.5, 6.5, 7);
            HocVien HV4 = new HocVien("Huynh Hung Thinh", 2000, 6.5, 6, 7, 5, 5);
            HocVien HV5 = new HocVien("Truong Tat Sang", 1999, 4, 5, 7, 8, 9);
            hocViens.Add(HV1);
            hocViens.Add(HV2);
            hocViens.Add(HV3);
            hocViens.Add(HV4);
            hocViens.Add(HV5);

            for(int i = 0; i < hocViens.Count; i++)
            {
                if (hocViens[i].isLamLuanVan() == true) soluongLamLuanVan++;
                else if (hocViens[i].isThiTotNghiep() == true) soluongThiTotNghiep++;
                else soluongThiLai++;
            }
            Console.WriteLine("Số lượng học viên làm luận văn = " + soluongLamLuanVan);
            Console.WriteLine("Số lượng học viên thi tốt nghiệp = " + soluongThiTotNghiep);
            Console.WriteLine("Số lượng học viên thi lại = "+ soluongThiLai);
        }
    }
}