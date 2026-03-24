using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreetFighter_2ITC
{
    public partial class LetterMinigame : TimedMinigame
    {
        string text = "ASDFG";
        string doneText = "";

        public LetterMinigame()
        {
            InitializeComponent();
        }

        public override void StartMinigame()
        {
            base.StartMinigame();
            GenerateText(6);
            Focus();
        }

        protected override void TimedMinigame_Paint(object sender, PaintEventArgs e)
        {
            base.TimedMinigame_Paint(sender, e);
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
