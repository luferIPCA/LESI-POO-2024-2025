/**
 * lufer
 * POO-2024-2025
 * Variaveis de classe e de instância
 * static
 **/

namespace Aula_06
{
    /// <summary>
    /// Classe pode ter dados de class com uso de static
    /// </summary>
    class Pessoa
    {
        int id;
        string nome;

        //H2: variaveis de class
        //static Pessoa[] t;
        //static int tot = 0;

        public Pessoa()
        {
            id = 0;
            nome = "";
        }

        public Pessoa(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
