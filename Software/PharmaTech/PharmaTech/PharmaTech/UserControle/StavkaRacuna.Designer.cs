namespace PharmaTech.UserControle
{
    partial class StavkaRacuna
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxNazivLijeka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxKolicinaNaZalihi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxCijena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxKolicinaKupnje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxObrisi = new System.Windows.Forms.Button();
            this.uxUkupanIznos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxNazivLijeka
            // 
            this.uxNazivLijeka.FormattingEnabled = true;
            this.uxNazivLijeka.Location = new System.Drawing.Point(17, 23);
            this.uxNazivLijeka.Name = "uxNazivLijeka";
            this.uxNazivLijeka.Size = new System.Drawing.Size(121, 21);
            this.uxNazivLijeka.TabIndex = 0;
            this.uxNazivLijeka.SelectedIndexChanged += new System.EventHandler(this.uxNazivLijeka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv lijeka:";
            // 
            // uxKolicinaNaZalihi
            // 
            this.uxKolicinaNaZalihi.Location = new System.Drawing.Point(162, 23);
            this.uxKolicinaNaZalihi.Name = "uxKolicinaNaZalihi";
            this.uxKolicinaNaZalihi.Size = new System.Drawing.Size(100, 20);
            this.uxKolicinaNaZalihi.TabIndex = 2;
            this.uxKolicinaNaZalihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Količina na zalihi:";
            // 
            // uxCijena
            // 
            this.uxCijena.Location = new System.Drawing.Point(283, 23);
            this.uxCijena.Name = "uxCijena";
            this.uxCijena.Size = new System.Drawing.Size(100, 20);
            this.uxCijena.TabIndex = 4;
            this.uxCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cijena (1x):";
            // 
            // uxKolicinaKupnje
            // 
            this.uxKolicinaKupnje.Location = new System.Drawing.Point(401, 23);
            this.uxKolicinaKupnje.Name = "uxKolicinaKupnje";
            this.uxKolicinaKupnje.Size = new System.Drawing.Size(100, 20);
            this.uxKolicinaKupnje.TabIndex = 6;
            this.uxKolicinaKupnje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxKolicinaKupnje.TextChanged += new System.EventHandler(this.uxKolicinaKupnje_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Količina kupnje:";
            // 
            // uxObrisi
            // 
            this.uxObrisi.Location = new System.Drawing.Point(650, 21);
            this.uxObrisi.Name = "uxObrisi";
            this.uxObrisi.Size = new System.Drawing.Size(75, 23);
            this.uxObrisi.TabIndex = 8;
            this.uxObrisi.Text = "Obriši";
            this.uxObrisi.UseVisualStyleBackColor = true;
            this.uxObrisi.Click += new System.EventHandler(this.uxObrisi_Click);
            // 
            // uxUkupanIznos
            // 
            this.uxUkupanIznos.Location = new System.Drawing.Point(523, 23);
            this.uxUkupanIznos.Name = "uxUkupanIznos";
            this.uxUkupanIznos.Size = new System.Drawing.Size(100, 20);
            this.uxUkupanIznos.TabIndex = 9;
            this.uxUkupanIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ukupan iznos:";
            // 
            // StavkaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxUkupanIznos);
            this.Controls.Add(this.uxObrisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxKolicinaKupnje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxCijena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxKolicinaNaZalihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxNazivLijeka);
            this.Name = "StavkaRacuna";
            this.Size = new System.Drawing.Size(754, 56);
            this.Load += new System.EventHandler(this.StavkaRacuna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxNazivLijeka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxKolicinaNaZalihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxCijena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxKolicinaKupnje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uxObrisi;
        private System.Windows.Forms.TextBox uxUkupanIznos;
        private System.Windows.Forms.Label label5;
    }
}
