using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance.Abstract
{
    //NHận diện giao tiếp cổng com
    public abstract class DeviceBase
    {
        protected string ComName { get; set; }
        protected int BaudRate { get; set; }

        protected DeviceType Type;

        protected DeviceBase(string comName, int baudRate, DeviceType type)
        {
            ComName = comName;
            BaudRate = baudRate;
            Type = type;
        }
        public abstract OprationResult Connect();
        public abstract OprationResult DisConnect();
        public abstract OprationResult Write(string text);
        public abstract OprationResult Read();
    }
}
