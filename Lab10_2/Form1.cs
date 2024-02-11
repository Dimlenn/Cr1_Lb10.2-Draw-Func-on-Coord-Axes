using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int xc = this.Width / 2;
            int yc = this.Height / 2;
            g.TranslateTransform(xc, yc);
            g.DrawEllipse(new Pen(Color.Red, 6.0f), 0, 0, 1, 1);
            //вычерчивание осей координат
            g.DrawLine(new Pen(Color.Brown, 1.0f), -250, 0, 250, 0);
            g.DrawLine(new Pen(Color.Brown, 1.0f), 0, -250, 0, 250);

            g.DrawLine(new Pen(Color.Brown, 1.0f), 250, 0, 250 - 10, -10);
            g.DrawLine(new Pen(Color.Brown, 1.0f), 250, 0, 250 - 10, 10);

            g.DrawLine(new Pen(Color.Brown, 1.0f), 0, -250, -10, -250 + 10);
            g.DrawLine(new Pen(Color.Brown, 1.0f), 0, -250, 10, -250 + 10);


            int k = 50;
            Font font = new Font("Times New Roman", 8);
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 1);
            int i1 = 5;

            g.DrawString("0", font, brush, -15, 10);

            for (double i = 1; i <= 4; i++)
            {
                g.DrawLine(pen, (int)i * k, -5, (int)i * k, 5);
                g.DrawString((i1).ToString("0.00"), font, brush, (int)i * k - 10, 10);
                i1 += 5;
            }
            i1 = 5;
            for (double i = -1; i >= -4; i--)
            {
                g.DrawLine(pen, (int)i * k, -5, (int)i * k, 5);
                g.DrawString((-i1).ToString("0.00"), font, brush, (int)i * k - 15, 10);
                i1 += 5;
            }
            i1 = 5;
            for (double i = 1; i <= 4; i++)
            {
                g.DrawLine(pen, -4, (int)i * k, 5, (int)i * k);
                g.DrawString((-i1).ToString(), font, brush, -20, (int)i * k);
                i1 += 5;
            }
            i1 = 5;
            for (double i = -1; i >= -4; i--)
            {
                g.DrawLine(pen, -5, (int)i * k, 5, (int)i * k);
                g.DrawString((i1).ToString(), font, brush, -20, (int)i * k);
                i1 += 5;
            }

            float x, y;
            int a = 5, b = 20;
            float c = Math.Abs(a - b);
            for (int i = 0; i <= 40; i += 1)
            {
                x = a + (i * c / 40);
                y = x * x - 18 * x + 72;
                g.DrawEllipse(new Pen(Color.Blue, 2.0f),
                10 * x, 2*y, 1, 1);
                //g.DrawEllipse(new Pen(Color.Blue, 2.0f),
                //10 * x, 0, 1, 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
