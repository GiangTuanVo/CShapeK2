using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance.Abstract
{
    class LibNano
    {
        public static OprationResult Connect(string comName, int baudRate, out SerialPort sport)
        {
            OprationResult result = new OprationResult();
            SerialPort port = null;
            if (CheckCom(comName))
            {
                port = new SerialPort(comName, baudRate);
                port.Open();
                if (port.IsOpen)
                {
                    result.IsSuccess = true;
                    result.ErrorCode = 0;
                    result.Message = "Successful!";
                }
                else
                {
                    result.IsSuccess = false;
                    result.ErrorCode = -1;
                    result.Message = "Fail!";
                }
            }
            sport = port;
            return result;
        }
        private static bool CheckCom(string comName)
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
