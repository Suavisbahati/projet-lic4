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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textutilisateur.Text != "Groupe 13" && textPassord.Text != "123456")
            {
                MessageBox.Show("Le nom d'utilisateur ou le mot de passe est incorrect " +
                "veillez revoir le nom d'utilisateur et le mot de passe, puis reconnectez-vous",
                "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (textutilisateur.Text.Equals("Groupe 13") && textPassord.Text.Equals("123456"))
            {
                MessageBox.Show("Autoriser", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //new Frm_titre().Show();
                //this.Hide();
                new Form2().Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
