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

        void ellipsePlotPoints(int xc, int yc, int x, int y)
        {

            var Brush = Brushes.Black;
            var g = panel1.CreateGraphics();

            g.FillRectangle(Brush, xc + x, yc + y, 2, 2);
            g.FillRectangle(Brush, xc - x, yc + y, 2, 2);
            g.FillRectangle(Brush, xc + x, yc - y, 2, 2);
            g.FillRectangle(Brush, xc - x, yc - y, 2, 2);
        }

        void ellipseMidpoint(int xc, int yc, int rx, int ry)
        {
            int rx2 = rx * rx;
            int ry2 = ry * ry;
            int tworx2 = 2 * rx2;
            int twory2 = 2 * ry2;
            int p;
            int x = 0;
            int y = ry;
            int px = 0;
            int py = tworx2 * y;

            ellipsePlotPoints(xc, yc, x, y);

            /* Region 1 */
            p = (int)(ry2 - (rx2 * ry) + (0.25 * rx2));
            while (px < py)
            {
                x++;
                px += twory2;
                if (p < 0)
                    p += ry2 + px;
                else
                {
                    y--;
                    py -= tworx2;
                    p += ry2 + px - py;
                }
                ellipsePlotPoints(xc, yc, x, y);
            }

            /* Region 2 */
            p = ((int)(ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 *ry2));
            while (y > 0)
            {
                y--;
                py -= tworx2;
                if (p > 0)
                    p += rx2 - py;
                else
                {
                    x++;
                    px += twory2;
                    p += rx2 - py + px;
                }
                ellipsePlotPoints(xc, yc, x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int xc, yc, rx, ry;
            xc = int.Parse(box_xc.Text);
            yc = int.Parse(box_yc.Text);
            rx = int.Parse(box_rx.Text);
            ry = int.Parse(box_ry.Text);

            ellipseMidpoint(xc, yc, rx, ry);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.Silver);
        }

        private void box_xc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
