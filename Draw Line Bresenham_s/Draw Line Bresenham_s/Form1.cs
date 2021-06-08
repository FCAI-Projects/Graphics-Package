using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_Line_Bresenham_s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void lineBres(int x0, int y0, int xEnd, int yEnd)
        {
            var Brush = Brushes.Black;
            var g = panel1.CreateGraphics();

            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);

            /* Determine endpoint to use as start position.  */
            if (x0 > xEnd)
            {
                x = xEnd; 
                y = yEnd; 
                xEnd = x0;
            }
            else
            {
                x = x0; 
                y = y0;
            }

            g.FillRectangle(Brush, x, y, 2, 2);

            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                g.FillRectangle(Brush, x, y, 2, 2);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x0, y0, xe, ye;
            x0 = int.Parse(box_x0.Text);
            y0 = int.Parse(box_y0.Text);
            xe = int.Parse(box_xe.Text);
            ye = int.Parse(box_ye.Text);

            lineBres(x0, y0, xe, ye);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.Silver);
        }
    }
}
