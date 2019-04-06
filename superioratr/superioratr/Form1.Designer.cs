namespace superioratr
{
    partial class Form1
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
            this.BotonHolaMundo = new System.Windows.Forms.Button();
            this.LabelHolaMundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotonHolaMundo
            // 
            this.BotonHolaMundo.Location = new System.Drawing.Point(316, 180);
            this.BotonHolaMundo.Name = "BotonHolaMundo";
            this.BotonHolaMundo.Size = new System.Drawing.Size(75, 23);
            this.BotonHolaMundo.TabIndex = 0;
            this.BotonHolaMundo.Text = "Hola Mundo";
            this.BotonHolaMundo.UseVisualStyleBackColor = true;
            this.BotonHolaMundo.Click += new System.EventHandler(this.BotonHolaMundo_Click);
            // 
            // LabelHolaMundo
            // 
            this.LabelHolaMundo.AutoSize = true;
            this.LabelHolaMundo.Location = new System.Drawing.Point(335, 130);
            this.LabelHolaMundo.Name = "LabelHolaMundo";
            this.LabelHolaMundo.Size = new System.Drawing.Size(0, 13);
            this.LabelHolaMundo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelHolaMundo);
            this.Controls.Add(this.BotonHolaMundo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonHolaMundo;
        private System.Windows.Forms.Label LabelHolaMundo;
    }
}

