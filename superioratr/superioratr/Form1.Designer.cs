namespace superioratr
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabInicio = new System.Windows.Forms.TabPage();
			this.labelFormatoIncorrecto = new System.Windows.Forms.Label();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.labelTransformar = new System.Windows.Forms.Label();
			this.buttonTransformar = new System.Windows.Forms.Button();
			this.labelTransformado = new System.Windows.Forms.Label();
			this.buttonTipo = new System.Windows.Forms.Button();
			this.labelComplejoEnForma = new System.Windows.Forms.Label();
			this.textBoxTransformacion = new System.Windows.Forms.TextBox();
			this.tabOperacionesBasicas = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.labelResultadoPolar = new System.Windows.Forms.Label();
			this.buttonMultiplicacion = new System.Windows.Forms.Button();
			this.buttonResta = new System.Windows.Forms.Button();
			this.buttonCociente = new System.Windows.Forms.Button();
			this.buttonSuma = new System.Windows.Forms.Button();
			this.labelResultadoBinomica = new System.Windows.Forms.Label();
			this.textBoxNum2 = new System.Windows.Forms.TextBox();
			this.textBoxNum1 = new System.Windows.Forms.TextBox();
			this.tabOperacionesAvanzadas = new System.Windows.Forms.TabPage();
			this.tabSumaFasores = new System.Windows.Forms.TabPage();
			this.textBoxComplejo = new System.Windows.Forms.TextBox();
			this.textBoxFactor = new System.Windows.Forms.TextBox();
			this.buttonPotencia = new System.Windows.Forms.Button();
			this.buttonRadicacion = new System.Windows.Forms.Button();
			this.labelComplejo = new System.Windows.Forms.Label();
			this.labelFactor = new System.Windows.Forms.Label();
			this.labelInfoResultBinomial = new System.Windows.Forms.Label();
			this.labelInfoResultPolar = new System.Windows.Forms.Label();
			this.labelResultPolar = new System.Windows.Forms.Label();
			this.labelResultBinomial = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabInicio.SuspendLayout();
			this.tabOperacionesBasicas.SuspendLayout();
			this.tabOperacionesAvanzadas.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabInicio);
			this.tabControl.Controls.Add(this.tabOperacionesBasicas);
			this.tabControl.Controls.Add(this.tabOperacionesAvanzadas);
			this.tabControl.Controls.Add(this.tabSumaFasores);
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(776, 426);
			this.tabControl.TabIndex = 1;
			// 
			// tabInicio
			// 
			this.tabInicio.Controls.Add(this.labelFormatoIncorrecto);
			this.tabInicio.Controls.Add(this.labelTitulo);
			this.tabInicio.Controls.Add(this.labelTransformar);
			this.tabInicio.Controls.Add(this.buttonTransformar);
			this.tabInicio.Controls.Add(this.labelTransformado);
			this.tabInicio.Controls.Add(this.buttonTipo);
			this.tabInicio.Controls.Add(this.labelComplejoEnForma);
			this.tabInicio.Controls.Add(this.textBoxTransformacion);
			this.tabInicio.Location = new System.Drawing.Point(4, 22);
			this.tabInicio.Name = "tabInicio";
			this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
			this.tabInicio.Size = new System.Drawing.Size(768, 400);
			this.tabInicio.TabIndex = 0;
			this.tabInicio.Text = "Inicio";
			this.tabInicio.UseVisualStyleBackColor = true;
			// 
			// labelFormatoIncorrecto
			// 
			this.labelFormatoIncorrecto.AutoSize = true;
			this.labelFormatoIncorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.labelFormatoIncorrecto.ForeColor = System.Drawing.Color.Red;
			this.labelFormatoIncorrecto.Location = new System.Drawing.Point(329, 84);
			this.labelFormatoIncorrecto.Name = "labelFormatoIncorrecto";
			this.labelFormatoIncorrecto.Size = new System.Drawing.Size(127, 17);
			this.labelFormatoIncorrecto.TabIndex = 7;
			this.labelFormatoIncorrecto.Text = "Formato Incorrecto";
			// 
			// labelTitulo
			// 
			this.labelTitulo.AutoSize = true;
			this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.Location = new System.Drawing.Point(100, 20);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(169, 25);
			this.labelTitulo.TabIndex = 6;
			this.labelTitulo.Text = "Transformaciones";
			this.labelTitulo.Click += new System.EventHandler(this.label4_Click);
			// 
			// labelTransformar
			// 
			this.labelTransformar.AutoSize = true;
			this.labelTransformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTransformar.Location = new System.Drawing.Point(341, 223);
			this.labelTransformar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTransformar.Name = "labelTransformar";
			this.labelTransformar.Size = new System.Drawing.Size(0, 17);
			this.labelTransformar.TabIndex = 5;
			// 
			// buttonTransformar
			// 
			this.buttonTransformar.Enabled = false;
			this.buttonTransformar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTransformar.Location = new System.Drawing.Point(344, 150);
			this.buttonTransformar.Margin = new System.Windows.Forms.Padding(2);
			this.buttonTransformar.Name = "buttonTransformar";
			this.buttonTransformar.Size = new System.Drawing.Size(116, 50);
			this.buttonTransformar.TabIndex = 4;
			this.buttonTransformar.Text = "Transformar";
			this.buttonTransformar.UseVisualStyleBackColor = true;
			this.buttonTransformar.Click += new System.EventHandler(this.buttonTransformar_Click);
			// 
			// labelTransformado
			// 
			this.labelTransformado.AutoSize = true;
			this.labelTransformado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTransformado.Location = new System.Drawing.Point(102, 249);
			this.labelTransformado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTransformado.Name = "labelTransformado";
			this.labelTransformado.Size = new System.Drawing.Size(0, 17);
			this.labelTransformado.TabIndex = 3;
			this.labelTransformado.Click += new System.EventHandler(this.label2_Click);
			// 
			// buttonTipo
			// 
			this.buttonTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTipo.Location = new System.Drawing.Point(105, 150);
			this.buttonTipo.Margin = new System.Windows.Forms.Padding(2);
			this.buttonTipo.Name = "buttonTipo";
			this.buttonTipo.Size = new System.Drawing.Size(116, 50);
			this.buttonTipo.TabIndex = 2;
			this.buttonTipo.Text = "Tipo de dato ingresado";
			this.buttonTipo.UseVisualStyleBackColor = true;
			this.buttonTipo.Click += new System.EventHandler(this.buttonTipo_Click);
			// 
			// labelComplejoEnForma
			// 
			this.labelComplejoEnForma.AutoSize = true;
			this.labelComplejoEnForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelComplejoEnForma.Location = new System.Drawing.Point(102, 223);
			this.labelComplejoEnForma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelComplejoEnForma.Name = "labelComplejoEnForma";
			this.labelComplejoEnForma.Size = new System.Drawing.Size(0, 17);
			this.labelComplejoEnForma.TabIndex = 1;
			// 
			// textBoxTransformacion
			// 
			this.textBoxTransformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTransformacion.Location = new System.Drawing.Point(105, 78);
			this.textBoxTransformacion.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxTransformacion.Name = "textBoxTransformacion";
			this.textBoxTransformacion.Size = new System.Drawing.Size(163, 23);
			this.textBoxTransformacion.TabIndex = 0;
			this.textBoxTransformacion.TextChanged += new System.EventHandler(this.textBoxTransformacion_TextChanged);
			// 
			// tabOperacionesBasicas
			// 
			this.tabOperacionesBasicas.Controls.Add(this.label5);
			this.tabOperacionesBasicas.Controls.Add(this.label4);
			this.tabOperacionesBasicas.Controls.Add(this.labelResultadoPolar);
			this.tabOperacionesBasicas.Controls.Add(this.buttonMultiplicacion);
			this.tabOperacionesBasicas.Controls.Add(this.buttonResta);
			this.tabOperacionesBasicas.Controls.Add(this.buttonCociente);
			this.tabOperacionesBasicas.Controls.Add(this.buttonSuma);
			this.tabOperacionesBasicas.Controls.Add(this.labelResultadoBinomica);
			this.tabOperacionesBasicas.Controls.Add(this.textBoxNum2);
			this.tabOperacionesBasicas.Controls.Add(this.textBoxNum1);
			this.tabOperacionesBasicas.Location = new System.Drawing.Point(4, 22);
			this.tabOperacionesBasicas.Name = "tabOperacionesBasicas";
			this.tabOperacionesBasicas.Padding = new System.Windows.Forms.Padding(3);
			this.tabOperacionesBasicas.Size = new System.Drawing.Size(768, 400);
			this.tabOperacionesBasicas.TabIndex = 2;
			this.tabOperacionesBasicas.Text = "Operaciones Básicas";
			this.tabOperacionesBasicas.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(128, 303);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Resultado polar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(128, 264);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Resultado binomica:";
			// 
			// labelResultadoPolar
			// 
			this.labelResultadoPolar.AutoSize = true;
			this.labelResultadoPolar.Location = new System.Drawing.Point(246, 303);
			this.labelResultadoPolar.Name = "labelResultadoPolar";
			this.labelResultadoPolar.Size = new System.Drawing.Size(0, 13);
			this.labelResultadoPolar.TabIndex = 6;
			// 
			// buttonMultiplicacion
			// 
			this.buttonMultiplicacion.Location = new System.Drawing.Point(473, 183);
			this.buttonMultiplicacion.Name = "buttonMultiplicacion";
			this.buttonMultiplicacion.Size = new System.Drawing.Size(93, 23);
			this.buttonMultiplicacion.TabIndex = 5;
			this.buttonMultiplicacion.Text = "Multiplicación";
			this.buttonMultiplicacion.UseVisualStyleBackColor = true;
			this.buttonMultiplicacion.Click += new System.EventHandler(this.buttonMultiplicacion_Click);
			// 
			// buttonResta
			// 
			this.buttonResta.Location = new System.Drawing.Point(473, 154);
			this.buttonResta.Name = "buttonResta";
			this.buttonResta.Size = new System.Drawing.Size(93, 23);
			this.buttonResta.TabIndex = 4;
			this.buttonResta.Text = "Resta";
			this.buttonResta.UseVisualStyleBackColor = true;
			this.buttonResta.Click += new System.EventHandler(this.buttonResta_Click);
			// 
			// buttonCociente
			// 
			this.buttonCociente.Location = new System.Drawing.Point(473, 212);
			this.buttonCociente.Name = "buttonCociente";
			this.buttonCociente.Size = new System.Drawing.Size(93, 23);
			this.buttonCociente.TabIndex = 4;
			this.buttonCociente.Text = "Cociente";
			this.buttonCociente.UseVisualStyleBackColor = true;
			this.buttonCociente.Click += new System.EventHandler(this.buttonCociente_Click);
			// 
			// buttonSuma
			// 
			this.buttonSuma.Location = new System.Drawing.Point(473, 125);
			this.buttonSuma.Name = "buttonSuma";
			this.buttonSuma.Size = new System.Drawing.Size(93, 23);
			this.buttonSuma.TabIndex = 3;
			this.buttonSuma.Text = "Suma";
			this.buttonSuma.UseVisualStyleBackColor = true;
			this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
			// 
			// labelResultadoBinomica
			// 
			this.labelResultadoBinomica.AutoSize = true;
			this.labelResultadoBinomica.Location = new System.Drawing.Point(246, 265);
			this.labelResultadoBinomica.Name = "labelResultadoBinomica";
			this.labelResultadoBinomica.Size = new System.Drawing.Size(0, 13);
			this.labelResultadoBinomica.TabIndex = 2;
			// 
			// textBoxNum2
			// 
			this.textBoxNum2.Location = new System.Drawing.Point(128, 199);
			this.textBoxNum2.Name = "textBoxNum2";
			this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
			this.textBoxNum2.TabIndex = 1;
			// 
			// textBoxNum1
			// 
			this.textBoxNum1.Location = new System.Drawing.Point(128, 149);
			this.textBoxNum1.Name = "textBoxNum1";
			this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
			this.textBoxNum1.TabIndex = 0;
			this.textBoxNum1.TextChanged += new System.EventHandler(this.textBoxNum1_TextChanged);
			// 
			// tabOperacionesAvanzadas
			// 
			this.tabOperacionesAvanzadas.Controls.Add(this.labelResultPolar);
			this.tabOperacionesAvanzadas.Controls.Add(this.labelResultBinomial);
			this.tabOperacionesAvanzadas.Controls.Add(this.labelInfoResultPolar);
			this.tabOperacionesAvanzadas.Controls.Add(this.labelInfoResultBinomial);
			this.tabOperacionesAvanzadas.Controls.Add(this.labelFactor);
			this.tabOperacionesAvanzadas.Controls.Add(this.labelComplejo);
			this.tabOperacionesAvanzadas.Controls.Add(this.buttonRadicacion);
			this.tabOperacionesAvanzadas.Controls.Add(this.buttonPotencia);
			this.tabOperacionesAvanzadas.Controls.Add(this.textBoxFactor);
			this.tabOperacionesAvanzadas.Controls.Add(this.textBoxComplejo);
			this.tabOperacionesAvanzadas.Location = new System.Drawing.Point(4, 22);
			this.tabOperacionesAvanzadas.Name = "tabOperacionesAvanzadas";
			this.tabOperacionesAvanzadas.Padding = new System.Windows.Forms.Padding(3);
			this.tabOperacionesAvanzadas.Size = new System.Drawing.Size(768, 400);
			this.tabOperacionesAvanzadas.TabIndex = 3;
			this.tabOperacionesAvanzadas.Text = "Operaciones Avanzadas";
			this.tabOperacionesAvanzadas.UseVisualStyleBackColor = true;
			// 
			// tabSumaFasores
			// 
			this.tabSumaFasores.Location = new System.Drawing.Point(4, 22);
			this.tabSumaFasores.Name = "tabSumaFasores";
			this.tabSumaFasores.Padding = new System.Windows.Forms.Padding(3);
			this.tabSumaFasores.Size = new System.Drawing.Size(768, 400);
			this.tabSumaFasores.TabIndex = 4;
			this.tabSumaFasores.Text = "Suma Fasores";
			this.tabSumaFasores.UseVisualStyleBackColor = true;
			// 
			// textBoxComplejo
			// 
			this.textBoxComplejo.Location = new System.Drawing.Point(101, 50);
			this.textBoxComplejo.Name = "textBoxComplejo";
			this.textBoxComplejo.Size = new System.Drawing.Size(100, 20);
			this.textBoxComplejo.TabIndex = 0;
			// 
			// textBoxFactor
			// 
			this.textBoxFactor.Location = new System.Drawing.Point(101, 77);
			this.textBoxFactor.Name = "textBoxFactor";
			this.textBoxFactor.Size = new System.Drawing.Size(100, 20);
			this.textBoxFactor.TabIndex = 1;
			// 
			// buttonPotencia
			// 
			this.buttonPotencia.Location = new System.Drawing.Point(289, 50);
			this.buttonPotencia.Name = "buttonPotencia";
			this.buttonPotencia.Size = new System.Drawing.Size(103, 23);
			this.buttonPotencia.TabIndex = 2;
			this.buttonPotencia.Text = "Calcular Potencia";
			this.buttonPotencia.UseVisualStyleBackColor = true;
			this.buttonPotencia.Click += new System.EventHandler(this.ButtonPotencia_Click);
			// 
			// buttonRadicacion
			// 
			this.buttonRadicacion.Location = new System.Drawing.Point(289, 77);
			this.buttonRadicacion.Name = "buttonRadicacion";
			this.buttonRadicacion.Size = new System.Drawing.Size(103, 23);
			this.buttonRadicacion.TabIndex = 3;
			this.buttonRadicacion.Text = "Calcular Raices";
			this.buttonRadicacion.UseVisualStyleBackColor = true;
			this.buttonRadicacion.Click += new System.EventHandler(this.ButtonRadicacion_Click);
			// 
			// labelComplejo
			// 
			this.labelComplejo.AutoSize = true;
			this.labelComplejo.Location = new System.Drawing.Point(42, 53);
			this.labelComplejo.Name = "labelComplejo";
			this.labelComplejo.Size = new System.Drawing.Size(53, 13);
			this.labelComplejo.TabIndex = 4;
			this.labelComplejo.Text = "Complejo:";
			// 
			// labelFactor
			// 
			this.labelFactor.AutoSize = true;
			this.labelFactor.Location = new System.Drawing.Point(42, 80);
			this.labelFactor.Name = "labelFactor";
			this.labelFactor.Size = new System.Drawing.Size(40, 13);
			this.labelFactor.TabIndex = 5;
			this.labelFactor.Text = "Factor:";
			// 
			// labelInfoResultBinomial
			// 
			this.labelInfoResultBinomial.AutoSize = true;
			this.labelInfoResultBinomial.Location = new System.Drawing.Point(42, 127);
			this.labelInfoResultBinomial.Name = "labelInfoResultBinomial";
			this.labelInfoResultBinomial.Size = new System.Drawing.Size(115, 13);
			this.labelInfoResultBinomial.TabIndex = 6;
			this.labelInfoResultBinomial.Text = "Resultado en Binomial:";
			// 
			// labelInfoResultPolar
			// 
			this.labelInfoResultPolar.AutoSize = true;
			this.labelInfoResultPolar.Location = new System.Drawing.Point(42, 154);
			this.labelInfoResultPolar.Name = "labelInfoResultPolar";
			this.labelInfoResultPolar.Size = new System.Drawing.Size(100, 13);
			this.labelInfoResultPolar.TabIndex = 7;
			this.labelInfoResultPolar.Text = "Resultado en Polar:";
			// 
			// labelResultPolar
			// 
			this.labelResultPolar.AutoSize = true;
			this.labelResultPolar.Location = new System.Drawing.Point(175, 154);
			this.labelResultPolar.Name = "labelResultPolar";
			this.labelResultPolar.Size = new System.Drawing.Size(0, 13);
			this.labelResultPolar.TabIndex = 9;
			// 
			// labelResultBinomial
			// 
			this.labelResultBinomial.AutoSize = true;
			this.labelResultBinomial.Location = new System.Drawing.Point(175, 127);
			this.labelResultBinomial.Name = "labelResultBinomial";
			this.labelResultBinomial.Size = new System.Drawing.Size(0, 13);
			this.labelResultBinomial.TabIndex = 8;
			// 
			// Inicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Inicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NCOM";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.tabInicio.ResumeLayout(false);
			this.tabInicio.PerformLayout();
			this.tabOperacionesBasicas.ResumeLayout(false);
			this.tabOperacionesBasicas.PerformLayout();
			this.tabOperacionesAvanzadas.ResumeLayout(false);
			this.tabOperacionesAvanzadas.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabOperacionesBasicas;
        private System.Windows.Forms.TabPage tabOperacionesAvanzadas;
        private System.Windows.Forms.TabPage tabSumaFasores;
        private System.Windows.Forms.Button buttonTipo;
        private System.Windows.Forms.Label labelComplejoEnForma;
        private System.Windows.Forms.TextBox textBoxTransformacion;
        private System.Windows.Forms.Label labelTransformado;
        private System.Windows.Forms.Button buttonTransformar;
        private System.Windows.Forms.Label labelTransformar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonMultiplicacion;
        private System.Windows.Forms.Button buttonResta;
        private System.Windows.Forms.Button buttonCociente;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.Label labelResultadoBinomica;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.Label labelFormatoIncorrecto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResultadoPolar;
		private System.Windows.Forms.Label labelInfoResultPolar;
		private System.Windows.Forms.Label labelInfoResultBinomial;
		private System.Windows.Forms.Label labelFactor;
		private System.Windows.Forms.Label labelComplejo;
		private System.Windows.Forms.Button buttonRadicacion;
		private System.Windows.Forms.Button buttonPotencia;
		private System.Windows.Forms.TextBox textBoxFactor;
		private System.Windows.Forms.TextBox textBoxComplejo;
		private System.Windows.Forms.Label labelResultPolar;
		private System.Windows.Forms.Label labelResultBinomial;
	}
}

