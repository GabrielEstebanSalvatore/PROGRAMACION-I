namespace PROGRAMACION_I.games
{
    partial class AdivinaLaCarta
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
            this.btnAdvMayor = new System.Windows.Forms.Button();
            this.btnAdvMenor = new System.Windows.Forms.Button();
            this.labelCartaActual = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNameSp = new System.Windows.Forms.Label();
            this.lblReglas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdvMayor
            // 
            this.btnAdvMayor.BackColor = System.Drawing.Color.Green;
            this.btnAdvMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvMayor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdvMayor.Location = new System.Drawing.Point(717, 140);
            this.btnAdvMayor.Name = "btnAdvMayor";
            this.btnAdvMayor.Size = new System.Drawing.Size(140, 99);
            this.btnAdvMayor.TabIndex = 1;
            this.btnAdvMayor.Text = "MAYOR";
            this.btnAdvMayor.UseVisualStyleBackColor = false;
            this.btnAdvMayor.Click += new System.EventHandler(this.btnAdvMayor_Click);
            // 
            // btnAdvMenor
            // 
            this.btnAdvMenor.BackColor = System.Drawing.Color.Yellow;
            this.btnAdvMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAdvMenor.Location = new System.Drawing.Point(571, 140);
            this.btnAdvMenor.Name = "btnAdvMenor";
            this.btnAdvMenor.Size = new System.Drawing.Size(140, 99);
            this.btnAdvMenor.TabIndex = 2;
            this.btnAdvMenor.Text = "MENOR";
            this.btnAdvMenor.UseVisualStyleBackColor = false;
            this.btnAdvMenor.Click += new System.EventHandler(this.btnAdvMenor_Click);
            // 
            // labelCartaActual
            // 
            this.labelCartaActual.AutoSize = true;
            this.labelCartaActual.Font = new System.Drawing.Font("Open Sans Semibold", 38F, System.Drawing.FontStyle.Bold);
            this.labelCartaActual.Location = new System.Drawing.Point(680, 63);
            this.labelCartaActual.Name = "labelCartaActual";
            this.labelCartaActual.Size = new System.Drawing.Size(59, 70);
            this.labelCartaActual.TabIndex = 3;
            this.labelCartaActual.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(613, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "ADIVINA LA CARTA";
            // 
            // lblNameSp
            // 
            this.lblNameSp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameSp.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblNameSp.CausesValidation = false;
            this.lblNameSp.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameSp.Location = new System.Drawing.Point(8, 16);
            this.lblNameSp.Name = "lblNameSp";
            this.lblNameSp.Size = new System.Drawing.Size(237, 24);
            this.lblNameSp.TabIndex = 56;
            this.lblNameSp.Text = "Bienvenido";
            this.lblNameSp.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblReglas
            // 
            this.lblReglas.AutoSize = true;
            this.lblReglas.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblReglas.Location = new System.Drawing.Point(12, 83);
            this.lblReglas.Name = "lblReglas";
            this.lblReglas.Size = new System.Drawing.Size(322, 95);
            this.lblReglas.TabIndex = 57;
            this.lblReglas.Text = "Reglas de juego:\r\n\r\n1 - En pantalla saldra una carta del 1 al 12\r\n2- Usted debe e" +
    "lejir MAYOR o MENOR \r\nconsiderando que saldra en la proxima ronda\r\n";
            // 
            // AdivinaLaCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.lblReglas);
            this.Controls.Add(this.lblNameSp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelCartaActual);
            this.Controls.Add(this.btnAdvMenor);
            this.Controls.Add(this.btnAdvMayor);
            this.Name = "AdivinaLaCarta";
            this.Text = "AdivinaLaCarta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdvMayor;
        private System.Windows.Forms.Button btnAdvMenor;
        protected System.Windows.Forms.Label labelCartaActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNameSp;
        private System.Windows.Forms.Label lblReglas;
    }
}