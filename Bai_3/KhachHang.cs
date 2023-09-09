using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class KhachHang
    {
        string hoTen;
        bool thoiGian;
        decimal giaThuyen;
        decimal tien;
        string doUong;
        int soLuong;

        public KhachHang()
        {

        }
        public KhachHang(string hoTen, bool thoiGian, decimal giaThuyen, decimal tien, string doUong, int soLuong)
        {
            this.hoTen = hoTen;
            this.thoiGian = thoiGian;
            this.giaThuyen = giaThuyen;
            this.tien = tien;
            this.doUong = doUong;
            this.soLuong = soLuong;
        }

        public decimal tinhTien()
        {
            decimal sum = giaThuyen + tien;
            return sum;
        }
        public override string ToString()
        {
            string s = "Ho Ten: " + hoTen + " " + " Thoi gian di: " + thoiGian + " " + "Tong tien: " + tinhTien().ToString();
            return s; 
        }


    }
}
