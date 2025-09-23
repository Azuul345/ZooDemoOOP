﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public abstract class Animal
    {
        public static int TotalCount = 0;
        private int hp;


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
                else 
                {
                    hp = value;
                }
            }
        }

        protected Animal(string name, int age, int startHP)
        {
            Name = name;
            Age = age;
            HP = startHP;

            TotalCount++;
            
        }

        //has to be overwriten and has no body
        public abstract string Speak();


        public virtual double DailyFoodKg()
        {
            return 1.0;
        }
        
        public string Info()
        {
            return $"{Name}: Age: {Age}, HP: {HP}";
        }

        public override string ToString()
        {
            return Info() + " blablabla";
        }



    }
}
