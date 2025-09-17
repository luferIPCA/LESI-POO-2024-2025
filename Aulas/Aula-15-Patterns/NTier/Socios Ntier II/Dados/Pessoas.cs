/*
 * lufer
 * 
 * Camada de Dados | Data Layer
 * */
using Excepcoes;
using ObjetosNegocio;
using System.Collections.Generic;

namespace Dados
{
    public class Pessoas
    {
        private static List<Pessoa> todasPessoas;

        static Pessoas()
        {
            todasPessoas = new List<Pessoa>();
        }

        /// <summary>
        /// Insere nova pessoa
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool AddPessoa(PessoaSemLista p)
        {
            try
            {
                //PessoaSemLista em Pessoa;
                Pessoa aux = new Pessoa();
                aux.nome = p.nome;
                aux.conjA = null;

                if (todasPessoas.Contains(aux)) return false;   //Rever Contains que percorre pelo "nome"
                
                todasPessoas.Add(aux);
            }
            catch (InsercaoException e)
            {
                throw e;
            }
            return true;
        }


        public static bool AddPessoa(PessoaSemLista p, A a)
        {
            try
            {
                //PessoaSemLista em Pessoa;
                Pessoa aux = new Pessoa(a);
                aux.nome = p.nome;

                if (todasPessoas.Contains(aux)) return false;   //Rever Contains que percorre pelo "nome"

                todasPessoas.Add(aux);
            }
            catch (InsercaoException e)
            {
                throw e;
            }
            return true;
        }

        public static bool AddA(string nome, A a)
        {
            try
            {
                foreach(Pessoa p in todasPessoas)
                {
                    if (p.nome == nome)
                    {
                        //testar
                        p.conjA.Add(a);
                        return true;
                    }
                }
            }
            catch (InsercaoException e)
            {
                throw e;
            }
            return false;
        }

        public static Pessoa GetPessoa(int p)
        {
            return null;
        }

        public static bool SaveAll()
        {
            return true;
        }

        public static bool LoadAll()
        {
            return true;
        }

    }
}
