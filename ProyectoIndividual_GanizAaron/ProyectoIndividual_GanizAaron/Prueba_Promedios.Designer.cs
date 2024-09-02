namespace ProyectoIndividual_GanizAaron
{
    partial class Prueba_Promedios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarFrecuencia = new System.Windows.Forms.Button();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresarFrec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prueba de la Frecuencia";
            // 
            // btnIniciarFrecuencia
            // 
            this.btnIniciarFrecuencia.Font = new System.Drawing.Font("Digital Dare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarFrecuencia.Location = new System.Drawing.Point(32, 244);
            this.btnIniciarFrecuencia.Name = "btnIniciarFrecuencia";
            this.btnIniciarFrecuencia.Size = new System.Drawing.Size(217, 69);
            this.btnIniciarFrecuencia.TabIndex = 16;
            this.btnIniciarFrecuencia.Text = "Iniciar";
            this.btnIniciarFrecuencia.UseVisualStyleBackColor = true;
            // 
            // txtAlfa
            // 
            this.txtAlfa.Location = new System.Drawing.Point(32, 153);
            this.txtAlfa.Multiline = true;
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(217, 36);
            this.txtAlfa.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alfa";
            // 
            // btnRegresarFrec
            // 
            this.btnRegresarFrec.Font = new System.Drawing.Font("Digital Dare", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarFrec.Location = new System.Drawing.Point(32, 353);
            this.btnRegresarFrec.Name = "btnRegresarFrec";
            this.btnRegresarFrec.Size = new System.Drawing.Size(217, 69);
            this.btnRegresarFrec.TabIndex = 19;
            this.btnRegresarFrec.Text = "Regresar";
            this.btnRegresarFrec.UseVisualStyleBackColor = true;
            this.btnRegresarFrec.Click += new System.EventHandler(this.btnRegresarFrec_Click);
            // 
            // Prueba_Promedios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 505);
            this.Controls.Add(this.btnRegresarFrec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlfa);
            this.Controls.Add(this.btnIniciarFrecuencia);
            this.Controls.Add(this.label1);
            this.Name = "Prueba_Promedios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba_Promedios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnIniciarFrecuencia;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnRegresarFrec;
    }
}