namespace PharmaTech.UserControle
{
    partial class StavkaNarudzbenice
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxIzbrisi = new System.Windows.Forms.Button();
            this.uxCijena = new System.Windows.Forms.TextBox();
            this.uxKolicina = new System.Windows.Forms.TextBox();
            this.uxNazivLijeka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Količina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Naziv lijeka";
            // 
            // uxIzbrisi
            // 
            this.uxIzbrisi.BackColor = System.Drawing.Color.DarkGray;
            this.uxIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxIzbrisi.Location = new System.Drawing.Point(663, 45);
            this.uxIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.uxIzbrisi.Name = "uxIzbrisi";
            this.uxIzbrisi.Size = new System.Drawing.Size(66, 28);
            this.uxIzbrisi.TabIndex = 29;
            this.uxIzbrisi.Text = "Obriši";
            this.uxIzbrisi.UseVisualStyleBackColor = false;
            this.uxIzbrisi.Click += new System.EventHandler(this.uxIzbrisi_Click);
            // 
            // uxCijena
            // 
            this.uxCijena.Cursor = System.Windows.Forms.Cursors.Help;
            this.uxCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCijena.Location = new System.Drawing.Point(374, 48);
            this.uxCijena.Margin = new System.Windows.Forms.Padding(4);
            this.uxCijena.Name = "uxCijena";
            this.uxCijena.Size = new System.Drawing.Size(132, 23);
            this.uxCijena.TabIndex = 28;
            this.uxCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxKolicina
            // 
            this.uxKolicina.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uxKolicina.Location = new System.Drawing.Point(200, 52);
            this.uxKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.uxKolicina.Name = "uxKolicina";
            this.uxKolicina.Size = new System.Drawing.Size(144, 22);
            this.uxKolicina.TabIndex = 26;
            this.uxKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxNazivLijeka
            // 
            this.uxNazivLijeka.FormattingEnabled = true;
            this.uxNazivLijeka.Location = new System.Drawing.Point(27, 51);
            this.uxNazivLijeka.Margin = new System.Windows.Forms.Padding(4);
            this.uxNazivLijeka.Name = "uxNazivLijeka";
            this.uxNazivLijeka.Size = new System.Drawing.Size(160, 24);
            this.uxNazivLijeka.TabIndex = 25;
            this.uxNazivLijeka.SelectedIndexChanged += new System.EventHandler(this.uxNazivLijeka_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(514, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "kn";
            // 
            // StavkaNarudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxIzbrisi);
            this.Controls.Add(this.uxCijena);
            this.Controls.Add(this.uxKolicina);
            this.Controls.Add(this.uxNazivLijeka);
            this.Name = "StavkaNarudzbenice";
            this.Size = new System.Drawing.Size(804, 116);
            this.Load += new System.EventHandler(this.StavkaNarudzbenice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxIzbrisi;
        private System.Windows.Forms.TextBox uxCijena;
        private System.Windows.Forms.TextBox uxKolicina;
        private System.Windows.Forms.ComboBox uxNazivLijeka;
        private System.Windows.Forms.Label label3;
    }
}
