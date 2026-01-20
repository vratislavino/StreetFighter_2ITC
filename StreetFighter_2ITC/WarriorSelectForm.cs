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

        public WarriorSelectForm()
        {
            InitializeComponent();
        }

        private void WarriorSelectForm_Load(object sender, EventArgs e)
        {
            availableFighters.ForEach(f => f.LoadImage());

            CreateFighterThumbnails();

            fighterSelectOverview1.SetFighter(availableFighters.First());
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


            fighterSelectOverview1.SetFighter(model);
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var enemyIndex = rand.Next(0, availableFighters.Count);
            fighterSelectOverview2.SetFighter(availableFighters[enemyIndex]);
        }
    }
}
