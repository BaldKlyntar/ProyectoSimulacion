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
    public partial class Prueba_Poker : Form
    {

        public int n;
        public double[] NP;

        public Prueba_Poker(double[] nP, int N)
        {
            InitializeComponent();
            NP = nP;
            n= N;
        }

        private void Prueba_Poker_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1PFE.Clear();
            txt1PFO.Clear();
            txt1PX.Clear();
            txt1PP.Clear();
            txt2PFE.Clear();
            txt2PFO.Clear();
            txt2PX.Clear();
            txt2PP.Clear();
            txtTDFE.Clear();
            txtTDFO.Clear();
            txtTDP.Clear();
            txtTDX.Clear();
            txt3IFE.Clear();
            txt3IFO.Clear();
            txt3IP.Clear();
            txt3IX.Clear();
            txtTPFE.Clear();
            txtTPX.Clear();
            txtTPFO.Clear();
            txtTPP.Clear();
            txt4IFE.Clear();
            txt4IFO.Clear();
            txt4IP.Clear();
            txt4IX.Clear();
            txtTIFE.Clear();
            txtTIFO.Clear();
            txtTIP.Clear();
            txtTIX.Clear();
            txtFESUM.Clear();
            txtFOSUM.Clear();
            txtXSUM.Clear();
            txtTablas.Clear();
            txtResultado.Clear();
            btnIniciarPoker.Enabled = true;
        }

        private void btnIniciarPoker_Click(object sender, EventArgs e)
        {
            btnIniciarPoker.Enabled = false;
          

            if (NP != null)
            {
                if (txtAlfa.Text == "")
                {
                    MessageBox.Show("Selecciona un valor Alfa");
                }
                else
                {
                    try
                    {




                        int TD, ONEP, TWOP, THREEI, TP, FOURI, TI, i, FOSUM;
                        double ChiTablas, FESUM, PSUM, XSUM, TDP, ONEPP, TWOPP, THREEIP, TPP, FOURIP, TIP,
                                TDFE, ONEPFE, TWOPFE, THREEPFE, TPFE, FOURIFE, TIFE, TDX, ONEPX, TWOPX, THREEIX, 
                                TPX, FOURIX, TIX;

                        TDP = 0.30240;
                        ONEPP = 0.50400;
                        TWOPP = 0.10800;
                        THREEIP = 0.07200;
                        TPP = 0.00900;
                        FOURIP = 0.00450;
                        TIP = 0.00010;

                        TD = 0;
                        ONEP = 0;
                        TWOP = 0;
                        THREEI = 0;
                        TP = 0;
                        FOURI = 0;
                        TI = 0;
                        i = 0;
                        ChiTablas = 0;



                        while (i < NP.Length)
                        {
                            
                            string numeroComoTexto = NP[i].ToString();
                            string parteDecimal = numeroComoTexto.Split('.')[1];

                           
                            List<char> digitos = parteDecimal.Distinct().ToList();

                            
                            //**
                            if (digitos.Count == parteDecimal.Length)
                            {
                                TD++;
                            }
                            //**
                            else if (digitos.Count == parteDecimal.Length - 1)
                            {
                                ONEP++;
                            }
                            //**
                            else if (digitos.Count == 1)
                            {
                                TI++;
                            }
                            else
                            {
                                int maxRepetitions = 0;
                                int pairsCount = 0;
                                int reptres = 0;

                                foreach (char digito in digitos)
                                {
                                    int repeticiones = parteDecimal.Count(c => c == digito);

                                    if (repeticiones == 4)
                                    {
                                        FOURI++;
                                    }
                                    else if (repeticiones == 3)
                                    {
                                        reptres++;
                                        if (maxRepetitions == 2)
                                        {
                                            TP++;
                                        }
                                        maxRepetitions = 3;
                                    }
                                    else if (repeticiones == 2)
                                    {
                                        if (maxRepetitions == 3)
                                        {
                                            TP++;
                                        }
                                        else
                                        {
                                            pairsCount++;
                                            maxRepetitions = 2;
                                        }
                                    }
                                }

                                if (maxRepetitions == 2 && pairsCount == 2 && digitos.Count == 3 && reptres == 0)
                                {
                                    TWOP++;
                                }
                                else if (maxRepetitions == 3 && digitos.Count == 3 && reptres == 1)
                                {
                                    THREEI++;
                                }
                            }





                            i++;

                        }

                        txtTDFO.Text = TD.ToString();
                        txt1PFO.Text = ONEP.ToString();
                        txt2PFO.Text = TWOP.ToString();
                        txt3IFO.Text = THREEI.ToString();
                        txtTPFO.Text = TP.ToString();
                        txt4IFO.Text = FOURI.ToString();
                        txtTIFO.Text = TI.ToString();

                        FOSUM = (TD + ONEP + TWOP + THREEI + TP + FOURI + TI);

                        txtFOSUM.Text = FOSUM.ToString();

                        txtTDP.Text = TDP.ToString();
                        txt1PP.Text = ONEPP.ToString();
                        txt2PP.Text = TWOPP.ToString();
                        txt3IP.Text = THREEIP.ToString();
                        txtTPP.Text = TPP.ToString();
                        txt4IP.Text = FOURIP.ToString();
                        txtTIP.Text = TIP.ToString();

                        PSUM = (TDP + ONEPP + TWOPP + THREEIP + TPP + FOURIP + TIP);

                        txtPSUM.Text = PSUM.ToString();

                        TDFE = TDP * n;
                        ONEPFE = ONEPP * n;
                        TWOPFE = TWOPP * n;
                        THREEPFE = THREEIP * n;
                        TPFE = TPP * n;
                        FOURIFE = FOURIP * n;
                        TIFE = TIP * n;

                        txtTDFE.Text = TDFE.ToString();
                        txt1PFE.Text = ONEPFE.ToString();
                        txt2PFE.Text = TWOPFE.ToString();
                        txt3IFE.Text = THREEPFE.ToString();
                        txtTPFE.Text = TPFE.ToString();
                        txt4IFE.Text = FOURIFE.ToString();
                        txtTIFE.Text = TIFE.ToString();

                        FESUM = (TDFE + ONEPFE + TWOPFE + THREEPFE + TPFE + FOURIFE + TIFE);
                        txtFESUM.Text = FESUM.ToString();



                        TDX = (Math.Pow((TD - TDFE), 2)) / TDFE;
                        ONEPX = (Math.Pow((ONEP - ONEPFE), 2)) / ONEPFE;
                        TWOPX = (Math.Pow((TWOP - TWOPFE), 2)) / TWOPFE;
                        THREEIX = (Math.Pow((THREEI - THREEPFE), 2)) / THREEPFE;
                        TPX = (Math.Pow((TP - TPFE), 2)) / TPFE;
                        FOURIX = (Math.Pow((FOURI - FOURIFE), 2)) / FOURIFE;
                        TIX = (Math.Pow((TI - TIFE), 2)) / TIFE;

                        txtTDX.Text = TDX.ToString();
                        txt1PX.Text = ONEPX.ToString();
                        txt2PX.Text = TWOPX.ToString();
                        txt3IX.Text = THREEIX.ToString();
                        txtTPX.Text = TPX.ToString();
                        txt4IX.Text = FOURIX.ToString();
                        txtTIX.Text = TIX.ToString();

                        XSUM = (TDX + ONEPX + TWOPX + THREEIX + TPX + FOURIX + TIX);
                        txtXSUM.Text = XSUM.ToString();





















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

                        if(double.Parse(txtXSUM.Text) <= ChiTablas)
                        {
                            txtResultado.Text = txtResultado.Text + "Distribuidos Uniformemente";
                        }
                        else
                        {
                            txtResultado.Text = txtResultado.Text + "No Distribuidos Uniformemente";
                        }
                        
                    }


                    catch (Exception)
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


    }
}
