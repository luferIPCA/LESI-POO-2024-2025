using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controlo;
using BO;

namespace NTierApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            X novo = new X();                       //Objeto de Negócio
            novo.Nome = "novo";
            Controlar.AddNovo(novo);                //Camada de Regras de Negocio

            if (textBox1.Text.Length == 0) return;
            int a = int.Parse(textBox1.Text);
            dataGridView1.DataSource = Controlar.GetDados(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
