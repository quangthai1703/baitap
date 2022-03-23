using System;
using System.Collections.Generic;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CD> CDlist = new List<CD>();
            int choose;
            do
            {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Input(CDlist);
                        break;
                    case 2:
                        Console.WriteLine("----------------- Thong tin CD --------------");
                        Console.WriteLine(string.Format("{0,-10} {1,-20} {2,-20} {3,-20}", "Ma CD", "Ten CD", "So bai hat", "Gia ban"));
                        Display(CDlist);
                        break;
                    case 3:
                        CD cd = new CD();
                        cd.Input();
                        int count = 0;
                        for (int i = 0; i < CDlist.Count; i++)
                        {
                            if (CDlist[i].Cdnumber == cd.Cdnumber)
                            {
                                count++;
                                Console.WriteLine("Them vao khong thanh cong!!! Ma bi trung");
                            }
                        }
                        if(count == 0) CDlist.Add(cd);
                        break;
                    case 4:
                        Console.WriteLine(" So luong CD trong List la: {0}", CDlist.Count);
                        break;
                    case 5:
                        Sumprice(CDlist);
                        break;
                    case 6:
                        CD temp = CDlist[0];
                        for (int i = 0; i < CDlist.Count - 1; i++)
                        {
                            for (int j = i + 1; j < CDlist.Count; j++)
                            {
                                if (CDlist[i].Price < CDlist[j].Price)
                                {
                                    temp = CDlist[j];
                                    CDlist[j] = CDlist[i];
                                    CDlist[i] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Sap xep thanh cong! Nhap so 2 de kiem tra!");
                        break;
                    case 7:
                        temp = CDlist[0];
                        for (int i = 0; i < CDlist.Count - 1; i++)
                        {
                            for (int j = i + 1; j < CDlist.Count; j++)
                            {
                                if (CDlist[i].Cdname.CompareTo(CDlist[j].Cdname) > 0)
                                {
                                    temp = CDlist[j];
                                    CDlist[j] = CDlist[i];
                                    CDlist[i] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Sap xep thanh cong! Nhap so 2 de kiem tra!");
                        break;
                    case 8:
                        Console.WriteLine("Ket thuc!!!");
                        break;
                    default:
                        Console.WriteLine("Nhap sai, Vui long nhap lai!");
                        break;
                }
            }
            while (choose != 8);
        }
        static void Input(List<CD> CDlist)
        {
            Console.WriteLine("Nhap so luong CD can them vao danh sach: ");
            int n= int.Parse(Console.ReadLine());
            for(int i= 0; i < n; i++)
            {
                CD cd = new CD();
                cd.Input();
                CDlist.Add(cd);
            }
        }
        static void Display(List<CD> CDlist)
        {
            for (int i = 0; i < CDlist.Count; i++)
            {
               CDlist[i].Display();
            }
        }
        static void Sumprice(List<CD> CDlist)
        {
            float sum = 0;
            for (int i = 0;i < CDlist.Count; i++)
            {
                sum += CDlist[i].Price;
            }
            Console.WriteLine("Tong gia thanh cua cac CD: {0}", sum);
        }
        static void ShowMenu()
        {
            Console.WriteLine("1.\t Nhap thong tin n CD");
            Console.WriteLine("2.\t Hien thi thong tin vua nhap");
            Console.WriteLine("3.\t Them 1 CD vao danh sach va hien thi");
            Console.WriteLine("4.\t So luong CD co trong danh sach");
            Console.WriteLine("5.\t Tong gia thanh cua cac CD");
            Console.WriteLine("6.\t Sap xep danh sach giam dan theo gia thanh");
            Console.WriteLine("7.\t Sap xep danh sach tang dan theo ten CD");
            Console.WriteLine("8.\t Thoat");
            Console.WriteLine("Lua chon: ");
        }
    }
}