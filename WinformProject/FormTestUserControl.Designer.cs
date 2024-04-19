
using WinformProject.Connection;

namespace WinformProject
{
    partial class FormTestUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnect = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.Label();
            this.motor1 = new WinformProject.Control.Motor();
            this.valve = new WinformProject.Control.Motor();
            this.motorMitsu = new WinformProject.Control.Motor();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(48, 19);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(173, 26);
            this.txtIp.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(272, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(63, 26);
            this.txtPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // txtConnect
            // 
            this.txtConnect.Location = new System.Drawing.Point(378, 12);
            this.txtConnect.Name = "txtConnect";
            this.txtConnect.Size = new System.Drawing.Size(91, 41);
            this.txtConnect.TabIndex = 2;
            this.txtConnect.Text = "Connect";
            this.txtConnect.UseVisualStyleBackColor = true;
            this.txtConnect.Click += new System.EventHandler(this.txtConnect_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(489, 22);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(64, 20);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.Text = "Waiting";
            // 
            // motor1
            // 
            this.motor1.AddCurrent = "D12";
            this.motor1.AddError = "D10";
            this.motor1.AddSpeed = "D8";
            this.motor1.AddStatus = "M10";
            this.motor1.AddTemprature = "D14";
            this.motor1.Current = 0F;
            this.motor1.ErrColor = System.Drawing.Color.Empty;
            this.motor1.Error = ((short)(0));
            this.motor1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motor1.Icon = global::WinformProject.Properties.Resources.Solenoi_Valve;
            this.motor1.Location = new System.Drawing.Point(684, 129);
            this.motor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motor1.MotorName = "Solenoi Valve";
            this.motor1.Name = "motor1";
            this.motor1.OffColor = System.Drawing.Color.Empty;
            this.motor1.OnColor = System.Drawing.Color.Empty;
            this.motor1.Size = new System.Drawing.Size(223, 218);
            this.motor1.Speed = ((short)(0));
            this.motor1.Status = false;
            this.motor1.TabIndex = 5;
            this.motor1.Temprature = 0F;
            this.motor1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.motorMitsu_MouseDown);
            // 
            // valve
            // 
            this.valve.AddCurrent = "D10";
            this.valve.AddError = "D12";
            this.valve.AddSpeed = "D13";
            this.valve.AddStatus = "M1";
            this.valve.AddTemprature = "D14";
            this.valve.BackColor = System.Drawing.Color.Transparent;
            this.valve.Current = 0F;
            this.valve.ErrColor = System.Drawing.Color.OrangeRed;
            this.valve.Error = ((short)(0));
            this.valve.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valve.Icon = global::WinformProject.Properties.Resources.Valve;
            this.valve.Location = new System.Drawing.Point(387, 129);
            this.valve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valve.MotorName = "HGDF1213";
            this.valve.Name = "valve";
            this.valve.OffColor = System.Drawing.Color.Transparent;
            this.valve.OnColor = System.Drawing.Color.SkyBlue;
            this.valve.Size = new System.Drawing.Size(225, 231);
            this.valve.Speed = ((short)(0));
            this.valve.Status = false;
            this.valve.TabIndex = 4;
            this.valve.Temprature = 0F;
            this.valve.MouseDown += new System.Windows.Forms.MouseEventHandler(this.motorMitsu_MouseDown);
            // 
            // motorMitsu
            // 
            this.motorMitsu.AddCurrent = "D1";
            this.motorMitsu.AddError = "D5";
            this.motorMitsu.AddSpeed = "D0";
            this.motorMitsu.AddStatus = "M0";
            this.motorMitsu.AddTemprature = "D3";
            this.motorMitsu.BackColor = System.Drawing.Color.Transparent;
            this.motorMitsu.Current = 0F;
            this.motorMitsu.ErrColor = System.Drawing.Color.Red;
            this.motorMitsu.Error = ((short)(0));
            this.motorMitsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorMitsu.Icon = global::WinformProject.Properties.Resources.Motor;
            this.motorMitsu.Location = new System.Drawing.Point(143, 129);
            this.motorMitsu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.motorMitsu.MotorName = "Mitsubishi";
            this.motorMitsu.Name = "motorMitsu";
            this.motorMitsu.OffColor = System.Drawing.Color.Transparent;
            this.motorMitsu.OnColor = System.Drawing.Color.Green;
            this.motorMitsu.Size = new System.Drawing.Size(225, 231);
            this.motorMitsu.Speed = ((short)(0));
            this.motorMitsu.Status = false;
            this.motorMitsu.TabIndex = 3;
            this.motorMitsu.Temprature = 0F;
            this.motorMitsu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.motorMitsu_MouseDown);
            // 
            // FormTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 502);
            this.Controls.Add(this.motor1);
            this.Controls.Add(this.valve);
            this.Controls.Add(this.motorMitsu);
            this.Controls.Add(this.txtConnect);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIp);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTestUserControl";
            this.Text = "FormTestUserControl";
            this.Load += new System.EventHandler(this.FormTestUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtConnect;
        private System.Windows.Forms.Label txtStatus;
        private Control.Motor motorMitsu;
        private Control.Motor valve;
        private Control.Motor motor1;
    }
}