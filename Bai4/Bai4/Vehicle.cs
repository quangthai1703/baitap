using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Vehicle
    {
        string ChuXe;
        string LoaiXe;
        int TriGia;
        int DungTich;
        int Thue;
       public void setChuXe(string ChuXe)
        {
            this.ChuXe=ChuXe;
        }
        public void setLoaiXe(string LoaiXe)
        {
            this.LoaiXe = LoaiXe;
        }
        public void setTriGia(int TriGia)
        {
            if (TriGia < 0)
                this.TriGia = 0;
            this.TriGia= TriGia;
        }
        public void setDungTich(int DungTich)
        {
            if (DungTich< 0)
                this.DungTich = 0;
            this.DungTich = DungTich;
        }
        public string getChuXe()
        {
            return ChuXe;
        }
        public string getLoaiXe() { return LoaiXe; }
        public int getTriGia() { return TriGia; }
        public int getDungTich() { return DungTich; }
        public void TinhThue()
        {
            if (DungTich < 100)
            { Thue = TriGia / 100; }
            else if (DungTich < 200)
            {
                Thue = (TriGia / 100)*3;
            }
            else
            {
              Thue = (TriGia /100)*5;
            }
        }
        public int getThue() { return Thue; }
        public Vehicle(string chuXe, string loaiXe, int triGia, int dungTich)
        {
          setChuXe(chuXe);
          setDungTich(dungTich);
          setLoaiXe(loaiXe);
          setTriGia(triGia); 
        }

        public Vehicle()
        {
        }

        public override string ToString()
        {
            return string.Format("{0,-20} {1,-10} {2,10} {3,22:n} {4,22:n}", getChuXe(), getLoaiXe(), getDungTich(), getTriGia(), getThue());
        }
    }
}
