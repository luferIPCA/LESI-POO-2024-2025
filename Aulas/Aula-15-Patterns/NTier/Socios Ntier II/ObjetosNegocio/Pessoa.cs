/*
*	<copyright file="Pessoa.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 3:07:34 PM</date>
*	<description> Business Objects </description>
**/

using System;
using System.Collections.Generic;

namespace ObjetosNegocio
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/14/2020 3:07:34 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class PessoaSemLista
    {
        #region Attributes
        public string nome;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public PessoaSemLista()
        {
        }

        public PessoaSemLista(string s)
        {
            nome = s;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~PessoaSemLista()
        {
        }
        #endregion

        #endregion
    }

    public class A
    {
        string x;
        string y;
    }
}
