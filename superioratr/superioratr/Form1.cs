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
            labelFormatoIncorrecto.Hide();
        }

        private void BotonHolaMundo_Click(object sender, EventArgs e)
        {

        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            Complejo complejo = new Complejo(textBoxTransformacion.Text);
            if (complejo.tipoOriginal == "Binomial")
            {
                labelFormatoIncorrecto.Hide();
                labelComplejoEnForma.Text = "Complejo en forma: " + complejo.tipoOriginal;
                labelTransformado.Text = complejo.parteReal.ToString() + " + " + complejo.parteImaginaria.ToString() + "j";
                buttonTransformar.Enabled = true;
            }
            else if (complejo.tipoOriginal == "Polar")
            {
                labelFormatoIncorrecto.Hide();
                labelComplejoEnForma.Text = "Complejo en forma: " + complejo.tipoOriginal;
                labelTransformado.Text = "modulo: " + Math.Abs(complejo.modulo).ToString() + "    angulo: " + complejo.angulo.ToString();
                buttonTransformar.Enabled = true;
            }
            else
            {
                labelFormatoIncorrecto.Show();
                labelComplejoEnForma.Text = "";
                labelTransformado.Text = "";
                labelTransformar.Text = "";
                buttonTransformar.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransformar_Click(object sender, EventArgs e)
        {
            Complejo complejo = new Complejo(textBoxTransformacion.Text);
            labelTransformar.Text = complejo.MostrarTransformado(complejo);
        }

        private void tabInicio_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTransformacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            Complejo complejo1 = new Complejo(textBoxNum1.Text);
            Complejo complejo2 = new Complejo(textBoxNum2.Text);
            Complejo resultado = complejo1.Suma(complejo2);
            labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
            labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            Complejo complejo1 = new Complejo(textBoxNum1.Text);
            Complejo complejo2 = new Complejo(textBoxNum2.Text);
            Complejo resultado = complejo1.Resta(complejo2);
            labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
            labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            Complejo complejo1 = new Complejo(textBoxNum1.Text);
            Complejo complejo2 = new Complejo(textBoxNum2.Text);
            Complejo resultado = complejo1.Multiplicacion(complejo2);
            labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
            labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
        }

        private void buttonCociente_Click(object sender, EventArgs e)
        {
            Complejo complejo1 = new Complejo(textBoxNum1.Text);
            Complejo complejo2 = new Complejo(textBoxNum2.Text);
            Complejo resultado = complejo1.Cociente(complejo2);
            labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
            labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
        }

        private void ButtonPotencia_Click(object sender, EventArgs e)
        {
            Complejo complejo = new Complejo(textBoxComplejo.Text);
            Int32 potencia = Convert.ToInt32(textBoxFactor.Text);
            Complejo resultado = complejo.Potencia(potencia);
            labelResultBinomial.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
            labelResultPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
        }

        private void ButtonRadicacion_Click(object sender, EventArgs e)
        {
            Complejo complejo = new Complejo(textBoxComplejo.Text);
            Int32 factor = Convert.ToInt32(textBoxFactor.Text);
            Complejo[] resultados = complejo.Radicacion(factor);
            labelResultPolar.Text = "modulo: " + Math.Abs(resultados[0].modulo).ToString() + "    angulo: " + resultados[0].angulo.ToString() + "+2.k.pi/" + factor;
           /* ListViewItem[] items = new ListViewItem[factor];
            for (int i = 0; i < factor; i++)
            {
                ListViewItem item = new ListViewItem("W" + i.ToString());
                item.SubItems.Add("Hola");
                items[i] = item;
            }

            listView1.Items.AddRange(items);
            listView1.Refresh(); No se muestran los items*/
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 amplitud = Convert.ToInt32(textBoxAmplitud.Text);
            Int32 pulsacion = Convert.ToInt32(textBoxPulsacion.Text);
            double angulo = double.Parse(textBoxAngulo.Text);
            Fasor primerFasor = new Fasor(amplitud, pulsacion, comboBoxFuncion.Text, angulo);

            Int32 segAmplitud = Convert.ToInt32(textBoxAmplitud.Text);
            Int32 segPulsacion = Convert.ToInt32(textBoxPulsacion.Text);
            double segAngulo = double.Parse(textBoxAngulo.Text);
            Fasor segundoFasor = new Fasor(segAmplitud, segPulsacion, comboBoxFuncion2.Text, segAngulo);

            primerFasor.sumarFasores(segundoFasor);
            double modulo = primerFasor.complejoFinal.modulo;
            double anguloFinal = primerFasor.complejoFinal.angulo;
            label15.Text = "e^" + pulsacion + primerFasor.complejoFinal.ToString();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
