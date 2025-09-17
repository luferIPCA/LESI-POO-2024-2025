/*
*	<copyright file="Gorjeta.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description>Model</description>
**/

using System.Collections.Generic;

namespace MVCSample
{
    /// <summary>
    /// Model
    /// </summary>
    class Gorjeta
    { 
        //private fields
        private double amount;
        private double tipPercent;

        /// <summary>
        /// default constructor
        /// </summary>
        public Gorjeta()
        {
            Amount = 0;
            TipPercent = 0;
        }

        //overloaded constructor
        public Gorjeta(double amt, double percent)
        {
            Amount = amt;
            TipPercent = percent;
        }

        //public properties
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double TipPercent
        {
            get { return tipPercent; }
            set
            {
                //máximo=100
                if (value > 1)
                {
                    value /= 100;
                }
                tipPercent = value;
            }
        }

        public double CalculateTip()
        {
            //h1
            return Amount * TipPercent;
        }

        public double CalculateTotal()
        {
            return CalculateTip() + Amount;
        }

    }

    class Gorjetas
    {
        List<Gorjeta> cofre;

    }
}
