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
        char[] BOCALES = new char[5] { 'A', 'E', 'I', 'O', 'U' };
        int intentos = 0, posicion, TAM = 5, variable ;
        char auxiliar = ' ';
        //object sender;
        //EventArgs e;
        bool condicion = false;

   
        Random random = new Random();
     
        public DarVueltas()
        {
            InitializeComponent();

            

            //PINTO ARRAY INICIAL MEZCLADO
            for (int i = 0; i < TAM; i++)
            {
                posicion = random.Next(0, BOCALES.Length);
                auxiliar = BOCALES[posicion];
                BOCALES[posicion] = BOCALES[i];
                BOCALES[i] = auxiliar;

                //}

                label2.Text = BOCALES[0].ToString();
                label3.Text = BOCALES[1].ToString();
                label4.Text = BOCALES[2].ToString();
                label5.Text = BOCALES[3].ToString();
                label6.Text = BOCALES[4].ToString();

            }

            //AcceptVariable_Click( sender,  e);
        }

       

        private void AcceptVariable_Click(object sender, EventArgs e)
        {
            variable = int.Parse(textBoxIngresoValor.Text);
            if (variable > TAM || variable < 1)
            {

                string text = "DEBES INGRESAR UN VALOR ENTRE 1 y 5";
                ErrorMessage errorMessage = new ErrorMessage(text);
                errorMessage.Visible = true;

            }
            else
            {
                variable = variable - 1;

                //PINTO ARRAY MODIFICADO POR USUARIO
                auxiliar = BOCALES[variable];
                BOCALES[variable] = BOCALES[0];
                BOCALES[0] = auxiliar;

                label2.Text = BOCALES[0].ToString();
                label3.Text = BOCALES[1].ToString();
                label4.Text = BOCALES[2].ToString();
                label5.Text = BOCALES[3].ToString();
                label6.Text = BOCALES[4].ToString();

                intentos = intentos + 1;

                if (BOCALES[0] == 'A' && BOCALES[1] == 'E' && BOCALES[2] == 'I' &&
                    BOCALES[3] == 'O' && BOCALES[4] == 'U')
                {
                    string text = "GANASTE EN " + intentos + " INTENTOS ";
                    ErrorMessage errorMessage = new ErrorMessage(text);
                    errorMessage.Visible = true;

                    //PINTO ARRAY INICIAL MEZCLADO
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
                    }

                }

            }
        }
    }
}
