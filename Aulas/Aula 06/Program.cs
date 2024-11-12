/**
 * lufer
 * POO-2024-2025
 * Variaveis de classe e de instância
 * static
 **/
using System;

namespace Aula_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa p = new Pessoa();
            Pessoa p1 = new Pessoa(12, "Maria");

            Console.WriteLine(p.Id);


            #region H1

            //dados são expostos: evitar
            int tot = 0;
            Pessoa[] t = new Pessoa[100];       //ATENÇÃO
            t[tot++] = p;
            Console.WriteLine("Numero=" + t[0].Id.ToString());

            #endregion

            #region H2

            //Dados no interior da classe
            Turma t1 = new Turma(30);

            t1.RegistaPessoa(p);

            Turma t2 = new Turma();
            t2.RegistaPessoa(p1);

            #endregion
        }
    }
}
