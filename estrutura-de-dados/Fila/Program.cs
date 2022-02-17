using System;
using System.Collections.Generic;

namespace Fila
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Fila - Ordenação do tipo FIFO
            Queue<string> fila = new Queue<string>();

            System.Console.WriteLine("Palavras adicionadas à fila:");
            fila.Enqueue("Hello ");
            fila.Enqueue("World! ");
            fila.Enqueue("Bons ");
            fila.Enqueue("estudos!");
            fila.Enqueue("\n");
            foreach(string s in fila){
                System.Console.Write(s);
            }

            System.Console.WriteLine("\nRemevendo duas palavras da fila:");
            fila.Dequeue();
            fila.Dequeue();
            foreach(string s in fila){
                System.Console.Write(s);
            }

            System.Console.WriteLine("\nAperte qualquer tecla para finalizar a execução...");
            Console.ReadKey();
        }
    }
}