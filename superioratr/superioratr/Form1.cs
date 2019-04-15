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
			listView1.Columns.Add("Header", 100);
			listView1.Columns.Add("Details", 100);
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
            if (NOEstaVacio()) {

            Complejo complejo = new Complejo(textBoxTransformacion.Text);
            if (complejo.tipoOriginal == "Binomial")
            {
                labelFormatoIncorrecto.Hide();
                labelComplejoEnForma.Text = "Complejo en forma: " + complejo.tipoOriginal;
                labelTransformado.Text = complejo.parteReal.ToString() + " + " + complejo.parteImaginaria.ToString() + "j";
                
            }
            else if (complejo.tipoOriginal == "Polar")
            {
                labelFormatoIncorrecto.Hide();
                labelComplejoEnForma.Text = "Complejo en forma: " + complejo.tipoOriginal;
                labelTransformado.Text = "modulo: " + Math.Abs(complejo.modulo).ToString() + "    angulo: " + complejo.angulo.ToString();
               
            }
            else
            {
                textBoxTransformacion.Text = "";
                labelFormatoIncorrecto.Show();
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
          if(NOEstaVacio())
            {

                Complejo complejo = new Complejo(textBoxTransformacion.Text);
                labelTransformar.Text = complejo.MostrarTransformado(complejo);
            }



        }

        private bool NOEstaVacio()
        {
            string error = "";
            double x;
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
			//ListViewItem[] items = new ListViewItem[factor];
			listView1.Items.Clear();
			for (int i = 0; i < factor; i++)
            {
                ListViewItem item = new ListViewItem("W" + i.ToString());
                item.SubItems.Add("Hola");
				listView1.Items.Add(item);
				//items[i] = item;
			}

            //listView1.Items.AddRange(items);
            listView1.Refresh();
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
                } 

                double segAngulo = 0; // double.Parse(textBoxAngulo2.Text);

                if (textBoxAngulo2.Text.Contains("PI/") || textBoxAngulo2.Text.Contains("pi/"))
                {
                    textBoxAngulo2.Text = textBoxAngulo2.Text.Replace("PI", "1");
                    textBoxAngulo2.Text = textBoxAngulo2.Text.Replace("pi", "1");

                    DataTable dt = new DataTable();
                    var v = dt.Compute(textBoxAngulo2.Text,"");
                    segAngulo = double.Parse(v.ToString());
                    segAngulo *= Math.PI;

                }

                if (VerificarCampos2()) { 

                    pulsacion = double.Parse(textBoxPulsacion.Text);
                    angulo = double.Parse(textBoxAngulo.Text);
                    segPulsacion = double.Parse(textBoxPulsacion2.Text);
                    segAngulo = double.Parse(textBoxAngulo2.Text);
                    return;
                }


                Fasor segundoFasor = new Fasor(segAmplitud, segPulsacion, comboBoxFuncion2.Text, segAngulo);
                labelSegundoFasor.Text = "Su segundo Fasor es: " + segAmplitud + " " + comboBoxFuncion2.Text + "(" + segPulsacion + "t + ( " + segAngulo + ") )";

                primerFasor.sumarFasores(segundoFasor);
                primerFasor.complejoFinal.CorregirAngulos();
                string modulo = primerFasor.complejoFinal.modulo.ToString();
                string anguloFinal = primerFasor.complejoFinal.angulo.ToString();
                labelResultado.Text = "Resultado: " +  modulo + " cos(" + primerFasor.pulsacion + "t + ( " + anguloFinal + " ) )";

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
            if (string.IsNullOrWhiteSpace(textBoxAngulo2.Text)) {error += "El campo 'Ángulo' debe estar completo\n"; }
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
            if (!double.TryParse(textBoxPulsacion2.Text, out x)) { error += "El campo 'Pulsación' debe ser numérico\n"; }
            if (!double.TryParse(textBoxAngulo2.Text, out x)) { error += "El campo 'Ángulo' debe ser numérico\n"; }
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
    }
    }
