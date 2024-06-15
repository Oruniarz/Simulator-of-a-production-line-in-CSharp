namespace ASK_P3___Linia_Produkcyjna
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_text = new System.Windows.Forms.TextBox();
            this.Haslo_text = new System.Windows.Forms.TextBox();
            this.Zaloguj_button = new System.Windows.Forms.Button();
            this.Create_account_button = new System.Windows.Forms.Button();
            this.Nowe_haslo_text = new System.Windows.Forms.TextBox();
            this.Nowy_login_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(72, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaloguj się do systemu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasło:";
            // 
            // Login_text
            // 
            this.Login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login_text.Location = new System.Drawing.Point(132, 90);
            this.Login_text.Name = "Login_text";
            this.Login_text.Size = new System.Drawing.Size(148, 22);
            this.Login_text.TabIndex = 3;
            // 
            // Haslo_text
            // 
            this.Haslo_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Haslo_text.Location = new System.Drawing.Point(132, 143);
            this.Haslo_text.Name = "Haslo_text";
            this.Haslo_text.Size = new System.Drawing.Size(148, 22);
            this.Haslo_text.TabIndex = 4;
            this.Haslo_text.UseSystemPasswordChar = true;
            // 
            // Zaloguj_button
            // 
            this.Zaloguj_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zaloguj_button.Location = new System.Drawing.Point(164, 196);
            this.Zaloguj_button.Name = "Zaloguj_button";
            this.Zaloguj_button.Size = new System.Drawing.Size(87, 30);
            this.Zaloguj_button.TabIndex = 5;
            this.Zaloguj_button.Text = "Zaloguj";
            this.Zaloguj_button.UseVisualStyleBackColor = true;
            this.Zaloguj_button.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // Create_account_button
            // 
            this.Create_account_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Create_account_button.Location = new System.Drawing.Point(164, 408);
            this.Create_account_button.Name = "Create_account_button";
            this.Create_account_button.Size = new System.Drawing.Size(87, 30);
            this.Create_account_button.TabIndex = 10;
            this.Create_account_button.Text = "Załóż konto";
            this.Create_account_button.UseVisualStyleBackColor = true;
            this.Create_account_button.Click += new System.EventHandler(this.Create_account_Click);
            // 
            // Nowe_haslo_text
            // 
            this.Nowe_haslo_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nowe_haslo_text.Location = new System.Drawing.Point(132, 354);
            this.Nowe_haslo_text.Name = "Nowe_haslo_text";
            this.Nowe_haslo_text.Size = new System.Drawing.Size(148, 22);
            this.Nowe_haslo_text.TabIndex = 9;
            this.Nowe_haslo_text.UseSystemPasswordChar = true;
            // 
            // Nowy_login_text
            // 
            this.Nowy_login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nowy_login_text.Location = new System.Drawing.Point(132, 301);
            this.Nowy_login_text.Name = "Nowy_login_text";
            this.Nowy_login_text.Size = new System.Drawing.Size(148, 22);
            this.Nowy_login_text.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasło:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Login:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(32, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Jeśli nie masz konta, utwórz je";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Create_account_button);
            this.Controls.Add(this.Nowe_haslo_text);
            this.Controls.Add(this.Nowy_login_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Zaloguj_button);
            this.Controls.Add(this.Haslo_text);
            this.Controls.Add(this.Login_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login_text;
        private System.Windows.Forms.TextBox Haslo_text;
        private System.Windows.Forms.Button Zaloguj_button;
        private System.Windows.Forms.Button Create_account_button;
        private System.Windows.Forms.TextBox Nowe_haslo_text;
        private System.Windows.Forms.TextBox Nowy_login_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

