using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace StreetFighter_2ITC
{

    public partial class GameForm : Form
    {
        private const int PREMINIGAME_TIMER = 3;
        private int secondsToStart = PREMINIGAME_TIMER;

        FighterModel player;
        FighterModel opponent;

        InGameFighter currentFighter = null;
        GameState currentState;

        Random generator = new Random();

        float damageMultiplier = 0.1f;

        List<Type> availableMinigames = new List<Type>();

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(FighterModel player, FighterModel opponent) : this()
        {
            this.player = player;
            this.opponent = opponent;

            playerFighter.SetFighter(player);
            opponentFighter.SetFighter(opponent);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            ChooseFirstFighter();
            ChangeGameState(currentFighter == opponentFighter ?
                GameState.EnemyTurn :
                GameState.WaitingForMinigame);

            LoadMinigameTypes();

            gameflowTimer.Start();
        }

        private void LoadMinigameTypes()
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            LoadMinigamesFromAssembly(ass);
        }

        private void LoadMinigamesFromAssembly(Assembly ass)
        {
            var types = ass.GetTypes().ToList();
            var filtered = types.Where(t => t.IsAssignableTo(typeof(IMinigame)) && !t.IsAbstract && t.IsClass);
            availableMinigames.AddRange(filtered);
            
            Debug.WriteLine(string.Join<Type>("\n", filtered));
        }

        private void gameflowTimer_Tick(object sender, EventArgs e)
        {
            if (currentState == GameState.WaitingForMinigame)
            {
                secondsToStart--;
                AddLog($"Minigame starts in {secondsToStart}");
                if (secondsToStart == 0)
                {
                    ChangeGameState(GameState.PlayingMinigame);
                    gameflowTimer.Stop();
                    StartRandomMinigame();
                }
            }

            if(currentState == GameState.EnemyTurn)
            {
                MockEnemyTurn();
            }
        }

        private int CalculateDamage(int baseDmg, int turnDamage) {
            return (int)(turnDamage * damageMultiplier * baseDmg);
        }

        private bool Dodged(int dexterity)
        {
            return generator.Next(0, 100) < dexterity;
        }

        private void MockEnemyTurn() {
            if (Dodged(player.Dexterity))
            {
                AddLog($"{player.Name} dodged!");
            }
            else {
                int damage = generator.Next(1, 9);
                int dmgToDeal = CalculateDamage(opponent.Damage, damage);
                playerFighter.CurrentHp -= dmgToDeal;
                AddLog($"{opponent.Name} damaged {player.Name} - {dmgToDeal} hp");
            }

            ChangeGameState(GameState.WaitingForMinigame);
            SwitchFighter();
            secondsToStart = PREMINIGAME_TIMER;
        }

        private IMinigame ChooseRandomMinigame()
        {
            int rand = generator.Next(0, availableMinigames.Count);
            Type typ = availableMinigames[rand];

            var minigame = (IMinigame)Activator.CreateInstance(typ);
            return minigame;
        }

        private void StartRandomMinigame() {

            IMinigame minigame = ChooseRandomMinigame();
            
            panel1.Controls.Add(minigame as UserControl);

            minigame.MinigameEnded += () =>
            {
                if (Dodged(opponent.Dexterity))
                {
                    AddLog($"{opponent.Name} dodged!");
                }
                else {
                    
                    int dmg = CalculateDamage(player.Damage, minigame.GetScore());
                    opponentFighter.CurrentHp -= dmg;
                    AddLog($"{player.Name} damaged {opponent.Name} - {dmg} hp");
                }
                
                (minigame as Control)?.Dispose();
                SwitchFighter();
                ChangeGameState(GameState.EnemyTurn);
                gameflowTimer.Start();
            };
            minigame.StartMinigame();

            // load minigame
            // start minigame
        }

        private void SwitchFighter() { 
            currentFighter.IsPlaying = false;
            currentFighter = currentFighter == playerFighter ? opponentFighter : playerFighter;
            currentFighter.IsPlaying = true;
        }

        private void ChooseFirstFighter()
        {
            Random r = new Random();
            int num = r.Next(0, player.Speed + opponent.Speed);
            
            if (currentFighter != null)
                currentFighter.IsPlaying = false;

            if (num < player.Speed)
            {
                currentFighter = playerFighter;
            } else
            {
                currentFighter = opponentFighter;
            }

            currentFighter.IsPlaying = true;
        }

        private void ChangeGameState(GameState gs) {
            currentState = gs;
            label1.Text = gs.ToString();
        }

        private void AddLog(string log)
        {
            richTextBox1.Text = log + "\n" + richTextBox1.Text;
        }
    }
}
