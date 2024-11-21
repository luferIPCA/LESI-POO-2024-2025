/*
*	<copyright file="Aula_10_Varios.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/12/2024 9:48:13 AM</date>
*	<description>
*	    POO - 2024-2025
*	    Modificadores de parametros
*	    Parâmetros ref e out
*	    Operadores "is" e "as"
*	</description>
**/

using Aula_09_Libraries;
using System;

namespace Aula_10_Varios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes_Structs

            //PessoaC pesClass;
            //PessoaS pesStruct;

            //pesClass.idade = 12;    //Erro...porquê? Exige alocação de memoria        
            //criar objeto e só depois usar!

            //pesStruct.idade = 12;   //Ok


            //PessoaC[] turmaObjetos;

            //PessoaS[] turmaStructs;

            #endregion

            #region Boxing_Unboxing

            int? x = 120;
            object obj = x;     //boxing
            int aux = (int)x;   //unboxing
            int z;

            if (x is int && !(x is null))
            {
                z = (int)x;
            }

            #endregion

            #region in_as

            PessoaC p1 = new PessoaC();
            object pObj = p1;
            PessoaC p2;

            Console.WriteLine(p1 is PessoaS);      //escreve false

            if(p1 is PessoaC)
                p2 = p1 as PessoaC;

            #endregion

        }
    }
}
