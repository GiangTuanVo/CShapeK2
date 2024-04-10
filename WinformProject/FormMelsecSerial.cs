using LibConnection;
using LibConnection.Profinet.Melsec;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WinformProject
{
    public partial class FormMelsecFxSerial : Form
    {
        public FormMelsecFxSerial()
        {
            InitializeComponent();
            melsecSerial = new MelsecFxSerial();
        }


        private MelsecFxSerial melsecSerial = null;

        private void FormMXComponent_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            comboBox1.SelectedIndex = 2;
            comboBox3.DataSource = SerialPort.GetPortNames();
            try
            {
                comboBox3.SelectedIndex = 0;
            }
            catch
            {
                comboBox3.Text = "COM1";
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


            melsecSerial?.Close();
            melsecSerial = new MelsecFxSerial();
            melsecSerial.AutoChangeBaudRate = checkBox2.Checked;

            try
            {
                melsecSerial.SerialPortInni(sp =>
                {
                    sp.PortName = comboBox3.Text;
                    sp.BaudRate = baudRate;
                    sp.DataBits = dataBits;
                    sp.StopBits = stopBits == 0 ? StopBits.None : (stopBits == 1 ? StopBits.One : StopBits.Two);
                    sp.Parity = comboBox1.SelectedIndex == 0 ? Parity.None : (comboBox1.SelectedIndex == 1 ? Parity.Odd : Parity.Even);
                });
                melsecSerial.Open();

                button2.Enabled = true;
                button1.Enabled = false;
                panel2.Enabled = true;

                userControlReadWrite.SetReadWriteNet(melsecSerial, "D100", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Disconnect
            melsecSerial.Close();
            button2.Enabled = false;
            button1.Enabled = true;
            panel2.Enabled = false;
        }


        private void button25_Click(object sender, EventArgs e)
        {
            DemoUtils.BulkReadRenderResult(melsecSerial, textBox6, textBox9, textBox10);
        }


        private void button26_Click(object sender, EventArgs e)
        {
            OperateResult<byte[]> read = melsecSerial.ReadFromCoreServer(LibConnection.BasicFramework.SoftBasic.HexStringToBytes(textBox13.Text));
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
