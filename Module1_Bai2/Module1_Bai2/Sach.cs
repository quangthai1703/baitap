using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_Bai2
{
    public class Sach
    {
        private string MaSach { get; set; }
        private string NgayNhap { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        private string NhaXuatBan { get; set; }

        public Sach()
        {
        }

        public Sach(string maSach, string ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            MaSach = maSach;
            NgayNhap = ngayNhap;
            DonGia = donGia;
            SoLuong = soLuong;
            NhaXuatBan = nhaXuatBan;
        }
        
        public virtual double thanhtien()
        {
            return this.DonGia * this.SoLuong;
        } 
        public virtual string toString()
        {
            return "Ma Sach: " + this.MaSach + ", Ten NXB: " + this.NhaXuatBan + ", Don gia: " +
                    this.DonGia + ", So luong: " + this.SoLuong;
        }
    }
}
