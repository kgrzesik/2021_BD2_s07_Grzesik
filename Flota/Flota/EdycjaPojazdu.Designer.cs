
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
            this.nrRej = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.opiekun = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wyposazenie
            // 
            this.wyposazenie.FormattingEnabled = true;
            this.wyposazenie.Location = new System.Drawing.Point(237, 385);
            this.wyposazenie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wyposazenie.Name = "wyposazenie";
            this.wyposazenie.Size = new System.Drawing.Size(239, 24);
            this.wyposazenie.TabIndex = 46;
            // 
            // przeznaczenie1
            // 
            this.przeznaczenie1.FormattingEnabled = true;
            this.przeznaczenie1.Location = new System.Drawing.Point(237, 352);
            this.przeznaczenie1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.przeznaczenie1.Name = "przeznaczenie1";
            this.przeznaczenie1.Size = new System.Drawing.Size(239, 24);
            this.przeznaczenie1.TabIndex = 45;
            // 
            // typ
            // 
            this.typ.FormattingEnabled = true;
            this.typ.Location = new System.Drawing.Point(237, 318);
            this.typ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(239, 24);
            this.typ.TabIndex = 44;
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(237, 286);
            this.model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(239, 24);
            this.model.TabIndex = 43;
            // 
            // przebieg
            // 
            this.przebieg.Location = new System.Drawing.Point(237, 220);
            this.przebieg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.przebieg.Name = "przebieg";
            this.przebieg.Size = new System.Drawing.Size(239, 22);
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
            this.rok.Location = new System.Drawing.Point(237, 186);
            this.rok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rok.Name = "rok";
            this.rok.Size = new System.Drawing.Size(239, 24);
            this.rok.TabIndex = 41;
            this.rok.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(237, 252);
            this.marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(239, 24);
            this.marka.TabIndex = 40;
            this.marka.SelectedIndexChanged += new System.EventHandler(this.marka_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 39;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(99, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Wyposażenie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(99, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Przeznaczenie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(99, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Typ pojazdu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(100, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(100, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(100, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Przebieg (km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(100, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Rok produkcji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(99, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "VIN";
            // 
            // vin
            // 
            this.vin.Location = new System.Drawing.Point(237, 151);
            this.vin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(239, 22);
            this.vin.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Numer rejestracyjny";
            // 
            // powrotZarzadzajPojazdem
            // 
            this.powrotZarzadzajPojazdem.Location = new System.Drawing.Point(53, 9);
            this.powrotZarzadzajPojazdem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powrotZarzadzajPojazdem.Name = "powrotZarzadzajPojazdem";
            this.powrotZarzadzajPojazdem.Size = new System.Drawing.Size(157, 40);
            this.powrotZarzadzajPojazdem.TabIndex = 27;
            this.powrotZarzadzajPojazdem.Text = "Powrót";
            this.powrotZarzadzajPojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzajPojazdem.Click += new System.EventHandler(this.powrotZarzadzajPojazdem_Click_1);
            // 
            // nrRej
            // 
            this.nrRej.FormattingEnabled = true;
            this.nrRej.Location = new System.Drawing.Point(237, 114);
            this.nrRej.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nrRej.Name = "nrRej";
            this.nrRej.Size = new System.Drawing.Size(239, 24);
            this.nrRej.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(100, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 51;
            this.label11.Text = "Opiekun";
            // 
            // opiekun
            // 
            this.opiekun.FormattingEnabled = true;
            this.opiekun.Location = new System.Drawing.Point(237, 418);
            this.opiekun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opiekun.Name = "opiekun";
            this.opiekun.Size = new System.Drawing.Size(239, 24);
            this.opiekun.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(80, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 377);
            this.panel1.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(80, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 58);
            this.panel3.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Zalogowano jako: ";
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
            this.panel2.Controls.Add(this.powrotZarzadzajPojazdem);
            this.panel2.Location = new System.Drawing.Point(473, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 58);
            this.panel2.TabIndex = 54;
            // 
            // EdycjaPojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(858, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.opiekun);
            this.Controls.Add(this.nrRej);
            this.Controls.Add(this.wyposazenie);
            this.Controls.Add(this.przeznaczenie1);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.model);
            this.Controls.Add(this.przebieg);
            this.Controls.Add(this.rok);
            this.Controls.Add(this.marka);
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
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EdycjaPojazdu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EdycjaPojazdu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox nrRej;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox opiekun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel2;
    }
}