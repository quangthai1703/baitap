using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class HinhTamGiac
    {
        private int ma;
        private int mb;
        private int mc;
        private string KieuTamGiac;
        public HinhTamGiac()
        {
        }
     
        public void setma(int ma)
        {
           if (this.ma < 0) ma=0;
           else this.ma = ma;
        }
        public void setmb(int mb)
        {
            if (this.mb < 0) mb = 0;
            this.mb = mb;
        }
        public void setmc(int mc)
        {
            if (this.mc < 0) mc = 0;
            this.mc = mc;
        }
        public int getma()
        {
            return ma;
        }
        public int getmb()
        {
            return mb;
        }
        public int getmc()
        {
            return mc;
        }
        public HinhTamGiac(int ma, int mb, int mc)
        {
            
            if ((ma < mb + mc) && (mb < ma + mc) && (mc < mb + ma))
            {
                setma(ma);
                setmb(mb);
                setmc(mc);
            }
            else ma = mb = mc = 0;
        }
        public int getCV()
        {
            return ma + mb + mc;
        }
        public int getDT()
        {
            int p = (ma + mb + mc) / 2;
            return (int)Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
        }
        public void setKieuTamGiac()
        {
            if ((ma < mb + mc) && (mb < ma + mc) && (mc < mb + ma))
            {
                if ((ma * ma == mb * mb + mc * mc) || (mb * mb == ma * ma + mc * mc) || (mc * mc == ma * ma + mb * mb))
                {
                    KieuTamGiac = "Tam giac vuong";
                }
                else if (ma == mb && mb == mc)
                {
                    KieuTamGiac = "Tam giac deu";
                }
                else if (ma == mb || mb == mc || ma == mc)
                {
                    KieuTamGiac =  "Tam giac can";
                }
                else if ((ma * ma > mb * mb + mc * mc) || (mb * mb > ma * ma + mc * mc) || (mc * mc > ma * ma + mb * mb))
                {
                    KieuTamGiac =  "Tam giac tu";
                }
            }
            else KieuTamGiac = "Khong phai tam giac";
        } 
        public string getKieuTamGiac()
        {
            return KieuTamGiac;
        }
   
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-25} {4,-15} {5}",getma(), getmb(), getmc(), getKieuTamGiac(), getCV(), getDT());
        }
    }
}
