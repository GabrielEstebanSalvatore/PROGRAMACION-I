using PROGRAMACION_I.Data;
using PROGRAMACION_I.games;
using System;
using System.Windows.Forms;

namespace PROGRAMACION_I
{
    public partial class FormIngresoJuego : Form
    {
        private Form currentForm = null;
        public FormIngresoJuego()
        {
            InitializeComponent();
            OpenChildForm(new FormSignUp());
            btnRes.Visible = false;
        }

        private void FormIngresoJuego_Load(object sender, EventArgs e)
        {
            hideSubMenu();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }
        private void OpenChildForm(Form childForm)
        {

            if (currentForm != null)
            {
                currentForm.Hide();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.Show();
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRes.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnRes.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSignUp());
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSignIn());
        }

        private void hideSubMenu()
        {
            panelGames.Visible = false;
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            panelGames.Visible = true;
        }

        private void btnAdivinaCarta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdivinaLaCarta( ));
        }
        private void btnQuiniela_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quiniela());
        }

        private void btnDarVueltas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DarVueltas());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin());
        }
    }
}
