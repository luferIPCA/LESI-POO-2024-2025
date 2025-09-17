using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrosBO;

namespace CarroDB
{
    public class Garagem
    {
        static List<Carro> garag;

        static Garagem()
        {
            garag = new List<Carro>();
        }

        public static bool Estaciona(Carro c)
        {
            if (!garag.Contains(c))
            {
                garag.Add(c); return true;
            }
            return false;
        }
    }
}
