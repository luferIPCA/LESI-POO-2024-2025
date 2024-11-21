/*
*  -------------------------------------------------
* <copyright file="Carro.cs" company="IPCA"/>
* <summary>
*	POO 
* </summary>
* <date></date>
* <author>lufer</author>
* <email>lufer@ipca.pt</email>
* <desc></desc>
* -------------------------------------------------
**/
using System;

namespace MyCollections
{
    class Carro : IComparable
    {
        public string matricula;    //cuidado

        public Carro(string m)
        {
            matricula = m;
        }

        /// <summary>
        /// Com este método já é possível ordenar um ArrayList de Carro
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int CompareTo(object o)
        {
            if (!(o is Carro))
                throw new Exception("So se comparam Carros!!!");
            Carro c = o as Carro;
            return (c.matricula.CompareTo(this.matricula));
        }
    }


}
