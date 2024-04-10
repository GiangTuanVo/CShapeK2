
namespace WinformProject
{
    partial class FormArduinoSerial
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
            this.comPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.cboHandShake = new System.Windows.Forms.ComboBox();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblX_Axis = new System.Windows.Forms.Label();
            this.lblZ_Axis = new System.Windows.Forms.Label();
            this.lblY_Axis = new System.Windows.Forms.Label();
            this.CircleTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CircleProgressTemp = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.CircleProgressHum = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comPort
            // 
            this.comPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.comPort_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cboComPort, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cboBaudRate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboHandShake, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboDataBits, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cboStopBits, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cboParity, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.checkBox2, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnConnect, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnStop, 1, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(233, 300);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Serial Port";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Baud Rate";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "HandShake";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "DataBits";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "StopBits";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Parity";
            // 
            // cboComPort
            // 
            this.cboComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(119, 3);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(111, 28);
            this.cboComPort.TabIndex = 4;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cboBaudRate.Location = new System.Drawing.Point(119, 39);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(111, 28);
            this.cboBaudRate.TabIndex = 5;
            // 
            // cboHandShake
            // 
            this.cboHandShake.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHandShake.FormattingEnabled = true;
            this.cboHandShake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.cboHandShake.Location = new System.Drawing.Point(119, 75);
            this.cboHandShake.Name = "cboHandShake";
            this.cboHandShake.Size = new System.Drawing.Size(111, 28);
            this.cboHandShake.TabIndex = 6;
            // 
            // cboDataBits
            // 
            this.cboDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(119, 111);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(111, 28);
            this.cboDataBits.TabIndex = 7;
            // 
            // cboStopBits
            // 
            this.cboStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.cboStopBits.Location = new System.Drawing.Point(119, 147);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(111, 28);
            this.cboStopBits.TabIndex = 8;
            // 
            // cboParity
            // 
            this.cboParity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Mark",
            "Odd",
            "Space"});
            this.cboParity.Location = new System.Drawing.Point(119, 183);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(111, 28);
            this.cboParity.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "DTR";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(150, 222);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "RST";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(3, 255);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 42);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(119, 255);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 42);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CircleProgressHum);
            this.groupBox2.Controls.Add(this.CircleProgressTemp);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(257, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Real Time";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lblX_Axis, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblZ_Axis, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblY_Axis, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(469, 58);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblX_Axis
            // 
            this.lblX_Axis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX_Axis.BackColor = System.Drawing.Color.Gainsboro;
            this.lblX_Axis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX_Axis.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblX_Axis.Location = new System.Drawing.Point(5, 5);
            this.lblX_Axis.Margin = new System.Windows.Forms.Padding(5);
            this.lblX_Axis.Name = "lblX_Axis";
            this.lblX_Axis.Size = new System.Drawing.Size(146, 48);
            this.lblX_Axis.TabIndex = 0;
            this.lblX_Axis.Text = "label1";
            this.lblX_Axis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZ_Axis
            // 
            this.lblZ_Axis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZ_Axis.BackColor = System.Drawing.Color.Gainsboro;
            this.lblZ_Axis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ_Axis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblZ_Axis.Location = new System.Drawing.Point(317, 5);
            this.lblZ_Axis.Margin = new System.Windows.Forms.Padding(5);
            this.lblZ_Axis.Name = "lblZ_Axis";
            this.lblZ_Axis.Size = new System.Drawing.Size(147, 48);
            this.lblZ_Axis.TabIndex = 4;
            this.lblZ_Axis.Text = "label1";
            this.lblZ_Axis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY_Axis
            // 
            this.lblY_Axis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY_Axis.BackColor = System.Drawing.Color.Gainsboro;
            this.lblY_Axis.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY_Axis.ForeColor = System.Drawing.Color.DeepPink;
            this.lblY_Axis.Location = new System.Drawing.Point(161, 5);
            this.lblY_Axis.Margin = new System.Windows.Forms.Padding(5);
            this.lblY_Axis.Name = "lblY_Axis";
            this.lblY_Axis.Size = new System.Drawing.Size(146, 48);
            this.lblY_Axis.TabIndex = 0;
            this.lblY_Axis.Text = "label1";
            this.lblY_Axis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CircleTime
            // 
            this.CircleTime.Enabled = true;
            this.CircleTime.Tick += new System.EventHandler(this.CircleTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "READ DATA OF ARDUINO FROM RS232";
            // 
            // CircleProgressTemp
            // 
            this.CircleProgressTemp.Animated = false;
            this.CircleProgressTemp.AnimationInterval = 1;
            this.CircleProgressTemp.AnimationSpeed = 1;
            this.CircleProgressTemp.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressTemp.CircleMargin = 10;
            this.CircleProgressTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.CircleProgressTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CircleProgressTemp.IsPercentage = false;
            this.CircleProgressTemp.LineProgressThickness = 10;
            this.CircleProgressTemp.LineThickness = 10;
            this.CircleProgressTemp.Location = new System.Drawing.Point(6, 101);
            this.CircleProgressTemp.Name = "CircleProgressTemp";
            this.CircleProgressTemp.ProgressAnimationSpeed = 200;
            this.CircleProgressTemp.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressTemp.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.CircleProgressTemp.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.CircleProgressTemp.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleProgressTemp.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.CircleProgressTemp.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleProgressTemp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CircleProgressTemp.Size = new System.Drawing.Size(210, 210);
            this.CircleProgressTemp.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircleProgressTemp.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.CircleProgressTemp.SubScriptText = ".00";
            this.CircleProgressTemp.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircleProgressTemp.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.CircleProgressTemp.SuperScriptText = "°C";
            this.CircleProgressTemp.TabIndex = 16;
            this.CircleProgressTemp.Text = "30";
            this.CircleProgressTemp.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CircleProgressTemp.Value = 30;
            this.CircleProgressTemp.ValueByTransition = 30;
            this.CircleProgressTemp.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // CircleProgressHum
            // 
            this.CircleProgressHum.Animated = false;
            this.CircleProgressHum.AnimationInterval = 1;
            this.CircleProgressHum.AnimationSpeed = 1;
            this.CircleProgressHum.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressHum.CircleMargin = 10;
            this.CircleProgressHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.CircleProgressHum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CircleProgressHum.IsPercentage = false;
            this.CircleProgressHum.LineProgressThickness = 10;
            this.CircleProgressHum.LineThickness = 10;
            this.CircleProgressHum.Location = new System.Drawing.Point(262, 101);
            this.CircleProgressHum.Name = "CircleProgressHum";
            this.CircleProgressHum.ProgressAnimationSpeed = 200;
            this.CircleProgressHum.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.CircleProgressHum.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.CircleProgressHum.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.CircleProgressHum.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleProgressHum.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.CircleProgressHum.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.CircleProgressHum.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CircleProgressHum.Size = new System.Drawing.Size(208, 208);
            this.CircleProgressHum.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircleProgressHum.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.CircleProgressHum.SubScriptText = ".00";
            this.CircleProgressHum.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CircleProgressHum.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.CircleProgressHum.SuperScriptText = "%";
            this.CircleProgressHum.TabIndex = 16;
            this.CircleProgressHum.Text = "30";
            this.CircleProgressHum.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.CircleProgressHum.Value = 30;
            this.CircleProgressHum.ValueByTransition = 30;
            this.CircleProgressHum.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // FormArduinoSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormArduinoSerial";
            this.Text = "FormArduinoSerial";
            this.Load += new System.EventHandler(this.ArduinoRS232_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort comPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.ComboBox cboHandShake;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblX_Axis;
        private System.Windows.Forms.Label lblZ_Axis;
        private System.Windows.Forms.Label lblY_Axis;
        private System.Windows.Forms.Timer CircleTime;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuCircleProgress CircleProgressHum;
        private Bunifu.UI.WinForms.BunifuCircleProgress CircleProgressTemp;
    }
}