/*
*	<copyright file="Clubecs.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 7:47:57 PM</date>
*	<description>Data Layer</description>
**/
using ClubeBO;
using System;
using System.Collections.Generic;

namespace DadosClubes
{
    public class Clubes
    {
        //
        private static List<ClubeCompleto> allClubes;

        static Clubes()
        {
            allClubes = new List<ClubeCompleto>();
        }

        /// <summary>
        /// Novo clube
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool AddClube(Clube c)
        {
            //Converter Clube em ClubeCompleto
            //ClubeCompleto cp = (ClubeCompleto)c;

            ClubeCompleto cp = new ClubeCompleto(c);
            if (allClubes.Contains(cp)) return false;
            allClubes.Add(cp);
            return true;
        }


        public static bool AddCampeonatoClube(DateTime c, string n)
        {
            foreach (ClubeCompleto cp in allClubes)
            {
                if (cp.c.Nome == n)
                {
                    cp.AddCampeonato(c); return true;
                }
            }
            return false;
        }


        public static bool SaveAll(String f)
        {
            return true;
        }

        public static bool LoadAll(String f)
        {
            return true;
        }


        public Clube GetClubeEssential(string n)
        {
            foreach(ClubeCompleto cp in allClubes)
            {
                if (cp.c.Nome == n)
                {
                    return (cp.c);
                }
            }
            return null;
        }

        public List<DateTime> GetClubeHist(string n)
        {
            foreach (ClubeCompleto cp in allClubes)
            {
                if (cp.c.Nome == n)
                {
                    return (cp.datasCampeonatos);
                }
            }
            return null;
        }


    }


    /// <summary>
    /// Preservar dados de um Clube
    /// </summary>
    class ClubeCompleto
    {
        public Clube c;
        public List<DateTime> datasCampeonatos;

        public ClubeCompleto(Clube c)
        {
            this.c = c;
            datasCampeonatos = new List<DateTime>();
        }

        public ClubeCompleto(Clube c, DateTime cp)
        {
            this.c = c;
            datasCampeonatos = new List<DateTime>();
            datasCampeonatos.Add(cp);
        }


        public bool AddCampeonato(DateTime d)
        {
            //testar
            datasCampeonatos.Add(d);
            return true;
        }     

    }
}
