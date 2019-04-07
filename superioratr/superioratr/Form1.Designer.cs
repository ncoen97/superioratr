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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabOperacionesBasicas = new System.Windows.Forms.TabPage();
            this.tabOperacionesAvanzadas = new System.Windows.Forms.TabPage();
            this.tabSumaFasores = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInicio);
            this.tabControl.Controls.Add(this.tabOperacionesBasicas);
            this.tabControl.Controls.Add(this.tabOperacionesAvanzadas);
            this.tabControl.Controls.Add(this.tabSumaFasores);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1035, 524);
            this.tabControl.TabIndex = 1;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.label3);
            this.tabInicio.Controls.Add(this.button2);
            this.tabInicio.Controls.Add(this.label2);
            this.tabInicio.Controls.Add(this.button1);
            this.tabInicio.Controls.Add(this.label1);
            this.tabInicio.Controls.Add(this.textBox1);
            this.tabInicio.Location = new System.Drawing.Point(4, 25);
            this.tabInicio.Margin = new System.Windows.Forms.Padding(4);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(4);
            this.tabInicio.Size = new System.Drawing.Size(1027, 495);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "rta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(140, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tipo de dato ingresado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "rta";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 27);
            this.textBox1.TabIndex = 0;
            // 
            // tabOperacionesBasicas
            // 
            this.tabOperacionesBasicas.Location = new System.Drawing.Point(4, 25);
            this.tabOperacionesBasicas.Margin = new System.Windows.Forms.Padding(4);
            this.tabOperacionesBasicas.Name = "tabOperacionesBasicas";
            this.tabOperacionesBasicas.Padding = new System.Windows.Forms.Padding(4);
            this.tabOperacionesBasicas.Size = new System.Drawing.Size(1027, 495);
            this.tabOperacionesBasicas.TabIndex = 2;
            this.tabOperacionesBasicas.Text = "Operaciones Básicas";
            this.tabOperacionesBasicas.UseVisualStyleBackColor = true;
            // 
            // tabOperacionesAvanzadas
            // 
            this.tabOperacionesAvanzadas.Location = new System.Drawing.Point(4, 25);
            this.tabOperacionesAvanzadas.Margin = new System.Windows.Forms.Padding(4);
            this.tabOperacionesAvanzadas.Name = "tabOperacionesAvanzadas";
            this.tabOperacionesAvanzadas.Padding = new System.Windows.Forms.Padding(4);
            this.tabOperacionesAvanzadas.Size = new System.Drawing.Size(1027, 495);
            this.tabOperacionesAvanzadas.TabIndex = 3;
            this.tabOperacionesAvanzadas.Text = "Operaciones Avanzadas";
            this.tabOperacionesAvanzadas.UseVisualStyleBackColor = true;
            // 
            // tabSumaFasores
            // 
            this.tabSumaFasores.Location = new System.Drawing.Point(4, 25);
            this.tabSumaFasores.Margin = new System.Windows.Forms.Padding(4);
            this.tabSumaFasores.Name = "tabSumaFasores";
            this.tabSumaFasores.Padding = new System.Windows.Forms.Padding(4);
            this.tabSumaFasores.Size = new System.Drawing.Size(1027, 495);
            this.tabSumaFasores.TabIndex = 4;
            this.tabSumaFasores.Text = "Suma Fasores";
            this.tabSumaFasores.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(459, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 61);
            this.button2.TabIndex = 4;
            this.button2.Text = "Transformar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "rta";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.Text = "NCOM";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabOperacionesBasicas;
        private System.Windows.Forms.TabPage tabOperacionesAvanzadas;
        private System.Windows.Forms.TabPage tabSumaFasores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

