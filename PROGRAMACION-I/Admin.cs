using PROGRAMACION_I.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PROGRAMACION_I
{
    public partial class Admin : Form
    {

        SinglePlayerDB oSinglePlayerDC;
        int currentID, indice;
         
        public Admin()
        {
            InitializeComponent();
            oSinglePlayerDC = new SinglePlayerDB();
            dataGridView1.DataSource = oSinglePlayerDC.ShowPlayer().Tables[0];
            cssTablas();
        }
        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            indice = e.RowIndex;
            currentID = int.Parse(dataGridView1.Rows[indice].Cells[0].Value.ToString());
            txtNameOfPlayer.Text = currentID.ToString();
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            oSinglePlayerDC.Delete(currentID);
            dataGridView1.DataSource = oSinglePlayerDC.ShowPlayer().Tables[0];
        }
        private void cssTablas()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
