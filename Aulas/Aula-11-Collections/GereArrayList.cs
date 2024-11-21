/*
*	<copyright file="GereArrayList.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description></description>
**/

using System.Collections;
using System.Collections.Generic;

namespace MyCollections
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/16/2021 11:09:05 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class GereArrayList
    {
        #region Attributes
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public GereArrayList()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool Existe(ArrayList x, string nome)
        {

            foreach (object obj in x)
            {
                if (obj is Pessoa)
                {
                    Pessoa aux = (Pessoa)obj;
                    if (aux.nome == nome)
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Pessoa? - Nullable value ...pode devolver null
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Pessoa Find(ArrayList x, string n)
        {
            foreach (object obj in x)
            {
                if (obj is Pessoa)
                {
                    Pessoa aux = (Pessoa)obj;
                    if (aux.nome == n)
                        return aux;
                }
            }
            return null;
        }

        public static Pessoa Find(List<Pessoa> x, string n)
        {
            foreach (object obj in x)
            {
                if (obj is Pessoa)
                {
                    Pessoa aux = (Pessoa)obj;
                    if (aux.nome == n)
                        return aux;
                }
            }
            return null;
        }

        public static Pessoa Find(Dictionary<int,Pessoa> x, string n)
        {
            foreach (object obj in x)
            {
                if (obj is Pessoa)
                {
                    Pessoa aux = (Pessoa)obj;
                    if (aux.nome == n)
                        return aux;
                }
            }
            return null;
        }

        public static bool Insert(ArrayList x, object o)
        {
            return true;
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~GereArrayList()
        {
        }
        #endregion

        #endregion
    }
}
