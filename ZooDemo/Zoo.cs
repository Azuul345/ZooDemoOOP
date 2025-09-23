using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooDemo
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();




        public void Add(Animal animal)
        {
            animals.Add(animal);
        }

        public void ListAll()
        {
            if (animals.Count == 0)
            {
                Console.WriteLine("No animals in the list");
                return;
            }
            else
            {
                Console.WriteLine("Animal List: ");

                for (int i = 0; i < animals.Count; i++)
                {
                    Animal a = animals[i];
                    Console.WriteLine($"{i+1}. {a.Info()}");
                }
            }
        }

        public void AllSpeak()
        {
            Console.WriteLine("Animal Speaks");

            foreach (Animal a in animals)
            {
                Console.WriteLine($"{a.Name}: {a.Speak()}");
            }
        }

        public void ShowFeedingPLan()
        {
            Console.WriteLine("Food Plan, KG/Day");
            foreach(Animal a in animals)
            {
                Console.WriteLine($"{a.Name} eats {a.DailyFoodKg()} kg");
            }
        }


        public void ShowTricks()
        {
            Console.WriteLine("Tricks");
            foreach(Animal a in animals)
            {
                ITrick t = a as ITrick;
                if (t != null)
                {
                    Console.WriteLine($"{a.Name} does {t.DoTrick()}");
                }
                else
                {
                    Console.WriteLine($"{a.Name} has no tricks");
                }
            }
        }

        public void ShowRunningSpeed()
        {
            Console.WriteLine("Speed capacity");
            foreach(Animal a in animals)
            {
                ICanRun r = a as ICanRun;
                if (r != null)
                {
                    Console.WriteLine($"{a.Name} runs {r.CanRUn()}");
                }
            }
        }

        public void CountDailyFoodConsumption()
        {
            double sum = 0;

            foreach(Animal a in animals)
            {
                sum += a.DailyFoodKg();
            }
            Console.WriteLine($"Total consumtion is: {sum}");
        }





    }
}
