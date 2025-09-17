/*
*	<copyright file="InsertException.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 8:20:34 PM</date>
*	<description></description>
**/
using System;

namespace Validacoes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/14/2020 8:20:34 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class InsertException : ApplicationException
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public InsertException() : base ("Erro")
        {
        }

        public InsertException(string g) : base(g) { }

        public InsertException(string s, Exception e)
        {
            throw new InsertException("ERRO: " + s + " " + e.Message);
        }

        #endregion

       

        #endregion
    }
}
