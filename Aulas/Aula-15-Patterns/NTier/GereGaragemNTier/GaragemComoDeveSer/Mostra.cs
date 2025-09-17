using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyCarro;
using RegrasGaragemDLL;

namespace GaragemComoDeveSer
{
    class Mostra
    {

        public static void ApresentaGaragem(int ano)
        {
            Regras.DevolveCarroAno(ano);
        }
    }
}
