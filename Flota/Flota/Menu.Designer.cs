
namespace Flota
{
    partial class Menu
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
            this.zarzadzajPojazdem = new System.Windows.Forms.Button();
            this.czynnosciSerwisowe = new System.Windows.Forms.Button();
            this.zarzadzajBazaDanych = new System.Windows.Forms.Button();
            this.wypozyczenia = new System.Windows.Forms.Button();
            this.czynnosciEksploatacyjne = new System.Windows.Forms.Button();
            this.zarzadzajUzytkownikiem = new System.Windows.Forms.Button();
            this.wyloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zarzadzajPojazdem
            // 
            this.zarzadzajPojazdem.Location = new System.Drawing.Point(98, 138);
            this.zarzadzajPojazdem.Name = "zarzadzajPojazdem";
            this.zarzadzajPojazdem.Size = new System.Drawing.Size(164, 52);
            this.zarzadzajPojazdem.TabIndex = 0;
            this.zarzadzajPojazdem.Text = "Zarządaj pojazdem";
            this.zarzadzajPojazdem.UseVisualStyleBackColor = true;
            this.zarzadzajPojazdem.Click += new System.EventHandler(this.zarzadzajPojazdem_Click);
            // 
            // czynnosciSerwisowe
            // 
            this.czynnosciSerwisowe.Location = new System.Drawing.Point(98, 234);
            this.czynnosciSerwisowe.Name = "czynnosciSerwisowe";
            this.czynnosciSerwisowe.Size = new System.Drawing.Size(164, 52);
            this.czynnosciSerwisowe.TabIndex = 3;
            this.czynnosciSerwisowe.Text = "Czynności serwisowe";
            this.czynnosciSerwisowe.UseVisualStyleBackColor = true;
            // 
            // zarzadzajBazaDanych
            // 
            this.zarzadzajBazaDanych.Location = new System.Drawing.Point(305, 138);
            this.zarzadzajBazaDanych.Name = "zarzadzajBazaDanych";
            this.zarzadzajBazaDanych.Size = new System.Drawing.Size(164, 52);
            this.zarzadzajBazaDanych.TabIndex = 4;
            this.zarzadzajBazaDanych.Text = "Zarządzaj bazą danych";
            this.zarzadzajBazaDanych.UseVisualStyleBackColor = true;
            this.zarzadzajBazaDanych.Click += new System.EventHandler(this.zarzadzajBazaDanych_Click);
            // 
            // wypozyczenia
            // 
            this.wypozyczenia.Location = new System.Drawing.Point(305, 234);
            this.wypozyczenia.Name = "wypozyczenia";
            this.wypozyczenia.Size = new System.Drawing.Size(164, 52);
            this.wypozyczenia.TabIndex = 5;
            this.wypozyczenia.Text = "Wypożyczenie";
            this.wypozyczenia.UseVisualStyleBackColor = true;
            // 
            // czynnosciEksploatacyjne
            // 
            this.czynnosciEksploatacyjne.Location = new System.Drawing.Point(503, 234);
            this.czynnosciEksploatacyjne.Name = "czynnosciEksploatacyjne";
            this.czynnosciEksploatacyjne.Size = new System.Drawing.Size(164, 52);
            this.czynnosciEksploatacyjne.TabIndex = 1;
            this.czynnosciEksploatacyjne.Text = "Czynności eksploatacyjne";
            this.czynnosciEksploatacyjne.UseVisualStyleBackColor = true;
            this.czynnosciEksploatacyjne.Click += new System.EventHandler(this.button2_Click);
            // 
            // zarzadzajUzytkownikiem
            // 
            this.zarzadzajUzytkownikiem.Location = new System.Drawing.Point(503, 138);
            this.zarzadzajUzytkownikiem.Name = "zarzadzajUzytkownikiem";
            this.zarzadzajUzytkownikiem.Size = new System.Drawing.Size(164, 52);
            this.zarzadzajUzytkownikiem.TabIndex = 2;
            this.zarzadzajUzytkownikiem.Text = "Zarządzaj użytkownikem";
            this.zarzadzajUzytkownikiem.UseVisualStyleBackColor = true;
            this.zarzadzajUzytkownikiem.Click += new System.EventHandler(this.button3_Click);
            // 
            // wyloguj
            // 
            this.wyloguj.Location = new System.Drawing.Point(677, 34);
            this.wyloguj.Name = "wyloguj";
            this.wyloguj.Size = new System.Drawing.Size(96, 39);
            this.wyloguj.TabIndex = 6;
            this.wyloguj.Text = "Wyloguj";
            this.wyloguj.UseVisualStyleBackColor = true;
            this.wyloguj.Click += new System.EventHandler(this.wyloguj_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wyloguj);
            this.Controls.Add(this.wypozyczenia);
            this.Controls.Add(this.zarzadzajBazaDanych);
            this.Controls.Add(this.czynnosciSerwisowe);
            this.Controls.Add(this.zarzadzajUzytkownikiem);
            this.Controls.Add(this.czynnosciEksploatacyjne);
            this.Controls.Add(this.zarzadzajPojazdem);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zarzadzajPojazdem;
        private System.Windows.Forms.Button czynnosciSerwisowe;
        private System.Windows.Forms.Button zarzadzajBazaDanych;
        private System.Windows.Forms.Button wypozyczenia;
        private System.Windows.Forms.Button czynnosciEksploatacyjne;
        private System.Windows.Forms.Button zarzadzajUzytkownikiem;
        private System.Windows.Forms.Button wyloguj;
    }
}