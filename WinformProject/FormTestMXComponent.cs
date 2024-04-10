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
    public partial class FormTestMXComponent : Form
    {
        public FormTestMXComponent()
        {
            InitializeComponent();
        }
        private MelsecComponent FX3U;
        bool isConnect = false;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            FX3U = new MelsecComponent();
            OperateResult ret = FX3U.Connection(int.Parse(txtStation.Text));
            if (ret.IsSuccess)
            {
                lblWarning.Text = "Connected !";
                isConnect = true;
            }
            else
            {
                lblWarning.Text = "Connect fail !";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FX3U.Close();
        }

        private void FormTestMXComponent_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isConnect)
            {
                OperateResult<bool> X0 = FX3U.ReadBool("X0");
                OperateResult<bool> X1 = FX3U.ReadBool("X1");
                OperateResult<bool> Y0 = FX3U.ReadBool("Y1");
                if (X0.Content) ledX0.On = true;
                else ledX0.On = false;
                if (X1.Content) ledX1.On = true;
                else ledX1.On = false;
                if (Y0.Content) ledY0.On = true;
                else ledY0.On = false;
                //
                float D0 = FX3U.ReadFloat("D0").Content;
                txtD0.Text = D0.ToString();
            }
        }

        private void cbxY0_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxY0.Checked)
            {
                FX3U.WriteBool("Y1", true);
            }
            else
            {
                FX3U.WriteBool("Y1", false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //OperateResult ret= FX3U.WriteFloat("D10", float.Parse(txtD10.Text));
            float[] value = new float[] { 12.1f, 343.5f, 3.5f, 53.46f };
            OperateResult ret = FX3U.WriteFloat("D10", value);
        }
    }
}
