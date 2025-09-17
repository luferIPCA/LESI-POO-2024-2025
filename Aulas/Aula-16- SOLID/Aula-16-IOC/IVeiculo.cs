using System;
using System.Collections.Generic;

namespace IOC
{
    public interface IVeiculo
    {
        void Accelerate();
        void Brake();
    }

    class Carro: IVeiculo
    {
        #region IVehicle Members

        public void Accelerate()
        {
            Console.WriteLine("Acelera carro...");
        }

        public void Brake()
        {
            Console.WriteLine("Parou carro!");
        }

        #endregion
    }

    public class Camiao : IVeiculo
    {
        #region IVehicle Members

        public void Accelerate()
        {

            Console.WriteLine("Acelera camião...");
        }

        public void Brake()
        {
            Console.WriteLine("Parou camião!");
        }

        #endregion
    }

    public class VeiculoController
    {
        IVeiculo v;

        public VeiculoController(IVeiculo vehicle)
        {
            this.v = vehicle;
        }

        public void Accelerate()
        {
            v.Accelerate();
        }

        public void Brake()
        {
            v.Brake();
        }
    }
}
