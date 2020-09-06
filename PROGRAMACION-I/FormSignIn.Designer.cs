namespace PROGRAMACION_I
{
    partial class FormSignIn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxQuiniela = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxAdivina = new System.Windows.Forms.PictureBox();
            this.pictureBoxDarVueltas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiniela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdivina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDarVueltas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(110, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(182, 105);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(135, 55);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "INGRESAR";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESO DE JUGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(77, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "JUEGOS DISPONIBLES";
            // 
            // pictureBoxQuiniela
            // 
            this.pictureBoxQuiniela.Location = new System.Drawing.Point(18, 268);
            this.pictureBoxQuiniela.Name = "pictureBoxQuiniela";
            this.pictureBoxQuiniela.Size = new System.Drawing.Size(135, 71);
            this.pictureBoxQuiniela.TabIndex = 9;
            this.pictureBoxQuiniela.TabStop = false;
            this.pictureBoxQuiniela.Click += new System.EventHandler(this.pictureBoxQuiniela_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "QUINIELA";
            // 
            // pictureBoxAdivina
            // 
            this.pictureBoxAdivina.Location = new System.Drawing.Point(182, 268);
            this.pictureBoxAdivina.Name = "pictureBoxAdivina";
            this.pictureBoxAdivina.Size = new System.Drawing.Size(135, 71);
            this.pictureBoxAdivina.TabIndex = 11;
            this.pictureBoxAdivina.TabStop = false;
            this.pictureBoxAdivina.Click += new System.EventHandler(this.pictureBoxAdivina_Click);
            // 
            // pictureBoxDarVueltas
            // 
            this.pictureBoxDarVueltas.Location = new System.Drawing.Point(348, 268);
            this.pictureBoxDarVueltas.Name = "pictureBoxDarVueltas";
            this.pictureBoxDarVueltas.Size = new System.Drawing.Size(135, 71);
            this.pictureBoxDarVueltas.TabIndex = 12;
            this.pictureBoxDarVueltas.TabStop = false;
            this.pictureBoxDarVueltas.Click += new System.EventHandler(this.pictureBoxDarVueltas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "ADIVINA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "DAR VUELTAS";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxDarVueltas);
            this.Controls.Add(this.pictureBoxAdivina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxQuiniela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "FormSignIn";
            this.Text = "INGRESO";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuiniela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdivina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDarVueltas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxQuiniela;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxAdivina;
        private System.Windows.Forms.PictureBox pictureBoxDarVueltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}