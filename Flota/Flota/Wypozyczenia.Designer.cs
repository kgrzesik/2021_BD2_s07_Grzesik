
namespace Flota
{
    partial class Wypozyczenia
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
            this.textPojazd = new System.Windows.Forms.ComboBox();
            this.textWypozyczajacy = new System.Windows.Forms.ComboBox();
            this.dataOd = new System.Windows.Forms.DateTimePicker();
            this.dataDo = new System.Windows.Forms.DateTimePicker();
            this.textPowod = new System.Windows.Forms.TextBox();
            this.Pojazd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.potwierdz = new System.Windows.Forms.Button();
            this.listaWyp = new System.Windows.Forms.Button();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(898, 77);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(184, 92);
            this.powrotMenu.TabIndex = 0;
            this.powrotMenu.Text = "Powrót do Menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // textPojazd
            // 
            this.textPojazd.Location = new System.Drawing.Point(255, 192);
            this.textPojazd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPojazd.Name = "textPojazd";
            this.textPojazd.Size = new System.Drawing.Size(320, 28);
            this.textPojazd.TabIndex = 42;
            // 
            // textWypozyczajacy
            // 
            this.textWypozyczajacy.FormattingEnabled = true;
            this.textWypozyczajacy.Location = new System.Drawing.Point(255, 234);
            this.textWypozyczajacy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textWypozyczajacy.Name = "textWypozyczajacy";
            this.textWypozyczajacy.Size = new System.Drawing.Size(320, 28);
            this.textWypozyczajacy.TabIndex = 43;
            // 
            // dataOd
            // 
            this.dataOd.Location = new System.Drawing.Point(255, 275);
            this.dataOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataOd.Name = "dataOd";
            this.dataOd.Size = new System.Drawing.Size(320, 26);
            this.dataOd.TabIndex = 44;
            // 
            // dataDo
            // 
            this.dataDo.Location = new System.Drawing.Point(255, 315);
            this.dataDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDo.Name = "dataDo";
            this.dataDo.Size = new System.Drawing.Size(320, 26);
            this.dataDo.TabIndex = 45;
            // 
            // textPowod
            // 
            this.textPowod.Location = new System.Drawing.Point(255, 355);
            this.textPowod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPowod.Name = "textPowod";
            this.textPowod.Size = new System.Drawing.Size(320, 26);
            this.textPowod.TabIndex = 46;
            // 
            // Pojazd
            // 
            this.Pojazd.AutoSize = true;
            this.Pojazd.Location = new System.Drawing.Point(170, 197);
            this.Pojazd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pojazd.Name = "Pojazd";
            this.Pojazd.Size = new System.Drawing.Size(57, 20);
            this.Pojazd.TabIndex = 47;
            this.Pojazd.Text = "Pojazd";
            this.Pojazd.Click += new System.EventHandler(this.Pojazd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Wypożyczający";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Od kiedy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Do kiedy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Powód";
            // 
            // potwierdz
            // 
            this.potwierdz.Location = new System.Drawing.Point(312, 435);
            this.potwierdz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.potwierdz.Name = "potwierdz";
            this.potwierdz.Size = new System.Drawing.Size(184, 92);
            this.potwierdz.TabIndex = 52;
            this.potwierdz.Text = "Potwierdź";
            this.potwierdz.UseVisualStyleBackColor = true;
            this.potwierdz.Click += new System.EventHandler(this.potwierdz_Click);
            // 
            // listaWyp
            // 
            this.listaWyp.Location = new System.Drawing.Point(898, 197);
            this.listaWyp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listaWyp.Name = "listaWyp";
            this.listaWyp.Size = new System.Drawing.Size(184, 92);
            this.listaWyp.TabIndex = 53;
            this.listaWyp.Text = "Lista wypożyczeń";
            this.listaWyp.UseVisualStyleBackColor = true;
            this.listaWyp.Click += new System.EventHandler(this.listaWyp_Click);
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(160, 14);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 20);
            this.zalogowany.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Zalogowano jako: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Dodaj wypożyczenie:";
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaWyp);
            this.Controls.Add(this.potwierdz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pojazd);
            this.Controls.Add(this.textPowod);
            this.Controls.Add(this.dataDo);
            this.Controls.Add(this.dataOd);
            this.Controls.Add(this.textWypozyczajacy);
            this.Controls.Add(this.textPojazd);
            this.Controls.Add(this.powrotMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Wypozyczenia";
            this.Text = "Wypozyczenia";
            this.Load += new System.EventHandler(this.Wypozyczenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.ComboBox textPojazd;
        private System.Windows.Forms.ComboBox textWypozyczajacy;
        private System.Windows.Forms.DateTimePicker dataOd;
        private System.Windows.Forms.DateTimePicker dataDo;
        private System.Windows.Forms.TextBox textPowod;
        private System.Windows.Forms.Label Pojazd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button potwierdz;
        private System.Windows.Forms.Button listaWyp;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}