/*
*	<copyright file="Aula_07_Pilars.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/28/2024 3:32:25 PM</date>
*	<description></description>
**/
using System;

namespace Aula_07_Pilars
{
    public enum COMBOS
    {
        Gasoli=1,
        Gasol=2,
        Gas=3,
        Ele=4
    }

    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/28/2024 3:32:25 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Carro : Veiculo
    {
        #region Attributes

        string marca;
        COMBOS comb;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Carro()
        {
            marca = "";
            comb = COMBOS.Gasol;
        }

        public Carro(COMBOS c, string m)
        {
            marca = m;
            comb = c;
        }

        public Carro(COMBOS c, string m, DateTime ano)
        {
            comb = c;
            this.marca = m;
            AnoVeiculo = ano;       //Usa propriedade
        }

        public Carro(COMBOS c, DateTime ano, string m): base(ano) //usa construtor
        {
            comb = c;
            this.marca = m;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the marca.
        /// </summary>
        /// <value>
        /// The marca.
        /// </value>
        public string Marca
        {
            get { return marca.ToUpper(); }
            set { marca = value; }
        }

        public COMBOS TipoCombustivel
        {
            get { return comb; }
            set { comb = value; }
        }
        #endregion

        #region Overrides
        public override int QualAno()
        {
            return AnoVeiculo.Month;
        }

        public override bool Equals(object obj)
        {
            Carro c = obj as Carro;
            if (c == null) return false;
            return this.AnoVeiculo == c.AnoVeiculo;
        }

        public static bool operator ==(Carro c1, Carro c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Carro c1, Carro c2)
        {
            return !c1.Equals(c2);
        }

        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Carro()
        {
        }
        #endregion

        #endregion
    }
}
