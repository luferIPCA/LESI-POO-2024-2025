/*
 * LP2
 * Excecoes
 * Lidar com novas exceções
 * lufer
 * */
using System;

namespace Excecoes
{
    /// <summary>
    /// Exception própria
    /// </summary>
    public class  DataInvalidaException : ApplicationException
    {
        public DataInvalidaException() : base("Data Inválida") 
        {
        }

        public DataInvalidaException(string s) : base(s) { }

        public DataInvalidaException(string s, Exception e)
        {
            //throw new Exception(e.Message + " - " + s);
            throw new DataInvalidaException(e.Message + " - " + s);
        }


    }
}
