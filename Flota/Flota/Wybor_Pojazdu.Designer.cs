
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
            this.powrotZarzadzaniePojazdem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaPoj
            // 
            this.listaPoj.FormattingEnabled = true;
            this.listaPoj.Location = new System.Drawing.Point(161, 32);
            this.listaPoj.Margin = new System.Windows.Forms.Padding(2);
            this.listaPoj.Name = "listaPoj";
            this.listaPoj.Size = new System.Drawing.Size(257, 277);
            this.listaPoj.TabIndex = 0;
            this.listaPoj.SelectedIndexChanged += new System.EventHandler(this.listaPojazdow_SelectedIndexChanged);
            // 
            // wybierzPojazd
            // 
            this.wybierzPojazd.Location = new System.Drawing.Point(446, 32);
            this.wybierzPojazd.Margin = new System.Windows.Forms.Padding(2);
            this.wybierzPojazd.Name = "wybierzPojazd";
            this.wybierzPojazd.Size = new System.Drawing.Size(106, 58);
            this.wybierzPojazd.TabIndex = 1;
            this.wybierzPojazd.Text = "Edytuj";
            this.wybierzPojazd.UseVisualStyleBackColor = true;
            this.wybierzPojazd.Click += new System.EventHandler(this.wybierzPojazd_Click);
            // 
            // powrotZarzadzaniePojazdem
            // 
            this.powrotZarzadzaniePojazdem.Location = new System.Drawing.Point(446, 251);
            this.powrotZarzadzaniePojazdem.Margin = new System.Windows.Forms.Padding(2);
            this.powrotZarzadzaniePojazdem.Name = "powrotZarzadzaniePojazdem";
            this.powrotZarzadzaniePojazdem.Size = new System.Drawing.Size(106, 58);
            this.powrotZarzadzaniePojazdem.TabIndex = 2;
            this.powrotZarzadzaniePojazdem.Text = "Powrót";
            this.powrotZarzadzaniePojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzaniePojazdem.Click += new System.EventHandler(this.powrotZarzadzaniePojazdem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(107, 9);
            this.zalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 13);
            this.zalogowany.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zalogowano jako: ";
            // 
            // Wybor_Pojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.powrotZarzadzaniePojazdem);
            this.Controls.Add(this.wybierzPojazd);
            this.Controls.Add(this.listaPoj);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Wybor_Pojazdu";
            this.Text = "Wybor_Pojazdu";
            this.Load += new System.EventHandler(this.Wybor_Pojazdu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaPoj;
        private System.Windows.Forms.Button wybierzPojazd;
        private System.Windows.Forms.Button powrotZarzadzaniePojazdem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label1;
    }
}