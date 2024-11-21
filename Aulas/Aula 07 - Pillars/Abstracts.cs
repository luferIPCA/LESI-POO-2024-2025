/*
*	<copyright file="Aula_07_Pilars.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/12/2024 10:41:00 AM</date>
*	<description>Classes Abstracts</description>
**/
using System;

namespace Aula_07_Pilars
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbsVeiculo : Veiculo
    {
        int x;
        int celind;
        /// <summary>
        /// new pois a classe pai já tem o método "Celindrara" implementado
        /// </summary>
        /// <param name="ano"></param>
        /// <returns></returns>
        public abstract new double Celindrada(int ano);
        public abstract int QualMes();
    }
}
