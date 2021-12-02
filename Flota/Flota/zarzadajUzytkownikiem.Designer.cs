
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
            this.edytujUzytkownika = new System.Windows.Forms.Button();
            this.usunUzytkownika = new System.Windows.Forms.Button();
            this.dodajUzytkownika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(646, 53);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(119, 51);
            this.powrotMenu.TabIndex = 7;
            this.powrotMenu.Text = "Powrót do menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // edytujUzytkownika
            // 
            this.edytujUzytkownika.Location = new System.Drawing.Point(486, 178);
            this.edytujUzytkownika.Name = "edytujUzytkownika";
            this.edytujUzytkownika.Size = new System.Drawing.Size(182, 111);
            this.edytujUzytkownika.TabIndex = 6;
            this.edytujUzytkownika.Text = "Edytuj użytkownika";
            this.edytujUzytkownika.UseVisualStyleBackColor = true;
            // 
            // usunUzytkownika
            // 
            this.usunUzytkownika.Location = new System.Drawing.Point(298, 178);
            this.usunUzytkownika.Name = "usunUzytkownika";
            this.usunUzytkownika.Size = new System.Drawing.Size(182, 111);
            this.usunUzytkownika.TabIndex = 5;
            this.usunUzytkownika.Text = "Usuń użytkownika";
            this.usunUzytkownika.UseVisualStyleBackColor = true;
            // 
            // dodajUzytkownika
            // 
            this.dodajUzytkownika.Location = new System.Drawing.Point(110, 178);
            this.dodajUzytkownika.Name = "dodajUzytkownika";
            this.dodajUzytkownika.Size = new System.Drawing.Size(182, 111);
            this.dodajUzytkownika.TabIndex = 4;
            this.dodajUzytkownika.Text = "Dodaj użytkownika";
            this.dodajUzytkownika.UseVisualStyleBackColor = true;
            // 
            // zarzadajUzytkownikiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.powrotMenu);
            this.Controls.Add(this.edytujUzytkownika);
            this.Controls.Add(this.usunUzytkownika);
            this.Controls.Add(this.dodajUzytkownika);
            this.Name = "zarzadajUzytkownikiem";
            this.Text = "zarzadajUzytkownikiem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.Button edytujUzytkownika;
        private System.Windows.Forms.Button usunUzytkownika;
        private System.Windows.Forms.Button dodajUzytkownika;
    }
}