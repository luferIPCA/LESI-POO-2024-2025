/*
 * MyCollections
 * 
 * http://www.tutorialspoint.com/csharp/csharp_collections.htm
 * 
 * HashTables 
 * 
 * "Hashing": Converter valor (chave aplicacional) em index único (chave) de um array
 * 
 * Exemplo: converter "números de BI" num número de acesso único!
 * POO
 * by lufer
 * */

using System.Collections;
using System.Text;

namespace MyCollections
{
    /// <summary>
    /// Gerir uma HashTable
    /// </summary>
    class MyHashTable
    {

        const int HASHSIZE=50;
        private Hashtable myHash;

        public MyHashTable()
        {
            myHash = new Hashtable();
        }

        /// <summary>
        /// Cuidado!
        /// </summary>
        public Hashtable MyHash
        {
            get {return myHash;}
            set {myHash=value;}
        }


        /// <summary>
        /// Mostra toda a Hash com Enumerator
        /// </summary>
        /// <returns></returns>
        public StringBuilder ShowHash()
        {
            IDictionaryEnumerator enumerator = myHash.GetEnumerator();
            StringBuilder buffer = new StringBuilder();
            while (enumerator.MoveNext())
            {
                buffer.Append("Chave: " + enumerator.Key + " Valor= " + ((Pessoa)(enumerator.Value)).idade + " \n");
            }
            return buffer;
        }

        #region Gerir Colisões
        /// <summary>
        /// Hashing Function: "x % max"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int MyGetHashCode(string s, int max)
        {
            char[] aux = s.ToCharArray();
            int key = 0;
            foreach(char c in aux)
            {
                key += (int)c;
            }
            return (key % max);
        }


        /// <summary>
        /// Inserir com tratamento de colisões
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool MyInsert(object o)
        {
            if (o.GetType() == typeof(int))
            {
            }
            else
            {
                int key = MyGetHashCode(((Pessoa)o).nome, HASHSIZE);  //descobre a hask key

                if (!myHash.ContainsKey(key))
                {
                    myHash.Add(key, new ArrayList());       //Se não existe cria o ArrayList
                }
                ((ArrayList)(myHash[key])).Add(o);          //insere!
            }
            return true;

            //int k=p.Ano;
            //if (!produtos.ContainsKey(k))
            //{
            //    produtos.Add(key, new List<Product>());       //Se não existe cria o ArrayList
            //}
            //produtos[key].Add(p)

        }

        #endregion
    }
}
