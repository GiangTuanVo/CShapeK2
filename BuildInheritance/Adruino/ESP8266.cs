using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuildInheritance.Adruino
{
    class ESP8266 : IConnect
    {
        public string comName { get; set; } = "COM10";
        public int baudRate { get; set; }
        public ESP8266(string comName, int baudRate)
        {
            this.comName = comName;
            this.baudRate = baudRate;
        }

        public SerialPort Connection()
        {
            SerialPort sPort = new SerialPort(comName, baudRate, Parity.None, 8, StopBits.One);
            sPort.Open();
            if (sPort.IsOpen) return sPort;
            else return null;
        }

        public string Read(SerialPort serial)
        {
            string text = "";
            do
            {
                Thread.Sleep(100);
                if (serial.IsOpen)
                    text = serial.ReadExisting();

            } while (!text.EndsWith("\r\n"));

            return text;
        }

        public void Write(SerialPort serial, string text)
        {
            if (serial.IsOpen)
            {
                serial.Write(text);
            }
        }
    }
}
