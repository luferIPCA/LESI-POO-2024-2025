/*
 * MyCollections
 * http://www.tutorialspoint.com/csharp/csharp_collections.htm
 * 
 * ArrayList
 * Enumerators
 * 
 * POO
 * by lufer
 * */
using System;
using System.Collections;
using System.Text;

namespace MyCollections
{
    /// <summary>
    /// Gerir um ArrayList
    /// </summary>
    class MyArrayList
    {
        string nome;
        ArrayList myArr;

        #region Construtores
        public MyArrayList()
        {
            myArr = new ArrayList();
        }

        public MyArrayList(int n)
        {
            myArr = new ArrayList(n);
        }

        #endregion

        #region Propriedades
        /// <summary>
        /// Cuidado...usar clone!
        /// </summary>
        public ArrayList MyArr
        {
            get { return (ArrayList)myArr.Clone(); }
            //get { return myArr;}  //EVITAR
            set { myArr=value;}
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Mostra ArrayList
        /// </summary>
        public void Show(){
            for (int i = 0; i < myArr.Count; i++)
            {
                Console.WriteLine(myArr[i].ToString());
            }
        }

        /// <summary>
        /// Mostra ArrayList II....
        /// </summary>
        /// <param name="r"></param>
        public void ShowCollection()
        {
            //for (int i = 0; i < r.Count; i++)
            //{
            //    Console.WriteLine(r[i].ToString());
            //}

            foreach (object o in myArr)
            {
                //Console.WriteLine(o.GetType());
                if (o.GetType() == typeof(int))                                 //int
                {
                    Console.WriteLine("Int: " + o.ToString()); continue;
                }
                if (o.GetType() == typeof(string))                              //string
                {
                    Console.WriteLine("Str: " + o.ToString()); continue;
                }
                if (o.GetType() == typeof(string[]))                            //array
                {
                    Console.WriteLine("Str[]: " + o.ToString()); continue;
                }
                if (o.GetType() == typeof(Pessoa))                              //struct or classe
                {
                    Pessoa aux = (Pessoa)o;

                    Console.WriteLine("Pessoa: Idade=" + aux.idade.ToString() + " Nome=" + aux.nome); continue;
                }
            }

        }


        /// <summary>
        /// Utilizar um Enumerator
        /// </summary>
        /// <returns></returns>
        public StringBuilder ShowCollectionAdvanced()
        {
            IEnumerator enu = myArr.GetEnumerator();        //herda next, previous, current, etc...
            StringBuilder buffer = new StringBuilder();    
           
            while ( enu.MoveNext() )
            {
                buffer.Append( ((Pessoa)enu.Current).nome + "\n" );
            }
            return buffer;
        }


        public bool Insert(object x)
        {
            if (!myArr.Contains(x))
            {
                myArr.Add(x);
                return true;
            }
            return false;
        }
        #endregion

       
    }
}
