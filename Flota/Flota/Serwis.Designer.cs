
namespace Flota
{
    partial class Serwis
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
            this.textPojazd = new System.Windows.Forms.ComboBox();
            this.serwisName = new System.Windows.Forms.TextBox();
            this.textUsluga = new System.Windows.Forms.ComboBox();
            this.dataOstPrzeg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.kosztText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.historia = new System.Windows.Forms.Button();
            this.dodajserwis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(616, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 80);
            this.button1.TabIndex = 42;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPojazd
            // 
            this.textPojazd.FormattingEnabled = true;
            this.textPojazd.Location = new System.Drawing.Point(250, 80);
            this.textPojazd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPojazd.Name = "textPojazd";
            this.textPojazd.Size = new System.Drawing.Size(298, 28);
            this.textPojazd.TabIndex = 43;
            // 
            // serwisName
            // 
            this.serwisName.Location = new System.Drawing.Point(250, 152);
            this.serwisName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serwisName.Name = "serwisName";
            this.serwisName.Size = new System.Drawing.Size(298, 26);
            this.serwisName.TabIndex = 44;
            // 
            // textUsluga
            // 
            this.textUsluga.FormattingEnabled = true;
            this.textUsluga.Location = new System.Drawing.Point(250, 225);
            this.textUsluga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUsluga.Name = "textUsluga";
            this.textUsluga.Size = new System.Drawing.Size(298, 28);
            this.textUsluga.TabIndex = 45;
            // 
            // dataOstPrzeg
            // 
            this.dataOstPrzeg.Location = new System.Drawing.Point(250, 305);
            this.dataOstPrzeg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataOstPrzeg.Name = "dataOstPrzeg";
            this.dataOstPrzeg.Size = new System.Drawing.Size(298, 26);
            this.dataOstPrzeg.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Pojazd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nazwa serwisu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Usługa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Data ostatniego przegladu";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(250, 372);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 147);
            this.listView1.TabIndex = 51;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Informacje o pojeździe";
            // 
            // kosztText
            // 
            this.kosztText.Location = new System.Drawing.Point(674, 226);
            this.kosztText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kosztText.Name = "kosztText";
            this.kosztText.Size = new System.Drawing.Size(118, 26);
            this.kosztText.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Koszt";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(160, 14);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 20);
            this.zalogowany.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Zalogowano jako: ";
            // 
            // historia
            // 
            this.historia.Cursor = System.Windows.Forms.Cursors.Default;
            this.historia.Location = new System.Drawing.Point(616, 122);
            this.historia.Name = "historia";
            this.historia.Size = new System.Drawing.Size(177, 80);
            this.historia.TabIndex = 57;
            this.historia.Text = "Historia";
            this.historia.UseVisualStyleBackColor = true;
            this.historia.Click += new System.EventHandler(this.historia_Click);
            // 
            // dodajserwis
            // 
            this.dodajserwis.Location = new System.Drawing.Point(608, 394);
            this.dodajserwis.Name = "dodajserwis";
            this.dodajserwis.Size = new System.Drawing.Size(184, 72);
            this.dodajserwis.TabIndex = 58;
            this.dodajserwis.Text = "Dodaj";
            this.dodajserwis.UseVisualStyleBackColor = true;
            this.dodajserwis.Click += new System.EventHandler(this.dodajserwis_Click);
            // 
            // Serwis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.dodajserwis);
            this.Controls.Add(this.historia);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kosztText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataOstPrzeg);
            this.Controls.Add(this.textUsluga);
            this.Controls.Add(this.serwisName);
            this.Controls.Add(this.textPojazd);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Serwis";
            this.Text = "Serwis";
            this.Load += new System.EventHandler(this.Serwis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox textPojazd;
        private System.Windows.Forms.TextBox serwisName;
        private System.Windows.Forms.ComboBox textUsluga;
        private System.Windows.Forms.DateTimePicker dataOstPrzeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kosztText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button historia;
        private System.Windows.Forms.Button dodajserwis;
    }
}