namespace Aula_06
{
    /// <summary>
    /// Cada turma tem o seu conjunto de pessoas
    /// Não deve ser static
    /// </summary>
    internal class Turma
    {
        //? Analisar
        //static Pessoa[] pessoas;
        int num;
        Pessoa[] pessoas;
        int tot = 0;

        public Turma(int n)
        {
            pessoas = new Pessoa[n];
        }

        public Turma()
        {
            pessoas = new Pessoa[100];
        }

        public int Num
        {
            get => num;
            set => num = value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool RegistaPessoa(Pessoa p)
        {
            //verificar se ja existe
            if (tot < pessoas.Length)
            {
                pessoas[tot++] = p;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pessoa QuemE(int id)
        {
            foreach (Pessoa p in pessoas)
            {
                if (p.Id == id) return p;
            }
            return null;

        }
    }
}
