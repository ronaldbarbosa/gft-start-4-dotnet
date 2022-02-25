using System;

namespace Revisao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceVetor = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "0")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        System.Console.Write("Nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        System.Console.Write("Informe a nota do aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal.");
                        }
                        alunos[indiceVetor] = aluno;
                        indiceVetor++;
                        break;
                    case "2":
                        foreach(Aluno a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                System.Console.WriteLine("Aluno: {0} | Nota: {1}", a.Nome, a.Nota);
                            }
                        }
                        break;
                    case "3":
                        decimal media, somaDasNotas = 0;
                        decimal numeroDeAlunos = 0;
                        
                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                somaDasNotas += alunos[i].Nota;
                                numeroDeAlunos++;
                            }
                        }

                        media = somaDasNotas / numeroDeAlunos;
                        System.Console.WriteLine("Média dos alunos: {0}", media);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine("\nInforme a opção desejada:");
            System.Console.WriteLine("1 - Inserir novo aluno");
            System.Console.WriteLine("2 - Listar alunos");
            System.Console.WriteLine("3 - Calcular média geral");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            System.Console.Clear();
            return opcaoUsuario;
        }
    }
}