namespace PharmaTech.Forme
{
    partial class KreirajRacun
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uxStavke = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnSpremiStavke = new System.Windows.Forms.Button();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUkupnaCijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(76, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kreiraj račun";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(11, 724);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(89, 25);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stavke za dodati na račun;";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmaTech.Properties.Resources.ppp;
            this.pictureBox1.Location = new System.Drawing.Point(11, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uxStavke
            // 
            this.uxStavke.BackColor = System.Drawing.Color.Ivory;
            this.uxStavke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxStavke.Location = new System.Drawing.Point(12, 139);
            this.uxStavke.Name = "uxStavke";
            this.uxStavke.Size = new System.Drawing.Size(750, 232);
            this.uxStavke.TabIndex = 7;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(15, 377);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(119, 25);
            this.btnDodajStavku.TabIndex = 8;
            this.btnDodajStavku.Text = "Dodaj stavku računa";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnSpremiStavke
            // 
            this.btnSpremiStavke.Location = new System.Drawing.Point(163, 377);
            this.btnSpremiStavke.Name = "btnSpremiStavke";
            this.btnSpremiStavke.Size = new System.Drawing.Size(119, 25);
            this.btnSpremiStavke.TabIndex = 9;
            this.btnSpremiStavke.Text = "Spremi stavke";
            this.btnSpremiStavke.UseVisualStyleBackColor = true;
            this.btnSpremiStavke.Click += new System.EventHandler(this.btnSpremiStavke_Click);
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(11, 452);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.Size = new System.Drawing.Size(751, 255);
            this.dgvStavke.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(8, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Popis stavki računa:";
            // 
            // txtUkupnaCijena
            // 
            this.txtUkupnaCijena.Location = new System.Drawing.Point(616, 380);
            this.txtUkupnaCijena.Name = "txtUkupnaCijena";
            this.txtUkupnaCijena.Size = new System.Drawing.Size(146, 20);
            this.txtUkupnaCijena.TabIndex = 12;
            this.txtUkupnaCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(464, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ukupan iznos računa:";
            // 
            // KreirajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(774, 758);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUkupnaCijena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.btnSpremiStavke);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.uxStavke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KreirajRacun";
            this.Text = "Kreiraj Racun";
            this.Load += new System.EventHandler(this.KreirajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel uxStavke;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnSpremiStavke;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUkupnaCijena;
        private System.Windows.Forms.Label label2;
    }
}