namespace ZooDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Animal Simba = new Lion("Simba", 10,100,110);
            Animal Nala = new Lion("Nala", 10, 80, 80);
            Animal Zazoo = new Parrot("Zazoo", 1, 40, 50);
            Animal Dumbo = new Elephant("Dumbo", 3, 80, 90);

            zoo.Add(Simba);
            zoo.Add(Zazoo);
            zoo.Add(Dumbo);
            zoo.Add(Nala);
            //Console.WriteLine($"total anaimals: {Animal.TotalCount}");

            zoo.ListAll();

            Console.WriteLine(Simba.DailyFoodKg());
            Console.WriteLine(Zazoo.DailyFoodKg());
            zoo.ShowSpeciesCount();

            zoo.PrintReport();
            
            //zoo.AllSpeak();
            //zoo.ShowFeedingPLan();
            //zoo.ShowTricks();

            //Zazoo.HP = -10;
            //Console.WriteLine(Zazoo.HP);

            //zoo.CountDailyFoodConsumption();
            //zoo.ShowRunningSpeed();
            //Console.WriteLine(Dumbo.Info());
            //Console.WriteLine(Zazoo.Info());
            //Console.WriteLine(Dumbo.HP - 50);
            //Console.WriteLine(Dumbo.Heal(300));

            //Console.WriteLine($"{Dumbo.Name} Has his birthday today! he goes from {Dumbo.Age} to {Dumbo.BirthDay()}");
            //Console.WriteLine(Dumbo.Age);
            //Console.WriteLine(Dumbo.ToString());

            //Console.WriteLine("What animal are you looking for? ");
            //string animal = Console.ReadLine();
            //Animal found = zoo.FindByName(animal);
            //if (found != null )
            //{
            //    Console.WriteLine(found);
            //}
            //else
            //{
            //    Console.WriteLine("Animal not found");
            //}

            //zoo.ListByDiet(Animal.DietType.Omnivore);
            //zoo.ListByDiet(Animal.DietType.Carnivor);
            //zoo.ListByDiet(Animal.DietType.Herbivore);

            //zoo.ListAllAnimalsBydiet();


            //zoo.ShowFlights();

            //zoo.ShowRunnersSorted();

            Console.ReadKey();
        }
    }
}
