/*
*	<copyright file="Aula_07_Pilars.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2024 3:33:11 PM</date>
*	<description></description>
**/
using System;

namespace Aula_07_Pilars
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/28/2024 3:33:11 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Bike: Veiculo
    {
        #region Attributes
        public int anoB;     //ATENÇÃO
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Bike()
        {
            Console.WriteLine("Nova Bike");
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        public new int QualAno()
        {
            return AnoVeiculo.Year;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Bike()
        {
        }
        #endregion

        #endregion
    }
}
