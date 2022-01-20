
namespace Flota
{
    partial class Wybor_Pojazdu
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
            this.listaPoj = new System.Windows.Forms.ListBox();
            this.wybierzPojazd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.powrotZarzadzaniePojazdem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.helpWybPoj = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaPoj
            // 
            this.listaPoj.FormattingEnabled = true;
            this.listaPoj.ItemHeight = 16;
            this.listaPoj.Location = new System.Drawing.Point(116, 124);
            this.listaPoj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listaPoj.Name = "listaPoj";
            this.listaPoj.Size = new System.Drawing.Size(342, 340);
            this.listaPoj.TabIndex = 0;
            this.listaPoj.SelectedIndexChanged += new System.EventHandler(this.listaPojazdow_SelectedIndexChanged);
            // 
            // wybierzPojazd
            // 
            this.wybierzPojazd.Location = new System.Drawing.Point(484, 141);
            this.wybierzPojazd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wybierzPojazd.Name = "wybierzPojazd";
            this.wybierzPojazd.Size = new System.Drawing.Size(141, 71);
            this.wybierzPojazd.TabIndex = 1;
            this.wybierzPojazd.Text = "Edytuj";
            this.wybierzPojazd.UseVisualStyleBackColor = true;
            this.wybierzPojazd.Click += new System.EventHandler(this.wybierzPojazd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // powrotZarzadzaniePojazdem
            // 
            this.powrotZarzadzaniePojazdem.Location = new System.Drawing.Point(133, 3);
            this.powrotZarzadzaniePojazdem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powrotZarzadzaniePojazdem.Name = "powrotZarzadzaniePojazdem";
            this.powrotZarzadzaniePojazdem.Size = new System.Drawing.Size(117, 51);
            this.powrotZarzadzaniePojazdem.TabIndex = 2;
            this.powrotZarzadzaniePojazdem.Text = "Powrót";
            this.powrotZarzadzaniePojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzaniePojazdem.Click += new System.EventHandler(this.powrotZarzadzaniePojazdem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(100, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 58);
            this.panel3.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(156, 19);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.helpWybPoj);
            this.panel1.Controls.Add(this.powrotZarzadzaniePojazdem);
            this.panel1.Location = new System.Drawing.Point(374, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 58);
            this.panel1.TabIndex = 90;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(100, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 372);
            this.panel2.TabIndex = 91;
            // 
            // helpWybPoj
            // 
            this.helpWybPoj.Location = new System.Drawing.Point(9, 3);
            this.helpWybPoj.Margin = new System.Windows.Forms.Padding(4);
            this.helpWybPoj.Name = "helpWybPoj";
            this.helpWybPoj.Size = new System.Drawing.Size(109, 49);
            this.helpWybPoj.TabIndex = 9;
            this.helpWybPoj.Text = "Pomoc";
            this.helpWybPoj.UseVisualStyleBackColor = true;
            this.helpWybPoj.Click += new System.EventHandler(this.helpWybPoj_Click);
            // 
            // Wybor_Pojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wybierzPojazd);
            this.Controls.Add(this.listaPoj);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Wybor_Pojazdu";
            this.Text = "Wybor_Pojazdu";
            this.Load += new System.EventHandler(this.Wybor_Pojazdu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaPoj;
        private System.Windows.Forms.Button wybierzPojazd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button powrotZarzadzaniePojazdem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button helpWybPoj;
    }
}