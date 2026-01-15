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

        public Image Image { get; set; }

        public FighterModel()
        {
            Name ??= "Noname";
            Image ??= new Bitmap(100, 100);
        }

        public void LoadImage()
        {
            if (File.Exists($"fighters/{Name}.png"))
            {
                try
                {
                    Image = Image.FromFile($"fighters/{Name}.png");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Chyba při načítání obrázku pro {Name}: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Nepodařilo se najít obrázek pro {Name}");
            }
        }
    }
}
