using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaTech.Forme;

namespace PharmaTech.Forme
{
    public partial class PregledZaposlenika : Form
    {
        public PregledZaposlenika()
        {
            InitializeComponent();
        }

        private void PregledZaposlenika_Load(object sender, EventArgs e)
        {
            dgvPregledZaposlenika.DataSource = null;
            DohvatiZaposlenike();
            dgvPregledZaposlenika.Columns["id_uloge"].Visible = false;
            dgvPregledZaposlenika.Columns["kontakt"].Visible = false;
            dgvPregledZaposlenika.Columns["inventuras"].Visible = false;
            dgvPregledZaposlenika.Columns["narudzbenicas"].Visible = false;
            dgvPregledZaposlenika.Columns["racuns"].Visible = false;
            dgvPregledZaposlenika.Columns["skladisna_primka"].Visible = false;
            dgvPregledZaposlenika.Columns["status"].Visible = false;
            dgvPregledZaposlenika.Columns["uloga"].Visible = false;
            dgvPregledZaposlenika.Columns["lozinka"].Visible = false;
        }

        private void DohvatiZaposlenike()
        {
            using (var context = new PI2256_DBEntities1())
            {
                //return context.zaposleniks.ToList();
                var upit = from zaposlenik in context.zaposleniks
                           join status in context.zaposleniks on zaposlenik.id_statusa equals status.id_statusa
                           join uloga in context.zaposleniks on zaposlenik.id_uloge equals uloga.id_uloge
                           select zaposlenik;
                           //select new
                           //{
                           //    Ime_i_prezime = zaposlenik.ime_prezime,
                           //    Uloga = zaposlenik.uloga.vrsta_uloge,
                           //    Status = zaposlenik.status.vrsta_statusa,
                           //    Kontakt = zaposlenik.kontakt
                           //};
                dgvPregledZaposlenika.DataSource = upit.Distinct().ToList();
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            DodajZaposlenika dodajZaposlenika = new DodajZaposlenika();
            dodajZaposlenika.ShowDialog();
            DohvatiZaposlenike();
        }

        private void btnAzurirajZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvPregledZaposlenika.CurrentRow != null)
            {
                zaposlenik odabraniZaposlenik = dgvPregledZaposlenika.CurrentRow.DataBoundItem as zaposlenik;
                AzurirajZaposlenika azurirajZaposlenika = new AzurirajZaposlenika(odabraniZaposlenik);
                azurirajZaposlenika.ShowDialog();
                DohvatiZaposlenike();
            }
        }
    }
}
