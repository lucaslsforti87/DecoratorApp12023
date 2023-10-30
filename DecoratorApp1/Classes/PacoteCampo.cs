using DecoratorPacotesViagem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes
{
    internal class PacoteCampo : Pacote
    {
        //Ao criar o pacote serão fornecidos a descrição e o preço
        public PacoteCampo(String desc, Double preco)
        : base("Campo: " + desc, preco)
        {

        }
    }
}
