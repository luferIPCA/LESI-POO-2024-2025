/*
*	<copyright file="Clubecs.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>5/14/2020 7:47:57 PM</date>
*	<description></description>
**/
using ClubeBO;
using ClubesRN;
using System;
using Validacoes;

namespace GereClubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gere Clubes");

            Clube c = new Clube("benfica");

            //ValidaDatas.ValidaData("12-12-2020");

            try
            {
                RegrasClubes.InsereCampeonatoClube(DateTime.Today, "benfica");

                if (RegrasClubes.InsereClube(c) == true)
                    Console.WriteLine("Nome:" + c.Nome);
                else
                    Console.WriteLine("Insucesso!");
            }
            catch (InsertException e) { }
            catch (Exception s)
            {

            }

            RegrasClubes.GravaClubes(@"c:\temp\all.bin");
            Console.ReadKey();
        }
    }
}
