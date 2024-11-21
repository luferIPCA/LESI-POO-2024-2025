
using System;

namespace Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro.DefineMarca("Ford");
            Carro.marca = "Fiat";

            Console.Write("Marca=" + Carro.GetMarca());

            //creat object from the class: use "new" operator
            Carro c1 = new Carro();
            //Carro.ano = 202;          //ERROR: attribute "ano" is not static
            c1.ano = 2001;

        }
    }
}
