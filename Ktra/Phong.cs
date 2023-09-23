using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra
{
    internal class Phong
    {
        string diaChi;
        int soPhong;
        int soVesinh;
        string huongPhong;
        double trietKhau;
        double gia;
        bool tinhTrang;
        public Phong()
        {
            tinhTrang = true;
        }

        public Phong(string diaChi, int soPhong, int soVesinh,string huongPhong, double trietKhau, double gia, bool tinhTrang)
        {
            this.diaChi = diaChi;
            this.soPhong = soPhong;
            this.soVesinh = soVesinh;
            this.huongPhong = huongPhong;
            this.trietKhau = trietKhau;
            this.gia = gia;
            this.tinhTrang = tinhTrang;
        }

        public double Gia { get => gia; }
        public bool TinhTrang { get => tinhTrang; }
        public string DiaChi { get => diaChi; }
        public int SoPhong { get => soPhong;  }
        public int SoVesinh { get => soVesinh; }
        public string HuongPhong { get => huongPhong; }
        public double TrietKhau { get => trietKhau; }
    }
   
}
