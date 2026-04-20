using System;
using System.Collections.Generic;
using System.Text;

namespace SF_BaseTypesControls
{
    public interface IMinigame
    {
        event Action MinigameEnded;

        int GetScore();

        void StartMinigame();
    }
}
