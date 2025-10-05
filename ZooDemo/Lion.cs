using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Lion : Animal, ICanRun
    {
        public static int Count { get; private set; } = 0;


        public Lion(string name, int age, int startHP, int maxHp) : base(name, age, startHP, maxHp)
        {
            Diet = DietType.Carnivore;
            DietMultiplier = 7.5;
            Count++;
        }

        

        public override string Speak()
        {
            return "Roar";
        }

        public double CanRun()
        {
            return 5.5;
        }

       
    }
}
