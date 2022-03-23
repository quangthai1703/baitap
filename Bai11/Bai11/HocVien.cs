using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    public class HocVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public double DiemToan { get; set; }
        public double DiemVan { get; set; }
        public double DiemAnh { get; set; }
        public double DiemHoa { get; set; }
        public double DiemLy { get; set; }

        public HocVien()
        {
        }

        public HocVien(string hoTen, int namSinh, double diemToan, double diemVan, double diemAnh, double diemHoa, double diemLy)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            DiemToan = diemToan;
            DiemVan = diemVan;
            DiemAnh = diemAnh;
            DiemHoa = diemHoa;
            DiemLy = diemLy;
        }
        public double DiemTB()
        {
            return (DiemToan + DiemVan + DiemAnh + DiemHoa + DiemLy) / 5;
        }
        public bool isLamLuanVan()
        {
            if(DiemToan >= 5 && DiemVan >=5 && DiemAnh >=5 && DiemHoa >= 5 && DiemLy >= 5)
            {
                if (DiemTB() > 7) return true;
                return false;
            }
            return false;
        }
        public bool isThiTotNghiep()
        {
            if (DiemToan >= 5 && DiemVan >= 5 && DiemAnh >= 5 && DiemHoa >= 5 && DiemLy >= 5)
            {
                if (DiemTB() <= 7) return true;
                return false;
            }
            return false;
        }
    }
}
