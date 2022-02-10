using System;

namespace Vetor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("----   Vetores   ----");
            
            System.Console.WriteLine("1. Criando vetor de números inteiros com 4 posições:");
            int[] arr = new int[4];
            for(int i = 0; i < 4; i++)
            {
                System.Console.Write("Digite um valor para a posição " + i + ": ");
                arr[i] = int.Parse(System.Console.ReadLine());
            }
            System.Console.WriteLine("\nVetor digitado:");
            for(int i = 0; i < 4; i++)
            {
                System.Console.Write(arr[i] + " | ");
            }
            Console.Write("\n\nAperte qualquer tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
            // -------------------------------------------------------------------------------

            System.Console.WriteLine("----   Vetores   ----");

            System.Console.WriteLine("2. Fazendo a busca de um elemento no vetor:");
            System.Console.Write("Digite o valor a ser buscado: ");
            int valor = int.Parse(Console.ReadLine());
            bool encontrado = false;
            int posicao = -1;
            for(int i = 0; i < 4; i++){
                if(arr[i] == valor){
                    encontrado = true;
                    posicao = i;
                }
            }
            if(encontrado == false){
                System.Console.WriteLine("\nValor não encontrado!");
            } else{
                System.Console.WriteLine("\nO valor " + valor + " foi encontrado na posição [" + posicao + "] do vetor.");
            }
            Console.WriteLine("\nAperte qualquer tecla para finalizar a execução do programa...");
            Console.ReadKey(true);
        }
    }
}