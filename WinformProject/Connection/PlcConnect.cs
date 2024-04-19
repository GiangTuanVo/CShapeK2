using LibConnection;
using LibConnection.Profinet.Melsec;

namespace WinformProject.Connection
{
    public class PlcConnect
    {
        public static MelsecMcNet melsec_net;
        public static bool isConnect = false;
        //Funtion connect to PLC
        public static string ConnectionPLc(string ip, int port, int timeout)
        {
            melsec_net = new MelsecMcNet();
            melsec_net.IpAddress = ip;
            melsec_net.Port = port;
            melsec_net.ConnectTimeOut = timeout;
            OperateResult connect = melsec_net.ConnectServer();
            if (connect.IsSuccess)
            {
                isConnect = true;
                return "Connect OK!";
            }
            else
            {
                return "Connect Fail!";
            }
        }
    }
}
