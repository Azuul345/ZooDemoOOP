namespace ZooDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Animal Simba = new Lion("Simba", 10,100);
            Animal Zazoo = new Parrot("Zazoo", 1, 40);
            Animal Dumbo = new Elephant("Dumbo", 3, 80);

            zoo.Add(Simba);
            zoo.Add(Zazoo);
            zoo.Add(Dumbo);

            Console.WriteLine($"total anaimals: {Animal.TotalCount}");

            //zoo.ListAll();
            //zoo.AllSpeak();
            //zoo.ShowFeedingPLan();
            //zoo.ShowTricks();

            //Zazoo.HP = -10;
            //Console.WriteLine(Zazoo.HP);

            //zoo.CountDailyFoodConsumption();
            //zoo.ShowRunningSpeed();

            Console.WriteLine(Dumbo.ToString());
            
            




            Console.ReadKey();
        }
    }
}
