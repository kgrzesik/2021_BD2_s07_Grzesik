
namespace Flota
{
    partial class LoginPanel
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Location = new System.Drawing.Point(316, 153);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(177, 22);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.TextChanged += new System.EventHandler(this.loginLabel_TextChanged);
            this.loginLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginLabel_KeyDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(316, 204);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.PasswordChar = '•';
            this.passwordLabel.Size = new System.Drawing.Size(177, 22);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.passwordLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordLabel_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło:";
            // 
            // zaloguj
            // 
            this.zaloguj.Location = new System.Drawing.Point(316, 243);
            this.zaloguj.Name = "zaloguj";
            this.zaloguj.Size = new System.Drawing.Size(177, 46);
            this.zaloguj.TabIndex = 5;
            this.zaloguj.Text = "Zaloguj";
            this.zaloguj.UseVisualStyleBackColor = true;
            this.zaloguj.Click += new System.EventHandler(this.zaloguj_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 497);
            this.Controls.Add(this.zaloguj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "LoginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Panel logowania";
            this.Load += new System.EventHandler(this.LoginPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginLabel;
        private System.Windows.Forms.TextBox passwordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zaloguj;
    }
}

