using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void circlePlotPoints(int xc, int yc, int x, int y)
        {

            var Brush = Brushes.Black;
            var g = panel1.CreateGraphics();

            g.FillRectangle(Brush, xc + x, yc + y, 2, 2);
            g.FillRectangle(Brush, xc - x, yc + y, 2, 2);
            g.FillRectangle(Brush, xc + x, yc - y, 2, 2);
            g.FillRectangle(Brush, xc - x, yc - y, 2, 2);
            g.FillRectangle(Brush, xc + y, yc + x, 2, 2);
            g.FillRectangle(Brush, xc - y, yc + x, 2, 2);
            g.FillRectangle(Brush, xc + y, yc - x, 2, 2);
            g.FillRectangle(Brush, xc - y, yc - x, 2, 2);
        }

        void circleMidPoint (int xc, int yc, int r)
        {
            int x = 0;
            int y = r;
            int p = 1 - r;

            circlePlotPoints(xc, yc, x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1; 
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }

                circlePlotPoints(xc, yc, x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xc, yc, r;
            xc = int.Parse(box_xc.Text);
            yc = int.Parse(box_yc.Text);
            r = int.Parse(box_r.Text);

            circleMidPoint(xc, yc, r);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.Silver);
        }

        private void box_xc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
