using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;

namespace SunSystem
{
    public partial class Form1 : Form
    {
        public double fullW, fullH, dt = 0, G, MSun, r, V0, speed, rad = 15, per = 1,
            x0, y0, a0 = 0.4, b0 = 0.39, t0 = 20, dt0,
            x1, y1, a1 = 0.72, b1 = 0.72, t1 = -19, dt1,
            x2, y2, a2 = 1.009, b2 = 1, t2 = 23.9, dt2,
            x3, y3, a3 = 1.53, b3 = 1.52, t3 = 24.6, dt3,
            x4, y4, a4 = 5.2, b4 = 5.2, t4 = 9.9, dt4,
            x5, y5, a5 = 9.56, b5 = 9.55, t5 = 10.7, dt5,
            x6, y6, a6 = 19.24, b6 = 19.22, t6 = -17.2, dt6,
            x7, y7, a7 = 23, b7 = 23, t7 = 16.1, dt7,
            p0 = 282, p1 = 252, p2 = 221, p3 = 190, p4 = 156, p5 = 130, p6 = 410, p7 = 56;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            dt0 = 0;
            dt1 = 0;
            dt2 = 0;
            dt3 = 0;
            dt4 = 0;
            dt5 = 0;
            dt6 = 0;
            dt7 = 0;
            Graphics g = pictureBox1.CreateGraphics();
            fullW = pictureBox1.ClientSize.Width;
            fullH = pictureBox1.ClientSize.Height;
            g.FillRectangle(Brushes.White, 0, 0, Convert.ToInt32(fullW), Convert.ToInt32(fullH));
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                speed = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                textBox1.Text = Convert.ToString("PLS");
            }

            dt0 -= 2 * PI / t0 * speed;
            dt1 -= 2 * PI / t1 * speed;
            dt2 -= 2 * PI / t2 * speed;
            dt3 -= 2 * PI / t3 * speed;
            dt4 -= 2 * PI / t4 * speed;
            dt5 -= 2 * PI / t5 * speed;
            dt6 -= 2 * PI / t6 * speed;
            dt7 -= 2 * PI / t7 * speed;
            PlanetMove();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox1.BackColor = Color.White;
            
            
        }
        private void PlanetMove()
        {
            Graphics g = pictureBox1.CreateGraphics();
            fullW = pictureBox1.ClientSize.Width;
            fullH = pictureBox1.ClientSize.Height;
            Pen Pen1 = new Pen(Color.Orange, 1);
            g.DrawLine(Pen1, Convert.ToInt32(Round(fullW / 2)), 0, Convert.ToInt32(Round(fullW / 2)), Convert.ToInt32(Round(fullH)));
            g.DrawLine(Pen1, 0, Convert.ToInt32(Round(fullH / 2)), Convert.ToInt32(Round(fullW)), Convert.ToInt32(Round(fullH / 2)));

            checkedListBox1.CheckOnClick = true;
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                x0 = (fullW/2 - p0) * per + Convert.ToInt32(Round(fullW / 2 * 0.9)) - Round(a0 * rad * Cos(dt0));
                y0 = Convert.ToInt32(Round(fullH / 2)) + Round(b0 * rad * Sin(dt0));
                g.FillEllipse(Brushes.DarkGray, Convert.ToInt32(x0), Convert.ToInt32(y0), 2, 2);
            }
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                x1 = (fullW/2 - p1) * per + Convert.ToInt32(Round(fullW / 2 * 0.8)) - Round(a1 * rad * Cos(dt1));
                y1 = Convert.ToInt32(Round(fullH / 2)) + Round(b1 * rad * Sin(dt1));
                g.FillEllipse(Brushes.YellowGreen, Convert.ToInt32(x1), Convert.ToInt32(y1), 2, 2);
                
            }
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked)
            {
                x2 = (fullW/2 - p2) * per + Convert.ToInt32(Round(fullW / 2 * 0.7)) - Round(a2 * rad * Cos(dt2));
                y2 = Convert.ToInt32(Round(fullH / 2)) + Round(b2 * rad * Sin(dt2));
                g.FillEllipse(Brushes.LightSkyBlue, Convert.ToInt32(x2), Convert.ToInt32(y2), 2, 2);
            }
            if (checkedListBox1.GetItemCheckState(3) == CheckState.Checked)
            {
                x3 = (fullW/2 - p3) * per + Convert.ToInt32(Round(fullW / 2 * 0.6)) - Round(a3 * rad * Cos(dt3));
                y3 = Convert.ToInt32(Round(fullH / 2)) + Round(b3 * rad * Sin(dt3));
                g.FillEllipse(Brushes.OrangeRed, Convert.ToInt32(x3), Convert.ToInt32(y3), 2, 2);
            }
            if (checkedListBox1.GetItemCheckState(4) == CheckState.Checked)
            {
                x4 = (fullW/2 - p4) * per + Convert.ToInt32(Round(fullW / 2 * 0.5)) - Round(a4 * rad * Cos(dt4));
                y4 = Convert.ToInt32(Round(fullH / 2)) + Round(b4 * rad * Sin(dt4));
                g.FillEllipse(Brushes.Orange, Convert.ToInt32(x4), Convert.ToInt32(y4), 3, 3);
            }
            if (checkedListBox1.GetItemCheckState(5) == CheckState.Checked)
            {
                x5 = (fullW/2 - p5) * per + Convert.ToInt32(Round(fullW / 2 * 0.4)) - Round(a5 * rad * Cos(dt5));
                y5 = Convert.ToInt32(Round(fullH / 2)) + Round(b5 * rad * Sin(dt5));
                g.FillEllipse(Brushes.BlueViolet, Convert.ToInt32(x5), Convert.ToInt32(y5), 3, 3);
            }
            if (checkedListBox1.GetItemCheckState(6) == CheckState.Checked)
            {
                x6 = (fullW - p6) * per + Convert.ToInt32(Round(fullW / 2 * 0.3)) - Round(a6 * rad * Cos(dt6));
                y6 = Convert.ToInt32(Round(fullH / 2)) + Round(b6 * rad * Sin(dt6));
                g.FillEllipse(Brushes.DeepSkyBlue, Convert.ToInt32(x6), Convert.ToInt32(y6), 4, 4);
            }
            if (checkedListBox1.GetItemCheckState(7) == CheckState.Checked)
            {
                x7 = (fullW/2 - p7) * per + Convert.ToInt32(Round(fullW / 2 * 0.2)) - Round(a7 * rad * Cos(dt7));
                y7 = Convert.ToInt32(Round(fullH / 2)) + Round(b7 * rad * Sin(dt7));
                g.FillEllipse(Brushes.Blue, Convert.ToInt32(x7), Convert.ToInt32(y7), 4, 4);
            }
            
        }
    }
}
