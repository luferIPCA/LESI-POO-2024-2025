/*
*	<copyright file="Aula_10_Varios.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>11/12/2024 9:48:13 AM</date>
*	<description>
*	    POO - 2024-2025
*	    Modificadores de parametros
*	    Parametros ref e out
*	    Operadores "is" e "as"
*	</description>
**/
namespace Aula_10_Varios
{
    public struct PessoaS
    {
        public int idade;
        public string nome;

        public override string ToString()
        {
            return "Idade: " + idade + " Nome: " + nome;
        }
    }
}
