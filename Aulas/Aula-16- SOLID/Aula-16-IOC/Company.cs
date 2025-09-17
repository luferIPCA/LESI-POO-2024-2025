/*
*	<copyright file="Company.cs" company="IPCA">
*		Copyright (c)  All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description> INVERSION OF CONTROL </description>
**/

namespace IOC
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Company
    {
        #region Attributes
        string name;
        Person cto;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Company(string n)
        {
            cto = new Person(n);     //ARRISCADO: Controlo não passa totalmente para Person
        }


        /// <summary>
        /// Aplicar Inversion of Control with Injection Dependency
        /// </summary>
        /// <param name="p"></param>
        public Company (Person p)
        {
            //if (p is null)
            //    throw new Exception();
            this.cto = p;
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Company()
        {
        }
        #endregion

        #endregion
    }

   
}
