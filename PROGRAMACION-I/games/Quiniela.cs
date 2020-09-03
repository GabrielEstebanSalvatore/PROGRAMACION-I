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
    public partial class Quiniela : Form
    {
        int numeroApostado, premioAcertado, apuesta, intentos=0;
        int[] numerosPremiados = new int[5];
        Random random = new Random();
 
        public Quiniela()
        {
            InitializeComponent();
            //MessageBox.Show();
            Mezclar(numerosPremiados);

            pictureBox.Image = Image.FromFile(@"C:\Users\user\Desktop\TEC-PROGRAMACION\FOTOS\logo-animado.gif");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        static void Mezclar(int[]numerosPremiados)
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                numerosPremiados[i] = random.Next(0, 30);
                //ErrorMessage premioAcer = new ErrorMessage(i + 1 + "Premios en: " + numerosPremiados[i]);
                //premioAcer.Visible = true;
            }
            ErrorMessage premioAcer = new ErrorMessage( "Premios en: " + numerosPremiados[1]);
            premioAcer.Visible = true;
        }


        private void AceptarApuesta_Click(object sender, EventArgs e)
        {
           
            //numeroApostado = int.Parse(txtNumeroApostar.Text);
            apuesta = int.Parse(txtApuesta.Text);
            intentos++;

            if(checkBox1.Checked == true && checkBox1.Enabled == true)
            {
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
                numeroApostado = 1;
            }
            if (checkBox2.Checked == true && checkBox2.Enabled == true)
            {
                checkBox2.Checked = true;
                checkBox2.Enabled = false;
                numeroApostado = 2;
            }
            if (checkBox3.Checked == true && checkBox3.Enabled == true)
            {
                checkBox3.Checked = true;
                checkBox3.Enabled = false;
                numeroApostado = 3;
            }
            if (checkBox4.Checked == true && checkBox4.Enabled == true)
            {
                checkBox4.Checked = true;
                checkBox4.Enabled = false;
                numeroApostado = 4;
            }
            if (checkBox5.Checked == true && checkBox5.Enabled == true)
            {
                checkBox1.Checked = true;
                checkBox1.Enabled = false;
                numeroApostado = 5;
            }

            if (numeroApostado <= 0 || numeroApostado > 30)
            {

                MessageBox.Show( "DEBES INGRESAR UN VALOR ENTRE 1 y 30");
 
            }
            else 
            {
                for (int i = 0; i < 5; i++)
                {
                   
                    if (intentos == 1 && numerosPremiados[i] == numeroApostado)
                    {
                        premioAcertado = numerosPremiados[i];
                        ErrorMessage premioAcer = new ErrorMessage("Felicidades, acertaste en el primer intento con el número "+ premioAcertado + ", ganaste $"+ apuesta * 10);
                        premioAcer.Visible = true;
                        intentos = 0;
                        Mezclar(numerosPremiados);
                        break;
                    }

                    if (intentos != 1 && numerosPremiados[i] == numeroApostado)
                    {
                        premioAcertado = numerosPremiados[i];
                        ErrorMessage premioAcer = new ErrorMessage("Felicidades, acertaste en el " + intentos + " intento. Número premiado "+ premioAcertado + ", ganaste $"+ apuesta * 3 );
                        premioAcer.Visible = true;
                        intentos = 0;
                        Mezclar(numerosPremiados);
                        break;

                    }
                    if (i == 4)
                    {
                        MessageBox.Show("No ganaste ningun premio, vuelve a intentarlo");
                        break;
                    }

             
                }



            }
        }
    }
}
