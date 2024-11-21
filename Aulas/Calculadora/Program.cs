using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OperacoesNS;      //"importa dll

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculos c = new Calculos();
            //c.Soma(2, 3);

            Calculos.Sub(2, 3);
            Calculos.Soma(2, 3, 4);
            int[] valores = { 2, 3, 4, 5 };

            Calculos.Soma(valores);

            Calculos.SomaII(2, 3, 4, 5, 6, 7, 8, 9);


           
        }
    }
}
