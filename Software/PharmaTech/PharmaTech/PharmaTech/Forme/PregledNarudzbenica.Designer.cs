namespace PharmaTech.Forme
{
    partial class PregledNarudzbenica
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
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKreirajNarudzbenicu = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNarudzbenice = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(652, 135);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(604, 437);
            this.dgvStavke.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 57);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pregled narudžbenica";
            // 
            // btnKreirajNarudzbenicu
            // 
            this.btnKreirajNarudzbenicu.Location = new System.Drawing.Point(1104, 589);
            this.btnKreirajNarudzbenicu.Name = "btnKreirajNarudzbenicu";
            this.btnKreirajNarudzbenicu.Size = new System.Drawing.Size(152, 27);
            this.btnKreirajNarudzbenicu.TabIndex = 20;
            this.btnKreirajNarudzbenicu.Text = "Kreiraj narudžbenicu";
            this.btnKreirajNarudzbenicu.UseVisualStyleBackColor = true;
            this.btnKreirajNarudzbenicu.Click += new System.EventHandler(this.btnKreirajNarudzbenicu_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Transparent;
            this.btnZatvori.Location = new System.Drawing.Point(18, 589);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(152, 27);
            this.btnZatvori.TabIndex = 19;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Stavke narudžbenice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Narudžbenice:";
            // 
            // dgvNarudzbenice
            // 
            this.dgvNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenice.Location = new System.Drawing.Point(18, 135);
            this.dgvNarudzbenice.Name = "dgvNarudzbenice";
            this.dgvNarudzbenice.RowHeadersWidth = 51;
            this.dgvNarudzbenice.RowTemplate.Height = 24;
            this.dgvNarudzbenice.Size = new System.Drawing.Size(611, 437);
            this.dgvNarudzbenice.TabIndex = 16;
            this.dgvNarudzbenice.SelectionChanged += new System.EventHandler(this.dgvNarudzbenice_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmaTech.Properties.Resources.ppp;
            this.pictureBox1.Location = new System.Drawing.Point(18, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Eva Oreški\\Desktop\\pi22-eoreski-dskaro-hmiskic\\PharmaTech\\PharmaTech\\Pha" +
    "rmaTech\\Resources\\PharmaTech.chm";
            // 
            // PregledNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1280, 635);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKreirajNarudzbenicu);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNarudzbenice);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "PregledNarudzbenica";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "PregledNarudzbenica";
            this.Load += new System.EventHandler(this.PregledNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKreirajNarudzbenicu;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNarudzbenice;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}