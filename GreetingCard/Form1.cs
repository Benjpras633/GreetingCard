using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)

        {   SolidBrush Textbrush = new SolidBrush(Color.FromArgb(157, 207, 182));
            Graphics g = this.CreateGraphics();
            Pen PathPen = new Pen(Color.Blue, 20);
            Pen EggPen = new Pen(Color.Pink, 20);

            Font Font1 = new Font("Zurich UBlkEx BT", 46);
            SolidBrush Whitebrush = new SolidBrush(Color.White);
            SolidBrush Pinkbrush = new SolidBrush(Color.Pink);
            SolidBrush lightbluebrush = new SolidBrush(Color.LightBlue);
            Pen Darkblue = new Pen(Color.DarkBlue, 10);



            //FrontCard
            g.Clear(Color.FromArgb(157, 207, 182));
            g.DrawString("HaPpY \nEaSter!", Font1, Whitebrush, 180, 115);
            g.RotateTransform(20);
            g.FillEllipse(Pinkbrush, 420, 99, 50, 70);
            g.ResetTransform();

            //Egg1
            g.FillEllipse(Whitebrush, 380, 280, 10, 10);
            g.FillEllipse(Whitebrush, 360, 290, 10, 10);
            g.FillEllipse(Whitebrush, 380, 260, 10, 10);
            g.FillEllipse(Whitebrush, 360, 260, 10, 10);
            g.FillEllipse(Whitebrush, 360, 275, 10, 10);

            //Egg2
            g.RotateTransform(20);
            g.FillEllipse(lightbluebrush, 200, 99, 50, 70);
           
            g.DrawLine(Darkblue, 200, 131, 250, 130);
            g.FillEllipse(Whitebrush, 200, 125, 10, 10);
            g.FillEllipse(Whitebrush, 213, 125, 10, 10);
            g.FillEllipse(Whitebrush, 226, 125, 10, 10);
            g.FillEllipse(Whitebrush, 239, 125, 10, 10);









        }

        private void Form1_Click(object sender, EventArgs e)

        {
            Graphics g = this.CreateGraphics();
            Font Font1 = new Font("Zurich UBlkEx BT", 20);
            SolidBrush Whitebrush = new SolidBrush(Color.White);
            SolidBrush Blackbrush = new SolidBrush(Color.Black);
            Pen EggPen = new Pen(Color.White, 20);
            Pen Egg2Pen = new Pen(Color.Black, 20);
            SolidBrush Pinkbrush = new SolidBrush(Color.Pink);
            SolidBrush lightbluebrush = new SolidBrush(Color.LightBlue);

            //Text
            g.Clear(Color.LightGreen);
            g.DrawString("May Your Easter Basket Be Full Of \nJoy, Happiness,Peace,\n And Easter Eggs", Font1, Whitebrush, 50, 70);

            //EggBasket
            g.FillPie(Blackbrush, 15, 220, 220, 200, 0, 180);
            g.DrawEllipse(Egg2Pen, 25, 260 , 200, 100);
            g.FillEllipse(Blackbrush, 25, 260, 200, 100);
            g.DrawArc(Egg2Pen, 25, 200, 200, 200, 180, 180);

            //Eggs
            g.FillEllipse(Pinkbrush, 420, 99, 50, 70);
            g.FillEllipse(lightbluebrush, 200, 99, 50, 70);
            g.Clear(Color.LightGreen);
            Thread.Sleep(2000);
            g.DrawString("May Your Easter Basket Be Full Of \nJoy, Happiness,Peace,\n And Easter Eggs", Font1, Whitebrush, 50, 70);

            //EggBasket
            g.FillPie(Blackbrush, 15, 220, 220, 200, 0, 180);
            g.DrawEllipse(Egg2Pen, 25, 260, 200, 100);
            g.FillEllipse(Blackbrush, 25, 260, 200, 100);
            g.DrawArc(Egg2Pen, 25, 200, 200, 200, 180, 180);






        }
    }
}
