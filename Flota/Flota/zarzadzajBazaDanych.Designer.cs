
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
            this.SuspendLayout();
            // 
            // kopiaBazy
            // 
            this.kopiaBazy.Location = new System.Drawing.Point(195, 172);
            this.kopiaBazy.Name = "kopiaBazy";
            this.kopiaBazy.Size = new System.Drawing.Size(183, 102);
            this.kopiaBazy.TabIndex = 0;
            this.kopiaBazy.Text = "Wykonaj kopię zapsową bazy danych";
            this.kopiaBazy.UseVisualStyleBackColor = true;
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(440, 172);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(183, 102);
            this.powrotMenu.TabIndex = 1;
            this.powrotMenu.Text = "Powrót";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // zarzadzajBazaDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.powrotMenu);
            this.Controls.Add(this.kopiaBazy);
            this.Name = "zarzadzajBazaDanych";
            this.Text = "zarzadzajBazaDanych";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kopiaBazy;
        private System.Windows.Forms.Button powrotMenu;
    }
}