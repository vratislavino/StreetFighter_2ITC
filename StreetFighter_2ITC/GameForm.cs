using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StreetFighter_2ITC
{
    public partial class GameForm : Form
    {
        private int secondsToStart = 3;

        FighterModel player;
        FighterModel opponent;

        InGameFighter currentFighter = null;
        GameState currentState = GameState.WaitingForMinigame;

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
            gameflowTimer.Start();
        }

        private void gameflowTimer_Tick(object sender, EventArgs e)
        {
            if (currentState == GameState.WaitingForMinigame)
            {
                secondsToStart--;
                if (secondsToStart == 0)
                {
                    currentState = GameState.PlayingMinigame;
                    gameflowTimer.Stop();
                    ChooseFighter();
                    StartRandomMinigame();
                }
            }
        }

        private void StartRandomMinigame() { 
            // choose random minigame
            // load minigame
            // start minigame
        }

        private void ChooseFighter()
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
    }
}
