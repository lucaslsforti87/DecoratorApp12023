using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes.Servicos
{
    internal class ServicoBebidas : PacoteDecorator
    {
        //Adicionar o servico de bebidas em um pacote
        public ServicoBebidas(Pacote pacote) : base(pacote, "Bebidas", 400.0)
        {

        }
    }
}
