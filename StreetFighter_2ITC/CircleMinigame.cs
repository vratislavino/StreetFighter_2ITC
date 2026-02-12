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
        public CircleMinigame()
        {
            InitializeComponent();
        }

        public event Action MinigameEnded;

        public int GetScore()
        {
            throw new NotImplementedException();
        }

        public void StartMinigame()
        {
            throw new NotImplementedException();
        }
    }
}
