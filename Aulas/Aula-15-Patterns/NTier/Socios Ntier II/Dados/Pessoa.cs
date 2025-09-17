/*
*	<copyright file="Pessoa.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/15/2020 2:25:22 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjetosNegocio;

namespace Dados
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/15/2020 2:25:22 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa : PessoaSemLista
    {
        #region Attributes
        public List<A> conjA;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
            conjA = new List<A>();
        }

        public Pessoa(A a)
        {
            conjA = new List<A>();
            conjA.Add(a);
        }

        #endregion

        #region Properties
        #endregion

        #region Functions

        bool AddA(A a)
        {
            //testar
            conjA.Add(a);
            return true;
        }
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Pessoa()
        {
        }
        #endregion

        #endregion
    }
}
