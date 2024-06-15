namespace ASK_P3___Linia_Produkcyjna
{
    partial class Form3
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
            this.Potwierdzenie_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Potwierdzenie_button
            // 
            this.Potwierdzenie_button.BackColor = System.Drawing.Color.Transparent;
            this.Potwierdzenie_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Potwierdzenie_button.Location = new System.Drawing.Point(87, 79);
            this.Potwierdzenie_button.Name = "Potwierdzenie_button";
            this.Potwierdzenie_button.Size = new System.Drawing.Size(190, 66);
            this.Potwierdzenie_button.TabIndex = 0;
            this.Potwierdzenie_button.Text = "Potwierdź obecność";
            this.Potwierdzenie_button.UseVisualStyleBackColor = false;
            this.Potwierdzenie_button.Click += new System.EventHandler(this.Potwierdzenie_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(350, 232);
            this.Controls.Add(this.Potwierdzenie_button);
            this.Name = "Form3";
            this.Text = "Śpisz?";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Potwierdzenie_button;
    }
}