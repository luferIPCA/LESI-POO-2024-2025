
using System;
using Aula_09_Libraries;

namespace Aula_08_Agregacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Garagem g = new Garagem();

            Garagem.EstacionaCarro(new Veiculo());
            Garagem.EstacionaCarro(new Veiculo());



            Veiculo v1 = new Veiculo(DateTime.Today);
            Veiculo v2 = new Veiculo(DateTime.Today);

            if (v1 == v2)
                Console.WriteLine("Iguais");

        }
    }
}
