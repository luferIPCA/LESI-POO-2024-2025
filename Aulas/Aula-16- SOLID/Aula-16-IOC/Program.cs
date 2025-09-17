/*
 * SOLID Design principles
 *  -  SRP: Single Responsibility Principle
 *  -  IOC: Inversion of Controll
 *  
 *  Ver: 
 *  - https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
 *  - https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design
 * lufer
 * */
using System;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem IOC
            Company c1 = new Company("pessoa");

            //Com IOC
            Person p1 = new Person("pessoa");
            Company c2 = new Company(p1);

            //IVehicle vehicle = new Camiao();

            //IVeiculo v = new Carro();
            //ou
            Carro v = new Carro();
            Camiao ca = new Camiao();
            VeiculoController vc = new VeiculoController(v);            //Injection Constructor 
            vc.Accelerate();
            vc.Brake();

            VeiculoController vcamiao = new VeiculoController(ca);      //Injection Constructor 
            vcamiao.Accelerate();
            vcamiao.Brake();

            Console.ReadKey();
        }
    }
}
