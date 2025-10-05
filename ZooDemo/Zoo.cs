using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ZooDemo.Animal;

namespace ZooDemo
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();




        public void Add(Animal animal)
        {
            animals.Add(animal);
        }

        public void PrintReport()
        {
            foreach(Animal animal in animals)
            {
                Console.WriteLine(animal.GetReportLine());
            }
        }

        public void ShowSpeciesCount()
        {
            int lions = Lion.Count;
            int parrot = Parrot.Count;

            Console.WriteLine($"The amount of Lions in the zoo are {lions}");
            Console.WriteLine($"The amount of Parrots in the zoo are {parrot}");
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
                    //Console.WriteLine($"{i+1}. {a.Info()}");
                    Console.WriteLine($"{i + 1}. {a}");
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
            foreach (Animal a in animals)
            {
                Console.WriteLine($"{a.Name} eats {a.DailyFoodKg()} kg");
            }
        }


        public void ShowTricks()
        {
            Console.WriteLine("Tricks");
            foreach (Animal a in animals)
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
            foreach (Animal a in animals)
            {
                ICanRun r = a as ICanRun;
                if (r != null)
                {
                    Console.WriteLine($"{a.Name} runs {r.CanRun()}");
                }
            }
        }

        public void CountDailyFoodConsumption()
        {
            double sum = 0;

            foreach (Animal a in animals)
            {
                sum += a.DailyFoodKg();
            }
            Console.WriteLine($"Total consumtion is: {sum}");
        }

        public Animal? FindByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }
            else
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    if (name.Equals(animals[i].Name))
                    {
                        return animals[i];
                    }

                }
                return null;
            }
        }

        public void ListByDiet(DietType diet)
        {
            foreach (Animal a in animals)
            {
                if (diet == a.Diet)
                {
                    Console.WriteLine(a.Name);
                }
            }

        }
        public void ListAllAnimalsByDiet()
        {
            Console.WriteLine("**Carnivors**");
            foreach (Animal a in animals)
            {
                if (DietType.Carnivore == a.Diet)
                {
                    Console.WriteLine(a.Name);
                }
            }
            Console.WriteLine("**Herbivore**");
            foreach (Animal a in animals)
            {
                if (DietType.Herbivore == a.Diet)
                {
                    Console.WriteLine(a.Name);
                }
            }
            Console.WriteLine("**Omnivore**");
            foreach (Animal a in animals)
            {
                if (DietType.Omnivore == a.Diet)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }

        public void ShowFlights()
        {
            Console.WriteLine("Flying Speed");
            foreach(Animal a in animals)
            {
                IFly f = a as IFly;
                if (f != null)
                {
                    Console.WriteLine($"{a.Name} flyes at {f.FlyspeedKmh()}");
                }
            }
        }


        public void ShowRunnersSorted()
        {
            Console.WriteLine("Speed List");
            List<(Animal a, double speed)> runlist = new List<(Animal a, double speed )>();
           
            foreach (Animal a in animals)
            {
                ICanRun r = a as ICanRun;
                if (r != null)
                {
                    double s = r.CanRun();
                    runlist.Add((a,s));
                }
            }
            runlist.Sort((x, y) => y.speed.CompareTo(x.speed));

            for(int i =0; i < runlist.Count; i++)
            {
                (Animal a, double speed) = runlist[i];
                Console.WriteLine($"{i+1}. {a.Name} - {speed} km/h ");
            }

        }

    }
}
