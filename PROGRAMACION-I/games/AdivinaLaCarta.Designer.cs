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
            this.SuspendLayout();
            // 
            // btnAdvMayor
            // 
            this.btnAdvMayor.Location = new System.Drawing.Point(519, 181);
            this.btnAdvMayor.Name = "btnAdvMayor";
            this.btnAdvMayor.Size = new System.Drawing.Size(140, 99);
            this.btnAdvMayor.TabIndex = 1;
            this.btnAdvMayor.Text = "MAYOR";
            this.btnAdvMayor.UseVisualStyleBackColor = true;
            this.btnAdvMayor.Click += new System.EventHandler(this.btnAdvMayor_Click);
            // 
            // btnAdvMenor
            // 
            this.btnAdvMenor.Location = new System.Drawing.Point(373, 181);
            this.btnAdvMenor.Name = "btnAdvMenor";
            this.btnAdvMenor.Size = new System.Drawing.Size(140, 99);
            this.btnAdvMenor.TabIndex = 2;
            this.btnAdvMenor.Text = "MENOR";
            this.btnAdvMenor.UseVisualStyleBackColor = true;
            this.btnAdvMenor.Click += new System.EventHandler(this.btnAdvMenor_Click);
            // 
            // labelCartaActual
            // 
            this.labelCartaActual.AutoSize = true;
            this.labelCartaActual.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartaActual.Location = new System.Drawing.Point(482, 104);
            this.labelCartaActual.Name = "labelCartaActual";
            this.labelCartaActual.Size = new System.Drawing.Size(70, 74);
            this.labelCartaActual.TabIndex = 3;
            this.labelCartaActual.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(160, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 31);
            this.label7.TabIndex = 27;
            this.label7.Text = "ADIVINA LA CARTA";
            // 
            // AdivinaLaCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
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
    }
}