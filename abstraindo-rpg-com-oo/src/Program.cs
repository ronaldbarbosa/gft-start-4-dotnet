using src.Entities;

namespace src;
    public class Program
    {
        public static void Main(string[] args)
        {
            Support soraka = new Support("Soraka", "Targon", "Support", "healing");
            Marksman varus = new Marksman("Varus", "Ionia", "Marksman", 575);
            Tank poppy = new Tank("Poppy", "Demacia", "Tank", 7);
            Mage malzahar = new Mage("Malzahar", "Void", "Mage", 9);
            
            
            System.Console.WriteLine(soraka);
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine(varus);
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine(poppy);
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine(malzahar);

            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("Fighting:");
            System.Console.WriteLine(varus.Fighting());
            System.Console.WriteLine(malzahar.Fighting());
            System.Console.WriteLine(soraka.Fighting());
            System.Console.WriteLine(poppy.Fighting());
        }
    }