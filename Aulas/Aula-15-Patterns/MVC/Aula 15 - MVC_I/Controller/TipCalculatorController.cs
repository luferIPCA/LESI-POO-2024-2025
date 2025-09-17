/*
*	<copyright file="TipCalculatorController.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description>MVC: Controller Entity</description>
**/

namespace MVCSample
{
    /// <summary>
    /// Controller
    /// </summary>
    class TipCalculatorController
    {

        private Gorjeta tip;        //model
        private Display display;    //view


        /// <summary>
        /// Equivale ao nosso Main()
        /// </summary>
        public TipCalculatorController()
        {
            //create a View (display) instance
            display = new Display();
            //create a Model (Gorjeta) instance
            tip = new Gorjeta(display.Amt, display.Percentage);
            //Get Values and Instanciate the Model instance
            display.TipAmount = tip.CalculateTip();
            display.Total = tip.CalculateTotal();
            //Show results (trigger to View)
            display.ShowTipandTotal();
        }
    }
}
