using System;
using System.Collections;
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
            public float diemTB;

            //Phương thức khởi tạo không tham số 
            // public có thể truy cập được từ bên ngoài class.
            public HocSinh NhapTT()
            {
                //Khai báo và khởi tạo biến có tên là hs.
                HocSinh hs;//có giá trị là null 
                hs = new HocSinh();
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
                Console.WriteLine("     Diem toan = "+diemToan);
                Console.WriteLine("     Diem van = "+diemVan);
                Console.WriteLine("     Diem anh van = "+diemAV);
                Console.WriteLine("     Diem trung binh = "+diemTB);
            }
        }

        static void Main(string[] args)
        {
            //Khởi tạo và khai báo danh sách có tên là hocSinhs 
            List<HocSinh> hocSinhs = new List<HocSinh>();
            Console.Write("Nhap so luong hoc sinh: ");
            //Kiểm tra nReadline có phải số nguyên không 
            string nReadline = Console.ReadLine();
            int n = int.Parse(nReadline);
            // vòng lặp for để nhập thông tin 
            for (int i = 0; i < n; i++)
            {
                HocSinh hs = new HocSinh();
                Console.WriteLine("Nhap thong tin hoc sinh thu " + (i + 1) + ". ");
                hs = hs.NhapTT();
                hocSinhs.Add(hs);
            }
            //vòng lặp foreach để xuất thông tin trong list 
            Console.WriteLine("------------------------------");
            Console.WriteLine("Thong tin hoc sinh vua nhap la: ");
            foreach (HocSinh hs in hocSinhs)
            {
                hs.XuatTT();
            }
            //Tìm học sinh có điểm trung bình cao nhất.
            //khai báo 2 biến để xuất tên và điểm.
            Console.WriteLine("------------------------------");
            double max = hocSinhs[0].diemTB;
            string tenhs = hocSinhs[0].HoTen;
            for(int i = 1; i < n; i++)
            {
                if (hocSinhs[i].diemTB > max)
                {
                    max = hocSinhs[i].diemTB;
                    tenhs = hocSinhs[i].HoTen;
                }
                if (hocSinhs[i].diemTB == max)
                {
                    Console.WriteLine("Hoc sinh co diem trung binh cao nhat la: " + tenhs + "-" + max);
                }
                
            }
            // Tìm những học sinh có điểm toán >= 8 
            Console.WriteLine("------------------------------");
            Console.WriteLine("Nhung hoc sinh co diem toan tren 8.0 la: ");
            foreach (HocSinh hs in hocSinhs)
            {
                if (hs.diemToan >= 8)
                {
                   
                    Console.WriteLine(hs.HoTen+"-"+hs.diemToan);
                }
               
            }
            //Sắp xếp điểm trung bình từ thấp đến cao trong list 
            hocSinhs.Sort(
                (p1, p2) =>
                {
                    if (p1.diemTB == p2.diemTB) return 0;
                    if (p1.diemTB < p2.diemTB) return -1;
                    return 1;
                }
                );
            // xuất sắp xếp 
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Diem trung binh tu thap den cao la: ");
            foreach (HocSinh hs in hocSinhs)
            {
                Console.WriteLine(hs.HoTen + "-" + hs.diemTB);
            }
            Console.WriteLine("-----------------------------");
            //Nhập thêm 1 học sinh
                for(int i = 0; i < 1;i++)
                {
                    // Nhập bổ sung học sinh     
                    HocSinh hs= new HocSinh();
                    Console.WriteLine("Nhap thong tin hoc sinh: ");
                    hs= hs.NhapTT();
                    hocSinhs.Add(hs);
                }
                // xuất học sinh bổ sung 
                Console.WriteLine("Danh sach hoc sinh sau khi cap nhat la:");
                foreach(HocSinh hs in hocSinhs)
                {
                    hs.XuatTT();
                }
                //Chinh sua diem phuc khao cho hoc sinh.
            List<HocSinh> phuckhao = new List<HocSinh>();
            phuckhao = hocSinhs;
            Console.WriteLine("-------------------");
            Console.Write("Nhap thu tu hoc sinh ban muon phuc khao: ");
            int a = int.Parse(Console.ReadLine()) - 1;
            //Chinh sua lai diem cho hoc sinh
            HocSinh hocSinh = phuckhao[a];
            Console.Write("Nhap diem Toan sau khi phuc khao: ");
            hocSinh.diemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Van sau khi phuc khao: ");
            hocSinh.diemVan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Anh Van sau khi phuc khao: ");
            hocSinh.diemAV = float.Parse(Console.ReadLine());
            hocSinh.diemTB = (hocSinh.diemToan + hocSinh.diemVan + hocSinh.diemAV) / 3;
            Console.WriteLine("--------------------");
            Console.WriteLine("Thong tin hoc sinh sau khi phuc khao la: ");
            hocSinh.XuatTT();
        }
    }
}
