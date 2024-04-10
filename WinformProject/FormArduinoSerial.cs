using System;
using System.IO.Ports;
using System.Text;

namespace WinformProject
{
    public partial class FormArduinoSerial : System.Windows.Forms.Form
    {
        string text = "";
        public FormArduinoSerial()
        {
            InitializeComponent();
            cboBaudRate.SelectedIndex = 5;
            cboDataBits.SelectedIndex = 1;
            cboHandShake.SelectedIndex = 0;
            cboParity.SelectedIndex = 0;
            cboStopBits.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!comPort.IsOpen)
                {
                    comPort.PortName = cboComPort.Text;
                    comPort.BaudRate = int.Parse(cboBaudRate.Text);
                    comPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cboHandShake.Text);
                    comPort.DataBits = Int16.Parse(cboDataBits.Text);
                    comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboStopBits.Text);
                    comPort.Parity = (Parity)Enum.Parse(typeof(Parity), cboParity.Text);
                    comPort.Open();
                    if (comPort.IsOpen)
                    {
                        btnConnect.Enabled = false;
                        btnStop.Enabled = true;
                    }
                    else
                    {
                        btnConnect.Enabled = true;
                        btnStop.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void ArduinoRS232_Load(object sender, EventArgs e)
        {
            string[] Ports = SerialPort.GetPortNames();
            cboComPort.DataSource = Ports;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (comPort.IsOpen)
            {
                comPort.Close();
                btnConnect.Enabled = true;
                btnStop.Enabled = false;
            }
            else
            {
                btnConnect.Enabled = false;
                btnStop.Enabled = true;
            }
        }

        private void comPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (comPort.IsOpen)
            {
                do
                {
                    text = comPort.ReadExisting();
                } while (!text.EndsWith("\r\n"));
            }
        }

        private void CircleTime_Tick(object sender, EventArgs e)
        {
            if (text != null)
            {
                string[] num = text.Split(',');
                if (num.Length < 3) return;
                lblX_Axis.Text = $"X:{num[0].Trim()}(rad)";
                lblY_Axis.Text = $"Y:{num[1].Trim()}(rad)";
                lblZ_Axis.Text = $"Z:{num[2].Trim()}(rad)";
                CircleProgressHum.Value = int.Parse(num[3].Split('.')[0]);
                CircleProgressTemp.Value = int.Parse(num[4].Split('.')[0]);
            }
        }

    }
}
