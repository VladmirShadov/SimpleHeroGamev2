using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHeroGamev2
{
    internal class Wizard : Hero, ISpecialAttack
    {
        public Wizard(string name, int fullhp, Colors color) : base(name, fullhp, color)
        {
        }

        public override void DefaultAttack(Hero hero)
        {
            int hp = rnd.Next(100, 151);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nGracz {Name} zadał {hp} obrażeń graczowi {hero.Name}.");
        }

        public override void Heal()
        {
            int hp = rnd.Next(100, 201);
            ActualHP += hp;
            Console.WriteLine($"\nGracz {Name} zregenerował życie o {hp} punktów zdrowia.");
        }

        public void SpecialAttack(Hero hero)
        {
            int hp = rnd.Next(200, 301);
            hero.ActualHP -= hp;
            Console.WriteLine($"\nAtak specjalny: Gracz {Name} zadał {hp} obrażeń graczowi {hero.Name}.");
        }
    }
}
