using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2_Ex4_Interface.Models.Animais
{
    public class Morcego : Mamifero, IVoar
    {
        public int AltitudeMaximaEmMetros { get ; set ; }
        public double VelocidadeDoVoo { get ; set ; }

        public void Voar()
        {
            Console.WriteLine("Voando..."); ;
        }
    }
}
