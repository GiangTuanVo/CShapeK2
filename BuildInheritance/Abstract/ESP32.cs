using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance.Abstract
{
    class ESP32 : RS232Base
    {
        public ESP32(string comName, int baudRate, DeviceType type) : base(comName, baudRate, type)
        {
        }
    }
}
