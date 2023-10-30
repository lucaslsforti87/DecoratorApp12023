using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes
{
    internal class PacotePraia : Pacote
    {
        public PacotePraia(String desc, Double preco)
        : base("Praia: " + desc, preco)
        {

        }
    }
}
