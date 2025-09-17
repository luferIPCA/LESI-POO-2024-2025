using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrataProblemas
{
    public class NaoPodeInserirException: ApplicationException
    {

        public NaoPodeInserirException() : base("Impossivel") { }
        public NaoPodeInserirException(string msg) 
        {

            throw new Exception(msg + " Nem penses...NaoPodeInserir!");
        }

        public NaoPodeInserirException(Exception e)
        {

            throw new NaoPodeInserirException (e.Message + " NaoPodeInserir...Nem penses! ");
        }
    }
}
