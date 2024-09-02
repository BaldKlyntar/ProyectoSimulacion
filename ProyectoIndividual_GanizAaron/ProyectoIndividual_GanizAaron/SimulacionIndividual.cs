using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIndividual_GanizAaron
{
    public partial class SimulacionIndividual : Form
    {
        public int n;
        public double[] NP;

        List<string> Ventas = new List<string>();
        List<string> Reviews = new List<string>();
        List<string> Comics = new List<string>();
        List<string> Meses = new List<string>
        {
            "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };







        public SimulacionIndividual(double[] nP, int N)
        {
            InitializeComponent();

            NP = nP;
            n = N;
        }

        private void SimulacionIndividual_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;

            int MinRev, MedRev, MaxRev, MinVen, MedVen, MaxVen, MinCom, MedCom, MaxCom;

            double RevComp, VenComp, X, Xt, ComComp, Xc;

            MinRev = 5;
            MedRev = 7;
            MaxRev = 10;

            MinVen = 250;
            MedVen = 345;
            MaxVen = 500;

            MinCom = 600;
            MedCom = 800;
            MaxCom = 1500;


            ComComp = ((MedCom - MinCom) / (MaxCom - MinCom));
            RevComp = ((MedRev - MinRev) / (MaxRev - MinRev));
            VenComp = ((MedVen - MinVen) / (MaxVen - MinVen));

            double[] NP2 = new double[12];
            Array.Copy(NP, 12,  NP2, 0, 12);
            double[] NP3 = new double[12];
            Array.Copy(NP, 24 , NP3, 0, 12);

            double[] rXt = new double[12];
            double[] rX = new double[12];

            for (int i = 0; i < 12; i++)
            {
         

                // Reseñas
                if (NP[i] <= RevComp)
                {
                    X = MinRev + Math.Sqrt((MaxRev - MinRev) * (MedRev - MinRev) * NP[i]);
                    X = Math.Round(X, 2);
                }
                else
                {
                    X = MaxRev - Math.Sqrt((MaxRev - MinRev) * (MaxRev - MedRev) * (1 - NP[i]));
                    X = Math.Round(X, 2);
                }

                if (X >= 9 && X <= 10)
                {
                    Reviews.Add("Obra Maestra");
                }
                else if (X >= 7 && X < 9)
                {
                    Reviews.Add("Entretenido");
                }
                else
                {
                    Reviews.Add("Malo");
                }



                txtRi2.Text = txtRi2.Text + NP[i] + "\r\n";
                txtResultado2.Text = txtResultado2.Text + Reviews[i] + "\r\n";
                txtReview.Text = txtReview.Text + X + "\r\n";

                rX[i] = X;
                
            }

        

            // Ventas
            for (int j = 0; j < 12; j++)
            {

                if (NP2[j] <= VenComp)
                {
                    Xt = MinVen + Math.Sqrt((MaxVen - MinVen) * (MedVen - MinVen) * NP2[j]);
                    Xt = Math.Round(Xt, 0);
                }
                else
                {
                    Xt = MaxVen - Math.Sqrt((MaxVen - MinVen) * (MaxVen - MedVen) * (1 - NP2[j]));
                    Xt = Math.Round(Xt, 0);
                }

                if (Xt <= 500 && Xt > 345)
                {
                    Ventas.Add("Exito");
                }
                else if (Xt <= 345 && Xt > 250)
                {
                    Ventas.Add("Aceptable");
                }
                else
                {
                    Ventas.Add("Fracaso");
                }

                txtRi.Text = txtRi.Text + NP2[j] + "\r\n";
                txtResultado.Text = txtResultado.Text + Ventas[j] + "\r\n";
                txtVentas.Text = txtVentas.Text + Xt + "\r\n";

                rXt[j] = Xt;
            }

            //Comics

            for (int k = 0; k < 12; k++)
            {
                if (k == 0 || k == 6)
                {
                    
                        if (NP3[k] <= ComComp)
                        {
                            Xc = MinCom + Math.Sqrt((MaxCom - MinCom) * (MedCom - MinCom) * NP3[k]);
                            Xc = Math.Round(Xc, 0);
                        }
                        else
                        {
                            Xc = MaxCom - Math.Sqrt((MaxCom - MinCom) * (MaxCom - MedCom) * (1 - NP3[k]));
                            Xc = Math.Round(Xc, 0);
                        }

                        if (Xc > 800 && Xc <= 1500)
                        {
                            Comics.Add("Venom");
                        }
                        else if (Xc < 800 && Xc >= 600)
                        {
                            Comics.Add("Ghost Rider");
                        }
                        else
                        {
                            Comics.Add("Spider Man");
                        }

                        txtFranquicia.Text = txtFranquicia.Text + Comics[k] + "\r\n";

                    
                }

                else if (k == 4 || k == 10)
                {
                    
                        if (NP3[k] <= ComComp)
                        {
                            Xc = MinCom + Math.Sqrt((MaxCom - MinCom) * (MedCom - MinCom) * NP3[k]);
                            Xc = Math.Round(Xc, 0);
                        }
                        else
                        {
                            Xc = MaxCom - Math.Sqrt((MaxCom - MinCom) * (MaxCom - MedCom) * (1 - NP3[k]));
                            Xc = Math.Round(Xc, 0);
                        }

                        if (Xc > 800 && Xc <= 1500)
                        {
                            Comics.Add("Venom");
                        }
                        else if (Xc < 800 && Xc >= 600)
                        {
                            Comics.Add("Spider Man");
                        }
                        else
                        {
                            Comics.Add("Ghost Rider");
                        }

                        txtFranquicia.Text = txtFranquicia.Text + Comics[k] + "\r\n";

                    
                }

                else if (k == 1 || k == 7)
                {
                    
                        if (NP3[k] <= ComComp)
                        {
                            Xc = MinCom + Math.Sqrt((MaxCom - MinCom) * (MedCom - MinCom) * NP3[k]);
                            Xc = Math.Round(Xc, 0);
                        }
                        else
                        {
                            Xc = MaxCom - Math.Sqrt((MaxCom - MinCom) * (MaxCom - MedCom) * (1 - NP3[k]));
                            Xc = Math.Round(Xc, 0);
                        }

                        if (Xc > 800 && Xc <= 1500)
                        {
                            Comics.Add("Spider man");
                        }
                        else if (Xc < 800 && Xc >= 600)
                        {
                            Comics.Add("Venom");
                        }
                        else
                        {
                            Comics.Add("Ghost Rider");
                        }

                        txtFranquicia.Text = txtFranquicia.Text + Comics[k] + "\r\n";

                    



                }

                else if (k == 3 || k == 9)
                {
                   
                        if (NP3[k] <= ComComp)
                        {
                            Xc = MinCom + Math.Sqrt((MaxCom - MinCom) * (MedCom - MinCom) * NP3[k]);
                            Xc = Math.Round(Xc, 0);
                        }
                        else
                        {
                            Xc = MaxCom - Math.Sqrt((MaxCom - MinCom) * (MaxCom - MedCom) * (1 - NP3[k]));
                            Xc = Math.Round(Xc, 0);
                        }

                        if (Xc > 800 && Xc <= 1500)
                        {
                            Comics.Add("Spider man");
                        }
                        else if (Xc < 800 && Xc >= 600)
                        {
                            Comics.Add("Ghost Rider");
                        }
                        else
                        {
                            Comics.Add("Venom");
                        }

                        txtFranquicia.Text = txtFranquicia.Text + Comics[k] + "\r\n";

                    

                    
                }

                else if (k == 2 || k == 5 || k == 8 || k == 11)
                {
                    
                        if (NP3[k] <= ComComp)
                        {
                            Xc = MinCom + Math.Sqrt((MaxCom - MinCom) * (MedCom - MinCom) * NP3[k]);
                            Xc = Math.Round(Xc, 0);
                        }
                        else
                        {
                            Xc = MaxCom - Math.Sqrt((MaxCom - MinCom) * (MaxCom - MedCom) * (1 - NP3[k]));
                            Xc = Math.Round(Xc, 0);
                        }

                        if (Xc > 800 && Xc <= 1500)
                        {
                            Comics.Add("Ghost Rider");
                        }
                        else if (Xc < 800 && Xc >= 600)
                        {
                            Comics.Add("Spider man");
                        }
                        else
                        {
                            Comics.Add("Venom");
                        }

                        txtFranquicia.Text = txtFranquicia.Text + Comics[k] + "\r\n";

                    

                    
                }

                txtIteracion.Text = txtIteracion.Text + k + "\r\n";

            }



            for (int l= 0; l<Meses.Count; l++)
            {
                txtMes.Text = txtMes.Text + Meses[l] + "\r\n";
            }


            double[] resultados = new double[]
            {
                NP[0] + NP2[0],
                NP[1] + NP2[1],
                NP[2] + NP2[2],
                NP[3] + NP2[3],
                NP[4] + NP2[4],
                NP[5] + NP2[5],
                NP[6] + NP2[6],
                NP[7] + NP2[7],
                NP[8] + NP2[8],
                NP[9] + NP2[9],
                NP[10] + NP2[10],
                NP[11] + NP2[11],
            };


        
            int indiceGanador = Array.IndexOf(resultados, resultados.Max());

          
            string franquiciaGanadora = Comics[indiceGanador];

            
            txtComYear.Text = txtComYear.Text + franquiciaGanadora;


        

         

            double ventasGanador = rXt[indiceGanador];
            double reseñasGanador = rX[indiceGanador];

            
            double ventasTotalesGanador = 0;
            double sumaReseñasGanador = 0;
            int cantidadReseñasGanador = 0;

            for (int m = 0; m < Comics.Count; m++)
            {
                if (Comics[m] == franquiciaGanadora)
                {
                    ventasTotalesGanador += rXt[m];
                    sumaReseñasGanador += rX[m];
                    cantidadReseñasGanador++;
                }
            }

            double promedioReseñasGanador = cantidadReseñasGanador > 0 ? sumaReseñasGanador / cantidadReseñasGanador : 0;
            txtVentasTotales.Text = txtVentasTotales.Text +  ventasTotalesGanador + "\r\n";
            txtCalificacion.Text = txtCalificacion.Text +  Math.Round(promedioReseñasGanador, 2) + "\r\n";






        }
    }
}
