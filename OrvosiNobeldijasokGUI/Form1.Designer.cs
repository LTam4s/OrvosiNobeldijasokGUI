namespace OrvosiNobeldijasokGUI
{
    partial class Form1
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
            this.Ev_label = new System.Windows.Forms.Label();
            this.Nev_label = new System.Windows.Forms.Label();
            this.SzH_label = new System.Windows.Forms.Label();
            this.Orszag_label = new System.Windows.Forms.Label();
            this.Ev_textBox = new System.Windows.Forms.TextBox();
            this.Nev_textBox = new System.Windows.Forms.TextBox();
            this.SzH_textBox = new System.Windows.Forms.TextBox();
            this.Orszag_textBox = new System.Windows.Forms.TextBox();
            this.AM_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ev_label
            // 
            this.Ev_label.AutoSize = true;
            this.Ev_label.Location = new System.Drawing.Point(25, 36);
            this.Ev_label.Name = "Ev_label";
            this.Ev_label.Size = new System.Drawing.Size(23, 13);
            this.Ev_label.TabIndex = 0;
            this.Ev_label.Text = "Év:";
            // 
            // Nev_label
            // 
            this.Nev_label.AutoSize = true;
            this.Nev_label.Location = new System.Drawing.Point(25, 68);
            this.Nev_label.Name = "Nev_label";
            this.Nev_label.Size = new System.Drawing.Size(30, 13);
            this.Nev_label.TabIndex = 1;
            this.Nev_label.Text = "Név:";
            // 
            // SzH_label
            // 
            this.SzH_label.AutoSize = true;
            this.SzH_label.Location = new System.Drawing.Point(25, 103);
            this.SzH_label.Name = "SzH_label";
            this.SzH_label.Size = new System.Drawing.Size(35, 13);
            this.SzH_label.TabIndex = 2;
            this.SzH_label.Text = "Sz/H:";
            // 
            // Orszag_label
            // 
            this.Orszag_label.AutoSize = true;
            this.Orszag_label.Location = new System.Drawing.Point(25, 138);
            this.Orszag_label.Name = "Orszag_label";
            this.Orszag_label.Size = new System.Drawing.Size(43, 13);
            this.Orszag_label.TabIndex = 3;
            this.Orszag_label.Text = "Orszag:";
            // 
            // Ev_textBox
            // 
            this.Ev_textBox.Location = new System.Drawing.Point(73, 33);
            this.Ev_textBox.Name = "Ev_textBox";
            this.Ev_textBox.Size = new System.Drawing.Size(66, 20);
            this.Ev_textBox.TabIndex = 4;
            // 
            // Nev_textBox
            // 
            this.Nev_textBox.Location = new System.Drawing.Point(73, 65);
            this.Nev_textBox.Name = "Nev_textBox";
            this.Nev_textBox.Size = new System.Drawing.Size(261, 20);
            this.Nev_textBox.TabIndex = 5;
            // 
            // SzH_textBox
            // 
            this.SzH_textBox.Location = new System.Drawing.Point(73, 103);
            this.SzH_textBox.Name = "SzH_textBox";
            this.SzH_textBox.Size = new System.Drawing.Size(153, 20);
            this.SzH_textBox.TabIndex = 6;
            // 
            // Orszag_textBox
            // 
            this.Orszag_textBox.Location = new System.Drawing.Point(73, 138);
            this.Orszag_textBox.Name = "Orszag_textBox";
            this.Orszag_textBox.Size = new System.Drawing.Size(76, 20);
            this.Orszag_textBox.TabIndex = 7;
            // 
            // AM_button
            // 
            this.AM_button.Location = new System.Drawing.Point(123, 186);
            this.AM_button.Name = "AM_button";
            this.AM_button.Size = new System.Drawing.Size(103, 23);
            this.AM_button.TabIndex = 8;
            this.AM_button.Text = "Adatok mentése";
            this.AM_button.UseVisualStyleBackColor = true;
            this.AM_button.Click += new System.EventHandler(this.AM_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 228);
            this.Controls.Add(this.AM_button);
            this.Controls.Add(this.Orszag_textBox);
            this.Controls.Add(this.SzH_textBox);
            this.Controls.Add(this.Nev_textBox);
            this.Controls.Add(this.Ev_textBox);
            this.Controls.Add(this.Orszag_label);
            this.Controls.Add(this.SzH_label);
            this.Controls.Add(this.Nev_label);
            this.Controls.Add(this.Ev_label);
            this.Name = "Form1";
            this.Text = "Orvosi Nobel-díjasok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ev_label;
        private System.Windows.Forms.Label Nev_label;
        private System.Windows.Forms.Label SzH_label;
        private System.Windows.Forms.Label Orszag_label;
        private System.Windows.Forms.TextBox Ev_textBox;
        private System.Windows.Forms.TextBox Nev_textBox;
        private System.Windows.Forms.TextBox SzH_textBox;
        private System.Windows.Forms.TextBox Orszag_textBox;
        private System.Windows.Forms.Button AM_button;
    }
}

