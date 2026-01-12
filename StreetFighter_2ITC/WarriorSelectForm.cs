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

            fighterSelectOverview1.SetFighter(availableFighters.First());
        }
    }
}
