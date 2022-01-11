
namespace Flota
{
    partial class Zarządzaj_pojazdem
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
            this.dodajPojazd = new System.Windows.Forms.Button();
            this.usunPojazd = new System.Windows.Forms.Button();
            this.powrotMenu = new System.Windows.Forms.Button();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodajPojazd
            // 
            this.dodajPojazd.Location = new System.Drawing.Point(164, 135);
            this.dodajPojazd.Margin = new System.Windows.Forms.Padding(2);
            this.dodajPojazd.Name = "dodajPojazd";
            this.dodajPojazd.Size = new System.Drawing.Size(136, 90);
            this.dodajPojazd.TabIndex = 0;
            this.dodajPojazd.Text = "Dodaj pojazd";
            this.dodajPojazd.UseVisualStyleBackColor = true;
            this.dodajPojazd.Click += new System.EventHandler(this.dodajPojazd_Click);
            // 
            // usunPojazd
            // 
            this.usunPojazd.Location = new System.Drawing.Point(304, 135);
            this.usunPojazd.Margin = new System.Windows.Forms.Padding(2);
            this.usunPojazd.Name = "usunPojazd";
            this.usunPojazd.Size = new System.Drawing.Size(136, 90);
            this.usunPojazd.TabIndex = 1;
            this.usunPojazd.Text = "Edytuj/Usuń pojazd";
            this.usunPojazd.UseVisualStyleBackColor = true;
            this.usunPojazd.Click += new System.EventHandler(this.usunPojazd_Click);
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(480, 33);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(2);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(89, 41);
            this.powrotMenu.TabIndex = 3;
            this.powrotMenu.Text = "Powrót do menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
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
            // Zarządzaj_pojazdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powrotMenu);
            this.Controls.Add(this.usunPojazd);
            this.Controls.Add(this.dodajPojazd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Zarządzaj_pojazdem";
            this.Text = "Zarządzaj_pojazdem";
            this.Load += new System.EventHandler(this.Zarządzaj_pojazdem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajPojazd;
        private System.Windows.Forms.Button usunPojazd;
        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label1;
    }
}