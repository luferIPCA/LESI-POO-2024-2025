/*
*	<copyright file="InsercaoException.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 3:55:43 PM</date>
*	<description></description>
**/
using System;

namespace Excepcoes
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/14/2020 3:55:43 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class InsercaoException : ApplicationException
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public InsercaoException() : base("Inserção Inválida")
        {
        }

        public InsercaoException(string s) : base(s) { }


        public InsercaoException(string s, Exception e)
        {
            throw new InsercaoException("ERRO: " + s + " - " + e.Message);
        }
        #endregion


        #endregion
    }
}
