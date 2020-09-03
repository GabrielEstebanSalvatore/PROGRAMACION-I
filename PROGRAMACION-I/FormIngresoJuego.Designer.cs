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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignUp.Location = new System.Drawing.Point(290, 229);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(210, 59);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "REGISTRARME";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignIn.Location = new System.Drawing.Point(12, 229);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(217, 59);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "INGRESAR";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "TABLERO DE JUEGOS";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(511, 305);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // FormIngresoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(512, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "FormIngresoJuego";
            this.Text = "TABLERO DE JUEGOS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

