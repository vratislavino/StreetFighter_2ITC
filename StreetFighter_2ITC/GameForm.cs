using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreetFighter_2ITC
{
    // TODO: Check jaký fighter svítí jako aktuální

    public partial class GameForm : Form
    {
        private const int PREMINIGAME_TIMER = 3;
        private int secondsToStart = PREMINIGAME_TIMER;

        FighterModel player;
        FighterModel opponent;

        InGameFighter currentFighter = null;
        GameState currentState;

        Random generator = new Random();

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

            gameflowTimer.Start();
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

        private void MockEnemyTurn() {
            int damage = generator.Next(1, 9);
            playerFighter.CurrentHp -= damage;
            AddLog($"{opponent.Name} damaged {player.Name} - {damage} hp");

            ChangeGameState(GameState.WaitingForMinigame);
            secondsToStart = PREMINIGAME_TIMER;
        }

        private void StartRandomMinigame() {
            // choose random minigame - later
            
            CircleMinigame minigame = new CircleMinigame();
            panel1.Controls.Add(minigame);

            minigame.MinigameEnded += () =>
            {
                opponentFighter.CurrentHp -= minigame.GetScore();
                AddLog($"{player.Name} damaged {opponent.Name} - {minigame.GetScore()} hp");
                minigame.Dispose();
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
