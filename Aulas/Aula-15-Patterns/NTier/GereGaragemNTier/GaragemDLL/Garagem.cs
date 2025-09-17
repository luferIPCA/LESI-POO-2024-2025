using System;
using System.Collections.Generic;
using MyCarro;

namespace GaragemDLL
{
    public class Garagem
    {
        #region Attributes
        static Dictionary<int, List<Carro>> garagem;
        string empresa;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        static Garagem()
        {
            garagem = new Dictionary<int, List<Carro>>();
        }

        #endregion

        #region Properties
        #endregion


        #region Overrides
        #endregion

        #region OtherMethods

        public static bool EstacionaCarro(Carro c)
        {
            //Verificar se há garagem
            //Verificar se carro já está estacionado
            //Estacionar
            //Verificar se Lista já existe
            //Se ainda não existe Lisat de Carro
            //garagem[c.ano] = new List<Carro>();
            garagem[c.ano].Add(c);
            return true;
        }


        public static List<Carro> DevolveCarros(int ano)
        {
            //testar se ano pertence as keys do dicionario
            return (garagem[ano]);
        }


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
