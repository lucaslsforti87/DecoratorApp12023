using DecoratorPacotesViagem.Classes;
using DecoratorPacotesViagem.Classes.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPacotesViagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Pacotes Férias ==");

            Pacote pacoteDeViagem = new PacotePraia("Beberibe-CE", 1500.0);


            pacoteDeViagem = new ServicoBebidas(pacoteDeViagem);
            pacoteDeViagem = new ServicoBebidas(pacoteDeViagem);
            pacoteDeViagem = new ServicoPasseio(pacoteDeViagem);

            Console.WriteLine("==INCLUSO==");
            Console.WriteLine(pacoteDeViagem.getDesc());
            Console.WriteLine("TOTAL R$ " + pacoteDeViagem.getPreco());
        }
    }
}
