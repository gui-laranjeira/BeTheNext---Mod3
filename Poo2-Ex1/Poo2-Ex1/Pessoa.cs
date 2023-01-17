using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2_Ex1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade) 
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public void Cumprimentar()
        {
            Console.WriteLine("Olá mundo!");
        }

        public void DizerIdade()
        {
            Console.WriteLine($"Tenho {Idade} anos!");
        }
    }
}
