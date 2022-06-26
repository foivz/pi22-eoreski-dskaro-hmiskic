namespace PharmaTech.UserControle
{
    partial class StavkaInventure
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxIzbrisi = new System.Windows.Forms.Button();
            this.uxRazlika = new System.Windows.Forms.TextBox();
            this.uxStvarnaKolicina = new System.Windows.Forms.TextBox();
            this.uxKolicinaNaZalihi = new System.Windows.Forms.TextBox();
            this.uxNazivLijeka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Razlika";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stvarna količina";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Količina na zalihi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Naziv lijeka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uxIzbrisi
            // 
            this.uxIzbrisi.BackColor = System.Drawing.Color.DarkGray;
            this.uxIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxIzbrisi.Location = new System.Drawing.Point(686, 45);
            this.uxIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.uxIzbrisi.Name = "uxIzbrisi";
            this.uxIzbrisi.Size = new System.Drawing.Size(66, 28);
            this.uxIzbrisi.TabIndex = 20;
            this.uxIzbrisi.Text = "Obriši";
            this.uxIzbrisi.UseVisualStyleBackColor = false;
            this.uxIzbrisi.Click += new System.EventHandler(this.uxIzbrisi_Click);
            // 
            // uxRazlika
            // 
            this.uxRazlika.Cursor = System.Windows.Forms.Cursors.Help;
            this.uxRazlika.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRazlika.Location = new System.Drawing.Point(533, 49);
            this.uxRazlika.Margin = new System.Windows.Forms.Padding(4);
            this.uxRazlika.Name = "uxRazlika";
            this.uxRazlika.Size = new System.Drawing.Size(132, 23);
            this.uxRazlika.TabIndex = 19;
            this.uxRazlika.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxRazlika.TextChanged += new System.EventHandler(this.uxRazlika_TextChanged);
            // 
            // uxStvarnaKolicina
            // 
            this.uxStvarnaKolicina.Location = new System.Drawing.Point(357, 49);
            this.uxStvarnaKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.uxStvarnaKolicina.Name = "uxStvarnaKolicina";
            this.uxStvarnaKolicina.Size = new System.Drawing.Size(151, 22);
            this.uxStvarnaKolicina.TabIndex = 18;
            this.uxStvarnaKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxStvarnaKolicina.TextChanged += new System.EventHandler(this.uxStvarnaKolicina_TextChanged);
            // 
            // uxKolicinaNaZalihi
            // 
            this.uxKolicinaNaZalihi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uxKolicinaNaZalihi.Location = new System.Drawing.Point(197, 49);
            this.uxKolicinaNaZalihi.Margin = new System.Windows.Forms.Padding(4);
            this.uxKolicinaNaZalihi.Name = "uxKolicinaNaZalihi";
            this.uxKolicinaNaZalihi.Size = new System.Drawing.Size(144, 22);
            this.uxKolicinaNaZalihi.TabIndex = 17;
            this.uxKolicinaNaZalihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uxKolicinaNaZalihi.TextChanged += new System.EventHandler(this.uxKolicinaNaZalihi_TextChanged);
            // 
            // uxNazivLijeka
            // 
            this.uxNazivLijeka.FormattingEnabled = true;
            this.uxNazivLijeka.Location = new System.Drawing.Point(24, 48);
            this.uxNazivLijeka.Margin = new System.Windows.Forms.Padding(4);
            this.uxNazivLijeka.Name = "uxNazivLijeka";
            this.uxNazivLijeka.Size = new System.Drawing.Size(160, 24);
            this.uxNazivLijeka.TabIndex = 16;
            this.uxNazivLijeka.SelectedIndexChanged += new System.EventHandler(this.uxNazivLijeka_SelectedIndexChanged);
            // 
            // StavkaInventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxIzbrisi);
            this.Controls.Add(this.uxRazlika);
            this.Controls.Add(this.uxStvarnaKolicina);
            this.Controls.Add(this.uxKolicinaNaZalihi);
            this.Controls.Add(this.uxNazivLijeka);
            this.Name = "StavkaInventure";
            this.Size = new System.Drawing.Size(778, 107);
            this.Load += new System.EventHandler(this.StavkaInventure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxIzbrisi;
        private System.Windows.Forms.TextBox uxRazlika;
        private System.Windows.Forms.TextBox uxStvarnaKolicina;
        private System.Windows.Forms.TextBox uxKolicinaNaZalihi;
        private System.Windows.Forms.ComboBox uxNazivLijeka;
    }
}
