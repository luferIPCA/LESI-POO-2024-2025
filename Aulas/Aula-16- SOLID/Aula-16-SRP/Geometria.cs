/*
*	<copyright file="SRP.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/4/2021 9:38:57 AM</date>
*	<description>
*	
 *  SOLID Design principles
 *  -  SRP: Single Responsibility Principle
 *  -  IOC: Inversion of Controll
 *  
 *  Ver: 
 *  - https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
 *  - https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design
 *  
*   </description>
**/
using System;
using System.Collections;

namespace SRP
{
    #region SRP
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Circulo
    {
        public double raio;

        public Circulo(double raio)
        {
         this.raio = raio;
        }

        public double Area()
        {
            //Pi*r*r
            return 0;
        }
    }

    public class Quadrado
    {
        public double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double Area()
        {
            //lado * lado
            return 0;
        }
    }

    /// <summary>
    /// Apenas calcula a soma das áreas
    /// Mas apresenta também no ecrã???
    /// </summary>
    class CalculaArea
    {
        protected static ArrayList shapes= new ArrayList();

        public CalculaArea()
        {
        }

        public static int AddShape(object shape)
        {
            ///Atenção
            shapes.Add(shape);
            return 1;
        }

        public static ArrayList SumAreas()
        {
            ArrayList tot=new ArrayList();

            foreach (object s in shapes) {
                if (typeof(Quadrado) == s.GetType())
                {
                    tot.Add(Math.Pow(((Quadrado)s).lado, 2));              //lado^2   
                }
                else
                        if (typeof(Circulo) == s.GetType())
                {
                    tot.Add(Math.PI * Math.Pow(((Circulo)s).raio, 2));    //PI*r^2
                }
            }
            return tot;
        }

        /// <summary>
        /// Mais uma tarefa???
        /// </summary>
        public static void ShowAreasScreen()
        {

            foreach(object s in SumAreas())
            {
                Console.WriteLine("Area:" + s.ToString());
            }

        }
    }

    #endregion



}
