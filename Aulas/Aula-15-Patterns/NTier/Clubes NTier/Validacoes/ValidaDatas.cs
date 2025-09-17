/*
*	<copyright file="Clubecs.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 7:47:57 PM</date>
*	<description>Validações </description>
**/
using System;

namespace Validacoes
{
    public class ValidaDatas
    {

        public static bool ValidaData(string d)
        {
            DateTime aux;
            bool x = DateTime.TryParse(d, out aux);
            return x;
        }


    }
}
