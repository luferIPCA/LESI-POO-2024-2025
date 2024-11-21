/*
*	<copyright file="Aula_04.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/3/2024 10:23:54 AM</date>
*	<description>Classe para </description>
**/
using System;

namespace Aula_04
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// Created on: 10/3/2024 10:23:54 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Aluno
    {
        #region Attributes

        string nomePessoa;
        int idade;
        string morada;          //definir propriedade...

        #endregion

        #region Methods

        #region A_LA_JAVA
        public bool DefineNome(string n)
        {
            nomePessoa = n;
            return true;
        }

        public string QualNome()
        {
            return nomePessoa.ToUpper();
        }
        #endregion

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Aluno()
        {
            Nome = "";
            idade = 0;
            morada = "Barcelos";
        }

        public Aluno(string nome)
        {
            //nomePessoa=nome;
            Nome = nome;
            idade = 0;
        }

        public Aluno(string nome, int idade)
        {
            //nomePessoa=nome;
            Nome = nome;
            //this.idade= idade;
            Idade = idade;

        }

        #endregion

        #region Properties
        public string Nome
        {
            //=>
            get { return nomePessoa.ToUpper(); }
            set
            {
                if (value.Length > 0)
                    nomePessoa = value;
            }
        }

        public int Idade
        {
            set { if (value > 0 && value < 200) idade = value; }
        }

        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        public DateTime DataNascimento()
        {
            return DateTime.Today;
        }

        public string Regiao()
        {
            return "";
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Aluno()
        {
            //
        }
        #endregion

        #endregion
    }
}
