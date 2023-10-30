using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes.Servicos
{
    internal class ServicoMassagem : PacoteDecorator 
    {
        public ServicoMassagem(Pacote pacote) : base(pacote, "Massagem", 50.0)
        { 
        }
    }
}
