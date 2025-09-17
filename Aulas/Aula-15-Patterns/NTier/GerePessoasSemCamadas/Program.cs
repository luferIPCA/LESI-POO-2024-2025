using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemCamadas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool aux=false;
            Pessoa p = new Pessoa();
            p.idade = 12;
            p.nome = "Paulo";

            try
            {
                if (p.idade > 18)
                    aux = Dados.InserePessoa(p);
            }
            catch
            {

            }
            if (aux) 
                Console.WriteLine("Pessoa:" + p.nome);
        }
    }
}
