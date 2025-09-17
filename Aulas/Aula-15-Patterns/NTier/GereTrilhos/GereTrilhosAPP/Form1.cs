
/*
 * by lufer
 * Gestor de Trilhos
 * */

using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrilhosBLL;
using TrilhosBO;

namespace GereTrilhosAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        /// <summary>
        /// Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = this.textBox1.Text;
            //TiposTrilhos tipo ? comboBox1.TabIndex;
            
            //TiposTrilhos tipo = TiposTrilhos.Pedestre;  //Ler de comboBox1
            TiposTrilhos tipo = (TiposTrilhos)Enum.Parse(typeof(TiposTrilhos),Enum.GetName(typeof(TiposTrilhos), comboBox1.SelectedIndex),true);

            int s = TrilhoManager.SaveTrilho(new Trilho(nome,tipo));
            MessageBox.Show(s.ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Show
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            int cod = int.Parse(textBox2.Text);
            Trilho t = TrilhoManager.GetTrilho(cod);
            MessageBox.Show("Trilho: "+ t.Nome);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedIndex.ToString());
            //MessageBox.Show(Enum.GetName(typeof(TiposTrilhos), comboBox1.SelectedIndex));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
