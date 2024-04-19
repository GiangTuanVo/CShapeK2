using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WinformProject.Control;

namespace WinformProject
{
    public partial class RealTimeMotor : Form
    {
        //Get object
        public delegate void Instant(Motor mmotor);
        public Instant GetInstant;

        Motor motor { get; set; }
        Thread thread = null;
        bool isThread = true;
        public RealTimeMotor()
        {
            InitializeComponent();
            GetInstant = new Instant(GetObject);
        }

        private void GetObject(object _object)
        {
            //trỏ đến
            motor = (Motor)_object; //tham chiếu

            this.StartPosition = FormStartPosition.Manual;

            this.Location = motor.PointToScreen(Point.Empty);
        }

        private void RealTime_Load(object sender, EventArgs e)
        {
            thread = new Thread(ShowValue);
            thread.Start();
        }

        private void ShowValue()
        {
            while (isThread)
            {
                if (motor != null)
                {
                    this.Invoke(new Action(() =>
                    {
                        if (motor.Status) { lblStaus.Text = "ON"; }
                        else { lblStaus.Text = "OFF"; }
                        if (motor.Error != 0) lblStaus.Text = "ERR";
                        lblSpeed.Text = motor.Speed.ToString();
                        lblCurrent.Text = motor.Current.ToString();
                        lblTem.Text = motor.Temprature.ToString();
                    }));
                }

            }
        }

        private void RealTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
            isThread = false;
        }
    }
}
