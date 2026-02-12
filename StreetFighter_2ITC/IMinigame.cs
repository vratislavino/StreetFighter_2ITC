using System;
using System.Collections.Generic;
using System.Text;

namespace StreetFighter_2ITC
{
    public interface IMinigame
    {
        event Action MinigameEnded;

        int GetScore();

        void StartMinigame();
    }
}
