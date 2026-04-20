using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF_BaseTypesControls;

namespace StreetFighter_2ITC
{
    public partial class EscapeMinigame : TimedMinigame
    {
        List<Point> circles = new List<Point>();
        int size = 0;
        int aliveFor = 0;
        int speed = 2;
        public EscapeMinigame()
        {
            InitializeComponent();
        }

        protected override void timer1_Tick(object sender, EventArgs e)
        {
            base.timer1_Tick(sender, e);
            aliveFor += timer1.Interval;
            if (aliveFor / 1000f > score)
            {
                score++;
                speed++;
            }
            size += speed;
            TestCursor();
        }

        protected override void TimedMinigame_Paint(object sender, PaintEventArgs e)
        {
            base.TimedMinigame_Paint(sender, e);
            foreach (Point p in circles)
            {
                e.Graphics.FillEllipse(Brushes.Black, p.X - size / 2, p.Y - size / 2, size, size);
            }
        }

        public override void StartMinigame()
        {
            base.StartMinigame();
            Random r = new Random();
            for (int i = 0; i < 4; i++)
            {
                circles.Add(new Point(
                    r.Next(0, Width),
                    r.Next(0, Height)
                    ));
            }

        }

        private void TestCursor()
        {
            var rect = this.DisplayRectangle;
            Point relativePoint = this.PointToClient(Cursor.Position);

            if (!rect.Contains(relativePoint))
                GameOver();

            for (int i = 0; i < circles.Count; i++)
            {
                bool dead = TestCircle(circles[i], relativePoint);
                if (dead)
                {
                    GameOver();
                    break;
                }
            }
        }

        private bool TestCircle(Point p, Point mp)
        {
            int a = p.X - mp.X;
            int b = p.Y - mp.Y;
            var c = Math.Sqrt(a * a + b * b);
            return c < size / 2;
        }

        private void EscapeMinigame_Load(object sender, EventArgs e)
        {
            TestCursor();
        }
    }
}
