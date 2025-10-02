using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    internal class Parrot : Animal, ITrick, IFly
    {
        public Parrot(string name, int age, int startHP, int maxHp) : base(name, age, startHP, maxHp)
        {
            Diet = DietType.Omnivore;
        }

        public override double DailyFoodKg()
        {
            return 0.2;
        }

        public string DoTrick()
        {
            return "vissla melodi";
        }

        public override string Speak()
        {
            return "Squeek";
        }

        public double FlyspeedKmh()
        {
            return 50.5;
        }

        
        
    }
}
