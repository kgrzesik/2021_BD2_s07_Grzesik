
namespace Flota
{
    partial class Eksploatacja
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
            this.zalogowany = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kosztText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textCzynnosc = new System.Windows.Forms.ComboBox();
            this.textPojazd = new System.Windows.Forms.ComboBox();
            this.powrotButton = new System.Windows.Forms.Button();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.historia = new System.Windows.Forms.Button();
            this.dataWyk = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(159, 26);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 20);
            this.zalogowany.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Zalogowano jako: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Koszt";
            // 
            // kosztText
            // 
            this.kosztText.Location = new System.Drawing.Point(249, 232);
            this.kosztText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kosztText.Name = "kosztText";
            this.kosztText.Size = new System.Drawing.Size(298, 26);
            this.kosztText.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Czynność";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Pojazd";
            // 
            // textCzynnosc
            // 
            this.textCzynnosc.FormattingEnabled = true;
            this.textCzynnosc.Location = new System.Drawing.Point(249, 165);
            this.textCzynnosc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCzynnosc.Name = "textCzynnosc";
            this.textCzynnosc.Size = new System.Drawing.Size(298, 28);
            this.textCzynnosc.TabIndex = 60;
            // 
            // textPojazd
            // 
            this.textPojazd.FormattingEnabled = true;
            this.textPojazd.Location = new System.Drawing.Point(249, 92);
            this.textPojazd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textPojazd.Name = "textPojazd";
            this.textPojazd.Size = new System.Drawing.Size(298, 28);
            this.textPojazd.TabIndex = 58;
            // 
            // powrotButton
            // 
            this.powrotButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.powrotButton.Location = new System.Drawing.Point(48, 383);
            this.powrotButton.Name = "powrotButton";
            this.powrotButton.Size = new System.Drawing.Size(177, 80);
            this.powrotButton.TabIndex = 57;
            this.powrotButton.Text = "Powrót";
            this.powrotButton.UseVisualStyleBackColor = true;
            this.powrotButton.Click += new System.EventHandler(this.powrotButton_Click);
            // 
            // zapiszButton
            // 
            this.zapiszButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.zapiszButton.Location = new System.Drawing.Point(249, 383);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(177, 80);
            this.zapiszButton.TabIndex = 72;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            // 
            // historia
            // 
            this.historia.Cursor = System.Windows.Forms.Cursors.Default;
            this.historia.Location = new System.Drawing.Point(453, 383);
            this.historia.Name = "historia";
            this.historia.Size = new System.Drawing.Size(156, 80);
            this.historia.TabIndex = 73;
            this.historia.Text = "Historia";
            this.historia.UseVisualStyleBackColor = true;
            this.historia.Click += new System.EventHandler(this.historia_Click);
            // 
            // dataWyk
            // 
            this.dataWyk.Location = new System.Drawing.Point(249, 294);
            this.dataWyk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataWyk.Name = "dataWyk";
            this.dataWyk.Size = new System.Drawing.Size(298, 26);
            this.dataWyk.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 30);
            this.label4.TabIndex = 75;
            this.label4.Text = "Data wykonania";
            // 
            // Eksploatacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataWyk);
            this.Controls.Add(this.historia);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kosztText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCzynnosc);
            this.Controls.Add(this.textPojazd);
            this.Controls.Add(this.powrotButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Eksploatacja";
            this.Text = "Eksploatacja";
            this.Load += new System.EventHandler(this.Eksploatacja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kosztText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textCzynnosc;
        private System.Windows.Forms.ComboBox textPojazd;
        private System.Windows.Forms.Button powrotButton;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Button historia;
        private System.Windows.Forms.DateTimePicker dataWyk;
        private System.Windows.Forms.Label label4;
    }
}