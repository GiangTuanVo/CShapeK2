using LibConnection;
using LibConnection.ModBus;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WinformProject
{
    public partial class FormModbusRtu : Form
    {
        public FormModbusRtu()
        {
            InitializeComponent();
        }

        private ModbusRtu busRtuClient = null;

        private void FormModbusRtu_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 2;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;

            comboBox3.DataSource = SerialPort.GetPortNames();
            try
            {
                comboBox3.SelectedIndex = 0;
            }
            catch
            {
                comboBox3.Text = "COM3";
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (busRtuClient != null)
            {
                busRtuClient.IsStringReverse = checkBox3.Checked;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busRtuClient != null)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: busRtuClient.DataFormat = LibConnection.Core.DataFormat.ABCD; break;
                    case 1: busRtuClient.DataFormat = LibConnection.Core.DataFormat.BADC; break;
                    case 2: busRtuClient.DataFormat = LibConnection.Core.DataFormat.CDAB; break;
                    case 3: busRtuClient.DataFormat = LibConnection.Core.DataFormat.DCBA; break;
                    default: break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(comboBox4.Text, out int baudRate))
            {
                MessageBox.Show(DemoUtils.BaudRateInputWrong);
                return;
            }

            if (!int.TryParse(comboBox5.Text, out int dataBits))
            {
                MessageBox.Show(DemoUtils.DataBitsInputWrong);
                return;
            }

            if (!int.TryParse(comboBox6.Text, out int stopBits))
            {
                MessageBox.Show(DemoUtils.StopBitInputWrong);
                return;
            }


            if (!byte.TryParse(textBox15.Text, out byte station))
            {
                MessageBox.Show("Station input wrong！");
                return;
            }

            busRtuClient?.Close();
            busRtuClient = new ModbusRtu(station);
            busRtuClient.AddressStartWithZero = checkBox1.Checked;
            busRtuClient.IsClearCacheBeforeRead = checkBox2.Checked;
            busRtuClient.Crc16CheckEnable = checkBox_crc16.Checked;


            ComboBox2_SelectedIndexChanged(null, new EventArgs());
            busRtuClient.IsStringReverse = checkBox3.Checked;

            try
            {
                busRtuClient.SerialPortInni(sp =>
                {
                    sp.PortName = comboBox3.Text;
                    sp.BaudRate = baudRate;
                    sp.DataBits = dataBits;
                    sp.StopBits = stopBits == 0 ? System.IO.Ports.StopBits.None : (stopBits == 1 ? System.IO.Ports.StopBits.One : System.IO.Ports.StopBits.Two);
                    sp.Parity = comboBox1.SelectedIndex == 0 ? System.IO.Ports.Parity.None : (comboBox1.SelectedIndex == 1 ? System.IO.Ports.Parity.Odd : System.IO.Ports.Parity.Even);
                });
                busRtuClient.RtsEnable = checkBox5.Checked;
                busRtuClient.Open();

                button2.Enabled = true;
                button1.Enabled = false;
                panel2.Enabled = true;

                userControlReadWrite.SetReadWriteNet(busRtuClient, "100", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            busRtuClient.Close();
            button2.Enabled = false;
            button1.Enabled = true;
            panel2.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DemoUtils.BulkReadRenderResult(busRtuClient, textBox6, textBox9, textBox10);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OperateResult<byte[]> read = busRtuClient.ReadFromCoreServer(textBox13.Text.ToHexBytes());
            if (read.IsSuccess)
            {
                textBox11.Text = "Result：" + LibConnection.BasicFramework.SoftBasic.ByteToHexString(read.Content);
            }
            else
            {
                MessageBox.Show("Read Failed：" + read.ToMessageShowString());
            }
        }
    }
}