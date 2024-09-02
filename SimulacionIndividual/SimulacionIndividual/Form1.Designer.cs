
namespace SimulacionIndividual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnGenerar = new System.Windows.Forms.Button();
            dgvPseudoaleatorio = new System.Windows.Forms.DataGridView();
            Corrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ValorRN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtCantidad = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtValorXo = new System.Windows.Forms.TextBox();
            lblValorXo = new System.Windows.Forms.Label();
            txtValorM = new System.Windows.Forms.TextBox();
            lblValorM = new System.Windows.Forms.Label();
            txtValorC = new System.Windows.Forms.TextBox();
            lblValorC = new System.Windows.Forms.Label();
            txtValorA = new System.Windows.Forms.TextBox();
            lblValorA = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dgvDistribucionTriangular = new System.Windows.Forms.DataGridView();
            ValorRn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MinutosTrabajados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FinTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MinutosMuertosDuranteTrab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgvUniforme = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MinutosLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            InicioVuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EsperaFila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblResultado = new System.Windows.Forms.Label();
            btnDistribucionTriangular = new System.Windows.Forms.Button();
            btnCalcularUniformemente = new System.Windows.Forms.Button();
            txtRelacion = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtValorMaximo = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtValorPromedio = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtValorMinimo = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtInicioJornada = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtCantidadFinal = new System.Windows.Forms.TextBox();
            lblNumeroCantidad = new System.Windows.Forms.Label();
            txtValorInicial = new System.Windows.Forms.TextBox();
            lblNumeroInicial = new System.Windows.Forms.Label();
            txtValorUniforme2 = new System.Windows.Forms.TextBox();
            lblValor2 = new System.Windows.Forms.Label();
            txtValorUniforme1 = new System.Windows.Forms.TextBox();
            lblValor1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            repetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            limpiarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ejercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            enunciadoDeEjercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            elaboradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPseudoaleatorio).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucionTriangular).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUniforme).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGenerar);
            groupBox1.Controls.Add(dgvPseudoaleatorio);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtValorXo);
            groupBox1.Controls.Add(lblValorXo);
            groupBox1.Controls.Add(txtValorM);
            groupBox1.Controls.Add(lblValorM);
            groupBox1.Controls.Add(txtValorC);
            groupBox1.Controls.Add(lblValorC);
            groupBox1.Controls.Add(txtValorA);
            groupBox1.Controls.Add(lblValorA);
            groupBox1.Location = new System.Drawing.Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(324, 759);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generador de numeros pseudoaleatorios";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new System.Drawing.Point(100, 197);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new System.Drawing.Size(94, 29);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // dgvPseudoaleatorio
            // 
            dgvPseudoaleatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPseudoaleatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Corrida, ValorRN });
            dgvPseudoaleatorio.Location = new System.Drawing.Point(6, 246);
            dgvPseudoaleatorio.Name = "dgvPseudoaleatorio";
            dgvPseudoaleatorio.ReadOnly = true;
            dgvPseudoaleatorio.RowHeadersWidth = 51;
            dgvPseudoaleatorio.RowTemplate.Height = 29;
            dgvPseudoaleatorio.Size = new System.Drawing.Size(304, 507);
            dgvPseudoaleatorio.TabIndex = 11;
            // 
            // Corrida
            // 
            Corrida.HeaderText = "No.Corrida";
            Corrida.MinimumWidth = 6;
            Corrida.Name = "Corrida";
            Corrida.ReadOnly = true;
            Corrida.Width = 125;
            // 
            // ValorRN
            // 
            ValorRN.HeaderText = "Valor Rn";
            ValorRN.MinimumWidth = 6;
            ValorRN.Name = "ValorRN";
            ValorRN.ReadOnly = true;
            ValorRN.Width = 125;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(212, 158);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(98, 27);
            txtCantidad.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(6, 161);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(206, 20);
            label5.TabIndex = 8;
            label5.Text = "Cantidad numeros a generar:";
            // 
            // txtValorXo
            // 
            txtValorXo.Location = new System.Drawing.Point(147, 125);
            txtValorXo.Name = "txtValorXo";
            txtValorXo.Size = new System.Drawing.Size(163, 27);
            txtValorXo.TabIndex = 7;
            txtValorXo.TextChanged += txtValorXo_TextChanged;
            // 
            // lblValorXo
            // 
            lblValorXo.AutoSize = true;
            lblValorXo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblValorXo.Location = new System.Drawing.Point(6, 128);
            lblValorXo.Name = "lblValorXo";
            lblValorXo.Size = new System.Drawing.Size(128, 20);
            lblValorXo.TabIndex = 6;
            lblValorXo.Text = "Ingrese valor Xo:";
            // 
            // txtValorM
            // 
            txtValorM.Location = new System.Drawing.Point(147, 92);
            txtValorM.Name = "txtValorM";
            txtValorM.Size = new System.Drawing.Size(163, 27);
            txtValorM.TabIndex = 5;
            txtValorM.Text = "17001";
            // 
            // lblValorM
            // 
            lblValorM.AutoSize = true;
            lblValorM.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblValorM.Location = new System.Drawing.Point(6, 95);
            lblValorM.Name = "lblValorM";
            lblValorM.Size = new System.Drawing.Size(143, 20);
            lblValorM.TabIndex = 4;
            lblValorM.Text = "Ingrese valor de M:";
            // 
            // txtValorC
            // 
            txtValorC.Location = new System.Drawing.Point(147, 59);
            txtValorC.Name = "txtValorC";
            txtValorC.Size = new System.Drawing.Size(163, 27);
            txtValorC.TabIndex = 3;
            txtValorC.Text = "221";
            // 
            // lblValorC
            // 
            lblValorC.AutoSize = true;
            lblValorC.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblValorC.Location = new System.Drawing.Point(6, 62);
            lblValorC.Name = "lblValorC";
            lblValorC.Size = new System.Drawing.Size(139, 20);
            lblValorC.TabIndex = 2;
            lblValorC.Text = "Ingrese valor de C:";
            // 
            // txtValorA
            // 
            txtValorA.Location = new System.Drawing.Point(147, 26);
            txtValorA.Name = "txtValorA";
            txtValorA.Size = new System.Drawing.Size(163, 27);
            txtValorA.TabIndex = 1;
            txtValorA.Text = "101";
            // 
            // lblValorA
            // 
            lblValorA.AutoSize = true;
            lblValorA.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblValorA.Location = new System.Drawing.Point(6, 29);
            lblValorA.Name = "lblValorA";
            lblValorA.Size = new System.Drawing.Size(141, 20);
            lblValorA.TabIndex = 0;
            lblValorA.Text = "Ingrese valor de A:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDistribucionTriangular);
            groupBox2.Controls.Add(dgvUniforme);
            groupBox2.Controls.Add(lblResultado);
            groupBox2.Controls.Add(btnDistribucionTriangular);
            groupBox2.Controls.Add(btnCalcularUniformemente);
            groupBox2.Controls.Add(txtRelacion);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtValorMaximo);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtValorPromedio);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtValorMinimo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtInicioJornada);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtCantidadFinal);
            groupBox2.Controls.Add(lblNumeroCantidad);
            groupBox2.Controls.Add(txtValorInicial);
            groupBox2.Controls.Add(lblNumeroInicial);
            groupBox2.Controls.Add(txtValorUniforme2);
            groupBox2.Controls.Add(lblValor2);
            groupBox2.Controls.Add(txtValorUniforme1);
            groupBox2.Controls.Add(lblValor1);
            groupBox2.Location = new System.Drawing.Point(345, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1176, 775);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Simulación";
            // 
            // dgvDistribucionTriangular
            // 
            dgvDistribucionTriangular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribucionTriangular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ValorRn2, MinutosTrabajados, FinTrabajo, MinutosMuertosDuranteTrab });
            dgvDistribucionTriangular.Location = new System.Drawing.Point(304, 401);
            dgvDistribucionTriangular.Name = "dgvDistribucionTriangular";
            dgvDistribucionTriangular.RowHeadersWidth = 51;
            dgvDistribucionTriangular.RowTemplate.Height = 29;
            dgvDistribucionTriangular.Size = new System.Drawing.Size(678, 352);
            dgvDistribucionTriangular.TabIndex = 22;
            // 
            // ValorRn2
            // 
            ValorRn2.HeaderText = "ValorRn2";
            ValorRn2.MinimumWidth = 6;
            ValorRn2.Name = "ValorRn2";
            ValorRn2.Width = 125;
            // 
            // MinutosTrabajados
            // 
            MinutosTrabajados.HeaderText = "MinutosVuelta";
            MinutosTrabajados.MinimumWidth = 6;
            MinutosTrabajados.Name = "MinutosTrabajados";
            MinutosTrabajados.Width = 125;
            // 
            // FinTrabajo
            // 
            FinTrabajo.HeaderText = "FinVuelta";
            FinTrabajo.MinimumWidth = 6;
            FinTrabajo.Name = "FinTrabajo";
            FinTrabajo.Width = 125;
            // 
            // MinutosMuertosDuranteTrab
            // 
            MinutosMuertosDuranteTrab.HeaderText = "MinutosMuertosDuranteVuelta";
            MinutosMuertosDuranteTrab.MinimumWidth = 6;
            MinutosMuertosDuranteTrab.Name = "MinutosMuertosDuranteTrab";
            MinutosMuertosDuranteTrab.Width = 250;
            // 
            // dgvUniforme
            // 
            dgvUniforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUniforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, MinutosLlegada, dataGridViewTextBoxColumn3, InicioVuelta, EsperaFila });
            dgvUniforme.Location = new System.Drawing.Point(304, 26);
            dgvUniforme.Name = "dgvUniforme";
            dgvUniforme.RowHeadersWidth = 51;
            dgvUniforme.RowTemplate.Height = 29;
            dgvUniforme.Size = new System.Drawing.Size(805, 349);
            dgvUniforme.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "No.Corridas";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "ValorRn";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // MinutosLlegada
            // 
            MinutosLlegada.HeaderText = "Minutos/Llegada";
            MinutosLlegada.MinimumWidth = 6;
            MinutosLlegada.Name = "MinutosLlegada";
            MinutosLlegada.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "MinutosLlegada";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // InicioVuelta
            // 
            InicioVuelta.HeaderText = "InicioVuelta";
            InicioVuelta.MinimumWidth = 6;
            InicioVuelta.Name = "InicioVuelta";
            InicioVuelta.Width = 125;
            // 
            // EsperaFila
            // 
            EsperaFila.HeaderText = "Minutos perdidos";
            EsperaFila.MinimumWidth = 6;
            EsperaFila.Name = "EsperaFila";
            EsperaFila.Width = 125;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblResultado.Location = new System.Drawing.Point(15, 457);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new System.Drawing.Size(111, 28);
            lblResultado.TabIndex = 20;
            lblResultado.Text = "Resultado:";
            // 
            // btnDistribucionTriangular
            // 
            btnDistribucionTriangular.Location = new System.Drawing.Point(70, 381);
            btnDistribucionTriangular.Name = "btnDistribucionTriangular";
            btnDistribucionTriangular.Size = new System.Drawing.Size(151, 52);
            btnDistribucionTriangular.TabIndex = 19;
            btnDistribucionTriangular.Text = "Distribución triangular";
            btnDistribucionTriangular.UseVisualStyleBackColor = true;
            btnDistribucionTriangular.Click += btnDistribucionTriangular_Click;
            // 
            // btnCalcularUniformemente
            // 
            btnCalcularUniformemente.Location = new System.Drawing.Point(70, 323);
            btnCalcularUniformemente.Name = "btnCalcularUniformemente";
            btnCalcularUniformemente.Size = new System.Drawing.Size(151, 52);
            btnCalcularUniformemente.TabIndex = 18;
            btnCalcularUniformemente.Text = "Calcular forma uniforme";
            btnCalcularUniformemente.UseVisualStyleBackColor = true;
            btnCalcularUniformemente.Click += btnCalcularUniformemente_Click;
            // 
            // txtRelacion
            // 
            txtRelacion.Location = new System.Drawing.Point(155, 290);
            txtRelacion.Name = "txtRelacion";
            txtRelacion.ReadOnly = true;
            txtRelacion.Size = new System.Drawing.Size(125, 27);
            txtRelacion.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 293);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 20);
            label2.TabIndex = 16;
            label2.Text = "Relación:";
            // 
            // txtValorMaximo
            // 
            txtValorMaximo.Location = new System.Drawing.Point(155, 257);
            txtValorMaximo.Name = "txtValorMaximo";
            txtValorMaximo.Size = new System.Drawing.Size(125, 27);
            txtValorMaximo.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 260);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 20);
            label1.TabIndex = 14;
            label1.Text = "Tiempo maximo:";
            // 
            // txtValorPromedio
            // 
            txtValorPromedio.Location = new System.Drawing.Point(155, 224);
            txtValorPromedio.Name = "txtValorPromedio";
            txtValorPromedio.Size = new System.Drawing.Size(125, 27);
            txtValorPromedio.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(15, 227);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(129, 20);
            label8.TabIndex = 12;
            label8.Text = "Tiempo promedio:";
            // 
            // txtValorMinimo
            // 
            txtValorMinimo.Location = new System.Drawing.Point(155, 191);
            txtValorMinimo.Name = "txtValorMinimo";
            txtValorMinimo.Size = new System.Drawing.Size(125, 27);
            txtValorMinimo.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(15, 194);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(112, 20);
            label7.TabIndex = 10;
            label7.Text = "Tiempo minimo:";
            // 
            // txtInicioJornada
            // 
            txtInicioJornada.Location = new System.Drawing.Point(163, 158);
            txtInicioJornada.Name = "txtInicioJornada";
            txtInicioJornada.Size = new System.Drawing.Size(117, 27);
            txtInicioJornada.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(15, 161);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(140, 20);
            label6.TabIndex = 8;
            label6.Text = "Inicio vuelta (Min):";
            // 
            // txtCantidadFinal
            // 
            txtCantidadFinal.Location = new System.Drawing.Point(155, 125);
            txtCantidadFinal.Name = "txtCantidadFinal";
            txtCantidadFinal.Size = new System.Drawing.Size(125, 27);
            txtCantidadFinal.TabIndex = 7;
            // 
            // lblNumeroCantidad
            // 
            lblNumeroCantidad.AutoSize = true;
            lblNumeroCantidad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumeroCantidad.Location = new System.Drawing.Point(15, 128);
            lblNumeroCantidad.Name = "lblNumeroCantidad";
            lblNumeroCantidad.Size = new System.Drawing.Size(75, 20);
            lblNumeroCantidad.TabIndex = 6;
            lblNumeroCantidad.Text = "Cantidad:";
            // 
            // txtValorInicial
            // 
            txtValorInicial.Location = new System.Drawing.Point(155, 92);
            txtValorInicial.Name = "txtValorInicial";
            txtValorInicial.Size = new System.Drawing.Size(125, 27);
            txtValorInicial.TabIndex = 5;
            // 
            // lblNumeroInicial
            // 
            lblNumeroInicial.AutoSize = true;
            lblNumeroInicial.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNumeroInicial.Location = new System.Drawing.Point(15, 95);
            lblNumeroInicial.Name = "lblNumeroInicial";
            lblNumeroInicial.Size = new System.Drawing.Size(111, 20);
            lblNumeroInicial.TabIndex = 4;
            lblNumeroInicial.Text = "Numero inicial:";
            // 
            // txtValorUniforme2
            // 
            txtValorUniforme2.Location = new System.Drawing.Point(155, 59);
            txtValorUniforme2.Name = "txtValorUniforme2";
            txtValorUniforme2.Size = new System.Drawing.Size(125, 27);
            txtValorUniforme2.TabIndex = 3;
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblValor2.Location = new System.Drawing.Point(15, 62);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new System.Drawing.Size(143, 20);
            lblValor2.TabIndex = 2;
            lblValor2.Text = "2do valor uniforme:";
            // 
            // txtValorUniforme1
            // 
            txtValorUniforme1.Location = new System.Drawing.Point(155, 26);
            txtValorUniforme1.Name = "txtValorUniforme1";
            txtValorUniforme1.Size = new System.Drawing.Size(125, 27);
            txtValorUniforme1.TabIndex = 1;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblValor1.Location = new System.Drawing.Point(15, 29);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new System.Drawing.Size(139, 20);
            lblValor1.TabIndex = 0;
            lblValor1.Text = "1er valor uniforme:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { inicioToolStripMenuItem, repetirToolStripMenuItem, ejercicioToolStripMenuItem, elaboradoToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1535, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { salirToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // repetirToolStripMenuItem
            // 
            repetirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { limpiarValoresToolStripMenuItem });
            repetirToolStripMenuItem.Name = "repetirToolStripMenuItem";
            repetirToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            repetirToolStripMenuItem.Text = "Limpiar";
            // 
            // limpiarValoresToolStripMenuItem
            // 
            limpiarValoresToolStripMenuItem.Name = "limpiarValoresToolStripMenuItem";
            limpiarValoresToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            limpiarValoresToolStripMenuItem.Text = "Limpiar valores";
            limpiarValoresToolStripMenuItem.Click += limpiarValoresToolStripMenuItem_Click;
            // 
            // ejercicioToolStripMenuItem
            // 
            ejercicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { enunciadoDeEjercicioToolStripMenuItem });
            ejercicioToolStripMenuItem.Name = "ejercicioToolStripMenuItem";
            ejercicioToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            ejercicioToolStripMenuItem.Text = "Ejercicio";
            // 
            // enunciadoDeEjercicioToolStripMenuItem
            // 
            enunciadoDeEjercicioToolStripMenuItem.Name = "enunciadoDeEjercicioToolStripMenuItem";
            enunciadoDeEjercicioToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            enunciadoDeEjercicioToolStripMenuItem.Text = "Enunciado de ejercicio";
            enunciadoDeEjercicioToolStripMenuItem.Click += enunciadoDeEjercicioToolStripMenuItem_Click;
            // 
            // elaboradoToolStripMenuItem
            // 
            elaboradoToolStripMenuItem.Name = "elaboradoToolStripMenuItem";
            elaboradoToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            elaboradoToolStripMenuItem.Text = "Elaborado";
            elaboradoToolStripMenuItem.Click += elaboradoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Salmon;
            ClientSize = new System.Drawing.Size(1535, 827);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Proyecto Individual Simulación 2021";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPseudoaleatorio).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucionTriangular).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUniforme).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorXo;
        private System.Windows.Forms.Label lblValorXo;
        private System.Windows.Forms.TextBox txtValorM;
        private System.Windows.Forms.Label lblValorM;
        private System.Windows.Forms.TextBox txtValorC;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.DataGridView dgvPseudoaleatorio;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnDistribucionTriangular;
        private System.Windows.Forms.Button btnCalcularUniformemente;
        private System.Windows.Forms.TextBox txtRelacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorMaximo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorPromedio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorMinimo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInicioJornada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadFinal;
        private System.Windows.Forms.Label lblNumeroCantidad;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.Label lblNumeroInicial;
        private System.Windows.Forms.TextBox txtValorUniforme2;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.TextBox txtValorUniforme1;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.DataGridView dgvDistribucionTriangular;
        private System.Windows.Forms.DataGridView dgvUniforme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repetirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enunciadoDeEjercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elaboradoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinutosTrabajados;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinutosMuertosDuranteTrab;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinutosLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn InicioVuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsperaFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Corrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorRN;
    }
}

