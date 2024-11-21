/*
*	<copyright file="Carro.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/1/2024 3:07:13 PM</date>
*	<description></description>
**/

namespace Aula_03
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/1/2024 3:07:13 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro
    {
        #region STATE | ATTRIBUTES        //all attributes must be private

        public static string marca;        //must be private: static means class attribute
        public int ano;                    //object attribute

        #endregion

        #region BEHAVIOUR | METODOS

        /// <summary>
        /// Define a marca do carro....
        /// </summary>
        /// <param name="m">marca</param>
        public static void DefineMarca(string m)
        {
            marca = m;
        }

        public static string GetMarca()
        {
            return marca.ToUpper();
        }

        #endregion
    }


}
