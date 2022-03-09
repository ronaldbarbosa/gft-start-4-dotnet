using System.Linq;

namespace LINQ
{
    public class LINQ
    {
        public static void Main(string[] args)
        {
            int[] arrayNumeros = new int[5] {1, 2, 3, 4, 5};
            var numerosParesQuery =
                    from num in arrayNumeros
                    where num % 2 == 0
                    orderby num
                    select num;
            
            var numerosImparesMetodo = arrayNumeros.Where(x => x % 2 ==1).OrderBy(x => x).ToList();

            System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
            System.Console.WriteLine("Números ímpares método: " + string.Join(", ", numerosImparesMetodo));
        }
    }
}