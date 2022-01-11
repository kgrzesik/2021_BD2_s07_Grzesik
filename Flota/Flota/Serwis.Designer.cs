
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
            this.kosztText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.historia = new System.Windows.Forms.Button();
            this.dodajserwis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(89, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textPojazd
            // 
            this.textPojazd.FormattingEnabled = true;
            this.textPojazd.Location = new System.Drawing.Point(183, 19);
            this.textPojazd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPojazd.Name = "textPojazd";
            this.textPojazd.Size = new System.Drawing.Size(265, 24);
            this.textPojazd.TabIndex = 43;
            // 
            // serwisName
            // 
            this.serwisName.Location = new System.Drawing.Point(223, 151);
            this.serwisName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serwisName.Name = "serwisName";
            this.serwisName.Size = new System.Drawing.Size(265, 22);
            this.serwisName.TabIndex = 44;
            // 
            // textUsluga
            // 
            this.textUsluga.FormattingEnabled = true;
            this.textUsluga.Location = new System.Drawing.Point(223, 210);
            this.textUsluga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUsluga.Name = "textUsluga";
            this.textUsluga.Size = new System.Drawing.Size(265, 24);
            this.textUsluga.TabIndex = 45;
            // 
            // dataOstPrzeg
            // 
            this.dataOstPrzeg.Location = new System.Drawing.Point(223, 274);
            this.dataOstPrzeg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataOstPrzeg.Name = "dataOstPrzeg";
            this.dataOstPrzeg.Size = new System.Drawing.Size(265, 22);
            this.dataOstPrzeg.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(118, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Pojazd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(70, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nazwa serwisu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(118, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Usługa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Data ostatniego przegladu";
            // 
            // kosztText
            // 
            this.kosztText.Location = new System.Drawing.Point(183, 266);
            this.kosztText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kosztText.Name = "kosztText";
            this.kosztText.Size = new System.Drawing.Size(142, 22);
            this.kosztText.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(132, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Koszt";
            // 
            // historia
            // 
            this.historia.Cursor = System.Windows.Forms.Cursors.Default;
            this.historia.Location = new System.Drawing.Point(477, 209);
            this.historia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historia.Name = "historia";
            this.historia.Size = new System.Drawing.Size(157, 32);
            this.historia.TabIndex = 57;
            this.historia.Text = "Historia";
            this.historia.UseVisualStyleBackColor = true;
            this.historia.Click += new System.EventHandler(this.historia_Click);
            // 
            // dodajserwis
            // 
            this.dodajserwis.Location = new System.Drawing.Point(477, 262);
            this.dodajserwis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajserwis.Name = "dodajserwis";
            this.dodajserwis.Size = new System.Drawing.Size(157, 32);
            this.dodajserwis.TabIndex = 58;
            this.dodajserwis.Text = "Dodaj";
            this.dodajserwis.UseVisualStyleBackColor = true;
            this.dodajserwis.Click += new System.EventHandler(this.dodajserwis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(44, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 58);
            this.panel3.TabIndex = 87;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(169, 19);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(404, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 58);
            this.panel1.TabIndex = 88;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dodajserwis);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.historia);
            this.panel2.Controls.Add(this.textPojazd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.kosztText);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(44, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 338);
            this.panel2.TabIndex = 89;
            // 
            // Serwis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataOstPrzeg);
            this.Controls.Add(this.textUsluga);
            this.Controls.Add(this.serwisName);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Serwis";
            this.Text = "Serwis";
            this.Load += new System.EventHandler(this.Serwis_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox kosztText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button historia;
        private System.Windows.Forms.Button dodajserwis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}