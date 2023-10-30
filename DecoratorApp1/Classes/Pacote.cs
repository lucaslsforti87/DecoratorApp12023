using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem.Classes
{
    internal class Pacote
    {
        private String desc;
        private Double preco;

        public Pacote(string desc, double preco)
        {         
            this.desc = desc;
            this.preco = preco;
        }
        public String getDesc()
        {
            return desc;
        }
        public Double getPreco()
        {
            return preco;
        }
    }
}
