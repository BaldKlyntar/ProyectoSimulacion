
namespace SimulacionIndividual
{
    partial class EnunciadoEjercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnunciadoEjercicio));
            this.rtxtEnunciado = new System.Windows.Forms.RichTextBox();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtEnunciado
            // 
            this.rtxtEnunciado.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtEnunciado.Location = new System.Drawing.Point(91, 72);
            this.rtxtEnunciado.Name = "rtxtEnunciado";
            this.rtxtEnunciado.ReadOnly = true;
            this.rtxtEnunciado.Size = new System.Drawing.Size(615, 297);
            this.rtxtEnunciado.TabIndex = 0;
            this.rtxtEnunciado.Text = resources.GetString("rtxtEnunciado.Text");
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEjercicio.Location = new System.Drawing.Point(332, 37);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(109, 32);
            this.lblEjercicio.TabIndex = 1;
            this.lblEjercicio.Text = "Ejercicio";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegresar.Location = new System.Drawing.Point(356, 375);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(94, 29);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // EnunciadoEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.rtxtEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnunciadoEjercicio";
            this.Text = "Enunciado de Ejercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtEnunciado;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.Button btnRegresar;
    }
}