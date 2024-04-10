using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformProject
{
    public partial class FormPainting : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;
        public FormPainting()
        {
            InitializeComponent();
        }

        private void FormPainting_Load(object sender, EventArgs e)
        {

        }

        private void CaptureScreen()
        {
            Graphics mygraphics = panel1.CreateGraphics();
            Size s = panel1.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, panel1.ClientRectangle.Width, panel1.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            PrinterSettings ps = new PrinterSettings();
            ps.Copies = 2;
            IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
            PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A5);
            printDocument1.DefaultPageSettings.PaperSize = sizeA4;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog(this);
            //printDocument1.Print();
            Close();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
