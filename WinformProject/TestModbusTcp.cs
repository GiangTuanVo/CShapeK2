using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibConnection;
using LibConnection.ModBus;
namespace WinformProject
{
    public partial class TestModbusTcp : Form
    {
        private ModbusTcpNet busTcpClient = null;
        public TestModbusTcp()
        {
            InitializeComponent();
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            busTcpClient = new ModbusTcpNet(txtAddress.Text, int.Parse(txtPort.Text), byte.Parse(txtStation.Text));
            busTcpClient.DataFormat = LibConnection.Core.DataFormat.CDAB;
            busTcpClient.AddressStartWithZero = true;
            busTcpClient.IsStringReverse=true;
            OperateResult ret = busTcpClient.ConnectServer();
            if (ret.IsSuccess) MessageBox.Show("Connected!");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            switch (cmbVariableRead.Text)
            {
                case "Bool":
                    txtResultRead.Text = busTcpClient.ReadBool(txtAddrRead.Text).Content.ToString();
                    break;
                case "Short":
                    txtResultRead.Text = busTcpClient.ReadInt16(txtAddrRead.Text).Content.ToString();
                    break;
                case "Int":
                    txtResultRead.Text = busTcpClient.ReadInt32(txtAddrRead.Text).Content.ToString();
                    break;
                case "Float":
                    txtResultRead.Text = busTcpClient.ReadFloat(txtAddrRead.Text).Content.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            switch (cmbVariableWrite.Text)
            {
                case "Bool":
                    if(txtResltWrite.Text.StartsWith("[") && txtResltWrite.Text.EndsWith("]"))
                    {
                        string text = txtResltWrite.Text.Substring(1, txtResltWrite.Text.Length - 2);
                        string[] txtSplit = text.Split(',');
                        bool[] result = new bool[txtSplit.Length];
                        for (int i = 0; i < txtSplit.Length; i++)
                        {
                            result[i] = bool.Parse(txtSplit[i]);
                        }
                        busTcpClient.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        busTcpClient.Write(txtAddrWrite.Text, bool.Parse(txtResltWrite.Text));
                    }
                    
                    break;
                case "Short":
                    if (txtResltWrite.Text.StartsWith("[") && txtResltWrite.Text.EndsWith("]"))
                    {
                        string text = txtResltWrite.Text.Substring(1, txtResltWrite.Text.Length - 2);
                        string[] txtSplit = text.Split(',');
                        short[] result = new short[txtSplit.Length];
                        for (int i = 0; i < txtSplit.Length; i++)
                        {
                            result[i] = short.Parse(txtSplit[i]);
                        }
                        busTcpClient.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        busTcpClient.Write(txtAddrWrite.Text, short.Parse(txtResltWrite.Text));
                    }
                    break;
                case "Int":
                    if (txtResltWrite.Text.StartsWith("[") && txtResltWrite.Text.EndsWith("]"))
                    {
                        string text = txtResltWrite.Text.Substring(1, txtResltWrite.Text.Length - 2);
                        string[] txtSplit = text.Split(',');
                        int[] result = new int[txtSplit.Length];
                        for (int i = 0; i < txtSplit.Length; i++)
                        {
                            result[i] = int.Parse(txtSplit[i]);
                        }
                        busTcpClient.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        busTcpClient.Write(txtAddrWrite.Text, int.Parse(txtResltWrite.Text));
                    }
                    break;
                case "Float":
                    if (txtResltWrite.Text.StartsWith("[") && txtResltWrite.Text.EndsWith("]"))
                    {
                        string text = txtResltWrite.Text.Substring(1, txtResltWrite.Text.Length - 2);
                        string[] txtSplit = text.Split(',');
                        float[] result = new float[txtSplit.Length];
                        for (int i = 0; i < txtSplit.Length; i++)
                        {
                            result[i] = float.Parse(txtSplit[i]);
                        }
                        busTcpClient.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        busTcpClient.Write(txtAddrWrite.Text, float.Parse(txtResltWrite.Text));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
