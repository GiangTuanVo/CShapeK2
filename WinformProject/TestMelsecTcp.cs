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
using LibConnection.Profinet.Melsec;
namespace WinformProject
{
    public partial class TestMelsecTcp : Form
    {
        private MelsecMcNet melsecTcp = null;
        public TestMelsecTcp()
        {
            InitializeComponent();
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            melsecTcp = new MelsecMcNet(txtAddress.Text, int.Parse(txtPort.Text));
            OperateResult ret = melsecTcp.ConnectServer();
            if (ret.IsSuccess)
            {
                MessageBox.Show("Connected!");
                btnConnect.Enabled = false;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            switch (cmbVariableRead.Text)
            {
                case "Bool":
                    txtResultRead.Text = melsecTcp.ReadBool(txtAddrRead.Text).Content.ToString();
                    break;
                case "Short":
                    txtResultRead.Text = melsecTcp.ReadInt16(txtAddrRead.Text).Content.ToString();
                    break;
                case "Int":
                    txtResultRead.Text = melsecTcp.ReadInt32(txtAddrRead.Text).Content.ToString();
                    break;
                case "Float":
                    txtResultRead.Text = melsecTcp.ReadFloat(txtAddrRead.Text).Content.ToString();
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
                        melsecTcp.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        melsecTcp.Write(txtAddrWrite.Text, bool.Parse(txtResltWrite.Text));
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
                        melsecTcp.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        melsecTcp.Write(txtAddrWrite.Text, short.Parse(txtResltWrite.Text));
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
                        melsecTcp.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        melsecTcp.Write(txtAddrWrite.Text, int.Parse(txtResltWrite.Text));
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
                        melsecTcp.Write(txtAddrWrite.Text, result);
                    }
                    else
                    {
                        melsecTcp.Write(txtAddrWrite.Text, float.Parse(txtResltWrite.Text));
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            melsecTcp.ConnectClose();
        }
    }
}
