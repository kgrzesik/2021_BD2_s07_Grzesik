
namespace Flota
{
    partial class zarzadajUzytkownikiem
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
            this.powrotMenu = new System.Windows.Forms.Button();
            this.usunUzytkownika = new System.Windows.Forms.Button();
            this.dodajUzytkownika = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(63, 10);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(138, 37);
            this.powrotMenu.TabIndex = 7;
            this.powrotMenu.Text = "Powrót do menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // usunUzytkownika
            // 
            this.usunUzytkownika.Location = new System.Drawing.Point(366, 69);
            this.usunUzytkownika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usunUzytkownika.Name = "usunUzytkownika";
            this.usunUzytkownika.Size = new System.Drawing.Size(228, 110);
            this.usunUzytkownika.TabIndex = 5;
            this.usunUzytkownika.Text = "Edytuj/Usuń użytkownika";
            this.usunUzytkownika.UseVisualStyleBackColor = true;
            this.usunUzytkownika.Click += new System.EventHandler(this.usunUzytkownika_Click);
            // 
            // dodajUzytkownika
            // 
            this.dodajUzytkownika.Location = new System.Drawing.Point(74, 69);
            this.dodajUzytkownika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajUzytkownika.Name = "dodajUzytkownika";
            this.dodajUzytkownika.Size = new System.Drawing.Size(228, 110);
            this.dodajUzytkownika.TabIndex = 4;
            this.dodajUzytkownika.Text = "Dodaj użytkownika";
            this.dodajUzytkownika.UseVisualStyleBackColor = true;
            this.dodajUzytkownika.Click += new System.EventHandler(this.dodajUzytkownika_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.powrotMenu);
            this.panel2.Location = new System.Drawing.Point(460, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 58);
            this.panel2.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(68, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 58);
            this.panel3.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(164, 21);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dodajUzytkownika);
            this.panel1.Controls.Add(this.usunUzytkownika);
            this.panel1.Location = new System.Drawing.Point(68, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 261);
            this.panel1.TabIndex = 59;
            // 
            // zarzadajUzytkownikiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "zarzadajUzytkownikiem";
            this.Text = "zarzadajUzytkownikiem";
            this.Load += new System.EventHandler(this.zarzadajUzytkownikiem_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.Button usunUzytkownika;
        private System.Windows.Forms.Button dodajUzytkownika;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel1;
    }
}