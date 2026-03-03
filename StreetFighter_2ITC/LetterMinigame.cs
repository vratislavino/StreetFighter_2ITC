using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreetFighter_2ITC
{
    public partial class LetterMinigame : UserControl, IMinigame
    {
        public event Action MinigameEnded;
        private int score;

        float maxTime = 5f;
        float remainingTime;

        System.Windows.Forms.Timer timer;

        string text = "ASDFG";
        string doneText = "";

        public LetterMinigame()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 17; // ~60 FPS
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime -= timer.Interval / 1000f;
            
            if (remainingTime <= 0) 
                GameOver();
            
            Invalidate();
        }

        private void GameOver()
        {
            timer.Stop();
            MinigameEnded?.Invoke();
        }

        public int GetScore()
        {
            return score;
        }

        public void StartMinigame()
        {
            remainingTime = maxTime;
            GenerateText(6);
            Focus();
        }

        private void LetterMinigame_Paint(object sender, PaintEventArgs e)
        {
            PaintRemainingTime(e.Graphics);
            PaintText(e.Graphics);
        }

        private void PaintText(Graphics g)
        {
            g.DrawString(
                text, 
                new Font(FontFamily.GenericSansSerif, 30f), 
                Brushes.DarkBlue,
                100, 
                Height / 2 - 40);
            g.DrawString(doneText, 
                new Font(FontFamily.GenericSansSerif, 30f),
                Brushes.GreenYellow,
                100,
                Height / 2);
        }

        private void PaintRemainingTime(Graphics g) {
            g.FillRectangle(
                Brushes.DarkKhaki, 
                0, 
                Height - 40, 
                (remainingTime/maxTime) * Width, 
                40);
        }

        private void LetterMinigame_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show($"Key pressed: {e.KeyCode}");

            string letter = e.KeyCode.ToString();
            if(letter.Length == 1) {
                doneText += letter;
                CheckText();
            }
        }

        private void GenerateText(int length)
        {
            text = doneText = "";
            Random rand = new Random();
            for(int i = 0; i < length; i++)
            {
                char letter = (char)rand.Next('A', 'Z' + 1);
                text += letter;
            }
        }

        private void CheckText()
        {
            if(!text.StartsWith(doneText))
            {
                GameOver();
            } else
            {
                if(doneText.Length == text.Length)
                {
                    score++;
                    if (score >= 10)
                        GameOver();
                    GenerateText(6);

                    maxTime *= 0.9f;
                    remainingTime = maxTime;
                }
            }
        }
    }
}
