using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoIndividual_GanizAaron
{
    public partial class SimulacionEquipo : Form
    {
        public int n;
        public double[] NP;

        List<string> Eventos = new List<string>();
        List<string> Resultado = new List<string>();

        public SimulacionEquipo(double[] nP, int N)
        {
            InitializeComponent();

            NP = nP;
            n = N;
        }

        private void SimulacionEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                btnIniciar.Enabled = false;
                int montoInicial = Convert.ToInt32(txtMontoInicial.Text);
                int apuesta = Convert.ToInt32(txtApuesta.Text);
                int meta = Convert.ToInt32(txtMeta.Text);
                int cantidadCruz = 0;
                int cantidadCara = 0;


           


                if (txtSeleccion.Text == "Cruz")
                {


                    for (int i = 0; i < n; i++)
                    {
                        txtApuestai.Text = txtApuestai.Text + apuesta + "\r\n";
                        txtMonto.Text = txtMonto.Text + montoInicial + "\r\n";
                        montoInicial -= apuesta;

                        if (NP[i] >= 0.5)
                        {
                            Eventos.Add("Cruz");


                            montoInicial += apuesta * 8;




                        }
                        else
                        {
                            Eventos.Add("Cara");




                            apuesta *= 2;

                            if (montoInicial < 0)
                            {
                                montoInicial = 0;
                            }

                        }



                        if (montoInicial >= meta)
                        {
                            Resultado.Add("Exito");
                        }
                        else if (montoInicial <= 0)
                        {
                            Resultado.Add("Quiebra");
                            MessageBox.Show(" Sin fondos suficientes para continuar");

                        }
                        else
                        {
                            Resultado.Add(" ");
                        }

                        txtResultado.Text = txtResultado.Text + Resultado[i] + "\r\n";
                        txtIteracion.Text = txtIteracion.Text + i + "\r\n";
                        txtEvento.Text = txtEvento.Text + Eventos[i] + "\r\n";

                        txtRi.Text = txtRi.Text + NP[i] + "\r\n";
                        txtMontoPosterior.Text = txtMontoPosterior.Text + montoInicial.ToString() + "\r\n";


                        if (montoInicial <= 0)
                        {
                            break;
                        }
                    }

                    foreach (string elemento in Eventos)
                    {
                        if (elemento == "Cruz")
                        {
                            cantidadCruz++;
                        }
                        else if (elemento == "Cara")
                        {
                            cantidadCara++;
                        }
                    }


                    txtJuegosGanados.Text = txtJuegosGanados.Text + cantidadCruz + "\r\n";
                    txtMontoFinal.Text = txtMontoFinal.Text + montoInicial + "\r\n";
                    txtJuegosPerdidos.Text = txtJuegosPerdidos.Text + cantidadCara;

                }

                else if (txtSeleccion.Text == "Cara")
                {
                    for (int j = 0; j < n; j++)
                    {
                        txtApuestai.Text = txtApuestai.Text + apuesta + "\r\n";
                        txtMonto.Text = txtMonto.Text + montoInicial + "\r\n";
                        montoInicial -= apuesta;

                        if (NP[j] >= 0.5)
                        {
                            Eventos.Add("Cara");

                            montoInicial += apuesta * 8;



                        }
                        else
                        {
                            Eventos.Add("Cruz");



                            apuesta *= 2;

                            if (montoInicial < 0)
                            {
                                montoInicial = 0;
                            }
                        }




                        if (montoInicial >= meta)
                        {
                            Resultado.Add("Exito");
                        }
                        else if (montoInicial <= 0)
                        {
                            Resultado.Add("Quiebra");

                            MessageBox.Show(" Sin fondos suficientes para continuar");



                        }
                        else
                        {
                            Resultado.Add(" ");
                        }


                        txtResultado.Text = txtResultado.Text + Resultado[j] + "\r\n";
                        txtIteracion.Text = txtIteracion.Text + j + "\r\n";
                        txtEvento.Text = txtEvento.Text + Eventos[j] + "\r\n";

                        txtRi.Text = txtRi.Text + NP[j] + "\r\n";
                        txtMontoPosterior.Text = txtMontoPosterior.Text + montoInicial.ToString() + "\r\n";

                        if (montoInicial <= 0)
                        {
                            break;
                        }



                    }

                    foreach (string elemento in Eventos)
                    {
                        if (elemento == "Cruz")
                        {
                            cantidadCruz++;
                        }
                        else if (elemento == "Cara")
                        {
                            cantidadCara++;
                        }
                    }
                    txtMontoFinal.Text = txtMontoFinal.Text + montoInicial + "\r\n";
                    txtJuegosGanados.Text = txtJuegosGanados.Text + cantidadCara + "\r\n";
                    txtJuegosPerdidos.Text = txtJuegosPerdidos.Text + cantidadCruz + "\r\n";
                }

                else
                {
                    MessageBox.Show("Opcion no valida, elige cara o cruz");
                    btnIniciar.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Inserte los valores para la Simulacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnIniciar.Enabled = true;
            }


        }

      
    }
}
