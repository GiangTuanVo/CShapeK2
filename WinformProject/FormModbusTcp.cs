using LibConnection;
using LibConnection.ModBus;
using System;
using System.Windows.Forms;

namespace WinformProject
{
    public partial class FormModbusTcp : Form
    {
        public FormModbusTcp()
        {
            InitializeComponent();
        }

        private ModbusTcpNet busTcpClient = null;

        private void FormModbusTcp_Load(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            comboBox2.SelectedIndex = 2;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            checkBox3.CheckedChanged += CheckBox3_CheckedChanged;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (busTcpClient != null)
            {
                busTcpClient.IsStringReverse = checkBox3.Checked;
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busTcpClient != null)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0: busTcpClient.DataFormat = LibConnection.Core.DataFormat.ABCD; break;
                    case 1: busTcpClient.DataFormat = LibConnection.Core.DataFormat.BADC; break;
                    case 2: busTcpClient.DataFormat = LibConnection.Core.DataFormat.CDAB; break;
                    case 3: busTcpClient.DataFormat = LibConnection.Core.DataFormat.DCBA; break;
                    default: break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int port))
            {
                MessageBox.Show(DemoUtils.PortInputWrong);
                return;
            }


            if (!byte.TryParse(textBox15.Text, out byte station))
            {
                MessageBox.Show("Station input is wrong！");
                return;
            }

            busTcpClient?.ConnectClose();
            busTcpClient = new ModbusTcpNet(textBox1.Text, port, station);
            busTcpClient.AddressStartWithZero = checkBox1.Checked;


            ComboBox2_SelectedIndexChanged(null, new EventArgs());
            busTcpClient.IsStringReverse = checkBox3.Checked;

            try
            {
                OperateResult connect = busTcpClient.ConnectServer();
                if (connect.IsSuccess)
                {
                    MessageBox.Show(StringResources.Language.ConnectedSuccess);
                    button2.Enabled = true;
                    button1.Enabled = false;
                    panel2.Enabled = true;

                    userControlReadWrite.SetReadWriteNet(busTcpClient, "100", false);
                }
                else
                {
                    MessageBox.Show(StringResources.Language.ConnectedFailed + connect.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            busTcpClient.ConnectClose();
            button2.Enabled = false;
            button1.Enabled = true;
            panel2.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DemoUtils.BulkReadRenderResult(busTcpClient, textBox6, textBox9, textBox10);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OperateResult<byte[]> read = busTcpClient.ReadFromCoreServer(textBox13.Text.ToHexBytes());
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