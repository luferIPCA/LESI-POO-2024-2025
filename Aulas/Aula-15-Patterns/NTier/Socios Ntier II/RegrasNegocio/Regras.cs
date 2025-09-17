
/*
 * lufer
 * 
 * Camada de Regras de Negócio ! Business Rules Layer
 * */

using Dados;
using Excepcoes;
using ObjetosNegocio;

namespace RegrasNegocio
{
    /// <summary>
    /// Descreve os métodos de acesso aos dados, filtrado por regras de negócio
    /// </summary>
    public class Regras
    {

        public Regras()
        {
            
        }

        /// <summary>
        /// Insere nova pessoa
        /// Devolve Exceção "InsereException"
        /// </summary>
        /// <param name="p"></param>
        /// <param name="perfil"></param>
        /// <returns></returns>
        public static bool InserePessoa(PessoaSemLista p, int perfil)
        {
            //Aplicar regra de negócio
            if (perfil > 0)
            {
                try
                {
                    return Pessoas.AddPessoa(p);
                }
                catch( InsercaoException e)
                {
                    throw e;
                }
            }
            return false;  
        }

        public static bool InserePessoaA(PessoaSemLista p, A a)
        {
            return Pessoas.AddPessoa(p, a);
        }


        public static bool InsereA(string nome, A a)
        {
            return Pessoas.AddA(nome, a);
        }

        

        public static Pessoa GetPessoa (int cod, int perfil)
        {
            return null;
        }
       
    }
}
