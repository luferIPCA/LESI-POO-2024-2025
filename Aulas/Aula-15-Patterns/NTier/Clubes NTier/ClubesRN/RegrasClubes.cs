/*
*	<copyright file="Clubecs.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 7:47:57 PM</date>
*	<description>Business Layer</description>
**/
using ClubeBO;
using DadosClubes;
using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Validacoes;

namespace ClubesRN
{
    /// <summary>
    /// Classe que suporta a Camada de Regras de Negócio
    /// </summary>
    public class RegrasClubes
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool InsereClube(Clube c)
        {
            try
            {
                //aplica regras de negocio
                if (c.Nome.CompareTo("Porto") == 0) return false;
                return Clubes.AddClube(c);
            }
            catch(InsertException e)
            {
                throw e;
            }
        }

        public static bool InsereCampeonatoClube(DateTime c, string n)
        {
            try
            {
                //aplica regras de negocio
                return Clubes.AddCampeonatoClube(c, n);
            }
            catch (InsertException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Preservar dados em ficheiro
        /// </summary>
        /// <param name="fPath"></param>
        /// <returns></returns>
        public static bool GravaClubes(string fPath)
        {
            //aplicar regras
            return Clubes.SaveAll(fPath);
        }
    }
}
