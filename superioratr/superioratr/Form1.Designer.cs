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
            this.tabTransformaciones = new System.Windows.Forms.TabPage();
            this.tabOperacionesBasicas = new System.Windows.Forms.TabPage();
            this.tabOperacionesAvanzadas = new System.Windows.Forms.TabPage();
            this.tabSumaFasores = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInicio);
            this.tabControl.Controls.Add(this.tabTransformaciones);
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
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(768, 400);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabTransformaciones
            // 
            this.tabTransformaciones.Location = new System.Drawing.Point(4, 22);
            this.tabTransformaciones.Name = "tabTransformaciones";
            this.tabTransformaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransformaciones.Size = new System.Drawing.Size(768, 400);
            this.tabTransformaciones.TabIndex = 1;
            this.tabTransformaciones.Text = "Transformaciones";
            this.tabTransformaciones.UseVisualStyleBackColor = true;
            // 
            // tabOperacionesBasicas
            // 
            this.tabOperacionesBasicas.Location = new System.Drawing.Point(4, 22);
            this.tabOperacionesBasicas.Name = "tabOperacionesBasicas";
            this.tabOperacionesBasicas.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperacionesBasicas.Size = new System.Drawing.Size(768, 400);
            this.tabOperacionesBasicas.TabIndex = 2;
            this.tabOperacionesBasicas.Text = "Operaciones Básicas";
            this.tabOperacionesBasicas.UseVisualStyleBackColor = true;
            // 
            // tabOperacionesAvanzadas
            // 
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
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Inicio";
            this.Text = "NCOM";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabTransformaciones;
        private System.Windows.Forms.TabPage tabOperacionesBasicas;
        private System.Windows.Forms.TabPage tabOperacionesAvanzadas;
        private System.Windows.Forms.TabPage tabSumaFasores;
    }
}

