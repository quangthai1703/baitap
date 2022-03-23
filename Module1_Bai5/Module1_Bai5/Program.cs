using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module1_Bai5
{
    class Program
    {
        static void Main(string[]arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<HoaDonVN> hoaDonVNs = new List<HoaDonVN>();
            List<HoaDonKhachNN> hoaDonKhachNNs = new List<HoaDonKhachNN>();
            double tongThanhTienVN = 0, tongThanhTienNN = 0;

            HoaDonVN HD1 = new HoaDonVN("MKH01", "Lê Hải Dương", "15/9/2018", 12345, 3500, "sinh hoạt", 20000);
            HoaDonVN HD2 = new HoaDonVN("MKH02", "Nguyễn Hoàng Việt", "8/3/2022", 23456, 3000, "kinh doanh", 30000);
            HoaDonVN HD3 = new HoaDonVN("MKH03", "Huỳnh Hưng Thịnh", "5/3/2022", 123456, 2500, "sản xuất", 50000);

            HoaDonKhachNN HDNN1 = new HoaDonKhachNN("M001", "Tony Duong", "12/9/2018", 12345, 3500, "Hoa Kỳ");
            HoaDonKhachNN HDNN2 = new HoaDonKhachNN("M002", "Jeremy Berath", "5/3/2022", 23456, 3000, "Anh");
            HoaDonKhachNN HDNN3 = new HoaDonKhachNN("M003", "Beranko Nith", "5/3/2022", 123456, 2500, "Tây Ban Nha");

            hoaDonVNs.Add(HD1); hoaDonVNs.Add(HD2); hoaDonVNs.Add(HD3);
            hoaDonKhachNNs.Add(HDNN1); hoaDonKhachNNs.Add(HDNN2); hoaDonKhachNNs.Add(HDNN3);

            Console.Write("TỔNG THÀNH TIỀN HÓA ĐƠN KHÁCH VIỆT NAM = ");
            for(int i = 0;i< hoaDonVNs.Count; i++)
            {
                tongThanhTienVN += hoaDonVNs[i].ThanhTien();
            }
            Console.WriteLine(tongThanhTienVN);
            Console.WriteLine();

            Console.Write("TỔNG THÀNH TIỀN HÓA ĐƠN KHÁCH NƯỚC NGOÀI = ");
            for (int i = 0; i < hoaDonKhachNNs.Count; i++)
            {
                tongThanhTienNN += hoaDonKhachNNs[i].ThanhTien();
            }
            Console.WriteLine(tongThanhTienNN);
            Console.WriteLine();

            Console.Write("TRUNG BÌNH THÀNH TIỀN CỦA KHÁCH NƯỚC NGOÀI = ");
            Console.WriteLine(tongThanhTienNN / hoaDonKhachNNs.Count);
            Console.WriteLine();

            // xuất ra các giao dịch của tháng 9 năm 2018
            Console.WriteLine("Hóa đơn của khách VN trong tháng 9 năm 2018: ");
            for (int i = 0; i < hoaDonVNs.Count; i++)
            {
                String[] dateHoaDonVN = hoaDonVNs[i].NgayLapHD.Split("/");
                if (dateHoaDonVN[1].Equals("9") && dateHoaDonVN[2].Equals("2018"))
                    Console.WriteLine(hoaDonVNs[i].toString());
            }
            Console.WriteLine("Hóa đơn của khách NN trong tháng 9 năm 2018 ");
            for (int i = 0; i < hoaDonKhachNNs.Count; i++)
            {
                String[] dateHoaDonNN = hoaDonKhachNNs[i].NgayLapHD.Split("/");
                if (dateHoaDonNN[1].Equals("9") && dateHoaDonNN[2].Equals("2018"))
                    Console.WriteLine(hoaDonKhachNNs[i].toString());
            }
        }
    }
}