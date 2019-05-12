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
            listView1.Columns.Add("Raiz", 100);
            listView1.Columns.Add("Modulo", 100);
            listView1.Columns.Add("Angulo", 100);
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

        private void buttonTipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTransformacion.Text))
            {
                MessageBox.Show("No hay complejo para transformar", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo = new Complejo(textBoxTransformacion.Text);
                if (complejo.tipoOriginal == "Binomial")
                {
                    labelComplejoEnForma.Text = "Complejo en forma: " + complejo.tipoOriginal;
                    labelTransformado.Text = complejo.parteReal.ToString() + " + " + complejo.parteImaginaria.ToString() + "j";

                }
                else if (complejo.tipoOriginal == "Polar")
                {
                    labelComplejoEnForma.Text = "Complejo en forma: " + complejo.tipoOriginal;
                    labelTransformado.Text = "modulo: " + Math.Abs(complejo.modulo).ToString() + "    angulo: " + complejo.angulo.ToString();

                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                    labelComplejoEnForma.Text = "";
                    labelTransformado.Text = "";
                    labelTransformar.Text = "";

                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTransformar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTransformacion.Text))
            {
                MessageBox.Show("No hay complejo para transformar", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo = new Complejo(textBoxTransformacion.Text);
                if (complejo.tipoOriginal == "Binomial" || complejo.tipoOriginal == "Polar")
                {
                    labelTransformar.Text = complejo.MostrarTransformado(complejo);
                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private bool NOEstaVacio()
        {
            string error = "";
            if (string.IsNullOrEmpty(textBoxTransformacion.Text)) { error += "No hay complejo para transformar"; }

            if (error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                textBoxTransformacion.Text = "";
                return false;
            }

            return true;
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
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) || string.IsNullOrWhiteSpace(textBoxNum2.Text))
            {
                MessageBox.Show("Falta un complejo para realizar la operacion", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo1 = new Complejo(textBoxNum1.Text);
                Complejo complejo2 = new Complejo(textBoxNum2.Text);
                if ((complejo1.tipoOriginal == "Binomial" || complejo1.tipoOriginal == "Polar") && (complejo2.tipoOriginal == "Binomial" || complejo2.tipoOriginal == "Polar"))
                {
                    Complejo resultado = complejo1.Suma(complejo2);
                    resultado.modulo = Math.Round(resultado.modulo, 4);
                    resultado.angulo = Math.Round(resultado.angulo, 4);
                    labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
                    labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                }
            }
        }


        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) || string.IsNullOrWhiteSpace(textBoxNum2.Text))
            {
                MessageBox.Show("Falta un complejo para realizar la operacion", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo1 = new Complejo(textBoxNum1.Text);
                Complejo complejo2 = new Complejo(textBoxNum2.Text);
                if ((complejo1.tipoOriginal == "Binomial" || complejo1.tipoOriginal == "Polar") && (complejo2.tipoOriginal == "Binomial" || complejo2.tipoOriginal == "Polar"))
                {
                    Complejo resultado = complejo1.Resta(complejo2);
                    resultado.modulo = Math.Round(resultado.modulo, 4);
                    resultado.angulo = Math.Round(resultado.angulo, 4);
                    labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
                    labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) || string.IsNullOrWhiteSpace(textBoxNum2.Text))
            {
                MessageBox.Show("Falta un complejo para realizar la operacion", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo1 = new Complejo(textBoxNum1.Text);
                Complejo complejo2 = new Complejo(textBoxNum2.Text);
                if ((complejo1.tipoOriginal == "Binomial" || complejo1.tipoOriginal == "Polar") && (complejo2.tipoOriginal == "Binomial" || complejo2.tipoOriginal == "Polar"))
                {
                    Complejo resultado = complejo1.Multiplicacion(complejo2);
                    resultado.modulo = Math.Round(resultado.modulo, 4);
                    resultado.angulo = Math.Round(resultado.angulo, 4);
                    labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
                    labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonCociente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNum1.Text) || string.IsNullOrWhiteSpace(textBoxNum2.Text))
            {
                MessageBox.Show("Falta un complejo para realizar la operacion", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo1 = new Complejo(textBoxNum1.Text);
                Complejo complejo2 = new Complejo(textBoxNum2.Text);
                if ((complejo1.tipoOriginal == "Binomial" || complejo1.tipoOriginal == "Polar") && (complejo2.tipoOriginal == "Binomial" || complejo2.tipoOriginal == "Polar"))
                {
                    Complejo resultado = complejo1.Cociente(complejo2);
                    resultado.modulo = Math.Round(resultado.modulo, 4);
                    resultado.angulo = Math.Round(resultado.angulo, 4);
                    labelResultadoBinomica.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
                    labelResultadoPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void ButtonPotencia_Click(object sender, EventArgs e)
        {
            labelPrimitivas.Hide();
            labelAngulo.Hide();
            listView1.Items.Clear();
            if (string.IsNullOrWhiteSpace(textBoxComplejo.Text) || string.IsNullOrWhiteSpace(textBoxFactor.Text))
            {
                MessageBox.Show("Fata complejo o factor", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo = new Complejo(textBoxComplejo.Text);
                Int32 potencia = new Int32();
                if ((complejo.tipoOriginal == "Binomial" || complejo.tipoOriginal == "Polar") && Int32.TryParse(textBoxFactor.Text, out potencia))
                {
                    Complejo resultado = complejo.Potencia(potencia);
                    resultado.modulo = Math.Round(resultado.modulo, 4);
                    resultado.angulo = Math.Round(resultado.angulo, 4);
                    labelResultBinomial.Text = resultado.parteReal.ToString() + " + " + resultado.parteImaginaria.ToString() + "j";
                    labelResultPolar.Text = "modulo: " + Math.Abs(resultado.modulo).ToString() + "    angulo: " + resultado.angulo.ToString();
                    labelResultBinomial.Show();
                    labelResultPolar.Show();
                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void ButtonRadicacion_Click(object sender, EventArgs e)
        {
            labelResultBinomial.Hide();
            labelResultPolar.Hide();
            if (string.IsNullOrWhiteSpace(textBoxComplejo.Text) || string.IsNullOrWhiteSpace(textBoxFactor.Text))
            {
                MessageBox.Show("Fata complejo o factor", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Complejo complejo = new Complejo(textBoxComplejo.Text);
                Int32 factor = new Int32();
                if ((complejo.tipoOriginal == "Binomial" || complejo.tipoOriginal == "Polar") && Int32.TryParse(textBoxFactor.Text, out factor))
                {
                    Complejo[] raices = complejo.Radicacion(factor);
                    foreach (Complejo c in raices)
                    {
                        c.angulo = Math.Round(c.angulo, 4);
                        c.modulo = Math.Round(c.modulo, 4);
                    }
                    labelAngulo.Text = "Fórmula: " + raices[0].angulo.ToString() + "+2.K.pi/" + factor;
                    //ListViewItem[] items = new ListViewItem[factor];
                    listView1.Items.Clear();
                    int i = 0;
                    foreach (Complejo c in raices)
                    {
                        ListViewItem item = new ListViewItem("W" + i);
                        item.SubItems.Add(c.modulo.ToString());
                        item.SubItems.Add(c.angulo.ToString());
                        listView1.Items.Add(item);
                        //items[i] = item;
                        i++;
                    }
                    if (complejo.modulo == 1 && complejo.angulo==0) {
                        string primitivas;
                        primitivas = "Raices Primitivas:\n";
                        for (int j = 0; j < raices.Length; j++)
                        {
                            if (mcd(j, factor) == 1) {
                                primitivas= primitivas + "W" + j.ToString() + ", ";
                            }
                        }
                        labelPrimitivas.Text = primitivas.Substring(0,primitivas.Length-2);
                        labelPrimitivas.Show();
                        listView1.Refresh();
                    }
                    else
                    {
                        labelPrimitivas.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Error ingresando los datos", "Error", MessageBoxButtons.OK);
                }

            }
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
            if (this.verificarCampos())
            {
                double amplitud = double.Parse(textBoxAmplitud.Text);
                double pulsacion = 0;

                if (textBoxPulsacion.Text.Contains("PI") || textBoxPulsacion.Text.Contains("pi"))
                {
                    textBoxPulsacion.Text = textBoxPulsacion.Text.Replace("PI", "1");
                    textBoxPulsacion.Text = textBoxPulsacion.Text.Replace("pi", "1");
                    pulsacion = double.Parse(textBoxPulsacion.Text);
                    pulsacion *= Math.PI;
                    textBoxPulsacion.Text = pulsacion.ToString();

                }
                else
                {

                    pulsacion = double.Parse(textBoxPulsacion.Text);
                }

                double angulo = 0; //double.Parse(textBoxAngulo.Text); ;

                if (textBoxAngulo.Text.Contains("PI/") || textBoxAngulo.Text.Contains("pi/"))
                {
                    textBoxAngulo.Text = textBoxAngulo.Text.Replace("PI", "1");
                    textBoxAngulo.Text = textBoxAngulo.Text.Replace("pi", "1");

                    DataTable dt = new DataTable();
                    var v = dt.Compute(textBoxAngulo.Text, "");
                    angulo = double.Parse(v.ToString());

                    angulo *= Math.PI;
                    textBoxAngulo.Text = angulo.ToString();

                }
                else if (textBoxAngulo.Text.Contains("PI") || textBoxAngulo.Text.Contains("pi"))
                {
                    textBoxAngulo.Text = textBoxAngulo.Text.Replace("PI", "1");
                    textBoxAngulo.Text = textBoxAngulo.Text.Replace("pi", "1");

                    DataTable dt = new DataTable();
                    var v = dt.Compute(textBoxAngulo.Text, "");
                    angulo = double.Parse(v.ToString());

                    angulo *= Math.PI;
                    textBoxAngulo.Text = angulo.ToString();

                }
                else {

                    angulo = double.Parse(textBoxAngulo.Text);
                }

                Fasor primerFasor = new Fasor(amplitud, pulsacion, comboBoxFuncion.Text, angulo);
                labelPrimerFasor.Text = "Su primer Fasor es: " + amplitud + " " + comboBoxFuncion.Text + "(" + pulsacion + "t + ( " + angulo + "))";

                double segAmplitud = double.Parse(textBoxAmplitud2.Text);
                double segPulsacion = 0;


                if (textBoxPulsacion2.Text.Contains("PI") || textBoxPulsacion2.Text.Contains("pi"))
                {
                    textBoxPulsacion2.Text = textBoxPulsacion2.Text.Replace("PI", "1");
                    textBoxPulsacion2.Text = textBoxPulsacion2.Text.Replace("pi", "1");
                    segPulsacion = double.Parse(textBoxPulsacion2.Text);
                    segPulsacion *= Math.PI;
                    textBoxPulsacion2.Text = segPulsacion.ToString();
                }
                else
                {
                    segPulsacion = double.Parse(textBoxPulsacion2.Text);
                }

                double segAngulo = 0; // double.Parse(textBoxAngulo2.Text);

                if (textBoxAngulo2.Text.Contains("PI/") || textBoxAngulo2.Text.Contains("pi/"))
                {
                    textBoxAngulo2.Text = textBoxAngulo2.Text.Replace("PI", "1");
                    textBoxAngulo2.Text = textBoxAngulo2.Text.Replace("pi", "1");

                    DataTable dt = new DataTable();
                    var v = dt.Compute(textBoxAngulo2.Text, "");
                    segAngulo = double.Parse(v.ToString());
                    segAngulo *= Math.PI;
                    textBoxAngulo2.Text = segAngulo.ToString();

                }

                if (VerificarCampos2()) {

                    pulsacion = double.Parse(textBoxPulsacion.Text);
                    angulo = double.Parse(textBoxAngulo.Text);
                    segPulsacion = double.Parse(textBoxPulsacion2.Text);
                    segAngulo = double.Parse(textBoxAngulo2.Text);

                }


                Fasor segundoFasor = new Fasor(segAmplitud, segPulsacion, comboBoxFuncion2.Text, segAngulo);
                labelSegundoFasor.Text = "Su segundo Fasor es: " + segAmplitud + " " + comboBoxFuncion2.Text + "(" + segPulsacion + "t + ( " + segAngulo + ") )";

                primerFasor.sumarFasores(segundoFasor);
                primerFasor.complejoFinal.CorregirAngulos();
                string modulo = primerFasor.complejoFinal.modulo.ToString();
                string anguloFinal = primerFasor.complejoFinal.angulo.ToString();
                labelResultado.Text = "Resultado: " + modulo + " cos(" + primerFasor.pulsacion + "t + ( " + anguloFinal + " ) )";

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool verificarCampos()
        {
            string error = "";
            double x;
            if (string.IsNullOrWhiteSpace(textBoxAmplitud.Text)) { error += "El campo 'Amplitud' debe estar completo\n"; }
            if (string.IsNullOrWhiteSpace(textBoxPulsacion.Text)) { error += "El campo 'Pulsación' debe estar completo\n"; }
            if (string.IsNullOrWhiteSpace(textBoxAngulo.Text)) { error += "El campo 'Ángulo' debe estar completo\n"; }
            if (!double.TryParse(textBoxAmplitud.Text, out x)) { error += "El campo 'Amplitud' debe ser numérico\n"; }
            // if (!double.TryParse(textBoxPulsacion.Text, out x)) { error += "El campo 'Pulsación' debe ser numérico\n"; }
            //if (!double.TryParse(textBoxAngulo.Text, out x)) { error += "El campo 'Ángulo' debe ser numérico\n"; }
            if (string.IsNullOrWhiteSpace(comboBoxFuncion.Text)) { error += "El campo 'Funcion' debe estar completo\n"; }

            if (string.IsNullOrWhiteSpace(textBoxAmplitud2.Text)) { error += "El campo 'Amplitud' debe estar completo\n"; }
            if (string.IsNullOrWhiteSpace(textBoxPulsacion2.Text)) { error += "El campo 'Pulsación' debe estar completo\n"; }
            if (string.IsNullOrWhiteSpace(textBoxAngulo2.Text)) { error += "El campo 'Ángulo' debe estar completo\n"; }
            if (!double.TryParse(textBoxAmplitud2.Text, out x)) { error += "El campo 'Amplitud' debe ser numérico\n"; }
            //if (!double.TryParse(textBoxPulsacion2.Text, out x)) { error += "El campo 'Pulsación' debe ser numérico\n"; }
            //if (!double.TryParse(textBoxAngulo2.Text, out x)) { error += "El campo 'Ángulo' debe ser numérico\n"; }
            if (string.IsNullOrWhiteSpace(comboBoxFuncion2.Text)) { error += "El campo 'Funcion' debe estar completo\n"; }
            if (textBoxPulsacion.Text != textBoxPulsacion2.Text) { error += "Las pulsaciones deben ser las mismas para ambos fasores\n"; }

            if (error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return false;
            }


            return true;
        }

        private bool VerificarCampos2()
        {
            string error = "";
            double x;
            if (!double.TryParse(textBoxPulsacion.Text, out x)) { error += "El campo 'Pulsación' debe ser numérico\n"; }
            if (!double.TryParse(textBoxAngulo.Text, out x)) { error += "El campo 'Ángulo' debe ser numérico\n"; }
            if (!double.TryParse(textBoxPulsacion2.Text, out x)) { error += "El campo 'Pulsación 2' debe ser numérico\n"; }
            if (!double.TryParse(textBoxAngulo2.Text, out x)) { error += "El campo 'Ángulo 2' debe ser numérico\n"; }
            if (error != "")
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxAmplitud.Clear();
            textBoxPulsacion.Clear();
            comboBoxFuncion.SelectedIndex = -1;
            textBoxAngulo.Clear();
            textBoxAmplitud2.Clear();
            textBoxPulsacion2.Clear();
            comboBoxFuncion2.SelectedIndex = -1;
            textBoxAngulo2.Clear();
            labelPrimerFasor.Text = "";
            labelSegundoFasor.Text = "";
            labelResultado.Text = "";
        }

        private void labelPrimerFasor_Click(object sender, EventArgs e)
        {

        }

        private void labelSegundoFasor_Click(object sender, EventArgs e)
        {

        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

        private void tabSumaFasores_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        private Int32 mcd(Int32 a, Int32 b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }
    }
 }
