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
        SinglePlayerDC oSinglePlayerDC;
        int Id = 0;

        public FormSignUp()
        {
            oSinglePlayerDC = new SinglePlayerDC();
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
            string text = "Conectado..";
            ErrorMessage errorMessage = new ErrorMessage(text+ oSinglePlayerDC.Add()); 
            errorMessage.Visible = true;

            
        }
    }
}


