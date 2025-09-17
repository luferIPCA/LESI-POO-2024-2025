using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarroDB;
using CarrosBO;

namespace CarroBL
{
    public class CarroBL
    {

        public static bool EstacionaCarro(Carro c)
        {
            if (String.Compare(c.matricula, "00.00.00") == 0) 
                return false;
            return Garagem.Estaciona(c);
        }
    }
}
