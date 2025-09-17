/*
*	<copyright file="Display.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description></description>
**/
using System;

namespace MVCSample
{
    class Display
    {
        //private fields
        private double perc;
        private double amt;
        private double total;
        private double tipAmount;

        //constructor
        public Display()
        {
            Percentage = 0;
            TipAmount = 0;
            Amt = 0;
            Total = 0;
            //Get values from user
            GetValues();
        }

        //public properties
        public double TipAmount
        {
            get { return tipAmount; }
            set { tipAmount = value; }
        }


        public double Total
        {
            get { return total; }
            set { total = value; }
        }


        public double Percentage
        {
            get { return perc; }
            set { perc = value; }
        }

        public double Amt
        {
            get { return amt; }
            set { amt = value; }
        }

        //private method for getting input
        //it is called in the constructor
        private void GetValues()
        {
            Console.WriteLine("Custo da Refeição:");
            Amt = double.Parse(Console.ReadLine());         //Attention!!! Parsing!

            Console.WriteLine("Gorjeta que pretende oferecer (%)");
            Percentage = double.Parse(Console.ReadLine()); //Attention!!! Parsing!
        }

        //public method to show output
        //public so I can access it from the controller
        public void ShowTipandTotal()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("A sua gorjeta é {0:C}", TipAmount); //"C" - Coin...moeda...para euros definir Encoding!!!
            Console.WriteLine("Custo total: {0:C}", Total);        //see https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
            Console.ReadKey();
        }



    }
}
