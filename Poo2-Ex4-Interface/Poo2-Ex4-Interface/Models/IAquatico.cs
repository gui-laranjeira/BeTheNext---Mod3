using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo2_Ex4_Interface.Models
{
    public interface IAquatico
    {
        bool ViveEmTerra { get; set; }
        bool Mergulho { get; set; }
        bool AguaDoce { get; set; }
    }
}
