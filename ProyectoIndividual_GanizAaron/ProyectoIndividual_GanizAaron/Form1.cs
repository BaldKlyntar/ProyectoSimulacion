using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIndividual_GanizAaron
{
    public partial class Form1 : Form
    {
        public int n;
        public double[] NP;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bntGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                int X0, A, C, M, r;
                double Aux, most, XR, XN;
                Aux = 0;
                

                X0 = int.Parse(txtValorX0.Text);
                A = int.Parse(txtValorA.Text);
                C = int.Parse(txtValorC.Text);
                M = int.Parse(txtValorM.Text);
                n = int.Parse(txtCantidadn.Text);
                NP = new double[n];

                double[] arr = new double[n];
                bntGenerar.Enabled = false;

                for (int i = 0; i<n; i++)
                {
                    
                    XN = (((A * X0) + C) % M);
                    XR = (XN / M);
                    XR = Math.Round(XR, 5);
                    double d = XR;
                    X0 = Convert.ToInt32(XR * M);
                    NP[i] = XR;
                    Aux = Aux + XR;
                    txtRi.Text = txtRi.Text + NP[i] + "\r\n";
                    txti.Text = txti.Text + i + "\r\n";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inserte los valores para el generador", "Advertencia",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnLimpiarPseudo_Click(object sender, EventArgs e)
        {
            try
            {


                txtCantidadn.Clear();
                txtValorA.Clear();
                txtValorC.Clear();
                txtValorM.Clear();
                txtValorX0.Clear();
                txtRi.Clear();
                txti.Clear();
                bntGenerar.Enabled = true;
                Array.Clear(NP, 0, NP.Length);
            }
            catch(Exception)
            {
                MessageBox.Show("No hay valores que se necesiten limpiar");
            }
            
            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPoker_Click(object sender, EventArgs e)
        {
            if (NP != null)
            {


                bool todosTienenAlMenosCincoDecimales = VerificarDecimalesEnArreglo(NP);

                if (todosTienenAlMenosCincoDecimales)
                {


                    Prueba_Poker prueba_Poker = new Prueba_Poker(NP, n);
                    prueba_Poker.Show();
                }
                else
                {
                    MessageBox.Show("Se requiere que cada numero contenga por lo menos 5 caracteres");
                }
            }
            else
            {
                MessageBox.Show("Numeros pseudoaleatorios no generados");
            }
        }

        private void btnPromedios_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFrecuencia_Click(object sender, EventArgs e)
        {
            if (NP != null)
            {


                Prueba_Frecuencia prueba_Frecuencia = new Prueba_Frecuencia(NP);
                prueba_Frecuencia.Show();
            }
            else
            {
                MessageBox.Show("Numeros pseudoaleatorios no generados");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private bool VerificarDecimalesEnArreglo(double[] NP)
        {
            foreach (double numero in NP)
            {
                string numeroComoCadena = numero.ToString("0.#####");

                int indicePuntoDecimal = numeroComoCadena.IndexOf('.');
                int longitudParteDecimal = numeroComoCadena.Length - indicePuntoDecimal - 1;

                if (longitudParteDecimal < 5)
                {
                    return false; 
                }
            }

            return true;
        }

        private void btnSImulacion_Click(object sender, EventArgs e)
        {
            if (NP != null)
            {


                Simulacion menu = new Simulacion(NP, n);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Numeros pseudoaleatorios no generados");
            }
            

        }
    }
}
