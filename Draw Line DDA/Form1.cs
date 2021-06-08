using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_App_DDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int round(float a)
        {
            return (int)(a + 0.5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Brush = Brushes.Black;
            var g = panel1.CreateGraphics();

            int x0, y0, xe, ye;
            x0 = int.Parse(box_x0.Text);
            y0 = int.Parse(box_y0.Text);
            xe = int.Parse(box_xe.Text);
            ye = int.Parse(box_ye.Text);
            int dx = xe - x0, dy = ye - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            g.FillRectangle(Brush, round(x), round(y), 2, 2);

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(Brush, round(x), round(y), 2, 2);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void x0_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.Silver);
        }
    }
}
