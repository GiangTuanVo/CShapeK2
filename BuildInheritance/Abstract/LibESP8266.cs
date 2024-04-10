using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance.Abstract
{
    public class LibESP8266
    {
        public static OprationResult Connect(string comName, int baudRate, out SerialPort sport)
        {
            OprationResult result = new OprationResult();
            sport = null;
            return result;
        }
        private bool CheckCom(string comName)
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
    }
}
