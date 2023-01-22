using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Carro
    {
        public string Cor { get; set; } = "Azul";
        public string Marca { get; set; } = "BMW";
        public string Modelo { get; set; } = "Sedan";
        public double CapacidadeDoTanque { get; set; } = 50;
        public string TipoDeCombustivel { get; set; } = "flex";
        
        
        public Carro()
        {

        }

        public void Abastecer()
        {
            switch (TipoDeCombustivel)
            {
                case "flex":
                    Console.WriteLine("Seu carro é flex, deseja (1) gasolina ou (2) alcool");
                    int.TryParse(Console.ReadLine(), out int tipoCompustivel);
                    if (tipoCompustivel == 1)
                    {
                        Console.WriteLine("Vamos abastecer com gasolina!");
                    }
                    else if (tipoCompustivel == 2)
                    {
                        Console.WriteLine("Vamos abastecer com álcool!");
                    }

                    Console.WriteLine("Quantos litros");
                    int.TryParse(Console.ReadLine(), out int litrosFlex);
                    if (litrosFlex > CapacidadeDoTanque)
                    {
                        Console.WriteLine("Abastecimento ultrapassa a capacidade do tanque!");
                    }
                    else
                    {
                        Console.WriteLine("*Abastecendo");
                    }
                    return;
                case "alcool":

                    Console.WriteLine("Quantos litros");
                    int.TryParse(Console.ReadLine(), out int litrosAlcool);
                    if (litrosAlcool > CapacidadeDoTanque)
                    {
                        Console.WriteLine("Abastecimento ultrapassa a capacidade do tanque!");
                    }
                    else
                    {
                        Console.WriteLine("*Abastecendo");
                    }
                    return;
                case "gasolina":
                    Console.WriteLine("Quantos litros");
                    int.TryParse(Console.ReadLine(), out int litrosGasolina);
                    if (litrosGasolina > CapacidadeDoTanque)
                    {
                        Console.WriteLine("Abastecimento ultrapassa a capacidade do tanque!");
                    }
                    else
                    {
                        Console.WriteLine("*Abastecendo");
                    }
                    return;

            }
           
        }
    }
    
   
}
