using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrosBO;
using CarroBL;

namespace GereCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carro c = new Carro();
            c.matricula = "00.00.00";


            Console.WriteLine("Carro Estacionado: " + CarroBL.CarroBL.EstacionaCarro(c).ToString());
            Console.ReadKey();
        }
    }
}
