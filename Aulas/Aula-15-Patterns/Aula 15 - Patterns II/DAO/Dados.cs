
using BO;
using System;
using System.Collections;

namespace DAO
{
    public class Dados
    {
        static ArrayList aux = new ArrayList();
        public Dados()
        {

        }

        public static ArrayList GetDados()
        {
            aux.Add(new X("Ola"));
            aux.Add(new X("Ola1"));
            aux.Add(new X("Ola2"));
            return (ArrayList)aux.Clone();
        }

        public static bool AddX(X a)
        {
            try
            {
                if (!aux.Contains(a)) { aux.Add(a); return true; }
                return false;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }

    
}
