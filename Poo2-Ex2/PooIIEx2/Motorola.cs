using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooIIEx2
{
    internal class Motorola : Smartphone
    {
        public Motorola(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"{nome} foi instalado em seu Motorola com sucesso!");
        }
    }
}
