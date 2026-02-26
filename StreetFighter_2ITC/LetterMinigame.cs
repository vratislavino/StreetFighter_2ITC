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
        public LetterMinigame()
        {
            InitializeComponent();
        }

        public int GetScore()
        {
            return score;
        }

        public void StartMinigame()
        {
            throw new NotImplementedException();
        }
    }
}
