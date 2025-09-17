using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaragemTudoAmonte
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro c = new Carro();
            c.ano = 2000;
            c.mat = "00-00-00";

            bool aux = Garagem.EstacionaCarro(c);
            if (aux)
            {
                Console.WriteLine("Carro Estacionado...");
            }

        }
    }

}