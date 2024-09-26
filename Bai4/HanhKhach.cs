using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
   
    internal class HanhKhach : Nguoi
    {
        List<VeMayBay> yourVeMayBay;
        int soLuong;
        public HanhKhach()
        {
                
        }

        public HanhKhach(string hoTen, string gioiTinh, int tuoi, List<VeMayBay> yourVeMayBay, int soLuong) : base(hoTen, gioiTinh, tuoi)
        {
            this.yourVeMayBay = yourVeMayBay;
            this.soLuong = soLuong;
        }

        public List<VeMayBay> YourVeMayBay { get => yourVeMayBay; set => yourVeMayBay = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public override void Nhap()
        {
            base.Nhap();           
        }
        public double TongTien(List<VeMayBay> yourVeMayBay)
        {
            double money = 0;
            foreach (var item in yourVeMayBay)
            {
                money = money + item.GiaVe;
            }
            return money;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Tong so tien khach hang phai tra: " + TongTien(YourVeMayBay));
            
            Console.WriteLine("So luong ve khach hang dat la : " + yourVeMayBay.Count);

        }
    }
}
