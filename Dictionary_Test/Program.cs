using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dictionary_Test
{
    class Program
    {
        //Bag
        //Mat :
        private static Queue<int> buffer = new Queue<int>(2);//2 image 

        private static bool IsThread = true;
        private static Random random = new Random();
        private static Thread GetValue;
        private static Thread ShowValue;
        static void Main(string[] args)
        {
            GetValue = new Thread(GetRandom);
            ShowValue = new Thread(Show);
            GetValue.Start();
            ShowValue.Start();
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "ABC");
            //dic.Add(2, "ABD");
            //dic.Add(3, "DFHDS");
            //Console.WriteLine(dic.Count());
            //foreach (KeyValuePair<int,string> item in dic)
            //{
            //    Console.WriteLine($"{item.Key}, {item.Value}");
            //}
            //dic.Remove(1);
            ////Console.WriteLine($"Get value: {dic[1]}");

            //Console.ReadKey();
        }

        private static void Show()
        {
            while (true)
            {
                if (buffer.Count > 0)
                    Console.WriteLine(buffer.Dequeue());
                //dk thoat
            }
            IsThread = false;
        }

        private static void GetRandom()
        {
            // read image 
            if (buffer.Count == 0) buffer.Enqueue(random.Next(1, 100));
            while (IsThread)
            {
                if (buffer.Count > 1) Thread.Sleep(100);
                else buffer.Enqueue(random.Next(1, 100));
            }
        }
    }
}
