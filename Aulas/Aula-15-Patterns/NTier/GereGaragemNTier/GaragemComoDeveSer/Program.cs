using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyCarro;
using RegrasGaragemDLL;

namespace GaragemComoDeveSer
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro c = new Carro();
            c.ano = 2000;
            c.mat = "000000";

            bool aux = Regras.EstacioneCarroPorFavor(c);
            if (aux)
            {
                //Console.WriteLine("Ok");
                Mostra.ApresentaGaragem(2000);
            }
            
        }
    }
}
