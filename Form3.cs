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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                lblpour.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                new Form1().Show();
                this.Hide();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
