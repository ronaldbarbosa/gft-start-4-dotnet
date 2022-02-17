using System;
using System.Collections.Generic;

namespace Pilha
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Pilha - Ordenação do tipo LIFO
            Stack<int> numeros = new Stack<int>();
            numeros.Push(1);
            numeros.Push(6);
            numeros.Push(2);
            numeros.Push(3);
            
            System.Console.WriteLine("Pilha após inserção de 4 números:");
            foreach(int numero in numeros){
                System.Console.Write(numero + " | ");
            }

            numeros.Pop();

            System.Console.WriteLine("\nPilha após a remoção do último elemento:");
            foreach(int numero in numeros){
                System.Console.Write(numero + " | ");
            }
            
            System.Console.WriteLine("\nAperte qualquer tecla para finalizar a execução...");
            Console.ReadKey();
        }
    }
}