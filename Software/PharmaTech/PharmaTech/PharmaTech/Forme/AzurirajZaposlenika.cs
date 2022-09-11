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
    public partial class AzurirajZaposlenika : Form
    {
        zaposlenik odabraniZaposlenik;
        public AzurirajZaposlenika(zaposlenik zaposlenik)
        {
            InitializeComponent();
            odabraniZaposlenik = zaposlenik;
        }

        private void AzurirajZaposlenika_Load(object sender, EventArgs e)
        {
            DohvatiStatuse();
            DohvatiUloge();
            using (var context = new PI2256_DBEntities1())
            {
                txtImePrezime.Text = odabraniZaposlenik.ime_prezime;
                //cmbStatus.SelectedValue = odabraniZaposlenik.status.vrsta_statusa;
                dateRodenja.Value = odabraniZaposlenik.datum_rodenja.Date;
                txtKorime.Text = odabraniZaposlenik.korisnicko_ime.ToString();
                txtLozinka.Text = odabraniZaposlenik.lozinka.ToString();
                txtKontakt.Text = odabraniZaposlenik.kontakt.ToString();
                //cmbUloga.SelectedValue = odabraniZaposlenik.uloga.vrsta_uloge;
            }
        }

        private void DohvatiUloge()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from uloga in context.ulogas
                           select uloga.vrsta_uloge;
                cmbUloga.DataSource = upit.ToList();
            }
        }

        private void DohvatiStatuse()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from status in context.status
                           select status.vrsta_statusa;
                cmbStatus.DataSource = upit.ToList();
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            using (var context = new PI2256_DBEntities1())
            {
                int ulogaZaposlenikaa = 0;
                int statusZaposlenika = 2;

                if (cmbUloga.Text == "Voditelj")
                {
                    ulogaZaposlenikaa = 3;
                }
                else if (cmbUloga.Text == "Magistar farmacije")
                {
                    ulogaZaposlenikaa = 2;
                }
                else
                {
                    ulogaZaposlenikaa = 1;
                }

                if (cmbStatus.Text == "Aktivan")
                {
                    statusZaposlenika = 1;
                }

                context.zaposleniks.Attach(odabraniZaposlenik);

                odabraniZaposlenik.ime_prezime = txtImePrezime.Text;
                odabraniZaposlenik.id_uloge = ulogaZaposlenikaa;
                odabraniZaposlenik.datum_rodenja = dateRodenja.Value.Date;
                odabraniZaposlenik.korisnicko_ime = txtKorime.Text;
                odabraniZaposlenik.lozinka = txtLozinka.Text;
                odabraniZaposlenik.kontakt = txtKontakt.Text;
                odabraniZaposlenik.id_statusa = statusZaposlenika;

                context.SaveChanges();
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
