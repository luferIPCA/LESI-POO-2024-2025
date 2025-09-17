/*
*	<copyright file="ComCamadas.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/13/2021 10:35:10 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using BODLL;

namespace ComCamadas
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/13/2021 10:35:10 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Apresenta
    {

        public static void MostraLista(List<Pessoa> pes)
        {

            foreach(Pessoa p in pes)
            {
                Console.WriteLine("Nome:" + p.nome);
            }
        }
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Apresenta()
        {
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Apresenta()
        {
        }
        #endregion

        #endregion
    }
}
