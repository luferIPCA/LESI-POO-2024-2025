/*
 * * by lufer
 * Array
 * ArrayList
 * Etc.
 * Ordenar MyCollections
 *  1º Criar Classe X:IComparer
 *  2º Criar método Compare com return (1,-1 ou 0)
 *  3º Usar: arrayList.Sort(new X()) ou
 *  4º Usar: arrayList.Sort(new X(ENUMERADO))
 *  
 * URLs: 
 * http://www.java2s.com/Tutorial/CSharp/CatalogCSharp.htm
 * http://www.tutorialspoint.com/csharp/csharp_collections.htm
 * */

using System;
using System.Collections;
using System.Text;

namespace MyCollections
{
    /// <summary>
    /// Auxiliar para Ordenação
    /// </summary>
    public enum SortDirecc
    {
        Asc,
        Desc
    }


    /// <summary>
    /// Para Sort de MyCollections
    /// </summary>
    class MyComparer : IComparer
    {
         private SortDirecc dir;        //Asc, Desc
         public MyComparer()
         {
             dir = SortDirecc.Asc;             
         }
        public MyComparer(SortDirecc dir)
        {
            this.dir = dir;
        }

        /// <summary>
        /// Comparador: IComparer.Compare...só para inteiros!
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        //public int Compare(object x, object y)
        //{
        //    int a = (int)x;
        //    int b = (int)y;
        //    return (a > b ? 1 : (a == b ? 0 : -1));

        //}

        /// <summary>
        /// 0 - iguais
        /// 1 - x>y
        /// -1 - x<y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            //Se algum é null
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
                return 0;

            //if ((x is int) && (y is int))
            //{
                
            //}
            if (x.GetType() == typeof(int) && y.GetType() == typeof(int))       //int
            {
                int a = (int)x;
                int b = (int)y;
                //return (a > b ? 1 : (a == b ? 0 : -1));

                if (dir == SortDirecc.Asc)
                    return (a > b ? 1 : (a == b ? 0 : -1));
                else
                    return (a > b ? -1 : (a == b ? 0 : 1));

            }

            if (x.GetType() == typeof(Pessoa) && y.GetType() == typeof(Pessoa))  //struct or classe
            {
                //assumi comparar só as idades
                int i1 = ((Pessoa)x).idade;
                int i2 = ((Pessoa)y).idade;


                //a ? : 

                //if (i1 > i2)
                //{
                //    return 1;                    
                //}
                //else{
                //    if (i1 == i2) return 0;
                //    else return (-1);
                //}


                return (i1 > i2 ? 1 : (i1 == i2 ? 0 : -1));
            }

            if (x.GetType() == typeof(string) && y.GetType() == typeof(string))  //string
            {
                //((String)y).CompareTo("ola");
                return (String.Compare((String)x, (String)y));
            }

            if (x.GetType() == typeof(Carro) && y.GetType() == typeof(Carro))  //string
            {
                Carro aux1 = (Carro)x;
                Carro aux2 = (Carro)y;
     
                return (String.Compare(aux1.matricula, aux2.matricula));
            }

            return -1;
        }

        
    }
    
}
