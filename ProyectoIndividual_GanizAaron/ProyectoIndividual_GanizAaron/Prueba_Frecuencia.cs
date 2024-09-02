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
    public partial class Prueba_Frecuencia : Form
    {

      
        public double[] NP;


        public Prueba_Frecuencia(double[] np)
        {
            InitializeComponent();

            
            NP = np;
        }

        private void btnRegresarFrec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarFrecuencia_Click(object sender, EventArgs e)
        {   
            btnIniciarFrecuencia.Enabled = false;
            if (NP != null)
            {
                if(txtAlfa.Text == "")
                {
                    MessageBox.Show("Selecciona un valor Alfa");
                }
                else
                {
                    try
                    {
                        int i = 0;
                        double Fe = NP.Length / 5;
                        int c1, c2, c3, c4, c5;
                        double chi1, chi2, chi3, chi4, chi5, ChiCuadrada, ChiTablas;

                        c1 = 0;
                        c2 = 0;
                        c3 = 0;
                        c4 = 0;
                        c5 = 0;

                        chi1 = 0;
                        chi2 = 0;
                        chi3 = 0;
                        chi4 = 0;
                        chi5 = 0;

                        ChiCuadrada = 0;
                        ChiTablas = 0;

                        txtFE1.Text = Fe.ToString();
                        txtFE2.Text = Fe.ToString();
                        txtFE3.Text = Fe.ToString();
                        txtFE4.Text = Fe.ToString();
                        txtFE5.Text = Fe.ToString();

                        while (i < NP.Length)
                        {
                            if(NP[i] >= 0 && NP[i] < 0.2)
                                c1++;
                            else if (NP[i] >= 0.2 && NP[i] < 0.4)
                                c2++;
                            else if (NP[i] >= 0.4 && NP[i] < 0.6)
                                c3++;
                            else if (NP[i] >= 0.6 && NP[i] < 0.8)
                                c4++;
                            else if (NP[i] >= 0.8 && NP[i] < 1)
                                c5++;

                            i++;
                        }

                        txtFO1.Text = c1.ToString();
                        txtFO2.Text = c2.ToString();
                        txtFO3.Text = c3.ToString();
                        txtFO4.Text = c4.ToString();
                        txtFO5.Text = c5.ToString();

                        chi1 = Math.Pow((c1 - Fe), 2) / Fe;
                        chi2 = Math.Pow((c2 - Fe), 2) / Fe;
                        chi3 = Math.Pow((c3 - Fe), 2) / Fe;
                        chi4 = Math.Pow((c4 - Fe), 2) / Fe;
                        chi5 = Math.Pow((c5 - Fe), 2) / Fe;

                        txtC1.Text = chi1.ToString();
                        txtC2.Text = chi2.ToString();
                        txtC3.Text = chi3.ToString();
                        txtC4.Text = chi4.ToString();
                        txtC5.Text = chi5.ToString();

                        ChiCuadrada = chi1 + chi2 + chi3 + chi4 + chi5;
                        txtCuadrada.Text = ChiCuadrada.ToString();

                        if (double.Parse(txtAlfa.Text) == 0.995)
                        {
                            ChiTablas = 0.21;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.990)
                        {
                            ChiTablas = 0.30;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.975)
                        {
                            ChiTablas = 0.48;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.950)
                        {
                            ChiTablas = 0.71;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.500)
                        {
                            ChiTablas = 3.36;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.050)
                        {
                            ChiTablas = 9.49;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.250)
                        {
                            ChiTablas = 11.14;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.010)
                        {
                            ChiTablas = 13.28;
                        }
                        else if (double.Parse(txtAlfa.Text) == 0.005)
                        {
                            ChiTablas = 14.86;
                        }

                        txtTablas.Text = ChiTablas.ToString();

                        if(double.Parse(txtCuadrada.Text) <= ChiTablas)
                        {
                            txtResultado.Text = txtResultado.Text + "Distribuidos Uniformemente";
                        }
                        else
                        {
                            txtResultado.Text = txtResultado.Text + "No Distribuidos Uniformemente";
                        }

                    }
                    catch(Exception)
                    {
                        MessageBox.Show("No se ha ingresado un valor numerico");
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Numeros pseudoaleatorios no generados");
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtCuadrada.Clear();
            txtTablas.Clear();
            txtFE5.Clear();
            txtFE2.Clear();
            txtFE3.Clear();
            txtFE4.Clear();
            txtFE1.Clear();
            txtFO1.Clear();
            txtFO2.Clear();
            txtFO3.Clear();
            txtFO4.Clear();
            txtFO5.Clear();
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear();
            txtC4.Clear();
            txtC5.Clear();

            btnIniciarFrecuencia.Enabled = true;

        }
    }
}
