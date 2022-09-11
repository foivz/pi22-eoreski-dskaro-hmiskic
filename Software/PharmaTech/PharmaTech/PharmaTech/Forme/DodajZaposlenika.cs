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
    public partial class DodajZaposlenika : Form
    {
        public DodajZaposlenika()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajZaposlenika_Load(object sender, EventArgs e)
        {
            DohvatiUloge();
            DohvatiStatuse();
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

        private void DohvatiUloge()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from uloga in context.ulogas
                           select uloga.vrsta_uloge;
                cmbUloga.DataSource = upit.ToList();
            }
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            if (txtImePrezime.Text == "" || txtKorime.Text == "" || txtLozinka.Text == "")
            {
                MessageBox.Show("Molimo vas da popunite prazna polja.");
            }
            else
            {
                using (var context = new PI2256_DBEntities1())
                {
                    int statusZaposlenika = 2;
                    int ulogaZaposlenikaa = 0;
                    if (cmbStatus.Text == "Aktivan")
                    {
                        statusZaposlenika = 1;
                    }

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

                    string imePrezime = txtImePrezime.Text;
                    int ulogaZaposlenika = ulogaZaposlenikaa;
                    DateTime vrijemeRodenja = dateRodenja.Value.Date;
                    string korime = txtKorime.Text;
                    string lozinka = txtLozinka.Text;
                    string kontakt = txtKontakt.Text;
                    int status = statusZaposlenika;

                    zaposlenik noviZaposlenik = new zaposlenik
                    {
                        ime_prezime = imePrezime,
                        id_uloge = ulogaZaposlenika,
                        datum_rodenja = vrijemeRodenja,
                        korisnicko_ime = korime,
                        lozinka = lozinka,
                        kontakt = kontakt,
                        id_statusa = status
                    };

                    context.zaposleniks.Add(noviZaposlenik);
                    context.SaveChanges();
                }
                Close();
            }
            
        }
    }
}
