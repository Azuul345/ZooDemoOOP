using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    internal class Elephant : Animal, ITrick
    {
        public Elephant(string name, int age, int startHP) : base(name, age, startHP)
        {
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
    }
}
