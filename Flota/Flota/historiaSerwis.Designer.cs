
namespace Flota
{
    partial class historiaSerwis
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
            this.powrot = new System.Windows.Forms.Button();
            this.zalogowany = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(631, 81);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(123, 60);
            this.powrot.TabIndex = 61;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(105, 13);
            this.zalogowany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 13);
            this.zalogowany.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Zalogowano jako: ";
            // 
            // historiaSerwis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.powrot);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label5);
            this.Name = "historiaSerwis";
            this.Text = "historiaSerwis";
            this.Load += new System.EventHandler(this.historiaSerwis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label5;
    }
}