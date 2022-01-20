
namespace Flota
{
    partial class WyborUzytkownika
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
            this.button1 = new System.Windows.Forms.Button();
            this.powrotZarzadzaniePojazdem = new System.Windows.Forms.Button();
            this.wybierzPojazd = new System.Windows.Forms.Button();
            this.listaUsr = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpWybUzyt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // powrotZarzadzaniePojazdem
            // 
            this.powrotZarzadzaniePojazdem.Location = new System.Drawing.Point(114, 3);
            this.powrotZarzadzaniePojazdem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powrotZarzadzaniePojazdem.Name = "powrotZarzadzaniePojazdem";
            this.powrotZarzadzaniePojazdem.Size = new System.Drawing.Size(141, 51);
            this.powrotZarzadzaniePojazdem.TabIndex = 6;
            this.powrotZarzadzaniePojazdem.Text = "Powrót";
            this.powrotZarzadzaniePojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzaniePojazdem.Click += new System.EventHandler(this.powrotZarzadzaniePojazdem_Click);
            // 
            // wybierzPojazd
            // 
            this.wybierzPojazd.Location = new System.Drawing.Point(372, 10);
            this.wybierzPojazd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wybierzPojazd.Name = "wybierzPojazd";
            this.wybierzPojazd.Size = new System.Drawing.Size(141, 71);
            this.wybierzPojazd.TabIndex = 5;
            this.wybierzPojazd.Text = "Edytuj";
            this.wybierzPojazd.UseVisualStyleBackColor = true;
            this.wybierzPojazd.Click += new System.EventHandler(this.wybierzPojazd_Click);
            // 
            // listaUsr
            // 
            this.listaUsr.FormattingEnabled = true;
            this.listaUsr.ItemHeight = 16;
            this.listaUsr.Location = new System.Drawing.Point(164, 105);
            this.listaUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaUsr.Name = "listaUsr";
            this.listaUsr.Size = new System.Drawing.Size(342, 340);
            this.listaUsr.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.helpWybUzyt);
            this.panel1.Controls.Add(this.powrotZarzadzaniePojazdem);
            this.panel1.Location = new System.Drawing.Point(423, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 58);
            this.panel1.TabIndex = 92;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(148, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 58);
            this.panel3.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(150, 21);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.wybierzPojazd);
            this.panel2.Location = new System.Drawing.Point(148, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 364);
            this.panel2.TabIndex = 93;
            // 
            // helpWybUzyt
            // 
            this.helpWybUzyt.Location = new System.Drawing.Point(4, 3);
            this.helpWybUzyt.Margin = new System.Windows.Forms.Padding(4);
            this.helpWybUzyt.Name = "helpWybUzyt";
            this.helpWybUzyt.Size = new System.Drawing.Size(103, 51);
            this.helpWybUzyt.TabIndex = 9;
            this.helpWybUzyt.Text = "Pomoc";
            this.helpWybUzyt.UseVisualStyleBackColor = true;
            this.helpWybUzyt.Click += new System.EventHandler(this.helpWybUzyt_Click);
            // 
            // WyborUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listaUsr);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WyborUzytkownika";
            this.Text = "WyborUzytkownika";
            this.Load += new System.EventHandler(this.WyborUzytkownika_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button powrotZarzadzaniePojazdem;
        private System.Windows.Forms.Button wybierzPojazd;
        private System.Windows.Forms.ListBox listaUsr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button helpWybUzyt;
    }
}