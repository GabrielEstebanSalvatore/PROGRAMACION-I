namespace PROGRAMACION_I.message
{
    partial class ErrorMessage
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
            this.ErrorMessageBtn = new System.Windows.Forms.Button();
            this.TextErrorMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ErrorMessageBtn
            // 
            this.ErrorMessageBtn.Location = new System.Drawing.Point(196, 138);
            this.ErrorMessageBtn.Name = "ErrorMessageBtn";
            this.ErrorMessageBtn.Size = new System.Drawing.Size(75, 23);
            this.ErrorMessageBtn.TabIndex = 3;
            this.ErrorMessageBtn.Text = "Aceptar";
            this.ErrorMessageBtn.UseVisualStyleBackColor = true;
            this.ErrorMessageBtn.Click += new System.EventHandler(this.ErrorMessageBtn_Click);
            // 
            // TextErrorMessage
            // 
            this.TextErrorMessage.Location = new System.Drawing.Point(96, 77);
            this.TextErrorMessage.Name = "TextErrorMessage";
            this.TextErrorMessage.Size = new System.Drawing.Size(296, 20);
            this.TextErrorMessage.TabIndex = 2;
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 196);
            this.Controls.Add(this.ErrorMessageBtn);
            this.Controls.Add(this.TextErrorMessage);
            this.Name = "ErrorMessage";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ErrorMessageBtn;
        private System.Windows.Forms.TextBox TextErrorMessage;
    }
}