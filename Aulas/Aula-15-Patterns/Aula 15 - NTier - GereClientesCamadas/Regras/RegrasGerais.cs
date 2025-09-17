using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
using Dados;
using TrataProblemas;

namespace Regras
{
    public class RegrasGerais
    {

        public static bool InsereClienteNosDados(Cliente c)
        {
            //regras de negocio!!!
            if (c.id % 2 == 0)
            {
                try
                {
                    bool a = Clientes.InsereCliente(c);
                    return a;
                }
                catch (NaoPodeInserirException e)
                {
                    throw new NaoPodeInserirException(e.Message + " Regra Violada ");
                }
            }
            else return false;
        }
    }
}
