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

namespace WinformProject
{
    public partial class FormTest : Form
    {
        string text = "";
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            string[] readCom = SerialPort.GetPortNames();
            cmbComport.DataSource = readCom;
            btnClose.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = cmbComport.Text;
                serialPort.BaudRate = int.Parse(cmbBaudrate.Text);
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    btnConnect.Enabled = false;
                    btnClose.Enabled = true;
                    lblWarning.Text = "Connected !";
                    lblWarning.ForeColor = Color.Blue;
                }
                else
                {
                    lblWarning.Text = "Connect fail !";
                    lblWarning.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnClose.Enabled = false;
                btnConnect.Enabled = true;
                lblWarning.Text = "Closed!";
                lblWarning.ForeColor = Color.Black;
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            do
            {
                text = serialPort.ReadExisting();
            } while (!text.EndsWith("\r\n"));
            Invoke(new Action(() =>
            {
                txtRead.AppendText(text);
                string[] arrText = text.Trim().Split(',');
                txtX_Axis.Text = arrText[0];
                txtY_Axis.Text = arrText[1];
                txtZ_Axis.Text = arrText[2];
                txtTem.Text = arrText[3];
                txtHu.Text = arrText[4];
            }));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            Close();
        }
    }
}
