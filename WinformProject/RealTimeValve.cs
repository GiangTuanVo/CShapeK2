using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WinformProject.Control;

namespace WinformProject
{
    public partial class RealTimeValve : Form
    {
        //Get object
        public delegate void Instant(Valve valve);
        public Instant GetInstant;

        Valve valve { get; set; }
        Thread thread = null;
        bool isThread = true;
        public RealTimeValve()
        {
            InitializeComponent();
            GetInstant = new Instant(GetObject);
        }

        private void GetObject(object _object)
        {
            //trỏ đến
            valve = (Valve)_object; //tham chiếu

            this.StartPosition = FormStartPosition.Manual;

            this.Location = valve.PointToScreen(Point.Empty);
        }

        private void RealTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void RealTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (valve != null)
            {
                this.Invoke(new Action(() =>
                {
                    if (valve.Status) { lblStaus.Text = "ON"; }
                    else { lblStaus.Text = "OFF"; }
                    if (valve.ErrorID != 0) lblStaus.Text = "ERR";
                    lblPressure.Text = valve.Pressure.ToString();
                    lblFlow.Text = valve.Flow.ToString();
                    lblErrorID.Text = valve.ErrorID.ToString();
                }));
            }
            timer1.Start();
        }
    }
}
