/*
 * Gestão de Sumários
 * Application Layer
 * by lufer
 * 05-06-2009
 * */

using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GereSumariosNTier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                      

        }

        /// <summary>
        /// Mostrar Sumários
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            try
            {            
                ds = SumariosBL.SumariosRules.GetSumarios(comboBox1.SelectedItem.ToString());
                dataGridView1.DataSource=ds;
                dataGridView1.DataMember="Sumarios";
                //listBox1.DataSource = ds.Tables[0];
                //listBox1.DisplayMember = ds.Tables[0].Columns[3].ColumnName;    //data column
                    ;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Professor não escreveu sumários");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SumariosBO.Sumario s = SumariosBL.SumariosRules.GetSumarioDetails(int.Parse(this.dataGridView1.CurrentCell.FormattedValue.ToString()));
                MessageBox.Show(s.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
