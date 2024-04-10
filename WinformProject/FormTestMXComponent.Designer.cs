
namespace WinformProject
{
    partial class FormTestMXComponent
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.ledX0 = new Sunny.UI.UILedBulb();
            this.ledX1 = new Sunny.UI.UILedBulb();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ledY0 = new Sunny.UI.UILedBulb();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxY0 = new System.Windows.Forms.CheckBox();
            this.txtD0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtD10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station :";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(86, 44);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(163, 27);
            this.txtStation.TabIndex = 1;
            this.txtStation.Text = "1";
            this.txtStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 84);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(91, 41);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtStation);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MX_Component";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(158, 84);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(12, 210);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(57, 21);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "label2";
            // 
            // ledX0
            // 
            this.ledX0.Location = new System.Drawing.Point(342, 56);
            this.ledX0.Name = "ledX0";
            this.ledX0.On = false;
            this.ledX0.Size = new System.Drawing.Size(52, 49);
            this.ledX0.TabIndex = 5;
            this.ledX0.Text = "uiLedBulb1";
            this.ledX0.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ledX1
            // 
            this.ledX1.Location = new System.Drawing.Point(430, 56);
            this.ledX1.Name = "ledX1";
            this.ledX1.On = false;
            this.ledX1.Size = new System.Drawing.Size(52, 49);
            this.ledX1.TabIndex = 5;
            this.ledX1.Text = "uiLedBulb1";
            this.ledX1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "X1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ledY0
            // 
            this.ledY0.Location = new System.Drawing.Point(505, 56);
            this.ledY0.Name = "ledY0";
            this.ledY0.On = false;
            this.ledY0.Size = new System.Drawing.Size(52, 49);
            this.ledY0.TabIndex = 5;
            this.ledY0.Text = "uiLedBulb1";
            this.ledY0.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y0";
            // 
            // cbxY0
            // 
            this.cbxY0.AutoSize = true;
            this.cbxY0.Location = new System.Drawing.Point(508, 111);
            this.cbxY0.Name = "cbxY0";
            this.cbxY0.Size = new System.Drawing.Size(49, 25);
            this.cbxY0.TabIndex = 7;
            this.cbxY0.Text = "Y0";
            this.cbxY0.UseVisualStyleBackColor = true;
            this.cbxY0.CheckedChanged += new System.EventHandler(this.cbxY0_CheckedChanged);
            // 
            // txtD0
            // 
            this.txtD0.Location = new System.Drawing.Point(342, 157);
            this.txtD0.Name = "txtD0";
            this.txtD0.Size = new System.Drawing.Size(100, 27);
            this.txtD0.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "D0";
            // 
            // txtD10
            // 
            this.txtD10.Location = new System.Drawing.Point(505, 157);
            this.txtD10.Name = "txtD10";
            this.txtD10.Size = new System.Drawing.Size(100, 27);
            this.txtD10.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "D10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTestMXComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 240);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtD10);
            this.Controls.Add(this.txtD0);
            this.Controls.Add(this.cbxY0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ledY0);
            this.Controls.Add(this.ledX1);
            this.Controls.Add(this.ledX0);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormTestMXComponent";
            this.Text = "FormTestMXComponent";
            this.Load += new System.EventHandler(this.FormTestMXComponent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWarning;
        private Sunny.UI.UILedBulb ledX0;
        private Sunny.UI.UILedBulb ledX1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILedBulb ledY0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxY0;
        private System.Windows.Forms.TextBox txtD0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtD10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}