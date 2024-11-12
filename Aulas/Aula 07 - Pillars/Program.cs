
using System;

namespace Aula_07_Pilars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veiculo v1 = new Veiculo();     //data de hoje
            Veiculo v2 = new Veiculo(new DateTime(2023, 10, 29));
            
            Console.WriteLine("V1:" + v1.ToString() + "Ano:" + v1.QualAno());

            Carro c1 = new Carro();
            Carro c2 = new Carro(COMBOS.Ele, "Opel");
            Carro c3 = new Carro(COMBOS.Ele, "Opel", new DateTime(2000, 12, 12));
            Carro c4 = new Carro(COMBOS.Gas, new DateTime(2020,10,12), "Renault");

            Console.WriteLine("C3:" + c3.ToString() + "Ano:" + c3.QualAno());

            RealVeiculo xx = new RealVeiculo();
            double d = xx.Celindrada(2024);

            Outra o = new Outra();
            o.Detalhes(v1);

            OutroVeiculo ov = new OutroVeiculo();
            o.Detalhes(ov);

            Bike b = new Bike();
            b.anoB = 2023;
            b.AnoVeiculo = new DateTime(2024,12,12);
            Console.WriteLine("Ano Bike:" + b.QualAno().ToString());

        }
    }
}
