using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace BuildClass
{

    class XeHoi
    {
        public static string LoaiXe;
        public static string MauSon;
        public static int SoCho;

        public static void Input(string loaixe, string mauson, int soCho)
        {
            LoaiXe = loaixe;
            MauSon = mauson;
            SoCho = soCho;
        }
    }
    class Fruit
    {
        //private string Name { get; set; } = "Tao";
        //private string Color { get; set; } = "Do";

        //Contructor
        public Fruit(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public Fruit(string name)
        {
            Name = name;
        }

        public Fruit()
        {
        }

        //public string Name;
        //public string Color;



        private string name;
        private string color;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                //if()
                name = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public void InputProduct()
        {

        }
        public void InputProduct(string Color)
        {

        }
        public void InputProduct(string Name, string Color)
        {
            this.Color = Color;
            this.Name = Name;
            if (!Check())
            {
                MessageBox.Show("Nhap sai");
            }
        }
        private bool Check()
        {
            if (Name == "Heo")
                return false;
            else
                return true;
        }
        public void Show()
        {

        }

        public override string ToString()
        {
            return $"{Name},{Color}";
        }
    }


    class Program
    {
        private static int Sum(params int[] arr)
        {
            int s = 0;
            foreach (int x in arr)
            {
                s += x;
            }
            return s;
        }
        static void NVTV()
        {
            NVThoiVu abc = new NVThoiVu();
            abc.Ten = "Vo Van A;";
            abc.MaNV = 123;
            Console.WriteLine($"Luong cua A {abc.Ten},{abc.MaNV}");
            abc.TinhLuong();
        }
        static void NVCT()
        {
            NVChinhThuc abc = new NVChinhThuc();
            abc.Ten = "Vo Van A;";
            abc.MaNV = 123;
            Console.WriteLine($"Luong cua A {abc.Ten},{abc.MaNV}");
            abc.TinhLuong();
        }
        static void test()
        {
            NhanVien nVChinh = new NhanVien();
            Console.WriteLine(nVChinh.TinhLuong(20));
        }
        static void test2()
        {
            NVChinhThuc nVChinh = new NVChinhThuc();
            Console.WriteLine(nVChinh.TinhLuong(10));
        }
        static void test3()
        {
            NhanVien nVChinh = new NVChinhThuc();
            Console.WriteLine(nVChinh.TinhLuong(20));
        }
        static void Main(string[] args)
        {
            Thread thr1 = new Thread(Funtion1);
            Thread thr2 = new Thread(Funtion2);
            thr1.Start();
            thr2.Start();

            //test2();
            //NVCT();
            //NVTV();

            //ComPort Adruino = new ComPort();
            //Adruino.ComName = "COM6";
            //Adruino.BaudRate = 9600;


            //ComPort Adruino = new ComPort("COM6", 9600);
            //bool isConnect = Adruino.Connect();
            //if (isConnect == true)
            //{
            //    //Console.WriteLine("Connect OK");
            //    Adruino.WitePort("Hello");
            //    Console.WriteLine(Adruino.Read());
            //    Adruino.WitePort("Welcome");
            //    Console.WriteLine(Adruino.Read());
            //}
            //else
            //{
            //    Console.WriteLine("Connect Fail");
            //}    

            //Console.OutputEncoding = Encoding.UTF8;

            //Fruit Cam = new Fruit();
            //Fruit Chanh = new Fruit();
            //Cam = Chanh;

            ////Fruit Cam = new Fruit("Heo","Vang");
            //Cam.InputProduct("Heo", "Xanh");

            //Console.WriteLine(Cam.ToString());

            //XeHoi.Input("HonDa", "Do", 4);

            //Console.WriteLine(Sum(12, 1, 2, 3,3));
            //Console.WriteLine(Sum());

            Console.ReadLine();
        }

        private static void Funtion2()
        {

            ComPort Adruino = new ComPort("COM6", 9600);
            bool isConnect = Adruino.Connect();
            while (true)
            {
                if (isConnect == true)
                {
                    //Console.WriteLine("Connect OK");
                    Adruino.WitePort("Hello");
                    Console.WriteLine(Adruino.Read());
                    Adruino.WitePort("Welcome");
                    Console.WriteLine(Adruino.Read());
                }
            }

        }

        private static void Funtion1()
        {
            while (true)
            {

            }
        }
    }
}
