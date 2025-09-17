/*
*	<copyright file="DadosDLL.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/13/2021 9:49:25 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using BODLL;

namespace DadosDLL
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/13/2021 9:49:25 PM
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


        public static Pessoa QualPessoa(string nome)
        {
            //procurar qual a chave no Dicionario desta pessoa
            //devolva a pessoa encontra
            return (new Pessoa());
        }

        public static List<Pessoa> PessoasIdade(int idade)
        {
            //Aceder à Lista com a chave idade;
            //ver se chave existe
            return (valores[idade]);
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
