using System;

namespace Module1_Bai1
{
    class Program
    {
        static void Main(string[] arg)
        {
            List<ChuyenXeNoiThanh> chuyenxenoithanh = new List<ChuyenXeNoiThanh>();
            List<ChuyenXeNgoaiThanh> chuyenxengoaithanh = new List<ChuyenXeNgoaiThanh>();
            int soChuyenNoiThanh, soChuyenNgoaiThanh;
            double doanhThuXeNoiThanh = 0, doanhThuXeNgoaiThanh = 0;

            Console.WriteLine("Nhap so chuyen xe noi thanh: ");
            soChuyenNoiThanh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so chuyen xe ngoai thanh: ");
            soChuyenNgoaiThanh = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap thong tin chuyen xe noi thanh: ");
            for (int i = 0; i < soChuyenNoiThanh; i++)
            {
                Console.WriteLine("Nhap thong tin chuyen xe thu " + (i + 1) + ":");
                ChuyenXeNoiThanh chuyenXeNoiThanh = new ChuyenXeNoiThanh();
                chuyenXeNoiThanh.nhapThongTinChuyenXe();
                doanhThuXeNoiThanh += chuyenXeNoiThanh.doanhThu;
                chuyenxenoithanh.Add(chuyenXeNoiThanh);
            }

            Console.WriteLine("Nhap thong tin chuyen xe ngoai thanh: ");
            for (int i = 0; i < soChuyenNgoaiThanh; i++)
            {
                Console.WriteLine("Nhap thong tin chuyen xe thu " + (i + 1) + ":");
                ChuyenXeNgoaiThanh chuyenXeNgoaiThanh = new ChuyenXeNgoaiThanh();
                chuyenXeNgoaiThanh.nhapThongTinChuyenXe();
                doanhThuXeNgoaiThanh += chuyenXeNgoaiThanh.doanhThu;
                chuyenxengoaithanh.Add(chuyenXeNgoaiThanh);
            }

            Console.WriteLine("-----Thong tin chuyen xe noi thanh-----");
            for (int i = 0; i < chuyenxenoithanh.Count; i++)
            {
                Console.WriteLine(chuyenxenoithanh[i].toString());
            }

            Console.WriteLine("-----Thong tin chuyen xe ngoai thanh-----");
            for (int i = 0; i < chuyenxengoaithanh.Count; i++)
            {
                Console.WriteLine(chuyenxengoaithanh[i].toString());
            }

            Console.WriteLine("Doanh thu tung chuyen xe: ");
            Console.WriteLine("Doanh thu chuyen xe noi thanh: " + doanhThuXeNoiThanh);
            Console.WriteLine("Doanh thu chuyen xe ngoai thanh: " + doanhThuXeNgoaiThanh);
        }
    }
}
