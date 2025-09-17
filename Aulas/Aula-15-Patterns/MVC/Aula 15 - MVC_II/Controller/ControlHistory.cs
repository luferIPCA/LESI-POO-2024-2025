/*
*	<copyright file="ControlHistory.cs" company="IPCA">
*		Copyright (c) All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date></date>
*	<description></description>
**/

using MVC_II.Model;
using MVC_II.View;
using System.Collections.Generic;

namespace MVC_II.Controller
{
    /// <summary>
    /// Purpose:
    /// Created by: lufer
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ControlHistory
    {
        #region Attributes
        private IIndicadoresHistory indHist;

        #endregion

        #region Control_Model

        #region IndicadoresHistory

        public void SetModel(IIndicadoresHistory m)
        {
            this.indHist = m;
        }

        public void NewIndicator(Indicadores i)
        {
            if (indHist != null)
            {
                //testar se não existe
                indHist.AddIndicador(i);
            }
        }

        public bool SaveHistoryII(string s)
        {
            if (indHist != null)
            {
                return indHist.SaveHistory(s);
            }
            return false;
        }

        public bool LoadHistory(string s)
        {
            if (indHist != null)
            {
                return indHist.LoadHistory(s);
            }
            return false;
        }

        #endregion

        #endregion

    }

    /// <summary>
    /// COMPLETAR
    /// </summary>
    internal class GereHistorico : IIndicadoresHistory
    {
        List<IIndicadoresModel> bd;

        public bool AddIndicador(IIndicadoresModel i)
        {
            if (bd.Contains(i)) return false;
            bd.Add(i);
            return true;
        }


    }
}
