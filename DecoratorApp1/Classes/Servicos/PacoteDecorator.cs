using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes.Servicos
{
    internal class PacoteDecorator : Pacote
    {
        protected Pacote pacote;

        public PacoteDecorator(Pacote pacote, String descServico, Double precoServico)
            : base(pacote.getDesc() + " + " + descServico,
                 pacote.getPreco() + precoServico)
        {
            this.pacote = pacote;
        }
    }
}
