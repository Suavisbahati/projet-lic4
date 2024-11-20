using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_contation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        public int selectedRow { get; private set; }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void activer_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textnom.Text, combsexe.Text, cbclasse.Text, combcours.Text, cbconduite.Text, combApplication.Text, textpointobt.Text, textpointmax.Text, textpourcentage.Text);
            MessageBox.Show("Enregistrement reussie");
            Actualiser();
        }

        private void Actualiser()

        {
            textnom.Text = "";
            combsexe.Text = "";
            cbclasse.Text = "";
            combcours.Text = "";
            cbconduite.Text = "";
            combApplication.Text = "";
            textpointobt.Text = "";
            textpointmax.Text = "";
            textpourcentage.Text = "";
          
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            textnom.Text = row.Cells[0].Value.ToString();
            combsexe.Text = row.Cells[1].Value.ToString();
            cbclasse.Text = row.Cells[2].Value.ToString();
            combcours.Text = row.Cells[3].Value.ToString();
            cbconduite.Text = row.Cells[4].Value.ToString();
            combApplication.Text = row.Cells[5].Value.ToString();
            textpointobt.Text = row.Cells[6].Value.ToString();
            textpointmax.Text = row.Cells[7].Value.ToString();
            textpourcentage.Text = row.Cells[8].Value.ToString();
       
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[0].Value = textnom.Text;
            newDataRow.Cells[1].Value = combsexe.Text;
            newDataRow.Cells[2].Value = cbclasse.Text;
            newDataRow.Cells[3].Value = combcours.Text;
            newDataRow.Cells[4].Value = cbconduite.Text;
            newDataRow.Cells[5].Value = combApplication.Text;
            newDataRow.Cells[6].Value = textpointobt.Text;
            newDataRow.Cells[7].Value = textpointmax.Text;
            newDataRow.Cells[8].Value = textpourcentage.Text;
         
            
            MessageBox.Show("Modification reussie");
            Actualiser();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textpourcentage.Text = ((float.Parse(textpointobt.Text) * 100) / float.Parse(textpointmax.Text)).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
            MessageBox.Show("Suppression reussie");
            Actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;
            
        }

        private void textpourcentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textnom_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
