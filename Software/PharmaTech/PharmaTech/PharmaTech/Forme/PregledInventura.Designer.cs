namespace PharmaTech
{
    partial class PregledInventura
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
            this.btnKreirajInventurniList = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventure = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStavke
            // 
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(574, 138);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(470, 448);
            this.dgvStavke.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 57);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pregled inventura";
            // 
            // btnKreirajInventurniList
            // 
            this.btnKreirajInventurniList.Location = new System.Drawing.Point(892, 592);
            this.btnKreirajInventurniList.Name = "btnKreirajInventurniList";
            this.btnKreirajInventurniList.Size = new System.Drawing.Size(152, 27);
            this.btnKreirajInventurniList.TabIndex = 12;
            this.btnKreirajInventurniList.Text = "Kreiraj inventurni list";
            this.btnKreirajInventurniList.UseVisualStyleBackColor = true;
            this.btnKreirajInventurniList.Click += new System.EventHandler(this.btnKreirajInventurniList_Click_1);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.Transparent;
            this.btnZatvori.Location = new System.Drawing.Point(31, 592);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(152, 27);
            this.btnZatvori.TabIndex = 11;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stavke inventure:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inventure:";
            // 
            // dgvInventure
            // 
            this.dgvInventure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventure.Location = new System.Drawing.Point(31, 138);
            this.dgvInventure.Name = "dgvInventure";
            this.dgvInventure.RowHeadersWidth = 51;
            this.dgvInventure.RowTemplate.Height = 24;
            this.dgvInventure.Size = new System.Drawing.Size(470, 448);
            this.dgvInventure.TabIndex = 8;
            this.dgvInventure.SelectionChanged += new System.EventHandler(this.dgvInventure_SelectionChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmaTech.Properties.Resources.ppp;
            this.pictureBox1.Location = new System.Drawing.Point(31, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Eva Oreški\\Desktop\\pi22-eoreski-dskaro-hmiskic\\PharmaTech\\PharmaTech\\Pha" +
    "rmaTech\\Resources\\PharmaTech.chm";
            // 
            // PregledInventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1092, 631);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKreirajInventurniList);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventure);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "PregledInventura";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Pregled Inventura";
            this.Load += new System.EventHandler(this.PregledInventura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKreirajInventurniList;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventure;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

