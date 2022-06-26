namespace PharmaTech.Forme
{
    partial class KreirajInventurniList
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uxStavke = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Dodaj stavku inventure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(388, 108);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 19;
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(129, 108);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(157, 24);
            this.cbZaposlenik.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Provodi inventuru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 25.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(100, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 57);
            this.label3.TabIndex = 14;
            this.label3.Text = "Inventurni list";
            // 
            // uxStavke
            // 
            this.uxStavke.AutoScroll = true;
            this.uxStavke.Location = new System.Drawing.Point(10, 159);
            this.uxStavke.Name = "uxStavke";
            this.uxStavke.Size = new System.Drawing.Size(776, 223);
            this.uxStavke.TabIndex = 13;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(618, 425);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(167, 30);
            this.btnSpremi.TabIndex = 21;
            this.btnSpremi.Text = "Spremi stavke";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmaTech.Properties.Resources.ppp;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(12, 516);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(773, 250);
            this.dgvStavke.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Popis stavki:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(10, 772);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 30);
            this.btnZatvori.TabIndex = 25;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Eva Oreški\\Desktop\\pi22-eoreski-dskaro-hmiskic\\PharmaTech\\PharmaTech\\Pha" +
    "rmaTech\\Resources\\PharmaTech.chm";
            // 
            // KreirajInventurniList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(809, 814);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxStavke);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "KreirajInventurniList";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "KreirajInventurniList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel uxStavke;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}