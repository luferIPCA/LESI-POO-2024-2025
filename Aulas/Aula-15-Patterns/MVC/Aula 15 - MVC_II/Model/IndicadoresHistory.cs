/*
*	<copyright file="IndicadoresHistory.cs" company="IPCA">
*		Copyright (c) All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MVC_II.Controller;

namespace MVC_II.Model
{

    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    [Serializable]
    public class IndicadoresHistory : IIndicadoresHistory
    {
        List<IIndicadoresModel> hist;

        public IndicadoresHistory()
        {
            hist = new List<IIndicadoresModel>();
        }

        public bool AddIndicador(IIndicadoresModel i)
        {
            if (hist != null)
                if (!hist.Contains(i))
                {
                    hist.Add(i);
                    return true;
                }
            return false;
        }


        /// <summary>
        /// Preservar
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveHistory(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.OpenOrCreate,FileAccess.ReadWrite);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, hist);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }


        /// <summary>
        /// Load Data
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool LoadHistory(string fileName)
        {
            if (File.Exists(fileName))
            {
                try
                {
                    Stream stream = File.Open(fileName, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    hist = (List<IIndicadoresModel>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
            }
            return false;
        }
    }
}
