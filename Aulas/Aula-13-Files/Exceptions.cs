/*
*	<copyright file="Aula_13_Files.cs" company="IPCA">
*		Copyright (c) 2024 All Rights Reserved
*	</copyright>
* 	<author>mustl</author>
*   <date>11/28/2024 10:36:41 AM</date>
*	<description></description>
**/
using System;

namespace FilesAndFolders
{
    /// <summary>
    /// Purpose:
    /// Created by: mustl
    /// Created on: 11/28/2024 10:36:41 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class NaoEstaAtentoException : ApplicationException
    {
        int x;
        public NaoEstaAtentoException(): base("Atento!")
        {
            x++;
        }
        public NaoEstaAtentoException(string msg) : base(msg)
        {
            x++;
        }
        public NaoEstaAtentoException(string msg, Exception e) 
        {
            string nova = msg + " qui debaixo...";
            throw new NaoEstaAtentoException(msg + e.Message);
        }


    }

}
