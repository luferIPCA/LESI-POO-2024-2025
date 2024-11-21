/**
 * Manipulação de HashTables
 * Gestão de colisões
 * Funções de Hash
 * */

using System.Collections;

namespace MyCollections
{

    class GerePessoas
    {
        private Hashtable h;
        //private int[] valores;

        public GerePessoas()
        {
            h=new Hashtable();
        }

        /// <summary>
        /// Indexador
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Pessoa this[string n]
        {
            get
            {
                //if (h.ContainsKey(Fh(n))) return (Pessoa1)h[Fh(n)];
                //return null;
                //ou
                return (QualPessoa(n));
            }
            set => AddPessoa(value);
        }

        public Hashtable H
        {
            get => h;
        }

        public bool AddPessoa(Pessoa p)
        {
            //h.Add(Fh(p.nome), p);       //Pode causar colisão
            char k = Fh(p.nome);

            if (!h.ContainsKey(k))      //se a chave ainda não existe
                h[k] = new ArrayList(); //crio arraylist
            ((ArrayList)h[k]).Add(p);   //inserir no arraylist
            //Preferivel;
            //GereArrayList.Insert((ArrayList)h[k], p)
            return true;
        }

        public Pessoa QualPessoa(string n)
        {
            char k = Fh(n);
            if (h.ContainsKey(k))
            {
                return (GereArrayList.Find((ArrayList)h[k], n));
               
            }
            return null;
        }

        public bool ExistePessoa(string nome)
        {
            char k = Fh(nome);
            if (h.ContainsKey(k))
            {
                ArrayList aux = (ArrayList)h[k];
                return (GereArrayList.Existe(aux, nome));

            }
            return false;
        }

        public bool RemovePessoa(Pessoa p)
        {
            //GereArrayList.Remove((ArrayList)h[Fh(p.nome)], p)
            char k = Fh(p.nome);
            if (h.ContainsKey(k))
                ((ArrayList)h[k]).Remove(p);
            return false;
        }

        #region Auxiliar

        /// <summary>
        /// Função de Hashing
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public char Fh(string nome)
        {
            return nome[0];
       }

        #endregion
    }
}
