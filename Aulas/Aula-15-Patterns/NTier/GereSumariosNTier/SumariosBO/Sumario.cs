/*
 * Gestão de Sumários
 * Business Object
 * by lufer
 * */

using System;
using System.Text;

namespace SumariosBO
{
    public enum TiposAulas
    {
        T,
        TP,
        P
    }


    /// <summary>
    /// Isto faz algo
    /// </summary>
    /// <remarks></remarks>
    /// 
    public class Sumario
    {
        #region Atributos

        int codSum;
        DateTime data;
        String prof;
        string desc;

        #endregion

        #region Construtores

        public Sumario()
        {
        }
        #endregion

        #region Propriedades

        /// <summary>
        /// Isto é fixe
        /// </summary>
        public int CodSum
        {
            get { return codSum/2; }
            set { codSum = value; }
        }

        public string Prof
        {
            get { return prof; }
            set { prof = value; }
        }

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        #endregion

        #region Outros
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Sumário: Prof: "+prof+" Data: "+data;
        }
        #endregion
    }
}
