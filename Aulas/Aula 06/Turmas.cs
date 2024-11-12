namespace Aula_06
{
    /// <summary>
    /// Gestão de várias Turmas
    /// O conjunto de turmas é único (static)
    /// </summary>
    internal class Turmas
    {
        const int MAX = 100;
        static Turma[] turmas = new Turma[MAX];
        static int totTurmas = 0;

        /// <summary>
        /// Rgista nova turma
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static bool RegistaTurma(Turma t)
        {
            if (ExisteTurma(t.Num)) return false;
            turmas[totTurmas++] = t;
            return true;
        }

        /// <summary>
        /// Verfica de determinado numero de turma existe
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool ExisteTurma(int num)
        {
            foreach (Turma t in turmas)
            {
                if (t.Num == num) return true;
            }
            return false;
        }

        /// <summary>
        /// Devolve informação sobre a turma com um determonado número
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Turma QualTurma(int num)
        {
            foreach (Turma t in turmas)
            {
                if (t.Num == num) return t;
            }
            return null;
        }

    }
}
