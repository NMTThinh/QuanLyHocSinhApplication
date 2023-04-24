using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhApplication
{
    internal class Program
    {
        class HocSinh
        {
            public string HoTen;
            public float diemToan;
            public float diemVan;
            public float diemAV;
            public double diemTB;

            public HocSinh NhapTT()
            {
                HocSinh hs= new HocSinh();
                Console.Write("Nhap ho va ten hoc sinh: ");
                hs.HoTen=Console.ReadLine();
                Console.Write("Nhap diem toan: ");
                hs.diemToan = float.Parse(Console.ReadLine());
                Console.Write("Nhap diem van: ");
                hs.diemVan= float.Parse(Console.ReadLine());
                Console.Write("Nhap diem anh van: ");
                hs.diemAV= float.Parse(Console.ReadLine());
                hs.diemTB = (hs.diemToan + hs.diemVan + hs.diemAV) / 3;
                return hs;
            }
           public void XuatTT()
            {
                Console.WriteLine("Ho va ten hoc sinh la: "+HoTen);
                Console.WriteLine("Diem toan = "+diemToan);
                Console.WriteLine("Diem van = "+diemVan);
                Console.WriteLine("Diem anh van = "+diemAV);
                Console.WriteLine("Diem trung binh = "+diemTB);
            }
        }

        static void Main(string[] args)
        {
            List<HocSinh> hocSinhs = new List<HocSinh>();
            Console.Write("Nhap so luong hoc sinh: ");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                HocSinh hs=new HocSinh();
                Console.WriteLine("Nhap thong tin hoc sinh thu "+(i+1)+" : ");
                hs = hs.NhapTT();
                hocSinhs.Add(hs);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Thong tin hoc sinh vua nhap la: ");
            foreach(HocSinh hs in hocSinhs)
            {
                hs.XuatTT();
            }
            
        }
    }
}
