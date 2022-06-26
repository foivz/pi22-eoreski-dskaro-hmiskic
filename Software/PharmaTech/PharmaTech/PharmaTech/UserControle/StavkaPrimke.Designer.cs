namespace PharmaTech.UserControle
{
    partial class StavkaPrimke
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxIzbrisi = new System.Windows.Forms.Button();
            this.uxPrimljenaKolicina = new System.Windows.Forms.TextBox();
            this.uxNazivLijeka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Primljena količina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 34);
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
            this.uxIzbrisi.Location = new System.Drawing.Point(469, 54);
            this.uxIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.uxIzbrisi.Name = "uxIzbrisi";
            this.uxIzbrisi.Size = new System.Drawing.Size(66, 28);
            this.uxIzbrisi.TabIndex = 29;
            this.uxIzbrisi.Text = "Obriši";
            this.uxIzbrisi.UseVisualStyleBackColor = false;
            this.uxIzbrisi.Click += new System.EventHandler(this.uxIzbrisi_Click);
            // 
            // uxPrimljenaKolicina
            // 
            this.uxPrimljenaKolicina.Location = new System.Drawing.Point(240, 58);
            this.uxPrimljenaKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.uxPrimljenaKolicina.Name = "uxPrimljenaKolicina";
            this.uxPrimljenaKolicina.Size = new System.Drawing.Size(151, 22);
            this.uxPrimljenaKolicina.TabIndex = 27;
            this.uxPrimljenaKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxNazivLijeka
            // 
            this.uxNazivLijeka.FormattingEnabled = true;
            this.uxNazivLijeka.Location = new System.Drawing.Point(35, 56);
            this.uxNazivLijeka.Margin = new System.Windows.Forms.Padding(4);
            this.uxNazivLijeka.Name = "uxNazivLijeka";
            this.uxNazivLijeka.Size = new System.Drawing.Size(160, 24);
            this.uxNazivLijeka.TabIndex = 25;
            // 
            // StavkaPrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxIzbrisi);
            this.Controls.Add(this.uxPrimljenaKolicina);
            this.Controls.Add(this.uxNazivLijeka);
            this.Name = "StavkaPrimke";
            this.Size = new System.Drawing.Size(674, 112);
            this.Load += new System.EventHandler(this.StavkaPrimke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxIzbrisi;
        private System.Windows.Forms.TextBox uxPrimljenaKolicina;
        private System.Windows.Forms.ComboBox uxNazivLijeka;
    }
}
