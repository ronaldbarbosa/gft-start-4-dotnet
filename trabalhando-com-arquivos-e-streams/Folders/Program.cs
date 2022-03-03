using System.IO;
using static System.Console;

namespace Folders 
{
    public class Program
    {
        public static void CreateFile(string name)
        {
            var path = Path.Combine("/tmp", $"{name}.txt");
            if(!File.Exists(path))
            {
                using var sw = File.CreateText(path);
            }
            
        }
        public static void MoveFile(string originPath, string destinationPath)
        {
            if(!File.Exists(originPath))
            {
                WriteLine("File don't exists in origin path!"); 
                return;
            }
            if(File.Exists(destinationPath)) 
            {
                WriteLine("File already exists in destination path!"); 
                return;
            }
            
            File.Move(originPath, destinationPath);
        }
        public static void CreateWorldDirectories()
        {
            var path = Path.Combine("/tmp", "world");

            if(!Directory.Exists(path))
            {
                var world = Directory.CreateDirectory(path);
            
                var NorthAmerica = world.CreateSubdirectory("NorthAmerica");
                var CentralAmerica = world.CreateSubdirectory("CentralAmerica");
                var SouthAmerica = world.CreateSubdirectory("SouthAmerica");

                NorthAmerica.CreateSubdirectory("USA");
                NorthAmerica.CreateSubdirectory("MEX");

                CentralAmerica.CreateSubdirectory("CUB");
                CentralAmerica.CreateSubdirectory("PAN");

                SouthAmerica.CreateSubdirectory("BRA");
                SouthAmerica.CreateSubdirectory("ARG");
            }
        }
        public static void Main(string[] args)
        {
            CreateWorldDirectories();

            CreateFile("Brasil");
            
            var origin = Path.Combine("/tmp", "Brasil.txt");
            var destination = Path.Combine("/tmp", "world", "SouthAmerica", "BRA", "Brasil.txt");
            
            MoveFile(origin, destination);
        }
    }
}