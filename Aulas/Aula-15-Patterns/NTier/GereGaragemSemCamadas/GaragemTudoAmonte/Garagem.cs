/*
*	<copyright file="GaragemTudoAmonte.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2021 9:15:55 AM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;

namespace GaragemTudoAmonte
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 5/14/2021 9:15:55 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Garagem
    {
        #region Attributes
        static Dictionary<int, List<Carro>> garagem;
        string empresa;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Garagem()
        {
            garagem = new Dictionary<int, List<Carro>>();
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods

        public static bool EstacionaCarro(Carro c)
        {
            //Verificar se há garagem
            //Verificar se carro já está estacionado
            //Estacionar
            //Verificar se Lista já existe
            //Se ainda não existe Lisat de Carro
            //garagem[c.ano] = new List<Carro>();
            garagem[c.ano].Add(c);
            return true;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Garagem()
        {
        }
        #endregion

        #endregion
    }
}
