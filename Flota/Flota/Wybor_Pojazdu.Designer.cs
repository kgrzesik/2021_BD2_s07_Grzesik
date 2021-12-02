
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
            this.SuspendLayout();
            // 
            // listaPoj
            // 
            this.listaPoj.FormattingEnabled = true;
            this.listaPoj.ItemHeight = 16;
            this.listaPoj.Location = new System.Drawing.Point(215, 40);
            this.listaPoj.Name = "listaPoj";
            this.listaPoj.Size = new System.Drawing.Size(341, 340);
            this.listaPoj.TabIndex = 0;
            this.listaPoj.SelectedIndexChanged += new System.EventHandler(this.listaPojazdow_SelectedIndexChanged);
            // 
            // wybierzPojazd
            // 
            this.wybierzPojazd.Location = new System.Drawing.Point(594, 40);
            this.wybierzPojazd.Name = "wybierzPojazd";
            this.wybierzPojazd.Size = new System.Drawing.Size(141, 71);
            this.wybierzPojazd.TabIndex = 1;
            this.wybierzPojazd.Text = "Wybierz pojazd";
            this.wybierzPojazd.UseVisualStyleBackColor = true;
            // 
            // powrotZarzadzaniePojazdem
            // 
            this.powrotZarzadzaniePojazdem.Location = new System.Drawing.Point(594, 309);
            this.powrotZarzadzaniePojazdem.Name = "powrotZarzadzaniePojazdem";
            this.powrotZarzadzaniePojazdem.Size = new System.Drawing.Size(141, 71);
            this.powrotZarzadzaniePojazdem.TabIndex = 2;
            this.powrotZarzadzaniePojazdem.Text = "Powrót";
            this.powrotZarzadzaniePojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzaniePojazdem.Click += new System.EventHandler(this.powrotZarzadzaniePojazdem_Click);
            // 
            // Wybor_Pojazdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.powrotZarzadzaniePojazdem);
            this.Controls.Add(this.wybierzPojazd);
            this.Controls.Add(this.listaPoj);
            this.Name = "Wybor_Pojazdu";
            this.Text = "Wybor_Pojazdu";
            this.Load += new System.EventHandler(this.Wybor_Pojazdu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaPoj;
        private System.Windows.Forms.Button wybierzPojazd;
        private System.Windows.Forms.Button powrotZarzadzaniePojazdem;
    }
}