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
        int[] baraja = new int[48];
        int contador = 1;
        int carta = 0;

        public AdivinaLaCarta()
        {
            InitializeComponent();
            GenerarBaraja(ref baraja, ref carta, contador);
            MezclarBaraja(baraja);

            cartaActual = 1;
            cartaSigiente = 2;
            labelCartaActual.Text = baraja[cartaActual].ToString();
          
        }

        static void GenerarBaraja(ref int[] baraja, ref int carta, int contador)
        {
            
            for (int i = 1; i <= 12; i++)
            {
                for (int b = 1; b <= 4; b++)
                {
                    baraja[carta] = contador;
                    carta = carta + 1;
                }
                contador = contador + 1;
            }
    
        }

        static void MezclarBaraja(int[] baraja)
        {
            var seed = Environment.TickCount;
            Random random = new Random(seed);
            int auxiliar;
            int posicion;

            for (int i = 0; i < baraja.Length; i++)
            {
                posicion = random.Next(0, baraja.Length);
                auxiliar = baraja[posicion];
                baraja[posicion] = baraja[i];
                baraja[i] = auxiliar;
            }
        }

        

        private void btnAdvMayor_Click(object sender, EventArgs e)
        {
            if (baraja[cartaActual] < baraja[cartaSigiente])
            {
                MessageBox.Show("Muy bien, salió el naipe N°"+ baraja[cartaSigiente]);
                cartaActual = cartaActual + 1;
                cartaSigiente = cartaSigiente + 1;
                intentos++;
            }
            else
            {
                MessageBox.Show("Salió el naipe N° "+baraja[cartaSigiente]
                    +" y la carta es menor. Perdiste despúes de "+intentos+" intentos");
                intentos = 0;

            }
            MezclarBaraja(baraja);
            labelCartaActual.Text = baraja[cartaActual].ToString();
      

        }
        private void btnAdvMenor_Click(object sender, EventArgs e)
        {
            if (baraja[cartaActual] > baraja[cartaSigiente])
            {
                MessageBox.Show("Muy bien, salió el naipe N°" + baraja[cartaSigiente]);
                cartaActual = cartaActual + 1;
                cartaSigiente = cartaSigiente + 1;
                intentos++;
            }
            else
            {
                MessageBox.Show("Salió el naipe N°" + baraja[cartaSigiente] 
                    + "y la carta es mayor. Perdiste despúes de "+ intentos+" intentos");
                intentos = 0;
            }
            MezclarBaraja(baraja);
            labelCartaActual.Text = baraja[cartaActual].ToString();

        }


    }
}
