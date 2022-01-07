
namespace Flota
{
    partial class EdycjaPojazdu
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
            this.wyposazenie = new System.Windows.Forms.ComboBox();
            this.przeznaczenie1 = new System.Windows.Forms.ComboBox();
            this.typ = new System.Windows.Forms.ComboBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.przebieg = new System.Windows.Forms.TextBox();
            this.rok = new System.Windows.Forms.ComboBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.powrotZarzadzajPojazdem = new System.Windows.Forms.Button();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nrRej = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.opiekun = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // wyposazenie
            // 
            this.wyposazenie.FormattingEnabled = true;
            this.wyposazenie.Location = new System.Drawing.Point(189, 281);
            this.wyposazenie.Name = "wyposazenie";
            this.wyposazenie.Size = new System.Drawing.Size(180, 21);
            this.wyposazenie.TabIndex = 46;
            // 
            // przeznaczenie1
            // 
            this.przeznaczenie1.FormattingEnabled = true;
            this.przeznaczenie1.Location = new System.Drawing.Point(189, 254);
            this.przeznaczenie1.Name = "przeznaczenie1";
            this.przeznaczenie1.Size = new System.Drawing.Size(180, 21);
            this.przeznaczenie1.TabIndex = 45;
            // 
            // typ
            // 
            this.typ.FormattingEnabled = true;
            this.typ.Location = new System.Drawing.Point(189, 227);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(180, 21);
            this.typ.TabIndex = 44;
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(189, 200);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(180, 21);
            this.model.TabIndex = 43;
            // 
            // przebieg
            // 
            this.przebieg.Location = new System.Drawing.Point(189, 147);
            this.przebieg.Name = "przebieg";
            this.przebieg.Size = new System.Drawing.Size(180, 20);
            this.przebieg.TabIndex = 42;
            // 
            // rok
            // 
            this.rok.FormattingEnabled = true;
            this.rok.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990"});
            this.rok.Location = new System.Drawing.Point(189, 119);
            this.rok.Name = "rok";
            this.rok.Size = new System.Drawing.Size(180, 21);
            this.rok.TabIndex = 41;
            this.rok.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(189, 173);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(180, 21);
            this.marka.TabIndex = 40;
            this.marka.SelectedIndexChanged += new System.EventHandler(this.marka_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 195);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 52);
            this.button1.TabIndex = 39;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 281);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Wyposażenie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Przeznaczenie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Typ pojazdu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Przebieg (km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Rok produkcji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "VIN";
            // 
            // vin
            // 
            this.vin.Location = new System.Drawing.Point(189, 91);
            this.vin.Margin = new System.Windows.Forms.Padding(2);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(180, 20);
            this.vin.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Numer rejestracyjny";
            // 
            // powrotZarzadzajPojazdem
            // 
            this.powrotZarzadzajPojazdem.Location = new System.Drawing.Point(472, 91);
            this.powrotZarzadzajPojazdem.Margin = new System.Windows.Forms.Padding(2);
            this.powrotZarzadzajPojazdem.Name = "powrotZarzadzajPojazdem";
            this.powrotZarzadzajPojazdem.Size = new System.Drawing.Size(118, 52);
            this.powrotZarzadzajPojazdem.TabIndex = 27;
            this.powrotZarzadzajPojazdem.Text = "Powrót";
            this.powrotZarzadzajPojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzajPojazdem.Click += new System.EventHandler(this.powrotZarzadzajPojazdem_Click_1);
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(107, 9);
            this.zalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 13);
            this.zalogowany.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Zalogowano jako: ";
            // 
            // nrRej
            // 
            this.nrRej.FormattingEnabled = true;
            this.nrRej.Location = new System.Drawing.Point(189, 61);
            this.nrRej.Name = "nrRej";
            this.nrRej.Size = new System.Drawing.Size(180, 21);
            this.nrRej.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 311);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Opiekun";
            // 
            // opiekun
            // 
            this.opiekun.FormattingEnabled = true;
            this.opiekun.Location = new System.Drawing.Point(189, 308);
            this.opiekun.Name = "opiekun";
            this.opiekun.Size = new System.Drawing.Size(180, 21);
            this.opiekun.TabIndex = 50;
            // 
            // EdycjaPojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 396);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.opiekun);
            this.Controls.Add(this.nrRej);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wyposazenie);
            this.Controls.Add(this.przeznaczenie1);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.model);
            this.Controls.Add(this.przebieg);
            this.Controls.Add(this.rok);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powrotZarzadzajPojazdem);
            this.Name = "EdycjaPojazdu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EdycjaPojazdu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox wyposazenie;
        private System.Windows.Forms.ComboBox przeznaczenie1;
        private System.Windows.Forms.ComboBox typ;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.TextBox przebieg;
        private System.Windows.Forms.ComboBox rok;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button powrotZarzadzajPojazdem;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox nrRej;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox opiekun;
    }
}