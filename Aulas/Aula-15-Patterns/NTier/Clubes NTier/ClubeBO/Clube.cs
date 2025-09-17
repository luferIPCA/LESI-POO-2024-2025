/*
*	<copyright file="Clubecs.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 7:47:57 PM</date>
*	<description></description>
**/

using System;
using System.Collections.Generic;

namespace ClubeBO
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/14/2020 7:47:57 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Clube
    {
        #region Attributes
        string nome;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Clube()
        {
        }

        public Clube(string n)
        {
            nome = n;
        }
        #endregion

        #region Properties

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Clube()
        {
        }
        #endregion

        #endregion
    }
}
