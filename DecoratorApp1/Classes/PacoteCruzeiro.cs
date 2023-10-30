using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes 
{
    internal class PacoteCruzeiro : Pacote
    {
        public PacoteCruzeiro(String desc, Double preco)
        : base("Cruzeiro: " + desc, preco)
        {

        }
    }
}
