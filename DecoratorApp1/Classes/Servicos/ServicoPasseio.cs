using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes.Servicos
{
    internal class ServicoPasseio : PacoteDecorator
    {
        public ServicoPasseio(Pacote pacote) : base(pacote, "Passeio", 250.0)
        {

        }
    }
}
