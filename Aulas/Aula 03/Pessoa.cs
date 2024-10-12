/*
*	<copyright file="Pessoa.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/1/2024 3:25:05 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;


namespace Aula_03
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/1/2024 3:25:05 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        string nome;
        int peso;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
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
        ~Pessoa()
        {
        }
        #endregion

        #endregion

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
            }
        }

        /// <summary>
        /// Property to manipulate Peso
        /// </summary>
        public int Peso
        {
            get
            {
                return peso;
            }
            set
            {
                if (value > 0)
                    peso = value;
                else
                    peso = -1;

            }
        }
    }
}
