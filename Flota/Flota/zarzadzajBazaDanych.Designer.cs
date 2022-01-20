
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpZarzBD = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kopiaBazy
            // 
            this.kopiaBazy.Location = new System.Drawing.Point(192, 74);
            this.kopiaBazy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kopiaBazy.Name = "kopiaBazy";
            this.kopiaBazy.Size = new System.Drawing.Size(278, 102);
            this.kopiaBazy.TabIndex = 0;
            this.kopiaBazy.Text = "Wykonaj kopię zapsową bazy danych";
            this.kopiaBazy.UseVisualStyleBackColor = true;
            this.kopiaBazy.Click += new System.EventHandler(this.kopiaBazy_Click);
            // 
            // powrotMenu
            // 
            this.powrotMenu.Location = new System.Drawing.Point(130, 7);
            this.powrotMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.powrotMenu.Name = "powrotMenu";
            this.powrotMenu.Size = new System.Drawing.Size(121, 43);
            this.powrotMenu.TabIndex = 1;
            this.powrotMenu.Text = "Powrót";
            this.powrotMenu.UseVisualStyleBackColor = true;
            this.powrotMenu.Click += new System.EventHandler(this.powrotMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.helpZarzBD);
            this.panel2.Controls.Add(this.powrotMenu);
            this.panel2.Location = new System.Drawing.Point(448, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 58);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(55, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 58);
            this.panel3.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(160, 20);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kopiaBazy);
            this.panel1.Location = new System.Drawing.Point(55, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 265);
            this.panel1.TabIndex = 57;
            // 
            // helpZarzBD
            // 
            this.helpZarzBD.Location = new System.Drawing.Point(14, 7);
            this.helpZarzBD.Margin = new System.Windows.Forms.Padding(4);
            this.helpZarzBD.Name = "helpZarzBD";
            this.helpZarzBD.Size = new System.Drawing.Size(109, 43);
            this.helpZarzBD.TabIndex = 9;
            this.helpZarzBD.Text = "Pomoc";
            this.helpZarzBD.UseVisualStyleBackColor = true;
            this.helpZarzBD.Click += new System.EventHandler(this.helpZarzBD_Click);
            // 
            // zarzadzajBazaDanych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "zarzadzajBazaDanych";
            this.Text = "zarzadzajBazaDanych";
            this.Load += new System.EventHandler(this.zarzadzajBazaDanych_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kopiaBazy;
        private System.Windows.Forms.Button powrotMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button helpZarzBD;
    }
}