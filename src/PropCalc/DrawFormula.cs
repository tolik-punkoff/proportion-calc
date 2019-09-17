using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PropCalc
{
    public static class DrawFormula
    {
        public static PictureBox pbDraw = null;
        private static Font fntXr = new Font("Microsoft Sans Serif", 18, 
            FontStyle.Italic, GraphicsUnit.Point);
        private static Font fntNumbers = new Font("Microsoft Sans Serif", 10,
            FontStyle.Regular, GraphicsUnit.Point);
        private static Bitmap view = null;
        private static Graphics graph;
        private static Timer tmrDraw = new Timer();

        private static string M1 = "";
        private static string M2 = "";
        private static string D = "";
        private static string A = "";

        public static void InitGraph()
        {
            view = new Bitmap(pbDraw.Width, pbDraw.Height);
            graph = Graphics.FromImage((Image)view);
            tmrDraw.Interval = 100;
            tmrDraw.Tick += new EventHandler(tmrDraw_Tick);

            tmrDraw.Start();
        }

        public static void SetStrings(string m1, string m2, string d, string a)
        {
            M1 = m1; M2 = m2; D = d; A = a;
        }

        static void tmrDraw_Tick(object sender, EventArgs e)
        {
            graph.Clear(pbDraw.BackColor);

            int width = graph.MeasureString("X = ", fntXr).ToSize().Width;
            int height = graph.MeasureString("X = ", fntXr).ToSize().Height;
            int ycenter = pbDraw.Height / 2;
            int ycentertxt = ycenter - 15;
            Brush brush = new SolidBrush(Color.Black);
            graph.DrawString("X = ", fntXr, brush, 5, ycentertxt);

            string sNumerator = M1 + " × " + M2;
            int xnumerator = width + 12;
            int ynumerator = ycenter - 20;
            int wnumerator = graph.MeasureString(sNumerator, fntNumbers).
                ToSize().Width;
            int hnumerator = graph.MeasureString(sNumerator, fntNumbers).
                ToSize().Height;            
            graph.DrawString(sNumerator, fntNumbers, brush, xnumerator, ynumerator);
            
            int xdenom = width + 12;
            int ydenom = ycenter + 5;
            int wdenom = graph.MeasureString(D, fntNumbers).
                ToSize().Width;
            int hdenom = graph.MeasureString(sNumerator, fntNumbers).
                ToSize().Height;
            graph.DrawString(D, fntNumbers, brush, xdenom, ydenom);

            int maxwidth = wnumerator;
            if (maxwidth < wdenom) maxwidth = wdenom;

            Pen pen = new Pen(brush, 2);
            width = width + 12;
            graph.DrawLine(pen, width, ycenter, width + maxwidth, ycenter);

            string stAnswer = "";
            if ((A == "0") && (calc.ErrorMessage != string.Empty))
            {
                stAnswer = " = ∅";
            }
            else
            {
                stAnswer = " = " + A;
            }

            int xanswer = width + maxwidth;
            graph.DrawString(stAnswer, fntXr, brush, xanswer, ycentertxt);

            pbDraw.Image = (Image)view;
        }
    }
}
