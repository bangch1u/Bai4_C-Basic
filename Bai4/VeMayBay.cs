using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class VeMayBay
    {
        private string tenChuyen;
        private DateTime ngayBay;
        private double giaVe;


        public VeMayBay()
        {
                
        }

        public VeMayBay(string tenChuyen, DateTime ngayBay, double giaVe)
        {
            this.TenChuyen = tenChuyen;
            this.NgayBay = ngayBay;
            this.GiaVe = giaVe;
        }

        public string TenChuyen { get => tenChuyen; set => tenChuyen = value; }
        public DateTime NgayBay { get => ngayBay; set => ngayBay = value; }
        public double GiaVe { get => giaVe; set => giaVe = value; }

        //public string TenChuyen { get => tenChuyen; set => tenChuyen = value; }
        //private DateTime NgayBay { get => ngayBay; set => ngayBay = value; }
        //private double GiaVe { get => giaVe; set => giaVe = value; }

        public void Nhap()
        {
            Console.Write("Nhập tên chuyến bay: ");
            TenChuyen = Console.ReadLine();

            Console.Write("Nhập ngày bay (dd/MM/yyyy): ");
            string ngayBayInput = Console.ReadLine();
            if (DateTime.TryParseExact(ngayBayInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
            {
                NgayBay = parsedDate;
            }
            else
            {
                Console.WriteLine("Ngày nhập không hợp lệ, vui lòng nhập lại.");
                Nhap(); // Gọi lại hàm Nhap nếu ngày không hợp lệ
            }

            Console.Write("Nhập giá vé: ");
            giaVe = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Thông tin vé máy bay:");
            Console.WriteLine($"Tên chuyến bay: {TenChuyen}");
            Console.WriteLine($"Ngày bay: {NgayBay.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Giá vé: {GiaVe:C}"); // Hiển thị giá vé dưới định dạng tiền tệ
        }

    }
}
