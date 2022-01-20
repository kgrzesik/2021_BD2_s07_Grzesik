
namespace Flota
{
    partial class Zarzadzaj_pojazdem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.helpZarzPoj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dodajPojazd
            // 
            this.dodajPojazd.Location = new System.Drawing.Point(91, 31);
            this.dodajPojazd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajPojazd.Name = "dodajPojazd";
            this.dodajPojazd.Size = new System.Drawing.Size(181, 110);
            this.dodajPojazd.TabIndex = 0;
            this.dodajPojazd.Text = "Dodaj pojazd";
            this.dodajPojazd.UseVisualStyleBackColor = true;
            this.dodajPojazd.Click += new System.EventHandler(this.dodajPojazd_Click);
            // 
            // usunPojazd
            // 
            this.usunPojazd.Location = new System.Drawing.Point(378, 31);
            this.usunPojazd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usunPojazd.Name = "usunPojazd";
            this.usunPojazd.Size = new System.Drawing.Size(181, 110);
            this.usunPojazd.TabIndex = 1;
            this.usunPojazd.Text = "Edytuj/Usuń pojazd";
            this.usunPojazd.UseVisualStyleBackColor = true;
            this.usunPojazd.Click += new System.EventHandler(this.usunPojazd_Click);
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(126, 11);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(131, 36);
            this.powrotMenu.TabIndex = 3;
            this.powrotMenu.Text = "Powrót do menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dodajPojazd);
            this.panel1.Controls.Add(this.usunPojazd);
            this.panel1.Location = new System.Drawing.Point(70, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 172);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.helpZarzPoj);
            this.panel2.Controls.Add(this.powrotMenu);
            this.panel2.Location = new System.Drawing.Point(402, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 58);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(70, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 58);
            this.panel3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(174, 21);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // helpZarzPoj
            // 
            this.helpZarzPoj.Location = new System.Drawing.Point(16, 11);
            this.helpZarzPoj.Margin = new System.Windows.Forms.Padding(4);
            this.helpZarzPoj.Name = "helpZarzPoj";
            this.helpZarzPoj.Size = new System.Drawing.Size(103, 36);
            this.helpZarzPoj.TabIndex = 9;
            this.helpZarzPoj.Text = "Pomoc";
            this.helpZarzPoj.UseVisualStyleBackColor = true;
            this.helpZarzPoj.Click += new System.EventHandler(this.helpZarzPoj_Click);
            // 
            // Zarzadzaj_pojazdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 413);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Zarzadzaj_pojazdem";
            this.Text = "Zarządzaj_pojazdem";
            this.Load += new System.EventHandler(this.Zarządzaj_pojazdem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dodajPojazd;
        private System.Windows.Forms.Button usunPojazd;
        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Button helpZarzPoj;
    }
}