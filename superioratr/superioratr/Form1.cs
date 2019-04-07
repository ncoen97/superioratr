using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superioratr
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonHolaMundo_Click(object sender, EventArgs e)
        {

        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Complejo complejo = new Complejo(textBox1.Text);
            label1.Text = "Complejo en forma: " + complejo.tipoOriginal;
            if (complejo.tipoOriginal == "Binomial")
            {
                label2.Text = complejo.parteReal.ToString() +" + " + complejo.parteImaginaria.ToString() + "j";
                button2.Enabled = true;
            }
            else if (complejo.tipoOriginal == "Polar")
            {
                label2.Text = "modulo: "+complejo.modulo.ToString() + ", angulo: " + complejo.angulo.ToString();
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }


        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complejo complejo = new Complejo(textBox1.Text);
            label3.Text = complejo.MostrarTransformado(complejo);
        }
    }
}
