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
    public partial class FormTestModbusRTU : Form
    {
        private ModbusRtu modbusRtuClient = null;
        public FormTestModbusRTU()
        {
            InitializeComponent();
        }

        private void FormTestModbusRTU_Load(object sender, EventArgs e)
        {
            modbusRtuClient = new ModbusRtu();
            modbusRtuClient.DataFormat = LibConnection.Core.DataFormat.CDAB;//Short
            //modbusRtuClient.DataFormat = LibConnection.Core.DataFormat.ABCD;//Short
            //modbusRtuClient.DataFormat = LibConnection.Core.DataFormat.BADC;//Short
            //modbusRtuClient.DataFormat = LibConnection.Core.DataFormat.ABCD;//Short

            modbusRtuClient.SerialPortInni(sp =>
            {
                sp.PortName = "COM2";
                sp.BaudRate = 19200;
                sp.DataBits = 8;
                sp.StopBits = System.IO.Ports.StopBits.One;
                sp.Parity = System.IO.Ports.Parity.None;
            });
            OperateResult connect = modbusRtuClient.Open();
            if (connect.IsSuccess) MessageBox.Show(connect.Message);

            //Read Coil
            bool readM0 = modbusRtuClient.ReadBool("16384").Content;

            bool readM1 = modbusRtuClient.ReadBool("1").Content;

            bool[] readBoolArr = modbusRtuClient.ReadBool("16384", 8).Content;
            //Write coil
            bool[] value = new bool[] { true, false, true, false, true, false, true, false, true };
            OperateResult ret =modbusRtuClient.Write("16384", value);
            //OperateResult ret = modbusRtuClient.Write("0", true);
            //if (ret.IsSuccess) MessageBox.Show(connect.Message);
            //Read register
            short readD0 = modbusRtuClient.ReadInt16("0").Content;
            short[] readRegisterArr = modbusRtuClient.ReadInt16("0",10).Content;
            //Write register
            //short value = -234;
            //int[] arr_Short = new int[] { 12, 34, 56, 78, 23 };
            //float value = -3.45f;
            //byte[] arr = Convert(value);//0:205,1:204,2:192,3:92
            //float[] arr_Short = new float[] { 1.2f, 3.4f, 5.6f, 7.8f, 2.3f };
            //ret = modbusRtuClient.Write("0", value);
            //ret = modbusRtuClient.Write("0", arr_Short);
            //double double_val = 121435678;
            //ret = modbusRtuClient.Write("0", double_val);

        }
        private byte[] Convert(float value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}
