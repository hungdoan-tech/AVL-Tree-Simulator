using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lớp_Sin_viên
{
   public class Sinhvien
    {
        private string sHoten;
        private string sMSSV;
        private double dDiemtoan;
        private double dDiemtin;
        private double dDiemTB;
        //các properties;
        public string HoTen
        {
            get { return this.sHoten; }
            set { this.sHoten = value; }
        }
        public string MSSV
        {
            get { return this.sMSSV; }
            set { this.sHoten = value; }
        }
        public double DiemToan
        {
            get { return this.dDiemtoan; }
            set {
                if (value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 and 10.");
                        this.dDiemtoan = value;
            }
        }
        public double DiemTin
        {
            get { return this.dDiemtin; }
            set {
                if (value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 10.");
                this.dDiemtin = value; }
        }
        public double DiemTB
        {
            get { return this.dDiemTB; }
        }
        // các constructors
        // không có tham số
        public Sinhvien()
        {
        }
        //có đủ tham số
        public Sinhvien(string hoten, string msSV, double diemtoan, double diemtin)
        {
            this.HoTen = HoTen;
            this.MSSV = msSV;
            this.DiemToan = DiemToan;
            this.DiemTin = DiemTin;
        }
        //có một tham số
        public Sinhvien(string hoTen, string msSV)
        {
            this.HoTen = hoTen;
            this.MSSV = msSV;
        }
        public Sinhvien(string hoTen)
        {
            this.HoTen = hoTen;
        }
        // hàm xóa Finalizer, destructors
        ~Sinhvien()
        {
        }
        // các method
        //hàm nhập
        public void nhap()
        {
            Console.WriteLine("nhap ho ten: ");
            this.HoTen = Console.ReadLine();
            Console.WriteLine("nhap mssv: ");
            this.MSSV = Console.ReadLine();
            Console.WriteLine("nhap diem toan: ");
            this.DiemToan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap diem tin:  ");
            this.DiemTin = Convert.ToDouble(Console.ReadLine());
        }
        //co mot phan tham so
        public void nhap(string hoTen, string msSV)
        {
            this.HoTen = hoTen;
            this.MSSV = msSV;
        }
        public void nhap(string hoTen)
        {
            this.HoTen = hoTen;
        }

        public void Xuat()
        { Console.WriteLine("Ho ten: " + this.sHoten);
            Console.WriteLine("MSSV: " + this.sMSSV);
            Console.WriteLine("Diem toan: " + this.dDiemtoan);
            Console.WriteLine("Diem tin: " + this.dDiemtin);
            Console.WriteLine("Diem trung binh: " + this.dDiemTB);
        }

        //Hàm tính toán        
        public void TinhDiemTrungBinh()
        {
            this.dDiemTB = (this.dDiemtoan + this.dDiemtin) / 2;
        }
    }
    public class Lop
    {
        //fields
        private string sTenLop;
        private List<Sinhvien> lDSSV;

        //properties
        public string TenLop
        {
            get { return this.sTenLop; }
            set { this.sTenLop = value; }
        }
        public List<Sinhvien> DSSV
        {
            get { return this.lDSSV; }
            set { this.lDSSV = value; }
        }
        //Constructors
        public Lop()
        {
            this.lDSSV = new List<Sinhvien>();//bắc buộc phải có
        }
        public Lop(string tenLop, List<Sinhvien> dsSV)
        {
            this.sTenLop = tenLop;
            this.lDSSV = dsSV;
        }
        //Method
        public void Nhap()
        {
            Console.WriteLine("Nhap ten lop:");
            this.sTenLop = Console.ReadLine();
            int soSV = 0;
            Console.WriteLine("Nhap so sinh vien cua lop:");
            soSV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap thong tin sinh vien sinh vien :");
            for (int i = 0; i < soSV; i++)
            {
                Sinhvien sv = new Sinhvien();
                sv.nhap();
                this.lDSSV.Add(sv);
            }
        }
        public void Nhap(string tenLop, List<Sinhvien> dsSV)
        {
            this.sTenLop = tenLop;
            this.lDSSV = dsSV;
        }
        public void TinhDiemTrungBinhSV()
        {
            for (int i = 0; i < this.lDSSV.Count; i++)
            {
                this.lDSSV[i].TinhDiemTrungBinh();
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Ten lop: " + this.sTenLop);
            Console.WriteLine("Danh sách sinh viên :");
            for (int i = 0; i < this.lDSSV.Count; i++)
            {
                this.lDSSV[i].Xuat();
            }
        }
    }
}
}



        static void Main(string[] args)
        {

        }
    }
}
