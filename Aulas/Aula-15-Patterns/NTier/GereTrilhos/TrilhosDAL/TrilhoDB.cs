
/*
 * by lufer
 * Biblioteca DAL para Trilho
 * */
using System;
using System.Text;
using TrilhosBO;
using System.Data;
using System.Collections;

namespace TrilhosDAL
{
    /// <summary>
    /// Gere BD referente a um Trilho
    /// </summary>
    public class TrilhoDB
    {                
        public static Trilho GetTrilho(int cod){
            //código ADO.NET ou Linq            
            return new Trilho("Mezio", TiposTrilhos.Pedestre);
        }

        public static ArrayList GetTrilhos(TiposTrilhos t)
        {
            //código ADO.NET ou Linq
            return null;
        }

        public static int SaveTrilho(Trilho t)
        {
            //código ADO.NET ou Linq
            return (1);
        }
    }
}
