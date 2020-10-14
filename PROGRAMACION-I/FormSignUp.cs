using PROGRAMACION_I.Data;
using PROGRAMACION_I.message;
using System;
using System.Windows.Forms;

namespace PROGRAMACION_I
{
    public partial class FormSignUp : Form
    {
        SinglePlayerDB oSinglePlayerDC;
        int currentID, indice;

        public FormSignUp()
        {
            oSinglePlayerDC = new SinglePlayerDB();
            InitializeComponent();
            dataGridView1.DataSource = oSinglePlayerDC.ShowPlayer().Tables[0];
        }

        private SinglePlayer CreatedSinglePlayer()
        {

            SinglePlayer singlePlayer = new SinglePlayer();
      
            singlePlayer.Name = txtNameOfPlayer.Text;
          
            return singlePlayer;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var playerExist = oSinglePlayerDC.ShowPlayer(txtNameOfPlayer.Text); 
         
            if (playerExist.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("El nombre de usuario ya existe");
                return;
            }
           
            oSinglePlayerDC.Add(CreatedSinglePlayer());
            dataGridView1.DataSource = oSinglePlayerDC.ShowPlayer().Tables[0];

        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;

            currentID = int.Parse(dataGridView1.Rows[indice].Cells[0].Value.ToString());
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        { 
     
            oSinglePlayerDC.Delete(currentID);
            dataGridView1.DataSource = oSinglePlayerDC.ShowPlayer().Tables[0];
            
        }
    }
}


