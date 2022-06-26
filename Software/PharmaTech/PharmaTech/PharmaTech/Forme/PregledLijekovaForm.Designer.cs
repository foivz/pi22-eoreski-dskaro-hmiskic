namespace PharmaTech.Forme
{
    partial class PregledLijekovaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.cmbSortiranje = new System.Windows.Forms.ComboBox();
            this.cmbFiltriranje = new System.Windows.Forms.ComboBox();
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnDodajLijek = new System.Windows.Forms.Button();
            this.btnAzurirajLijek = new System.Windows.Forms.Button();
            this.btnIzbrisiLijek = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmaTech.Properties.Resources.ppp;
            this.pictureBox1.Location = new System.Drawing.Point(32, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 59);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pregled lijekova";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pretraživanje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(835, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Filtriranje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sortiranje:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretraga.Location = new System.Drawing.Point(144, 120);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(188, 27);
            this.txtPretraga.TabIndex = 26;
            // 
            // cmbSortiranje
            // 
            this.cmbSortiranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortiranje.FormattingEnabled = true;
            this.cmbSortiranje.Location = new System.Drawing.Point(688, 119);
            this.cmbSortiranje.Name = "cmbSortiranje";
            this.cmbSortiranje.Size = new System.Drawing.Size(141, 28);
            this.cmbSortiranje.TabIndex = 27;
            this.cmbSortiranje.SelectedIndexChanged += new System.EventHandler(this.cmbSortiranje_SelectedIndexChanged);
            // 
            // cmbFiltriranje
            // 
            this.cmbFiltriranje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltriranje.FormattingEnabled = true;
            this.cmbFiltriranje.Location = new System.Drawing.Point(936, 119);
            this.cmbFiltriranje.Name = "cmbFiltriranje";
            this.cmbFiltriranje.Size = new System.Drawing.Size(181, 28);
            this.cmbFiltriranje.TabIndex = 28;
            this.cmbFiltriranje.SelectedIndexChanged += new System.EventHandler(this.cmbFiltriranje_SelectedIndexChanged);
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLijekovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLijekovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLijekovi.Location = new System.Drawing.Point(57, 158);
            this.dgvLijekovi.Name = "dgvLijekovi";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLijekovi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLijekovi.RowHeadersWidth = 57;
            this.dgvLijekovi.RowTemplate.Height = 24;
            this.dgvLijekovi.Size = new System.Drawing.Size(988, 325);
            this.dgvLijekovi.TabIndex = 29;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.Location = new System.Drawing.Point(12, 515);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(128, 46);
            this.btnZatvori.TabIndex = 30;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.Location = new System.Drawing.Point(525, 515);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(146, 46);
            this.btnDetalji.TabIndex = 31;
            this.btnDetalji.Text = "Detalji o lijeku";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnDodajLijek
            // 
            this.btnDodajLijek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajLijek.Location = new System.Drawing.Point(688, 515);
            this.btnDodajLijek.Name = "btnDodajLijek";
            this.btnDodajLijek.Size = new System.Drawing.Size(130, 46);
            this.btnDodajLijek.TabIndex = 32;
            this.btnDodajLijek.Text = "Dodaj lijek";
            this.btnDodajLijek.UseVisualStyleBackColor = true;
            this.btnDodajLijek.Click += new System.EventHandler(this.btnDodajLijek_Click);
            // 
            // btnAzurirajLijek
            // 
            this.btnAzurirajLijek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzurirajLijek.Location = new System.Drawing.Point(839, 515);
            this.btnAzurirajLijek.Name = "btnAzurirajLijek";
            this.btnAzurirajLijek.Size = new System.Drawing.Size(130, 46);
            this.btnAzurirajLijek.TabIndex = 33;
            this.btnAzurirajLijek.Text = "Ažuriraj lijek";
            this.btnAzurirajLijek.UseVisualStyleBackColor = true;
            this.btnAzurirajLijek.Click += new System.EventHandler(this.btnAzurirajLijek_Click);
            // 
            // btnIzbrisiLijek
            // 
            this.btnIzbrisiLijek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiLijek.Location = new System.Drawing.Point(987, 515);
            this.btnIzbrisiLijek.Name = "btnIzbrisiLijek";
            this.btnIzbrisiLijek.Size = new System.Drawing.Size(130, 46);
            this.btnIzbrisiLijek.TabIndex = 34;
            this.btnIzbrisiLijek.Text = "Izbriši lijek";
            this.btnIzbrisiLijek.UseVisualStyleBackColor = true;
            this.btnIzbrisiLijek.Click += new System.EventHandler(this.btnIzbrisiLijek_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(348, 115);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(103, 37);
            this.btnPretrazi.TabIndex = 35;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(457, 115);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(122, 37);
            this.btnPrikazi.TabIndex = 36;
            this.btnPrikazi.Text = "Prikaži sve";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Eva Oreški\\Desktop\\projekt\\pi22-eoreski-dskaro-hmiskic\\PharmaTech\\Pharma" +
    "Tech\\PharmaTech\\Resources\\PharmaTech.chm";
            // 
            // PregledLijekovaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1139, 588);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.btnIzbrisiLijek);
            this.Controls.Add(this.btnAzurirajLijek);
            this.Controls.Add(this.btnDodajLijek);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvLijekovi);
            this.Controls.Add(this.cmbFiltriranje);
            this.Controls.Add(this.cmbSortiranje);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "PregledLijekovaForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "PregledLijekovaForm";
            this.Load += new System.EventHandler(this.PregledLijekovaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.ComboBox cmbSortiranje;
        private System.Windows.Forms.ComboBox cmbFiltriranje;
        private System.Windows.Forms.DataGridView dgvLijekovi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnDodajLijek;
        private System.Windows.Forms.Button btnAzurirajLijek;
        private System.Windows.Forms.Button btnIzbrisiLijek;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}