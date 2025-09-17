/*
 * by lufer
 * Biblioteca BO
 * */

using System;
using System.Text;

namespace TrilhosBO
{
    /// <summary>
    /// Informação sobre um Trilho
    /// </summary>
    public class Trilho
    {
        #region Atributos

        private int codTrilho;        
        string nome;
        TiposTrilhos tipo = TiposTrilhos.Nenhum;
        Localizacao localizacao;

        #endregion

        #region Métodos

        #region Construtores

        public Trilho()
        {
        }

        public Trilho(string n, TiposTrilhos t)
        {
            tipo = t;
            nome = n;
        }
        #endregion

        #region Propriedades

        public int CodTrilho
        {
            get { return codTrilho; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public TiposTrilhos Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion
        #endregion
    }
}
