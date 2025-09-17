/*
*	<copyright file="SemCamadas.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/13/2021 9:19:44 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace SemCamadas
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/13/2021 9:19:44 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Dados
    {


        #region Attributes
        //chave==idade da pessoa
        static Dictionary<int, List<Pessoa>> valores;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Dados()
        {
            valores = new Dictionary<int, List<Pessoa>>();
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool InserePessoa(Pessoa p)
        {
            try
            {
                //TPC: Ver se p já existe em valores;
                //return false;
                //se não existe, insere
                //TPC: Verificar se a Lista existe ou não
                //TPC: Testar se p é nulo???
                valores[p.idade] = new List<Pessoa>();
                valores[p.idade].Add(p);
                return true;
            }
            catch
            {
                throw;
            }
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Dados()
        {
        }
        #endregion

        #endregion
    }
}
