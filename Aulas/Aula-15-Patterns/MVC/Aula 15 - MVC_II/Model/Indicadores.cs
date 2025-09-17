/*
*	<copyright file="Indicadores.cs" company="IPCA">
*		Copyright (c)  All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description></description>
**/

using System;
using System.Collections.Generic;

namespace MVC_II.Model
{
    public interface IIndicadoresModel
    {
        int Recuperados { get; set; }
        int Mortes { get; set; }
        int Infetados { get; set; }

        void AddInfected(int v);
    }

    [Serializable]
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Indicadores : IIndicadoresModel
    {
        private int totInfetados;
        private int totMortes;
        private int totRecuperados;
        DateTime d;

        public Indicadores()
        {
            totInfetados = 0;
            totMortes = 0;
            totRecuperados = 0;
            d = DateTime.Today;
        }

        #region Metodos
        public int Infetados
        {
            set { totInfetados += value; }
            get { return totInfetados; }
        }

        public int Recuperados
        {
            set { totRecuperados += value; }
            get { return totRecuperados; }
        }

        public int Mortes
        {
            set { totMortes += value; }
            get { return totMortes; }
        }

        public void AddInfected(int v)
        {
            if (v>0)
            totInfetados += v;
        }

        #endregion
    }
}
