
namespace Flota
{
    partial class Ustawienia
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
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.newPasword2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.powrotZarzadzajPojazdem = new System.Windows.Forms.Button();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(110, 49);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(100, 20);
            this.oldPassword.TabIndex = 0;
            this.oldPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(110, 116);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(100, 20);
            this.newPassword.TabIndex = 1;
            // 
            // newPasword2
            // 
            this.newPasword2.Location = new System.Drawing.Point(110, 142);
            this.newPasword2.Name = "newPasword2";
            this.newPasword2.Size = new System.Drawing.Size(100, 20);
            this.newPasword2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zmień hasło";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stare hasło";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nowe hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Powtórz hasło";
            // 
            // powrotZarzadzajPojazdem
            // 
            this.powrotZarzadzajPojazdem.Location = new System.Drawing.Point(248, 29);
            this.powrotZarzadzajPojazdem.Margin = new System.Windows.Forms.Padding(2);
            this.powrotZarzadzajPojazdem.Name = "powrotZarzadzajPojazdem";
            this.powrotZarzadzajPojazdem.Size = new System.Drawing.Size(118, 52);
            this.powrotZarzadzajPojazdem.TabIndex = 28;
            this.powrotZarzadzajPojazdem.Text = "Powrót";
            this.powrotZarzadzajPojazdem.UseVisualStyleBackColor = true;
            this.powrotZarzadzajPojazdem.Click += new System.EventHandler(this.powrotZarzadzajPojazdem_Click);
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(107, 9);
            this.zalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 13);
            this.zalogowany.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Zalogowano jako: ";
            // 
            // Ustawienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 283);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.powrotZarzadzajPojazdem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newPasword2);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPassword);
            this.Name = "Ustawienia";
            this.Text = "Ustawienia";
            this.Load += new System.EventHandler(this.Ustawienia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox newPasword2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button powrotZarzadzajPojazdem;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label4;
    }
}