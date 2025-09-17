using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using BO;
using Regras;
using TrataProblemas;

namespace GereClientes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.id = 12;


            try
            {
                bool x = RegrasGerais.InsereClienteNosDados(c);
                x = RegrasGerais.InsereClienteNosDados(c);
            }
            catch (NaoPodeInserirException e)
            {
                Console.WriteLine("ERRO: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERRO GLOBAL" + e.Message);
            }

            Console.ReadKey();
            
        }
    }
}
