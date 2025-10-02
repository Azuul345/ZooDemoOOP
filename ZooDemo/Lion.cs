using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Lion : Animal, ICanRun
    {
        public Lion(string name, int age, int startHP, int maxHp) : base(name, age, startHP, maxHp)
        {
            Diet = DietType.Carnivor;
        }

        public override double DailyFoodKg()
        {
            return 7.5;
        }

        public override string Speak()
        {
            return "Roar";
        }

        public double CanRUn()
        {
            return 5.5;
        }

       
    }
}
