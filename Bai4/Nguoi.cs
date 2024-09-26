using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Nguoi
    {
        private string hoTen;
        private string gioiTinh;
        private int tuoi;
        public Nguoi()
        {
                
        }

        public Nguoi(string hoTen, string gioiTinh, int tuoi)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.Tuoi = tuoi;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public virtual void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhập giới tính (Nam/Nữ): ");
            gioiTinh = Console.ReadLine();

            Console.Write("Nhập tuổi: ");
            while (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi <= 0)
            {
                Console.WriteLine("Tuổi không hợp lệ, vui lòng nhập lại (tuổi phải lớn hơn 0): ");
            }
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Thông tin người:");
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Giới tính: {gioiTinh}");
            Console.WriteLine($"Tuổi: {tuoi}");
        }


    }
}
