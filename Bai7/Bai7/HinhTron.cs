using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    internal class HinhTron: ToaDo
    {
        ToaDo tam;
        double banKinh;
        public double tinhChuVi()
        {
            return 2 * 3.14 * banKinh;
        }
        public double tinhDienTich()
        {
            return 3.14 * banKinh * banKinh;
        }

        public HinhTron(ToaDo tam, double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        public void setTam(ToaDo tam)
        {
            this.tam = (ToaDo)tam;
        }
        public void setBanKinh(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public ToaDo getTam() { return tam; }
        public double getBanKinh() { return banKinh; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
