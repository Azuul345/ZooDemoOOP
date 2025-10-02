using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    internal class Elephant : Animal, ITrick, ICanRun
    {
        public Elephant(string name, int age, int startHP, int maxHp) : base(name, age, startHP, maxHp)
        {
            Diet = DietType.Herbivore;
        }

        public override double DailyFoodKg()
        {
            return 25.0;
        }
        public string DoTrick()
        {
            return "a painting";
        }

        public override string Speak()
        {
            return "Trunck noise";
        }

        public double CanRUn()
        {
            return 1.5;
        }

    }
}
