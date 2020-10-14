using PROGRAMACION_I.Data;
using PROGRAMACION_I.message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PROGRAMACION_I.games
{
    public partial class Quiniela : Form
    {
        int numeroApostado, premioAcertado, apuesta, intentos=0;
        int[] numerosPremiados = new int[5];
        SinglePlayer sp;
 
        public Quiniela()
        {
            if (!Properties.Settings.Default.userSignedIn)
            {
                this.Hide();
                return;
            }
           
            InitializeComponent();
            Mezclar(numerosPremiados);
            lblNameSp.Text = "Bienvenido: " + Properties.Settings.Default.currentPlayer.Name;
            sp = Properties.Settings.Default.currentPlayer;
            pictureBox.Image = Image.FromFile(@"C:\Users\user\Desktop\TEC-PROGRAMACION\FOTOS\logo-animado.gif");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        static void Mezclar(int[]numerosPremiados)
        {
            Random random = new Random();

            for (int i = 1; i < 2; i++)
            {
                numerosPremiados[i] = random.Next(1, 3);
            }
            ErrorMessage premioAcer = new ErrorMessage( "Premios en: " + numerosPremiados[1]);
            premioAcer.Visible = true;

        }
        
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            numeroApostado = ((CheckBox)sender).Checked ? int.Parse(((CheckBox)sender).Text) : numeroApostado;            
        }

        public IEnumerable<Control> GetRecursiveAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetRecursiveAll(ctrl, type))
                                    .Concat(controls)
                                    .Where(c => c.GetType() == type);
        }
        
        private void AceptarApuesta_Click(object sender, EventArgs e)
        {

            if (txtApuesta.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto a apostar");
                return;
            }

            apuesta = int.Parse(txtApuesta.Text);

            intentos++;

            for (int i = 0; i < 5; i++)
            {
                   
                if (intentos == 1 && numerosPremiados[i] == numeroApostado)
                {
                    premioAcertado = numerosPremiados[i];
                    MessageBox.Show("Felicidades, acertaste en el primer intento con el número " + premioAcertado + ", ganaste $"+ apuesta * 10);
                  
                    new SinglePlayerDB().AddScoreQuiniela(sp, intentos);
                    intentos = 0;
                    foreach (var checkBox in GetRecursiveAll(this, typeof(CheckBox)))
                    {
                        ((CheckBox)checkBox).Checked = false;
                    }
                    foreach (var checkBox in GetRecursiveAll(this, typeof(TextBox)))
                    {
                        ((TextBox)checkBox).Text = "";
                    }
                    Mezclar(numerosPremiados);
                    break;
                }

                if (intentos != 1 && numerosPremiados[i] == numeroApostado)
                {
                    premioAcertado = numerosPremiados[i];
                    MessageBox.Show("Felicidades, acertaste en el " + intentos + " intento. Número premiado "+ premioAcertado + ", ganaste $"+ apuesta * 3 );
                    new SinglePlayerDB().AddScoreQuiniela(sp, intentos);
                    intentos = 0;

                    foreach (var checkBox in GetRecursiveAll(this, typeof(CheckBox)))
                    {
                        ((CheckBox)checkBox).Checked = false;
                    }
                    foreach (var checkBox in GetRecursiveAll(this, typeof(TextBox)))
                    {
                        ((TextBox)checkBox).Text = "";
                    }
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
