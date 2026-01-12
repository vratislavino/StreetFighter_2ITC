using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFighter_2ITC
{
    public class FighterModel
    {
        public string Name { get; set; }

        public int MaxHp { get; set; }

        public int Dexterity { get; set; }

        public int Damage { get; set; }

        public int Speed { get; set; }

        public FighterModel()
        {
            Name ??= "Noname";
        }
    }
}
