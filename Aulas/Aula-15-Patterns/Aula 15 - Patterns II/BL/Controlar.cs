using BO;
using DAO;
using System.Collections;

namespace Controlo
{
    public class Controlar
    {
        public static ArrayList GetDados(int x)
        {
            if (x>0)
            {
                return (Dados.GetDados());
            }
            return null;
        }

        public static bool AddNovo(X a)
        {
            //testar
            return (Dados.AddX(a));
        }
    }
}
