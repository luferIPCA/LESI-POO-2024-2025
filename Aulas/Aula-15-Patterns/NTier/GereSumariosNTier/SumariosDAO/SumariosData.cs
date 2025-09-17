/*
 * Gestão de Sumários
 * Data Access Layer
 * Manipular dados (BD, Ficheiros, etc.)
 * by lufer
 * */

using System;
using System.Data;
using System.Data.OleDb;
using SumariosBO;
using System.Configuration;

namespace SumariosDAO
{

    public class SumariosData
    {

        /// <summary>
        /// Devolve todos os sumários de um docente
        /// </summary>
        /// <param name="prof">Código do docente</param>
        /// <returns>Sumários do Docente</returns>
        public static DataSet GetAllSumariosBD(string prof)
        {
            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString1"].ConnectionString))
            //using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["GereSumariosNTier.Properties.Settings.SumariosConnectionString1"].ConnectionString))
            {
                string query = @"select * from Sumarios where sigla_p like @prof";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);        //acede a dados da BD
                //Instanciar parâmetros
                da.SelectCommand.Parameters.Add("@prof", OleDbType.VarChar).Value = prof;

                da.Fill(ds, "Sumarios");
                if (ds.Tables[0].Rows.Count == 0)
                    throw new Exception("Prof. não fez sumários");
                return ds;                
            }
        }

        /// <summary>
        /// Devolve detalhe de um determinado sumário
        /// </summary>
        /// <param name="cod">Código do Sumário</param>
        /// <returns>Detalhes do Sumário</returns>
        public static Sumario GetSumarioDetailsBD(int cod)
        {
            DataSet ds = new DataSet();
            //SumariosBO.Sumarios sum1 = new SumariosBO.Sumarios();         //sem "using"
            using (OleDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["SumariosConnectionString"].ConnectionString))
            {
                string query = @"select * from Sumarios where C_sum = @cod";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);       
                //Instanciar parâmetros
                da.SelectCommand.Parameters.Add("@cod", OleDbType.Integer).Value = cod;              
                da.Fill(ds, "Sumarios");
                                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Sumario s = new Sumario();   
                    DataRow dr= ds.Tables[0].Rows[0];
                    s.CodSum = cod;
                    s.Data = (DateTime)dr["Data"];
                    s.Desc = dr["Texto"].ToString();
                    s.Prof = dr["Sigla_p"].ToString(); ;
                    return s;
                }
                return null;
            }
        }
    }
}
