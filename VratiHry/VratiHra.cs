using SF_BaseTypesControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VratiHry
{
    public partial class VratiHra : TimedMinigame
    {
        Label label;
        public VratiHra()
        {
            InitializeComponent();
            Click += VratiHra_Click;

            label = new Label();
            Controls.Add(label);
            label.Location = new Point(50, 50);
        }

        private void VratiHra_Click(object? sender, EventArgs e)
        {
            score++;
            if(score > 8)
                score = 8;

            label.Text = score.ToString();
        }
    }
}
