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
    public abstract partial class TimedMinigame : UserControl, IMinigame
    {
        public event Action MinigameEnded;

        protected int score;

        protected float maxTime = 5f;
        protected float remainingTime;

        public TimedMinigame()
        {
            InitializeComponent();
        }

        public virtual void StartMinigame()
        {
            remainingTime = maxTime; 
            timer1.Start();
        }

        public int GetScore()
        {
            return score;
        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime -= timer1.Interval / 1000f;

            if (remainingTime <= 0)
                GameOver();

            Invalidate();
        }

        protected virtual void TimedMinigame_Paint(object sender, PaintEventArgs e)
        {
            PaintRemainingTime(e.Graphics);
        }

        protected void GameOver()
        {
            timer1.Stop();
            MinigameEnded?.Invoke();
        }

        private void PaintRemainingTime(Graphics g)
        {
            g.FillRectangle(
                Brushes.DarkKhaki,
                0,
                Height - 40,
                (remainingTime / maxTime) * Width,
                40);
        }
    }
}
