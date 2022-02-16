using System;
using System.Collections.Generic;

namespace Lista 
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            
            pessoa1.Nome = "Maria";
            pessoa1.Idade = 23;
            pessoa2.Nome = "Ronald";
            pessoa2.Idade = 26;

            listaPessoas.Add(pessoa1);
            listaPessoas.Add(pessoa2);

            System.Console.WriteLine("Nome e idade de pessoas adicionadas à lista:\n");
            foreach(Pessoa p in listaPessoas){
                System.Console.WriteLine("{0} tem {1} anos de idade.", p.Nome, p.Idade);
            }
        }
    }
}