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
    public partial class FighterSelectThumbnail : UserControl
    {
        public event Action<FighterModel> FighterSelected;

        FighterModel fighterModel;
        private bool isSelected = false;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.BackColor = isSelected ? Color.Yellow : Color.Olive;
            }
        }

        public FighterSelectThumbnail()
        {
            InitializeComponent();
        }

        public void SetFighter(FighterModel model)
        {
            fighterModel = model;
            label1.Text = model.Name;
            pictureBox1.BackgroundImage = model.Image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FighterSelected?.Invoke(fighterModel);
            IsSelected = true;
        }
    }
}
