
namespace WinformProject
{
    partial class FormTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbComport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.txtX_Axis = new System.Windows.Forms.TextBox();
            this.txtY_Axis = new System.Windows.Forms.TextBox();
            this.txtZ_Axis = new System.Windows.Forms.TextBox();
            this.txtTem = new System.Windows.Forms.TextBox();
            this.txtHu = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cmbBaudrate);
            this.groupBox1.Controls.Add(this.cmbComport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(224, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comport Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comport";
            // 
            // cmbComport
            // 
            this.cmbComport.FormattingEnabled = true;
            this.cmbComport.Location = new System.Drawing.Point(94, 41);
            this.cmbComport.Name = "cmbComport";
            this.cmbComport.Size = new System.Drawing.Size(122, 31);
            this.cmbComport.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "BaudRate";
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbBaudrate.Location = new System.Drawing.Point(94, 79);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(122, 31);
            this.cmbBaudrate.TabIndex = 1;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 130);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 39);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(128, 130);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(12, 272);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(56, 23);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "label3";
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(265, 16);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRead.Size = new System.Drawing.Size(352, 177);
            this.txtRead.TabIndex = 2;
            // 
            // txtX_Axis
            // 
            this.txtX_Axis.Location = new System.Drawing.Point(17, 214);
            this.txtX_Axis.Name = "txtX_Axis";
            this.txtX_Axis.Size = new System.Drawing.Size(100, 31);
            this.txtX_Axis.TabIndex = 3;
            this.txtX_Axis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY_Axis
            // 
            this.txtY_Axis.Location = new System.Drawing.Point(141, 214);
            this.txtY_Axis.Name = "txtY_Axis";
            this.txtY_Axis.Size = new System.Drawing.Size(100, 31);
            this.txtY_Axis.TabIndex = 3;
            this.txtY_Axis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZ_Axis
            // 
            this.txtZ_Axis.Location = new System.Drawing.Point(265, 214);
            this.txtZ_Axis.Name = "txtZ_Axis";
            this.txtZ_Axis.Size = new System.Drawing.Size(100, 31);
            this.txtZ_Axis.TabIndex = 3;
            this.txtZ_Axis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTem
            // 
            this.txtTem.Location = new System.Drawing.Point(389, 214);
            this.txtTem.Name = "txtTem";
            this.txtTem.Size = new System.Drawing.Size(100, 31);
            this.txtTem.TabIndex = 3;
            this.txtTem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHu
            // 
            this.txtHu.Location = new System.Drawing.Point(513, 214);
            this.txtHu.Name = "txtHu";
            this.txtHu.Size = new System.Drawing.Size(100, 31);
            this.txtHu.TabIndex = 3;
            this.txtHu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 304);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtHu);
            this.Controls.Add(this.txtTem);
            this.Controls.Add(this.txtZ_Axis);
            this.Controls.Add(this.txtY_Axis);
            this.Controls.Add(this.txtX_Axis);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.ComboBox cmbComport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.TextBox txtRead;
        private System.Windows.Forms.TextBox txtX_Axis;
        private System.Windows.Forms.TextBox txtY_Axis;
        private System.Windows.Forms.TextBox txtZ_Axis;
        private System.Windows.Forms.TextBox txtTem;
        private System.Windows.Forms.TextBox txtHu;
        private System.Windows.Forms.Button btnExit;
    }
}