using PROGRAMACION_I.Data;
using PROGRAMACION_I.games;
using PROGRAMACION_I.Player;
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
        SinglePlayerDB oSinglePlayerDC;
        DataTable table, table2, table3;

        public FormSignIn()
        {
            InitializeComponent();
            cssTablas();
            oSinglePlayerDC = new SinglePlayerDB();
            if (Properties.Settings.Default.currentPlayer != null)
            {
                var data = oSinglePlayerDC.ShowPlayer(Properties.Settings.Default.currentPlayer.Name).Tables[0].Rows[0];
                cargarTabla(data);
                
            }
        }
    
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            var user = textPlayerName.Text;
            if (oSinglePlayerDC.ShowPlayer(user).Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Usuario no encontrado");
                Properties.Settings.Default.userSignedIn = false;
                return;
            }
            else
            {
                btnSalir.Enabled = true;
                btnIngreso.Enabled = false;
            }

            var data = oSinglePlayerDC.ShowPlayer(user).Tables[0].Rows[0];
            MessageBox.Show("Bienvenido " + data["name"].ToString());

            cargarTabla(data);

            SinglePlayer sp = new SinglePlayer();
            sp.Name = data["name"].ToString();
            sp.ID = int.Parse(data["id"].ToString());

            Properties.Settings.Default.currentPlayer = sp;
            Properties.Settings.Default.userSignedIn = true;
            Properties.Settings.Default.Save();

            cssTablas();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.userSignedIn = false;
            Properties.Settings.Default.currentPlayer = null;
            btnIngreso.Enabled = true;
            btnSalir.Enabled = false;
            limpiarTablas();
            textPlayerName.Text = null;
            Properties.Settings.Default.Save();

        }

        private void limpiarTablas()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
        }

        private void cargarTabla(DataRow data)
        {

            table = new DataTable();
            table.Columns.Add("Nombre");
            table.Columns.Add("Score");
            dataGridView1.DataSource = table;

            var QuinielaList = oSinglePlayerDC.DataContextListQuiniela(int.Parse(data["id"].ToString()));
            foreach (var item in QuinielaList)
            {
                DataRow fila = table.NewRow();
                fila["Nombre"] = item.SinglePlayer.Name;
                fila["Score"] = item.Score;
                table.Rows.Add(fila);
            }

            table2 = new DataTable();
            table2.Columns.Add("Nombre");
            table2.Columns.Add("Score");
            dataGridView2.DataSource = table2;
            var DarVueltaList = oSinglePlayerDC.DataContextListDarVueltas(int.Parse(data["id"].ToString()));
            foreach (var item in DarVueltaList)
            {
                DataRow fila = table2.NewRow();
                fila["Nombre"] = item.SinglePlayer.Name;
                fila["Score"] = item.Score;
                table2.Rows.Add(fila);
            }

            table3 = new DataTable();
            table3.Columns.Add("Nombre");
            table3.Columns.Add("Score");
            dataGridView3.DataSource = table3;
            var AdivinaLaCartaList = oSinglePlayerDC.DataContextListAdivinaCartaScore(int.Parse(data["id"].ToString()));
            foreach (var item in AdivinaLaCartaList)
            {
                DataRow fila = table3.NewRow();
                fila["Nombre"] = item.SinglePlayer.Name;
                fila["Score"] = item.Score;
                table3.Rows.Add(fila);
            }
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
            
            //dataGridView1.Size = new Size(label2.Size.Width / 3, 300);

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridView2.Size = new Size(label2.Size.Width / 3, 300);

            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           // dataGridView3.Size = new Size(label2.Size.Width / 3, 300);

        }
    }
}
