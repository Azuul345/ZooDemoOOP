using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public abstract class Animal
    {
        protected double DietMultiplier = 1;

        public static int TotalCount = 0;
        private int hp;
        private int _maxHP;

        public string Name { get; private set; }
        public int Age { get; private set; } //can only be changes withing the class with private


      
        public int HP 
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0)
                {
                    hp = 0;
                }
                else if(value > _maxHP)
                {
                    hp = _maxHP;
                }
                else
                {
                    hp = value;
                }
            }
        }
        public enum DietType { Carnivore, Herbivore, Omnivore}

        public DietType Diet { get ; protected set; }


        protected Animal(string name, int age, int startHP, int maxHp)
        {
            Name = name;
            Age = age;
            _maxHP = maxHp;
            HP = startHP;
            

            TotalCount++;
            
        }

        

        //has to be overwriten and has no body
        public abstract string Speak();

        //can be overwritten and has a body
        public virtual double DailyFoodKg()
        {
            return 1.0 * DietMultiplier;
        }
        
        public string Info()
        {
            return $"{Name}: Age: {Age}, HP: {HP}";

        }
        

        public override string ToString()
        {
            return Info() + " blablabla";
        }

        public int Heal(int amount)
        {
            HP += amount;
            return HP;
        }

        public int BirthDay()
        {
            return ++Age;
        }

        public string GetReportLine()
        {
            return $"{Name} - Age {Age}; Health {HP}; Daily Food Consumption {DailyFoodKg()} kg";
        }


    }
}
