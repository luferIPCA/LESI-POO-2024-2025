using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_09_Libraries
{
    /// <summary>
    /// 
    /// </summary>
    public class VeiculoI : Veiculo
    {
        string registo;
        public VeiculoI() { }   

        public string Registo
        {
            get { return registo; }
            set { registo = value; }
        }
    }
}
