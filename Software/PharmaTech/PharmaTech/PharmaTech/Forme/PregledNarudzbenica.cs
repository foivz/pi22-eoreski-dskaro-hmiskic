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
    public partial class PregledNarudzbenica : Form
    {
        public PregledNarudzbenica()
        {
            InitializeComponent();
        }

        private void btnKreirajNarudzbenicu_Click(object sender, EventArgs e)
        {
            KreirajNarudzbenicucs kreirajNarudzbenicucs = new KreirajNarudzbenicucs();
            kreirajNarudzbenicucs.ShowDialog();
            DogvatiSveNarudzbenice();
        }
    


        private void PregledNarudzbenica_Load(object sender, EventArgs e)
        {
            dgvNarudzbenice.DataSource = null;
            DogvatiSveNarudzbenice();
        }

        private void DogvatiSveNarudzbenice()
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from narudzbenica in context.narudzbenicas
                           join zaposlenik in context.zaposleniks on narudzbenica.id_zaposlenik equals zaposlenik.id_zaposlenik
                           join dobavljac in context.dobavljacs on narudzbenica.id_dobavljac equals dobavljac.id_dobavljac
                           select new
                           {
                               ID_narudzbenice = narudzbenica.id_narudzbenica,
                               Datum = narudzbenica.datum_narudzbe,
                               Zaposlenik = zaposlenik.ime_prezime,
                               Dobavljac = dobavljac.naziv_dobavljaca
                           };


                dgvNarudzbenice.DataSource = upit.ToList();
            }
        }
     

        private void btnZatvori_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvNarudzbenice_SelectionChanged(object sender, EventArgs e)
        {
            var odabrana = dgvNarudzbenice.CurrentRow.Cells[0].Value;
            DohvatiStavkeNarudzbenice((int)odabrana);

        }

        private void DohvatiStavkeNarudzbenice(int odabrana)
        {
            using (var context = new PI2256_DBEntities1())
            {
                var upit = from stavka_narudzbe in context.stavka_narudzbe
                           join lijek in context.lijeks on stavka_narudzbe.id_lijek equals
                                lijek.id_lijek
                           where stavka_narudzbe.id_narudzbenica == odabrana
                           select new
                           {
                               Lijek = lijek.naziv_lijek,
                               Kolicina = stavka_narudzbe.narucena_kolicina,
                               Cijena = lijek.nabavna_cijena,
                               Ukupna_cijena = (stavka_narudzbe.narucena_kolicina * lijek.nabavna_cijena).ToString()

                           };

                dgvStavke.DataSource = upit.ToList();
            }
        }
    }
}
