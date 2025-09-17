//ADO.NET

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BO;
namespace DL
{
    public class Dados
    {
        static List<int> valores;
        static List<Pessoa> turma;

        static Dados()
        {
            valores = new List<int>();
        }

        public static bool AddVal(int val)
        {
            if (valores.Contains(val)) return false;
            valores.Add(val);
            return (true);
        }

        public static bool ExistVal(int val)
        {
            return (valores.Contains(val));
        }

        public static bool InserePessoaBD(Pessoa p)
        {
            turma.Add(p);
            return true;
        }
    }
}
