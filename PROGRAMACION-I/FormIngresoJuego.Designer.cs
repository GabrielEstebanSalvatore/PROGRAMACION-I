namespace PROGRAMACION_I
{
    partial class FormIngresoJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresoJuego));
            this.panelHeaderTop = new System.Windows.Forms.Panel();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSidebarLeft = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelGames = new System.Windows.Forms.Panel();
            this.btnDarVueltas = new System.Windows.Forms.Button();
            this.btnQuiniela = new System.Windows.Forms.Button();
            this.btnAdivinaCarta = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelHeaderTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelSidebarLeft.SuspendLayout();
            this.panelGames.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeaderTop
            // 
            this.panelHeaderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelHeaderTop.Controls.Add(this.btnRes);
            this.panelHeaderTop.Controls.Add(this.btnMin);
            this.panelHeaderTop.Controls.Add(this.btnMax);
            this.panelHeaderTop.Controls.Add(this.btnExit);
            this.panelHeaderTop.Controls.Add(this.label2);
            this.panelHeaderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderTop.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderTop.Name = "panelHeaderTop";
            this.panelHeaderTop.Size = new System.Drawing.Size(950, 61);
            this.panelHeaderTop.TabIndex = 4;
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.BackColor = System.Drawing.Color.Black;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(810, 12);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(23, 20);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRes.TabIndex = 9;
            this.btnRes.TabStop = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Black;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(839, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(23, 20);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMin.TabIndex = 8;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Black;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(868, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 20);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMax.TabIndex = 7;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(897, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(23, 20);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(501, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "TABLERO DE JUEGOS";
            // 
            // panelSidebarLeft
            // 
            this.panelSidebarLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelSidebarLeft.Controls.Add(this.btnAdmin);
            this.panelSidebarLeft.Controls.Add(this.panelGames);
            this.panelSidebarLeft.Controls.Add(this.btnGames);
            this.panelSidebarLeft.Controls.Add(this.btnSignIn);
            this.panelSidebarLeft.Controls.Add(this.btnSignUp);
            this.panelSidebarLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebarLeft.Location = new System.Drawing.Point(0, 61);
            this.panelSidebarLeft.Name = "panelSidebarLeft";
            this.panelSidebarLeft.Size = new System.Drawing.Size(200, 539);
            this.panelSidebarLeft.TabIndex = 3;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdmin.Location = new System.Drawing.Point(0, 509);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(200, 30);
            this.btnAdmin.TabIndex = 9;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panelGames
            // 
            this.panelGames.BackColor = System.Drawing.Color.DimGray;
            this.panelGames.Controls.Add(this.btnDarVueltas);
            this.panelGames.Controls.Add(this.btnQuiniela);
            this.panelGames.Controls.Add(this.btnAdivinaCarta);
            this.panelGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGames.Location = new System.Drawing.Point(0, 90);
            this.panelGames.Name = "panelGames";
            this.panelGames.Size = new System.Drawing.Size(200, 91);
            this.panelGames.TabIndex = 6;
            // 
            // btnDarVueltas
            // 
            this.btnDarVueltas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDarVueltas.FlatAppearance.BorderSize = 0;
            this.btnDarVueltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarVueltas.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDarVueltas.Location = new System.Drawing.Point(0, 60);
            this.btnDarVueltas.Name = "btnDarVueltas";
            this.btnDarVueltas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDarVueltas.Size = new System.Drawing.Size(200, 31);
            this.btnDarVueltas.TabIndex = 11;
            this.btnDarVueltas.Text = "DAR VUELTAS";
            this.btnDarVueltas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarVueltas.UseVisualStyleBackColor = true;
            this.btnDarVueltas.Click += new System.EventHandler(this.btnDarVueltas_Click);
            // 
            // btnQuiniela
            // 
            this.btnQuiniela.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuiniela.FlatAppearance.BorderSize = 0;
            this.btnQuiniela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuiniela.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnQuiniela.Location = new System.Drawing.Point(0, 30);
            this.btnQuiniela.Name = "btnQuiniela";
            this.btnQuiniela.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnQuiniela.Size = new System.Drawing.Size(200, 30);
            this.btnQuiniela.TabIndex = 10;
            this.btnQuiniela.Text = "QUINIELA";
            this.btnQuiniela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuiniela.UseVisualStyleBackColor = true;
            this.btnQuiniela.Click += new System.EventHandler(this.btnQuiniela_Click);
            // 
            // btnAdivinaCarta
            // 
            this.btnAdivinaCarta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdivinaCarta.FlatAppearance.BorderSize = 0;
            this.btnAdivinaCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdivinaCarta.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdivinaCarta.Location = new System.Drawing.Point(0, 0);
            this.btnAdivinaCarta.Name = "btnAdivinaCarta";
            this.btnAdivinaCarta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdivinaCarta.Size = new System.Drawing.Size(200, 30);
            this.btnAdivinaCarta.TabIndex = 9;
            this.btnAdivinaCarta.Text = "ADIVINA LA CARTA";
            this.btnAdivinaCarta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdivinaCarta.UseVisualStyleBackColor = true;
            this.btnAdivinaCarta.Click += new System.EventHandler(this.btnAdivinaCarta_Click);
            // 
            // btnGames
            // 
            this.btnGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGames.FlatAppearance.BorderSize = 0;
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGames.Location = new System.Drawing.Point(0, 60);
            this.btnGames.Name = "btnGames";
            this.btnGames.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGames.Size = new System.Drawing.Size(200, 30);
            this.btnGames.TabIndex = 8;
            this.btnGames.Text = "JUEGOS";
            this.btnGames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignIn.Location = new System.Drawing.Point(0, 30);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSignIn.Size = new System.Drawing.Size(200, 30);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "INGRESAR";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignUp.Location = new System.Drawing.Point(0, 0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSignUp.Size = new System.Drawing.Size(200, 30);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "REGISTRARME";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 61);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(750, 539);
            this.panelChildForm.TabIndex = 5;
            // 
            // FormIngresoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSidebarLeft);
            this.Controls.Add(this.panelHeaderTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormIngresoJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TABLERO DE JUEGOS";
            this.Load += new System.EventHandler(this.FormIngresoJuego_Load);
            this.panelHeaderTop.ResumeLayout(false);
            this.panelHeaderTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelSidebarLeft.ResumeLayout(false);
            this.panelGames.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeaderTop;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.Panel panelSidebarLeft;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel panelGames;
        private System.Windows.Forms.Button btnDarVueltas;
        private System.Windows.Forms.Button btnQuiniela;
        private System.Windows.Forms.Button btnAdivinaCarta;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnAdmin;
    }
}

