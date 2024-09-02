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
    public partial class Simulacion : Form
    {
        public int n;
        public double[] NP;


        public Simulacion(double[] nP, int N)
        {
            InitializeComponent();

            NP = nP;
            n = N;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Simulacion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSImulacion_Click(object sender, EventArgs e)
        {

            if (n == 48)
            {
                SimulacionIndividual individual = new SimulacionIndividual(NP, n);
                individual.Show();
            }

            else
            {
                MessageBox.Show("Esta simulacion requiere de 48 numeros pseudoaleatorios");
            }







        }

        private void btnSimEquipo_Click(object sender, EventArgs e)
        {
            SimulacionEquipo equipo = new SimulacionEquipo(NP, n);
            equipo.Show();
        }
    }
}
