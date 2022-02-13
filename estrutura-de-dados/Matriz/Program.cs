namespace Matriz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("-----   Matrizes   -----");
            System.Console.WriteLine("1. Criando uma matriz n x n:");
            System.Console.Write("Qual será a dimensão (n) da matriz? ");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[,] mat = new int[dim, dim];
            for(int i = 0; i < dim; i++){
                for(int j = 0; j < dim; j++){
                    System.Console.Write("Digite o valor da posição [" + i + "][" + j + "]: ");
                    mat[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            System.Console.WriteLine("\nMatriz digitada:");
            for(int i = 0; i < dim; i++){
                System.Console.Write("|\t");
                for(int j = 0; j < dim; j++){
                    System.Console.Write(mat[i,j] + "\t|\t");
                }
                System.Console.Write("\n");
            }
            System.Console.Write("\n");
            System.Console.Write("Pressione qualquer tecla para continuar...");
            Console.ReadKey(true);
            Console.Clear();
            //-----------------------------------------------------------------------------------------
            System.Console.WriteLine("2. Fazendo a busca de um elemento na matriz:");
            System.Console.Write("Digite o valor a ser buscado: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;
            int[] posicao = new int[2]{-1, -1};
            for(int i = 0; i < dim; i++){
                for(int j = 0; j < dim; j++){
                    if(mat[i, j] == valor){
                        posicao[0] = i;
                        posicao[1] = j;
                        encontrado = true;
                    }
                }
            }
            if(encontrado){
                System.Console.WriteLine("\nO valor " + valor + " foi encontrado na posição [" + posicao[0] + "][" + posicao[1] + "] da matriz.");
            } else{
                System.Console.WriteLine("\nO valor " + valor + " não foi encontrado na matriz.");
            }
            System.Console.Write("Digite qualquer tecla para finalizar a execução do programa.\n");
            Console.ReadKey(true);
        }
    }
}