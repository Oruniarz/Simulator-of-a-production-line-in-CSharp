namespace ASK_P3___Linia_Produkcyjna
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prod_line_button = new System.Windows.Forms.Button();
            this.Add_fan_button = new System.Windows.Forms.Button();
            this.Speed_fan_button = new System.Windows.Forms.Button();
            this.Usage_value_display = new System.Windows.Forms.Label();
            this.Temp_value_display = new System.Windows.Forms.Label();
            this.Speed_value_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procent wykorzystania procesora (Dozwolone: 30 - 90):\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura rdzenia procesora (Dozwolona: 40 - 100):\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(536, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prędkość obrotowa wentylatorów (Dozwolona 300 - 900):";
            // 
            // Prod_line_button
            // 
            this.Prod_line_button.BackColor = System.Drawing.Color.Fuchsia;
            this.Prod_line_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Prod_line_button.Location = new System.Drawing.Point(16, 326);
            this.Prod_line_button.Name = "Prod_line_button";
            this.Prod_line_button.Size = new System.Drawing.Size(187, 44);
            this.Prod_line_button.TabIndex = 3;
            this.Prod_line_button.Text = "Spowolnij linię produkcyjną";
            this.Prod_line_button.UseVisualStyleBackColor = false;
            this.Prod_line_button.Click += new System.EventHandler(this.Prod_line_Click);
            // 
            // Add_fan_button
            // 
            this.Add_fan_button.BackColor = System.Drawing.Color.Fuchsia;
            this.Add_fan_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_fan_button.Location = new System.Drawing.Point(222, 326);
            this.Add_fan_button.Name = "Add_fan_button";
            this.Add_fan_button.Size = new System.Drawing.Size(187, 44);
            this.Add_fan_button.TabIndex = 4;
            this.Add_fan_button.Text = "Włącz dodatkowy wentylator";
            this.Add_fan_button.UseVisualStyleBackColor = false;
            this.Add_fan_button.Click += new System.EventHandler(this.Add_fan_Click);
            // 
            // Speed_fan_button
            // 
            this.Speed_fan_button.BackColor = System.Drawing.Color.Fuchsia;
            this.Speed_fan_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Speed_fan_button.Location = new System.Drawing.Point(434, 326);
            this.Speed_fan_button.Name = "Speed_fan_button";
            this.Speed_fan_button.Size = new System.Drawing.Size(187, 44);
            this.Speed_fan_button.TabIndex = 5;
            this.Speed_fan_button.Text = "Zwiększ/zmniejsz prędkość wentylatorów";
            this.Speed_fan_button.UseVisualStyleBackColor = false;
            this.Speed_fan_button.Click += new System.EventHandler(this.Speed_fan_Click);
            // 
            // Usage_value_display
            // 
            this.Usage_value_display.AutoSize = true;
            this.Usage_value_display.BackColor = System.Drawing.Color.Transparent;
            this.Usage_value_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Usage_value_display.ForeColor = System.Drawing.Color.Lime;
            this.Usage_value_display.Location = new System.Drawing.Point(591, 55);
            this.Usage_value_display.Name = "Usage_value_display";
            this.Usage_value_display.Size = new System.Drawing.Size(46, 31);
            this.Usage_value_display.TabIndex = 6;
            this.Usage_value_display.Text = "45";
            // 
            // Temp_value_display
            // 
            this.Temp_value_display.AutoSize = true;
            this.Temp_value_display.BackColor = System.Drawing.Color.Transparent;
            this.Temp_value_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Temp_value_display.ForeColor = System.Drawing.Color.Lime;
            this.Temp_value_display.Location = new System.Drawing.Point(591, 113);
            this.Temp_value_display.Name = "Temp_value_display";
            this.Temp_value_display.Size = new System.Drawing.Size(46, 31);
            this.Temp_value_display.TabIndex = 7;
            this.Temp_value_display.Text = "60";
            this.Temp_value_display.Click += new System.EventHandler(this.label5_Click);
            // 
            // Speed_value_display
            // 
            this.Speed_value_display.AutoSize = true;
            this.Speed_value_display.BackColor = System.Drawing.Color.Transparent;
            this.Speed_value_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Speed_value_display.ForeColor = System.Drawing.Color.Lime;
            this.Speed_value_display.Location = new System.Drawing.Point(591, 168);
            this.Speed_value_display.Name = "Speed_value_display";
            this.Speed_value_display.Size = new System.Drawing.Size(62, 31);
            this.Speed_value_display.TabIndex = 8;
            this.Speed_value_display.Text = "600";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ASK_P3___Linia_Produkcyjna.Properties.Resources.nowa_maszyna__1_of_8_;
            this.ClientSize = new System.Drawing.Size(680, 431);
            this.Controls.Add(this.Speed_value_display);
            this.Controls.Add(this.Temp_value_display);
            this.Controls.Add(this.Usage_value_display);
            this.Controls.Add(this.Speed_fan_button);
            this.Controls.Add(this.Add_fan_button);
            this.Controls.Add(this.Prod_line_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Panel kontrolny";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Prod_line_button;
        private System.Windows.Forms.Button Add_fan_button;
        private System.Windows.Forms.Button Speed_fan_button;
        private System.Windows.Forms.Label Usage_value_display;
        private System.Windows.Forms.Label Temp_value_display;
        private System.Windows.Forms.Label Speed_value_display;
    }
}