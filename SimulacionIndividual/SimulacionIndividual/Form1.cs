using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionIndividual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Generador de numeros pseudoaletorios
        public void Generador()
        {
            try
            {
                int x0;
                int A;
                int C;
                int M;
                int n;

                n = int.Parse(txtCantidad.Text);
                float[] arr = new float[n];
                x0 = int.Parse(txtValorXo.Text);
                A = int.Parse(txtValorA.Text);
                C = int.Parse(txtValorC.Text);
                M = int.Parse(txtValorM.Text);

                for (int i = 0; i < n; i++)
                {
                    int r = dgvPseudoaleatorio.Rows.Add();

                    dgvPseudoaleatorio.Rows[r].Cells[0].Value = i + 1;

                    float aux = (x0 * A + C);
                    float most = x0 * A;
                    aux %= M;
                    aux = aux / M;
                    arr[i] = aux;
                    x0 = Convert.ToInt32(aux * M);
                    dgvPseudoaleatorio.Rows[r].Cells[1].Value = aux.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generador();
        }

        private void btnCalcularUniformemente_Click(object sender, EventArgs e)
        {
            try
            {
                int v = 0, cantidad;
                double[] lis1 = new double[dgvPseudoaleatorio.RowCount];
                double a = Convert.ToDouble(txtValorUniforme1.Text);
                double b = Convert.ToDouble(txtValorUniforme2.Text);
                double InicioJornada = Convert.ToDouble(txtInicioJornada.Text);
                v = int.Parse(txtValorInicial.Text);
                cantidad = int.Parse(txtCantidadFinal.Text);
                for (int x = 0; x < cantidad; x++)
                {
                    int r = dgvUniforme.Rows.Add();
                    dgvUniforme.Rows[r].Cells[0].Value = x + 1;

                    dgvUniforme.Rows[r].Cells[1].Value = dgvPseudoaleatorio.Rows[v - 1].Cells[1].Value;
                    lis1[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v - 1].Cells[1].Value);

                    dgvUniforme.Rows[r].Cells[1].Value = lis1[x];
                    dgvUniforme.Rows[r].Cells[2].Value = a + ((b - a) * Convert.ToDouble(dgvUniforme.Rows[r].Cells[1].Value));
                    if (x == 0)
                    {
                        dgvUniforme.Rows[r].Cells[3].Value = InicioJornada + Convert.ToDouble(dgvUniforme.Rows[x].Cells[2].Value);
                        dgvUniforme.Rows[r].Cells[4].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value);
                        dgvUniforme.Rows[r].Cells[5].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value);
                    }
                    else
                    {
                        dgvUniforme.Rows[r].Cells[3].Value = Convert.ToDouble(dgvUniforme.Rows[x - 1].Cells[3].Value) + Convert.ToDouble(dgvUniforme.Rows[x].Cells[2].Value);
                        dgvUniforme.Rows[r].Cells[4].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value);
                    }
                    v++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n", ex.Message);

            }
        }

        private void btnDistribucionTriangular_Click(object sender, EventArgs e)
        {
            double relacion = 0, prom = 0, Prom2 = 0;

            try
            {
                int v = 0, cantidad;
                double[] lis1 = new double[dgvPseudoaleatorio.RowCount];

                relacion = (Convert.ToDouble(txtValorPromedio.Text) - Convert.ToDouble(txtValorMinimo.Text)) / (Convert.ToDouble(txtValorMaximo.Text) - Convert.ToDouble(txtValorMinimo.Text));
                txtRelacion.Text = relacion.ToString();
                v = int.Parse(txtValorInicial.Text);
                cantidad = int.Parse(txtCantidadFinal.Text);
                for (int x = 0; x < cantidad; x++)
                {
                    int r = dgvDistribucionTriangular.Rows.Add();
                    lis1[x] = Convert.ToDouble(dgvPseudoaleatorio.Rows[v].Cells[1].Value);
                    dgvDistribucionTriangular.Rows[r].Cells[0].Value = lis1[x];

                    if (lis1[x] > relacion)
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[1].Value = Convert.ToDouble(txtValorMaximo.Text) - Math.Sqrt((Convert.ToDouble(txtValorMaximo.Text) - Convert.ToDouble(txtValorPromedio.Text)) * (1 - Convert.ToDouble(lis1[x])));
                    }
                    else
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[1].Value = Convert.ToDouble(txtValorMinimo.Text) + Math.Sqrt((Convert.ToDouble(txtValorPromedio.Text) - Convert.ToDouble(txtValorMinimo.Text)) * Convert.ToDouble(lis1[x]));

                    }

                    if (x == 0)
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[3].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(txtInicioJornada.Text);
                        dgvDistribucionTriangular.Rows[r].Cells[2].Value = Convert.ToDouble(dgvDistribucionTriangular.Rows[r].Cells[1].Value) + Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value);

                    }
                    else
                    {
                        dgvDistribucionTriangular.Rows[r].Cells[2].Value = Convert.ToDouble(dgvDistribucionTriangular.Rows[r].Cells[1].Value) + Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value);

                        if (Convert.ToDouble(dgvDistribucionTriangular.Rows[r].Cells[2].Value) > Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value))
                        {
                            dgvUniforme.Rows[x].Cells[4].Value = Convert.ToDouble(dgvDistribucionTriangular.Rows[x - 1].Cells[2].Value);
                        }
                        else
                        {
                            dgvUniforme.Rows[x].Cells[4].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value);
                        }
                        dgvDistribucionTriangular.Rows[r].Cells[3].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(dgvDistribucionTriangular.Rows[x - 1].Cells[2].Value);
                    }

                    dgvUniforme.Rows[x].Cells[5].Value = Convert.ToDouble(dgvUniforme.Rows[x].Cells[4].Value) - Convert.ToDouble(dgvUniforme.Rows[x].Cells[3].Value);
                    v++;
                }
                foreach (DataGridViewRow row in dgvUniforme.Rows)
                {
                    prom = prom + Convert.ToDouble(row.Cells[5].Value);
                }
                foreach (DataGridViewRow data in dgvDistribucionTriangular.Rows)
                {
                    Prom2 = Prom2 + Convert.ToDouble(data.Cells[1].Value);
                }
                Prom2 = Prom2 / dgvDistribucionTriangular.RowCount;
                prom = prom / dgvUniforme.RowCount;
                double R = Prom2 + prom;
                lblResultado.Text = "Prom de minutos perdidos:\n" + Math.Round(prom, 2).ToString() + "\n" + "Prom de minutos de vueltas:\n" + Math.Round(Prom2, 2).ToString() + "\nResultado final:\n" + Math.Round(R, 2).ToString() + " Minutos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("El formato de entrada no es el correcto.\nIntente de nuevo\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvDistribucionTriangular.Rows.Clear();
            dgvPseudoaleatorio.Rows.Clear();
            dgvUniforme.Rows.Clear();
            txtCantidad.Clear();
            txtValorInicial.Clear();
            txtRelacion.Clear();
            txtInicioJornada.Clear();
            txtCantidadFinal.Clear();
            txtValorUniforme1.Clear();
            txtValorUniforme2.Clear();
            lblResultado.Text = "";
        }

        private void enunciadoDeEjercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnunciadoEjercicio EnunciadoForm = new EnunciadoEjercicio();
            EnunciadoForm.Show();
            WindowState = FormWindowState.Minimized;
        }

        private void elaboradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este proyecto esta elaborado por:\nGaniz Galaz Aaron 23211003");
        }

        private void txtValorXo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
