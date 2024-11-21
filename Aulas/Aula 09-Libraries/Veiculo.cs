/*
*	<copyright file="Aula_09_Libraries.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/5/2024 11:52:34 AM</date>
*	<description></description>
**/
using System;

namespace Aula_09_Libraries
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/5/2024 11:52:34 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculo
    {
        #region Attributes

        int ano;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
        }

        #endregion

        #region Properties

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Veiculo()
        {
        }
        #endregion

        #endregion
    }
}
