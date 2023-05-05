using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static quanlihocsinhh.Program;

namespace quanlihocsinhh
{
    internal class Program
    {

        public class HocSinh
        {
            public string hoTen; 
            public string gioiTinh;
            public float diemToan;
            public float diemVan;
            public float diemAV;
            public double diemTB;
        }

        public void NhapThongTinMotHocSinh(HocSinh hocsinh)
        {
            Console.Write("Nhap ho va ten hoc sinh: ");
            hocsinh.hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            hocsinh.gioiTinh = Console.ReadLine();
            Console.Write("Nhap diem toan = ");
            hocsinh.diemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem van =  ");
            hocsinh.diemVan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem anh van = ");
            hocsinh.diemAV = float.Parse(Console.ReadLine());
            hocsinh.diemTB = (double)((hocsinh.diemToan + hocsinh.diemVan + hocsinh.diemAV) / 3);
        }
        public void XuatThongTinMotHocSinh(HocSinh hocsinh)
        {
            Console.WriteLine("Ho va ten hoc sinh la: " + hocsinh.hoTen);
            Console.WriteLine("Gioi tinh:" + hocsinh.gioiTinh);
            Console.WriteLine("Diem toan = " + hocsinh.diemToan);
            Console.WriteLine("Diem van = " + hocsinh.diemVan);
            Console.WriteLine("Diem anh van = " + hocsinh.diemAV);
            Console.WriteLine("Diem trung binh =  " + hocsinh.diemTB);
        }

        public void NhapDanhSachThongTinHocSinh(List<HocSinh> hocSinhs, int n)
        {

            for (int i = 0; i < n; i++)
            {
                HocSinh hs = new HocSinh();
                Console.WriteLine("Nhap thong tin hoc sinh thu " + (i + 1) + " : ");
                NhapThongTinMotHocSinh(hs);
                hocSinhs.Add(hs);

            }
        }
        public void XuatDanhSachThongTinHocSinh(List<HocSinh> hocSinhs)
        {
            HocSinh hs = new HocSinh();
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                XuatThongTinMotHocSinh(hocSinhs[i]);
            }
        }

        public void XemDanhSach(List<HocSinh> hocSinhs)
        {
            XuatDanhSachThongTinHocSinh(hocSinhs);
            bool kiemTra = true;
            Console.WriteLine("----------------------------");
            while (kiemTra)
            {
                Console.WriteLine("Cac chuc nang.");
                Console.WriteLine("0. Thoat khoi chuong trinh.");
                Console.WriteLine("1. Phan loai hoc sinh theo nam/nu.");
                Console.WriteLine("2. Sap xep hoc sinh theo diem/chu cai");
                Console.WriteLine("3. Chinh sua thong tin hoc sinh.");
                Console.WriteLine("4. Xoa mot hoc sinh khoi danh sach.");
                Console.Write("Nhap vao chuc nang ban muon: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        PhanLoaiHocSinh(hocSinhs);
                        break;
                    case 2:
                        SapXepHocSinh(hocSinhs);
                        break;
                    case 3:
                        SuaThongTinHocSinh(hocSinhs);
                        break;
                    case 4:
                        XoaHocSinh(hocSinhs);
                        break;
                    default:
                        kiemTra = false;
                        break;
                }
            }
        }

