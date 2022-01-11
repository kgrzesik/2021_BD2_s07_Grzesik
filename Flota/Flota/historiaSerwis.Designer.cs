
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
            this.listaSerwis = new System.Windows.Forms.DataGridView();
            this.Wyswietl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDo = new System.Windows.Forms.DateTimePicker();
            this.dataOd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.listaSerwis)).BeginInit();
            this.SuspendLayout();
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(841, 100);
            this.powrot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(164, 74);
            this.powrot.TabIndex = 61;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(140, 16);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 17);
            this.zalogowany.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "Zalogowano jako: ";
            // 
            // listaSerwis
            // 
            this.listaSerwis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSerwis.Location = new System.Drawing.Point(47, 196);
            this.listaSerwis.Name = "listaSerwis";
            this.listaSerwis.RowHeadersWidth = 51;
            this.listaSerwis.RowTemplate.Height = 24;
            this.listaSerwis.Size = new System.Drawing.Size(958, 329);
            this.listaSerwis.TabIndex = 70;
            // 
            // Wyswietl
            // 
            this.Wyswietl.Location = new System.Drawing.Point(644, 99);
            this.Wyswietl.Margin = new System.Windows.Forms.Padding(4);
            this.Wyswietl.Name = "Wyswietl";
            this.Wyswietl.Size = new System.Drawing.Size(164, 74);
            this.Wyswietl.TabIndex = 69;
            this.Wyswietl.Text = "Wyswietl";
            this.Wyswietl.UseVisualStyleBackColor = true;
            this.Wyswietl.Click += new System.EventHandler(this.Wyswietl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Do kiedy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Od kiedy";
            // 
            // dataDo
            // 
            this.dataDo.Location = new System.Drawing.Point(135, 131);
            this.dataDo.Margin = new System.Windows.Forms.Padding(4);
            this.dataDo.Name = "dataDo";
            this.dataDo.Size = new System.Drawing.Size(285, 22);
            this.dataDo.TabIndex = 66;
            // 
            // dataOd
            // 
            this.dataOd.Location = new System.Drawing.Point(135, 99);
            this.dataOd.Margin = new System.Windows.Forms.Padding(4);
            this.dataOd.Name = "dataOd";
            this.dataOd.Size = new System.Drawing.Size(285, 22);
            this.dataOd.TabIndex = 65;
            // 
            // historiaSerwis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listaSerwis);
            this.Controls.Add(this.Wyswietl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataDo);
            this.Controls.Add(this.dataOd);
            this.Controls.Add(this.powrot);
            this.Controls.Add(this.zalogowany);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "historiaSerwis";
            this.Text = "historiaSerwis";
            this.Load += new System.EventHandler(this.historiaSerwis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaSerwis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView listaSerwis;
        private System.Windows.Forms.Button Wyswietl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataDo;
        private System.Windows.Forms.DateTimePicker dataOd;
    }
}