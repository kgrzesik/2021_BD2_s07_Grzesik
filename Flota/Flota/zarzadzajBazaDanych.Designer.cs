
namespace Flota
{
    partial class zarzadzajBazaDanych
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
            this.kopiaBazy = new System.Windows.Forms.Button();
            this.powrotMenu = new System.Windows.Forms.Button();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kopiaBazy
            // 
            this.kopiaBazy.Location = new System.Drawing.Point(146, 140);
            this.kopiaBazy.Margin = new System.Windows.Forms.Padding(2);
            this.kopiaBazy.Name = "kopiaBazy";
            this.kopiaBazy.Size = new System.Drawing.Size(137, 83);
            this.kopiaBazy.TabIndex = 0;
            this.kopiaBazy.Text = "Wykonaj kopię zapsową bazy danych";
            this.kopiaBazy.UseVisualStyleBackColor = true;
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(330, 140);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(2);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(137, 83);
            this.powrotMenu.TabIndex = 1;
            this.powrotMenu.Text = "Powrót";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
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
            // zarzadzajBazaDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.powrotMenu);
            this.Controls.Add(this.kopiaBazy);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "zarzadzajBazaDanych";
            this.Text = "zarzadzajBazaDanych";
            this.Load += new System.EventHandler(this.zarzadzajBazaDanych_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kopiaBazy;
        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label1;
    }
}