        public void PhanLoaiHocSinh(List<HocSinh> hocSinhs)
        {
            bool kiemTra = true;
            while(kiemTra)
            {
                Console.WriteLine("0. Thoat chuong trinh.");
                Console.WriteLine("1. Phan loai hoc sinh NAM.");
                Console.WriteLine("2. Phan loai hoc sinh NU");
                Console.WriteLine("----------------------------");
                Console.Write("Nhap lua chon cua ban: ");
                int n=int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------");
                switch (n)
                {
                    case 1:
                        PhanLoaiHocSinhNam(hocSinhs);
                        break;
                    case 2:
                        PhanLoaiHocSinhNu(hocSinhs);
                        break;
                    default:
                        kiemTra = false;
                        break;
                }
            }
        }
        public void PhanLoaiHocSinhNam(List<HocSinh> hocSinhs)
        {
            string gioitinh = hocSinhs[0].gioiTinh;
            string tenhs = hocSinhs[0].hoTen;
            Console.WriteLine("Danh sach hoc sinh NAM la.");
            for(int i = 0; i < hocSinhs.Count; i++)
            {
                if (hocSinhs[i].gioiTinh == "nam")
                {
                    gioitinh = hocSinhs[i].gioiTinh;
                    tenhs= hocSinhs[i].hoTen;
                    Console.WriteLine(tenhs+"-"+gioitinh);
                }
            }
        }
        public void PhanLoaiHocSinhNu(List<HocSinh> hocSinhs)
        {
            string gioitinh = hocSinhs[0].gioiTinh;
            string tenhs = hocSinhs[0].hoTen;
            Console.WriteLine("Danh sach hoc sinh NU la.");
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                if (hocSinhs[i].gioiTinh == "nu")
                {
                    gioitinh = hocSinhs[i].gioiTinh;
                    tenhs = hocSinhs[i].hoTen;
                    Console.WriteLine(tenhs + "-" + gioitinh);
                }
            }
        }


        public void SapXepHocSinh(List<HocSinh> hocSinhs)
        {
            bool kiemTra = true;
            while (kiemTra)
            {
                Console.WriteLine("0. Thoat khoi chuong trinh.");
                Console.WriteLine("1. Sap xep danh sach theo DIEM cao/thap. ");
                Console.WriteLine("2. Sap xep danh sach theo BANG CHU CAI. ");
                Console.WriteLine("------------------------------------------");
                Console.Write("Nhap lua chon cua ban: ");
                int n=int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        SapXepHocSinhTheoDiem(hocSinhs);
                        break;
                    case 2:
                        SapXepHocSinhTheoBCC(hocSinhs);
                        break;
                    default:
                        kiemTra = false;
                        break;

                }
            }
        }
        public void SapXepHocSinhTheoDiem(List<HocSinh> hocSinhs)
        {
            bool kiemTra = true;
            while (kiemTra)
            {
                Console.WriteLine("0. Thoat khoi chuong trinh. ");
                Console.WriteLine("1. Sap xep diem tu CAO den THAP.");
                Console.WriteLine("2. Sap xep diem tu THAP den CAO.");
                Console.Write("Nhap lua chon cua ban: ");
                int n = int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        SapXepDSHocSinhTheoDiemTuCaoDenThap(hocSinhs);
                        break;
                    case 2:
                        SapXepDSHocSinhTheoDiemTuThapDenCao(hocSinhs);
                        break;
                }
            }
        }
        public void SapXepDSHocSinhTheoDiemTuCaoDenThap(List<HocSinh> hocSinhs)
        {
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                for (int j = i + 1; j < hocSinhs.Count; j++)
                {
                    if (hocSinhs[j].diemTB > hocSinhs[i].diemTB)
                    {
                        HocSinh temp = hocSinhs[j];
                       hocSinhs[j] = hocSinhs[i];
                        hocSinhs[i] = temp;
                    }
                }
            }
            Console.WriteLine("------------------------------");
            XuatDanhSachThongTinHocSinh(hocSinhs);
        }
        public void SapXepDSHocSinhTheoDiemTuThapDenCao(List<HocSinh> hocSinhs)
        {
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                for (int j = i + 1; j < hocSinhs.Count; j++)
                {
                    if (hocSinhs[j].diemTB < hocSinhs[i].diemTB)
                    {
                        HocSinh temp = hocSinhs[j];
                        hocSinhs[j] = hocSinhs[i];
                        hocSinhs[i] = temp;
                    }
                }
            }
            Console.WriteLine("------------------------------");
            XuatDanhSachThongTinHocSinh(hocSinhs);
        }
        public void SapXepHocSinhTheoBCC(List<HocSinh> hocSinhs)
        {
            hocSinhs.Sort(
                (p1, p2) =>
                p1.hoTen.CompareTo(p2.hoTen));

            XuatDanhSachThongTinHocSinh(hocSinhs);
        }


        public void SuaThongTinHocSinh(List<HocSinh> hocSinhs)
        {
            
            XuatDanhSachThongTinHocSinh(hocSinhs) ;
            Console.Write("Nhap so thu tu hoc sinh ban can chinh sua: ");
            int a = int.Parse(Console.ReadLine())-1;
            HocSinh hs = hocSinhs[a];
            Console.WriteLine("-----------------------");
            Console.WriteLine("Hoc sinh ban chon la:");
            XuatThongTinMotHocSinh(hs);
            bool kiemTra= true;
            while (kiemTra)
            {
                Console.WriteLine("0. Neu ban muon thoat chuong trinh.");
                Console.WriteLine("Ban muon chinh sua: ");
                Console.WriteLine("1.Ho va ten hoc sinh.");
                Console.WriteLine("2. Diem mon TOAN. ");
                Console.WriteLine("3. Diem mon VAN");
                Console.WriteLine("4. Diem mon ANH VAN.");
                Console.Write("Lua chon cua ban la: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        ChinhSuaHoVaTenHocSinh(hs);
                        break;
                    case 2:
                        ChinhSuaDiemToanHocSinh(hs);
                        break;
                    case 3:
                        ChinhSuaDiemVanHocSinh(hs);
                        break;
                    case 4:
                        ChinhSuaDiemAnhVanHocSinh(hs);
                        break;
                    default:
                        kiemTra = false;
                        break;
                }
            }
        }
        public void ChinhSuaHoVaTenHocSinh(HocSinh hs)
        {
            Console.WriteLine("Nhap lai ho va ten : ");
            hs.hoTen = Console.ReadLine();
            XuatThongTinMotHocSinh(hs);
        }
        public void ChinhSuaDiemToanHocSinh(HocSinh hs)
        {
            Console.WriteLine("Nhap lai diem toan = ");
            hs.diemToan=float.Parse(Console.ReadLine());
         
        }
        public void ChinhSuaDiemVanHocSinh(HocSinh hs)
        {
            Console.WriteLine("Nhap lai diem van = ");
            hs.diemVan = float.Parse(Console.ReadLine());
         
        }
        public void ChinhSuaDiemAnhVanHocSinh(HocSinh hs)
        {
            Console.WriteLine("Nhap lai diem anh van = ");
            hs.diemAV = float.Parse(Console.ReadLine());
          
        }

        public void XoaHocSinh(List<HocSinh> hocSinhs)
        {
            Console.Write("Nhap so thu tu hoc sinh ban muon xoa: ");
            int n = int.Parse(Console.ReadLine()) - 1;
            hocSinhs.RemoveAt(n);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Danh sach cap nhat lai la: ");
            XuatDanhSachThongTinHocSinh(hocSinhs);
        }

        public void TimKiem(List<HocSinh> hocSinhs)
        {
            Console.Write("Nhap ho va ten hoc sinh ban muon tim: ");
            string timkiem = Console.ReadLine();
            bool kiemTra = false;
            HocSinh hs = new HocSinh();
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                if (hocSinhs[i].hoTen.Contains(timkiem))
                {
                    kiemTra = true;
                    hs = hocSinhs[i];
                    break;
                }
            }
            if (kiemTra == false)
            {
                Console.WriteLine("Hoc sinh ban tim khong co trong danh sach.");
            }
            else
            {
                Console.WriteLine("Da tim thay hoc sinh.");
               XuatThongTinMotHocSinh(hs);

                bool kt = true;
                while (kt)
                {
                    Console.WriteLine("0. Thoat ra khoi chuong trinh.");
                    Console.WriteLine("1. Chinh sua thong tin hoc sinh.");
                    Console.WriteLine("2. Xoa hoc sinh ra khoi danh sach");
                    Console.Write("Lua chon cua ban la: ");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            SuaThongTinHSTrongTimKiem(hs);
                            break;
                        case 2:
                            XoaMotHocSinhTrongTimKiem(hocSinhs, hs);
                            break;
                        default:
                            kt = false;
                            break;
                    }
                }
            }

        }
        public void SuaThongTinHSTrongTimKiem(HocSinh hs)
        {
            bool kiemTra = true;
            while (kiemTra)
            {
                Console.WriteLine("0. Neu ban muon thoat chuong trinh.");
                Console.WriteLine("Ban muon chinh sua: ");
                Console.WriteLine("1.Ho va ten hoc sinh.");
                Console.WriteLine("2. Diem mon TOAN. ");
                Console.WriteLine("3. Diem mon VAN");
                Console.WriteLine("4. Diem mon ANH VAN.");
                Console.Write("Lua chon cua ban la: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        ChinhSuaHoVaTenHocSinh(hs);
                        break;
                    case 2:
                        ChinhSuaDiemToanHocSinh(hs);
                        break;
                    case 3:
                        ChinhSuaDiemVanHocSinh(hs);
                        break;
                    case 4:
                        ChinhSuaDiemAnhVanHocSinh(hs);
                        break;
                    default:
                        kiemTra = false;
                        break;
                }
            }
        }
        public void XoaMotHocSinhTrongTimKiem(List<HocSinh> hocSinhs, HocSinh hs)
        {
            hocSinhs.Remove(hs);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Danh sach sau khi cap nhat la: ");
           XuatDanhSachThongTinHocSinh(hocSinhs);
        }

        public void ThemMotHocSinhMoi(List<HocSinh> hocSinhs)
        {
            HocSinh hocsinh=new HocSinh();
            Console.Write("Nhap ho va ten hoc sinh: ");
            hocsinh.hoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            hocsinh.gioiTinh = Console.ReadLine();
            Console.Write("Nhap diem toan = ");
            hocsinh.diemToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem van =  ");
            hocsinh.diemVan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem anh van = ");
            hocsinh.diemAV = float.Parse(Console.ReadLine());
            hocsinh.diemTB = (double)((hocsinh.diemToan + hocsinh.diemVan + hocsinh.diemAV) / 3);
        }

        public void ChonHocSinhThiHSG(List<HocSinh> hocSinhs)
        {
            bool kiemTra = true;
            while (kiemTra)
            {
                Console.WriteLine("0. Neu ban muon thoat chuong trinh.");
                Console.WriteLine("Ban muon chon hoc sinh thi hoc sinh gioi mon:");
                Console.WriteLine("1.Hoc Sinh gioi mon TOAN.");
                Console.WriteLine("2.Hoc Sinh gioi mon VAN.");
                Console.WriteLine("3.Hoc Sinh gioi mon ANH VAN.");
                Console.Write("Lua chon cua ban la: ");
                int n=int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        HocSinhGioiMonToan(hocSinhs);
                        break;
                    case 2:
                        HocSinhGioiMonVan(hocSinhs);
                        break;
                    case 3:
                        HocSinhGioiMonAnhVan(hocSinhs);
                        break;
                    default:
                        kiemTra= false;
                        break;
                }
            }
        }
        public void HocSinhGioiMonToan(List<HocSinh> hocSinhs)
        {
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                for (int j = i + 1; j < hocSinhs.Count; j++)
                {
                    if (hocSinhs[j].diemToan > hocSinhs[i].diemToan)
                    {
                        HocSinh temp = hocSinhs[j];
                        hocSinhs[j] = hocSinhs[i];
                        hocSinhs[i] = temp;
                    }
                }
            }
            XuatDanhSachThongTinHocSinh(hocSinhs);
        }
        public void HocSinhGioiMonVan(List<HocSinh> hocSinhs)
        {
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                for (int j = i + 1; j < hocSinhs.Count; j++)
                {
                    if (hocSinhs[j].diemVan > hocSinhs[i].diemVan)
                    {
                        HocSinh temp = hocSinhs[j];
                        hocSinhs[j] = hocSinhs[i];
                        hocSinhs[i] = temp;
                    }
                }
            }
            XuatDanhSachThongTinHocSinh(hocSinhs);
        }
        public void HocSinhGioiMonAnhVan(List<HocSinh> hocSinhs)
        {
            for (int i = 0; i < hocSinhs.Count; i++)
            {
                for (int j = i + 1; j < hocSinhs.Count; j++)
                {
                    if (hocSinhs[j].diemAV > hocSinhs[i].diemAV)
                    {
                        HocSinh temp = hocSinhs[j];
                        hocSinhs[j] = hocSinhs[i];
                        hocSinhs[i] = temp;
                    }
                }
            }
            XuatDanhSachThongTinHocSinh(hocSinhs);
        }



        static void Main(string[] args)
        {
            List<HocSinh> hocSinhs = new List<HocSinh>();
            Program program= new Program();
            Console.Write("Nhap so luong hoc sinh: ");
            int n = int.Parse(Console.ReadLine());
            program.NhapDanhSachThongTinHocSinh(hocSinhs,n);
            Console.WriteLine("Cac chuc nang cua chuong trinh: ");
            bool kiemTra = true;
            while (kiemTra == true)
            {
                Console.WriteLine("0. Thoat.");
                Console.WriteLine("1. Xem danh sach.");
                Console.WriteLine("2. Tim kiem.");
                Console.WriteLine("3. Them mot hoc sinh moi.");
                Console.WriteLine("4. Chon hoc sinh thi hoc sinh gioi.");
                Console.Write("Chuc nang ban muon chon la: ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------");
                switch (choice)
                {
                    case 1:
                        program.XemDanhSach(hocSinhs);
                        break;
                    case 2:
                        program.TimKiem(hocSinhs);
                        break;
                    case 3:
                        program.ThemMotHocSinhMoi(hocSinhs);
                        break;
                    case 4:
                        program.ChonHocSinhThiHSG(hocSinhs);
                        break;
                    default:
                        kiemTra = false;
                        break;
                }
            }
            
        }
    }
}
