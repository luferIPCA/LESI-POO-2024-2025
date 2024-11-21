/*
*	<copyright file="Calculadora.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/8/2024 3:36:02 PM</date>
*	<description></description>
**/

namespace Aula_05
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/8/2024 3:36:02 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Calculadora
    {
        #region Attributes
        int x;
        int y;
        int resultado;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Calculadora()
        {
        }

        public Calculadora(int x, int y)
        {
            //this.x = x;
            X = x;
            Y = y;
        }

        #endregion

        #region Properties
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        #endregion

        #region Functions
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Soma()
        {
            return x + y;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Soma(int a, int b)
        {
            return a + b;
        }

        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Calculadora()
        {
        }
        #endregion

        #endregion
    }
}
