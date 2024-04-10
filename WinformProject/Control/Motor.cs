using LibConnection.Core;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinformProject.Connection;
using LibConnection;

namespace WinformProject.Control
{
    public partial class Motor : UserControl
    {
        private IReadWriteNet ReadWriteNet = null;
        private Timer _timer = new Timer();

        private Color onColor;
        private Color offColor;
        private Color errColor;

        private Image icon;

        private string motorName;

        private short speed;
        private float current;
        private float temprature;
        private bool status;
        private short error;

        private string addSpeed;
        private string addCurrent;
        private string addTemprature;
        private string addStatus;
        private string addError;

        public Motor()
        {
            InitializeComponent();
            _timer.Tick += new EventHandler(CheckStatus);
            _timer.Start();
        }

        public string MotorName
        {
            get => motorName;
            set
            {
                motorName = value;
                lblName.Text = value;
                this.Invalidate();
            }
        }

        public short Speed { get => speed; set => speed = value; }
        public float Current { get => current; set => current = value; }
        public float Temprature { get => temprature; set => temprature = value; }
        public bool Status { get => status; set => status = value; }
        public string AddSpeed { get => addSpeed; set => addSpeed = value; }
        public string AddCurrent { get => addCurrent; set => addCurrent = value; }
        public string AddTemprature { get => addTemprature; set => addTemprature = value; }
        public Color OnColor
        {
            get => onColor;
            set
            {
                onColor = value;
                if(status) this.BackColor = value;
                this.Invalidate();
            }
        }
        public Color OffColor
        {
            get => offColor;
            set
            {
                offColor = value;
                if (!status) this.BackColor = value;
                this.Invalidate();
            }
        }
        public Color ErrColor
        {
            get => errColor;
            set
            {
                errColor = value;
                if(error!=0) this.BackColor = value;
                this.Invalidate();
            }
        }
        public short Error { get => error; set => error = value; }
        public Image Icon 
        { 
            get => icon;
            set 
            { 
                icon = value;
                imgBG.Image = value;
                this.Invalidate();
            }
        }
        public string AddStatus { get => addStatus; set => addStatus = value; }
        public string AddError { get => addError; set => addError = value; }

        private void Image_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

        }

        private void CheckStatus(object sender, EventArgs e)
        {
            _timer.Stop();
            if (PlcConnect.isConnect)
                ReadWriteNet = PlcConnect.melsec_net;
            if (ReadWriteNet != null)
            {
                Speed = ReadWriteNet.ReadInt16(addSpeed).Content;
                Current = ReadWriteNet.ReadFloat(addCurrent).Content;
                Temprature = ReadWriteNet.ReadFloat(addTemprature).Content;
                Status = ReadWriteNet.ReadBool(addStatus).Content;
                Error = ReadWriteNet.ReadInt16(addError).Content;
                if (Status) this.BackColor = onColor;
                else this.BackColor = OffColor;
                if (Error != 0) this.BackColor = errColor;
            }
            _timer.Start();
        }
    }
}
