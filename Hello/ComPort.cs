using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace BuildClass
{
    public class ComPort
    {

        //Thuộc tính là đặc điểm của đối tương
        //Phương thức là hành vi của đối tượng
        //Các đối tượng có đặc điểm về thuộc tính và phương thức giống nhau được gom thành một lớp
        //Lớp là một khái niệm trừu tượng dùng để chỉ một tập hợp các đối tượng có mặt trong hệ thống.
        //Vậy thì - Thuộc tính tương với các thuộc tính của đối tượng
        //        - Phương thức tương ứng với các hành động của đối tượng
        private SerialPort Serial;

        private string comName;
        private int baudRate;
        public string ComName { get => comName; set => comName = value; }
        public int BaudRate { get => baudRate; set => baudRate = value; }

        public ComPort(string comName, int baudRate)
        {
            this.comName = comName;
            this.baudRate = baudRate;
        }

        public ComPort()
        {
        }
        ~ComPort()
        {

        }
        private bool CheckComName(string comName)
        {
            bool isCom = false;
            string[] listCom = SerialPort.GetPortNames();
            foreach (var item in listCom)
            {
                if (comName == item)
                {
                    isCom = true;
                    break;
                }
            }
            return isCom;
        }

        public bool Connect()
        {
            if (CheckComName(comName))
            {
                try
                {
                    Serial = new SerialPort(comName, baudRate, Parity.None, 8, StopBits.One);
                    Serial.Open();
                    if (Serial.IsOpen)
                    {
                        return true;
                    }
                    else return false;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
                return false;

        }

        public string Read()
        {
            string text = "";
            do
            {
                Thread.Sleep(100);
                text = Serial.ReadExisting();
            } while (!text.EndsWith("\n"));
            return text;
        }
        public void Send(string text)
        {
            Serial.Write(text);
        }
    }
}
