using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    internal class Parrot : Animal, ITrick
    {
        public Parrot(string name, int age, int startHP) : base(name, age, startHP)
        {

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
    }
}
