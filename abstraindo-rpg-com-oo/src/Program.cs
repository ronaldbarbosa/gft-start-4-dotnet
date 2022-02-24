using src.Entities;

namespace src;
    public class Program
    {
        public static void Main(string[] args)
        {
            Wizard hero = new Wizard("Ronald", 26, "Wizard");
            System.Console.WriteLine(hero);
            System.Console.WriteLine(hero.Attack(2));
        }
    }