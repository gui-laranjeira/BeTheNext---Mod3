using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Cnh
    {
        public string Pais { get; set; }        
        public int Idade { get; set; }
        public string CategoriaCarteira { get; set; }

        public Cnh(string pais)
        {
            this.Pais = pais;
        }

        public void CadastrarIdade()
        {
            if (Pais == "US" || Pais == "CA")
            {
                bool convertUniversal;
                do
                {
                    Console.WriteLine("Insira sua Idade (maior de 16 anos)");
                    bool convertIdade = int.TryParse(Console.ReadLine(), out int idade);
                    if (convertIdade && idade >= 16)
                    {
                        convertUniversal = true;
                        Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Insira uma idade válida (maior de 16 anos)");
                        convertUniversal = false;
                    }

                } while (!convertUniversal);
            }
            else if (Pais == "CH" || Pais == "RU")
            {
                bool convertUniversal;
                do
                {
                    Console.WriteLine("Insira sua Idade (maior de 21 anos)");
                    bool convertIdade = int.TryParse(Console.ReadLine(), out int idade);
                    if (convertIdade && idade >= 21)
                    {
                        convertUniversal = true;
                        Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Insira uma idade válida (maior de 21 anos)");
                        convertUniversal = false;
                    }

                } while (!convertUniversal);
            }
            else if (Pais == "BR")
            {
                bool convertUniversal;
                do
                {
                    Console.WriteLine("Insira sua Idade (maior de 18 anos)");
                    bool convertIdade = int.TryParse(Console.ReadLine(), out int idade);
                    if (convertIdade && idade >= 18)
                    {
                        convertUniversal = true;
                        Idade = idade;
                    }
                    else
                    {
                        Console.WriteLine("Insira uma idade válida (maior de 18 anos)");
                        convertUniversal = false;
                    }

                } while (!convertUniversal);

                Console.WriteLine("Também informe a categoria da carteira: (A, B, C, D, E, AB, AC, AD ou AE)");
                string categoria = Console.ReadLine();
                this.CategoriaCarteira = categoria;
            }
        }
    }
}
