using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElemenTable
{
    public partial class CapasElectronicas : Form
    {

        private Timer timer;
        private double[] angles;
        private int[] radii;
        private int numeroAtomico;
        public CapasElectronicas(int elemento)
        {
            InitializeComponent();
            numeroAtomico = elemento;
            ConfigurarElemento(elemento);
            InitializeTimer();
          
            this.ClientSize = new Size(297, 237); // Tamaño del formulario
        }


        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 30; // Intervalo en milisegundos para la animación
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listAngulosXElec.Count; i++)
            {
                listAngulosXElec[i] += 0.03;
            }
            Refresh();
        }

        List<double> listAngulosXElec = new List<double> { };
        private void ConfigurarElemento(int elemento)
        {

         
            ncapas = configuracionesElectronicas[numeroAtomico - 1].Length;

            double pos = 0;

            for (int i = 0; i < ncapas; i++)
            {
                int electronesxCapa= configuracionesElectronicas[numeroAtomico - 1][i];
                pos = listAngulos[ncapas - 1][i];
                for (int j = 0; j < electronesxCapa; j++)
                {
               
                    pos += 1;
                    listAngulosXElec.Add(pos);
                   
                }

            }
            ncapas = configuracionesElectronicas[numeroAtomico - 1].Length;
        }

        int ncapas = 0;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            int radiob = 30;
            ncapas = configuracionesElectronicas[numeroAtomico-1].Length;
            // Dibuja las capas/orbitas electrónicas
            for (int i = 0; i < ncapas; i++)
            {
               // int radius = radii[i];
                g.DrawEllipse(Pens.Gray, ClientSize.Width / 2 - radiob, ClientSize.Height / 2 - radiob, 2 * radiob, 2 * radiob);

                if (numeroAtomico <= 71)
                {
                    radiob = radiob + 20 - 4;
                }
                else
                {
                    radiob = radiob + 20 - 3;
                }
            }

            // Dibujar el núcleo del átomo
            g.FillEllipse(Brushes.Black, ClientSize.Width / 2 - 3, ClientSize.Height / 2 - 3, 10, 10);
            radiob = 30;
            //for (int i = 0; i < ncapas; i++)
            //{
            //    double posx = listAngulos[ncapas - 1][i];
            //    double posy = listAngulos[ncapas - 1][i];
            //    int x = (int)(ClientSize.Width / 2 + radiob * Math.Cos(posx));
            //    int y = (int)(ClientSize.Height / 2 + radiob * Math.Sin(posy));

            //    if (numeroAtomico <= 71)
            //    {
            //        radiob = radiob + 20 - 4;
            //    }
            //    else
            //    {
            //        radiob = radiob + 20 - 3;
            //    }

            //    g.FillEllipse(Brushes.Blue, x - 3, y - 3, 6, 6); // Dibuja los electrones con un tamaño de 6x6
            //}
            int natom = 0;
            for (int i = 0; i < ncapas; i++)
            {
                for (int j = 0;j < configuracionesElectronicas[numeroAtomico-1][ncapas-1]; j++)
                {

                    if (natom <= numeroAtomico-1)
                    {
                        int x = (int)(ClientSize.Width / 2 + radiob * Math.Cos(listAngulosXElec[natom]));
                        int y = (int)(ClientSize.Height / 2 + radiob * Math.Sin(listAngulosXElec[natom]));

                        natom++;

                        g.FillEllipse(Brushes.Blue, x - 3, y - 3, 6, 6); // Dibuja los electrones con un tamaño de 6x6
                    }
              
                }


                if (numeroAtomico <= 71)
                {
                    radiob = radiob + 20 - 4;
                }
                else
                {
                    radiob = radiob + 20 - 3;
                }

              
            }


        }

        List<double[]> listAngulos = new List<double[]>
        {
             new double[] { 0 },

             new double[] { 0, Math.PI },

             new double[] { 0, Math.PI, 0 },

             new double[] { 0, Math.PI, 0, Math.PI },

             new double[] { 0, Math.PI, 0, Math.PI, Math.PI / 2 },

             new double[] { 0, Math.PI, 0, Math.PI, Math.PI / 2, Math.PI * 3 / 2 },

};

        List<int[]> configuracionesElectronicas = new List<int[]>
        {
            new int[] { 1 },
            new int[] { 2 },
            new int[] { 2, 1 },
            new int[] { 2, 2 },
            new int[] { 2, 2, 1 },
            new int[] { 2, 2, 2 },
            new int[] { 2, 2, 3 },
            new int[] { 2, 4 },
            new int[] { 2, 5 },
            new int[] { 2, 5, 1 },
            new int[] { 2, 8, 1 },
            new int[] { 2, 8, 2 },
            new int[] { 2, 8, 3 },
            new int[] { 2, 8, 4 },
            new int[] { 2, 8, 5 },
            new int[] { 2, 8, 6 },
            new int[] { 2, 8, 7 },
            new int[] { 2, 8, 8 },
            new int[] { 2, 8, 8, 1 },
            new int[] { 2, 8, 8, 2 },
            new int[] { 2, 8, 9, 2 },
            new int[] { 2, 8, 10, 2 },
            new int[] { 2, 8, 11, 2 },
            new int[] { 2, 8, 13, 1 },
            new int[] { 2, 8, 13, 2 },
            new int[] { 2, 8, 14, 2 },
            new int[] { 2, 8, 15, 2 },
            new int[] { 2, 8, 16, 2 },
            new int[] { 2, 8, 18, 1 },
            new int[] { 2, 8, 18, 2 },
            new int[] { 2, 8, 18, 3 },
            new int[] { 2, 8, 18, 4 },
            new int[] { 2, 8, 18, 7 }, // 36 (Kriptón)
            new int[] { 2, 8, 18, 8 }, // 37 (Rubidio)
            new int[] { 2, 8, 18, 8, 1 }, // 38 (Estroncio)
            new int[] { 2, 8, 18, 8, 2 }, // 39 (Itrio)
            new int[] { 2, 8, 18, 9, 2 }, // 40 (Circonio)
            new int[] { 2, 8, 18, 10, 2 }, // 41 (Niobio)
            new int[] { 2, 8, 11, 2 }, // 42 (Molibdeno)
            new int[] { 2, 8, 13, 1 }, // 43 (Tecnecio)
            new int[] { 2, 8, 13, 2 }, // 44 (Rutenio)
            new int[] { 2, 8, 14, 2 }, // 45 (Rodio)
            new int[] { 2, 8, 15, 2 }, // 46 (Paladio)
            new int[] { 2, 8, 16, 2 }, // 47 (Plata)
            new int[] { 2, 8, 18, 1 }, // 48 (Cadmio)
            new int[] { 2, 8, 18, 2 }, // 49 (Indio)
            new int[] { 2, 8, 18, 3 }, // 50 (Estaño)
            new int[] { 2, 8, 18, 4 }, // 51 (Antimonio)
            new int[] { 2, 8, 18, 5 }, // 52 (Telurio)
            new int[] { 2, 8, 18, 6 }, // 53 (Yodo)
            new int[] { 2, 8, 18, 7 }, // 54 (Xenón)
            new int[] { 2, 8, 18, 8 }, // 55 (Cesio)
            new int[] { 2, 8, 18, 8, 1 }, // 56 (Bario)
            new int[] { 2, 8, 18, 8, 2 }, // 57 (Lantano)
            new int[] { 2, 8, 18, 9, 2 }, // 58 (Cerio)
            new int[] { 2, 8, 18, 10, 2 }, // 59 (Praseodimio)
            new int[] { 2, 8, 18, 11, 2 }, // 60 (Neodimio)
            new int[] { 2, 8, 18, 12, 2 }, // 61 (Prometio)
            new int[] { 2, 8, 18, 13, 2 }, // 62 (Samario)
            new int[] { 2, 8, 18, 14, 2 }, // 63 (Europio)
            new int[] { 2, 8, 18, 15, 2 }, // 64 (Gadolinio)
            new int[] { 2, 8, 18, 16, 2 }, // 65 (Terbio)
            new int[] { 2, 8, 18, 17, 2 }, // 66 (Disprosio)
            new int[] { 2, 8, 18, 18, 2 }, // 67 (Holmio)
            new int[] { 2, 8, 18, 19, 2 }, // 68 (Erbio)
            new int[] { 2, 8, 18, 20, 2 }, // 69 (Tulio)
            new int[] { 2, 8, 18, 21, 2 }, // 70 (Iterbio)
            new int[] { 2, 8, 18, 22, 2 }, // 71 (Lutecio)
            new int[] { 2, 8, 18, 32, 18, 1 }, // 72 (Hafnio)
            new int[] { 2, 8, 18, 32, 20, 2 }, // 73 (Tantalio)
            new int[] { 2, 8, 18, 32, 21, 2 }, // 74 (Wolframio)
            new int[] { 2, 8, 18, 32, 22, 2 }, // 75 (Renio)
            new int[] { 2, 8, 18, 32, 23, 2 }, // 76 (Osmio)
            new int[] { 2, 8, 18, 32, 24, 2 }, // 77 (Iridio)
            new int[] { 2, 8, 18, 32, 25, 2 }, // 78 (Platino)
            new int[] { 2, 8, 18, 32, 26, 2 }, // 79 (Oro)
            new int[] { 2, 8, 18, 32, 27, 2 }, // 80 (Mercurio)
            new int[] { 2, 8, 18, 32, 28, 2 }, // 81 (Talio)
            new int[] { 2, 8, 18, 32, 29, 2 }, // 82 (Plomo)
            new int[] { 2, 8, 18, 32, 30, 2 }, // 83 (Bismuto)
            new int[] { 2, 8, 18, 32, 31, 2 }, // 84 (Polonio)
            new int[] { 2, 8, 18, 32, 32, 2 }, // 85 (Astato)
            new int[] { 2, 8, 18, 32, 32, 17, 1 }, // 86 (Radón)
            new int[] { 2, 8, 18, 32, 32, 18, 1 }, // 87 (Francio)
            new int[] { 2, 8, 18, 32, 32, 18, 2 }, // 88 (Radio)
            new int[] { 2, 8, 18, 32, 32, 18, 3 }, // 89 (Actinio)
            new int[] { 2, 8, 18, 32, 32, 18, 4 }, // 90 (Torio)
            new int[] { 2, 8, 18, 32, 32, 18, 5 }, // 91 (Protactinio)
            new int[] { 2, 8, 18, 32, 32, 18, 6 }, // 92 (Uranio)
            new int[] { 2, 8, 18, 32, 32, 18, 7 }, // 93 (Neptunio)
            new int[] { 2, 8, 18, 32, 32, 18, 8 }, // 94 (Plutonio)
            new int[] { 2, 8, 18, 32, 32, 18, 9 }, // 95 (Americio)
            new int[] { 2, 8, 18, 32, 32, 18, 10 }, // 96 (Curio)
            new int[] { 2, 8, 18, 32, 32, 18, 11 }, // 97 (Berkelio)
            new int[] { 2, 8, 18, 32, 32, 18, 12 }, // 98 (Californio)
            new int[] { 2, 8, 18, 32, 32, 18, 13 }, // 99 (Einstenio)
            new int[] { 2, 8, 18, 32, 32, 18, 14 }, // 100 (Fermio)
            new int[] { 2, 8, 18, 32, 32, 18, 15 }, // 101 (Mendelevio)
            new int[] { 2, 8, 18, 32, 32, 18, 16 }, // 102 (Nobelio)
            new int[] { 2, 8, 18, 32, 32, 18, 17 }, // 103 (Lawrencio)
            new int[] { 2, 8, 18, 32, 32, 18, 18 }, // 104 (Rutherfordio)
            new int[] { 2, 8, 18, 32, 32, 18, 19 }, // 105 (Dubnio)
            new int[] { 2, 8, 18, 32, 32, 18, 20 }, // 106 (Seaborgio)
            new int[] { 2, 8, 18, 32, 32, 18, 21 }, // 107 (Bohrio)
            new int[] { 2, 8, 18, 32, 32, 18, 22 }, // 108 (Hasio)
            new int[] { 2, 8, 18, 32, 32, 18, 23 }, // 109 (Meitnerio)
            new int[] { 2, 8, 18, 32, 32, 18, 24 }, // 110 (Darmstadtio)
            new int[] { 2, 8, 18, 32, 32, 18, 25 }, // 111 (Roentgenio)
            new int[] { 2, 8, 18, 32, 32, 18, 26 }, // 112 (Copernicio)
            new int[] { 2, 8, 18, 32, 32, 18, 27 }, // 113 (Nihonio)
            new int[] { 2, 8, 18, 32, 32, 18, 28 }, // 114 (Flerovio)
            new int[] { 2, 8, 18, 32, 32, 18, 29 }, // 115 (Moscovio)
            new int[] { 2, 8, 18, 32, 32, 18, 30 }, // 116 (Livermorio)
            new int[] { 2, 8, 18, 32, 32, 18, 31 }, // 117 (Tenesino)
            new int[] { 2, 8, 18, 32, 32, 18, 32 }, // 118 (Oganesón)
        };

    
    }
}
