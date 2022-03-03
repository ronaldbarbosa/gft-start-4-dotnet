// Criando arquivo de texto com nome definido pelo usuário
// Caracteres inválidos no nome do arquivo serão trocados por '-'
using System.IO;
using static System.Console;

namespace Files
{
   public class Program
    {
        public static void CreateFile(string path)
        {
            using var sw = File.CreateText(path);
            sw.WriteLine("Linha 1");
            sw.WriteLine("Linha 2");
            sw.WriteLine("Linha 3");
        
        }
        public static string ClearFileName(string name)
        {
            foreach(var @char in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(@char, '-');
            }
            return name;
        }
        public static void Main(string[] args)
        {
            var name = ReadLine();
            name = ClearFileName(name);

            var path = Path.Combine("/tmp", $"{name}.txt");
            CreateFile(path);
        
            WriteLine("Press 'Enter' to exit...");
            ReadLine();
        }
    }  
}
