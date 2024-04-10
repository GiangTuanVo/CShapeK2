using BuildInheritance.Adruino;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance
{
    //Overriding Methods
    class HinhHoc
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public virtual int TinhChuVi()
        {
            return Width * Length;
        }
    }
    class HinhTron : HinhHoc
    {
        public override int TinhChuVi()
        {
            return Width / Length;
        }
    }


    //Tính đa hình
    class HinhChuNhat
    {
        //Poco
        public double ChieuRong { get; set; }
        public double ChieuDai { get; set; }

        //Khai báo ban đầu
        public HinhChuNhat(double chieuRong, double chieuDai)
        {
            ChieuRong = chieuRong;
            ChieuDai = chieuDai;
        }

        //Ccontructor mặt định
        //public HinhChuNhat()
        //{
        //}

        public virtual double TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }
        public virtual double TinhChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }
    }
    class HinhVuong : HinhChuNhat
    {
        public HinhVuong(double a) : base(a, a)
        {

        }
        public override double TinhChuVi()
        {
            return base.TinhChuVi();
        }
        public override double TinhDienTich()
        {
            return base.TinhDienTich();
        }
    }






    //interface : Tính đa hình
    interface ILamViec
    {
        string LamViec(string tenViec);
    }
    public class Nhanvien : ILamViec
    {
        public string LamViec(string tenViec)
        {
            return $"{tenViec} -> Kiem Tien";
        }
    }
    public class SinhVien : ILamViec
    {
        public string LamViec(string tenViec)
        {
            return $"{tenViec} -> Tieu Tien";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abstract.Nano nano = new Abstract.Nano("COM11", 9600, Abstract.DeviceType.NANO);
            Abstract.OprationResult result = nano.Connect();
            if (result.IsSuccess)
            {
                Console.WriteLine(result.Message);
            }
            //HinhChuNhat hcn = new HinhChuNhat(13.2,33.5);
            //Console.WriteLine(hcn.TinhChuVi());
            //Console.WriteLine(hcn.TinhDienTich());

            //HinhChuNhat hinhChu = new HinhVuong(12.3);
            //Console.WriteLine(hinhChu.TinhChuVi());
            //Console.WriteLine(hinhChu.TinhDienTich());

            //HinhVuong hv = new HinhVuong(2.5);
            //Console.WriteLine(hv.TinhChuVi());
            //Console.WriteLine(hv.TinhDienTich());

            //IConnect device = new Nano("COM11", 9600); 
            //SerialPort sPort = device.Connection();
            //device.Write(sPort, "Hello");
            //Console.WriteLine(device.Read(sPort));

            //IConnect device = new ESP8266("COM10", 19200);
            //SerialPort sPort = device.Connection();
            //device.Write(sPort, "Hello");
            //Console.WriteLine(device.Read(sPort));

            //IConnect device = new ESP8266("COM10", 19200);
            //SerialPort sPort = device.Connection();
            //device.Write(sPort, "Hello");
            //Console.WriteLine(device.Read(sPort));

            //Console.OutputEncoding = Encoding.UTF8;

            //Nhanvien nv = new Nhanvien();
            //SinhVien sv = new SinhVien();
            //ILamViec lv = nv;
            //Console.WriteLine(lv.LamViec("Đi làm để"));
            //lv = sv;
            //Console.WriteLine(lv.LamViec("Đi học"));
            Console.ReadLine();
        }
    }
}
