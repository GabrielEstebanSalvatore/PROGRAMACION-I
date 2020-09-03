using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION_I.games
{
    public partial class AdivinaLaCarta : Form
    {
        int intentos=1, cartaSigiente, cartaActual;
        int[] baraja1 = new int[48];
        int contador = 1;
        int carta = 0;

        public AdivinaLaCarta()
        {
            InitializeComponent();
            GenerarBaraja(ref baraja1, ref carta, contador);
            MezclarBaraja(baraja1);

            cartaActual = 1;
            cartaSigiente = 2;

            textCartaActual.Text = baraja1[cartaActual].ToString();
        }

        static void GenerarBaraja(ref int[] baraja1, ref int carta, int contador)
        {
            
            for (int i = 1; i <= 12; i++)
            {
                for (int b = 1; b <= 4; b++)
                {
                    baraja1[carta] = contador;
                    carta = carta + 1;
                }
                contador = contador + 1;
            }
    
        }

        static void MezclarBaraja(int[] baraja1)
        {
            var seed = Environment.TickCount;
            Random random = new Random(seed);
            int auxiliar;
            int posicion;

            for (int i = 0; i < baraja1.Length; i++)
            {
                posicion = random.Next(0, baraja1.Length);
                auxiliar = baraja1[posicion];
                baraja1[posicion] = baraja1[i];
                baraja1[i] = auxiliar;
            }
        }

        private void btnAdvMayor_Click(object sender, EventArgs e)
        {
            if (baraja1[cartaActual] < baraja1[cartaSigiente])
            {
                MessageBox.Show("Muy bien, salió el naipe N°"+ baraja1[cartaSigiente]);
                cartaActual = cartaActual + 1;
                cartaSigiente = cartaSigiente + 1;
                intentos++;
            }
            else
            {
                MessageBox.Show("Salió el naipe N° "+baraja1[cartaSigiente]
                    +" y la carta es menor. Perdiste despúes de "+intentos+" intentos");
                intentos = 0;

            }
            MezclarBaraja(baraja1);
            textCartaActual.Text = baraja1[cartaActual].ToString();

        }
        private void btnAdvMenor_Click(object sender, EventArgs e)
        {
            if (baraja1[cartaActual] > baraja1[cartaSigiente])
            {
                MessageBox.Show("Muy bien, salió el naipe N°" + baraja1[cartaSigiente]);
                cartaActual = cartaActual + 1;
                cartaSigiente = cartaSigiente + 1;
                intentos++;
            }
            else
            {
                MessageBox.Show("Salió el naipe N°" + baraja1[cartaSigiente] 
                    + "y la carta es mayor. Perdiste despúes de "+ intentos+" intentos");
                intentos = 0;
            }
            MezclarBaraja(baraja1);
            textCartaActual.Text = baraja1[cartaActual].ToString();
        }


    }
}
