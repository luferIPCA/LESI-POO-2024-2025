using BO;
using System.Collections.Generic;
using TrataProblemas;

namespace Dados
{
    public class Clientes
    {
        private static List<Cliente> clientes= new List<Cliente>(); //REVER

        static Clientes() { 
            clientes = new List<Cliente>(); 
        }
        public static bool InsereCliente(Cliente c)
        {
            if (!clientes.Contains(c))
            {
                clientes.Add(c);
                return true;
            }
            else
                throw new NaoPodeInserirException("Nao pagou!");
            //
            //return false;
        }
    }
}
