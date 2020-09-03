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

namespace PROGRAMACION_I
{
    public partial class FormSignUp : Form
    {
        int Id = 0;
        public FormSignUp()
        {
            InitializeComponent();
        }
        private void CreatedSinglePlayer()
        {
            
            SinglePlayer singlePlayer = new SinglePlayer();
            singlePlayer.Name = txtNameOfPlayer.Text;
            singlePlayer.ID = Id;
            singlePlayer.Coins = 0;
            singlePlayer.adivinaLaCartaScores = 0;
            singlePlayer.quinielaScores = 0;
            singlePlayer.darVueltasScores = 0;

            MessageBox.Show(singlePlayer.Name);
            MessageBox.Show(singlePlayer.ID.ToString());

            Id++;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreatedSinglePlayer();
            DataBase connection = new DataBase();
            string text = "Conectado..";
            ErrorMessage errorMessage = new ErrorMessage(text + connection.DataContext());
            errorMessage.Visible = true;

            
        }
    }
}
