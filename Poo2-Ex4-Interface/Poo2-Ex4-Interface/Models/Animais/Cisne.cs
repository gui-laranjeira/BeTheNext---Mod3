using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2_Ex4_Interface.Models.Animais
{
    public class Cisne : Ave, IOviparo, IAquatico, IVoar
    {
        public bool ViveEmTerra { get ; set; } = true;
        public bool Mergulho { get; set ; }
        public bool AguaDoce { get ; set; }
        public int AltitudeMaximaEmMetros { get ; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Botar()
        {
            Console.WriteLine("Botando..."); ;
        }

        public void Chocar()
        {
            Console.WriteLine("Chocando..."); ;
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
