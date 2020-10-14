using PROGRAMACION_I.Data;
using PROGRAMACION_I.message;
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
    public partial class DarVueltas : Form
    {
        int[] BOCALES = new int[10] { 1,2,3,4,5,6,7,8,9,10};
        int intentos = 0, posicion, TAM = 10, numeroIngresado ;
        int auxiliar = ' ';
        SinglePlayer sp;
   
        Random random = new Random();
     
        public DarVueltas()
        {
            if (Properties.Settings.Default.currentPlayer == null)
            {
                this.Hide();
                return;
            }
            InitializeComponent();
            lblNameSp.Text = "Bienvenido: "+ Properties.Settings.Default.currentPlayer.Name;
            sp = Properties.Settings.Default.currentPlayer;

            //PINTO ARRAY INICIAL MEZCLADO
            for (int i = 0; i < TAM; i++)
            {
                posicion = random.Next(0, BOCALES.Length);
                auxiliar = BOCALES[posicion];
                BOCALES[posicion] = BOCALES[i];
                BOCALES[i] = auxiliar;

                numero1.Text = BOCALES[0].ToString();
                numero2.Text = BOCALES[1].ToString();
                numero3.Text = BOCALES[2].ToString();
                numero4.Text = BOCALES[3].ToString();
                numero5.Text = BOCALES[4].ToString();
                numero6.Text = BOCALES[5].ToString();
                numero7.Text = BOCALES[6].ToString();
                numero8.Text = BOCALES[7].ToString();
                numero9.Text = BOCALES[8].ToString();
                numero10.Text = BOCALES[9].ToString();

            }

        }


        private void AcceptVariable_Click(object sender, EventArgs e)
        {
            numeroIngresado = int.Parse(textBoxIngresoValor.Text);
            if (numeroIngresado > TAM || numeroIngresado < 1)
            {

                string text = "DEBES INGRESAR UN VALOR ENTRE 1 y 5";
                ErrorMessage errorMessage = new ErrorMessage(text);
                errorMessage.Visible = true;

            }
            else
            {
                int indice = numeroIngresado - 1;
             

                int[] BOCALES2 = new int[numeroIngresado];

                for (int i = 0; i < numeroIngresado; i++)
                {
                    BOCALES2[i] = BOCALES[indice];
                    indice--;

                }
                for (int i = 0; i < numeroIngresado; i++)
                {
                    BOCALES[i] = BOCALES2[i];
                }

                numero1.Text = BOCALES[0].ToString();
                numero2.Text = BOCALES[1].ToString();
                numero3.Text = BOCALES[2].ToString();
                numero4.Text = BOCALES[3].ToString();
                numero5.Text = BOCALES[4].ToString();
                numero6.Text = BOCALES[5].ToString();
                numero7.Text = BOCALES[6].ToString();
                numero8.Text = BOCALES[7].ToString();
                numero9.Text = BOCALES[8].ToString();
                numero10.Text = BOCALES[9].ToString();

                intentos = intentos + 1;

                if (BOCALES[0] == 1 && BOCALES[1] == 2 && BOCALES[2] == 3 &&
                    BOCALES[3] == 4 && BOCALES[4] == 5 && BOCALES[5] == 6
                    && BOCALES[6] == 7 && BOCALES[7] == 8 && BOCALES[8] == 9 && BOCALES[9] == 10)
                {
                    string text = "GANASTE EN " + intentos + " INTENTOS ";
                    new SinglePlayerDB().AddScoreDarVueltas(sp, intentos);

                    ErrorMessage errorMessage = new ErrorMessage(text);
                    errorMessage.Visible = true;

                    /*//PINTO ARRAY INICIAL MEZCLADO
                    for (int i = 0; i < TAM; i++)
                    {
                        posicion = random.Next(0, BOCALES.Length);
                        auxiliar = BOCALES[posicion];
                        BOCALES[posicion] = BOCALES[i];
                        BOCALES[i] = auxiliar;

                        label2.Text = BOCALES[0].ToString();
                        label3.Text = BOCALES[1].ToString();
                        label4.Text = BOCALES[2].ToString();
                        label5.Text = BOCALES[3].ToString();
                        label6.Text = BOCALES[4].ToString();

                        textBoxIngresoValor.Text = "";
                    }*/

                }

            }
        }
    }
}
