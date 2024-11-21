using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesNS
{
    public class Calculos
    {
        public static int Soma(int x , int y)
        {
            Pessoa p = new Pessoa();
            return x + y;
        }

        public static int Soma(int x, int y, int z)
        {
            return x + y+z;
        }

        public static int Soma(int[] valores)
        {
            int s = 0;
            foreach(int i in valores)
            {
                s += valores[i];
            }
            return s;
        }


        public static int SomaII(params int[] valores)
        {
            int s = 0;
            foreach (int i in valores)
            {
                s += valores[i];
            }
            return s;
        }

        public static int Sub(int x, int y)
        {
            return x-y;
        }

        /// <summary>
        /// Inboxing
        /// "is" e "as"
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public bool Estranho(Object v)
        {
            if (v is Pessoa)
            {
                Pessoa p = v as Pessoa;
                p = (Pessoa)v;
                ((Pessoa)v).
                return true;
            }
            Pessoa p1 = v as Pessoa;

            Pessoa p2 = new QuasePessoa();
        }
    }

    public  class Pessoa
    {
        public string nome;

        public Pessoa() { }
    }

    public class QuasePessoa : Pessoa
    {
        public QuasePessoa() { }
    }
}
