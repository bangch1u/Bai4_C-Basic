using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            #region method Ve
            List<VeMayBay> lstVe = new List<VeMayBay>();
            Console.Write("Nhap so luong ve muon them: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                VeMayBay veNew = new VeMayBay();
                veNew.Nhap();
                lstVe.Add(veNew);
            }
            Console.WriteLine("Danh sach ve sau khi them");
            foreach (VeMayBay item in lstVe)
            {
                item.Xuat();
            }
            #endregion

            #region method HanhKhach
            List<HanhKhach> lstHK = new List<HanhKhach>();
            Console.WriteLine("Nhap so luong hanh khach muon them: ");
            int count2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count2; i++)
            {
                HanhKhach hanhKhach = new HanhKhach();
                hanhKhach.Nhap();
                lstHK.Add(hanhKhach);

                #region Khach Hang Mua Ve
                Console.Write("Nhap so luong ve muon mua: ");
                int slVe = Convert.ToInt32(Console.ReadLine());
                hanhKhach.YourVeMayBay = new List<VeMayBay>();
                for (int e = 0; e < slVe; e++)
                {
                    Console.Write("Nhap ten chuyen bay: ");
                    string tenChuyenBay = Console.ReadLine();
                    VeMayBay findVe = lstVe.Find(v => v.TenChuyen == tenChuyenBay);
                    if (findVe == null)
                    {
                        Console.WriteLine("Khong co ve ten " + tenChuyenBay);
                        continue;
                    }

                    hanhKhach.YourVeMayBay.Add(findVe);
                }
                #endregion


            }
            Console.WriteLine("Danh khach hang sau khi them");
            foreach (HanhKhach item in lstHK)
            {
                Console.WriteLine("------------------------------------------------");
                item.Xuat();
            }
            #endregion



        }
    }
}
