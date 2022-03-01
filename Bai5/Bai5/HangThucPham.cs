using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class HangThucPham
    {
        string mahang;
        string tenhang;
        int dongia;
        DateTime nsx;
        DateTime nhh;
        string kq;
        public void settenhang(string tenhang)
        {
            if (tenhang.Equals(""))
                this.tenhang = "xxx";
            else this.tenhang = tenhang;
        }
        public void setdongia(int dongia)
        {
            if (this.dongia < 0)
                this.dongia = 0;
            else this.dongia = dongia;
        }
        public void setnxs(DateTime nsx)
        {
            int result = DateTime.Compare(this.nsx, DateTime.Now);
            if (result < 0)
                this.nsx = DateTime.Now;
            else this.nsx = nsx;
        }
        public void setnhh(DateTime nhh)
        {
            int result = DateTime.Compare(this.nhh, this.nsx);
            if (result < 0)
                this.nhh = nsx;
            else this.nhh = nhh;
        }
        public string getmahang()
        {
            return this.mahang;
        }
        public string gettenhang() { return this.tenhang; }
        public int getdongia() { return this.dongia; }
        public DateTime getnsx() { return this.nsx; }
        public DateTime getnhh() { return this.nhh;}

        public HangThucPham(string mahang, string tenhang, int dongia, DateTime nsx, DateTime nhh)
        {
            if (mahang.Equals("")) throw new Exception("fail required!");
            else
            {
                this.mahang = mahang;
                settenhang(tenhang);
                setdongia(dongia);
                setnxs(nsx);
                setnhh(nhh);
            }
        }
        public void KiemTra(DateTime nsx, DateTime nhh)
        {
            int result = DateTime.Compare(nsx, nhh);
            if (result < 0)
                kq = "Con han";
            else kq = "Het han ";
        }
        public string getGhichu() { return kq; }
        public override string ToString()
        {
            return string.Format("{0,-13} {1,-16} {2,-18:0,0}{3,-15:d}{4,-16:d}{5}",getmahang(),gettenhang(),getdongia(),getnsx(),getnhh(),getGhichu());
        }
    }
}
