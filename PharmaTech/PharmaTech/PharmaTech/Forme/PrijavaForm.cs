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

            Autentifikator.Autentifikacija(korime, lozinka);
            if (Autentifikator.uspjeh)
            {
                GlavnaForm glavnaForm = new GlavnaForm();
                glavnaForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Unijeli ste neispravne podatke!");
            }
        }
    }
}
