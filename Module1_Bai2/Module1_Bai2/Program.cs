using Module1_Bai2;
using System;
using System.Text;

namespace Module_Bai2
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<SachGiaoKhoa> sachgiaokhoa = new List<SachGiaoKhoa>();
            List<SachThamKhao> sachthamkhao = new List<SachThamKhao>();
            int soSachGiaoKhoa, soSachThamKhao;
            double tongTienSachGiaoKhoa = 0, tongTienSachThamKhao = 0, tongDonGiaSachThamKhao = 0, trungBinhCongDonGia = 0;

            SachGiaoKhoa SGK1 = new SachGiaoKhoa("MS001", "7/3/2022", 30000, 10,"NXB HN", "cu");
            SachGiaoKhoa SGK2 = new SachGiaoKhoa("MS002", "7/3/2022", 25000, 30, "NXB HN", "moi");
            SachGiaoKhoa SGK3 = new SachGiaoKhoa("MS003", "7/3/2022", 20000, 20, "NXB HN", "cu");
            sachgiaokhoa.Add(SGK1);sachgiaokhoa.Add(SGK2);sachgiaokhoa.Add(SGK3);

            SachThamKhao STK1 = new SachThamKhao("MS111", "8/3/2022", 20000, 5, "NXB HCM", 5000);
            SachThamKhao STK2 = new SachThamKhao("MS222", "8/3/2022", 15000, 100, "NSB HCM", 3000);
            SachThamKhao STK3 = new SachThamKhao("MS333","8/3/2022",10000,50,"NXB HCM",1000);
            sachthamkhao.Add(STK1); sachthamkhao.Add(STK2); sachthamkhao.Add(STK3);

            for (int i = 0; i < sachgiaokhoa.Count(); i++)
            {
                if (sachgiaokhoa[i].Number == 0)
                {
                    tongTienSachGiaoKhoa += sachgiaokhoa[i].SoLuong *
                        sachgiaokhoa[i].DonGia * 50 / 100;
                }
                else if (sachgiaokhoa[i].Number == 1)
                {
                    tongTienSachGiaoKhoa += sachgiaokhoa[i].SoLuong *
                        sachgiaokhoa[i].DonGia;
                }
            }
            Console.WriteLine("Tổng tiền sách giáo khoa = " + tongTienSachGiaoKhoa);

            for (int i = 0; i < sachthamkhao.Count; i++)
            {
                tongTienSachThamKhao += sachthamkhao[i].SoLuong *
                    sachthamkhao[i].DonGia + sachthamkhao[i].Thue;
            }
            Console.WriteLine("Tổng tiền sách tham khảo = " + tongTienSachThamKhao);


            for (int i = 0; i < sachthamkhao.Count; i++)
            {
                tongDonGiaSachThamKhao += sachthamkhao[i].DonGia;
                trungBinhCongDonGia = tongDonGiaSachThamKhao / sachthamkhao.Count;
            }
            Console.WriteLine("Trung bình cộng đơn giá các sách tham khảo = " + trungBinhCongDonGia);

            Console.WriteLine("-----Thông tin sách giáo khoa-----");
            for (int i = 0; i < sachgiaokhoa.Count; i++)
            {
                Console.WriteLine(sachgiaokhoa[i].toString());
            }

            Console.WriteLine("-----Thông tin sách tham khảo-----");
            for (int i = 0; i < sachthamkhao.Count; i++)
            {
                Console.WriteLine(sachthamkhao[i].toString());
            }

        }
    }
}
