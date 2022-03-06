using System.Collections.Generic;

namespace Dicionario;
public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> cidades = new Dictionary<int, string>{};
        cidades.Add(11, "São Paulo");
        cidades.Add(21, "Rio de Janeiro");
        cidades.Add(27, "Vitória");
        cidades.Add(31, "Belo Horizonte");

        System.Console.Write("Digite um número de DDD para consultar sua capital correspondente (apenas capitais da região Sudeste): ");
        int ddd = int.Parse(System.Console.ReadLine());
        
        if(cidades.TryGetValue(ddd, out string value))
        {
            System.Console.WriteLine($"O DDD ({ddd}) corresponde a cidade de: {value}");
        }
        else
        {
            System.Console.WriteLine("DDD digitado não corresponde a nenhuma capital da região Sudeste.");
        }
        
        System.Console.Write("Pressione [Enter] para limpar a tela e imprimir todas as capitais e DDD...");
        System.Console.ReadLine();
        System.Console.Clear();

        foreach (KeyValuePair<int, string> cidade in cidades)
        {
            System.Console.WriteLine($"DDD (chave): {cidade.Key}\nCidade (Valor): {cidade.Value}\n");
        }
    }
}