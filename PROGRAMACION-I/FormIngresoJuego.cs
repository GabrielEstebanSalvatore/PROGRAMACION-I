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
    public partial class FormIngresoJuego : Form
    {
        public FormIngresoJuego()
        {
            InitializeComponent();
            pictureBox.Image = Image.FromFile(@"C:\Users\user\Desktop\TEC-PROGRAMACION\FOTOS\gift.gif");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn IngresoCliente = new FormSignIn();
            IngresoCliente.Visible = true;

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp RegistroCliente = new FormSignUp();
            RegistroCliente.Visible = true;
        }
    }
}
