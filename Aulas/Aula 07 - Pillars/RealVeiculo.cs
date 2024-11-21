using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Pilars
{
    public class RealVeiculo : AbsVeiculo, IVeiculo
    {
        /// <summary>
        /// Da class AbsVeiculo
        /// </summary>
        /// <returns></returns>
        public override int QualMes()
        {
            return AnoVeiculo.Month;
        }

        /// <summary>
        /// Da class AbsVeiculo
        /// </summary>
        /// <param name="ano"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override double Celindrada(int ano)
        {
            throw new NotImplementedException();
        }

        #region OutrosMetodos
        /// <summary>
        /// "new" pois 
        /// </summary>
        /// <returns></returns>
        public new int QualDia()
        {
            return AnoVeiculo.Day;
        }

        /// <summary>
        /// Condicionado pelo Interface
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool FazCoisas(IOutrosMetodos v)
        {
            Console.Write("Dia:" + v.QualDia().ToString());
            return true;
        }

        #endregion

    }
}
