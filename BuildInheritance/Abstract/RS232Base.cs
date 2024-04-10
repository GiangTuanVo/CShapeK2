using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInheritance.Abstract
{
    public class RS232Base : DeviceBase
    {
        private SerialPort sPort;

        public RS232Base(string comName, int baudRate, DeviceType type) : base(comName, baudRate, type)
        {
        }

        public override OprationResult Connect()
        {
            OprationResult result = new OprationResult();
            switch (base.Type)
            {
                case DeviceType.NANO:
                    result = LibNano.Connect(base.ComName, base.BaudRate, out sPort);
                    break;
                case DeviceType.ESP8266:
                    LibESP8266.Connect(base.ComName, base.BaudRate, out sPort);
                    break;
                case DeviceType.ESP32:
                    break;
                default:
                    break;
            }
            return result;
        }

        public override OprationResult DisConnect()
        {
            OprationResult result = new OprationResult();
            try
            {
                if (sPort.IsOpen)
                {
                    sPort.Close();
                    result.ErrorCode = 0;
                    result.IsSuccess = true;
                    result.Message = "Successful!";
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }

        public override OprationResult Read()
        {
            OprationResult result = new OprationResult();
            switch (base.Type)
            {
                case DeviceType.NANO:
                    break;
                case DeviceType.ESP8266:
                    break;
                case DeviceType.ESP32:
                    break;
                default:
                    break;
            }
            return result;
        }

        public override OprationResult Write(string text)
        {
            OprationResult result = new OprationResult();
            switch (base.Type)
            {
                case DeviceType.NANO:
                    break;
                case DeviceType.ESP8266:
                    break;
                case DeviceType.ESP32:
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
