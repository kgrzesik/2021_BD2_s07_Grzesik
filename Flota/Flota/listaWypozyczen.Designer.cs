
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
            this.listaWyp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaWyp)).BeginInit();
            this.SuspendLayout();
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(142, 11);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Zalogowano jako: ";
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(844, 94);
            this.powrot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(164, 74);
            this.powrot.TabIndex = 58;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Do kiedy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Od kiedy";
            // 
            // dataDo
            // 
            this.dataDo.Location = new System.Drawing.Point(138, 126);
            this.dataDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataDo.Name = "dataDo";
            this.dataDo.Size = new System.Drawing.Size(285, 22);
            this.dataDo.TabIndex = 60;
            // 
            // dataOd
            // 
            this.dataOd.Location = new System.Drawing.Point(138, 94);
            this.dataOd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataOd.Name = "dataOd";
            this.dataOd.Size = new System.Drawing.Size(285, 22);
            this.dataOd.TabIndex = 59;
            // 
            // Wyswietl
            // 
            this.Wyswietl.Location = new System.Drawing.Point(647, 94);
            this.Wyswietl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Wyswietl.Name = "Wyswietl";
            this.Wyswietl.Size = new System.Drawing.Size(164, 74);
            this.Wyswietl.TabIndex = 63;
            this.Wyswietl.Text = "Wyswietl";
            this.Wyswietl.UseVisualStyleBackColor = true;
            this.Wyswietl.Click += new System.EventHandler(this.Wyswietl_Click);
            // 
            // listaWyp
            // 
            this.listaWyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaWyp.Location = new System.Drawing.Point(50, 191);
            this.listaWyp.Name = "listaWyp";
            this.listaWyp.RowHeadersWidth = 51;
            this.listaWyp.RowTemplate.Height = 24;
            this.listaWyp.Size = new System.Drawing.Size(958, 329);
            this.listaWyp.TabIndex = 64;
            // 
            // listaWypozyczen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listaWyp);
            this.Controls.Add(this.Wyswietl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataDo);
            this.Controls.Add(this.dataOd);
            this.Controls.Add(this.powrot);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "listaWypozyczen";
            this.Text = "listaWypozyczen";
            this.Load += new System.EventHandler(this.listaWypozyczen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaWyp)).EndInit();
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
        private System.Windows.Forms.DataGridView listaWyp;
    }
}