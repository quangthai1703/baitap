using System;
using System.Text;

namespace Module1_Bai3
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<GiaoDichVang> giaodichvang = new List<GiaoDichVang>();
            List<GiaoDichTienTe> giaodichtiente = new List<GiaoDichTienTe>();
            int soGiaoDichVang = 0, soGiaoDichTienTe = 0;
            double tongTienGiaoDichVang = 0, tongTienGiaoDichTienTe = 0,trungBinhThanhTien = 0;

            GiaoDichVang GDV1 = new GiaoDichVang("MGD01", "8/9/2013", 15000000000, 30, "9999");
            GiaoDichVang GDV2 = new GiaoDichVang("MGD02", "8/3/2022", 10000000, 10, "SCJ");
            GiaoDichVang GDV3 = new GiaoDichVang("MGD03", "7/3/2022", 8000000, 15, "PNJ");

            GiaoDichTienTe GDT1 = new GiaoDichTienTe("M111", "8/9/2013", 15000, 30, 1, "VN");
            GiaoDichTienTe GDT2 = new GiaoDichTienTe("M222", "9/3/2022", 22851, 50, 0.08, "USD");
            GiaoDichTienTe GDT3 = new GiaoDichTienTe("M333", "8/3/2022", 24792, 40, 0.05, "EUR");

            giaodichvang.Add(GDV1);
            giaodichvang.Add(GDV2);
            giaodichvang.Add(GDV3);

            giaodichtiente.Add(GDT1);
            giaodichtiente.Add(GDT2);
            giaodichtiente.Add(GDT3);


            for(int i = 0; i < giaodichvang.Count; i++)
            {
                tongTienGiaoDichVang += giaodichvang[i].ThanhTien();
                soGiaoDichVang += giaodichvang[i].SoLuong;
            }
            Console.WriteLine("Tổng Số lượng giao dịch vàng = "+ soGiaoDichVang);
            Console.WriteLine("Tổng tiền giao dịch vàng  = " + tongTienGiaoDichVang);

            for (int i = 0; i < giaodichtiente.Count; i++)
            {
                soGiaoDichTienTe += giaodichtiente[i].SoLuong;
                tongTienGiaoDichTienTe += giaodichtiente[i].ThanhTien();
                trungBinhThanhTien = tongTienGiaoDichTienTe / giaodichtiente.Count;
            }
            Console.WriteLine("Tổng số lượng giao dịch tiền tệ = " + soGiaoDichTienTe);
            Console.WriteLine("Tổng tiền giao dịch Tiền tệ  = " + tongTienGiaoDichTienTe);
            Console.WriteLine("Trung bình thành tiền của giao dịch Tiền tệ = " + trungBinhThanhTien);

            Console.WriteLine("-----Thông tin giao dịch có đơn giá trên 1 tỷ-----");
            for (int i = 0; i < giaodichvang.Count; i++)
            {
                if(giaodichvang[i].DonGia>=1000000000) Console.WriteLine(giaodichvang[i].toString());
            }
            for(int i = 0; i < giaodichtiente.Count; i++)
            {
                if (giaodichtiente[i].DonGia >= 1000000000) Console.WriteLine(giaodichtiente[i].toString());
            }

        }
    }
}