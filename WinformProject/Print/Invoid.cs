using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;

namespace WinformProject.Print
{
    class Invoid
    {
        public void CreateInvoid(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Invoids", new Font("Arial", 11, FontStyle.Regular),Brushes.Black ,new Point(0, 0));

        }
    }
}
