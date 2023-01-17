using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2_Ex4_Interface.Models.Animais
{
    public class Coruja : Ave, IVoar, IOviparo
    {
        public int AltitudeMaximaEmMetros { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double VelocidadeDoVoo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
        {
            throw new NotImplementedException();
        }

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
