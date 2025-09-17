using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DL;
using BO;

namespace BL
{
    public class Rules
    {
        public static bool InsereValorBD(int val)
        {
            if (val > 0 && val < 100) return false;
            Dados.AddVal(val);
            return true;
        }

        public static bool ExisteValBD(int val)
        {
            return (DL.Dados.ExistVal(val));
        }

        public static bool InserePessoa(Pessoa p)
        {
            if (p.idade > 18)
            {
                return DL.Dados.InserePessoaBD(p);
            }
            return false;
        }
    }
}
