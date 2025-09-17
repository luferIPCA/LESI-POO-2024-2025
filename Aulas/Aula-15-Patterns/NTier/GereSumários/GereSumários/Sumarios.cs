using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GereSumários
{
    public partial class Sumarios : Form
    {
        public Sumarios()
        {
            InitializeComponent();
        }

        private void Sumarios_Load(object sender, EventArgs e)
        {

            ArrayList aux = new ArrayList();

            aux.Add(new Clube("Benfica"));
            aux.Add(new Clube("Porto"));
            aux.Add(new Clube("Sporting"));
            aux.Add(new Clube("Braguinha"));

            dataGridView2.DataSource = aux;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    [Serializable]
    class Clube
    {
        public string nome;

        public Clube(string n)
        {
            nome = n;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}
