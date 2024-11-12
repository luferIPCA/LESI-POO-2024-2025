/*
*	<copyright file="Aula_07___Pilars.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>10/31/2024 10:19:06 AM</date>
*	<description></description>
**/
using Aula_08_Agregacao;
using System;


namespace Aula_08_Agregacao
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 10/31/2024 10:19:06 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Garagem : IGaragem
    {
        #region Attributes
        const int MAXCAR = 20;
        static Veiculo[] garag; 
        static int totVeiculos=0;

        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Garagem()
        {
            garag= new Veiculo[MAXCAR];
            totVeiculos = 0;
        }

        #endregion

        #region Properties

        public static int CarrosGaragem
        {
            //get => totVeiculos;
            get { return totVeiculos; }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods

        public static bool EstacionaCarro(Veiculo v)
        {
            if (totVeiculos < MAXCAR)
            {

                garag[totVeiculos++] = v;
                return true;
            }
            return false;
        }

        public bool Estaciona(Veiculo v)
        {
            return true;
        }


        public static bool ExisteCarro(string mat)
        {
            foreach(Veiculo v in garag)
            {

                //break;

            }

            for(int i=0; i < totVeiculos; i++)
            {
                //break
            }

            return true;
        }
        //SaiCarro
        //ExisteCarro
        //QuaisCarros
        //QualCarroMatricula
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Garagem()
        {
        }
        #endregion

        #endregion
    }
}
