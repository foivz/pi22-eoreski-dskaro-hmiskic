using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaTech.Forme
{
    public partial class PrijavaForm : Form
    {
        public string strVar = string.Empty;
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var korime = txtKorime.Text;
            var lozinka = txtLozinka.Text;
            strVar = txtKorime.Text;

            Autentifikator.ValidirajPrijavu(korime, lozinka);
            if (Autentifikator.uspjeh)
            {
                this.Hide();
                GlavnaForm glavnaForm = new GlavnaForm(this);
                glavnaForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Uneseni podaci su neispravni ili je račun neaktivan!");
            }
        }
    }
}
