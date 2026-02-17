using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreetFighter_2ITC
{
    public partial class CircleMinigame : UserControl, IMinigame
    {
        private int score;
        private int x, y;
        private float size;

        private const int MAX_SCORE = 8;
        private const int BASE_SIZE = 100;

        private float sizeDecay = 0.5f;

        private System.Windows.Forms.Timer timer;
        Random generator = new Random();

        public CircleMinigame()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += OnTick;
        }

        public event Action MinigameEnded;

        public int GetScore()
        {
            return score;
        }

        public void StartMinigame()
        {
            score = 0;
            timer.Start();
            CreateCircle();
        }

        private void CreateCircle() {
            x = generator.Next(0, Width - BASE_SIZE);
            y = generator.Next(0, Height - BASE_SIZE);
            size = BASE_SIZE;
            Invalidate();
        }

        private void OnTick(object sender, EventArgs e)
        {
            size -= sizeDecay;
            if (size < 0)
            {
                GameOver();
            }
            Invalidate();
        }

        private void CircleMinigame_Paint(object sender, PaintEventArgs e) {
            e.Graphics.FillEllipse(
                Brushes.DarkMagenta, 
                x - size / 2, 
                y - size / 2, 
                size, 
                size);
        }

        private void CircleMinigame_MouseClick(object sender, MouseEventArgs e)
        {
            double dist = Math.Sqrt(Math.Pow(e.X - x, 2) + Math.Pow(e.Y - y, 2));
            if(dist < size / 2)
            {
                score++;
                if (score == MAX_SCORE) { 
                    GameOver();
                    return;
                }

                sizeDecay += 0.2f;
                CreateCircle();
            } else
            {
                GameOver();
            }
        }

        private void GameOver() {
            timer.Stop();
            MinigameEnded?.Invoke();
        }
    }
}
