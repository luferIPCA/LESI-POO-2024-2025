/*
 * by lufer
 * Array
 * ArrayList
 * Etc.
 * Ordenar MyCollections
 *  1º Criar Classe X:IComparer
 *  2º Criar método Compare com return (1,-1 ou 0)
 *  3º Usar: arrayList.Sort(new X()) ou
 *  4º Usar: arrayList.Sort(new X(ENUMERADO))
 *  
 * URL: 
 * http://www.java2s.com/Tutorial/CSharp/CatalogCSharp.htm
 * http://www.tutorialsteacher.com/csharp/csharp-queue
 * */
using System;
using System.Collections;

namespace MyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fundamentos

            Pessoa p1 = new Pessoa();
            p1.nome = "ola1";
            p1.idade = 10;

            Pessoa p2 = new Pessoa();
            p2.nome = "ola2";
            p2.idade = 11;

            Pessoa p3 = new Pessoa();
            p3.nome = "ola3";
            p3.idade = 10;

            Pessoa[] novo = new Pessoa[20];
            novo[0] = p1;
            //novo[0] = "ola";          //é possível?
            //novo[21] = new Pessoa();  //Erro?
            Console.Write("Nome:" + novo[0].nome);

            #endregion

            #region ArrayList

            ArrayList aux = new ArrayList();
            string[] nomes = new string[] { "ola", "ole" };
            aux.Add("luis");
            aux.Add("luis");
            aux.Add(12);
            aux.Add(nomes);
            //aux.AddRange(nomes);//adiciona elementos no final do ArrayList
            aux.Add("benfica");
            aux.Add(p2);
            aux.Add(p1);

            Console.WriteLine("Size= " + aux.Count);
            aux.Remove(p1);
            Console.WriteLine("Index: " + aux.IndexOf(p1).ToString());
            Console.WriteLine("Existe Benfica: " + aux.Contains("benfica"));

            //mostrar arrayList
            for (int i = 0; i < aux.Count; i++)
            {
                if (aux[i].GetType() == typeof(Pessoa))
                {
                    Pessoa p = (Pessoa)aux[i];
                    Console.WriteLine("{0} - {1}\n", p.nome, p.idade);
                }
                else
                    Console.WriteLine(aux[i].ToString());
            }

            //acrecsenta a Queue ao ArrayList
            //aux.AddRange(myQueue);

            ShowII(aux, '\n');

            #endregion            

            #region Queues

            // Declaring a Queue  
            Queue q = new Queue();
            // Adds an element at the end of Queue i.e. Enqueue operation  
            q.Enqueue("Pankaj");
            q.Enqueue(1);
            q.Enqueue(10.5);
            q.Enqueue(true);
            q.Enqueue('A');
            q.Enqueue("Benfica");
            q.Enqueue("Portinho");
            q.Enqueue("Braguinha");
            q.Enqueue(6000000);
            q.Enqueue("Tadinhos!!!");
            //Get the number of elements present in the Queue  
            Console.WriteLine("Count : {0}", q.Count);
            Console.WriteLine();
            //Printing all the element of Queue  
            Console.WriteLine("Elements in Queue : ");
            foreach (object obj in q)
                Console.WriteLine(obj);
            Console.WriteLine();

            //Returns the "next" of the Queue without removing  
            Console.WriteLine("End element of Queue : {0}", q.Peek());
            Console.WriteLine();
            //Removes and Returns the end element of the Queue i.e. Dequeue operation  
            object TopElement = q.Dequeue();
            Console.WriteLine("Removing End element of Queue = {0}\nNow End element of Queue = {1}\n", TopElement, q.Peek());
            //Determines whether an element present or not in the Queue  
            if (q.Contains("Benfica"))
                Console.WriteLine("O Glorioso!");
            else
                Console.WriteLine("Não é clube...");
            //Copies all queue to a new Array(object)  
            Object[] ob = q.ToArray();
            Console.WriteLine();
            foreach (object obj in ob)
                Console.WriteLine(obj);
            //Adjust queue size...Trim the Queue  
            q.TrimToSize();

            //More...
            ShowII(q, '\n');
            Console.WriteLine("(Peek)   \t{0}", q.Peek());
            Console.WriteLine("(Dequeue)\t{0}", q.Dequeue());
            ShowII(q, '\n');
            //Removes all the element from Queue  
            q.Clear();
            Console.WriteLine();
            Console.WriteLine("Count : {0}", q.Count);
            Console.ReadKey();

            #endregion

            #region Stacks
            // Declaring a stack  
            Stack st = new Stack();
            // Inserting an element at the top of stack i.e. Push operation  
            st.Push("Benfica");
            st.Push(1);
            st.Push(10.5);
            st.Push(true);
            st.Push('A');
            //Get the number of elements contained in the stack  
            Console.WriteLine("Count : {0}", st.Count);
            Console.WriteLine();
            //Printing all the element of stack  
            Console.WriteLine("Element in stack : ");
            foreach (object obj in st)
                Console.WriteLine(obj);
            Console.WriteLine();
            //Returns the topmost element of the stack without removing  
            Console.WriteLine("Top most element of stack : {0}", st.Peek());
            Console.WriteLine();
            //Removes and Returns the topmost element of the stack i.e. Pop operation  
            Object TopElement1 = st.Pop();
            Console.WriteLine("Removing Top element of Stack = {0}\nNow Top element of stack = {1}\n", TopElement1, st.Peek());
            //Determines whether an element present or not in the stack  
            if (st.Contains("Benfica"))
                Console.WriteLine("O maior");
            else
                Console.WriteLine("Que clube estranho...");
            //Copies the stack to a new Array(object)  
            Object[] ob1 = st.ToArray();
            Console.WriteLine();
            foreach (object obj in ob1)
                Console.WriteLine(obj);
            //Removes all the element from stack  
            st.Clear();
            Console.WriteLine();
            Console.WriteLine("Count : {0}", st.Count);
            Console.ReadKey();
            #endregion      

            #region OrdenarCollections

            ArrayList n = new ArrayList();
            n.Add(12);
            n.Add(24);
            n.Add(7);
            n.Sort();

            n.Add("ola");

            n.Add(new Pessoa());

            Console.WriteLine("Antes de Ordenar");
            Show(n);
            //n.Sort();                    //comparar do mesmo tipo...OK!

            Console.ReadKey();
            //n.Sort();                // Porque falha? 
            n.Sort(new MyComparer(SortDirecc.Desc));

            Console.WriteLine("Depois de Ordenar");
            Show(n);

            //REVER
            aux.Clear();
            aux.Add(new Carro("12"));
            aux.Add(new Carro("10"));
            aux.Add(new Carro("14"));
            aux.Add(new Carro("18"));
            aux.Sort();

            Console.ReadKey();
            //#endregion

            #endregion

            #region Ordenar ArrayList - Carros

            ArrayList carros = new ArrayList();

            carros.Add(new Carro("19-12-12"));
            carros.Add(new Carro("12-12-13"));
            carros.Add(new Carro("13-12-12"));

            foreach (Carro c in carros)
            {
                Console.WriteLine("Mat= " + c.matricula);
            }

            carros.Sort(new MyComparer());

            foreach (Carro c in carros)
            {
                Console.WriteLine("Mat= " + c.matricula);
            }

            #endregion

            #region Ordenar MyArrayList

            //MyArrayList m = new MyArrayList();
            MyArrayList m = new MyArrayList(2);         //Capacidade multiplos de 2


            //m.MyArr.Add("ola");
            m.MyArr.Add(p1);        //Cuidado...myArr não deve ser publico
            m.MyArr.Add(p2);
            m.MyArr.Add(p1);        //A Capacidade (capacity) duplica sempre que se esgota a reservada inicialmente
            m.Insert(p1);           //correct!!!


            m.MyArr.Insert(0, p3);  //Insere na posição 0...shift rigth das existentes
            m.MyArr.Remove(p1);
            m.MyArr.Add(p1);
            //m.MyArr.Remove(p1);

            //Antes de ordenar
            m.ShowCollection();


            m.MyArr.Sort(new MyComparer());             //para ordenar é necessário um "IComparer
            //depois de ordenar
            m.ShowCollection();

            Console.WriteLine("Existe P1? " + m.MyArr.Contains(p1).ToString());
            Console.WriteLine("Em que posição está P2?" + m.MyArr.IndexOf(p2).ToString());

            Console.WriteLine("Capacidade: " + m.MyArr.Capacity.ToString());
            Console.WriteLine("Elementos: " + m.MyArr.Count.ToString());

            Console.WriteLine(m.ShowCollectionAdvanced().ToString());
            #endregion

            #region Hashtable I

            Hashtable ht = new Hashtable();
            //inicializar
            //Hashtable ht = new Hashtable() { { 1, 2 }, { 2, "ok" }, { "3", new Carro("12") } };

            //Adding item into HashTable  
            ht.Add(1, "Benfica");
            ht.Add(7, "Benfica");
            //ht.Add(1, "Porto");           //Erro: Porquê?
            ht.Add(12, "Porto");
            ht.Add(8, "Braga");
            ht.Add(4, "Outro");
            //
            Console.WriteLine("Count : {0}", ht.Count);
            if (ht.ContainsValue("Benfica"))
                Console.WriteLine("Benfica existe na HashTable");
            else
                ht.Add(5, "Benfica");

            //Get a collection of values  
            Console.WriteLine("Valores :");
            ICollection values = ht.Values;
            foreach (string str in values)
                Console.WriteLine(str);

            //Get a collection of Keys  
            Console.WriteLine("Chaves:");
            ICollection keys = ht.Keys;
            foreach (int k in keys)
                Console.WriteLine("Key: " + k + " Value: " + ht[k]); ;
            ht.Remove(3);
            ht.Clear();

            // Put keys in an ArrayList.
            ArrayList arrayList = new ArrayList(ht.Keys);
            foreach (int key in arrayList)
            {
                Console.WriteLine(key);
            }
            Console.ReadKey();
            #endregion

            #region HashTable II - Gerir Colisões
            MyHashTable h = new MyHashTable();

            //h.MyHash.Add(p1.nome, p1);
            //h.MyHash.Add(p2.nome, p2);

            //Console.WriteLine(((Pessoa)(h.MyHash[p1.nome])).nome);

            //Console.WriteLine("Contem chave ? " + h.MyHash.ContainsKey(p3.nome));
            //Console.WriteLine("Número de chaves ? " + h.MyHash.Count.ToString());

            //h.MyHash.Clear()                //limpa hash

            Console.WriteLine(h.ShowHash());

            Console.WriteLine(h.MyGetHashCode(p1.nome, 50));
            Console.WriteLine(h.MyGetHashCode(p2.nome, 50));
            Console.WriteLine(h.MyGetHashCode(p3.nome, 50));

            h.MyInsert(p1);
            h.MyInsert(p2);
            h.MyInsert(p3);
            h.MyInsert(p1);         //colisão!

            #endregion

            #region HasTableIII - Gerir Colisões

            GerePessoas hp = new GerePessoas();
            Pessoa y = new Pessoa();
            y.nome = "Ola";
            hp.AddPessoa(y);
            hp[y.nome] = y;         //Usa Indexador


            Pessoa x = new Pessoa();
            x.nome = "Ole";
            hp.AddPessoa(x);

            Pessoa z = new Pessoa();
            z.nome = "Luis";
            hp.AddPessoa(z);

            bool b = hp.ExistePessoa(z.nome);

            #endregion

            #region Arrays

            Array a = Array.CreateInstance(typeof(string), 20);

            a.SetValue("Benfica", 0);
            a.SetValue("Porto", 1);

            string s1 = (string)a.GetValue(0);

            #endregion

            #region SortedList

            Console.WriteLine("\nSortedList\n");
            SortedList sl = new SortedList();

            sl.Add(1, "Benfica");
            sl.Add(3, "Porto");
            sl.Add(4, "Braguinha");
            sl.Add(2, "Sporting");

            Console.WriteLine("Número de Elementos : {0}", sl.Count);
            if (sl.ContainsValue("Benfica"))
                Console.WriteLine("Benfica é o maior");
            else
                sl.Add(1, "Benfica");
            Console.WriteLine("Valor e chave na posição 3 = {0} , {1}", sl.GetByIndex(3), sl.GetKey(3));

            //Percorre a SortedList...mostra todas as chaves
            Console.Write("Chaves: ");
            foreach (int i in sl.Keys)
                Console.Write(i + " ");


            //Agrupa pares (k,v)  
            IList keys1 = sl.GetKeyList();
            IList values1 = sl.GetValueList();
            Console.WriteLine("\nValores :");
            foreach (object obj in values1)
                Console.WriteLine(obj);
            //Or
            Console.WriteLine("\nChaves: Valores :");
            foreach (object obj in keys1)
                Console.WriteLine("Chave: " + obj + " Valor: " + sl[obj]);

            Console.WriteLine("Index do Porto é : {0}", sl.IndexOfValue("Porto"));

            //Mostra todos os pares (k,v)

            foreach (object obj in keys1)
                Console.WriteLine("Key: {0} - Valor: {1}\n", obj, sl[obj]);


            //Remover
            //remove elemento com chave 3
            sl.Remove(3);
            // Remove um elemento num determinado index
            sl.RemoveAt(2); //?

            Console.ReadKey();

            #endregion
        }

        /// <summary>
        /// Auxiliar
        /// </summary>
        /// <param name="a"></param>
        public static void Show(ArrayList a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
        }

        public static void ShowII(IEnumerable myList, char mySeparator)
        {
            foreach (Object obj in myList)
                Console.Write("{0}{1}", mySeparator, obj);
            Console.WriteLine();
        }

    }
}
