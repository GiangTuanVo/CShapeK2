using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Threading;

namespace BuildClass
{
    //Lớp là một khái niệm trừu tượng dùng để chỉ một tập hợp các đối tượng có mặt trong hệ thống.
    //Các đối tượng có đặc điểm về thuộc tính và phương thức giống nhau được gom thành một lớp
    //Thuộc tính là đặc điểm của đối tương
    //Phương thức là hành vi của đối tượng
    //Vậy thì - Thuộc tính tương với các thuộc tính của đối tượng
    //        - Phương thức tương ứng với các hành động của đối tượng
    public class ComPort
    {
        // Thuộc
        private SerialPort Port;
        private string comName;
        private int baudRate;
        public string ComName { get => comName; set => comName = value; }
        public int BaudRate { get => baudRate; set => baudRate = value; }
        public ComPort()
        {
        }

        public ComPort(string comName, int baudRate)
        {
            this.comName = comName;
            this.baudRate = baudRate;
        }

        private bool CheckCom()
        {
            bool ischeck = false;
            string[] com = SerialPort.GetPortNames();
            foreach (var item in com)
            {
                if (comName == item)
                {
                    ischeck = true;
                    break;
                }
            }
            return ischeck;
        }

        public bool Connect()
        {
            bool ischeck = false;
            if (CheckCom())
            {
                Port = new SerialPort(comName, baudRate, Parity.None, 8, StopBits.One);
                Port.Open();
                if (Port.IsOpen)
                {
                    ischeck = true;
                }
            }
            return ischeck;
        }

        public void WitePort(byte[] byteArr)
        {

        }
        public void WitePort(string text)
        {
            if (Port.IsOpen)
                Port.Write(text);
        }

        public string Read()
        {
            string text = "";
            lock (this)
            {
                do
                { 
                    Thread.Sleep(100);
                    if (Port.IsOpen)
                        text = Port.ReadExisting();

                } while (!text.EndsWith("\r\n"));
            }

            return text;
        }

        public override string ToString()
        {
            return $"{comName},{baudRate}";
        }
    }
}
