
namespace WinformProject
{
    partial class TestMelsecTcp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmbVariableRead = new System.Windows.Forms.ComboBox();
            this.txtAddrRead = new System.Windows.Forms.TextBox();
            this.txtResultRead = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.cmbVariableWrite = new System.Windows.Forms.ComboBox();
            this.txtAddrWrite = new System.Windows.Forms.TextBox();
            this.txtResltWrite = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IpAddress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(103, 23);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "192.168.1.3";
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(89, 52);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(103, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "5000";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 81);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 41);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmbVariableRead
            // 
            this.cmbVariableRead.FormattingEnabled = true;
            this.cmbVariableRead.Items.AddRange(new object[] {
            "Bool",
            "Short",
            "Int",
            "Float"});
            this.cmbVariableRead.Location = new System.Drawing.Point(400, 44);
            this.cmbVariableRead.Name = "cmbVariableRead";
            this.cmbVariableRead.Size = new System.Drawing.Size(62, 25);
            this.cmbVariableRead.TabIndex = 4;
            // 
            // txtAddrRead
            // 
            this.txtAddrRead.Location = new System.Drawing.Point(302, 45);
            this.txtAddrRead.Name = "txtAddrRead";
            this.txtAddrRead.Size = new System.Drawing.Size(92, 23);
            this.txtAddrRead.TabIndex = 5;
            this.txtAddrRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultRead
            // 
            this.txtResultRead.Location = new System.Drawing.Point(470, 45);
            this.txtResultRead.Name = "txtResultRead";
            this.txtResultRead.Size = new System.Drawing.Size(79, 23);
            this.txtResultRead.TabIndex = 6;
            this.txtResultRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Addr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Variable";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Result";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(228, 40);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(64, 32);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // cmbVariableWrite
            // 
            this.cmbVariableWrite.FormattingEnabled = true;
            this.cmbVariableWrite.Items.AddRange(new object[] {
            "Bool",
            "Short",
            "Int",
            "Float"});
            this.cmbVariableWrite.Location = new System.Drawing.Point(400, 94);
            this.cmbVariableWrite.Name = "cmbVariableWrite";
            this.cmbVariableWrite.Size = new System.Drawing.Size(62, 25);
            this.cmbVariableWrite.TabIndex = 4;
            // 
            // txtAddrWrite
            // 
            this.txtAddrWrite.Location = new System.Drawing.Point(302, 95);
            this.txtAddrWrite.Name = "txtAddrWrite";
            this.txtAddrWrite.Size = new System.Drawing.Size(92, 23);
            this.txtAddrWrite.TabIndex = 5;
            this.txtAddrWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResltWrite
            // 
            this.txtResltWrite.Location = new System.Drawing.Point(470, 95);
            this.txtResltWrite.Name = "txtResltWrite";
            this.txtResltWrite.Size = new System.Drawing.Size(79, 23);
            this.txtResltWrite.TabIndex = 6;
            this.txtResltWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(228, 90);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(64, 32);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(104, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TestMelsecTcp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 129);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResltWrite);
            this.Controls.Add(this.txtResultRead);
            this.Controls.Add(this.txtAddrWrite);
            this.Controls.Add(this.cmbVariableWrite);
            this.Controls.Add(this.txtAddrRead);
            this.Controls.Add(this.cmbVariableRead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestMelsecTcp";
            this.Text = "la";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cmbVariableRead;
        private System.Windows.Forms.TextBox txtAddrRead;
        private System.Windows.Forms.TextBox txtResultRead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ComboBox cmbVariableWrite;
        private System.Windows.Forms.TextBox txtAddrWrite;
        private System.Windows.Forms.TextBox txtResltWrite;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClose;
    }
}