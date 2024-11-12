using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07_Pilars
{
    public class OutroVeiculo : IVeiculo
    {
        public double Celindrada(int x)
        {
            return x * 3;
        }
    }
}
