/**/

using System;

namespace Aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a;        //declarar objeto

            a = new Aluno(); //objeto do tipo Aluno
            //a.nome = "ok";      //EVITAR!!!!


            a.DefineNome("ok");
            Console.Write("Nome a:" + a.QualNome());

            a.Nome = "ok1";
            Console.Write("Nome a:" + a.Nome);

            Aluno b = new Aluno();
            b.Idade = 23;
            b.Nome = "oli";

            Aluno d = new Aluno("ok");
            d.Idade = 12;

            Aluno e = new Aluno("ola", 27);



        }
    }
}
