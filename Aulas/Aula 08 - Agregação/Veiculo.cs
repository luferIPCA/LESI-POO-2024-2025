/*
*	<copyright file="Aula_07___Pilars.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2024 3:35:31 PM</date>
*	<description></description>
**/
using System;
using Aula_09_Libraries;

namespace Aula_08_Agregacao
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/28/2024 3:35:31 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Veiculo : IVeiculo, IVeiculo2
    {
        #region Attributes
        DateTime anoV;
        string mat;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veiculo()
        {
            //anoV = DateTime.Now;
            mat = "0";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Veiculo"/> class.
        /// </summary>
        /// <param name="d">The d.</param>
        public Veiculo(DateTime d)
        {
            //anoV = d;
            mat = "0";
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

        public string Matricula
        {
            get;
            set;
        }
        #endregion

        #region Overrides

        public override string ToString()
        {
            return ("Ano Veiculo:" + anoV.ToString());
        }

        public override bool Equals(object obj)
        {
            Veiculo v1 = obj as Veiculo;

            //Veiculo v2 = (Veiculo)obj;

            return (this.Matricula == v1.Matricula && anoV==v1.anoV);

        }

        //Operadores
        public static bool operator ==(Veiculo v1, Veiculo v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Veiculo v1, Veiculo v2)
        {
            return !v1.Equals(v2);
        }

        #endregion

        #region OtherMethods        
        /// <summary>
        /// Quals the ano.
        /// </summary>
        /// <returns></returns>
        public virtual int QualAno()
        {
            return anoV.Year;
        }


        /// <summary>
        /// Implementação do interface IVeiculo2
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public double Celindrada(int x)
        {
            return 2 * x;
        }

        /// <summary>
        /// Implementação do interface IVeiculo
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
