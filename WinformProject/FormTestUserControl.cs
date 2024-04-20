using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinformProject.Connection;
using WinformProject.Control;
using WinformProject.FileHelper;
using WinformProject.Model;

namespace WinformProject
{
    public partial class FormTestUserControl : Form
    {
        DataSet dataSet;
        public FormTestUserControl()
        {
            InitializeComponent();
        }
        string path = "\\master\\Data.csv";
        private void FormTestUserControl_Load(object sender, EventArgs e)
        {
            txtIp.Text = Properties.Settings.Default.IpAddress;
            txtPort.Text = Properties.Settings.Default.Port;

            dataSet = new DataSet();
            DataTable system = new DataTable("Data");
            CSVFile.FileToTBL(Application.StartupPath, @"master\\Data.csv", dataSet, system);

            if (dataSet.Tables.Count > 0)
            {
                if (dataSet.Tables["Data"].Rows.Count > 0)
                {
                    foreach (DataRow item in dataSet.Tables["Data"].Rows)
                    {
                        Valve valve = new Valve();
                        //
                        valve.ColorOn = Color.Blue;
                        //
                        valve.AddrStatus = item.ItemArray[1].ToString();
                        valve.AddrErrorID = item.ItemArray[2].ToString();
                        valve.AddrFlow = item.ItemArray[3].ToString();
                        valve.AddrPressure = item.ItemArray[4].ToString();
                        valve.MouseDown += valve1_MouseDown;
                        flowLayoutPanel1.Controls.Add(valve);
                    }
                }
            }
        }

        private void txtConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IpAddress = txtIp.Text;
            Properties.Settings.Default.Port = txtPort.Text;
            Properties.Settings.Default.Save();
            txtStatus.Text = PlcConnect.ConnectionPLc(txtIp.Text, int.Parse(txtPort.Text), 3000);
        }

        private void valve1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Valve)
            {
                Valve valve = (Valve)sender;
                RealTimeValve realTime = new RealTimeValve();
                realTime.GetInstant(valve);
                realTime.Show();
            }
        }
    }
}
