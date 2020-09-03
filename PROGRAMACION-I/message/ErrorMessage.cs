using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMACION_I.message
{
    public partial class ErrorMessage : Form
    {
        public ErrorMessage()
        {
            InitializeComponent();
        }
        public ErrorMessage(string text)
        {
            InitializeComponent();
            TextErrorMessage.Text = text;
        }


        /*
        public ErrorMessage(string text ,int posicionPremiado, int premio)
        {
            InitializeComponent();
            string CompleteText = text + posicionPremiado.ToString() + premio.ToString();
            TextErrorMessage.Text = CompleteText;
        }

        public ErrorMessage(string text, int posicionPremiado, int premio, int numeroPremiado)
        {
            InitializeComponent();
            string CompleteText = text + posicionPremiado.ToString() + premio.ToString() + numeroPremiado.ToString();
            TextErrorMessage.Text = CompleteText;
        }*/


        private void ErrorMessageBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
