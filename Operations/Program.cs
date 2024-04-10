using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Operations
{
    class Program
    {
        /// <summary>
        /// Day la phep tinh cong
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Mul(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="result"></param>
        static void Mul(double a, double b, ref double result)
        {
            result = a * b;
        }

        static void Mul1(double a, double b, out double result)
        {
            result = a * b;
        }

        static int Tinh_Giai_Thua(int n)
        {
            int giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            return giaiThua;
        }


        static void KhaiBao()
        {

        }


        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 4, 5, 6, 7 };
            list.RemoveRange(0, 2);
            list.Remove(1);
            list.RemoveAt(3);
            for (int q = 0; q < list.Count; q++)
            {
                Console.WriteLine(list[q]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


            List<SinhVien> sv = new List<SinhVien>();

            SinhVien sv1 = new SinhVien();
            sv1.Name = "Vo van A";
            sv1.Age = 10;
            sv1.BirthDay = "05 / 04 / 2021";

            SinhVien sv2 = new SinhVien();
            sv2.Name = "Vo van B";
            sv2.Age = 43;
            sv2.BirthDay = "05 / 04 / 2561";

            sv.Add(sv1);
            sv.Add(sv2);
            foreach (var item in sv)
            {
                Console.WriteLine($"{item.Name}, {item.Age}, {item.BirthDay}");
            }

            Console.ReadKey();
            int count = sv.Count();
            sv.Clear();

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "ABC");
            dic.Add(2, "DCF");




            int[,] arrl = new int[2, 3];

            int[] arr = new int[] { 1, 2, 3, 4, 6, 4, 5 };
            int[] arr2 = arr;

            int index1 = 0;

            for (int j = 0; j < arr.Length; j++)
            {
                //Console.WriteLine(arr[j]);
                if (arr[j] == 6)
                {
                    Console.WriteLine(j);
                    break;
                }

            }

            Console.ReadKey();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
                if (index1 == 3) break;
                ++index1;
            }
            Console.ReadKey();
            arr[0] = 5;

            string s = DateTime.Now.ToString("dd/MM/yyyy");
            int num1 = 12;
            string hex = num1.ToString("X4");

            string link = "Hello\r\n";
            string sub = link.Substring(2);

            string sub2 = link.Substring(1, 3);

            string padl = link.PadLeft(10);

            padl = padl.Trim();

            int index = link.IndexOf('l');
            int lindex = link.LastIndexOf('l');

            //string padl = link.PadLeft(10);
            string padl2 = link.PadLeft(10, '@');

            char[] cha = new char[5];
            cha[0] = 'Q';
            cha[1] = 'G';
            link.CopyTo(1, cha, 1, 2);




            link = "VO VAN TOAN";
            string[] spl = link.Split(' ');

            link = string.Join("_", spl);


            foreach (var item in spl)
            {
                Console.WriteLine(item);
            }

            if (link.Contains("H"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            char ch = link[0];

            for (int k = 0; k < link.Length; k++)
            {
                Console.WriteLine(link[k]);

            }
            Console.ReadKey();



            char kytu1 = 'A';
            char kytu2 = 'B';
            Console.WriteLine(kytu1.CompareTo(kytu2)); //=0,>1,<-1
            Console.WriteLine(Char.ToLower(kytu1));
            Console.ReadKey();

            Char.ToLower(kytu1);

            try
            {
                Console.WriteLine(int.Parse("1.2"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            //label01:
            //Random rand = new Random();
            //int a = rand.Next(0, 100);
            //Console.WriteLine(a);
            //Thread.Sleep(100);
            //goto label01;
            DateTime time = new DateTime();
            int year = time.Year;

            Console.WriteLine(Math.PI);
            Console.ReadKey();
            string lblName = "";

            double result1 = 0;

            Mul(2.3, 4.5, ref result1);

            double result2 = Mul(2.3, 4.5);



            int so1 = Add(1, 2);
            int so2 = Add(3, 4);
            int giaithua = Tinh_Giai_Thua(5);
            //Tinh toan tuoi
            /*
             * Add(1, 2);
             */
            int y = 2;

            //if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            //    Console.WriteLine("y la năm nhuận");
            //else
            //    Console.WriteLine("y không là năm nhuận");


            //if (y>0)
            //{
            //    Console.WriteLine("So khong am");
            //}
            //else if(y==0)
            //{
            //    Console.WriteLine("So khong");
            //}
            //else if (y<0)
            //{
            //    Console.WriteLine("So am");
            //}
            //else
            //{
            //    Console.WriteLine("So am");
            //}
            //Console.ReadKey();

            //switch (y)
            //{
            //    case 1:
            //        Console.WriteLine("So mot");
            //        //Code here
            //        break;
            //    case 2:
            //        Console.WriteLine("So hai");
            //        //
            //        break;
            //    default:
            //        break;
            //}
            //Console.ReadKey();
            /*
                    label01:
                        Console.WriteLine("Nhap so");
                        //Toan tu gán
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("num /= 5");
                        Console.WriteLine($"So nhap vao la : {num}");
                        //num += 5;//num = num + 5;
                        //num -= 5;//num=num-5;
                        //num *= 5;
                        num /= 5;
                        Console.WriteLine($"Ket qua : {num}");
                        goto label01;

                        double num1 = Convert.ToDouble(Console.ReadLine());
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"num1 % num2 = {num1 % num2}");
                        int num = 5;
                        Console.WriteLine(num++);
                        Console.WriteLine(num);
                        int a = 5, b = 8;
                        int c = ++a - b++ - 5;
                        //6-8-5
                        Console.WriteLine(c);
                    label01:
                        Console.WriteLine(" Nhap so thu nhat :");
                        int st1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" Nhap so thu hai :");
                        int st2 = Convert.ToInt32(Console.ReadLine());


                        string a = st1 > 0 || st2 > 0 ? "Co khong am" : "So am";
                        Console.WriteLine("a");

                        Console.WriteLine(st1 > 0 || st2 > 0 ? "Co khong am" : "So am");

                        if (st1 > 0 || st2 > 0)
                        {
                            Console.WriteLine("Co khong am");
                        }
                        else
                        {
                            Console.WriteLine("So am");
                        }

                        goto label01;

            */

            //do_While
            int i = 0;
            //do
            //{
            //    //code
            //    ++i;
            //    Console.WriteLine(i);
            //    Thread.Sleep(50);
            //} while (i < 20);

            //while(i < 20)
            //{
            //    //    //code
            //    ++i;
            //    Console.WriteLine(i);
            //    Thread.Sleep(50);
            //}

            //for (int j = 0; j <= 20; j++)
            //{
            //    Console.WriteLine(j);
            //    Thread.Sleep(50);
            //}

            int[] num = { 34, 454, 2242, 656, 57547 };
            for (int k = 0; k < num.Length; k++)
            {
                Console.WriteLine(num[k]);
            }

            //foreach (var item in num)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
    }
}
