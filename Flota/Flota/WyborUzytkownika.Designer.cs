
namespace Flota
{
    partial class WyborUzytkownika
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
            this.powrotZarzadzaniePojazdem = new System.Windows.Forms.Button();
            this.wybierzPojazd = new System.Windows.Forms.Button();
            this.listaUsr = new System.Windows.Forms.ListBox();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // powrotZarzadzaniePojazdem
            // 
            this.powrotZarzadzaniePojazdem.Location = new System.Drawing.Point(408, 282);
            this.powrotZarzadzaniePojazdem.Margin = new System.Windows.Forms.Padding(2);
            this.powrotZarzadzaniePojazdem.Name = "powrotZarzadzaniePojazdem";
            this.powrotZarzadzaniePojazdem.Size = new System.Drawing.Size(106, 58);
            this.powrotZarzadzaniePojazdem.TabIndex = 6;
            this.powrotZarzadzaniePojazdem.Text = "Powrót";
            this.powrotZarzadzaniePojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzaniePojazdem.Click += new System.EventHandler(this.powrotZarzadzaniePojazdem_Click);
            // 
            // wybierzPojazd
            // 
            this.wybierzPojazd.Location = new System.Drawing.Point(408, 63);
            this.wybierzPojazd.Margin = new System.Windows.Forms.Padding(2);
            this.wybierzPojazd.Name = "wybierzPojazd";
            this.wybierzPojazd.Size = new System.Drawing.Size(106, 58);
            this.wybierzPojazd.TabIndex = 5;
            this.wybierzPojazd.Text = "Edytuj";
            this.wybierzPojazd.UseVisualStyleBackColor = true;
            this.wybierzPojazd.Click += new System.EventHandler(this.wybierzPojazd_Click);
            // 
            // listaUsr
            // 
            this.listaUsr.FormattingEnabled = true;
            this.listaUsr.Location = new System.Drawing.Point(123, 63);
            this.listaUsr.Margin = new System.Windows.Forms.Padding(2);
            this.listaUsr.Name = "listaUsr";
            this.listaUsr.Size = new System.Drawing.Size(257, 277);
            this.listaUsr.TabIndex = 4;
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(98, 9);
            this.zalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 13);
            this.zalogowany.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zalogowano jako: ";
            // 
            // WyborUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 400);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.powrotZarzadzaniePojazdem);
            this.Controls.Add(this.wybierzPojazd);
            this.Controls.Add(this.listaUsr);
            this.Name = "WyborUzytkownika";
            this.Text = "WyborUzytkownika";
            this.Load += new System.EventHandler(this.WyborUzytkownika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button powrotZarzadzaniePojazdem;
        private System.Windows.Forms.Button wybierzPojazd;
        private System.Windows.Forms.ListBox listaUsr;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label1;
    }
}