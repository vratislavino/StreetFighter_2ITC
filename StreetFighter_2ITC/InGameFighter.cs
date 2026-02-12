using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreetFighter_2ITC
{
    public partial class InGameFighter : UserControl
    {
        private int currentHp;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentHp
        {
            get { return currentHp; }
            set {
                currentHp = Math.Max(value, 0);
                progressBar1.Value = currentHp;
            }
        }

        private bool isPlaying;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPlaying
        {
            get { return isPlaying; }
            set { 
                isPlaying = value;
                BackColor = isPlaying ? Color.Yellow : Color.White;
            }
        }

        public InGameFighter()
        {
            InitializeComponent();
        }

        public void SetFighter(FighterModel model)
        {
            pictureBox1.BackgroundImage = model.Image;
            label2.Text = model.Name;
            label1.Text = $"{model.MaxHp}/{model.MaxHp}";
            progressBar1.Maximum = model.MaxHp;
            progressBar1.Value = model.MaxHp;
            currentHp = model.MaxHp;
        }
    }
}
