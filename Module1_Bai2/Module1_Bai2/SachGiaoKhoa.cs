using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai2
{
    public class SachGiaoKhoa:Sach
    {
        string TinhTrang { get; set; }
        public int Number { get; set; }
        private double thanhTien;
        public SachGiaoKhoa():base(){}

        public SachGiaoKhoa(string maSach, string ngayNhap, double donGia, int soLuong, string nhaXuatBan,string TinhTrang) : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.TinhTrang = TinhTrang;
        }

        public String tinhTrangSach(int x)
        {
            switch (Number)
            {
                case 0:
                    TinhTrang = "cu";
                    break;
                case 1:
                    TinhTrang = "moi";
                    break;
                default:
                    break;
            }
            return TinhTrang;
        }
        public override string toString()
        {
            return base.toString() + ", tinh trang sach: " + this.TinhTrang;
        }

    }
}
