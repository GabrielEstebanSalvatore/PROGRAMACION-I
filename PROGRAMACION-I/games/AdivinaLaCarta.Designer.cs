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
            this.textCartaActual = new System.Windows.Forms.TextBox();
            this.btnAdvMayor = new System.Windows.Forms.Button();
            this.btnAdvMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCartaActual
            // 
            this.textCartaActual.Location = new System.Drawing.Point(256, 72);
            this.textCartaActual.Name = "textCartaActual";
            this.textCartaActual.Size = new System.Drawing.Size(248, 20);
            this.textCartaActual.TabIndex = 0;
            // 
            // btnAdvMayor
            // 
            this.btnAdvMayor.Location = new System.Drawing.Point(429, 145);
            this.btnAdvMayor.Name = "btnAdvMayor";
            this.btnAdvMayor.Size = new System.Drawing.Size(75, 23);
            this.btnAdvMayor.TabIndex = 1;
            this.btnAdvMayor.Text = "MAYOR";
            this.btnAdvMayor.UseVisualStyleBackColor = true;
            this.btnAdvMayor.Click += new System.EventHandler(this.btnAdvMayor_Click);
            // 
            // btnAdvMenor
            // 
            this.btnAdvMenor.Location = new System.Drawing.Point(256, 145);
            this.btnAdvMenor.Name = "btnAdvMenor";
            this.btnAdvMenor.Size = new System.Drawing.Size(75, 23);
            this.btnAdvMenor.TabIndex = 2;
            this.btnAdvMenor.Text = "MENOR";
            this.btnAdvMenor.UseVisualStyleBackColor = true;
            this.btnAdvMenor.Click += new System.EventHandler(this.btnAdvMenor_Click);
            // 
            // AdivinaLaCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdvMenor);
            this.Controls.Add(this.btnAdvMayor);
            this.Controls.Add(this.textCartaActual);
            this.Name = "AdivinaLaCarta";
            this.Text = "AdivinaLaCarta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCartaActual;
        private System.Windows.Forms.Button btnAdvMayor;
        private System.Windows.Forms.Button btnAdvMenor;
    }
}