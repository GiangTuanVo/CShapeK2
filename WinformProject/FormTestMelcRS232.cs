using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using LibConnection;
using LibConnection.Profinet.Melsec;

namespace WinformProject
{
    public partial class FormTestMelcRS232 : Form
    {
        private MelsecFxSerial FxSerial = null;
        private bool isConnect = false;
        public FormTestMelcRS232()
        {
            InitializeComponent();
        }

        private void FormTestMelcRS232_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPort.DataSource = ports;
            cmbBaud.SelectedIndex = 0;
            cmbDatabits.SelectedIndex = 0;
            cmbStopbits.SelectedIndex = 0;
            cmbEvent.SelectedIndex = 2;
            btnClose.Enabled = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                FxSerial = new MelsecFxSerial();
                FxSerial.SerialPortInni(sp =>
                {
                    sp.PortName = cmbPort.Text;
                    sp.BaudRate = int.Parse(cmbBaud.Text);
                    sp.DataBits = int.Parse(cmbDatabits.Text);
                    int stopBits = int.Parse(cmbStopbits.Text);
                    //if (stopBits == 0) sp.StopBits = StopBits.None;
                    sp.StopBits = stopBits == 0 ? StopBits.None : (stopBits == 1 ? StopBits.One : StopBits.Two);
                    sp.Parity = cmbEvent.SelectedIndex == 0 ? Parity.None : (cmbEvent.SelectedIndex == 1 ? Parity.Odd : Parity.Even);
                });
                OperateResult ret = FxSerial.Open();
                if (ret.IsSuccess)
                {
                    lblInfo.Text = "Connect to PLC successful !";
                    lblInfo.ForeColor = Color.Blue;
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;
                    isConnect = true;
                }
                else
                {
                    lblInfo.Text = "Connect to PLC fail !";
                    lblInfo.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FxSerial.Close();
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            lblInfo.Text = "Close connect to PLC !";
            lblInfo.ForeColor = Color.Black;
        }

        private void chk_Y0_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Y0.Checked == true) FxSerial.Write("Y0", true);
            else FxSerial.Write("Y0", false);

            bool read_Y0 = FxSerial.ReadBool("Y0").Content;
            if (read_Y0) led_Y0.On = true;
            else led_Y0.On = false;
        }

        private void chk_Y1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Y1.Checked == true) FxSerial.Write("Y1", true);
            else FxSerial.Write("Y1", false);

            bool read_Y1 = FxSerial.ReadBool("Y1").Content;
            if (read_Y1) led_Y1.On = true;
            else led_Y1.On = false;
        }

        private void RealTime_Tick(object sender, EventArgs e)
        {
            if (isConnect)
            {
                led_X0.On = FxSerial.ReadBool("X0").Content;
                led_X1.On = FxSerial.ReadBool("X1").Content;
            }
        }

        private void txtShort_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtShortLength.Text != "" && txtAddr_Short_Read.Text != "" && isConnect)
                {
                    ushort length = ushort.Parse(txtShortLength.Text);
                    if (length <= 1)
                    {
                        txtValue_Short_Read.Text = FxSerial.ReadInt16(txtAddr_Short_Read.Text).Content.ToString();
                    }
                    else
                    {
                        short[] arr_Short = FxSerial.ReadInt16(txtAddr_Short_Read.Text, length).Content;
                        string text = "";
                        for (int i = 0; i < arr_Short.Length; i++)
                        {
                            if (i != arr_Short.Length - 1)
                            {
                                text += $"{arr_Short[i].ToString()},";
                            }
                            else
                            {
                                text += $"{arr_Short[i].ToString()}";
                            }

                        }
                        txtValue_Short_Read.Text = text;
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void txtValue_Short_Write_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAddr_Short_Write.Text != "" && txtValue_Short_Write.Text != "" && isConnect)
            {
                string[] text = txtValue_Short_Write.Text.Split(',');
                short[] ret = new short[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    ret[i] = short.Parse(text[i]);
                }
                OperateResult operate= FxSerial.Write(txtAddr_Short_Write.Text, ret);
                if (operate.IsSuccess) MessageBox.Show("Write Successful!");
                else MessageBox.Show("Write Fail!");
            }
        }

        private void txtAddr_Float_Read_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtFloatLength.Text != "" && txtAddr_Float_Read.Text != "" && isConnect)
                {
                    ushort length = ushort.Parse(txtFloatLength.Text);
                    if (length <= 1)
                    {
                        txtValue_Float_Read.Text = FxSerial.ReadFloat(txtAddr_Float_Read.Text).Content.ToString();
                    }
                    else
                    {
                        float[] arr_Float = FxSerial.ReadFloat(txtAddr_Float_Read.Text, length).Content;
                        string text = "";
                        for (int i = 0; i < arr_Float.Length; i++)
                        {
                            if (i != arr_Float.Length - 1)
                            {
                                text += $"{arr_Float[i].ToString()},";
                            }
                            else
                            {
                                text += $"{arr_Float[i].ToString()}";
                            }

                        }
                        txtValue_Float_Read.Text = text;
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtValue_FLoat_Write_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAddr_Float_Write.Text != "" && txtValue_Float_Write.Text != "" && isConnect)
            {
                string[] text = txtValue_Float_Write.Text.Split(',');
                float[] ret = new float[text.Length];
                for (int i = 0; i < text.Length; i++)
                {
                    ret[i] = float.Parse(text[i]);
                }
                OperateResult operate = FxSerial.Write(txtAddr_Float_Write.Text, ret);
                if (operate.IsSuccess) MessageBox.Show("Write Successful!");
                else MessageBox.Show("Write Fail!");
            }
        }
    }
}
