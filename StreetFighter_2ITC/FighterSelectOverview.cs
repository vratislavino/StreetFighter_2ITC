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
    public partial class FighterSelectOverview : UserControl
    {
        public FighterSelectOverview()
        {
            InitializeComponent();
        }

        public void SetFighter(FighterModel model)
        {
            label1.Text = model.Name;
            label2.Text = $"HP: {model.MaxHp}";
            label3.Text = $"Dexterity: {model.Dexterity}";
            label4.Text = $"Damage: {model.Damage}";
            label5.Text = $"Speed: {model.Speed}";

            pictureBox1.BackgroundImage = model.Image;
        }
    }
}
