/*
 * by lufer
 * Biblioteca BLL
 * */

using System;
using System.Text;
using TrilhosBO;
using TrilhosDAL;


namespace TrilhosBLL
{
    /// <summary>
    /// Gere um Trilho
    /// </summary>
    public class TrilhoManager
    {
        #region MetodosClasse

        /// <summary>
        /// Devolve inf sobre um trilho
        /// </summary>
        /// <returns></returns>
        public static Trilho GetTrilho(int cod)
        //public Trilho GetTrilho(int cod, User user)
        {
            //if (User.PerfilUser(user)>MinimoBD)
            if (true)
                return (TrilhoDB.GetTrilho(cod));
            else
                throw new NotSupportedException("Não pode...");
        }

        /// <summary>
        /// Guarda novo trilho
        /// </summary>
        /// <param name="t"></param>
        public static int SaveTrilho(Trilho t)
        {
            //if regras para gravar foram respeitadas....
            return (TrilhoDB.SaveTrilho(t));
        }

        #endregion
    }
}
