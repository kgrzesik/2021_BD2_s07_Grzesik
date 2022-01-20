
namespace Flota
{
    partial class historiaEksploatacja
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
            this.listaEksplo = new System.Windows.Forms.DataGridView();
            this.Wyswietl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataDo = new System.Windows.Forms.DateTimePicker();
            this.dataOd = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.zalogowany = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpHisEks = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaEksplo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(308, 16);
            this.powrot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(184, 41);
            this.powrot.TabIndex = 61;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // listaEksplo
            // 
            this.listaEksplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaEksplo.Location = new System.Drawing.Point(14, 117);
            this.listaEksplo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listaEksplo.Name = "listaEksplo";
            this.listaEksplo.RowHeadersWidth = 51;
            this.listaEksplo.RowTemplate.Height = 24;
            this.listaEksplo.Size = new System.Drawing.Size(1078, 411);
            this.listaEksplo.TabIndex = 76;
            this.listaEksplo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaEksplo_CellContentClick);
            // 
            // Wyswietl
            // 
            this.Wyswietl.Location = new System.Drawing.Point(649, 130);
            this.Wyswietl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Wyswietl.Name = "Wyswietl";
            this.Wyswietl.Size = new System.Drawing.Size(184, 66);
            this.Wyswietl.TabIndex = 75;
            this.Wyswietl.Text = "Wyswietl";
            this.Wyswietl.UseVisualStyleBackColor = true;
            this.Wyswietl.Click += new System.EventHandler(this.Wyswietl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(164, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Do kiedy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(164, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "Od kiedy";
            // 
            // dataDo
            // 
            this.dataDo.Location = new System.Drawing.Point(266, 170);
            this.dataDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDo.Name = "dataDo";
            this.dataDo.Size = new System.Drawing.Size(320, 26);
            this.dataDo.TabIndex = 72;
            // 
            // dataOd
            // 
            this.dataOd.Location = new System.Drawing.Point(266, 130);
            this.dataOd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataOd.Name = "dataOd";
            this.dataOd.Size = new System.Drawing.Size(320, 26);
            this.dataOd.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.zalogowany);
            this.panel3.Location = new System.Drawing.Point(38, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 72);
            this.panel3.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Zalogowano jako: ";
            // 
            // zalogowany
            // 
            this.zalogowany.AutoSize = true;
            this.zalogowany.Location = new System.Drawing.Point(174, 26);
            this.zalogowany.Name = "zalogowany";
            this.zalogowany.Size = new System.Drawing.Size(0, 20);
            this.zalogowany.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.helpHisEks);
            this.panel1.Controls.Add(this.powrot);
            this.panel1.Location = new System.Drawing.Point(598, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 72);
            this.panel1.TabIndex = 83;
            // 
            // helpHisEks
            // 
            this.helpHisEks.Location = new System.Drawing.Point(50, 16);
            this.helpHisEks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpHisEks.Name = "helpHisEks";
            this.helpHisEks.Size = new System.Drawing.Size(184, 41);
            this.helpHisEks.TabIndex = 85;
            this.helpHisEks.Text = "Pomoc";
            this.helpHisEks.UseVisualStyleBackColor = true;
            this.helpHisEks.Click += new System.EventHandler(this.helpHisEks_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.listaEksplo);
            this.panel2.Location = new System.Drawing.Point(38, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 554);
            this.panel2.TabIndex = 84;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 66);
            this.button1.TabIndex = 76;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // historiaEksploatacja
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
            this.Name = "historiaEksploatacja";
            this.Text = "historiaEksploatacja";
            this.Load += new System.EventHandler(this.historiaEksploatacja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaEksplo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.DataGridView listaEksplo;
        private System.Windows.Forms.Button Wyswietl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataDo;
        private System.Windows.Forms.DateTimePicker dataOd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label zalogowany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button helpHisEks;
        private System.Windows.Forms.Button button1;
    }
}