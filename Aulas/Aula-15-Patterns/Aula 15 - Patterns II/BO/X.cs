using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class X
    {
        string nome;

        public X() { }
        public X(string s) { nome = s; }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
