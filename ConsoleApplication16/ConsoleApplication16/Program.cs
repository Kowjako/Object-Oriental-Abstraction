using ConsoleApplication16.Classes;
using ConsoleApplication16.list;
using System;
namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalList x = new AnimalList();
            Bird b = new Bird("red","woda","Gragas",15,"Wroclaw");
            Bird b1 = new Bird("blue", "mushrooms", "Jax", 17, "Gdynia");
            Mammals m = new Mammals("170", "80", "Katarina", 18, "Warszawa");
            Mammals m1 = new Mammals("150", "80", "Warwick", 45, "Warszawa");
            PairCop p = new PairCop("2", 290, "Lux", 19, "Gdansk");
            PairCop p1 = new PairCop("2", 280, "Veigar", 51, "Gdansk");
            PairCop p2 = new PairCop("2", 270, "Nokturn", 11, "Gdansk");
            PairCop p3 = new PairCop("2", 260, "talon", 33, "Gdansk");
            x.AddToEndAnimal(b);
            x.AddToEndAnimal(b1);
            x.AddToEndAnimal(m);
            x.AddToEndAnimal(m1);
            x.AddToEndAnimal(p);
            x.AddToEndAnimal(p1);
            x.AddToEndAnimal(p2);
            x.AddToEndAnimal(p3);        
            x.DisplayList();
            Console.WriteLine("===============SORTING..================");
            x.Sort();
            x.DisplayList();
            Console.ReadKey();

        }
    }
}
