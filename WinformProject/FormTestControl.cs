using System;
using System.Windows.Forms;

namespace WinformProject
{
    public partial class FormTestControl : System.Windows.Forms.Form
    {
        public FormTestControl()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RealTime.Start();
            //RealTime.Stop();
            //Users users = new Users();
            //users.GetUsers.Add(new Users("Vo", 1, "Nam", new DateTime(2021, 4, 4)));
            //listBox.Items.Add(users);

        }


        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon tat form khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void chkOnOff_Click(object sender, EventArgs e)
        {
            if (chkOnOff.Checked == true)
            {
                //Light.OnColor = Color.Green;
            }
            else
            {
                //Light.OnColor = Color.Gray;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rad01.Checked == true)
            {
                //Light.OnColor = Color.Green;
                rad2.Checked = false;
            }
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2.Checked == true)
            {
                //Light.OnColor = Color.Red;
                rad01.Checked = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            txtDayTime.Text = dateTimePicker1.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(txtDayTime.Text);
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            //for (int i = 0; i<=100 ; i ++)
            //{
            //    progressBar1.Value = i;
            //    Thread.Sleep(100);
            //}
        }

        private void trbSpeed_ValueChanged(object sender, EventArgs e)
        {
            lblPercen.Text = $"{trbSpeed.Value.ToString()}%";
        }

        private void RealTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            RealTime.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RealTime.Start();
        }
    }
}
