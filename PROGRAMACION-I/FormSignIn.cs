using PROGRAMACION_I.games;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION_I
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            pictureBoxQuiniela.Image = Image.FromFile(@"C:\Users\user\Desktop\TEC-PROGRAMACION\FOTOS\gift.gif");
            pictureBoxQuiniela.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxAdivina.Image = Image.FromFile(@"C:\Users\user\Desktop\TEC-PROGRAMACION\FOTOS\gift.gif");
            pictureBoxAdivina.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxDarVueltas.Image = Image.FromFile(@"C:\Users\user\Desktop\TEC-PROGRAMACION\FOTOS\gift.gif");
            pictureBoxDarVueltas.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void pictureBoxQuiniela_Click(object sender, EventArgs e)
        {
            Quiniela quiniela = new Quiniela();
            quiniela.Visible = true;
        }

        private void pictureBoxDarVueltas_Click(object sender, EventArgs e)
        {
            DarVueltas darVueltas = new DarVueltas();
            darVueltas.Visible = true;
        }

        private void pictureBoxAdivina_Click(object sender, EventArgs e)
        {
            AdivinaLaCarta adivinaLaCarta = new AdivinaLaCarta();
            adivinaLaCarta.Visible = true;
        }
    }
}
