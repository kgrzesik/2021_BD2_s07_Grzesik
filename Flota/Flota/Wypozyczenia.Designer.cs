
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(399, 14);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(164, 48);
            this.powrotMenu.TabIndex = 0;
            this.powrotMenu.Text = "Powrót do Menu";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // textPojazd
            // 
            this.textPojazd.Location = new System.Drawing.Point(227, 154);
            this.textPojazd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPojazd.Name = "textPojazd";
            this.textPojazd.Size = new System.Drawing.Size(285, 24);
            this.textPojazd.TabIndex = 42;
            // 
            // textWypozyczajacy
            // 
            this.textWypozyczajacy.FormattingEnabled = true;
            this.textWypozyczajacy.Location = new System.Drawing.Point(227, 187);
            this.textWypozyczajacy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textWypozyczajacy.Name = "textWypozyczajacy";
            this.textWypozyczajacy.Size = new System.Drawing.Size(285, 24);
            this.textWypozyczajacy.TabIndex = 43;
            // 
            // dataOd
            // 
            this.dataOd.Location = new System.Drawing.Point(227, 220);
            this.dataOd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataOd.Name = "dataOd";
            this.dataOd.Size = new System.Drawing.Size(285, 22);
            this.dataOd.TabIndex = 44;
            // 
            // dataDo
            // 
            this.dataDo.Location = new System.Drawing.Point(227, 252);
            this.dataDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataDo.Name = "dataDo";
            this.dataDo.Size = new System.Drawing.Size(285, 22);
            this.dataDo.TabIndex = 45;
            // 
            // textPowod
            // 
            this.textPowod.Location = new System.Drawing.Point(227, 284);
            this.textPowod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPowod.Name = "textPowod";
            this.textPowod.Size = new System.Drawing.Size(285, 22);
            this.textPowod.TabIndex = 46;
            // 
            // Pojazd
            // 
            this.Pojazd.AutoSize = true;
            this.Pojazd.BackColor = System.Drawing.SystemColors.Control;
            this.Pojazd.Location = new System.Drawing.Point(151, 158);
            this.Pojazd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pojazd.Name = "Pojazd";
            this.Pojazd.Size = new System.Drawing.Size(51, 17);
            this.Pojazd.TabIndex = 47;
            this.Pojazd.Text = "Pojazd";
            this.Pojazd.Click += new System.EventHandler(this.Pojazd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(94, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Wypożyczający";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(137, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Od kiedy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(137, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Do kiedy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(137, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Powód";
            // 
            // potwierdz
            // 
            this.potwierdz.Location = new System.Drawing.Point(84, 250);
            this.potwierdz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.potwierdz.Name = "potwierdz";
            this.potwierdz.Size = new System.Drawing.Size(164, 74);
            this.potwierdz.TabIndex = 52;
            this.potwierdz.Text = "Potwierdź";
            this.potwierdz.UseVisualStyleBackColor = true;
            this.potwierdz.Click += new System.EventHandler(this.potwierdz_Click);
            // 
            // listaWyp
            // 
            this.listaWyp.Location = new System.Drawing.Point(299, 250);
            this.listaWyp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaWyp.Name = "listaWyp";
            this.listaWyp.Size = new System.Drawing.Size(164, 74);
            this.listaWyp.TabIndex = 53;
            this.listaWyp.Text = "Lista wypożyczeń";
            this.listaWyp.UseVisualStyleBackColor = true;
            this.listaWyp.Click += new System.EventHandler(this.listaWyp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Dodaj wypożyczenie:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(354, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 58);
            this.panel1.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(79, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 58);
            this.panel3.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(153, 21);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.potwierdz);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.listaWyp);
            this.panel2.Location = new System.Drawing.Point(79, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 358);
            this.panel2.TabIndex = 95;
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 505);
            this.Controls.Add(this.panel3);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Wypozyczenia";
            this.Text = "Wypozyczenia";
            this.Load += new System.EventHandler(this.Wypozyczenia_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel2;
    }
}