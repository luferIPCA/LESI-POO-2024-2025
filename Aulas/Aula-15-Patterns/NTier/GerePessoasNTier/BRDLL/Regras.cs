using System;
using System.Collections.Generic;
using BODLL;
using DadosDLL;

namespace BRDLL
{
    public class Regras
    {

        public static bool VerificaSePodeSerInserido(int idade)
        {
            return (idade > 18);
        }

        public static bool VerificaSeEBoaPessoa(Pessoa p)
        {
            return (VerificaSePodeSerInserido(p.idade) && p.nome.Length >= 20);
        }

        public static bool InserirPessoaBD(Pessoa p)
        {
            if (VerificaSePodeSerInserido(p.idade))
            {
                return Dados.InserePessoa(p);
            }
            return false;
        }


        public static List<Pessoa> DevolvePessoasIdade(int idade)
        {
            if (idade > 18 && idade < 40)
                return Dados.PessoasIdade(idade);
            return null;
        }
    }
}
