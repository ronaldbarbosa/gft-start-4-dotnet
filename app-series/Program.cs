using app_series.DIO.Series;

namespace Dio.Series
{
    public class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        public static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        System.Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void VisualizarSerie()
        {
            System.Console.Write("Digite o ID da serie: ");
            int indiceSerie = int.Parse(System.Console.ReadLine());
            var serie = repositorio.RetornaPorID(indiceSerie);
            System.Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            System.Console.Write("Digite o ID da serie: ");
            int indiceSerie = int.Parse(System.Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }

        private static void AtualizarSerie()
        {
            System.Console.Write("Digite o ID da série: ");
            int indiceSerie = int.Parse(System.Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            System.Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite o título da série: ");
            string entradaTitulo = System.Console.ReadLine();

            System.Console.Write("Digite o ano da série: ");
            int entradaAno = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a descrição da série: ");
            string entradaDescricao = System.Console.ReadLine();

            Serie atualizarSerie = new Serie(id: indiceSerie, 
                                        genero: (Genero) entradaGenero,
                                        entradaTitulo, 
                                        entradaDescricao,
                                        entradaAno
                                        );
            repositorio.Atualiza(indiceSerie, atualizarSerie);
        }

        private static void InserirSerie()
        {
            System.Console.WriteLine("Inserir serie");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            System.Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite o título da série: ");
            string entradaTitulo = System.Console.ReadLine();

            System.Console.Write("Digite o ano da série: ");
            int entradaAno = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a descrição da série: ");
            string entradaDescricao = System.Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoID(), 
                                        genero: (Genero) entradaGenero,
                                        entradaTitulo, 
                                        entradaDescricao,
                                        entradaAno
                                        );
            repositorio.Insere(novaSerie);
            
        }

        private static void ListarSeries()
        {
            System.Console.WriteLine("Listar series");

            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                System.Console.WriteLine($"#ID {serie.retornaID()}: - {serie.retornaTitulo()} - Excluida: {excluido}");
            }
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Series");
            System.Console.WriteLine("Informe a opção desejada:");
            System.Console.WriteLine("1 - Listar séries");
            System.Console.WriteLine("2 - Inserir nova série");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar tela");
            System.Console.WriteLine("X - Sair");

            string opcaoUsuario = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
    }
}