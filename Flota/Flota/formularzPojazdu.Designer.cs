﻿
namespace Flota
{
    partial class formularzPojazdu
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
            this.powrotZarzadzajPojazdem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.marka = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.ComboBox();
            this.typ = new System.Windows.Forms.ComboBox();
            this.przeznaczenie1 = new System.Windows.Forms.ComboBox();
            this.wyposazenie = new System.Windows.Forms.ComboBox();
            this.opiekun = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pomoc = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // powrotZarzadzajPojazdem
            // 
            this.powrotZarzadzajPojazdem.Location = new System.Drawing.Point(134, 9);
            this.powrotZarzadzajPojazdem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powrotZarzadzajPojazdem.Name = "powrotZarzadzajPojazdem";
            this.powrotZarzadzajPojazdem.Size = new System.Drawing.Size(161, 40);
            this.powrotZarzadzajPojazdem.TabIndex = 0;
            this.powrotZarzadzajPojazdem.Text = "Powrót";
            this.powrotZarzadzajPojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzajPojazdem.Click += new System.EventHandler(this.powrotZarzadzajPojazdem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(74, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer rejestracyjny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "VIN";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 116);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(74, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rok produkcji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(74, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Przebieg (km)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(74, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(74, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(72, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Typ pojazdu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(72, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Wyposażenie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(72, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Przeznaczenie:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.potwierdz);
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(211, 218);
            this.marka.Margin = new System.Windows.Forms.Padding(4);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(239, 24);
            this.marka.TabIndex = 20;
            this.marka.SelectedIndexChanged += new System.EventHandler(this.marka_SelectedIndexChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(211, 151);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 186);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 22);
            this.textBox3.TabIndex = 22;
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.Location = new System.Drawing.Point(211, 250);
            this.model.Margin = new System.Windows.Forms.Padding(4);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(239, 24);
            this.model.TabIndex = 23;
            this.model.SelectedIndexChanged += new System.EventHandler(this.model_SelectedIndexChanged);
            // 
            // typ
            // 
            this.typ.FormattingEnabled = true;
            this.typ.Location = new System.Drawing.Point(211, 284);
            this.typ.Margin = new System.Windows.Forms.Padding(4);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(239, 24);
            this.typ.TabIndex = 24;
            // 
            // przeznaczenie1
            // 
            this.przeznaczenie1.FormattingEnabled = true;
            this.przeznaczenie1.Location = new System.Drawing.Point(211, 317);
            this.przeznaczenie1.Margin = new System.Windows.Forms.Padding(4);
            this.przeznaczenie1.Name = "przeznaczenie1";
            this.przeznaczenie1.Size = new System.Drawing.Size(239, 24);
            this.przeznaczenie1.TabIndex = 25;
            // 
            // wyposazenie
            // 
            this.wyposazenie.FormattingEnabled = true;
            this.wyposazenie.Location = new System.Drawing.Point(211, 350);
            this.wyposazenie.Margin = new System.Windows.Forms.Padding(4);
            this.wyposazenie.Name = "wyposazenie";
            this.wyposazenie.Size = new System.Drawing.Size(239, 24);
            this.wyposazenie.TabIndex = 26;
            // 
            // opiekun
            // 
            this.opiekun.FormattingEnabled = true;
            this.opiekun.Location = new System.Drawing.Point(211, 383);
            this.opiekun.Margin = new System.Windows.Forms.Padding(4);
            this.opiekun.Name = "opiekun";
            this.opiekun.Size = new System.Drawing.Size(239, 24);
            this.opiekun.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(76, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Opiekun";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(61, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 58);
            this.panel3.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(166, 21);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Location = new System.Drawing.Point(61, 72);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 348);
            this.panel4.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pomoc);
            this.panel1.Controls.Add(this.powrotZarzadzajPojazdem);
            this.panel1.Location = new System.Drawing.Point(454, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 58);
            this.panel1.TabIndex = 32;
            // 
            // pomoc
            // 
            this.pomoc.Location = new System.Drawing.Point(15, 9);
            this.pomoc.Margin = new System.Windows.Forms.Padding(4);
            this.pomoc.Name = "pomoc";
            this.pomoc.Size = new System.Drawing.Size(103, 39);
            this.pomoc.TabIndex = 9;
            this.pomoc.Text = "Pomoc";
            this.pomoc.UseVisualStyleBackColor = true;
            this.pomoc.Click += new System.EventHandler(this.pomoc_Click);
            // 
            // formularzPojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 446);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.opiekun);
            this.Controls.Add(this.wyposazenie);
            this.Controls.Add(this.przeznaczenie1);
            this.Controls.Add(this.typ);
            this.Controls.Add(this.model);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formularzPojazdu";
            this.Text = "formularzPojazdu";
            this.Load += new System.EventHandler(this.formularzPojazdu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrotZarzadzajPojazdem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox model;
        private System.Windows.Forms.ComboBox typ;
        private System.Windows.Forms.ComboBox przeznaczenie1;
        private System.Windows.Forms.ComboBox wyposazenie;
        private System.Windows.Forms.ComboBox opiekun;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button pomoc;
    }
}