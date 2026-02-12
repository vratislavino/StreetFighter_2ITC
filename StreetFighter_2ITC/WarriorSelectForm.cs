namespace StreetFighter_2ITC
{
    public partial class WarriorSelectForm : Form
    {
        List<FighterModel> availableFighters = new List<FighterModel>()
        {
            new FighterModel() {
                Name = "Ryu",
                MaxHp = 100,
                Dexterity = 15,
                Damage = 20,
                Speed = 10
            },
            new FighterModel() { Name = "Chun-Li", MaxHp = 90, Dexterity = 20, Damage = 15, Speed = 15 },
            new FighterModel() { Name = "Guile", MaxHp = 110, Dexterity = 10, Damage = 25, Speed = 8 }
        };

        int currentFighter = -1;
        int enemyFighter = -1;

        public WarriorSelectForm()
        {
            InitializeComponent();
        }

        private void WarriorSelectForm_Load(object sender, EventArgs e)
        {
            availableFighters.ForEach(f => f.LoadImage());

            CreateFighterThumbnails();

            OnFighterSelected(availableFighters.First());
        }

        private void CreateFighterThumbnails()
        {
            foreach (var f in availableFighters)
            {
                FighterSelectThumbnail fst = new FighterSelectThumbnail();
                fst.SetFighter(f);
                fst.FighterSelected += OnFighterSelected;
                flowLayoutPanel1.Controls.Add(fst);
            }
        }

        private void OnFighterSelected(FighterModel model)
        {
            foreach (var c in flowLayoutPanel1.Controls)
            {
                if (c is FighterSelectThumbnail fst)
                {
                    (c as FighterSelectThumbnail).IsSelected = false;
                }
            }

            currentFighter = availableFighters.IndexOf(model);
            fighterSelectOverview1.SetFighter(model);
        }
        
        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (currentFighter == -1) {
                MessageBox.Show("You dont have fighter!");
                return;
            }

            if (enemyFighter == -1) {
                button1_Click(null, null);
            }

            GameForm gf = new GameForm(
                availableFighters[currentFighter],
                availableFighters[enemyFighter]
                );
            gf.Show();
            
            this.Hide();

            gf.FormClosing += (s, evt) => {
                this.Show();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int enemyIndex = -1;
            Random rand = new Random();
            
            do
            {
                enemyIndex = rand.Next(0, availableFighters.Count);
            } while (enemyIndex == currentFighter);

            enemyFighter = enemyIndex;
            fighterSelectOverview2.SetFighter(availableFighters[enemyIndex]);
        }
    }
}
