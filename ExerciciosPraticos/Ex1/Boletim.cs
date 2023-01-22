using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Boletim
    {
        public string Nome { get; set; }

        private int _ano;
        public int Ano
        {
            get { return _ano; }
            set
            {
                if (value < 1964)
                {
                    throw new ArgumentException("Ano precisa ser maior que 1964");
                }
                _ano = value;
            }
        }

        private int _semestre;

        public int Semestre
        {
            get { return _semestre; }
            set 
            { 
               if(value < 1 || value > 14)
                {
                    throw new ArgumentException("Semestre precisa ser entre 1 e 14");
                }
                _semestre = value; 
            }
        }

        public List<double> Notas { get; set; }

        public Boletim (string nome, int ano, int semestre)
        {
            this.Nome = nome;
            this.Ano = ano;
            this.Semestre = semestre;
            this.Notas = new List<double>();
        }

        public void RegistrarNotas(double nota)
        {
            if (Notas.Count < 6)
            {
                Notas.Add(nota);
            }
        }

        public void CalcularMediaSemestral()
        {
            double soma = 0;
            foreach (double nota in Notas)
            {
                soma += nota;
            }
            double media = soma / 6;
            Console.WriteLine($"A média do aluno {Nome} é: {media}");
        }
    }
}
