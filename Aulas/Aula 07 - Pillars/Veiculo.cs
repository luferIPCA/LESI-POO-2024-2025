/*
*	<copyright file="Aula_07_Pilars.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2024 3:35:31 PM</date>
*	<description></description>
**/
using System;

namespace Aula_07_Pilars
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/28/2024 3:35:31 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculo : IVeiculo, IOutrosMetodos
    {
        #region Attributes
        DateTime anoV;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
            anoV = DateTime.Now;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Veiculo"/> class.
        /// </summary>
        /// <param name="d">The d.</param>
        public Veiculo(DateTime d)
        {
            anoV = d;
        }

        #endregion

        #region Properties        
        /// <summary>
        /// Gets or sets the ano veiculo.
        /// </summary>
        /// <value>
        /// The ano veiculo.
        /// </value>
        public DateTime AnoVeiculo
        {
            get { return anoV; }
            set
            {
                //DateTime - analisar!!!
                DateTime aux = (DateTime)value;

                if (aux.Year < 0) anoV = DateTime.Now;

                else
                    anoV = value;
            }
        }
        #endregion

        #region Overrides

        public override string ToString()
        {
            return ("Ano Veiculo:" + anoV.ToString());
        }

        #endregion

        #region OtherMethods        
        /// <summary>
        /// Qual o ano do Veiculo?
        /// Admitido para Herança (virtual)
        /// </summary>
        /// <returns></returns>
        public virtual int QualAno()
        {
            return anoV.Year;
        }

        /// <summary>
        /// Celindrada do Veiculo
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Celindrada(int x)
        {
            return 2 * x;
        }

        /// <summary>
        /// Qual o dia? Obrigado implementar pelo Interface
        /// </summary>
        /// <returns></returns>
        public int QualDia()
        {
            return 1;
        }
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
