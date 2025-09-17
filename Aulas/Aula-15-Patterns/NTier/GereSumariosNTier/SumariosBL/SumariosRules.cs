/*
 * Gestão de Sumários
 * Business Layer
 * Regras
 * by lufer
 * */

using System;
using System.Data;
using System.Text;
using Validacoes;
using SumariosBO;

namespace SumariosBL
{
    /// <summary>
    /// 
    /// </summary>
    public class SumariosRules
    {        
        /// <summary>
        /// Devolve todos os sumários de um docente
        /// </summary>
        /// <param name="prof"></param>
        /// <returns></returns>
        ///        
        public static DataSet GetSumarios(string prof)
        {
            try
            {
                if (Seguranca.UserAccess(prof) == true)
                {
                    return SumariosDAO.SumariosData.GetAllSumariosBD(prof);
                }
                else
                {
                    //throw new Exception("Não lhe é permitido");
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Devolve informação sobre um sumário
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public static Sumario GetSumarioDetails(int cod)
        {
            if (Seguranca.UserAccess("user") == true && Seguranca.PerfilUser("user") > 2)
            {
                return SumariosDAO.SumariosData.GetSumarioDetailsBD(cod);
            }
            else
                throw new Exception("Sumário desconhecido");
        }
    }
}
