/*
*	<copyright file="Aula_10_Varios.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/12/2024 9:48:13 AM</date>
*	<description>
*	    Modificadores de parametros
*	    Parametros ref e out
*	</description>
**/
using System;

namespace Aula_10_Varios
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/12/2024 9:48:13 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Varios
    {

        #region Methods

        #region Modificadores_de_Parametros

        #region Com polimorfismos...pouco eficiente
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static int Soma(int x, int y, int z)
        {
            return x + y+z;
        }

        public static int Soma(int x, int y, int z, int w)
        {
            return x + y + z + w;
        }
        #endregion

        #region parametro array - menos eficiente
        public static int Soma(int[] numbers)
        {
            int s = 0;
            for(int i=0; i < numbers.Length; i++)
            {
                s+=numbers[i];
            }
            return s;
        }
        #endregion

        #region Array de parametros - mais eficiente
        public static int BestSoma(params int[] numbers)
        {
            int s = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i];
            }
            return s;
        }
        #endregion

        #endregion

        #region Ref_Out

        public static bool ConvertToInt(string value, out int v)
        {
            int v1;
            bool x = int.TryParse(value, out v1);
            if (x)
            {
                v = v1;
                return true;

            }
            else
            {
                v = -1;
                return false;
            }
        }

        /// <summary>
        /// Não funciona!
        /// </summary>
        /// <param name="x"></param>
        public static void DoubleWrong(int x)
        {
            x = x * 2;
        }

        /// <summary>
        /// Funciona!
        /// </summary>
        /// <param name="x"></param>
        public static void DoubleOk(ref int x)
        {
            x = x * 2;
        }

        #endregion


        #endregion
    }
}
