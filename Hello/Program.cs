using System;
using Test;
using static System.Console;
namespace XinChao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string txt1 = "A";
            string txt2 = "B";
            if (txt1 == "A" & txt2 != "B")
            {
                string _speed = "1347357";//chuỗi

            }
            //const float PI = 3.14f;
            var kieutruefale = true;

            var speed = "1347357";//chuỗi
            //var dateTime = DateTime.Now;
            //float k = 1.0f / 2;//0.5
            float i = (float)1 / 2; //0.5,0
            //WriteLine(speed.GetType());
            WriteLine($"MAX: {float.MaxValue}, MIN: {float.MinValue}");
            double Speed = Convert.ToDouble(kieutruefale);
            //var Speed = int.Parse(k);

            bool retrun = int.TryParse(speed,out int value);
            if (retrun == true)
            {
                // Ghi 
            }
            else
            {
                //Canh báo
            }
            ReadKey();

            //int age=0;
            //string ten_sinhvien_k1="";
            //string ten_sinhvien_k2="";
            //string ten_nhanvien_vanphong="";
            //string ten_nhanvien_kythuat="";

            //char kytu;
            //string kieuchu = "Buoi dau tien";
            //string chu;
            //int numer = 123
            //double sothuc = 1.2;//4 byte
            //float sothuc2 = 1.2f;//2 byte
            //long kieudai;
            ////
            //age = 1;
            //WriteLine(kieuchu);
            //WriteLine(numer);
            //WriteLine(sothuc);
            //WriteLine(sothuc2);
            ReadKey();
        }
    }
}
