using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BODLL;
using BRDLL;

namespace ComCamadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.idade = 12;
            p.nome = "Paulo";
            bool aux = Regras.InserirPessoaBD(p);


            List<Pessoa> l = Regras.DevolvePessoasIdade(23);
            Apresenta.MostraLista(l);


        }
    }
}
