
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
            this.zalogowany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(484, 43);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(2);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(89, 41);
            this.powrotMenu.TabIndex = 7;
            this.powrotMenu.Text = "Powrót do menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // usunUzytkownika
            // 
            this.usunUzytkownika.Location = new System.Drawing.Point(304, 145);
            this.usunUzytkownika.Margin = new System.Windows.Forms.Padding(2);
            this.usunUzytkownika.Name = "usunUzytkownika";
            this.usunUzytkownika.Size = new System.Drawing.Size(136, 90);
            this.usunUzytkownika.TabIndex = 5;
            this.usunUzytkownika.Text = "Edytuj/Usuń użytkownika";
            this.usunUzytkownika.UseVisualStyleBackColor = true;
            this.usunUzytkownika.Click += new System.EventHandler(this.usunUzytkownika_Click);
            // 
            // dodajUzytkownika
            // 
            this.dodajUzytkownika.Location = new System.Drawing.Point(164, 145);
            this.dodajUzytkownika.Margin = new System.Windows.Forms.Padding(2);
            this.dodajUzytkownika.Name = "dodajUzytkownika";
            this.dodajUzytkownika.Size = new System.Drawing.Size(136, 90);
            this.dodajUzytkownika.TabIndex = 4;
            this.dodajUzytkownika.Text = "Dodaj użytkownika";
            this.dodajUzytkownika.UseVisualStyleBackColor = true;
            this.dodajUzytkownika.Click += new System.EventHandler(this.dodajUzytkownika_Click);
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(107, 9);
            this.zalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 13);
            this.zalogowany.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zalogowano jako: ";
            // 
            // zarzadajUzytkownikiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powrotMenu);
            this.Controls.Add(this.usunUzytkownika);
            this.Controls.Add(this.dodajUzytkownika);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "zarzadajUzytkownikiem";
            this.Text = "zarzadajUzytkownikiem";
            this.Load += new System.EventHandler(this.zarzadajUzytkownikiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.Button usunUzytkownika;
        private System.Windows.Forms.Button dodajUzytkownika;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label1;
    }
}