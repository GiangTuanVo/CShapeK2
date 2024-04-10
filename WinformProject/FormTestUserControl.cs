using System;
using System.Windows.Forms;
using WinformProject.Connection;
using WinformProject.Control;

namespace WinformProject
{
    public partial class FormTestUserControl : Form
    {
        public FormTestUserControl()
        {
            InitializeComponent();
        }

        private void FormTestUserControl_Load(object sender, EventArgs e)
        {
            txtIp.Text = Properties.Settings.Default.IpAddress;
            txtPort.Text = Properties.Settings.Default.Port;
        }

        private void txtConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IpAddress = txtIp.Text;
            Properties.Settings.Default.Port = txtPort.Text;
            Properties.Settings.Default.Save();
            txtStatus.Text = PlcConnect.ConnectionPLc(txtIp.Text, int.Parse(txtPort.Text), 3000);
        }

        private void motorMitsu_MouseDown(object sender, MouseEventArgs e)
        {
            //cast
            if(sender is Motor)
            {
                Motor motor = (Motor)sender;

                RealTime frmRealTime = new RealTime();
                frmRealTime.GetInstant(motor);
                //frmRealTime.Show();
                frmRealTime.ShowDialog();
            }

        }
    }
}
