using System;

namespace Registro
{
    public class Program
    {
        public record Livro(string nome, double preco, int paginas);
        public static void Main(string[] args)
        {
            Livro[] livros = new Livro[3];
            System.Console.WriteLine("Entre com as informações dos 3 livros:");
            System.Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey(true);
            for(int i = 0; i < 3; i++){
                Console.Clear();
                System.Console.WriteLine("Livro " + i + ": ");
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Preço: R$ ");
                double preco = Convert.ToDouble(Console.ReadLine());
                System.Console.Write("Número de páginas: ");
                int paginas = Convert.ToInt32(Console.ReadLine());
                livros[i] = new Livro(nome, preco, paginas);
            }
            Console.Clear();
            System.Console.WriteLine("=========================================");
            System.Console.WriteLine("Livros digitados:");
            for(int i = 0; i < 3; i++){
                System.Console.WriteLine("-----------------------------------------");
                System.Console.WriteLine("Livro " + i + ":");
                System.Console.WriteLine("Nome: " + livros[i].nome);
                System.Console.WriteLine("Preço: " + livros[i].preco);
                System.Console.WriteLine("Número de páginas: " + livros[i].paginas);
            }
        }
    }
}