using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2_Ex1
{
    public class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        public void Explicar(string assunto)
        {
            Console.WriteLine($"*Explicando sobre {assunto.ToLower()}! blablabla");
        }
    }
}
