
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.typ_pojazdu = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wyposazenie = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.przenaczenie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // powrotZarzadzajPojazdem
            // 
            this.powrotZarzadzajPojazdem.Location = new System.Drawing.Point(591, 79);
            this.powrotZarzadzajPojazdem.Name = "powrotZarzadzajPojazdem";
            this.powrotZarzadzajPojazdem.Size = new System.Drawing.Size(157, 64);
            this.powrotZarzadzajPojazdem.TabIndex = 0;
            this.powrotZarzadzajPojazdem.Text = "Powrót";
            this.powrotZarzadzajPojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzajPojazdem.Click += new System.EventHandler(this.powrotZarzadzajPojazdem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer rejestracyjny:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "VIN";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rok produkcji";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(214, 121);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Przebieg";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 22);
            this.textBox4.TabIndex = 7;
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.ItemHeight = 16;
            this.marka.Location = new System.Drawing.Point(214, 180);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(239, 20);
            this.marka.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model";
            // 
            // model
            // 
            this.model.FormattingEnabled = true;
            this.model.ItemHeight = 16;
            this.model.Location = new System.Drawing.Point(214, 207);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(239, 20);
            this.model.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Typ pojazdu";
            // 
            // typ_pojazdu
            // 
            this.typ_pojazdu.FormattingEnabled = true;
            this.typ_pojazdu.ItemHeight = 16;
            this.typ_pojazdu.Location = new System.Drawing.Point(214, 233);
            this.typ_pojazdu.Name = "typ_pojazdu";
            this.typ_pojazdu.Size = new System.Drawing.Size(239, 20);
            this.typ_pojazdu.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Wyposażenie";
            // 
            // wyposazenie
            // 
            this.wyposazenie.FormattingEnabled = true;
            this.wyposazenie.ItemHeight = 16;
            this.wyposazenie.Location = new System.Drawing.Point(214, 285);
            this.wyposazenie.Name = "wyposazenie";
            this.wyposazenie.Size = new System.Drawing.Size(239, 20);
            this.wyposazenie.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Przenaczenie:";
            // 
            // przenaczenie
            // 
            this.przenaczenie.FormattingEnabled = true;
            this.przenaczenie.ItemHeight = 16;
            this.przenaczenie.Location = new System.Drawing.Point(214, 259);
            this.przenaczenie.Name = "przenaczenie";
            this.przenaczenie.Size = new System.Drawing.Size(239, 20);
            this.przenaczenie.TabIndex = 15;
            // 
            // formularzPojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 446);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wyposazenie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.przenaczenie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.typ_pojazdu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.powrotZarzadzajPojazdem);
            this.Name = "formularzPojazdu";
            this.Text = "formularzPojazdu";
            this.Load += new System.EventHandler(this.formularzPojazdu_Load);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListBox marka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox typ_pojazdu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox wyposazenie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox przenaczenie;
    }
}