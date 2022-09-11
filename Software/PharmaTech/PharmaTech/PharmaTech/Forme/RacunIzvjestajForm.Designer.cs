namespace PharmaTech.Forme
{
    partial class RacunIzvjestajForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaracunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsRacun";
            reportDataSource1.Value = this.racunBindingSource;
            reportDataSource2.Name = "DsStavkaRacuna";
            reportDataSource2.Value = this.stavkaracunaBindingSource;
            reportDataSource3.Name = "DsLijek";
            reportDataSource3.Value = this.lijekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PharmaTech.rptRacun.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(479, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(PharmaTech.racun);
            // 
            // stavkaracunaBindingSource
            // 
            this.stavkaracunaBindingSource.DataSource = typeof(PharmaTech.stavka_racuna);
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(PharmaTech.lijek);
            // 
            // RacunIzvjestajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RacunIzvjestajForm";
            this.Text = "Izvjestaj racuna";
            this.Load += new System.EventHandler(this.RacunIzvjestajForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaracunaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.BindingSource stavkaracunaBindingSource;
        private System.Windows.Forms.BindingSource lijekBindingSource;
    }
}