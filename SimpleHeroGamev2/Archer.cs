using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHeroGamev2
{
    internal class Archer : Hero
    {
        public Archer(string name, int fullhp, Colors color) : base(name, fullhp, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(75, 151);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz {Name} zadał {hp} obrażeń graczowi {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(75, 151);
            ActualHP += hp;
            Console.WriteLine($"\nGracz {Name} zregenerował życie o {hp} punktów zdrowia.");
        }
    }
}
