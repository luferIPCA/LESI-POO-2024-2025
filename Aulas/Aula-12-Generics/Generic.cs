/*
*	<copyright file="Generic.cs" company="IPCA">
*		Copyright (c) 2022 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description></description>
**/
using System.Collections.Generic;

namespace Generics_II
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 4/28/2021 10:02:00 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    #region GENERIC_CLASS

    /// <summary>
    /// Class não "Generic": estado condiciona
    /// </summary>
    class XInt
    {
        public int x;               //CUIDADDO
        public int[] valores;
    }

    /// <summary>
    /// Class não "Generic": estado condiciona
    /// </summary>
    class XString
    {
        public string x;               //CUIDADDO
        public string[] valores;
    }

    /// <summary>
    /// Class "Generic": estado condiciona... array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class X<T>
    {
        public T x;               //CUIDADDO
        public T[] valores;
    }

    /// <summary>
    /// Class "Generic": estado ainda condiciona...é um array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    class X<T, K>
    {
        public K x;
        public T[] valores;
    }

    /// <summary>
    /// Class "Generic": estado ainda condiciona...é uma List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Y<T>
    {
        public T x;               //CUIDADDO
        public List<T> valores;
    }

    /// <summary>
    /// Class "Generic": estado condiciona menos
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="K"></typeparam>
    class Z<T, K>
    {
        T x;               //CUIDADDO
        public K valores;


        public T X
        {
            get => x;
            set => x = value;
        }

        /// <summary>
        /// Polimorfismo...
        /// </summary>
        /// <param name="y"></param>
        /// <param name="aux"></param>
        /// <returns></returns>
        public bool InsertValue(K y, List<K> aux)
        {
            if (!aux.Contains(y)) aux.Add(y);
            return true;
        }
        /// <summary>
        /// Polimorfismo...
        /// </summary>
        /// <param name="y"></param>
        /// <param name="aux"></param>
        /// <returns></returns>
        public bool InsertValue(K y, HashSet<K> aux)
        {
            if (!aux.Contains(y)) aux.Add(y);
            return true;
        }
    }

    #endregion
}
