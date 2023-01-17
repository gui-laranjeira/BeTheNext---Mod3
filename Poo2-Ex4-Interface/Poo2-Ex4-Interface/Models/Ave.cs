using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2_Ex4_Interface.Models
{
    public class Ave : Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }
        
        public void Ciscar()
        {
            Console.WriteLine("Ciscando...");
        }
    }
}
