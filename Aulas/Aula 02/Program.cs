
/*
 * lufer
 * email
 * date
 * 
 * */


using System;

namespace Aula_02
{
    /// <summary>
    /// Programa para...
    /// </summary>
    /// 


    class Program
    {
        enum Dias { SEG, TER };
        /// <summary>
        /// Calcula a soma de dois....
        /// </summary>
        /// <param name="x">Valor 1</param>
        /// <param name="y">Valor 2</param>
        /// <returns>Soma</returns>
        public  static int Soma(int x, int y) 
        {
            return x + y; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Valor de X</param>
        /// <param name="y">valor de Y</param>
        /// <returns></returns>
        public static int Sub(int x, int y)
        {
            return (x - y);
        }

      

        /// <summary>
        /// Função que...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region VAR
            Dias x;
            #endregion

            #region USO

            x = Dias.TER;

            Console.WriteLine("Valor de X= {0}", x.ToString()); //+ Correcta!!!!
            Console.WriteLine("Valor de X " + x.ToString());

            Console.WriteLine("Valor de X= {0}; {1}", x.ToString(),100);

            int s = Soma(2, 3);

            int b = Outra.Sub(2, 3);
            b = Sub(3,3);

            #endregion

        }

    }

}
