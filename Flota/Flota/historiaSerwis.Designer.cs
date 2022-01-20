
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
            this.listaSerwis = new System.Windows.Forms.DataGridView();
            this.Wyswietl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDo = new System.Windows.Forms.DateTimePicker();
            this.dataOd = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpHisSer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaSerwis)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(323, 5);
            this.powrot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(184, 60);
            this.powrot.TabIndex = 61;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // listaSerwis
            // 
            this.listaSerwis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSerwis.Location = new System.Drawing.Point(12, 107);
            this.listaSerwis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaSerwis.Name = "listaSerwis";
            this.listaSerwis.RowHeadersWidth = 51;
            this.listaSerwis.RowTemplate.Height = 24;
            this.listaSerwis.Size = new System.Drawing.Size(1078, 411);
            this.listaSerwis.TabIndex = 70;
            this.listaSerwis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaSerwis_CellContentClick);
            // 
            // Wyswietl
            // 
            this.Wyswietl.Location = new System.Drawing.Point(652, 139);
            this.Wyswietl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Wyswietl.Name = "Wyswietl";
            this.Wyswietl.Size = new System.Drawing.Size(184, 72);
            this.Wyswietl.TabIndex = 69;
            this.Wyswietl.Text = "Wyswietl";
            this.Wyswietl.UseVisualStyleBackColor = true;
            this.Wyswietl.Click += new System.EventHandler(this.Wyswietl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(147, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Do kiedy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(147, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Od kiedy";
            // 
            // dataDo
            // 
            this.dataDo.Location = new System.Drawing.Point(249, 179);
            this.dataDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDo.Name = "dataDo";
            this.dataDo.Size = new System.Drawing.Size(320, 26);
            this.dataDo.TabIndex = 66;
            // 
            // dataOd
            // 
            this.dataOd.Location = new System.Drawing.Point(249, 139);
            this.dataOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataOd.Name = "dataOd";
            this.dataOd.Size = new System.Drawing.Size(320, 26);
            this.dataOd.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.helpHisSer);
            this.panel1.Controls.Add(this.powrot);
            this.panel1.Location = new System.Drawing.Point(601, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 72);
            this.panel1.TabIndex = 85;
            // 
            // helpHisSer
            // 
            this.helpHisSer.Location = new System.Drawing.Point(51, 5);
            this.helpHisSer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpHisSer.Name = "helpHisSer";
            this.helpHisSer.Size = new System.Drawing.Size(184, 60);
            this.helpHisSer.TabIndex = 90;
            this.helpHisSer.Text = "Pomoc";
            this.helpHisSer.UseVisualStyleBackColor = true;
            this.helpHisSer.Click += new System.EventHandler(this.helpHisSer_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(40, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 72);
            this.panel3.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(177, 26);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 20);
            this.zalogowany.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.listaSerwis);
            this.panel2.Location = new System.Drawing.Point(40, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 544);
            this.panel2.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 72);
            this.button1.TabIndex = 70;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historiaSerwis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Wyswietl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataDo);
            this.Controls.Add(this.dataOd);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "historiaSerwis";
            this.Text = "historiaSerwis";
            this.Load += new System.EventHandler(this.historiaSerwis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaSerwis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.DataGridView listaSerwis;
        private System.Windows.Forms.Button Wyswietl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataDo;
        private System.Windows.Forms.DateTimePicker dataOd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button helpHisSer;
        private System.Windows.Forms.Button button1;
    }
}