using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace BuildInheritance.Adruino
{
    interface IConnect
    {
        SerialPort Connection();
        void Write(SerialPort serial, string text);
        string Read(SerialPort serial);
    }
}
