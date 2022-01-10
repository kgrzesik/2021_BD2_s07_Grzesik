
namespace Flota
{
    partial class listaWypozyczen
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
            this.label5 = new System.Windows.Forms.Label();
            this.powrot = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDo = new System.Windows.Forms.DateTimePicker();
            this.dataOd = new System.Windows.Forms.DateTimePicker();
            this.Wyswietl = new System.Windows.Forms.Button();
            this.listaPoj = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(160, 14);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 20);
            this.zalogowany.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Zalogowano jako: ";
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(950, 118);
            this.powrot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(184, 92);
            this.powrot.TabIndex = 58;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Do kiedy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Od kiedy";
            // 
            // dataDo
            // 
            this.dataDo.Location = new System.Drawing.Point(236, 245);
            this.dataDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDo.Name = "dataDo";
            this.dataDo.Size = new System.Drawing.Size(320, 26);
            this.dataDo.TabIndex = 60;
            // 
            // dataOd
            // 
            this.dataOd.Location = new System.Drawing.Point(236, 205);
            this.dataOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataOd.Name = "dataOd";
            this.dataOd.Size = new System.Drawing.Size(320, 26);
            this.dataOd.TabIndex = 59;
            // 
            // Wyswietl
            // 
            this.Wyswietl.Location = new System.Drawing.Point(291, 412);
            this.Wyswietl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Wyswietl.Name = "Wyswietl";
            this.Wyswietl.Size = new System.Drawing.Size(184, 92);
            this.Wyswietl.TabIndex = 63;
            this.Wyswietl.Text = "Wyswietl";
            this.Wyswietl.UseVisualStyleBackColor = true;
            this.Wyswietl.Click += new System.EventHandler(this.Wyswietl_Click);
            // 
            // listaPoj
            // 
            this.listaPoj.FormattingEnabled = true;
            this.listaPoj.ItemHeight = 20;
            this.listaPoj.Location = new System.Drawing.Point(675, 245);
            this.listaPoj.Name = "listaPoj";
            this.listaPoj.Size = new System.Drawing.Size(384, 424);
            this.listaPoj.TabIndex = 64;
            // 
            // listaWypozyczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.listaPoj);
            this.Controls.Add(this.Wyswietl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataDo);
            this.Controls.Add(this.dataOd);
            this.Controls.Add(this.powrot);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "listaWypozyczen";
            this.Text = "listaWypozyczen";
            this.Load += new System.EventHandler(this.listaWypozyczen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataDo;
        private System.Windows.Forms.DateTimePicker dataOd;
        private System.Windows.Forms.Button Wyswietl;
        private System.Windows.Forms.ListBox listaPoj;
    }
}