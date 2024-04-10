using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance.Abstract
{
    public class Nano : RS232Base
    {
        public Nano(string comName, int baudRate, DeviceType type) : base(comName, baudRate, type)
        {
        }
    }
}
