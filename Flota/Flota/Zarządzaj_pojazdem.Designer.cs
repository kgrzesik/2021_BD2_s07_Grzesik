
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
            this.edytujPojazd = new System.Windows.Forms.Button();
            this.powrotMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajPojazd
            // 
            this.dodajPojazd.Location = new System.Drawing.Point(104, 166);
            this.dodajPojazd.Name = "dodajPojazd";
            this.dodajPojazd.Size = new System.Drawing.Size(182, 111);
            this.dodajPojazd.TabIndex = 0;
            this.dodajPojazd.Text = "Dodaj pojazd";
            this.dodajPojazd.UseVisualStyleBackColor = true;
            this.dodajPojazd.Click += new System.EventHandler(this.dodajPojazd_Click);
            // 
            // usunPojazd
            // 
            this.usunPojazd.Location = new System.Drawing.Point(292, 166);
            this.usunPojazd.Name = "usunPojazd";
            this.usunPojazd.Size = new System.Drawing.Size(182, 111);
            this.usunPojazd.TabIndex = 1;
            this.usunPojazd.Text = "Usuń pojazd";
            this.usunPojazd.UseVisualStyleBackColor = true;
            this.usunPojazd.Click += new System.EventHandler(this.usunPojazd_Click);
            // 
            // edytujPojazd
            // 
            this.edytujPojazd.Location = new System.Drawing.Point(480, 166);
            this.edytujPojazd.Name = "edytujPojazd";
            this.edytujPojazd.Size = new System.Drawing.Size(182, 111);
            this.edytujPojazd.TabIndex = 2;
            this.edytujPojazd.Text = "Edytuj pojazd";
            this.edytujPojazd.UseVisualStyleBackColor = true;
            this.edytujPojazd.Click += new System.EventHandler(this.edytujPojazd_Click);
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(640, 41);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(119, 51);
            this.powrotMenu.TabIndex = 3;
            this.powrotMenu.Text = "Powrót do menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // Zarządzaj_pojazdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.powrotMenu);
            this.Controls.Add(this.edytujPojazd);
            this.Controls.Add(this.usunPojazd);
            this.Controls.Add(this.dodajPojazd);
            this.Name = "Zarządzaj_pojazdem";
            this.Text = "Zarządzaj_pojazdem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajPojazd;
        private System.Windows.Forms.Button usunPojazd;
        private System.Windows.Forms.Button edytujPojazd;
        private System.Windows.Forms.Button powrotMenu;
    }
}