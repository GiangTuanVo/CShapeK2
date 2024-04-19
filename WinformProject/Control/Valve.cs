using LibConnection.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformProject.Connection;

namespace WinformProject.Control
{
    public partial class Valve : UserControl
    {
        private IReadWriteNet ReadWriteNet = null;
        private Timer _timer = new Timer();
        public Valve()
        {
            InitializeComponent();// draw form

            _timer.Tick += new EventHandler(CheckStatus);
            _timer.Start();
        }
        
        //Properites Object
        private string nameEquipment;
        private Image imageEquipment;
        private Color colorOn;
        private Color colorOff;
        private Color colorError;

        public string NameEquipment
        {
            get => nameEquipment;
            set
            {
                nameEquipment = value;
                txtName.Text = value;
            }
        }

        public Image ImageEquipment
        {
            get => imageEquipment;
            set
            {
                imageEquipment = value;
                picEquipment.Image = value;
            }
        }

        public Color ColorOn 
        { 
            get => colorOn; 
            set => colorOn = value; 
        }
        public Color ColorOff 
        { 
            get => colorOff; 
            set => colorOff = value; 
        }
        public Color ColorError 
        { 
            get => colorError; 
            set => colorError = value; 
        }
        //Address
        public string AddrStatus { get; set; }
        public string AddrFlow { get; set; }
        public string AddrPressure { get; set; }
        public string AddrErrorID { get; set; }
        //Read data
        public bool Status { get; set; } //ON/OFF
        public float Flow { get; set; }
        public float Pressure { get; set; }
        public int ErrorID { get; set; } // 1: Quá dòng, 2: Connection



        private void CheckStatus(object sender, EventArgs e)
        {
            _timer.Stop();
            if (PlcConnect.isConnect)
                ReadWriteNet = PlcConnect.melsec_net;
            if (ReadWriteNet != null)
            {
                Status = ReadWriteNet.ReadBool(AddrStatus).Content;
                Flow = ReadWriteNet.ReadFloat(AddrFlow).Content;
                Pressure = ReadWriteNet.ReadFloat(AddrPressure).Content;                
                ErrorID = ReadWriteNet.ReadInt16(AddrErrorID).Content;

                if (Status) this.BackColor = ColorOn;
                else this.BackColor = ColorOff;
                if (ErrorID != 0) this.BackColor = ColorError;
            }
            _timer.Start();
        }

        private void picEquipment_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }
    }
}
