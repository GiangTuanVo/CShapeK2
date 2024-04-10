using LibConnection;
using LibConnection.Profinet.Melsec;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WinformProject
{
    public partial class FormMelsecTcp : Form
    {
        public FormMelsecTcp()
        {
            InitializeComponent();
        }

        private MelsecMcNet melsec_net;
        private bool checkConnect = false;
        private void FormModbusTcp_Load(object sender, EventArgs e)
        {
            //Khoi tao
            melsec_net = new MelsecMcNet();
            panel2.Enabled = false;
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            if (!int.TryParse(textBox2.Text, out int port))
            {
                MessageBox.Show(DemoUtils.PortInputWrong);
                return;
            }
            //Setting
            melsec_net.IpAddress = textBox1.Text;
            melsec_net.Port = port;
            melsec_net.ConnectTimeOut = 3000;

            //Đóng kết nối
            melsec_net.ConnectClose();
            //Kết nối
            OperateResult connect = await melsec_net.ConnectServerAsync();
            if (connect.IsSuccess)
            {
                MessageBox.Show(StringResources.Language.ConnectedSuccess);
                button2.Enabled = true;
                btnConnect.Enabled = false;
                panel2.Enabled = true;
                checkConnect = true;
                userControlReadWrite.SetReadWriteNet(melsec_net, "D0", true);
            }
            else
            {
                MessageBox.Show(connect.Message + Environment.NewLine + "ErrorCode: " + connect.ErrorCode);
                btnConnect.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            melsec_net.ConnectClose();
            button2.Enabled = false;
            btnConnect.Enabled = true;
            panel2.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            DemoUtils.BulkReadRenderResult(melsec_net, textBox6, textBox9, textBox10);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            OperateResult<byte[]> read = melsec_net.ReadFromCoreServer(LibConnection.BasicFramework.SoftBasic.HexStringToBytes(textBox13.Text));
            if (read.IsSuccess)
            {
                textBox11.Text = "Result：" + LibConnection.BasicFramework.SoftBasic.ByteToHexString(read.Content);
            }
            else
            {
                MessageBox.Show("Read Failed：" + read.ToMessageShowString());
            }
        }

        private async void button4_ClickAsync(object sender, EventArgs e)
        {
            button4.Enabled = false;
            OperateResult<string> readResult = await melsec_net.ReadPlcTypeAsync();
            if (readResult.IsSuccess)
            {
                MessageBox.Show("Type:" + readResult.Content);
            }
            else
            {
                MessageBox.Show("Failed: " + readResult.ToMessageShowString());
            }
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OperateResult<byte[]> read = melsec_net.ReadRandom(
                    textBox6.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries),
                    textBox9.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(m => ushort.Parse(m)).ToArray());
            if (read.IsSuccess)
            {
                textBox10.Text = "Result：" + LibConnection.BasicFramework.SoftBasic.ByteToHexString(read.Content);
            }
            else
            {
                MessageBox.Show("Read Failed：" + read.ToMessageShowString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OperateResult result = melsec_net.RemoteReset();
            if (result.IsSuccess)
            {
                MessageBox.Show("RemoteReset Success");
            }
            else
            {
                MessageBox.Show("Failed: " + result.ToMessageShowString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OperateResult result = melsec_net.ErrorStateReset();
            if (result.IsSuccess)
            {
                MessageBox.Show("ErrorStateReset Success");
            }
            else
            {
                MessageBox.Show("Failed: " + result.ToMessageShowString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OperateResult runResult = melsec_net.RemoteRun();
            if (runResult.IsSuccess)
            {
                MessageBox.Show("Run Success");
            }
            else
            {
                MessageBox.Show("Failed: " + runResult.ToMessageShowString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OperateResult runResult = melsec_net.RemoteStop();
            if (runResult.IsSuccess)
            {
                MessageBox.Show("Stop Success");
            }
            else
            {
                MessageBox.Show("Failed: " + runResult.ToMessageShowString());
            }
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            OperateResult<TimeSpan> wait = await melsec_net.WaitAsync("M100", true, 100, 30_000);
            if (wait.IsSuccess)
            {
                MessageBox.Show("Wait Success, Takes " + wait.Content.TotalSeconds.ToString("F1") + " Seconds");
            }
            else
            {
                MessageBox.Show("Wait Failed:" + wait.Message);
            }
            button10.Enabled = true;
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            OperateResult<TimeSpan> wait = await melsec_net.WaitAsync("D100", (short)123, 100, 30_000);
            if (wait.IsSuccess)
            {
                MessageBox.Show("Wait Success, Takes " + wait.Content.TotalSeconds.ToString("F1") + " Seconds");
            }
            else
            {
                MessageBox.Show("Wait Failed:" + wait.Message);
            }
            button11.Enabled = true;
        }

        private void btnReadWrite_Click(object sender, EventArgs e)
        {
            if (checkConnect)
            {
                //short val = melsec_net.ReadInt16("D0";
                //OperateResult<short[]> result = melsec_net.ReadInt16("D0",5);
                OperateResult<bool> result = melsec_net.ReadBool("M0");
                if (result.IsSuccess)
                    MessageBox.Show($"Read D0 : {result.Content}");
            }
        }
    }
}