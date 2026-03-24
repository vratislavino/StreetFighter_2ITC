using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreetFighter_2ITC
{
    public partial class OrderMinigame : TimedMinigame
    {
        List<Point> points = new List<Point>();
        Random generator = new Random();
        int correct = -1;

        const int POINT_SIZE = 24;

        public OrderMinigame()
        {
            InitializeComponent();
        }

        public override void StartMinigame()
        {
            base.StartMinigame();
            AddPoint();
        }

        private void AddPoint()
        {
            points.Add(new Point(
                generator.Next(0, Width),
                generator.Next(0, Height)
                ));
        }

        protected override void TimedMinigame_Paint(object sender, PaintEventArgs e)
        {
            base.TimedMinigame_Paint(sender, e);
            DrawPoints(e.Graphics);
        }

        private void DrawPoints(Graphics g)
        {
            for (int i = 0; i < points.Count; i++)
            {
                g.FillEllipse(i <= correct ? Brushes.Green : Brushes.Red,
                    points[i].X - POINT_SIZE / 2,
                    points[i].Y - POINT_SIZE / 2,
                    POINT_SIZE,
                    POINT_SIZE);
            }
        }

        private void OrderMinigame_MouseDown(object sender, MouseEventArgs e)
        {
            Point currentTarget = points[correct + 1];
            double dist = Math.Sqrt(Math.Pow((currentTarget.X - e.X), 2) +
                Math.Pow((currentTarget.Y - e.Y), 2));

            if(dist < POINT_SIZE)
            {
                correct++;
                if(correct == points.Count - 1)
                {
                    score++;
                    if(score >= 10)
                    {
                        GameOver();
                    }
                    maxTime *= 1.2f;
                    remainingTime = maxTime;
                    AddPoint();
                    correct = -1;
                }
            }
            else
            {
                GameOver();
            }

        }
    }
}
