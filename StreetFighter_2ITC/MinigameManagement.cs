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
    public partial class MinigameManagement : Form
    {
        MinigameLoader loader;

        public MinigameManagement()
        {
            InitializeComponent();
        }

        public MinigameManagement(MinigameLoader loader) : this()
        {
            this.loader = loader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                try
                {
                    loader.LoadMinigamesFromFile(openFileDialog1.FileName);
                    UpdateMinigameList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading minigame: {ex.Message}");
                }
            }
        }

        private void UpdateMinigameList()
        {
            checkedListBox1.Items.Clear();
            foreach (var mg in MinigameLoader.AllMinigames)
            {
                checkedListBox1.Items.Add(mg.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MinigameLoader.LoadedMinigames = MinigameLoader.AllMinigames.Where(mg => checkedListBox1.CheckedItems.Contains(mg.Name)).ToList();
        }

        private void MinigameManagement_Load(object sender, EventArgs e)
        {
            UpdateMinigameList();
        }
    }
}
