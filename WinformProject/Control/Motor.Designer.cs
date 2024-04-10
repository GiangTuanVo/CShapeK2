
namespace WinformProject.Control
{
    partial class Motor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBackGround = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.imgBG = new System.Windows.Forms.PictureBox();
            this.pnlBackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBG)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlBackGround.ColumnCount = 1;
            this.pnlBackGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBackGround.Controls.Add(this.lblName, 0, 0);
            this.pnlBackGround.Controls.Add(this.imgBG, 0, 1);
            this.pnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnlBackGround.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.RowCount = 2;
            this.pnlBackGround.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlBackGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBackGround.Size = new System.Drawing.Size(225, 231);
            this.pnlBackGround.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(2, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(221, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgBG
            // 
            this.imgBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBG.Image = global::WinformProject.Properties.Resources.Motor;
            this.imgBG.Location = new System.Drawing.Point(6, 33);
            this.imgBG.Margin = new System.Windows.Forms.Padding(5);
            this.imgBG.Name = "imgBG";
            this.imgBG.Size = new System.Drawing.Size(213, 192);
            this.imgBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBG.TabIndex = 1;
            this.imgBG.TabStop = false;
            this.imgBG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Image_MouseDown);
            // 
            // Motor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackGround);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Motor";
            this.Size = new System.Drawing.Size(225, 231);
            this.pnlBackGround.ResumeLayout(false);
            this.pnlBackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlBackGround;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox imgBG;
    }
}
